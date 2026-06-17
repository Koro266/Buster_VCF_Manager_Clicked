//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.PersonAddressReader;

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
			/// Returns PERSON_X_Address constrained by fk_Person.
			/// </summary>
			public class ByPkPerson
			{
				READER person_address_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Persons_X_Addresses.pk_Person_X_Address,
						TDF_Persons_X_Addresses.fk_Person,
						TDF_Persons_X_Addresses.fk_Address,
						TDF_Persons_X_Addresses.st_AddressType
					FROM 
						TDF_Persons_X_Addresses 
					WHERE 
					(
						(
							(TDF_Persons_X_Addresses.fk_Person) = @fk_person 
						)
					);
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkPerson( int pk_person )
				{
					COLUMNS.FK_Person fk_column = new COLUMNS.FK_Person( pk_person );
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
