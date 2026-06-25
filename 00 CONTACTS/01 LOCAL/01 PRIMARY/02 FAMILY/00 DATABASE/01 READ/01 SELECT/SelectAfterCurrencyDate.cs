//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using COLUMNS	= CONTACTS.LOCAL.PRIMARY.FAMILY.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Families with CurrencyDate >= given date.
			/// </summary>
			public class SelectAfterCurrencyDate
			{
				public FamilyReader family_Reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Families.*   
					FROM 
						TDF_Families  
					WHERE
						(((TDF_Families.dt_CurrencyDate) >= @dt_currencydate));
				";

				//_______________________________________________________________________________________________________________________________
				public SelectAfterCurrencyDate( DateTime after_date )
				{
					COLUMNS.DT_CurrencyDate dt = new COLUMNS.DT_CurrencyDate( after_date );
					family_Reader = new FamilyReader( sql_text, dt.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return family_Reader.ReadFamilies(); }
				}
			}
		}
	}
}
