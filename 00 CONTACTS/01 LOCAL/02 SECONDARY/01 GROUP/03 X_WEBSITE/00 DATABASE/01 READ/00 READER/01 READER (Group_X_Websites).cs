
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using GROUP_XWEBSITE_ROW	= CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class GroupWebsiteReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public GroupWebsiteReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public GroupWebsiteReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public GROUP_XWEBSITE_ROW ReadGroupWebsite()
			{
				GROUP_XWEBSITE_ROW group_website;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					group_website = ReadRow();

					reader.Close();
					base.Connection.Close();
					return group_website;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadGroupWebsites()
			{
				Dictionary<int, BASE_ROW> group_websites = new Dictionary<int, BASE_ROW>();
				GROUP_XWEBSITE_ROW group_website;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						group_website = ReadRow();
						group_websites.Add( group_website.PkGroup_X_Website.Value, group_website );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return group_websites;
			}
			//___________________________________________________________________________________________________________________________________________
			private GROUP_XWEBSITE_ROW ReadRow()
			{
				GROUP_XWEBSITE_ROW group_x_website = new GROUP_XWEBSITE_ROW();

				group_x_website.Append( new COLUMNS.PK_Group_X_Website		( base.GetPrimaryKey	( ORDINAL.PkGroup_X_Website )	) );
				group_x_website.Append( new COLUMNS.FK_Group				( base.GetForeignKey	( ORDINAL.FkGroup )				) );
				group_x_website.Append( new COLUMNS.FK_Website				( base.GetForeignKey	( ORDINAL.FkWebsite )			) );
				group_x_website.Append( new COLUMNS.ST_Website				( base.GetShortText		( ORDINAL.Website )				) );

				return group_x_website;
			}
		}
	}
}
