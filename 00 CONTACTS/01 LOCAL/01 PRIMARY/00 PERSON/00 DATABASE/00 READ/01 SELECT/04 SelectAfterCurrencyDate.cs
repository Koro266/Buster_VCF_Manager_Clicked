//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using COLUMNS	= CONTACTS.LOCAL.PRIMARY.PERSON.Column;

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
			/// Returns Persons with CurrencyDate >= given date.
			/// </summary>
			public class SelectAfterCurrencyDate
			{
				public PersonReader person_Reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Persons.*   
					FROM 
						TDF_Persons  
					WHERE
						(((TDF_Persons.dt_CurrencyDate)>=@currency_date));
				";

				//_______________________________________________________________________________________________________________________________
				public SelectAfterCurrencyDate( DateTime after_date )
				{
					COLUMNS.DT_CurrencyDate dt = new COLUMNS.DT_CurrencyDate( after_date );
					person_Reader = new PersonReader( sql_text, dt.DbParameter );
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
