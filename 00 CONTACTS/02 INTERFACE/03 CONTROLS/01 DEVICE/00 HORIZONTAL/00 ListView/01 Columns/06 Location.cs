//___________________________________________________________________________________________________________________________________________________
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using DEVICE_COL	= CONTACTS.LOCAL.TERTIARY.DEVICE.Column.ST_DeviceLocation;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col6_Location
	{
		private DEVICE_COL _Location;
		private static string _NoValue = "no location";

		//___________________________________________________________________________________________________________________________________________
		public Col6_Location( DEVICE_ROW device_row )
		{
			_Location = device_row.DeviceLocation;
		}
		//___________________________________________________________________________________________________________________________________________
		public string ColumnValue
		{
			get { return _Location.IsNotNull ? _Location.AsIs : _NoValue; }
		}
	}
}
