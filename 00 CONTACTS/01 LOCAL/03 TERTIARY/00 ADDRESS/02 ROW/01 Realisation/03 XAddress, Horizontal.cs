//___________________________________________________________________________________________________________________________________________________
using SBLDR = System.Text.StringBuilder;
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using PARENT_ROW = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using GIANT_SWITCH = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row.TheGiantSwitch;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class XAddressHorizontal : BASE_ROW
		{
			private PARENT_ROW _ParentRow;
			private GIANT_SWITCH _Switch;
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
				_Switch = new GIANT_SWITCH( parent_row );
			}
		}
	}
}
