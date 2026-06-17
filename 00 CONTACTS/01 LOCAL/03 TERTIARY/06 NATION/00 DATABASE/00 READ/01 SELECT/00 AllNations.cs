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
			/// Returns all Country rows currently held in TDF_Countries.
			/// </summary>
			public class AllNations
			{
				private NationReader nation_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Countries.*
					FROM
						TDF_Countries
					ORDER BY 
						TDF_Countries.si_Order;
				";
				//_______________________________________________________________________________________________________________________________
				public AllNations()
				{
					nation_Reader = new NationReader( sql_text );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return nation_Reader.ReadNations(); }
				}
			}
		}
	}
}
