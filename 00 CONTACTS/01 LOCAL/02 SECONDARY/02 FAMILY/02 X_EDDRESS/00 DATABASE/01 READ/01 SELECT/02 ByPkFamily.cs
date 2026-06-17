//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Database.FamilyEddressReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Eddresses attached to a family.
			/// </summary>
			public class ByPkFamily
			{
				READER family_eddress_reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Families_X_Eddresses.pk_Family_X_Eddress,
						TDF_Families_X_Eddresses.fk_Family,
						TDF_Families_X_Eddresses.fk_Eddress,
						TDF_Eddresses.st_Eddress
					FROM
						TDF_Families_X_Eddresses
						INNER JOIN TDF_Eddresses ON TDF_Families_X_Eddresses.fk_Eddress = TDF_Eddresses.pk_Eddress
					WHERE
						(((TDF_Families_X_Eddresses.fk_Family) = @fk_Family))
					ORDER BY
						TDF_Families_X_Eddresses.st_ListOrder;
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkFamily( int fk_family )
				{
					COLUMNS.FK_Family fk_column = new COLUMNS.FK_Family( fk_family );
					family_eddress_reader = new READER( sql_text, fk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return family_eddress_reader.ReadFamilyEddresses(); }
				}
			}
		}
	}
}
