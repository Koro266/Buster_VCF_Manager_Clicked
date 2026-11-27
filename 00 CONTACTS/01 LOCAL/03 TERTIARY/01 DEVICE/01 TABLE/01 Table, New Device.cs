//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using NULL_TEXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using FIELD			= CONTACTS.LOCAL.TERTIARY.DEVICE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Table
	{
		//___________________________________________________________________________________________________________________________________________
		public DEVICE_ROW NewDevice
		{
			get
			{
				NULL_TEXT null_text = new NULL_TEXT();

				DEVICE_ROW new_device = new DEVICE_ROW();

				new_device.Append( new FIELD.PK_Device			( -1 ) );
				new_device.Append( new FIELD.FK_Country			( 0 ) );

				new_device.Append( new FIELD.ST_LongAreaCode	( null_text ) );
				new_device.Append( new FIELD.ST_ShortAreaCode	( null_text ) );
				new_device.Append( new FIELD.ST_LeadingDigits	( null_text ) );
				new_device.Append( new FIELD.ST_TrailingDigits	( null_text ) );
				new_device.Append( new FIELD.ST_DeviceLocation	( null_text ) );
				new_device.Append( new FIELD.ST_DeviceType		( null_text ) );
				new_device.Append( new FIELD.ST_DialNumber		( null_text ) );
				new_device.Append( new FIELD.ST_PickerNumber	( null_text ) );
				new_device.Append( new FIELD.ST_Notes			( null_text ) );

				new_device.Append( new FIELD.IS_Selected		( false ) );
				new_device.Append( new FIELD.IS_DefaultRow		( false ) );
				new_device.Append( new FIELD.IS_Blocked			( false ) );
				new_device.Append( new FIELD.IS_X_Person		( false ) );
				new_device.Append( new FIELD.IS_X_Group			( false ) );
				new_device.Append( new FIELD.IS_X_Family		( false ) );

				new_device.Append( new FIELD.ST_CountryName		( "New Zealand" ) );
				new_device.Append( new FIELD.ST_CountryCode		( "64" ) );
				new_device.Append( new FIELD.ST_ShortIsoCode	( "NZ" ) );
				new_device.Append( new FIELD.ST_LongIsoCode		( "NZL" ) );

				return new_device;
			}
		}
	}
}
