//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.FAMILY.XTAG.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.FAMILY.XTAG.Database.FamilyTagReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XTAG
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns FAMILY.X.Tags constrained by pk_Family.
			/// </summary>
			public class ByPkFamily
			{
				READER family_tag_reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Families_X_Tags.pk_Family_X_Tag,
						TDF_Families_X_Tags.fk_Family,
						TDF_TagsSupertext.pk_Tag,
						TDF_TagsSubtext.pk_Tag,
						TDF_TagsSupertext.st_TagText,
						TDF_TagsSubtext.st_TagText
					FROM
						(
							TDF_Families_X_Tags
							INNER JOIN TDF_TagsSupertext ON TDF_Families_X_Tags.fk_SuperText = TDF_TagsSupertext.pk_Tag
						)
						INNER JOIN TDF_TagsSubtext ON TDF_Families_X_Tags.fk_Subtext = TDF_TagsSubtext.pk_Tag
					WHERE
						(((TDF_Families_X_Tags.fk_Family) = @fk_family))
					ORDER BY
						TDF_TagsSupertext.st_TagText,
						TDF_TagsSubtext.st_TagText;
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkFamily( int pk_family )
				{
					COLUMNS.PK_Family pk_column = new COLUMNS.PK_Family( pk_family );
					family_tag_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return family_tag_reader.ReadFamilyTags(); }
				}
			}
		}
	}
}
