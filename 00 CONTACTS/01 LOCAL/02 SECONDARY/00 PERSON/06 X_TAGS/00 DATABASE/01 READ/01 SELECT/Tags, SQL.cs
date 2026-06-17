//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.PERSON.XTAG.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.PERSON.XTAG.Database.PersonTagReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XTAG
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns PERSON.X.Tags constrained by pk_Person.
			/// </summary>
			public class ByPkPerson
			{
				READER person_tag_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Persons_X_Tags.pk_Person_X_Tag,
						TDF_Persons.pk_Person,
						TDF_TagsSupertext.pk_Tag,
						TDF_TagsSubtext.pk_Tag,
						TDF_TagsSupertext.st_TagText,
						TDF_TagsSubtext.st_TagText 
					FROM 
						(
							(
								TDF_Persons 
								INNER JOIN TDF_Persons_X_Tags ON TDF_Persons.pk_Person = TDF_Persons_X_Tags.fk_Person
							)
							INNER JOIN TDF_TagsSupertext ON TDF_Persons_X_Tags.fk_SuperText = TDF_TagsSupertext.pk_Tag
						)
						INNER JOIN TDF_TagsSubtext ON TDF_Persons_X_Tags.fk_Subtext = TDF_TagsSubtext.pk_Tag 
					WHERE 
						(((TDF_Persons.pk_Person) = @pk_person)) 
					ORDER BY
						TDF_TagsSupertext.st_TagText,
						TDF_TagsSubtext.st_TagText;
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkPerson( int pk )
				{
					COLUMNS.PK_Person pk_column = new COLUMNS.PK_Person( pk );
					person_tag_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public ByPkPerson( OleDbParameter parameter )
				{
					person_tag_reader = new READER( sql_text, parameter );
				}
				//___________________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return person_tag_reader.ReadPersonTags(); }
				}
			}
		}
	}
}
