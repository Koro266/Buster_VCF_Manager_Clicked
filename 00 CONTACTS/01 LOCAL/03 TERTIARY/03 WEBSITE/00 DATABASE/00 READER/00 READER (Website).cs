//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER	= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using WEBSITE_ROW	= CONTACTS.LOCAL.TERTIARY.WEBSITE.Row;
using FIELD			= CONTACTS.LOCAL.TERTIARY.WEBSITE.Column;
using ORDINAL		= CONTACTS.LOCAL.TERTIARY.WEBSITE.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.WEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class WebsiteReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public WebsiteReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public WebsiteReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public WEBSITE_ROW ReadWebsite()
			{
				WEBSITE_ROW website;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					website = ReadRow();

					reader.Close();
					base.Connection.Close();
					return website;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadWebsites()
			{
				Dictionary<int, BASE_ROW> all_websites = new Dictionary<int, BASE_ROW>();
				WEBSITE_ROW website;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						website = ReadRow();
						all_websites.Add( website.PkWebsite.Value, website );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return all_websites;
			}
			//___________________________________________________________________________________________________________________________________________
			private WEBSITE_ROW ReadRow()
			{
				WEBSITE_ROW website = new WEBSITE_ROW();

				website.Append( new FIELD.PK_Website	( base.GetPrimaryKey	( ORDINAL.PkWebsite ) ) );
				website.Append( new FIELD.ST_Website	( base.GetShortText		( ORDINAL.Website ) ) );
				website.Append( new FIELD.ST_Notes		( base.GetShortText		( ORDINAL.Notes ) ) );

				return website;
			}
		}
	}
}
