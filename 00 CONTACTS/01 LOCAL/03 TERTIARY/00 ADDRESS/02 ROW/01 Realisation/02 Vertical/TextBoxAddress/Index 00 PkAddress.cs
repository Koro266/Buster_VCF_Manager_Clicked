//___________________________________________________________________________________________________________________________________________________
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL
{
	//___________________________________________________________________________________________________________________________________________
	public class Index00_PkAddress : BaseAddress
	{
		private ADDRESS_ROW _Address;
		private TextBox _TextBox;

		//___________________________________________________________________________________________________________________________________________
		public Index00_PkAddress( ADDRESS_ROW address_row, TextBox text_box ) : base( address_row )
		{
			AddressRow = address_row;
			TextBoxControl = text_box;
			TextBoxControl.Clear();
		}
		//___________________________________________________________________________________________________________________________________________
		public string InsertColumnValue()
		{
			return "";// TextBoxControl.Lines..Add( AddressRow.PkAddress.AsString );
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
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Gets/sets TextBox control object.
		/// </summary>
		private TextBox TextBoxControl
		{
			get { return _TextBox; }
			set { _TextBox = value; }
		}
	}
}
