//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
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
			/// Returns all TDF_Eddress rows currently held in TDF_Devices.
			/// </summary>
			public class AllEddresses
			{
				private EddressReader eddress_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Eddresses.*
					FROM
						TDF_Eddresses
					ORDER BY
						TDF_Eddresses.pk_Eddress;
				";
				//_______________________________________________________________________________________________________________________________
				public AllEddresses()
				{
					eddress_Reader = new EddressReader( sql_text );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return eddress_Reader.ReadEddresses(); }
				}
			}
		}
	}
}
