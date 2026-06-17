//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;

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
			/// Returns all TDF_Person rows currently held in TDF_Persons ordered by pk_Person.
			/// </summary>
			public class AllPersons
			{
				public PersonReader person_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Persons.*
					FROM
						TDF_Persons
					ORDER BY
						TDF_Persons.pk_Person;
				";
				//_______________________________________________________________________________________________________________________________
				public AllPersons()
				{
					person_Reader = new PersonReader( sql_text );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return person_Reader.ReadPersons(); }
				}
			}
		}
	}
}
