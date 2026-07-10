//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using SELECT		= CONTACTS.GLOBAL.DATABASE.READ.Select;
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
			/// Returns singleton TDF_Device constrained by PkDevice.
			/// </summary>
			public class ByPkDevice
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
						TDF_Countries.st_CountryName,
						TDF_Countries.st_CountryCode,
						TDF_Countries.st_ShortIsoCode,
						TDF_Countries.st_LongIsoCode
					FROM
						TDF_Devices
						INNER JOIN TDF_Countries ON TDF_Devices.fk_Country = TDF_Countries.pk_Country
					WHERE
						(((TDF_Devices.pk_Device) = @pk_device ));
				";

				//_______________________________________________________________________________________________________________________________
				public ByPkDevice( int pk_device )
				{
					COLUMNS.PK_Device pk = new COLUMNS.PK_Device( pk_device );
					device_Reader = new DeviceReader( sql_text, pk.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				public DEVICE_ROW Execute
				{
					get { return device_Reader.ReadDevice(); }
				}
			}
		}
	}
}
