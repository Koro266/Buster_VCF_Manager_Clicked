
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using FAMILY_X_DEVICE_ROW	= CONTACTS.LOCAL.SECONDARY.FAMILY.XDEVICE.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.FAMILY.XDEVICE.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.FAMILY.XDEVICE.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XDEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class FamilyDeviceReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public FamilyDeviceReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public FamilyDeviceReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public FAMILY_X_DEVICE_ROW ReadFamilyDevice()
			{
				FAMILY_X_DEVICE_ROW person;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					person = ReadRow();

					reader.Close();
					base.Connection.Close();
					return person;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadFamilyDevices()
			{
				Dictionary<int, BASE_ROW> all_person_devices = new Dictionary<int, BASE_ROW>();
				FAMILY_X_DEVICE_ROW person_x_device;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						person_x_device = ReadRow();
						all_person_devices.Add( person_x_device.PkFamily_X_Device.Value, person_x_device );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return all_person_devices;
			}
			//___________________________________________________________________________________________________________________________________________
			private FAMILY_X_DEVICE_ROW ReadRow()
			{
				FAMILY_X_DEVICE_ROW person_x_device = new FAMILY_X_DEVICE_ROW();

				person_x_device.Append( new COLUMNS.PK_Family_X_Device	( base.GetPrimaryKey	( ORDINAL.PkFamily_X_Device ) ) );
				person_x_device.Append( new COLUMNS.FK_Family			( base.GetForeignKey	( ORDINAL.FkFamily ) ) );
				person_x_device.Append( new COLUMNS.FK_Device			( base.GetForeignKey	( ORDINAL.FkDevice ) ) );
				person_x_device.Append( new COLUMNS.ST_DialNumber		( base.GetShortText		( ORDINAL.DialNumber ) ) );
				person_x_device.Append( new COLUMNS.ST_Label			( base.GetShortText		( ORDINAL.Label ) ) );

				return person_x_device;
			}
		}
	}
}
