//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using NULL_DATE		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<System.DateTime>;
using NULL_TEXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
using NULL_BOOL		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<bool>;
//LOCAL
using FAMILY_ROW	= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using FIELD			= CONTACTS.LOCAL.PRIMARY.FAMILY.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Table
	{
		//___________________________________________________________________________________________________________________________________________
		public FAMILY_ROW NewFamily
		{
			get
			{
				NULL_DATE null_date = new NULL_DATE();
				NULL_TEXT null_text = new NULL_TEXT();
				NULL_BOOL null_bool = new NULL_BOOL();

				FAMILY_ROW new_family = new FAMILY_ROW();

				new_family.Append( new FIELD.PK_Family 					( -1 ) );
				new_family.Append( new FIELD.FK_LeftPerson 				( 1482 ) );
				new_family.Append( new FIELD.FK_RightPerson 			( 1436 ) );
				new_family.Append( new FIELD.ST_FamilyType 				( null_text ) );
				new_family.Append( new FIELD.ST_FamilyName 				( null_text ) );
				new_family.Append( new FIELD.ST_SortableName 			( null_text ) );
				new_family.Append( new FIELD.ST_JointName 				( null_text ) );
				new_family.Append( new FIELD.ST_NaturalName 			( null_text ) );
				new_family.Append( new FIELD.ST_PostalName 				( null_text ) );
				new_family.Append( new FIELD.ST_Notes 					( null_text ) );
				new_family.Append( new FIELD.DT_WeddingDate 			( null_date ) );
				new_family.Append( new FIELD.DT_CurrencyDate 			( DateTime.Now ) );
				new_family.Append( new FIELD.IS_Christmas 				( null_bool ) );
				new_family.Append( new FIELD.IS_Dissolved 				( null_bool ) );
				new_family.Append( new FIELD.IS_CorlettRd 				( null_bool ) );
				new_family.Append( new FIELD.IS_StTheresa 				( null_bool ) );
				new_family.Append( new FIELD.IS_DefaultRow 				( null_bool ) );
				new_family.Append( new FIELD.ST_LeftUpperSurname 		( null_text ) );
				new_family.Append( new FIELD.ST_LeftProperSurname 		( null_text ) );
				new_family.Append( new FIELD.ST_LeftGivenName 			( null_text ) );
				new_family.Append( new FIELD.ST_RightUpperSurname 		( null_text ) );
				new_family.Append( new FIELD.ST_RightProperSurname 		( null_text ) );
				new_family.Append( new FIELD.ST_RightGivenName			( null_text ) );

				return new_family;
			}
		}
	}
}
