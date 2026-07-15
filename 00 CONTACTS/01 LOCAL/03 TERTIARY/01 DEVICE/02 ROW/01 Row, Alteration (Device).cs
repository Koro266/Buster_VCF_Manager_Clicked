//___________________________________________________________________________________________________________________________________________________
using SBLDR = System.Text.StringBuilder;
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL 
using ORDINAL = CONTACTS.LOCAL.TERTIARY.DEVICE.Constants.OrdinalByName;
using FIELD = CONTACTS.LOCAL.TERTIARY.DEVICE.Column;
using COUNTRY = CONTACTS.LOCAL.TERTIARY.NATION.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		private COUNTRY device_Nation; //The Nation that goes with this device.

		public const string DialNumberPattern = "+#0 #1 #2 #3";		//"+/cy /sc /ld /td"
		public const string PickerNumberPattern = "#0 #1 #2 #3";	//"/td /ld /lc /cy"

		#region VALUE ALTERATION
		//___________________________________________________________________________________________________________________________________________
		public COUNTRY Country
		{
			set { device_Nation = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		public void CountryAltered( COUNTRY new_value )
		{
			Country = new_value;
			Replace( ORDINAL.FkCountry, new FIELD.FK_Country( new_value.PkCountry.Value ) );
			RebuildNumbers();
		}
		//___________________________________________________________________________________________________________________________________________
		public void LongAreaCodeAltered( string new_value ) 
		{
			Replace( ORDINAL.LongAreaCode, new FIELD.ST_LongAreaCode( new_value ) );
			RebuildNumbers();
		}
		//___________________________________________________________________________________________________________________________________________
		public void ShortAreaCodeAltered( string new_value )
		{
			Replace( ORDINAL.ShortAreaCode, new FIELD.ST_ShortAreaCode( new_value ) );
			RebuildNumbers();
		}
		//___________________________________________________________________________________________________________________________________________
		public void LeadingDigitsAltered( string new_value )
		{
			Replace( ORDINAL.LeadingDigits, new FIELD.ST_LeadingDigits( new_value ) );
			RebuildNumbers();
		}
		//___________________________________________________________________________________________________________________________________________
		public void TrailingDigitsAltered( string new_value )
		{
			Replace( ORDINAL.TrailingDigits, new FIELD.ST_TrailingDigits( new_value ) );
			RebuildDialNumber();
			RebuildPickerNumber();
		}
		//___________________________________________________________________________________________________________________________________________
		public void DeviceLocationAltered( string new_value )
		{
			Replace( ORDINAL.DeviceLocation, new FIELD.ST_DeviceLocation( new_value ) );
		}
		//___________________________________________________________________________________________________________________________________________
		public void DeviceTypeAltered( string new_value )
		{
			Replace( ORDINAL.DeviceType, new FIELD.ST_DeviceType( new_value ) );
		}
		//___________________________________________________________________________________________________________________________________________
		public void NotesAltered( string new_value )
		{
			Replace( ORDINAL.Notes, new FIELD.ST_Notes( new_value ) );
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewSelected
		{
			set { Replace( ORDINAL.Selected, new FIELD.IS_Selected( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewDefaultRow
		{
			set { Replace( ORDINAL.DefaultRow, new FIELD.IS_DefaultRow( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewBlocked
		{
			set { Replace( ORDINAL.Blocked, new FIELD.IS_Blocked( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool New_X_Person
		{
			set { Replace( ORDINAL.X_Person, new FIELD.IS_X_Person( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool New_X_Group
		{
			set { Replace( ORDINAL.X_Group, new FIELD.IS_X_Group( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool New_X_Family
		{
			set { Replace( ORDINAL.X_Family, new FIELD.IS_X_Family( value ) ); }
		}
		#endregion


		#region RE-BUILDERS
		//___________________________________________________________________________________________________________________________________________
		private void RebuildNumbers()
		{
			RebuildDialNumber();
			RebuildPickerNumber();
		}
		//___________________________________________________________________________________________________________________________________________
		private void RebuildDialNumber()
		{
			SBLDR dial_number = new SBLDR( DialNumberPattern );
			dial_number.Replace( PRESET.S0, device_Nation.CountryCode.AsIs );
			dial_number.Replace( PRESET.S1, ShortAreaCode.AsIs );
			dial_number.Replace( PRESET.S2, LeadingDigits.AsIs );
			dial_number.Replace( PRESET.S3, TrailingDigits.AsIs );
			Replace( ORDINAL.DialNumber, new FIELD.ST_DialNumber( dial_number.ToString() ) );
		}
		//___________________________________________________________________________________________________________________________________________
		private void RebuildPickerNumber()
		{
			SBLDR picker_number = new SBLDR( PickerNumberPattern );
			picker_number.Replace( PRESET.S0, TrailingDigits.AsIs );
			picker_number.Replace( PRESET.S1, LeadingDigits.AsIs );
			picker_number.Replace( PRESET.S2, LongAreaCode.AsIs );
			picker_number.Replace( PRESET.S3, device_Nation.ShortIsoCode.AsIs );
			Replace( ORDINAL.PickerNumber, new FIELD.ST_PickerNumber( picker_number.ToString() ) );
		}
		#endregion
	}
}
