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
	public class Index01_Street : BaseAddress
	{
		private static string _UnValue = "no street data";
		private bool _isDataExtant = false;

		//___________________________________________________________________________________________________________________________________________
		public Index01_Street( ADDRESS_ROW address_row) : base( address_row )
		{
			IsExtantData = base.IsDataExtant
			(
				address_row.HouseNumber,
				address_row.StreetName,
				address_row.StreetType,
				address_row.Compass
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
		/// Returns an address rule that assembles a 'default' street address.
		/// If all columns are null, returns "no street data".
		/// </summary>
		private string Rule
		{
			get
			{
				if ( IsExtantData )
					return HouseNumber + StreetName + StreetType + Compass;
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
			s = s.Replace( this.HouseNumber,	String.Empty );
			s = s.Replace( this.StreetName,		String.Empty );
			s = s.Replace( this.StreetType,		String.Empty );
			s = s.Replace( this.Compass,		String.Empty );

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string HouseNumber		{ get { return base.HouseNumber + CONST.OneSpace; } }
		override public string StreetName		{ get { return base.StreetName + CONST.OneSpace; } }
		override public string StreetType		{ get { return base.StreetType + CONST.OneSpace; } }
		override public string Compass			{ get { return base.Compass; } }
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
