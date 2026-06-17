//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE.Database.GroupDeviceReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Devices attached to a Group.
			/// </summary>
			public class ByPkGroup
			{
				READER group_device_reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Groups_X_Devices.pk_Group_X_Device,
						TDF_Groups.pk_Group,
						TDF_Devices.pk_Device,
						TDF_Devices.st_DialNumber,
						TDF_Groups_X_Devices.st_Label
					FROM
						(
							TDF_Groups
							INNER JOIN TDF_Groups_X_Devices ON TDF_Groups.pk_Group = TDF_Groups_X_Devices.fk_Group
						)
						INNER JOIN TDF_Devices ON TDF_Groups_X_Devices.fk_Device = TDF_Devices.pk_Device
					WHERE
						(((TDF_Groups.pk_Group) = @fk_group))
					ORDER BY
						TDF_Groups_X_Devices.st_ListOrder;
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkGroup( int pk_group )
				{
					COLUMNS.FK_Group fk_column = new COLUMNS.FK_Group( pk_group );
					group_device_reader = new READER( sql_text, fk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return group_device_reader.ReadPersonDevices(); }
				}
			}
		}
	}
}
