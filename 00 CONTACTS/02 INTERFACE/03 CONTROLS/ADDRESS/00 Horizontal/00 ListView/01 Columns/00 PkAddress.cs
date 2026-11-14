//___________________________________________________________________________________________________________________________________________________
//LOCAL
using BASE_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.BaseAddress;	
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col0_PkAddress : BASE_ROW
	{
		private ADDRESS_ROW _Address;

		//___________________________________________________________________________________________________________________________________________
		public Col0_PkAddress( ADDRESS_ROW address_row ) : base( address_row )
		{
			AddressRow = address_row;
		}
		//___________________________________________________________________________________________________________________________________________
		public string ColumnValue
		{
			get { return AddressRow.PkAddress.AsString; }
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
