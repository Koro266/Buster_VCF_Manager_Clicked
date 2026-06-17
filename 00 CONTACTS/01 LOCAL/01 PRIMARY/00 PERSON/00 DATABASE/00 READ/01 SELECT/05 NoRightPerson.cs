
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using PERSON_ROW = CONTACTS.LOCAL.PRIMARY.PERSON.Row;

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
			/// Returns singleton TDF_Person constrained by is_NoRightPerson = True.
			/// </summary>
			public class NoRightPerson
			{
				public PersonReader person_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Persons.*
					FROM
						TDF_Persons
					WHERE
						(((TDF_Persons.is_NoRightPerson) = True ));
				";

				//_______________________________________________________________________________________________________________________________
				public NoRightPerson()
				{
					person_Reader = new PersonReader( sql_text );
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
