
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using PERSON_XWEBSITE_ROW	= CONTACTS.LOCAL.SECONDARY.PERSON.XWEBSITE.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.PERSON.XWEBSITE.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.PERSON.XWEBSITE.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XWEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class PersonWebsiteReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public PersonWebsiteReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public PersonWebsiteReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public PERSON_XWEBSITE_ROW ReadPersonWebsite()
			{
				PERSON_XWEBSITE_ROW person_website;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					person_website = ReadRow();

					reader.Close();
					base.Connection.Close();
					return person_website;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadPersonWebsites()
			{
				Dictionary<int, BASE_ROW> person_websites = new Dictionary<int, BASE_ROW>();
				PERSON_XWEBSITE_ROW person_website;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						person_website = ReadRow();
						person_websites.Add( person_website.PkPerson_X_Website.Value, person_website );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return person_websites;
			}
			//___________________________________________________________________________________________________________________________________________
			private PERSON_XWEBSITE_ROW ReadRow()
			{
				PERSON_XWEBSITE_ROW person_x_website = new PERSON_XWEBSITE_ROW();

				person_x_website.Append( new COLUMNS.PK_Person_X_Website	( base.GetPrimaryKey	( ORDINAL.PkPerson_X_Website )	) );
				person_x_website.Append( new COLUMNS.FK_Person				( base.GetForeignKey	( ORDINAL.FkPerson )			) );
				person_x_website.Append( new COLUMNS.FK_Website				( base.GetForeignKey	( ORDINAL.FkWebsite )			) );
				person_x_website.Append( new COLUMNS.ST_Website				( base.GetShortText		( ORDINAL.Website )				) );
				person_x_website.Append( new COLUMNS.ST_Notes				( base.GetShortText		( ORDINAL.Notes )				) );


				return person_x_website;
			}
		}
	}
}
