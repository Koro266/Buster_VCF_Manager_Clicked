//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Database.FamilyAddressReader;

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
			/// Returns Addresses attached to a family.
			/// </summary>
			public class ByPkFamily
			{
				READER family_address_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Families_X_Addresses.pk_Family_X_Address,
						TDF_Families_X_Addresses.fk_Family,
						TDF_Families_X_Addresses.fk_Address,
						TDF_Families_X_Addresses.st_AddressType 
					FROM 
						TDF_Families_X_Addresses 
					WHERE 
						(((TDF_Families_X_Addresses.fk_Family)=@fk_family));
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkFamily( int pk_family )
				{
					family_address_reader = new READER( sql_text, new COLUMNS.FK_Family( pk_family ).DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public ByPkFamily( OleDbParameter db_parameter )
				{
					family_address_reader = new READER( sql_text, db_parameter );
				}
				//___________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return family_address_reader.ReadFamilyAddresses(); }
				}
			}
		}
	}
}
