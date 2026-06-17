//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE.Database.GroupWebsiteReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Websites attached to a Group.
			/// </summary>
			public class ByPkGroup
			{
				READER group_website_reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Groups_X_Websites.pk_Group_X_Website,
						TDF_Groups_X_Websites.fk_Group,
						TDF_Groups_X_Websites.fk_Website,
						TDF_Websites.st_Website
					FROM
						TDF_Groups_X_Websites
						INNER JOIN TDF_Websites ON TDF_Groups_X_Websites.fk_Website = TDF_Websites.pk_Website
					WHERE
						(((TDF_Groups_X_Websites.fk_Group) = @fk_group))
					ORDER BY
						TDF_Websites.st_Website;
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkGroup( int pk_group )
				{
					COLUMNS.FK_Group fk_column = new COLUMNS.FK_Group( pk_group );
					group_website_reader = new READER( sql_text, fk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return group_website_reader.ReadGroupWebsites(); }
				}
			}
		}
	}
}
