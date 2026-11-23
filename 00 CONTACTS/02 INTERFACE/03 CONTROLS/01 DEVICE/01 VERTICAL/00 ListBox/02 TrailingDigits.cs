//___________________________________________________________________________________________________________________________________________________
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using DEVICE_COL	= CONTACTS.LOCAL.TERTIARY.DEVICE.Column.ST_TrailingDigits;
using LIKE			= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.DEVICE.VERTICAL.LISTBOX
{
	//___________________________________________________________________________________________________________________________________________
	public class TrailingDigits
	{
		private DEVICE_COL _TrailingDigits;
		private static string _NoValue = "no trail";

		//___________________________________________________________________________________________________________________________________________
		public TrailingDigits( DEVICE_ROW device_row )
		{
			_TrailingDigits = device_row.TrailingDigits;
		}
		//___________________________________________________________________________________________________________________________________________
		public string ColumnValue
		{
			get { return _TrailingDigits.IsNotNull ? _TrailingDigits.AsIs : _NoValue; }
		}
	}
}
