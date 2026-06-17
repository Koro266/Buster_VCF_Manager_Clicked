
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER		= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using FAMILY_XADDRESS	= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Row;
using COLUMNS			= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Column;
using ORDINAL			= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class FamilyAddressReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public FamilyAddressReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public FamilyAddressReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public FAMILY_XADDRESS ReadFamilyAddress()
			{
				FAMILY_XADDRESS family;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					family = ReadRow();

					reader.Close();
					base.Connection.Close();
					return family;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadFamilyAddresses()
			{
				Dictionary<int, BASE_ROW> family_addresses = new Dictionary<int, BASE_ROW>();
				FAMILY_XADDRESS family_address;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						family_address = ReadRow();
						family_addresses.Add( family_address.PkFamily_X_Address.Value, family_address );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return family_addresses;
			}
			//___________________________________________________________________________________________________________________________________________
			private FAMILY_XADDRESS ReadRow()
			{
				FAMILY_XADDRESS family_x_address = new FAMILY_XADDRESS();

				family_x_address.Append( new COLUMNS.PK_Family_X_Address	( base.GetPrimaryKey	( ORDINAL.PkFamily_X_Address )	) );
				family_x_address.Append( new COLUMNS.FK_Family				( base.GetForeignKey	( ORDINAL.FkFamily )			) );
				family_x_address.Append( new COLUMNS.FK_Address				( base.GetForeignKey	( ORDINAL.FkAddress )			) );
				family_x_address.Append( new COLUMNS.ST_AddressType			( base.GetShortText		( ORDINAL.AddressType )			) );

				return family_x_address;
			}
		}
	}
}
