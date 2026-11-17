//___________________________________________________________________________________________________________________________________________________
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using DEVICE_COL	= CONTACTS.LOCAL.TERTIARY.DEVICE.Column.ST_DeviceType;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col7_Type
	{
		private DEVICE_COL _Type;
		private static string _NoValue = "no type";

		//___________________________________________________________________________________________________________________________________________
		public Col7_Type( DEVICE_ROW device_row )
		{
			_Type = device_row.DeviceType;
		}
		//___________________________________________________________________________________________________________________________________________
		public string ColumnValue
		{
			get { return _Type.IsNotNull ? _Type.AsIs : _NoValue; }
		}
	}
}
