//___________________________________________________________________________________________________________________________________________________
using COUNT		= CONTACTS.GLOBAL.DATABASE.READ.Count;
using COLUMNS	= CONTACTS.LOCAL.PRIMARY.GROUP.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Count
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Counts the number of Groups with CurrencyDate >= given date.
			/// </summary>
			public class CountAfterCurrencyDate : COUNT
			{
				private const string sql_text =
				@"
					SELECT
						Count(pk_Group) AS ROWCOUNT
					FROM
						TDF_Groups
					WHERE
					(
						(
							(TDF_Groups.dt_CurrencyDate) >= @dt_currencydate 
						)
					);
				";

				//_______________________________________________________________________________________________________________________________
				public CountAfterCurrencyDate( DateTime after_date ) : base( sql_text )
				{
					COLUMNS.DT_CurrencyDate dt = new COLUMNS.DT_CurrencyDate( after_date );
					base.DbCommand.Parameters.Add( dt.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				public int Execute
				{
					get { return base.RowCount; } 
				}
			}
		}
	}
}
