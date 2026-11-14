//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using DB_CONNECTION		= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnection;
//LOCAL
using PERSON_ROW			= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using PERSON_X_ADDRESS	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Row;
using ADDRESS_ROW			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//_______________________________________________________________________________________________________________________________________
		public class Insert
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// INSERTs TDF_Persons_X_Address row.
			/// </summary>
			public class Persons_X_Address : DB_CONNECTION
			{
				private const string sql_text =
				@"
					INSERT INTO
						TDF_Persons_X_Addresses
						(
							fk_Person,
							fk_Address
						)
						VALUES
						(
							= @fk_person,
							= @fk_address
						);	
				";
				//_______________________________________________________________________________________________________________________________
				public Persons_X_Address( PERSON_ROW person_row, ADDRESS_ROW address_row ) : base( sql_text )
				{
					base.DbCommand.Parameters.Add( person_row.PkPerson.DbParameter );
					base.DbCommand.Parameters.Add( address_row.PkAddress.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns true if INSERT succeeds, false otherwise.
				/// </summary>
				public bool Execute
				{
					get
					{
						try
						{
							base.Connection.Open();
							base.DbCommand.ExecuteNonQuery();
							base.Connection.Close();
							return true;
						}
						catch ( Exception e )
						{
							Connection.Close();
							return false;
						}
					}
				}
			}
		}
	}
}
