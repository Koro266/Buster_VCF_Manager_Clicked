//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.FAMILY.XWEBSITE.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.FAMILY.XWEBSITE.Database.FamilyWebsiteReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XWEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Websites attached to a Family.
			/// </summary>
			public class ByPkFamily
			{
				READER family_website_reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Families_X_Websites.pk_Family_X_Website,
						TDF_Families_X_Websites.fk_Family,
						TDF_Families_X_Websites.fk_Website,
						TDF_Websites.st_Website
					FROM
						TDF_Families_X_Websites
						INNER JOIN TDF_Websites ON TDF_Families_X_Websites.fk_Website = TDF_Websites.pk_Website
					WHERE
						(((TDF_Families_X_Websites.fk_Family) = @fk_family))
					ORDER BY
						TDF_Websites.st_Website;
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkFamily( int pk_family )
				{
					COLUMNS.FK_Family fk_column = new COLUMNS.FK_Family( pk_family );
					family_website_reader = new READER( sql_text, fk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return family_website_reader.ReadFamilyWebsites(); }
				}
			}
		}
	}
}
