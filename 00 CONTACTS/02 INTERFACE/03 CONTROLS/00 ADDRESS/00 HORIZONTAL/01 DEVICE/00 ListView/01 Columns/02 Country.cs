//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using COUNTRY_NAME	= CONTACTS.LOCAL.TERTIARY.DEVICE.Column.ST_CountryName;
using COUNTRY_CODE	= CONTACTS.LOCAL.TERTIARY.DEVICE.Column.ST_CountryCode;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col2_Country
	{
		private COUNTRY_NAME _CountryName;
		private COUNTRY_CODE _CountryCode;
		private static string _Rule = "#0, #1";

		//___________________________________________________________________________________________________________________________________________
		public Col2_Country( DEVICE_ROW device_row )
		{
			_CountryName = device_row.CountryName;
			_CountryCode = device_row.CountryCode;
		}
		//___________________________________________________________________________________________________________________________________________
		public string ColumnValue
		{
			get 
			{
				string s = PRESET.ZLS;

				s = s.Replace( PRESET.S0, _CountryName.AsIs );
				s = s.Replace( PRESET.S1, _CountryCode.AsIs );

				return s; 
			}
		}
	}
}
