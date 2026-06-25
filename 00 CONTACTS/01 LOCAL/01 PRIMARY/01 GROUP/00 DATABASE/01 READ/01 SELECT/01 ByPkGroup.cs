//___________________________________________________________________________________________________________________________________________________
//LOCAL
using GROUP_ROW = CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using COLUMNS = CONTACTS.LOCAL.PRIMARY.GROUP.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns singleton TDF_Group constrained by PkGroup.
			/// </summary>
			public class ByPkGroup
			{
				private GroupReader group_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Groups.*
					FROM
						TDF_Groups
					WHERE
						(((TDF_Groups.pk_Group) = @pk_group ));
				";

				//_______________________________________________________________________________________________________________________________
				public ByPkGroup( int pk_group )
				{
					COLUMNS.PK_Group pk = new COLUMNS.PK_Group( pk_group );
					group_Reader = new GroupReader( sql_text, pk.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				public GROUP_ROW Execute
				{
					get { return group_Reader.ReadGroup(); }
				}
			}
		}
	}
}
