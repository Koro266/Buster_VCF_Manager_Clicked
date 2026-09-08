//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Builds and returns a string[] in which every address token is specified in the pattern and hence all address fields are examined.
	/// The result contains all the address data held in the database including the primary key. 
	/// </summary>
	public class DefaultAddress : TheGiantSwitch
	{
		private ADDRESS_ROW _AddressRow;
		private static string AddressPattern = @"/pk|/hn /sn /st /cp|/sb /ct|/mt /pv (/pa)|/bx /rd /pc|/as /ex /lv /un|/cy /cd /si /li FK=/fk|/nt";
		private static string SplitCharacter = "|";
		private string[] _Result;

		//___________________________________________________________________________________________________________________________________________
		public DefaultAddress( ADDRESS_ROW address_row ) : base( address_row )
		{
			_AddressRow = address_row;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Realises the defined address pattern and returns the first item (Item[0]) of the result array.
		/// </summary>
		public void RealiseAddress()
		{
			string s = base.RealiseAddressRule( AddressPattern );
			_Result = RectifyResult( s );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the first item (Item[0]) of the result array
		/// </summary>
		public string[] Result
		{
			get { return _Result; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the first item (Item[0]) of the result array. In this case, the PK of the address.
		/// </summary>
		public string RootItem
		{
			get { return Result[0]; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns everything that follows the first item of the result array (Items[1 to n])
		/// </summary>
		public string[] Subitems
		{
			get { return Result[1..]; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Splits the string into a string[] and rectifies each element of the array.
		/// </summary>
		private string[] RectifyResult( string s )
		{
			//s = s.Replace( "/pk",	 String.Empty );	//The address is guaranteed to have a PK.
			s = s.Replace( "/hn ",	 String.Empty );
			s = s.Replace( "/sn ",	 String.Empty );
			s = s.Replace( "/st ",	 String.Empty );
			s = s.Replace( "/cp",	 String.Empty );
			s = s.Replace( "/sb ",	 String.Empty );
			s = s.Replace( "/ct",	 String.Empty );
			s = s.Replace( "/mt ",	 String.Empty );
			s = s.Replace( "/pv ",	 String.Empty );
			s = s.Replace( "(/pa)",	 String.Empty );	//Remove the parentheses as well.
			s = s.Replace( "/bx ",	 String.Empty );
			s = s.Replace( "/rd ",	 String.Empty );
			s = s.Replace( "/pc",	 String.Empty );
			s = s.Replace( "/as ",	 String.Empty );
			s = s.Replace( "/ex ",	 String.Empty );
			s = s.Replace( "/lv ",	 String.Empty );
			s = s.Replace( "/un",	 String.Empty );
			s = s.Replace( "/cy ",	 String.Empty );
			s = s.Replace( "/cd ",	 String.Empty );
			s = s.Replace( "/si ",	 String.Empty );
			s = s.Replace( "/li ",	 String.Empty );
			//s = s.Replace( "/fk",	 String.Empty );	//The country is guaranteed to have a PK (which is an FK here).
			s = s.Replace( "|/nt",	 String.Empty );	//If there is no note, remove the split character as well.

			string[] string_array = s.Split( SplitCharacter, StringSplitOptions.None );

			return SHORT_TXT.RectifyStrings( string_array );
		}
	}
}
