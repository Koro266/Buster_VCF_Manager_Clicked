//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.PERSON.XWEBSITE.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.PERSON.XWEBSITE.Database.PersonWebsiteReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XWEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Websites attached to a Person.
			/// </summary>
			public class ByPkPerson
			{
				READER person_website_reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Persons_X_Websites.pk_Person_X_Website,
						TDF_Persons.pk_Person,
						TDF_Websites.pk_Website,
						TDF_Websites.st_Website,
						TDF_Websites.st_Notes
					FROM
						(
							TDF_Persons_X_Websites
							INNER JOIN TDF_Persons ON TDF_Persons_X_Websites.fk_Person = TDF_Persons.pk_Person
						)
						INNER JOIN TDF_Websites ON TDF_Persons_X_Websites.fk_Website = TDF_Websites.pk_Website
					WHERE
						(((TDF_Persons.pk_Person) = [@pk_person]))
					ORDER BY
						TDF_Websites.st_Website;
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkPerson( int pk_person )
				{
					COLUMNS.FK_Person fk_column = new COLUMNS.FK_Person( pk_person );
					person_website_reader = new READER( sql_text, fk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return person_website_reader.ReadPersonWebsites(); }
				}
			}
		}
	}
}
