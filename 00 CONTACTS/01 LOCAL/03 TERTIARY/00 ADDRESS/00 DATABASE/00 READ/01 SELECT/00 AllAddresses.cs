//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using ORDINAL = CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.OrdinalByName;
using ADDRESS_ROW = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using COLUMNS = CONTACTS.LOCAL.TERTIARY.ADDRESS.Column;
using COUNT = CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Count;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns all TDF_Address rows currently held in TDF_Addresses.
			/// </summary>
			public class AllAddresses
			{
				private AddressReader address_Reader;
				private const string sql_text =
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
						TDF_Addresses.st_Notes,

						TDF_Addresses.is_Selected,
						TDF_Addresses.is_DefaultRow,
						TDF_Addresses.is_Unattached,
						TDF_Addresses.is_X_Person,
						TDF_Addresses.is_X_Group,
						TDF_Addresses.is_X_Family,
						TDF_Addresses.is_Christmas,

						TDF_Countries.st_CountryName,
						TDF_Countries.st_CountryCode,
						TDF_Countries.st_ShortIsoCode,
						TDF_Countries.st_LongIsoCode 
					FROM
						TDF_Addresses
						INNER JOIN TDF_Countries ON TDF_Addresses.fk_Country = TDF_Countries.pk_Country;
				";
				//_______________________________________________________________________________________________________________________________
				public AllAddresses()
				{
					address_Reader = new AddressReader( sql_text );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return address_Reader.ReadAddresses(); }
				}
			}
		}
	}
}
