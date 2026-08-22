//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using SHORT_TXT = CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
//LOCAL
using PARENT_ROW = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISATION
{
	//___________________________________________________________________________________________________________________________________________
	public partial class RealiseFinderAddress : BASE_ROW
	{
		private PARENT_ROW _ParentRow;
		private TheGiantSwitch _Switch;
		private static string XAddressPattern = @"/pk|/hn /sn /st /cp|/sb /ct|/mt /pv (/pa)|/bx /rd /pc|/as /ex /lv /un|/cy /cd /si /li FK=/fk|/nt";
		//private static string[] sAddressPattern = { "/hn", "/sn", "/st", "/cp,", "/sb", "/ct,", "/mt /pv", "(/pa),", "/bx", "/rd", "/pc,", "/as", "/ex", "/lv", "/un,", "/cy", "(/cd)", "/si", "/li" };
		//private static int[] iAddressPattern = {  9, 10, 11, 12, 13, 14, 15, 16, 17, 8, 6, 7, 2, 5, 3, 4, 30, 31, 32, 33 };

		//___________________________________________________________________________________________________________________________________________
		public RealiseFinderAddress( PARENT_ROW parent_row )
		{
			_ParentRow = parent_row;
			_Switch = new TheGiantSwitch( parent_row );
		}
		//___________________________________________________________________________________________________________________________________________
		public string GetStrings
		{
			get
			{
				string s = _Switch.RealiseAddressRule( XAddressPattern );
				SHORT_TXT short_txt = new SHORT_TXT( s );
				return short_txt.RectifyString( s );
			}
		}
	}
}
