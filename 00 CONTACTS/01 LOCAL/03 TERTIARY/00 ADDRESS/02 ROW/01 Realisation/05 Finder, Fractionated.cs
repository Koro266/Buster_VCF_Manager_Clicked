//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.VALUES.CONSTANT;
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using PARENT_ROW = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using SHORT_TXT = CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISATION
{
	//___________________________________________________________________________________________________________________________________________
	public partial class RealiseFinderAddress : BASE_ROW
	{
		private PARENT_ROW _ParentRow;
		private TheGiantSwitch _Switch;
		private static string XAddressPattern = @"/pk|/hn /sn /st /cp|/sb /ct|/mt /pv (/pa)|/bx /rd /pc|/as /ex /lv /un|/cy /cd /si /li FK=/fk|/nt";

		//___________________________________________________________________________________________________________________________________________
		public RealiseFinderAddress( PARENT_ROW parent_row )
		{
			_ParentRow = parent_row;
			_Switch = new TheGiantSwitch( parent_row );
		}
		//___________________________________________________________________________________________________________________________________________
		public string[] GetStrings
		{
			get
			{
				string s = _Switch.RealiseAddressRule( XAddressPattern );
				SHORT_TXT short_txt = new SHORT_TXT( s );
				short_txt.RectifyString( s );
				return short_txt.Value.Split( "|", StringSplitOptions.None );
			}
		}
	}
}
