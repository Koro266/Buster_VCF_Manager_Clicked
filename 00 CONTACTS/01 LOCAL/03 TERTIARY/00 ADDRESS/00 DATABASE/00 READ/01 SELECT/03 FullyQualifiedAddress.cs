//___________________________________________________________________________________________________________________________________________________
//LOCAL
using ADDRESS_ROW = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using COLUMNS = CONTACTS.LOCAL.TERTIARY.ADDRESS.Column;

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
			/// Returns singleton TDF_Address constrained by isDefaultRow = True.
			/// </summary>
			public class FullyQualifiedAddress
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
						TDF_Addresses.is_Christmas,

						TDF_Countries.st_CountryName,
						TDF_Countries.st_CountryCode,
						TDF_Countries.st_ShortIsoCode,
						TDF_Countries.st_LongIsoCode 
					FROM
						TDF_Addresses
						INNER JOIN TDF_Countries ON TDF_Addresses.fk_Country = TDF_Countries.pk_Country
					WHERE
						(((TDF_Addresses.pk_Address) = @pk_address));
				";

				//_______________________________________________________________________________________________________________________________
				public FullyQualifiedAddress( int pk_address )
				{
					COLUMNS.PK_Address pk = new COLUMNS.PK_Address( pk_address );
					address_Reader = new AddressReader( sql_text, pk.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				public ADDRESS_ROW Execute
				{
					get { return address_Reader.ReadAddress(); }
				}
			}
		}
	}
}
