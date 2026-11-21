//___________________________________________________________________________________________________________________________________________________
using CONTACTS.GLOBAL.VALUES.CONSTANT;
using System.Data.OleDb;
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using REGEX				= CONTACTS.GLOBAL.VALUES.CONSTANT.LikeCriteria;
//LOCAL
using DEVICE_READER		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.DeviceReader;
using LIKE				= CONTACTS.GLOBAL.DATABASE.READ.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________
		public partial class Like
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns pk_Device and concatenated TDF_Device rows where device CountryCode begins with the given character(s).
			/// </summary>
			public class CountryCode : LIKE
			{
				private readonly string target_field = "st_CountryCode";
				private DEVICE_READER device_reader;

				//___________________________________________________________________________________________________________________________
				public CountryCode( string sought_after_text )
				{
					string sql_text = ConstructSQL( target_field );
					OleDbParameter parameter = PrepareParameter( sql_text, sought_after_text );
					device_reader = new DEVICE_READER( sql_text, parameter );
				}
				//_______________________________________________________________________________________________________________________________
				private string ConstructSQL( string target_field_name )
				{
					string sql_text =
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
						WHERE 
							(((TDF_Countries.#0) LIKE @subtext )) 
						ORDER BY
							TDF_Countries.#0;
					";

					return sql_text.Replace( PRESET.S0, target_field_name );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return device_reader.ReadDevices(); }
				}

			}
		}
	}
}
