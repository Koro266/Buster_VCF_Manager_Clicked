//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using LIKE				= CONTACTS.GLOBAL.DATABASE.READ.Like;
//LOCAL
using DEVICE_ROW		= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using DEVICE_READER		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.DeviceReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________
		public partial class Like
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns pk_Device and concatenated TDF_Device rows where device Type begins with the given character(s).
			/// </summary>
			public class Type : LIKE
			{
				private readonly string target_field = "st_DeviceType";
				private DEVICE_READER device_reader;

				//___________________________________________________________________________________________________________________________
				public Type( string sought_after_text )
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
