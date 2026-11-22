//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow ;
//LOCAL
using DEVICE_ROW		= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using SELECT_DEVICE		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Select;
using LIKE				= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTBOX
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class ListBoxDevice
	{
		//___________________________________________________________________________________________________________________________________________
		public DEVICE_ROW DefaultDevice
		{
			get { return new SELECT_DEVICE.DefaultDevice().Execute; }
		}
		////___________________________________________________________________________________________________________________________________________
		//public string LongAreaCode
		//{
		//	set
		//	{
		//		Dictionary<int, BASE_ROW> base_rows = new LIKE.LongAreaCode( value ).Execute;
		//		this.DisplayDevices( base_rows );
		//	}
		//}
		////___________________________________________________________________________________________________________________________________________
		//public string ShortAreaCode
		//{
		//	set
		//	{
		//		Dictionary<int, BASE_ROW> base_rows = new LIKE.ShortAreaCode( value ).Execute;
		//		this.DisplayDevices( base_rows );
		//	}
		//}
		////___________________________________________________________________________________________________________________________________________
		//public string LeadingDigits
		//{
		//	set
		//	{
		//		Dictionary<int, BASE_ROW> base_rows = new LIKE.LeadingDigits( value ).Execute;
		//		this.DisplayDevices( base_rows );
		//	}
		//}
		////___________________________________________________________________________________________________________________________________________
		//public string TrailingDigits
		//{
		//	set
		//	{
		//		Dictionary<int, BASE_ROW> base_rows = new LIKE.TrailingDigits( value ).Execute;
		//		this.DisplayDevices( base_rows );
		//	}
		//}
		////___________________________________________________________________________________________________________________________________________
		//public string Location
		//{
		//	set
		//	{
		//		Dictionary<int, BASE_ROW> base_rows = new LIKE.Location( value ).Execute;
		//		this.DisplayDevices( base_rows );
		//	}
		//}
		////___________________________________________________________________________________________________________________________________________
		//public string Type
		//{
		//	set
		//	{
		//		Dictionary<int, BASE_ROW> base_rows = new LIKE.Type( value ).Execute;
		//		this.DisplayDevices( base_rows );
		//	}
		//}
		////___________________________________________________________________________________________________________________________________________
		//public string CountryName
		//{
		//	set
		//	{
		//		Dictionary<int, BASE_ROW> base_rows = new LIKE.CountryCode( value ).Execute;
		//		this.DisplayDevices( base_rows );
		//	}
		//}
	}
}
