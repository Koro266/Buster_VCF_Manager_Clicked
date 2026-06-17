//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using NULL_DATE		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<System.DateTime>;
using NULL_TEXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
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
				new_person.Append( new FIELD.ST_Gender			( null_text ) );
				new_person.Append( new FIELD.ST_Notes			( null_text ) );
				new_person.Append( new FIELD.DT_BirthDate		( null_date ) );
				new_person.Append( new FIELD.DT_DeathDate		( null_date ) );
				new_person.Append( new FIELD.DT_WeddingDate		( null_date ) );
				new_person.Append( new FIELD.DT_CurrencyDate	( DateTime.Now ) );

				return new_person;
			}
		}
	}
}
