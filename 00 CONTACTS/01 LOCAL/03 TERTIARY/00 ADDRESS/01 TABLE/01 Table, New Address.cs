//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using NULL_TEXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using FIELD			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Table
	{
		//___________________________________________________________________________________________________________________________________________
		public ADDRESS_ROW NewAddress
		{
			get
			{
				NULL_TEXT null_text = new NULL_TEXT();
				ADDRESS_ROW new_address = new ADDRESS_ROW();

				new_address.Append( new FIELD.PK_Address			( -1 ) );
				new_address.Append( new FIELD.FK_Country			( 0	 ) );	//NZ

				new_address.Append( new FIELD.ST_Assemblage			( null_text ) );
				new_address.Append( new FIELD.ST_Level				( null_text ) );
				new_address.Append( new FIELD.ST_Unit				( null_text ) );
				new_address.Append( new FIELD.ST_Extension			( null_text ) );
				new_address.Append( new FIELD.ST_RuralDelivery		( null_text ) );
				new_address.Append( new FIELD.ST_PostalCode			( null_text ) );
				new_address.Append( new FIELD.ST_BoxNumber			( null_text ) );
				new_address.Append( new FIELD.ST_HouseNumber		( null_text ) );
				new_address.Append( new FIELD.ST_StreetName			( null_text ) );
				new_address.Append( new FIELD.ST_StreetType			( null_text ) );
				new_address.Append( new FIELD.ST_Compass			( null_text ) );
				new_address.Append( new FIELD.ST_Suburb				( null_text ) );
				new_address.Append( new FIELD.ST_City				( null_text ) );
				new_address.Append( new FIELD.ST_Metropolitan		( "Wellington" ) );
				new_address.Append( new FIELD.ST_ProvinceName		( "WELLINGTON" ) );
				new_address.Append( new FIELD.ST_ProvinceCode		( "WGTN" ) );
				new_address.Append( new FIELD.ST_VcfPostal			( "/hn /sn /st\\n/ct, /pc\\n/cy" ) );
				new_address.Append( new FIELD.ST_VcfPhysical		( "/hn /sn /st\\n/sb, /ct\\n/mt, /pv\\n/cy" ) );
				new_address.Append( new FIELD.ST_VcfExtended		( "/as\\n/lv\\n/un\\n/ex" ) );
				new_address.Append( new FIELD.ST_ExcelPattern		( null_text ) );
				new_address.Append( new FIELD.ST_Notes				( null_text ) );

				new_address.Append( new FIELD.IS_Selected			( false ) );
				new_address.Append( new FIELD.IS_DefaultRow			( false ) );
				new_address.Append( new FIELD.IS_Unattached			( false ) );
				new_address.Append( new FIELD.IS_X_Person			( false ) );
				new_address.Append( new FIELD.IS_X_Group			( false ) );
				new_address.Append( new FIELD.IS_X_Family			( false ) );
				new_address.Append( new FIELD.IS_Christmas			( false ) );

				new_address.Append( new FIELD.ST_CountryName		( "New Zealand" ) );
				new_address.Append( new FIELD.ST_CountryCode		( "64" ) );
				new_address.Append( new FIELD.ST_ShortIsoCode		( "NZ" ) );
				new_address.Append( new FIELD.ST_LongIsoCode		( "NZL" ) );

				return new_address;
			}
		}
	}
}
