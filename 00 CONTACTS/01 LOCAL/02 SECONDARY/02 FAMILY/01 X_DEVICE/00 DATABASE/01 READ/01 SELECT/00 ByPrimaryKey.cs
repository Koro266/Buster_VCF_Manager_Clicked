//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS			= CONTACTS.LOCAL.SECONDARY.FAMILY.XDEVICE.Column;
using FAMILY_XDEVICE	= CONTACTS.LOCAL.SECONDARY.FAMILY.XDEVICE.Row;
using READER			= CONTACTS.LOCAL.SECONDARY.FAMILY.XDEVICE.Database.FamilyDeviceReader;

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
			/// Returns FAMILY.X.Device constrained by pk_Family_X_Device.
			/// </summary>
			public class ByPrimaryKey
			{
				READER family_device_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Families_X_Devices.*  
					FROM 
						TDF_Families_X_Devices 
					WHERE 
						(((TDF_Families_X_Devices.pk_Family_X_Device)=@pk_family_x_device));
				";

				//___________________________________________________________________________________________________________________________________
				public ByPrimaryKey( int pk_fam_x_device )
				{
					COLUMNS.PK_Family_X_Device pk_column = new COLUMNS.PK_Family_X_Device( pk_fam_x_device );
					family_device_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public FAMILY_XDEVICE Execute
				{
					get { return family_device_reader.ReadFamilyDevice(); }
				}
			}
		}
	}
}
