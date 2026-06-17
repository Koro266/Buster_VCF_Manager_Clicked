
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using GROUP_X_DEVICE_ROW	= CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class GroupDeviceReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public GroupDeviceReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public GroupDeviceReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public GROUP_X_DEVICE_ROW ReadPersonDevice()
			{
				GROUP_X_DEVICE_ROW group;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					group = ReadRow();

					reader.Close();
					base.Connection.Close();
					return group;
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
				Dictionary<int, BASE_ROW> all_group_devices = new Dictionary<int, BASE_ROW>();
				GROUP_X_DEVICE_ROW group_x_device;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						group_x_device = ReadRow();
						all_group_devices.Add( group_x_device.PkGroup_X_Device.Value, group_x_device );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return all_group_devices;
			}
			//___________________________________________________________________________________________________________________________________________
			private GROUP_X_DEVICE_ROW ReadRow()
			{
				GROUP_X_DEVICE_ROW group_x_device = new GROUP_X_DEVICE_ROW();

				group_x_device.Append( new COLUMNS.PK_Group_X_Device	( base.GetPrimaryKey	( ORDINAL.PkGroup_X_Device ) ) );
				group_x_device.Append( new COLUMNS.FK_Group			( base.GetForeignKey	( ORDINAL.FkGroup ) ) );
				group_x_device.Append( new COLUMNS.FK_Device			( base.GetForeignKey	( ORDINAL.FkDevice ) ) );
				group_x_device.Append( new COLUMNS.ST_DialNumber		( base.GetShortText		( ORDINAL.DialNumber ) ) );
				group_x_device.Append( new COLUMNS.ST_Label			( base.GetShortText		( ORDINAL.Label ) ) );

				return group_x_device;
			}
		}
	}
}
