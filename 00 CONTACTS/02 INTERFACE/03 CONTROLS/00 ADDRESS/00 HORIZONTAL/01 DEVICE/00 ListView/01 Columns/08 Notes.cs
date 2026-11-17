//___________________________________________________________________________________________________________________________________________________
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using DEVICE_COL	= CONTACTS.LOCAL.TERTIARY.DEVICE.Column.ST_Notes;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col8_Notes
	{
		private DEVICE_COL _Notes;
		private static string _NoValue = "no note";

		//___________________________________________________________________________________________________________________________________________
		public Col8_Notes( DEVICE_ROW device_row )
		{
			_Notes = device_row.Notes;
		}
		//___________________________________________________________________________________________________________________________________________
		public string ColumnValue
		{
			get { return _Notes.IsNotNull ? _Notes.AsIs : _NoValue; }
		}
	}
}
