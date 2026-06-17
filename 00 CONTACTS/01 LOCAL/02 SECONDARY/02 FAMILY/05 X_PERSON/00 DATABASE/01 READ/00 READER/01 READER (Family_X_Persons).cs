
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using FAMILY_XPERSON_ROW	= CONTACTS.LOCAL.SECONDARY.FAMILY.XPERSON.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.FAMILY.XPERSON.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.FAMILY.XPERSON.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XPERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class FamilyPersonReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public FamilyPersonReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public FamilyPersonReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public FAMILY_XPERSON_ROW ReadFamilyPerson()
			{
				FAMILY_XPERSON_ROW family_person;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					family_person = ReadRow();

					reader.Close();
					base.Connection.Close();
					return family_person;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadFamilyPersons()
			{
				Dictionary<int, BASE_ROW> family_persons = new Dictionary<int, BASE_ROW>();
				FAMILY_XPERSON_ROW family_person;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						family_person = ReadRow();
						family_persons.Add( family_person.PkFamily_X_Person.Value, family_person );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return family_persons;
			}
			//___________________________________________________________________________________________________________________________________________
			private FAMILY_XPERSON_ROW ReadRow()
			{
				FAMILY_XPERSON_ROW family_person = new FAMILY_XPERSON_ROW();

				family_person.Append( new COLUMNS.PK_Family_X_Person	( base.GetPrimaryKey	( ORDINAL.PkFamily_X_Person )	) );
				family_person.Append( new COLUMNS.PK_Family				( base.GetForeignKey	( ORDINAL.PkFamily )			) );
				family_person.Append( new COLUMNS.PK_Person				( base.GetForeignKey	( ORDINAL.PkPerson )			) );
				family_person.Append( new COLUMNS.PK_Role				( base.GetForeignKey	( ORDINAL.PkRole )				) );
				family_person.Append( new COLUMNS.ST_PersonName			( base.GetShortText		( ORDINAL.PersonName )			) );
				family_person.Append( new COLUMNS.ST_Role				( base.GetShortText		( ORDINAL.Role )				) );

				return family_person;
			}
		}
	}
}
