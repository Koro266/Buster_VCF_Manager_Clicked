//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;

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
			/// Returns all TDF_Website rows currently held in TDF_Websites.
			/// </summary>
			public class AllWebsites
			{
				private WebsiteReader website_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Websites.*
					FROM
						TDF_Websites;
				";
				//_______________________________________________________________________________________________________________________________
				public AllWebsites()
				{
					website_Reader = new WebsiteReader( sql_text );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return website_Reader.ReadWebsites(); }
				}
			}
		}
	}
}
