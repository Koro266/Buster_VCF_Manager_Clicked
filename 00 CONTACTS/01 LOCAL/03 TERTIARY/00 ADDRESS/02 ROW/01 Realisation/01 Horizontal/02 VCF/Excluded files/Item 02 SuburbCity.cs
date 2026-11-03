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
	public class Item_02_SuburbCity : BaseAddress
	{
		private static string _Rule = "/sb /ct /mt /pc";
		private static string _UnValue = CONST.ZLS;
		private bool _isDataExtant = false;

		//___________________________________________________________________________________________________________________________________________
		public Item_02_SuburbCity( ADDRESS_ROW address_row) : base( address_row )
		{
			IsExtantData = base.IsDataExtant
			(
				address_row.Suburb,
				address_row.City,
				address_row.Metropolitan,
				address_row.PostalCode
			);
		}
		//___________________________________________________________________________________________________________________________________________
		public string RealiseAddressRule
		{
			get
			{
				string s = String.Empty;

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
						Suburb +
						City +
						Metropolitan +
						PostalCode;
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
			s = s.Replace( this.Suburb,			 String.Empty );
			s = s.Replace( this.City,			 String.Empty );
			s = s.Replace( this.Metropolitan,	 String.Empty );
			s = s.Replace( this.PostalCode,		 String.Empty );

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string Suburb			{ get { return base.Suburb + CONST.OneSpace; } }
		override public string City				{ get { return base.City + CONST.OneSpace; } }
		override public string Metropolitan		{ get { return base.Metropolitan + CONST.OneSpace; } }
		override public string PostalCode		{ get { return base.PostalCode + CONST.CommaSpace; } }

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
