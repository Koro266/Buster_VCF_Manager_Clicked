//___________________________________________________________________________________________________________________________________________________
//SYSTEM
using SUB_ITEM		= System.Windows.Forms.ListViewItem.ListViewSubItem;
//GLOBAL
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using BASE_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.BaseAddress;	
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.ADDRESS.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col8_IsoCodes : BASE_ROW
	{
		//___________________________________________________________________________________________________________________________________________
		public Col8_IsoCodes( ADDRESS_ROW address_row ) : base( address_row )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		public SUB_ITEM SubItem
		{
			get
			{
				SUB_ITEM sub_item = new SUB_ITEM();
				sub_item.Text = ColumnValue;
				return sub_item;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string ColumnValue
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
		/// Returns an address rule that assembles a 'default' ISO Codes.
		/// </summary>
		public string Rule
		{
			get { return IsoLong + IsoShort; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string IsoLong		{ get { return base.IsoLong + "," + CONST.OneSpace; } }
		override public string IsoShort		{ get { return base.IsoShort; } }
	}
}
