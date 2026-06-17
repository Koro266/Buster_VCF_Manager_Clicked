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
			/// Returns singleton TDF_Eddress constrained by PkEddress.
			/// </summary>
			public class ByPkEddress
			{
				private EddressReader device_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Eddresses.*
					FROM
						TDF_Eddresses
					WHERE
						(((TDF_Eddresses.pk_Eddress) = @pk_eddress ));
				";

				//_______________________________________________________________________________________________________________________________
				public ByPkEddress( int pk_eddress )
				{
					COLUMNS.PK_Eddress pk = new COLUMNS.PK_Eddress( pk_eddress );
					device_Reader = new EddressReader( sql_text, pk.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				public DEVICE_ROW Execute
				{
					get { return device_Reader.ReadEddress(); }
				}
			}
		}
	}
}
