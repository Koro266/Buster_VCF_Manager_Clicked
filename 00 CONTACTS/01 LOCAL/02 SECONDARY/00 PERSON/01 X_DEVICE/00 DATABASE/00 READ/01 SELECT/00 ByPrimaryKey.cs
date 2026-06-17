//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS			= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Column;
using PERSON_XDEVICE	= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Row;
using READER			= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Database.PersonDeviceReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns PERSON.X.Device constrained by pk_Person_X_Device.
			/// </summary>
			public class ByPrimaryKey
			{
				READER person_device_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Persons_X_Devices.*  
					FROM 
						TDF_Persons_X_Devices 
					WHERE 
						(((TDF_Persons_X_Devices.pk_Person_X_Device)=@pk_person_x_device));
				";

				//___________________________________________________________________________________________________________________________________
				public ByPrimaryKey( int pk )
				{
					COLUMNS.PK_Person_X_Device pk_column = new COLUMNS.PK_Person_X_Device( pk );
					person_device_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public PERSON_XDEVICE Execute
				{
					get { return person_device_reader.ReadPersonDevice(); }
				}
			}
		}
	}
}
