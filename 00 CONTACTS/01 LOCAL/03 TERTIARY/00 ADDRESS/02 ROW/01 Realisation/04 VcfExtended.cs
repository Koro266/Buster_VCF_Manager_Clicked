//___________________________________________________________________________________________________________________________________________________
using SBLDR = System.Text.StringBuilder;
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using PARENT_ROW = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using GIANT_SWITCH = CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.TheGiantSwitch;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public partial class VcfExtendedRealiser : BASE_ROW
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
		public VcfExtendedRealiser( PARENT_ROW parent_row )
		{
			_ParentRow = parent_row;
			_Switch = new GIANT_SWITCH( parent_row );
		}
	}
}
