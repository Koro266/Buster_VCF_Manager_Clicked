//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using COLUMNS	= CONTACTS.LOCAL.PRIMARY.GROUP.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Groups with CurrencyDate >= given date.
			/// </summary>
			public class SelectAfterCurrencyDate
			{
				public GroupReader group_Reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Groups.*   
					FROM 
						TDF_Groups  
					WHERE
						(((TDF_Groups.dt_CurrencyDate) >= @dt_currencydate));
				";

				//_______________________________________________________________________________________________________________________________
				public SelectAfterCurrencyDate( DateTime after_date )
				{
					COLUMNS.DT_CurrencyDate dt = new COLUMNS.DT_CurrencyDate( after_date );
					group_Reader = new GroupReader( sql_text, dt.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return group_Reader.ReadGroups(); }
				}
			}
		}
	}
}
