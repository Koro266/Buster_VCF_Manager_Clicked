//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using FK_ADDRESS	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Column.FK_Address;
using READER		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.PersonAddressReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Person_X_Address rows constrained by fk_Address.
			/// </summary>
			public class ByPkAddress
			{
				READER person_address_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Persons_X_Addresses.pk_Person_X_Address,
						TDF_Persons_X_Addresses.fk_Person,
						TDF_Persons_X_Addresses.fk_Address,
						TDF_Persons_X_Addresses.is_Selected
					FROM 
						TDF_Persons_X_Addresses 
					WHERE 
					(
						(
							(TDF_Persons_X_Addresses.fk_address) = @fk_address 
						)
					);
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkAddress( int fk_address )
				{
					FK_ADDRESS fk_column = new FK_ADDRESS( fk_address );
					person_address_reader = new READER( sql_text, fk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return person_address_reader.ReadPersonAddresses(); }
				}
			}
		}
	}
}
