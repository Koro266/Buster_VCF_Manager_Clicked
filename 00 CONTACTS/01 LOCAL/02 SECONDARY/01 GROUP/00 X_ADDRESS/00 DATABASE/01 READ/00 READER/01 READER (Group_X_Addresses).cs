
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER		= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using PERSON_XADDRESS	= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Row;
using COLUMNS			= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Column;
using ORDINAL			= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class GroupAddressReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public GroupAddressReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public GroupAddressReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public PERSON_XADDRESS ReadGroupAddress()
			{
				PERSON_XADDRESS group;

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
			public Dictionary<int, BASE_ROW> ReadGroupAddresses()
			{
				Dictionary<int, BASE_ROW> all_group_addresses = new Dictionary<int, BASE_ROW>();
				PERSON_XADDRESS group_x_address;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						group_x_address = ReadRow();
						all_group_addresses.Add( group_x_address.PkGroup_X_Address.Value, group_x_address );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return all_group_addresses;
			}
			//___________________________________________________________________________________________________________________________________________
			private PERSON_XADDRESS ReadRow()
			{
				PERSON_XADDRESS group_x_address = new PERSON_XADDRESS();

				group_x_address.Append( new COLUMNS.PK_Group_X_Address	( base.GetPrimaryKey	( ORDINAL.PkGroup_X_Address )	) );
				group_x_address.Append( new COLUMNS.FK_Group			( base.GetForeignKey	( ORDINAL.FkGroup )			) );
				group_x_address.Append( new COLUMNS.FK_Address			( base.GetForeignKey	( ORDINAL.FkAddress )			) );

				return group_x_address;
			}
		}
	}
}
