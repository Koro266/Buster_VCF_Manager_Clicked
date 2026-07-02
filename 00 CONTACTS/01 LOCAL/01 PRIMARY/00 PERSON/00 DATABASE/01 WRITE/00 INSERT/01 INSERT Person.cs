//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using DB_CONNECTION = CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnection;
//LOCAL
using PERSON_ROW = CONTACTS.LOCAL.PRIMARY.PERSON.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//_______________________________________________________________________________________________________________________________________
		public class Insert
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// INSERTs new, fully-qualified TDF_Person. Returns the PK of the INSERTed row.
			/// </summary>
			public class Person : DB_CONNECTION
			{
				private const string sql_text =
				@"		
					INSERT INTO TDF_Persons	
					( 
						st_SortableName, 
						st_NaturalName, 
						st_UpperSurname, 
						st_ProperSurname, 
						st_GivenName, 
						st_MiddleNames, 
						st_NickName, 
						st_BirthName, 
						st_Prefix, 
						st_Suffix, 
						st_Initials, 
						st_Gender, 
						st_Notes, 
						dt_BirthDate, 
						dt_DeathDate, 
						dt_WeddingDate, 
						dt_CurrencyDate,
						is_Selected,
						is_Enlightened,
						is_HolySomething,
						is_NewLeftPerson,
						is_NoRightPerson,
						is_DefaultRow,
						is_Export,
						is_TimeTalent,
						is_Minister,
						is_Sacristan,
						is_Vigil,
						is_Mass
					) 
					VALUES 
					( 
						@st_sortablename, 
						@st_naturalname, 
						@st_uppersurname, 
						@st_propersurname, 
						@st_givenname, 
						@st_middlenames, 
						@st_nickname, 
						@st_birthname, 
						@st_prefix, 
						@st_suffix, 
						@st_initials, 
						@st_gender, 
						@st_notes, 
						@dt_birthdate, 
						@dt_deathdate, 
						@dt_weddingdate, 
						@dt_currencydate, 
						@is_selected,
						@is_enlightened,
						@is_holysomething,
						@is_newleftperson,
						@is_norightperson,
						@is_defaultrow,
						@is_export,
						@is_timetalent,
						@is_minister,
						@is_sacristan,
						@is_vigil,
						@is_mass
					);
				";
				//_______________________________________________________________________________________________________________________________
				public Person( PERSON_ROW person ) : base( sql_text )
				{
					base.DbCommand.Parameters.Add( person.SortableName.DbParameter );
					base.DbCommand.Parameters.Add( person.NaturalName.DbParameter );
					base.DbCommand.Parameters.Add( person.UpperSurname.DbParameter );
					base.DbCommand.Parameters.Add( person.ProperSurname.DbParameter );
					base.DbCommand.Parameters.Add( person.GivenName.DbParameter );
					base.DbCommand.Parameters.Add( person.MiddleNames.DbParameter );
					base.DbCommand.Parameters.Add( person.NickName.DbParameter );
					base.DbCommand.Parameters.Add( person.BirthName.DbParameter );
					base.DbCommand.Parameters.Add( person.Prefix.DbParameter );
					base.DbCommand.Parameters.Add( person.Suffix.DbParameter );
					base.DbCommand.Parameters.Add( person.Initials.DbParameter );
					base.DbCommand.Parameters.Add( person.Gender.DbParameter );
					base.DbCommand.Parameters.Add( person.Notes.DbParameter );
					base.DbCommand.Parameters.Add( person.BirthDate.DbParameter );
					base.DbCommand.Parameters.Add( person.DeathDate.DbParameter );
					base.DbCommand.Parameters.Add( person.WeddingDate.DbParameter );
					base.DbCommand.Parameters.Add( person.CurrencyDate.DbParameter );
					base.DbCommand.Parameters.Add( person.Selected.DbParameter );
					base.DbCommand.Parameters.Add( person.Enlightened.DbParameter );
					base.DbCommand.Parameters.Add( person.HolySomething.DbParameter );
					base.DbCommand.Parameters.Add( person.NewLeftPerson.DbParameter );
					base.DbCommand.Parameters.Add( person.NoRightPerson.DbParameter );
					base.DbCommand.Parameters.Add( person.DefaultRow.DbParameter );
					base.DbCommand.Parameters.Add( person.Export.DbParameter );
					base.DbCommand.Parameters.Add( person.TimeTalent.DbParameter );
					base.DbCommand.Parameters.Add( person.Minister.DbParameter );
					base.DbCommand.Parameters.Add( person.Sacristan.DbParameter );
					base.DbCommand.Parameters.Add( person.Vigil.DbParameter );
					base.DbCommand.Parameters.Add( person.Mass.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns MaxPk if INSERT succeeds, -1 if INSERT fails.
				/// </summary>
				public int Execute
				{
					get
					{
						try
						{
							base.Connection.Open();
							base.DbCommand.ExecuteNonQuery();
							base.Connection.Close();
							return new Count.MaxPk().Execute;
						}
						catch ( Exception e )
						{
							Connection.Close();
							return PRESET.MINUS_ONE;
						}
					}
				}
			}
		}
	}
}
