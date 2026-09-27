//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public class Index04_Postal : BaseAddress
	{
		private static string _UnValue = "no postal data";
		private bool _isDataExtant = false;

		//___________________________________________________________________________________________________________________________________________
		public Index04_Postal( ADDRESS_ROW address_row ) : base( address_row )
		{
			IsExtantData = base.IsDataExtant
			(
				address_row.BoxNumber,
				address_row.RuralDelivery,
				address_row.PostalCode
			);
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertColumnValue( ListViewItem list_view_item )
		{
			string s = String.Empty;

			s = this.Rule;
			s = base.RealiseAddressRule( s );
			s = this.RemoveUnusedCodes( s );
			s = SHORT_TXT.RectifyString( s );

			list_view_item.SubItems.Add( s );
		}
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns an address rule that assembles a 'default' postal line.
		/// If all columns are null, returns "no postal data".
		/// </summary>
		public string Rule
		{
			get
			{
				if ( IsExtantData )
					return BoxNumber + RuralDelivery + PostalCode;
				else
					return _UnValue;
			}
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
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Gets/sets _isDataExtant == true if at least one postal line column is NOT null.
		/// </summary>
		private bool IsExtantData
		{
			get { return _isDataExtant; }
			set { _isDataExtant = value; }
		}
	}
}