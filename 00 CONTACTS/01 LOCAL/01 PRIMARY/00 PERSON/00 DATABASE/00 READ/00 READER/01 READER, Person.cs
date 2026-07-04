
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
using static CONTACTS.LOCAL.PRIMARY.PERSON.Column;

//GLOBAL
using BASE_READER	= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using FIELD			= CONTACTS.LOCAL.PRIMARY.PERSON.Column;
using ORDINAL		= CONTACTS.LOCAL.PRIMARY.PERSON.Constants.OrdinalByName;
using PERSON_ROW	= CONTACTS.LOCAL.PRIMARY.PERSON.Row;

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

				person.Append( new FIELD.PK_Person			( base.GetPrimaryKey	( ORDINAL.PkPerson)			) );
				person.Append( new FIELD.ST_SortableName	( base.GetText			( ORDINAL.SortableName)		) );
				person.Append( new FIELD.ST_NaturalName		( base.GetText			( ORDINAL.NaturalName)		) );
				person.Append( new FIELD.ST_UpperSurname	( base.GetText			( ORDINAL.UpperSurname)		) );
				person.Append( new FIELD.ST_ProperSurname	( base.GetText			( ORDINAL.ProperSurname)	) );
				person.Append( new FIELD.ST_GivenName		( base.GetText			( ORDINAL.GivenName)		) );
				person.Append( new FIELD.ST_MiddleNames		( base.GetText			( ORDINAL.MiddleNames)		) );
				person.Append( new FIELD.ST_NickName		( base.GetText			( ORDINAL.NickName)			) );
				person.Append( new FIELD.ST_BirthName		( base.GetText			( ORDINAL.BirthName)		) );
				person.Append( new FIELD.ST_Prefix			( base.GetText			( ORDINAL.Prefix)			) );
				person.Append( new FIELD.ST_Suffix			( base.GetText			( ORDINAL.Suffix)			) );
				person.Append( new FIELD.ST_Initials		( base.GetText			( ORDINAL.Initials)			) );
				person.Append( new FIELD.ST_Gender			( base.GetText			( ORDINAL.Gender)			) );
				person.Append( new FIELD.ST_Notes			( base.GetText			( ORDINAL.Notes)			) );
				person.Append( new FIELD.DT_BirthDate		( base.GetDateTime		( ORDINAL.BirthDate)		) );
				person.Append( new FIELD.DT_DeathDate		( base.GetDateTime		( ORDINAL.DeathDate)		) );
				person.Append( new FIELD.DT_WeddingDate		( base.GetDateTime		( ORDINAL.WeddingDate)		) );
				person.Append( new FIELD.DT_CurrencyDate	( base.GetDateTime		( ORDINAL.CurrencyDate)		) );
				person.Append( new FIELD.LI_EHS_Order		( base.GetInt32			( ORDINAL.EHS_Order)		) );
				person.Append( new FIELD.IS_Selected		( base.GetBoolean		( ORDINAL.Selected)			) );
				person.Append( new FIELD.IS_DefaultRow		( base.GetBoolean		( ORDINAL.DefaultRow)		) );
				person.Append( new FIELD.IS_Export			( base.GetBoolean		( ORDINAL.Export)			) );
				person.Append( new FIELD.IS_Blocked			( base.GetBoolean		( ORDINAL.Blocked)			) );
				person.Append( new FIELD.IS_Inactive		( base.GetBoolean		( ORDINAL.Inactive)			) );
				person.Append( new FIELD.IS_NewLeftPerson	( base.GetBoolean		( ORDINAL.NewLeftPerson)	) );
				person.Append( new FIELD.IS_NoRightPerson	( base.GetBoolean		( ORDINAL.NoRightPerson)	) );
				person.Append( new FIELD.IS_Enlightened		( base.GetBoolean		( ORDINAL.Enlightened)		) );
				person.Append( new FIELD.IS_HolySomething	( base.GetBoolean		( ORDINAL.HolySomething)	) );
				person.Append( new FIELD.IS_StTheresa		( base.GetBoolean		( ORDINAL.StTheresa)		) );
				person.Append( new FIELD.IS_TimeTalent		( base.GetBoolean		( ORDINAL.TimeTalent)		) );
				person.Append( new FIELD.IS_Minister		( base.GetBoolean		( ORDINAL.Minister)			) );
				person.Append( new FIELD.IS_Sacristan		( base.GetBoolean		( ORDINAL.Sacristan)		) );
				person.Append( new FIELD.IS_Vigil			( base.GetBoolean		( ORDINAL.Vigil)			) );
				person.Append( new FIELD.IS_Mass			( base.GetBoolean		( ORDINAL.Mass)				) );

				return person;
			}
		}
	}
}