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
	public partial class VcfExtendedRealiser : GIANT_SWITCH
	{
		private ADDRESS_ROW _AddressRow;
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
		public VcfExtendedRealiser( ADDRESS_ROW address_row ) : base( address_row )
		{
			_AddressRow = address_row;
		}
	}
}
