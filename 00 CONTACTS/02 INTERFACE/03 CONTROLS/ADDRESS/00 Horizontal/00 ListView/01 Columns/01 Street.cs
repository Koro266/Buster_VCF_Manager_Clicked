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
	public class Col1_Street : BASE_ROW
	{
		private static string _UnValue = "no street data";

		//___________________________________________________________________________________________________________________________________________
		public Col1_Street( ADDRESS_ROW address_row ) : base( address_row )
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
		/// Returns an address rule that assembles a 'default' street address.
		/// If all columns are null, returns "no street data".
		/// </summary>
		private string Rule
		{
			get { return HouseNumber + StreetName + StreetType + Compass; }
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
	}
}
