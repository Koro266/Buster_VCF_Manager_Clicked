//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Database.PersonDeviceReader;

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
			/// Returns PERSON.X.Devices constrained by pk_Person.
			/// </summary>
			public class ByPkPerson
			{
				READER person_device_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Persons_X_Devices.pk_Person_X_Device,
						TDF_Persons_X_Devices.fk_Person,
						TDF_Persons_X_Devices.fk_Device,
						TDF_Persons_X_Devices.st_ListOrder,
						TDF_Persons_X_Devices.st_Label
					FROM 
						TDF_Persons_X_Devices
					WHERE 
						(((TDF_Persons_X_Devices.fk_Person)=@fk_person))
					ORDER BY 
						TDF_Persons_X_Devices.st_ListOrder;
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkPerson( int pk_person )
				{
					COLUMNS.FK_Person fk_column = new COLUMNS.FK_Person( pk_person );
					person_device_reader = new READER( sql_text, fk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return person_device_reader.ReadPersonDevices(); }
				}
			}
		}
	}
}
