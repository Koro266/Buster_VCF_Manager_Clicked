//___________________________________________________________________________________________________________________________________________________
using CONTACTS.GLOBAL.DATABASE.COLUMN;
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
//LOCAL
using BASE_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.BaseAddress;	
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col7_Country : BASE_ROW
	{
		//___________________________________________________________________________________________________________________________________________
		public Col7_Country( ADDRESS_ROW address_row ) : base( address_row )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		public string ColumnValue
		{
			get
			{
				string s = String.Empty;

				s = this.Rule;
				s = base.RealiseAddressRule( s );

				return s;
			}

		}
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns an address rule that assembles a 'default' country line.
		/// </summary>
		public string Rule
		{
			get { return Country + TeleCode; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string Country			{ get { return base.Country + CONST.OneSpace; } }
		override public string TeleCode			{ get { return "(" + base.TeleCode + ")"; } }
	}
}
