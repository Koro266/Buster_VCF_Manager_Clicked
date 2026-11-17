//___________________________________________________________________________________________________________________________________________________
//SYSTEM
using SUB_ITEM		= System.Windows.Forms.ListViewItem.ListViewSubItem;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using BASE_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.BaseAddress;	

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.ADDRESS.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col6_PkCountry : BASE_ROW
	{
		private ADDRESS_ROW _Address;

		//___________________________________________________________________________________________________________________________________________
		public Col6_PkCountry( ADDRESS_ROW address_row ) : base( address_row )
		{
			AddressRow = address_row;
		}
		//___________________________________________________________________________________________________________________________________________
		public SUB_ITEM SubItem
		{
			get
			{
				SUB_ITEM sub_item = new SUB_ITEM();
				sub_item.Text = ColumnValue;
				return sub_item;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string ColumnValue
		{
			get { return AddressRow.FkCountry.AsString; }

		}
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Gets/sets Address row.
		/// </summary>
		private ADDRESS_ROW AddressRow
		{
			get { return _Address; }
			set { _Address = value; }
		}
	}
}
