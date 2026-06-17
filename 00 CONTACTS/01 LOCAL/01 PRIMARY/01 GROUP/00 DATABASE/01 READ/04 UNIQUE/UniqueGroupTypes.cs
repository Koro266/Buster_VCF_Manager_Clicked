//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//LOCAL
using ADDRESS_ROW = CONTACTS.LOCAL.PRIMARY.GROUP.Row;
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
			/// Returns all unique group types from TDF_Groups.
			/// </summary>
			public class UniqueGroupTypes
			{
				private const string sql_text =
				@"
					SELECT DISTINCT 
						TDF_Groups.st_GroupType 
					FROM 
						TDF_Groups 
					WHERE 
						((st_GroupType Is Not Null AND LEN(RTRIM(LTRIM(st_GroupType))) > 0))
					ORDER BY 
						TDF_Groups.st_GroupType;
				";

				//_______________________________________________________________________________________________________________________________
				public UniqueGroupTypes()
				{ }
				//_______________________________________________________________________________________________________________________________
				public List<string> Execute
				{
					get
					{
						GroupReader group_Reader = new GroupReader( sql_text );
						return group_Reader.ReadStringList;
					}
				}
			}
		}
	}
}
