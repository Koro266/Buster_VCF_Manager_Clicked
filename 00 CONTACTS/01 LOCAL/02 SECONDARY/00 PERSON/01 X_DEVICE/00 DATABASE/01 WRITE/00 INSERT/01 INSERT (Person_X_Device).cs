//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using DB_CONNECTION		= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnection;
//LOCAL
using PERSON_X_DEVICE	= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//_______________________________________________________________________________________________________________________________________
		public class Insert
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// INSERTs TDF_Persons_X_Devices row.
			/// </summary>
			public class Persons_X_Device : DB_CONNECTION
			{
				private const string sql_text =
				@"
					INSERT INTO
						TDF_Persons_X_Devices
						(
							fk_Person,
							fk_Device,
							st_ListOrder,
							st_Label
						)
						VALUES
						(
							@fk_person,
							@fk_address,
							@st_ListOrder,
							@st_Label
						);	
				";
				//_______________________________________________________________________________________________________________________________
				public Persons_X_Device( PERSON_X_DEVICE person_x_device ) : base( sql_text )
				{
					base.DbCommand.Parameters.Add( person_x_device.FkPerson.DbParameter );
					base.DbCommand.Parameters.Add( person_x_device.FkDevice.DbParameter );
					base.DbCommand.Parameters.Add( person_x_device.ListOrder.DbParameter );
					base.DbCommand.Parameters.Add( person_x_device.Label.DbParameter );
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
