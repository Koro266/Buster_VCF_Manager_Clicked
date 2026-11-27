//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using DEVICE_ROW = CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using LIKE = CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.ADDRESS.VERTICAL.COMBOBOX
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class CbxStreetName
	{
		private ComboBox _Control;

		//___________________________________________________________________________________________________________________________________________
		public CbxStreetName( ComboBox combo_box )
		{
			_Control = combo_box;
			ClearControl();
		}
		//___________________________________________________________________________________________________________________________________________
		public void ClearControl()
		{
			_Control.Items.Clear();
		}
		//___________________________________________________________________________________________________________________________________________
		public string SoughtAfterText
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.PreFindList( value ).Execute;
				this.DisplayItems( base_rows );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public void DisplayItems( Dictionary<int, BASE_ROW> base_rows )
		{
			ClearControl();

			foreach ( KeyValuePair<int, BASE_ROW> row in base_rows )
			{
				DEVICE_ROW device_row = ( DEVICE_ROW )row.Value;
				_Control.Items.Add( device_row.PickerNumber.Value );
			}
		}
	}
}
