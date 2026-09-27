//___________________________________________________________________________________________________________________________________________________
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public class Index08_IsoCodes : BaseAddress
	{

		//___________________________________________________________________________________________________________________________________________
		public Index08_IsoCodes( ADDRESS_ROW address_row ) : base( address_row )
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
		/// Returns an address rule that assembles a 'default' ISO Codes.
		/// </summary>
		public string Rule
		{
			get
			{
				return IsoLong + IsoShort;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string IsoLong		{ get { return base.IsoLong + "," + CONST.OneSpace; } }
		override public string IsoShort		{ get { return base.IsoShort; } }
	}
}
