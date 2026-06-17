//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using NATION_ROW	= CONTACTS.LOCAL.TERTIARY.NATION.Row;
using COLUMNS		= CONTACTS.LOCAL.TERTIARY.NATION.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.NATION
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns singleton TDF_Countries constrained by DefaultRow = True.
			/// </summary>
			public class DefaultNation
			{
				private NationReader nation_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Countries.*
					FROM
						TDF_Countries
					WHERE
						(((TDF_Countries.is_DefaultRow) = True ));
				";

				//_______________________________________________________________________________________________________________________________
				public DefaultNation()
				{
					nation_Reader = new NationReader( sql_text );
				}
				//_______________________________________________________________________________________________________________________________
				public NATION_ROW Execute
				{
					get { return nation_Reader.ReadNation(); }
				}
			}
		}
	}
}
