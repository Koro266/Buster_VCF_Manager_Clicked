//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS			= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Column;
using READER			= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Database.FamilyAddressReader;
using FAMILY_XADDRESS	= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns FAMILY_X_Address constrained by pk_Family_X_Address.
			/// </summary>
			public class ByPrimaryKey
			{
				READER family_address_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Persons_X_Addresses.pk_Family_X_Address,
						TDF_Persons_X_Addresses.fk_Family,
						TDF_Persons_X_Addresses.fk_Address,
						TDF_Persons_X_Addresses.st_AddressType
					FROM 
						TDF_Persons_X_Addresses 
					WHERE 
						(((TDF_Persons_X_Addresses.pk_Family_X_Address)=@pk_family_x_address));
				";

				//___________________________________________________________________________________________________________________________________
				public ByPrimaryKey( int pk_fam_x_addr )
				{
					COLUMNS.PK_Family_X_Address pk_column = new COLUMNS.PK_Family_X_Address( pk_fam_x_addr );
					family_address_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public FAMILY_XADDRESS Execute
				{
					get { return family_address_reader.ReadFamilyAddress(); }
				}
			}
		}
	}
}
