//___________________________________________________________________________________________________________________________________________________
//SYSTEM
using LIST_ITEM		= System.Windows.Forms.ListViewItem;
using SUB_ITEM		= System.Windows.Forms.ListViewItem.ListViewSubItem;
using System;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
//GLOBAL
using PK_DEVICE			= CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW.Col0_PkDevice;
using DIAL_NUMBER		= CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW.Col1_DialNumber;
using COUNTRY			= CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW.Col2_Country;
using AREA_CODE			= CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW.Col3_AreaCode;
using LEADING_DIGITS	= CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW.Col4_LeadingDigits;
using TRAILING_DIGITS	= CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW.Col5_TrailingDigits;
using LOCATION			= CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW.Col6_Location;
using TYPE				= CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW.Col7_Type;
using NOTES				= CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW.Col8_Notes;









//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class ListViewDevice
	{
		private ListView _Control;
		private Dictionary<int, BASE_ROW> _BaseRows;
		private int lvi_Index = 0;

		private PK_DEVICE		PK_ADDRESS _PkAddress;
		private DIAL_NUMBER		DIAL_NUMBER _Street;
		private COUNTRY			COUNTRY _City;
		private AREA_CODE		AREA_CODE _Metro;
		private LEADING_DIGITS	LEADING_DIGITS _Postal;
		private TRAILING_DIGITS	TRAILING_DIGITS _Extensions;
		private LOCATION		LOCATION _PkNation;
		private TYPE			TYPE _Country;
		private NOTES			NOTES _IsoCodes;

		//___________________________________________________________________________________________________________________________________________
		public ListViewDevice( ListView list_view )
		{
			_Control = list_view;
			_Control.Items.Clear();
			DisplayAddress( this.DefaultDevice );
		}
		//___________________________________________________________________________________________________________________________________________
		private void DisplayAddresses( Dictionary<int, BASE_ROW> base_rows )
		{
			_Control.Items.Clear();
			lvi_Index = 0;

			foreach ( KeyValuePair<int, BASE_ROW> row in base_rows )
			{
				ADDRESS_ROW address_row = ( ADDRESS_ROW )row.Value;
				DisplayAddress( address_row );
				lvi_Index++;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public void DisplayAddress( ADDRESS_ROW address_row )
		{
			ConstructColumns( address_row );
			LIST_ITEM lvi = new LIST_ITEM( _PkAddress.ColumnValue );

			_Control.Items.Add( lvi );
			_Control.Items[lvi_Index].SubItems.Add( _Street.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _City.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _Metro.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _Postal.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _Extensions.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _PkNation.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _Country.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _IsoCodes.ColumnValue );
			_Control.Items[lvi_Index].SubItems.Add( _Notes.ColumnValue );
		}
		//___________________________________________________________________________________________________________________________________________
		public void ConstructColumns( ADDRESS_ROW address_row )
		{
			_PkAddress	= new PK_ADDRESS( address_row );
			_Street		= new STREET( address_row );
			_City		= new CITY( address_row );
			_Metro		= new METRO( address_row );
			_Postal		= new POSTAL( address_row );
			_Extensions	= new EXTENSIONS( address_row );
			_PkNation	= new PK_NATION( address_row );
			_Country	= new NATION( address_row );
			_IsoCodes	= new ISOCODES( address_row );
			_Notes		= new NOTES( address_row );
		}
	}
}
