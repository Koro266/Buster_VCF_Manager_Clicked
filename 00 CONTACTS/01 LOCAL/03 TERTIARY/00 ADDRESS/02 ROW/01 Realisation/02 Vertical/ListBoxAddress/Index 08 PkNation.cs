//___________________________________________________________________________________________________________________________________________________
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX
{
	//___________________________________________________________________________________________________________________________________________
	public class Index08_PkNation : BaseAddress
	{
		private ADDRESS_ROW _Address;

		//___________________________________________________________________________________________________________________________________________
		public Index08_PkNation( ADDRESS_ROW address_row) : base( address_row )
		{
			AddressRow = address_row;
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertLineValue( ListBox list_box )
		{
			string s;

			s = "PK Country = ";
			s = s + AddressRow.FkCountry.AsString;

			list_box.Items.Add( s );
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
