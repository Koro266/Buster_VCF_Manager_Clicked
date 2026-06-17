
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER	= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using PERSON_ROW	= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using FIELD			= CONTACTS.LOCAL.PRIMARY.PERSON.Column;
using ORDINAL		= CONTACTS.LOCAL.PRIMARY.PERSON.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class PersonReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public PersonReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public PersonReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public PERSON_ROW ReadPerson()
			{
				PERSON_ROW person;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					person = ReadRow();

					reader.Close();
					base.Connection.Close();
					return person;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadPersons()
			{
				Dictionary<int, BASE_ROW> all_persons = new Dictionary<int, BASE_ROW>();
				PERSON_ROW person;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						person = ReadRow();
						all_persons.Add( person.PkPerson.Value, person );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return all_persons;
			}
			//___________________________________________________________________________________________________________________________________________
			private PERSON_ROW ReadRow()
			{
				PERSON_ROW person = new PERSON_ROW();

				person.Append( new FIELD.PK_Person			( base.GetPrimaryKey	( ORDINAL.PkPerson)		 ) );
				person.Append( new FIELD.ST_SortableName	( base.GetShortText		( ORDINAL.SortableName)	 ) );
				person.Append( new FIELD.ST_NaturalName		( base.GetShortText		( ORDINAL.NaturalName)	 ) );
				person.Append( new FIELD.ST_UpperSurname	( base.GetShortText		( ORDINAL.UpperSurname)	 ) );
				person.Append( new FIELD.ST_ProperSurname	( base.GetShortText		( ORDINAL.ProperSurname) ) );
				person.Append( new FIELD.ST_GivenName		( base.GetShortText		( ORDINAL.GivenName)	 ) );
				person.Append( new FIELD.ST_MiddleNames		( base.GetShortText		( ORDINAL.MiddleNames)	 ) );
				person.Append( new FIELD.ST_NickName		( base.GetShortText		( ORDINAL.NickName)		 ) );
				person.Append( new FIELD.ST_BirthName		( base.GetShortText		( ORDINAL.BirthName)	 ) );
				person.Append( new FIELD.ST_Prefix			( base.GetShortText		( ORDINAL.Prefix)		 ) );
				person.Append( new FIELD.ST_Suffix			( base.GetShortText		( ORDINAL.Suffix)		 ) );
				person.Append( new FIELD.ST_Initials		( base.GetShortText		( ORDINAL.Initials)		 ) );
				person.Append( new FIELD.ST_Gender			( base.GetShortText		( ORDINAL.Gender)		 ) );
				person.Append( new FIELD.ST_Notes			( base.GetShortText		( ORDINAL.Notes)		 ) );
				person.Append( new FIELD.DT_BirthDate		( base.GetDateTime		( ORDINAL.BirthDate)	 ) );
				person.Append( new FIELD.DT_DeathDate		( base.GetDateTime		( ORDINAL.DeathDate)	 ) );
				person.Append( new FIELD.DT_WeddingDate		( base.GetDateTime		( ORDINAL.WeddingDate)	 ) );
				person.Append( new FIELD.DT_CurrencyDate	( base.GetDateTime		( ORDINAL.CurrencyDate)	 ) );

				return person;
			}
		}
	}
}