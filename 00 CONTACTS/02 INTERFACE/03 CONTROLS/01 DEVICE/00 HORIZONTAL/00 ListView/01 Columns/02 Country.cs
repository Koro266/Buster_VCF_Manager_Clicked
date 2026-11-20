//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using COUNTRY_ISO	= CONTACTS.LOCAL.TERTIARY.DEVICE.Column.ST_ShortIsoCode;
using COUNTRY_CODE	= CONTACTS.LOCAL.TERTIARY.DEVICE.Column.ST_CountryCode;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col2_Country
	{
		private COUNTRY_ISO _ShortIsoCode;
		private COUNTRY_CODE _CountryCode;
		private static string _Rule = "#0, #1";

		//___________________________________________________________________________________________________________________________________________
		public Col2_Country( DEVICE_ROW device_row )
		{
			_ShortIsoCode = device_row.ShortIsoCode;
			_CountryCode = device_row.CountryCode;
		}
		//___________________________________________________________________________________________________________________________________________
		public string ColumnValue
		{
			get 
			{
				string s = _Rule;

				s = s.Replace( PRESET.S0, _ShortIsoCode.AsIs );
				s = s.Replace( PRESET.S1, _CountryCode.AsIs );

				return s; 
			}
		}
	}
}
