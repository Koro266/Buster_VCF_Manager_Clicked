//___________________________________________________________________________________________________________________________________________________
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL
{
	//___________________________________________________________________________________________________________________________________________
	public class Index06_Country : BaseAddress
	{
		//___________________________________________________________________________________________________________________________________________
		public Index06_Country( ADDRESS_ROW address_row ) : base( address_row )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertLineValue( TextBox text_box )
		{
			string s = String.Empty;

			s = Country + Environment.NewLine;
			s = s + TeleCode + Environment.NewLine;
			s = s + IsoLong + Environment.NewLine;
			s = s + IsoShort + Environment.NewLine;
			s = base.RealiseAddressRule( s );

			text_box.AppendText( s );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string Country		{ get { return base.Country + CONST.OneSpace; } }
		override public string TeleCode		{ get { return "Country Code: " + base.TeleCode + CONST.OneSpace; } }
		override public string IsoLong		{ get { return "ISO Long: "+base.IsoLong + CONST.OneSpace; } }
		override public string IsoShort		{ get { return "ISO Short: "+base.IsoShort; } }
	}
}
