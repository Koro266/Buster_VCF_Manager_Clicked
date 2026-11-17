//___________________________________________________________________________________________________________________________________________________
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using DEVICE_COL	= CONTACTS.LOCAL.TERTIARY.DEVICE.Column.ST_LeadingDigits;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col4_LeadingDigits
	{
		private DEVICE_COL _LeadingDigits;
		private static string _NoValue = "no lead";

		//___________________________________________________________________________________________________________________________________________
		public Col4_LeadingDigits( DEVICE_ROW device_row )
		{
			_LeadingDigits = device_row.LeadingDigits;
		}
		//___________________________________________________________________________________________________________________________________________
		public string ColumnValue
		{
			get { return _LeadingDigits.IsNotNull ? _LeadingDigits.AsIs : _NoValue; }
		}
	}
}
