//___________________________________________________________________________________________________________________________________________________
//LOCAL
using CONTACTS.GLOBAL.DATABASE.COLUMN;
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using BASE_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.BaseAddress;	

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
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
		public string ColumnValue
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
