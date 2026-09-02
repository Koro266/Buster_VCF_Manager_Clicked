//___________________________________________________________________________________________________________________________________________________
using SBLDR = System.Text.StringBuilder;
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using GIANT_SWITCH = CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.TheGiantSwitch;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public partial class VcfExtendedRealiser : BASE_ROW
	{
		private ADDRESS_ROW _AddressRow;
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
		public VcfExtendedRealiser( ADDRESS_ROW parent_row )
		{
			_AddressRow = parent_row;
			_Switch = new GIANT_SWITCH( parent_row );
		}
	}
}
