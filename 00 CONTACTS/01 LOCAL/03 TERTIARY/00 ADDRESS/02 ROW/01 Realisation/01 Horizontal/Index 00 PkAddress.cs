//___________________________________________________________________________________________________________________________________________________
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public class Index00_PkAddress : BaseAddress
	{
		private ADDRESS_ROW _Address;
		private ListView _ListView;

		//___________________________________________________________________________________________________________________________________________
		public Index00_PkAddress( ADDRESS_ROW address_row, ListView list_view ) : base( address_row )
		{
			AddressRow = address_row;
			ListViewControl = list_view;
			ListViewControl.Items.Clear();
		}
		//___________________________________________________________________________________________________________________________________________
		public ListViewItem InsertColumnValue()
		{
			return ListViewControl.Items.Add( AddressRow.PkAddress.AsString );
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
		/// Gets/sets ListView control object.
		/// </summary>
		private ListView ListViewControl
		{
			get { return _ListView; }
			set { _ListView = value; }
		}
	}
}
