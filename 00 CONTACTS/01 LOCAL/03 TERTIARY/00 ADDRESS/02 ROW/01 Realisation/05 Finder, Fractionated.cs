//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISATION
{
	//___________________________________________________________________________________________________________________________________________
	public partial class RealiseFinderAddress : BASE_ROW
	{
		private TheGiantSwitch _Switch;
		private ADDRESS_ROW _AddressRow;
		private static string AddressPattern = @"/pk|/hn /sn /st /cp|/sb /ct|/mt /pv (/pa)|/bx /rd /pc|/as /ex /lv /un|/cy /cd /si /li FK=/fk|/nt";

		//___________________________________________________________________________________________________________________________________________
		public RealiseFinderAddress( ADDRESS_ROW address_row )
		{
			_AddressRow = address_row;
			_Switch = new TheGiantSwitch( _AddressRow );
		}
		//___________________________________________________________________________________________________________________________________________
		public string[] GetStrings
		{
			get
			{
				string s = _Switch.RealiseAddressRule( AddressPattern );
				SHORT_TXT short_txt = new SHORT_TXT( s );
				short_txt.RectifyString( s );
				return short_txt.Value.Split( "|", StringSplitOptions.None );
			}
		}
	}
}
