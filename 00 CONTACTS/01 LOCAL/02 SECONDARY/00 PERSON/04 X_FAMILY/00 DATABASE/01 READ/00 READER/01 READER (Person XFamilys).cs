
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using PERSON_XFAMILY_ROW	= CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class PersonFamilyReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public PersonFamilyReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public PersonFamilyReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public PERSON_XFAMILY_ROW ReadPersonFamily()
			{
				PERSON_XFAMILY_ROW person_family;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					person_family = ReadRow();

					reader.Close();
					base.Connection.Close();
					return person_family;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadPersonFamilys()
			{
				Dictionary<int, BASE_ROW> person_familys = new Dictionary<int, BASE_ROW>();
				PERSON_XFAMILY_ROW person_family;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						person_family = ReadRow();
						person_familys.Add( person_family.PkPerson_X_Family.Value, person_family );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return person_familys;
			}
			//___________________________________________________________________________________________________________________________________________
			private PERSON_XFAMILY_ROW ReadRow()
			{
				PERSON_XFAMILY_ROW person_family = new PERSON_XFAMILY_ROW();

				person_family.Append( new COLUMNS.PK_Person_X_Family	( base.GetPrimaryKey	( ORDINAL.PkPerson_X_Family )	) );
				person_family.Append( new COLUMNS.PK_Person				( base.GetForeignKey	( ORDINAL.PkPerson )			) );
				person_family.Append( new COLUMNS.PK_Family				( base.GetForeignKey	( ORDINAL.PkFamily )			) );
				person_family.Append( new COLUMNS.PK_Role				( base.GetForeignKey	( ORDINAL.PkRole )				) );
				person_family.Append( new COLUMNS.ST_FamilyName			( base.GetShortText		( ORDINAL.FamilyName )			) );
				person_family.Append( new COLUMNS.ST_Role				( base.GetShortText		( ORDINAL.Role )				) );

				return person_family;
			}
		}
	}
}
