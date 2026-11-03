//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.VCF
{
	//___________________________________________________________________________________________________________________________________________
	public class Item_00_BoxRd : BaseAddress
	{
		private static string _Rule = "/bx /rd";
		private static string _UnValue = CONST.ZLS;
		private bool _isDataExtant = false;

		//___________________________________________________________________________________________________________________________________________
		public Item_00_BoxRd( ADDRESS_ROW address_row) : base( address_row )
		{
			IsExtantData = base.IsDataExtant
			(
				address_row.BoxNumber,
				address_row.RuralDelivery
			);
		}
		//___________________________________________________________________________________________________________________________________________
		public string RealiseAddressRule
		{
			get
			{
				string s = CONST.ZLS;

				s = _Rule;
				s = base.RealiseAddressRule( s );
				s = this.RemoveUnusedCodes( s );
				s = SHORT_TXT.RectifyString( s );
				s = s == CONST.ZLS ? s : s + CONST.CommaSpace;

				return s;
			}
		}
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns an address rule that assembles a 'default' street address.
		/// If all columns are null, returns "no street data".
		/// </summary>
		private string Rule
		{
			get
			{
				if ( IsExtantData )
					return
						PostalCode +
						RuralDelivery;
				else
					return _UnValue;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Remove unused/unreplaced RECON codes from the result string.
		/// </summary>
		private string RemoveUnusedCodes( string s )
		{
			s = s.Replace( this.PostalCode,		 String.Empty );
			s = s.Replace( this.RuralDelivery,	 String.Empty );

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string BoxNumber		{ get { return base.BoxNumber + CONST.OneSpace; } }
		override public string RuralDelivery	{ get { return base.RuralDelivery + CONST.CommaSpace; } }

		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Gets/sets _isDataExtant == true if at least one street line column is NOT null.
		/// </summary>
		private bool IsExtantData
		{
			get { return _isDataExtant; }
			set { _isDataExtant = value; }
		}
	}
}
