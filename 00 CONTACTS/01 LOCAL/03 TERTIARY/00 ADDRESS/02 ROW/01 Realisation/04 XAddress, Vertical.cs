//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.COLUMN;
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using GIANT_SWITCH	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row.TheGiantSwitch;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class XAddressVertical : BASE_ROW
	{
		private GIANT_SWITCH _Switch;
		private ADDRESS_ROW _AddressRow;
		private static string AddressPattern = "/hn /sn /st /cp|/sb /ct|/bx /rd /pc|/mt /pv /pa|/cy";
		private static string SplitCharacter = "|";
		private string[] _Result;

		//___________________________________________________________________________________________________________________________________________
		public XAddressVertical( ADDRESS_ROW address_row )
		{
			_AddressRow = address_row;
			_Switch = new GIANT_SWITCH( _AddressRow );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Realises the defined address pattern.
		/// </summary>
		public void RealiseAddress()
		{
			string s = _Switch.RealiseAddressRule( AddressPattern );
			_Result = RectifyResult( s );
		}
		//___________________________________________________________________________________________________________________________________________
		public string[] Result
		{
			get { return _Result; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Removes splits the string into a string[] and rectifies each element of the array.
		/// </summary>
		private string[] RectifyResult( string s )
		{
			string[] string_array = s.Split( SplitCharacter, StringSplitOptions.None );
			return SHORT_TXT.RectifyStrings( string_array );
		}
	}
}
