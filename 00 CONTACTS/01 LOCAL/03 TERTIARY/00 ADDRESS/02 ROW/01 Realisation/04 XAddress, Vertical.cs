//___________________________________________________________________________________________________________________________________________________
using SBLDR = System.Text.StringBuilder;
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using PARENT_ROW = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISATION
{
	//___________________________________________________________________________________________________________________________________________
	public partial class XAddressVertical : BASE_ROW
	{
		private PARENT_ROW _ParentRow;
		private TheGiantSwitch _Switch;
		private static string VcfAddressPattern = "/bx /rd;/sb /ct /mt /pc;/hn /sn /st /cp;/pv /pa;/as  /lv /un /ex;/cy";

		//___________________________________________________________________________________________________________________________________________
		public XAddressVertical( PARENT_ROW parent_row )
		{
			_ParentRow = parent_row;
			_Switch = new TheGiantSwitch( parent_row );
		}
	}
}
