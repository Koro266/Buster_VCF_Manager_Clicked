//___________________________________________________________________________________________________________________________________________________
using System.Text.RegularExpressions;
//GLOBAL
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using RECON			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reconstruction;
using IDX01_STREET		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.TEXTBOX.Index01_Street;
using IDX02_CITY		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.TEXTBOX.Index02_City;
using IDX03_METRO		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.TEXTBOX.Index03_Metro;
using IDX04_POSTAL		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.TEXTBOX.Index04_Postal;
using IDX05_EXTENSIONS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.TEXTBOX.Index05_Extensions;
using IDX06_COUNTRY		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.TEXTBOX.Index06_Country;
using IDX07_PK_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.TEXTBOX.Index07_PkAddress;
using IDX08_PK_NATION	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.TEXTBOX.Index08_PkNation;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.TEXTBOX
{
	//___________________________________________________________________________________________________________________________________________
	public class TextBoxAddress : BaseAddress
	{
		private TextBox _TextBox;
		private IDX01_STREET		_Street;
		private IDX02_CITY			_City;
		private IDX03_METRO			_Metro;
		private IDX04_POSTAL		_Postal;
		private IDX05_EXTENSIONS	_Extensions;
		private IDX06_COUNTRY		_Country;
		private IDX07_PK_ADDRESS	_PkAddress;
		private IDX08_PK_NATION		_PkNation;

		//___________________________________________________________________________________________________________________________________________
		public TextBoxAddress( ADDRESS_ROW address_row, TextBox text_box ) : base( address_row )
		{
			TextBoxControl = text_box;
			TextBoxControl.Multiline = true;

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
			TextBoxControl.Clear();
			_Street.InsertLineValue( TextBoxControl );
			_City.InsertLineValue( TextBoxControl );
			_Metro.InsertLineValue( TextBoxControl );
			_Postal.InsertLineValue( TextBoxControl );
			_Extensions.InsertLineValue( TextBoxControl );
			_Country.InsertLineValue( TextBoxControl );
			_PkAddress.InsertLineValue( TextBoxControl );
			_PkNation.InsertLineValue( TextBoxControl );
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
	