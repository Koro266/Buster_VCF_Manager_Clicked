//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using LIKE			= CONTACTS.GLOBAL.DATABASE.READ.Like;
//LOCAL
using DEVICE_READER	= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.DeviceReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________
		public partial class Like
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// PreFind is intended to avoid duplicating device numbers that are already present in the Devices table.
			/// </summary>
			public class PreFindList : LIKE
			{
				private DEVICE_READER device_reader;
				private readonly string target_field = "st_TrailingDigits";
				private const string sql_text =
				@"
					SELECT
						TDF_Devices.st_DialNumber
					FROM
						TDF_Devices
					WHERE
						(((TDF_Devices.st_TrailingDigits) = LIKE @subtext))
					ORDER BY
						TDF_Devices.st_DialNumber;
				";
				//___________________________________________________________________________________________________________________________
				public PreFindList( string sought_after_text )
				{
					string sql_text = PrepareSQL( target_field );
					OleDbParameter parameter = PrepareParameter( sql_text, sought_after_text );
					device_reader = new DEVICE_READER( sql_text, parameter );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return device_reader.ReadDevices(); }
				}
			}
		}
	}
}
