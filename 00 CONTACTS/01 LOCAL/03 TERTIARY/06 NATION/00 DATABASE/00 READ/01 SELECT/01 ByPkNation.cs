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
			/// Returns singleton TDF_Countries constrained by pk_Country.
			/// </summary>
			public class ByPkNation
			{
				private NationReader nation_Reader; 
				private const string sql_text =
				@"
					SELECT
						TDF_Countries.*
					FROM
						TDF_Countries
					WHERE
						(((TDF_Countries.pk_Country) = @pk_country ));
				";

				//_______________________________________________________________________________________________________________________________
				public ByPkNation( int pk_nation )
				{
					COLUMNS.PK_Country pk = new COLUMNS.PK_Country( pk_nation );
					nation_Reader = new NationReader( sql_text, pk.DbParameter );
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
