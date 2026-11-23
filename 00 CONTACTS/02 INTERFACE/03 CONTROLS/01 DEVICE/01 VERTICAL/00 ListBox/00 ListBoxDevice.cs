//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow ;
//LOCAL
using DEVICE_ROW		= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using LIKE				= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.DEVICE.VERTICAL.LISTBOX
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class ListBoxDevice
	{
		private ListBox _Control;
		private Dictionary<int, BASE_ROW> _BaseRows;

		//___________________________________________________________________________________________________________________________________________
		public ListBoxDevice( ListBox list_box )
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
		public string SoughtAfterText
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.PreFindList( value ).Execute;
				this.DisplayDevices( base_rows );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public void DisplayDevices( Dictionary<int, BASE_ROW> base_rows )
		{
			ClearDevices();

			foreach ( KeyValuePair<int, BASE_ROW> row in base_rows )
			{
				DEVICE_ROW device_row = ( DEVICE_ROW )row.Value;
				_Control.Items.Add( device_row.PickerNumber.Value );
			}
		}
	}
}
