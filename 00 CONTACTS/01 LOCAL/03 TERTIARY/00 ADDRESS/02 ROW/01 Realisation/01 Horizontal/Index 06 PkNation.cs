//___________________________________________________________________________________________________________________________________________________
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL
{
	//___________________________________________________________________________________________________________________________________________
	public class Index06_PkNation : BaseAddress
	{
		private ADDRESS_ROW _Address;

		//___________________________________________________________________________________________________________________________________________
		public Index06_PkNation( ADDRESS_ROW address_row) : base( address_row )
		{
			AddressRow = address_row;
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertColumnValue( ListViewItem list_view_item )
		{
			list_view_item.SubItems.Add( AddressRow.FkCountry.AsString );
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
