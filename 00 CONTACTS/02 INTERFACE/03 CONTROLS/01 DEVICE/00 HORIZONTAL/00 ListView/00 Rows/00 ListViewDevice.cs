//___________________________________________________________________________________________________________________________________________________
//SYSTEM
using LIST_ITEM			= System.Windows.Forms.ListViewItem;
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow ;
//LOCAL
using DEVICE_ROW		= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
//INTERFACE
using PK_DEVICE			= CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW.Col0_PkDevice;
using DIAL_NUMBER		= CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW.Col1_DialNumber;
using COUNTRY			= CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW.Col2_Country;
using AREA_CODE			= CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW.Col3_AreaCode;
using LEADING_DIGITS	= CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW.Col4_LeadingDigits;
using TRAILING_DIGITS	= CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW.Col5_TrailingDigits;
using LOCATION			= CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW.Col6_Location;
using TYPE				= CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW.Col7_Type;
using NOTES				= CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW.Col8_Notes;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class ListViewDevice
	{
		private ListView _Control;
		private Dictionary<int, BASE_ROW> _BaseRows;
		private int lvi_Index = 0;

		private PK_DEVICE		_PkDevice;
		private DIAL_NUMBER		_Number;
		private COUNTRY			_Country;
		private AREA_CODE		_AreaCode;
		private LEADING_DIGITS	_LeadingDigits;
		private TRAILING_DIGITS	_TrailingDigits;
		private LOCATION		_Location;
		private TYPE			_Type;
		private NOTES			_Notes;

		//___________________________________________________________________________________________________________________________________________
		public ListViewDevice( ListView list_view )
		{
			_Control = list_view;
			_Control.Items.Clear();
			DisplayDevice( this.DefaultDevice );
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

			foreach ( KeyValuePair<int, BASE_ROW> row in base_rows )
			{
				DEVICE_ROW device_row = ( DEVICE_ROW )row.Value;
				DisplayDevice( device_row );
				lvi_Index++;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public void DisplayDevice( DEVICE_ROW device_row )
		{
			ConstructColumns( device_row );
			LIST_ITEM lvi = new LIST_ITEM( _PkDevice.ColumnValue );

			_Control.Items.Add( lvi );
			_Control.Items[lvi_Index].SubItems.Add( _Number.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _Country.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _AreaCode.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _LeadingDigits.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _TrailingDigits.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _Location.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _Type.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _Notes.ColumnValue );
		}
		//___________________________________________________________________________________________________________________________________________
		public void ConstructColumns( DEVICE_ROW device_row )
		{
			_PkDevice		= new PK_DEVICE( device_row );
			_Number			= new DIAL_NUMBER( device_row );
			_Country		= new COUNTRY( device_row );
			_AreaCode		= new AREA_CODE( device_row );
			_LeadingDigits	= new LEADING_DIGITS( device_row );
			_TrailingDigits	= new TRAILING_DIGITS( device_row );
			_Location		= new LOCATION( device_row );
			_Type			= new TYPE( device_row );
			_Notes			= new NOTES( device_row );
		}
	}
}
