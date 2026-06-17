//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Database.GroupAddressReader;

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
			/// Returns Addresses attached to a Group.
			/// </summary>
			public class ByPkGroup
			{
				READER group_address_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Groups_X_Addresses.pk_Group_X_Address,
						TDF_Groups_X_Addresses.fk_Group,
						TDF_Groups_X_Addresses.fk_Address 
					FROM 
						TDF_Groups_X_Addresses 
					WHERE 
						(((TDF_Groups_X_Addresses.fk_Group)=@fk_group));
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkGroup( int pk_group )
				{
					COLUMNS.FK_Group fk_column = new COLUMNS.FK_Group( pk_group );
					group_address_reader = new READER( sql_text, fk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return group_address_reader.ReadGroupAddresses(); }
				}
			}
		}
	}
}
