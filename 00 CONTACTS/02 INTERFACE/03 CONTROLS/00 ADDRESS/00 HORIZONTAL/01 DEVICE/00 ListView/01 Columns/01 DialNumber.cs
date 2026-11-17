//___________________________________________________________________________________________________________________________________________________
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using DEVICE_COL	= CONTACTS.LOCAL.TERTIARY.DEVICE.Column.ST_DialNumber;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col1_DialNumber
	{
		private DEVICE_COL _DialNumber;
		private static string _NoValue = "no number";

		//___________________________________________________________________________________________________________________________________________
		public Col1_DialNumber( DEVICE_ROW device_row )
		{
			_DialNumber = device_row.DialNumber;
		}
		//___________________________________________________________________________________________________________________________________________
		public string ColumnValue
		{
			get { return _DialNumber.IsNotNull ? _DialNumber.AsIs : _NoValue; }
		}
	}
}
