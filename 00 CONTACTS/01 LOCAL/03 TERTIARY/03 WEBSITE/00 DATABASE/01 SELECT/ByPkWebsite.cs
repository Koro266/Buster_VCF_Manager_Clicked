//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using SELECT		= CONTACTS.GLOBAL.DATABASE.READ.Select;
//LOCAL
using WEBSITE_ROW	= CONTACTS.LOCAL.TERTIARY.WEBSITE.Row;
using COLUMNS		= CONTACTS.LOCAL.TERTIARY.WEBSITE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.WEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns singleton TDF_Website constrained by PkWebsite.
			/// </summary>
			public class ByPkWebsite
			{
				private WebsiteReader website_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Websites.*
					FROM
						TDF_Websites
					WHERE
						(((TDF_Websites.pk_Website) = @pk_website ));
				";

				//_______________________________________________________________________________________________________________________________
				public ByPkWebsite( int pk_eddress )
				{
					COLUMNS.PK_Website pk = new COLUMNS.PK_Website( pk_eddress );
					website_Reader = new WebsiteReader( sql_text, pk.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				public WEBSITE_ROW Execute
				{
					get { return website_Reader.ReadWebsite(); }
				}
			}
		}
	}
}
