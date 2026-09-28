//___________________________________________________________________________________________________________________________________________________
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX
{
	//___________________________________________________________________________________________________________________________________________
	public class Index06_Country : BaseAddress
	{
		//___________________________________________________________________________________________________________________________________________
		public Index06_Country( ADDRESS_ROW address_row ) : base( address_row )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertLineValue( ListBox list_box )
		{
			list_box.Items.Add( RealiseAddressRule( Country) );
			list_box.Items.Add( RealiseAddressRule( TeleCode ) );
			list_box.Items.Add( RealiseAddressRule( IsoLong ) );
			list_box.Items.Add( RealiseAddressRule( IsoShort) );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string Country		{ get { return base.Country; } }
		override public string TeleCode		{ get { return "Country Code: " + base.TeleCode; } }
		override public string IsoLong		{ get { return "ISO Long: "+base.IsoLong; } }
		override public string IsoShort		{ get { return "ISO Short: "+base.IsoShort; } }
	}
}
