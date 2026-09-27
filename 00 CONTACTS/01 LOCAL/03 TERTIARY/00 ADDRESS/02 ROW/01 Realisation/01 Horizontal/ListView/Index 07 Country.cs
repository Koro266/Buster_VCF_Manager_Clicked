//___________________________________________________________________________________________________________________________________________________
//LOCAL
using CONTACTS.GLOBAL.DATABASE.COLUMN;
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL
{
	//___________________________________________________________________________________________________________________________________________
	public class Index07_Country : BaseAddress
	{

		//___________________________________________________________________________________________________________________________________________
		public Index07_Country( ADDRESS_ROW address_row ) : base( address_row )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertColumnValue( ListViewItem list_view_item )
		{
			string s = String.Empty;

			s = this.Rule;
			s = base.RealiseAddressRule( s );

			list_view_item.SubItems.Add( s );
		}
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns an address rule that assembles a 'default' country line.
		/// </summary>
		public string Rule
		{
			get
			{
				return Country + TeleCode;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string Country			{ get { return base.Country + CONST.OneSpace; } }
		override public string TeleCode			{ get { return "(" + base.TeleCode + ")"; } }
	}
}
