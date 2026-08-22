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
	public partial class XAddressHorizontal : BASE_ROW
	{
		private PARENT_ROW _ParentRow;
		private TheGiantSwitch _Switch;
		private static string XAddressPattern = 
			@"
				/hn 
				/sn 
				/st 
				/cp, 
				/sb 
				/ct, 
				/mt 
				/pv 
				(/pa), 
				/bx 
				/rd 
				/pc, 
				/as 
				/ex 
				/lv 
				/un, 
				/cy 
				(/cd) 
				/si 
				/li
			";

		//___________________________________________________________________________________________________________________________________________
		public XAddressHorizontal( PARENT_ROW parent_row )
		{
			_ParentRow = parent_row;
			_Switch = new TheGiantSwitch( parent_row );
		}
	}
}
