
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using PERSON_XTAG_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XTAG.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.PERSON.XTAG.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.PERSON.XTAG.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XTAG
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class PersonTagReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public PersonTagReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public PersonTagReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public PERSON_XTAG_ROW ReadPersonTag()
			{
				PERSON_XTAG_ROW person_tag;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					person_tag = ReadRow();

					reader.Close();
					base.Connection.Close();
					return person_tag;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadPersonTags()
			{
				Dictionary<int, BASE_ROW> person_tags = new Dictionary<int, BASE_ROW>();
				PERSON_XTAG_ROW person_tag;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						person_tag = ReadRow();
						person_tags.Add( person_tag.PkPerson_X_Tag.Value, person_tag );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return person_tags;
			}
			//___________________________________________________________________________________________________________________________________________
			private PERSON_XTAG_ROW ReadRow()
			{
				PERSON_XTAG_ROW person_x_tag = new PERSON_XTAG_ROW();

				person_x_tag.Append( new COLUMNS.PK_Person_X_Tag	( base.GetPrimaryKey	( ORDINAL.PkPerson_X_Tag )	) );
				person_x_tag.Append( new COLUMNS.PK_Person			( base.GetForeignKey	( ORDINAL.PkPerson )		) );
				person_x_tag.Append( new COLUMNS.PK_SuperTag		( base.GetForeignKey	( ORDINAL.PkSuperTag )		) );
				person_x_tag.Append( new COLUMNS.PK_SubTag			( base.GetForeignKey	( ORDINAL.PkSubTag )		) );
				person_x_tag.Append( new COLUMNS.ST_SuperTag		( base.GetShortText		( ORDINAL.SuperTag )		) );
				person_x_tag.Append( new COLUMNS.ST_SubTag			( base.GetShortText		( ORDINAL.SubTag )			) );

				return person_x_tag;
			}
		}
	}
}
