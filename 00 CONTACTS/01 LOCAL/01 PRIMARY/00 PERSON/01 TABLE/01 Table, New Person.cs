//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using NULL_DATE		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<System.DateTime>;
using NULL_TEXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
using NULL_INT		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<int>;
//LOCAL
using PERSON_ROW	= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using FIELD			= CONTACTS.LOCAL.PRIMARY.PERSON.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Table
	{
		//___________________________________________________________________________________________________________________________________________
		public PERSON_ROW NewPerson
		{
			get
			{
				NULL_TEXT null_text = new NULL_TEXT();
				NULL_DATE null_date = new NULL_DATE();
				NULL_INT null_int = new NULL_INT();

				PERSON_ROW new_person = new PERSON_ROW();
				new_person.Append( new FIELD.PK_Person			( -1 ) );
				new_person.Append( new FIELD.ST_SortableName	( null_text ) );
				new_person.Append( new FIELD.ST_NaturalName		( null_text ) );
				new_person.Append( new FIELD.ST_UpperSurname	( null_text ) );
				new_person.Append( new FIELD.ST_ProperSurname	( null_text ) );
				new_person.Append( new FIELD.ST_GivenName		( null_text ) );
				new_person.Append( new FIELD.ST_MiddleNames		( null_text ) );
				new_person.Append( new FIELD.ST_NickName		( null_text ) );
				new_person.Append( new FIELD.ST_BirthName		( null_text ) );
				new_person.Append( new FIELD.ST_Prefix			( null_text ) );
				new_person.Append( new FIELD.ST_Suffix			( null_text ) );
				new_person.Append( new FIELD.ST_Initials		( null_text ) );
				new_person.Append( new FIELD.ST_Gender			( "F" ) );
				new_person.Append( new FIELD.ST_Notes			( null_text ) );
				new_person.Append( new FIELD.DT_BirthDate		( null_date ) );
				new_person.Append( new FIELD.DT_DeathDate		( null_date ) );
				new_person.Append( new FIELD.DT_WeddingDate		( null_date ) );
				new_person.Append( new FIELD.DT_CurrencyDate	( DateTime.Now ) );
				new_person.Append( new FIELD.LI_EHS_Order		( null_int ) );

				new_person.Append( new FIELD.IS_Selected		( false ) );
				new_person.Append( new FIELD.IS_DefaultRow		( false ) );
				new_person.Append( new FIELD.IS_Export			( false ) );
				new_person.Append( new FIELD.IS_Blocked			( false ) );
				new_person.Append( new FIELD.IS_Inactive		( false ) );
				new_person.Append( new FIELD.IS_NewLeftPerson	( false ) );
				new_person.Append( new FIELD.IS_NoRightPerson	( false ) );
				new_person.Append( new FIELD.IS_Enlightened		( false ) );
				new_person.Append( new FIELD.IS_HolySomething	( false ) );
				new_person.Append( new FIELD.IS_StTheresa		( false ) );
				new_person.Append( new FIELD.IS_TimeTalent		( false ) );
				new_person.Append( new FIELD.IS_Minister		( false ) );
				new_person.Append( new FIELD.IS_Sacristan		( false ) );
				new_person.Append( new FIELD.IS_Vigil			( false ) );
				new_person.Append( new FIELD.IS_Mass			( false ) );


				return new_person;
			}
		}
	}
}
