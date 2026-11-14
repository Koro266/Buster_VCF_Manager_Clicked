//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using BASE_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.BaseAddress;	
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col4_Postal : BASE_ROW
	{
		private static string _UnValue = "no postal data";

		//___________________________________________________________________________________________________________________________________________
		public Col4_Postal( ADDRESS_ROW address_row ) : base( address_row )
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
				s = this.RemoveUnusedCodes( s );
				s = SHORT_TXT.RectifyString( s );

				return s;
			}

		}
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns an address rule that assembles a 'default' postal line.
		/// If all columns are null, returns "no postal data".
		/// </summary>
		public string Rule
		{
			get { return BoxNumber + RuralDelivery + PostalCode; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Remove unused RECON codes for the result string.
		/// </summary>
		public string RemoveUnusedCodes( string s )
		{
			s = s.Replace( this.BoxNumber, String.Empty );
			s = s.Replace( this.RuralDelivery, String.Empty );
			s = s.Replace( this.PostalCode, String.Empty );

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string BoxNumber		{ get { return base.BoxNumber + CONST.OneSpace; } }
		override public string RuralDelivery	{ get { return base.RuralDelivery + CONST.OneSpace; } }
		override public string PostalCode		{ get { return base.PostalCode + CONST.OneSpace; } }
	}
}