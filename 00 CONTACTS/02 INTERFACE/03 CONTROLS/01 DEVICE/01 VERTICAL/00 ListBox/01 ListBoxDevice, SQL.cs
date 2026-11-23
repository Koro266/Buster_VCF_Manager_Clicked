//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow ;
//LOCAL
using DEVICE_ROW		= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using SELECT_DEVICE		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Select;
using LIKE				= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.DEVICE.VERTICAL.LISTBOX
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class ListBoxDevice
	{
		//___________________________________________________________________________________________________________________________________________
		public DEVICE_ROW DefaultDevice
		{
			get { return new SELECT_DEVICE.DefaultDevice().Execute; }
		}
		//___________________________________________________________________________________________________________________________________________
		public Dictionary<int, BASE_ROW> SqlResultSet(string find_this)
		{
			Dictionary<int, BASE_ROW> base_rows = new LIKE.PreFindList( find_this ).Execute;
			this.DisplayDevices( base_rows );
		}
	}
}
