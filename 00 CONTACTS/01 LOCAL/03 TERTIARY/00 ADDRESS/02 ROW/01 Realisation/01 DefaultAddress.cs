//___________________________________________________________________________________________________________________________________________________
using System.Text.RegularExpressions;
//GLOBAL
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public class DefaultAddress : TheGiantSwitch
	{
		private static string AddressPattern = "/pk<:>/hn /sn /st /cp<:>/sb /ct<:>/mt /pv (`pa)<:>/bx /rd /pc<:>/as /ex /lv /un<:>/cy, /cd<:>/si, /li<:>FK=/fk<:>/nt";
		private static string SplitPattern = "<:>";
		private string[] _Result;

		//___________________________________________________________________________________________________________________________________________
		public DefaultAddress( ADDRESS_ROW address_row ) : base( address_row )
		{
			string s;
			s = base.RealiseAddressRule( AddressPattern );
			s = RemoveUnusedReconCodes( s );
			_Result = SHORT_TXT.RectifyStrings( Regex.Split( s, SplitPattern ) );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the entire string array that derives from the default address-rule. 
		/// </summary>
		override public string[] Result
		{
			get { return _Result; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Return the 1st item (index=0) of the result array.
		/// </summary>
		override public string RootItem
		{
			get { return _Result[0]; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns items from index=1 to n of the result array.
		/// </summary>
		override public string[] Subitems
		{
			get { return Result[1..]; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Splits the string into a string[] and rectifies each element of the array.
		/// </summary>
		private string RemoveUnusedReconCodes( string s )
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
			s = s.Replace( "(`pa)",	 String.Empty );	//Remove the parentheses as well.
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
			s = s.Replace( "/nt",	 String.Empty );

			return s;
		}
	}
}
