//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using SELECT	= CONTACTS.GLOBAL.DATABASE.READ.Select;
//LOCAL
using ROLE_ROW	= CONTACTS.LOCAL.TERTIARY.ROLE.Row;
using COLUMNS	= CONTACTS.LOCAL.TERTIARY.ROLE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ROLE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns singleton TDF_Role constrained by PkRole.
			/// </summary>
			public class ByPkRole
			{
				private RoleReader role_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Roles.*
					FROM
						TDF_Roles
					WHERE
						(((TDF_Roles.pk_Role) = @pk_role ));
				";

				//_______________________________________________________________________________________________________________________________
				public ByPkRole( int pk_role)
				{
					COLUMNS.PK_Role pk = new COLUMNS.PK_Role( pk_role );
					role_Reader = new RoleReader( sql_text, pk.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				public ROLE_ROW Execute
				{
					get { return role_Reader.ReadRole(); }
				}
			}
		}
	}
}
