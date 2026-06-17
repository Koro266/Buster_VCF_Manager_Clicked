//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS			= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Column;
using READER			= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.PersonAddressReader;
using PERSON_XADDRESS	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Row;

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
			/// Returns PERSON_X_Address constrained by pk_Person_X_Address.
			/// </summary>
			public class ByPrimaryKey
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
						(((TDF_Persons_X_Addresses.pk_Person_X_Address)=@pk_person_x_address));
				";

				//___________________________________________________________________________________________________________________________________
				public ByPrimaryKey( int pk )
				{
					COLUMNS.PK_Person_X_Address pk_column = new COLUMNS.PK_Person_X_Address( pk );
					person_address_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public PERSON_XADDRESS Execute
				{
					get { return person_address_reader.ReadPersonAddress(); }
				}
			}
		}
	}
}
