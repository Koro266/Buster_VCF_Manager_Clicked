//___________________________________________________________________________________________________________________________________________________
//SYSTEM
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow ;
//LOCAL
using DEVICE_ROW		= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
//INTERFACE
using TRAILING_DIGITS	= CONTACTS.INTERFACE.CONTROLS.DEVICE.VERTICAL.LISTBOX.Col5_TrailingDigits;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.DEVICE.VERTICAL.LISTBOX
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class ListBoxDevice
	{
		private ListBox _Control;
		private Dictionary<int, BASE_ROW> _BaseRows;
		private int lvi_Index = 0;

		private TRAILING_DIGITS	_TrailingDigits;

		//___________________________________________________________________________________________________________________________________________
		public ListBoxDevice( ListBox list_box)
		{
			_Control = list_box;
			ClearDevices();
		}
		//___________________________________________________________________________________________________________________________________________
		public void ClearDevices()
		{
			_Control.Items.Clear();
		}
		//___________________________________________________________________________________________________________________________________________
		private void DisplayDevices( Dictionary<int, BASE_ROW> base_rows )
		{
			ClearDevices();
			lvi_Index = 0;

			foreach ( KeyValuePair<int, BASE_ROW
				> row in base_rows )
			{
				DEVICE_ROW device_row = ( DEVICE_ROW )row.Value;
				_Control.Items.Add( device_row.TrailingDigits.Value );
			}
		}
	}
}
