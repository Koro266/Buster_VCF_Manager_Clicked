//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS			= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Column;
using READER			= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Database.GroupAddressReader;
using GROUP_XADDRESS	= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns GROUP_X_Address constrained by pk_Group_X_Address.
			/// </summary>
			public class ByPrimaryKey
			{
				READER group_address_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Groups_X_Addresses.pk_Group_X_Address,
						TDF_Groups_X_Addresses.fk_Group,
						TDF_Groups_X_Addresses.fk_Address,
						TDF_Groups_X_Addresses.st_AddressType
					FROM 
						TDF_Groups_X_Addresses 
					WHERE 
						(((TDF_Groups_X_Addresses.pk_Group_X_Address)=@pk_group_x_address));
				";

				//___________________________________________________________________________________________________________________________________
				public ByPrimaryKey( int pk_grp_x_addr )
				{
					COLUMNS.PK_Group_X_Address pk_column = new COLUMNS.PK_Group_X_Address( pk_grp_x_addr );
					group_address_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public GROUP_XADDRESS Execute
				{
					get { return group_address_reader.ReadGroupAddress(); }
				}
			}
		}
	}
}
