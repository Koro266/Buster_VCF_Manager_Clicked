//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER	= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using FIELD			= CONTACTS.LOCAL.TERTIARY.DEVICE.Column;
using ORDINAL		= CONTACTS.LOCAL.TERTIARY.DEVICE.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class DeviceReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public DeviceReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public DeviceReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public DEVICE_ROW ReadDevice()
			{
				DEVICE_ROW device;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					device = ReadRow();

					reader.Close();
					base.Connection.Close();
					return device;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadDevices()
			{
				Dictionary<int, BASE_ROW> all_devices = new Dictionary<int, BASE_ROW>();
				DEVICE_ROW device;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						device = ReadRow();
						all_devices.Add( device.PkDevice.Value, device );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return all_devices;
			}
			//___________________________________________________________________________________________________________________________________________
			private DEVICE_ROW ReadRow()
			{
				DEVICE_ROW device = new DEVICE_ROW();

				device.Append( new FIELD.PK_Device			( base.GetPrimaryKey	( ORDINAL.PkDevice )		) );
				device.Append( new FIELD.FK_Country			( base.GetForeignKey	( ORDINAL.FkCountry )		) );
				device.Append( new FIELD.ST_LongAreaCode	( base.GetShortText		( ORDINAL.LongAreaCode )	) );
				device.Append( new FIELD.ST_ShortAreaCode	( base.GetShortText		( ORDINAL.ShortAreaCode )	) );
				device.Append( new FIELD.ST_LeadingDigits	( base.GetShortText		( ORDINAL.LeadingDigits )	) );
				device.Append( new FIELD.ST_TrailingDigits	( base.GetShortText		( ORDINAL.TrailingDigits )	) );
				device.Append( new FIELD.ST_DeviceLocation	( base.GetShortText		( ORDINAL.DeviceLocation )	) );
				device.Append( new FIELD.ST_DeviceType		( base.GetShortText		( ORDINAL.DeviceType )		) );
				device.Append( new FIELD.ST_DialNumber		( base.GetShortText		( ORDINAL.DialNumber )		) );
				device.Append( new FIELD.ST_PickerNumber	( base.GetShortText		( ORDINAL.PickerNumber )	) );
				device.Append( new FIELD.ST_Notes			( base.GetShortText		( ORDINAL.Notes )			) );
				device.Append( new FIELD.ST_CountryName		( base.GetShortText		( ORDINAL.CountryName)		) );
				device.Append( new FIELD.ST_CountryCode		( base.GetShortText		( ORDINAL.CountryCode)		) );
				device.Append( new FIELD.ST_ShortIsoCode	( base.GetShortText		( ORDINAL.ShortIsoCode)		) );
				device.Append( new FIELD.ST_LongIsoCode		( base.GetShortText		( ORDINAL.LongIsoCode)		) );

				return device;
			}
		}
	}
}
