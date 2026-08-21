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
		public class Insert
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// INSERTs fully-qualified TDF_Persons_X_Address. Returns true iff INSERT succeeds.
			/// </summary>
			public class Persons_X_Address : DB_CONNECTION
			{
				private const string sql_text =
				@"
					INSERT INTO
						TDF_Persons_X_Addresses
						(
							fk_Person,
							fk_Address,
							is_Selected
						)
						VALUES
						(
							= @fk_person,
							= @fk_address,
							= @is_selected
						);	
				";
				//_______________________________________________________________________________________________________________________________
				public Persons_X_Address( PERSON_X_ADDRESS person_x_address ) : base( sql_text )
				{
					base.DbCommand.Parameters.Add( person_x_address.FkPerson.DbParameter );
					base.DbCommand.Parameters.Add( person_x_address.FkAddress.DbParameter );
					base.DbCommand.Parameters.Add( person_x_address.Selected.DbParameter );
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
