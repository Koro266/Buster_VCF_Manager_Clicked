
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER		= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using PERSON_XADDRESS	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Row;
using COLUMNS			= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Column;
using ORDINAL			= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class PersonAddressReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public PersonAddressReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public PersonAddressReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public PERSON_XADDRESS ReadPersonAddress()
			{
				PERSON_XADDRESS person;

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
			public Dictionary<int, BASE_ROW> ReadPersonAddresses()
			{
				Dictionary<int, BASE_ROW> all_person_addresses = new Dictionary<int, BASE_ROW>();
				PERSON_XADDRESS person_x_address;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						person_x_address = ReadRow();
						all_person_addresses.Add( person_x_address.PkPerson_X_Address.Value, person_x_address );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return all_person_addresses;
			}
			//___________________________________________________________________________________________________________________________________________
			private PERSON_XADDRESS ReadRow()
			{
				PERSON_XADDRESS person_x_address = new PERSON_XADDRESS();

				person_x_address.Append( new COLUMNS.PK_Person_X_Address	( base.GetPrimaryKey	( ORDINAL.PkPerson_X_Address )	) );
				person_x_address.Append( new COLUMNS.FK_Person				( base.GetForeignKey	( ORDINAL.FkPerson )			) );
				person_x_address.Append( new COLUMNS.FK_Address				( base.GetForeignKey	( ORDINAL.FkAddress )			) );
				person_x_address.Append( new COLUMNS.ST_AddressType			( base.GetShortText		( ORDINAL.AddressType )			) );

				return person_x_address;
			}
		}
	}
}
