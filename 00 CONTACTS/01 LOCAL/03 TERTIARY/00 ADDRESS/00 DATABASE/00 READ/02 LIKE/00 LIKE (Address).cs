//___________________________________________________________________________________________________________________________________________________
using System.Data;
using System.Data.OleDb;
//GLOBAL
using LIKE		= CONTACTS.GLOBAL.DATABASE.READ.Like;
using PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using REGEX		= CONTACTS.GLOBAL.VALUES.CONSTANT.LikeCriteria;
//LOCAL
using ADDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using ADDRESS_READER	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.AddressReader;
using System.Text;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
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
						TDF_Addresses.pk_Address,
						TDF_Addresses.fk_Country,
						TDF_Addresses.st_Assemblage,
						TDF_Addresses.st_Level,
						TDF_Addresses.st_Unit,
						TDF_Addresses.st_Extension,
						TDF_Addresses.st_RuralDelivery,
						TDF_Addresses.st_PostalCode,
						TDF_Addresses.st_BoxNumber,
						TDF_Addresses.st_HouseNumber,
						TDF_Addresses.st_StreetName,
						TDF_Addresses.st_StreetType,
						TDF_Addresses.st_Compass,
						TDF_Addresses.st_Suburb,
						TDF_Addresses.st_City,
						TDF_Addresses.st_Metropolitan,
						TDF_Addresses.st_ProvinceName,
						TDF_Addresses.st_ProvinceCode,
						TDF_Addresses.st_VcfPostal,
						TDF_Addresses.st_VcfPhysical,
						TDF_Addresses.st_VcfExtended,
						TDF_Addresses.st_ExcelPattern,
						TDF_Addresses.is_Christmas,
						TDF_Countries.st_CountryName,
						TDF_Countries.st_CountryCode,
						TDF_Countries.st_ShortIsoCode,
						TDF_Countries.st_LongIsoCode 
					FROM
						TDF_Addresses
						INNER JOIN TDF_Countries ON TDF_Addresses.fk_Country = TDF_Countries.pk_Country
					WHERE 
							(((TDF_Addresses.#0) LIKE @subtext )) 
					ORDER BY
							TDF_Addresses.#0;
				";

				return sql_text.Replace( PRESET.S0, target_field_name );
			}
		}
	}
}
