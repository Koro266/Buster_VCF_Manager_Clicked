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
			/// Returns singleton TDF_Group constrained by DefaultRow = True.
			/// </summary>
			public class DefaultGroup
			{
				private GroupReader group_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Groups.*
					FROM
						TDF_Groups
					WHERE
						(((TDF_Groups.is_DefaultRow) = True ));
				";

				//_______________________________________________________________________________________________________________________________
				public DefaultGroup()
				{
					group_Reader = new GroupReader( sql_text );
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
