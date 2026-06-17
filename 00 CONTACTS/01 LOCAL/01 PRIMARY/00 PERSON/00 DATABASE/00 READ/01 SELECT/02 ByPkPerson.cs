//___________________________________________________________________________________________________________________________________________________
//LOCAL
using PERSON_ROW = CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using COLUMNS = CONTACTS.LOCAL.PRIMARY.PERSON.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns singleton TDF_Person constrained by PkPerson.
			/// </summary>
			public class ByPkPerson
			{
				public PersonReader person_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Persons.pk_Person,
						TDF_Persons.st_SortableName,
						TDF_Persons.st_NaturalName,
						TDF_Persons.st_UpperSurname,
						TDF_Persons.st_ProperSurname,
						TDF_Persons.st_GivenName,
						TDF_Persons.st_MiddleNames,
						TDF_Persons.st_NickName,
						TDF_Persons.st_BirthName,
						TDF_Persons.st_Prefix,
						TDF_Persons.st_Suffix,
						TDF_Persons.st_Initials,
						TDF_Persons.st_Gender,
						TDF_Persons.st_Notes,
						TDF_Persons.dt_BirthDate,
						TDF_Persons.dt_DeathDate,
						TDF_Persons.dt_WeddingDate,
						TDF_Persons.dt_CurrencyDate
					FROM
						TDF_Persons
					WHERE
						(((TDF_Persons.pk_Person) = @pk_person ));
				";

				//_______________________________________________________________________________________________________________________________
				public ByPkPerson( int pk_person )
				{
					COLUMNS.PK_Person pk_column = new COLUMNS.PK_Person( pk_person );
					person_Reader = new PersonReader( sql_text, pk_column.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				public PERSON_ROW Execute
				{
					get { return person_Reader.ReadPerson(); }
				}
			}
		}
	}
}
