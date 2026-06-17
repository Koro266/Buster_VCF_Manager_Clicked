//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using SELECT		= CONTACTS.GLOBAL.DATABASE.READ.Select;
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.EDDRESS.Row;
using COLUMNS		= CONTACTS.LOCAL.TERTIARY.EDDRESS.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.EDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns singleton TDF_Eddress constrained by DefaultRow = True.
			/// </summary>
			public class DefaultEddress
			{
				private EddressReader eddress_reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Devices.*
					FROM
						TDF_Devices
					WHERE
						(((TDF_Devices.is_DefaultRow) = True ));
				";

				//_______________________________________________________________________________________________________________________________
				public DefaultEddress()
				{
					eddress_reader = new EddressReader( sql_text );
				}
				//_______________________________________________________________________________________________________________________________
				public DEVICE_ROW Execute
				{
					get { return eddress_reader.ReadEddress(); }
				}
			}
		}
	}
}
