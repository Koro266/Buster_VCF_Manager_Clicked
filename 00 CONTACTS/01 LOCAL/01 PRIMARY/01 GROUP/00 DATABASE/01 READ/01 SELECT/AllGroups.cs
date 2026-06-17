//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using READER	= CONTACTS.LOCAL.PRIMARY.GROUP.Database.GroupReader;

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
			/// Returns all TDF_Group rows currently held in TDF_Groups.
			/// </summary>
			public class AllGroups
			{
				private READER group_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Groups.*
					FROM
						TDF_Groups 
					ORDER BY
						TDF_Groups.pk_Group;
				";
				//_______________________________________________________________________________________________________________________________
				public AllGroups()
				{
					group_Reader = new GroupReader( sql_text );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return group_Reader.ReadGroups(); }
				}
			}
		}
	}
}
