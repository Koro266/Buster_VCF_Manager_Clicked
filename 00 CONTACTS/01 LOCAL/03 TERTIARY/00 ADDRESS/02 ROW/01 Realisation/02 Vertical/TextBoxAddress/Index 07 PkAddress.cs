//___________________________________________________________________________________________________________________________________________________
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL
{
	//___________________________________________________________________________________________________________________________________________
	public class Index07_PkAddress : BaseAddress
	{
		private ADDRESS_ROW _Address;

		//___________________________________________________________________________________________________________________________________________
		public Index07_PkAddress( ADDRESS_ROW address_row ) : base( address_row )
		{
			AddressRow = address_row;
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertLineValue( TextBox text_box )
		{
			string s;
			
			s = "PK Address = ";
			s = s + AddressRow.PkAddress.AsString;
			s = s + Environment.NewLine;

			text_box.AppendText( s );
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
