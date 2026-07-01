//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.CONNECTION;
//LOCAL
using PERSON_ROW = CONTACTS.LOCAL.PRIMARY.PERSON.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class Update
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// UPDATEs an existing Person row specified by pk_Person.
			/// </summary>
			public class Person : DbConnection
			{
				private const string sql_text =
				@"
					UPDATE					
						TDF_Persons				
					SET					
						TDF_Persons.pk_Person			= @pk_person,	
						TDF_Persons.st_SortableName		= @st_sortablename,	
						TDF_Persons.st_NaturalName		= @st_naturalname,	
						TDF_Persons.st_UpperSurname		= @st_uppersurname,	
						TDF_Persons.st_ProperSurname	= @st_propersurname,	
						TDF_Persons.st_GivenName		= @st_givenname,	
						TDF_Persons.st_MiddleNames		= @st_middlenames,	
						TDF_Persons.st_NickName			= @st_nickname,	
						TDF_Persons.st_BirthName		= @st_birthname,	
						TDF_Persons.st_Prefix			= @st_prefix,	
						TDF_Persons.st_Suffix			= @st_suffix,	
						TDF_Persons.st_Initials			= @st_initials,	
						TDF_Persons.st_Gender			= @st_gender,	
						TDF_Persons.st_Notes			= @st_notes,	
						TDF_Persons.dt_BirthDate		= @dt_birthdate,	
						TDF_Persons.dt_DeathDate		= @dt_deathdate,	
						TDF_Persons.dt_WeddingDate		= @dt_weddingdate,	
						TDF_Persons.dt_CurrencyDate		= @dt_currencydate,	
						TDF_Persons.is_Selected			= @is_selected,	
						TDF_Persons.is_Enlightened		= @is_enlightened,	
						TDF_Persons.is_HolySomething	= @is_holysomething,	
						TDF_Persons.is_NewLeftPerson	= @is_newleftperson,	
						TDF_Persons.is_NoRightPerson	= @is_norightperson,	
						TDF_Persons.is_DefaultRow		= @is_defaultrow,	
						TDF_Persons.is_Export			= @is_export,	
						TDF_Persons.is_TimeTalent		= @is_timetalent,	
						TDF_Persons.is_Minister			= @is_minister,	
						TDF_Persons.is_Sacristan		= @is_sacristan,	
						TDF_Persons.is_Vigil			= @is_vigil,	
						TDF_Persons.is_Mass				= @is_mass	
						(((TDF_Persons.pk_Person		= @pk_person ));
				";

				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Updates functional columns of an existing Person row constrained by pk_Person.
				/// </summary>
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
					base.DbCommand.Parameters.Add( person.PkPerson.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns true if update succeeds, false on exception.
				/// </summary>
				public bool Execute
				{
					get { return base.ExecuteNonQuery; }
				}
			}
		}
	}
}
