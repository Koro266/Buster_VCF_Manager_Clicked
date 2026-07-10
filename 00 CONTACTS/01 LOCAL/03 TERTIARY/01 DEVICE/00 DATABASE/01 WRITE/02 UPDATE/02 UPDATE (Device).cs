//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.CONNECTION;
//LOCAL
using DEVICE_ROW = CONTACTS.LOCAL.TERTIARY.DEVICE.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class Update
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// UPDATEs existing TDF_Devices row specified by pk_Device.
			/// </summary>
			public class Device : DbConnection
			{
				private const string sql_text =
				@"
					UPDATE 
						TDF_Devices 
					SET 
						TDF_Devices.fk_Country			=	@fk_country,
						TDF_Devices.st_LongAreaCode		=	@st_longareacode,
						TDF_Devices.st_ShortAreaCode	=	@st_shortareacode,
						TDF_Devices.st_LeadingDigits	=	@st_leadingdigits,
						TDF_Devices.st_TrailingDigits	=	@st_trailingdigits,
						TDF_Devices.st_DeviceLocation	=	@st_devicelocation,
						TDF_Devices.st_DeviceType		=	@st_devicetype,
						TDF_Devices.st_DialNumber		=	@st_dialnumber,
						TDF_Devices.st_PickerNumber		=	@st_pickernumber,
						TDF_Devices.st_Notes			=	@st_notes
					WHERE 
						(((TDF_Devices.pk_Device)=@pk_device));
				";

				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Updates all columns of a single, existing, TDF_Devices row specified by pk_Device.
				/// </summary>
				public Device( DEVICE_ROW device ) : base( sql_text )
				{
					base.DbCommand.Parameters.Add( device.FkCountry.DbParameter );
					base.DbCommand.Parameters.Add( device.LongAreaCode.DbParameter );
					base.DbCommand.Parameters.Add( device.ShortAreaCode.DbParameter );
					base.DbCommand.Parameters.Add( device.LeadingDigits.DbParameter );
					base.DbCommand.Parameters.Add( device.TrailingDigits.DbParameter );
					base.DbCommand.Parameters.Add( device.DeviceLocation.DbParameter );
					base.DbCommand.Parameters.Add( device.DeviceType.DbParameter );
					base.DbCommand.Parameters.Add( device.DialNumber.DbParameter );
					base.DbCommand.Parameters.Add( device.PickerNumber.DbParameter );
					base.DbCommand.Parameters.Add( device.Notes.DbParameter );
					base.DbCommand.Parameters.Add( device.PkDevice.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
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
