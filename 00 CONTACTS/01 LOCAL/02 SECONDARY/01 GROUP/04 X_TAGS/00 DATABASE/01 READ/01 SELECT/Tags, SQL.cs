//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.GROUP.XTAG.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.GROUP.XTAG.Database.GroupTagReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XTAG
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns GROUP.X.Tags constrained by pk_Group.
			/// </summary>
			public class ByPkGroup
			{
				READER group_tag_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Groups_X_Tags.pk_Group_X_Tag,
						TDF_Groups.pk_Group,
						TDF_TagsSupertext.pk_Tag,
						TDF_TagsSubtext.pk_Tag,
						TDF_TagsSupertext.st_TagText,
						TDF_TagsSubtext.st_TagText 
					FROM 
						(
							(
								TDF_Groups 
								INNER JOIN TDF_Groups_X_Tags ON TDF_Groups.pk_Group = TDF_Groups_X_Tags.fk_Group
							)
							INNER JOIN TDF_TagsSupertext ON TDF_Groups_X_Tags.fk_SuperText = TDF_TagsSupertext.pk_Tag
						)
						INNER JOIN TDF_TagsSubtext ON TDF_Groups_X_Tags.fk_Subtext = TDF_TagsSubtext.pk_Tag 
					WHERE 
						(((TDF_Groups.pk_Group) = @pk_group)) 
					ORDER BY
						TDF_TagsSupertext.st_TagText,
						TDF_TagsSubtext.st_TagText;
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkGroup( int pk )
				{
					COLUMNS.PK_Group pk_column = new COLUMNS.PK_Group( pk );
					group_tag_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public ByPkGroup( OleDbParameter parameter )
				{
					group_tag_reader = new READER( sql_text, parameter );
				}
				//___________________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return group_tag_reader.ReadGroupTags(); }
				}
			}
		}
	}
}
