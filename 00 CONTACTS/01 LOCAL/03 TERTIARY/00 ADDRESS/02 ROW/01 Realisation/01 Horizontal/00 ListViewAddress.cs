//___________________________________________________________________________________________________________________________________________________
//LOCAL
using ADDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using IDX00_PK_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.Index00_PkAddress;
using IDX01_STREET		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.Index01_Street;
using IDX02_CITY		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.Index02_City;
using IDX03_METRO		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.Index03_Metro;
using IDX04_POSTAL		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.Index04_Postal;
using IDX05_EXTENSIONS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.Index05_Extensions;
using IDX06_PK_NATION	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.Index06_PkNation;
using IDX07_COUNTRY		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.Index07_Country;
using IDX08_ISOCODES	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.Index08_IsoCodes;
using IDX09_NOTES		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.Index09_Notes;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public class ListViewAddress : BaseAddress
	{
		private IDX00_PK_ADDRESS	_PkAddress;
		private IDX01_STREET		_Street;
		private IDX02_CITY			_City;
		private IDX03_METRO			_Metro;
		private IDX04_POSTAL		_Postal;
		private IDX05_EXTENSIONS	_Extensions;
		private IDX06_PK_NATION		_PkNation;
		private IDX07_COUNTRY		_Country;
		private IDX08_ISOCODES		_IsoCodes;
		private IDX09_NOTES			_Notes;

		//___________________________________________________________________________________________________________________________________________
		public ListViewAddress( ADDRESS_ROW address_row, ListView list_view ) : base( address_row )
		{
			_PkAddress	= new IDX00_PK_ADDRESS( address_row, list_view );
			_Street		= new IDX01_STREET( address_row );
			_City		= new IDX02_CITY( address_row );
			_Metro		= new IDX03_METRO( address_row );
			_Postal		= new IDX04_POSTAL( address_row );
			_Extensions	= new IDX05_EXTENSIONS( address_row );
			_PkNation	= new IDX06_PK_NATION( address_row );
			_Country	= new IDX07_COUNTRY( address_row );
			_IsoCodes	= new IDX08_ISOCODES( address_row );
			_Notes		= new IDX09_NOTES( address_row );
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertAddressValues()
		{
			ListViewItem list_view_item =_PkAddress.InsertColumnValue();
			_Street.InsertColumnValue( list_view_item );
			_City.InsertColumnValue( list_view_item );
			_Metro.InsertColumnValue( list_view_item );
			_Postal.InsertColumnValue( list_view_item );
			_Extensions.InsertColumnValue( list_view_item );
			_PkNation.InsertColumnValue( list_view_item );
			_Country.InsertColumnValue( list_view_item );
			_IsoCodes.InsertColumnValue( list_view_item );
			_Notes.InsertColumnValue( list_view_item );
		}
	}
}
