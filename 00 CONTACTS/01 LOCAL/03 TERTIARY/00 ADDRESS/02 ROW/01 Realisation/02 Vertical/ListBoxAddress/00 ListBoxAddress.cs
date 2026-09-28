//___________________________________________________________________________________________________________________________________________________
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using IDX01_STREET		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX.Index01_Street;
using IDX02_CITY		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX.Index02_City;
using IDX03_METRO		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX.Index03_Metro;
using IDX04_POSTAL		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX.Index04_Postal;
using IDX05_EXTENSIONS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX.Index05_Extensions;
using IDX06_COUNTRY		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX.Index06_Country;
using IDX07_PK_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX.Index07_PkAddress;
using IDX08_PK_NATION	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX.Index08_PkNation;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX
{
	//___________________________________________________________________________________________________________________________________________
	public class ListBoxAddress : BaseAddress
	{
		private ListBox _ListBox;
		private IDX01_STREET _Street;
		private IDX02_CITY _City;
		private IDX03_METRO _Metro;
		private IDX04_POSTAL _Postal;
		private IDX05_EXTENSIONS _Extensions;
		private IDX06_COUNTRY _Country;
		private IDX07_PK_ADDRESS _PkAddress;
		private IDX08_PK_NATION _PkNation;

		//___________________________________________________________________________________________________________________________________________
		public ListBoxAddress( ADDRESS_ROW address_row, ListBox list_box ) : base( address_row )
		{
			ListBoxControl = list_box;

			_Street = new IDX01_STREET( address_row );
			_City = new IDX02_CITY( address_row );
			_Metro = new IDX03_METRO( address_row );
			_Postal = new IDX04_POSTAL( address_row );
			_Extensions = new IDX05_EXTENSIONS( address_row );
			_Country = new IDX06_COUNTRY( address_row );
			_PkAddress = new IDX07_PK_ADDRESS( address_row );
			_PkNation = new IDX08_PK_NATION( address_row );
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertLineValues()
		{
			ListBoxControl.Items.Clear();
			_Street.InsertLineValue( ListBoxControl );
			_City.InsertLineValue( ListBoxControl );
			_Metro.InsertLineValue( ListBoxControl );
			_Postal.InsertLineValue( ListBoxControl );
			_Extensions.InsertLineValue( ListBoxControl );
			_Country.InsertLineValue( ListBoxControl );
			_PkAddress.InsertLineValue( ListBoxControl );
			_PkNation.InsertLineValue( ListBoxControl );
		}
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Gets/sets ListBox control object.
		/// </summary>
		private ListBox ListBoxControl
		{
			get { return _ListBox; }
			set { _ListBox = value; }
		}
	}
}
