//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using COLUMNS		= CONTACTS.LOCAL.TERTIARY.DEVICE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns all TDF_Device rows currently held in TDF_Devices.
			/// </summary>
			public class AllDevices
			{
				private DeviceReader device_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Devices.pk_Device,
						TDF_Devices.fk_Country,
						TDF_Devices.st_LongAreaCode,
						TDF_Devices.st_ShortAreaCode,
						TDF_Devices.st_LeadingDigits,
						TDF_Devices.st_TrailingDigits,
						TDF_Devices.st_DeviceLocation,
						TDF_Devices.st_DeviceType,
						TDF_Devices.st_DialNumber,
						TDF_Devices.st_PickerNumber,
						TDF_Devices.st_Notes,

						TDF_Devices.is_Selected,
						TDF_Devices.is_DefaultRow,
						TDF_Devices.is_Blocked,
						TDF_Devices.is_X_Person,
						TDF_Devices.is_X_Group,
						TDF_Devices.is_X_Family,

						TDF_Countries.st_CountryName,
						TDF_Countries.st_CountryCode,
						TDF_Countries.st_ShortIsoCode,
						TDF_Countries.st_LongIsoCode
					FROM
						TDF_Devices
						INNER JOIN TDF_Countries ON TDF_Devices.fk_Country = TDF_Countries.pk_Country
					ORDER BY
						TDF_Devices.pk_Device;
				";
				//_______________________________________________________________________________________________________________________________
				public AllDevices()
				{
					device_Reader = new DeviceReader( sql_text );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return device_Reader.ReadDevices(); }
				}
			}
		}
	}
}
