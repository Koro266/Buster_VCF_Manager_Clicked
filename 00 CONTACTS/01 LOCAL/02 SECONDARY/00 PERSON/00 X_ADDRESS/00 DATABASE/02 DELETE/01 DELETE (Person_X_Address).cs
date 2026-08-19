//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using DB_CONNECTION		= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnection;
//LOCAL
using PERSON_X_ADDRESS	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//_______________________________________________________________________________________________________________________________________
		public class Delete
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// DELETEs the Person_X_Address row defined by fk_Person & fk_Address. Returns TRUE iff DELETE succeeds.
			/// </summary>
			public class Persons_X_Address : DB_CONNECTION
			{
				private const string sql_text =
				@"
					DELETE
						TDF_Persons_X_Addresses.fk_Person,
						TDF_Persons_X_Addresses.fk_Address
					FROM
						TDF_Persons_X_Addresses
					WHERE
					(
						((TDF_Persons_X_Addresses.fk_Person) = @fk_person)
						AND ((TDF_Persons_X_Addresses.fk_Address) = @fk_address)
					);
				";
				//_______________________________________________________________________________________________________________________________
				public Persons_X_Address( PERSON_X_ADDRESS person_x_address ) : base( sql_text )
				{
					base.DbCommand.Parameters.Add( person_x_address.FkPerson.DbParameter );
					base.DbCommand.Parameters.Add( person_x_address.FkAddress.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns true iff DELETE succeeds.
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
