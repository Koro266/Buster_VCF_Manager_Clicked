//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
using BASE_READER	= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using FIELD			= CONTACTS.LOCAL.TERTIARY.ROLE.Column;
using ORDINAL		= CONTACTS.LOCAL.TERTIARY.ROLE.Constants.OrdinalByName;
using ROLE_ROW		= CONTACTS.LOCAL.TERTIARY.ROLE.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ROLE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class RoleReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public RoleReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public RoleReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public ROLE_ROW ReadRole()
			{
				ROLE_ROW role;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					role = ReadRow();

					reader.Close();
					base.Connection.Close();
					return role;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadRoles()
			{
				Dictionary<int, BASE_ROW> all_roles = new Dictionary<int, BASE_ROW>();
				ROLE_ROW role;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						role = ReadRow();
						all_roles.Add( role.PkRole.Value, role );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return all_roles;
			}
			//___________________________________________________________________________________________________________________________________________
			private ROLE_ROW ReadRow()
			{
				ROLE_ROW website = new ROLE_ROW();

				website.Append( new FIELD.PK_Role	( base.GetPrimaryKey	( ORDINAL.PkRole ) ) );
				website.Append( new FIELD.ST_Role	( base.GetShortText		( ORDINAL.Role ) ) );

				return website;
			}
		}
	}
}
