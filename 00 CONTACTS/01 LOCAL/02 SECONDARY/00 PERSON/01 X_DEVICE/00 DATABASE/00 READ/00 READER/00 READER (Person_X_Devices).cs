
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using PERSON_X_DEVICE_ROW	= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class PersonDeviceReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public PersonDeviceReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public PersonDeviceReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public PERSON_X_DEVICE_ROW ReadPersonDevice()
			{
				PERSON_X_DEVICE_ROW person;

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
			public Dictionary<int, BASE_ROW> ReadPersonDevices()
			{
				Dictionary<int, BASE_ROW> all_person_devices = new Dictionary<int, BASE_ROW>();
				PERSON_X_DEVICE_ROW person_x_device;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						person_x_device = ReadRow();
						all_person_devices.Add( person_x_device.PkPerson_X_Device.Value, person_x_device );
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
			private PERSON_X_DEVICE_ROW ReadRow()
			{
				PERSON_X_DEVICE_ROW person_x_device = new PERSON_X_DEVICE_ROW();

				person_x_device.Append( new COLUMNS.PK_Person_X_Device	( base.GetPrimaryKey	( ORDINAL.PkPerson_X_Device ) ) );
				person_x_device.Append( new COLUMNS.FK_Person			( base.GetForeignKey	( ORDINAL.FkPerson ) ) );
				person_x_device.Append( new COLUMNS.FK_Device			( base.GetForeignKey	( ORDINAL.FkDevice ) ) );
				person_x_device.Append( new COLUMNS.ST_ListOrder		( base.GetShortText		( ORDINAL.ListOrder ) ) );
				person_x_device.Append( new COLUMNS.ST_Label			( base.GetShortText		( ORDINAL.Label ) ) );

				return person_x_device;
			}
		}
	}
}
