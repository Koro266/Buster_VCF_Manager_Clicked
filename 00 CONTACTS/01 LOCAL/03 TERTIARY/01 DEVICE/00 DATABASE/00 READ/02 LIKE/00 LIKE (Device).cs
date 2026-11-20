//___________________________________________________________________________________________________________________________________________________
//SYSTEM
using System.Data;
using System.Data.OleDb;
//GLOBAL
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using REGEX				= CONTACTS.GLOBAL.VALUES.CONSTANT.LikeCriteria;

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
			private static OleDbParameter PrepareParameter( string sql_text, string sought_after_text )
			{
				OleDbParameter parameter = new OleDbParameter( REGEX.LikeParameterName, DbType.String );
				parameter.Value = sought_after_text == REGEX.Dot ? REGEX.SelectiveNotBlank : sought_after_text + REGEX.AcceptAll;

				return parameter;
			}
			//_______________________________________________________________________________________________________________________________
			private static string PrepareSQL( string target_field_name )
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
						(((TDF_Devices.#0) LIKE @subtext )) 
					ORDER BY
						TDF_Devices.#0;
				";

				return sql_text.Replace( PRESET.S0, target_field_name );
			}
		}
	}
}
