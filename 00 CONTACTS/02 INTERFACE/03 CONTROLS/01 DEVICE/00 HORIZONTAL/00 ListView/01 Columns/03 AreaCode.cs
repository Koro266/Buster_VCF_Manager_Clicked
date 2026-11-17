//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using DEVICE_SHORT	= CONTACTS.LOCAL.TERTIARY.DEVICE.Column.ST_ShortAreaCode;
using DEVICE_LONG	= CONTACTS.LOCAL.TERTIARY.DEVICE.Column.ST_LongAreaCode;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col3_AreaCode
	{
		private DEVICE_SHORT _ShortAreaCode;
		private DEVICE_LONG _LongAreaCode;
		private static string _Rule = "#0, #1";

		//___________________________________________________________________________________________________________________________________________
		public Col3_AreaCode( DEVICE_ROW device_row )
		{
			_ShortAreaCode = device_row.ShortAreaCode;
			_LongAreaCode = device_row.LongAreaCode;
		}
		//___________________________________________________________________________________________________________________________________________
		public string ColumnValue
		{
			get 
			{
				string s = _Rule;

				s = s.Replace( PRESET.S0, _ShortAreaCode.AsIs );
				s = s.Replace( PRESET.S1, _LongAreaCode.AsIs );

				return s; 
			}
		}
	}
}
