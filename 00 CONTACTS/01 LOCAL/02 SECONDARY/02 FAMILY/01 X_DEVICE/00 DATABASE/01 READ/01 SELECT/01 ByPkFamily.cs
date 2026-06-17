//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.FAMILY.XDEVICE.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.FAMILY.XDEVICE.Database.FamilyDeviceReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XDEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns PK_Devices attached to a family.
			/// </summary>
			public class ByPkFamily
			{
				READER family_device_reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Families_X_Devices.pk_Family_X_Device,
						TDF_Families_X_Devices.fk_Family,
						TDF_Families_X_Devices.fk_Device,
						TDF_Devices.st_DialNumber,
						TDF_Families_X_Devices.st_Label
					FROM
						(
							TDF_Families_X_Devices
							INNER JOIN TDF_Families ON TDF_Families_X_Devices.fk_Family = TDF_Families.pk_Family
						)
						INNER JOIN TDF_Devices ON TDF_Families_X_Devices.fk_Device = TDF_Devices.pk_Device
					WHERE
						(
							((TDF_Families_X_Devices.fk_Family) = @fk_family)
						)
					ORDER BY
						TDF_Families_X_Devices.st_ListOrder;
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkFamily( int pk_family )
				{
					COLUMNS.FK_Family fk_column = new COLUMNS.FK_Family( pk_family );
					family_device_reader = new READER( sql_text, fk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return family_device_reader.ReadFamilyDevices(); }
				}
			}
		}
	}
}
