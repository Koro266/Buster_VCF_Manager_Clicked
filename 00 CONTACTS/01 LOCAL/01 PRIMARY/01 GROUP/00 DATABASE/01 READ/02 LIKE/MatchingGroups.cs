//___________________________________________________________________________________________________________________________________________________
using System.Data;
using System.Data.OleDb;
//GLOBAL
using LIKE		= CONTACTS.GLOBAL.DATABASE.READ.Like;
using PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using REGEX		= CONTACTS.GLOBAL.VALUES.CONSTANT.LikeCriteria;
//LOCAL
using GROUP_ROW = CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using GROUP_READER = CONTACTS.LOCAL.PRIMARY.GROUP.Database.GroupReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________
		public partial class Like
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns PK_Group and GroupName rows where GroupName name begins with the given character(s).
			/// </summary>
			public class MatchingGroups : LIKE
			{
				private const string sql_text =
				@"
					SELECT 
						TDF_Groups.pk_Group, 
						TDF_Groups.st_GroupName 
					FROM 
						TDF_Groups 
					WHERE 
						(((TDF_Groups.st_GroupName) LIKE @subtext)) 
					ORDER BY 
						TDF_Groups.st_GroupName;
				";

				private const string sql_count = 
				@"
					SELECT
						Count(pk_Group)
					FROM
						TDF_Groups
					WHERE
						(((TDF_Groups.st_GroupName) LIKE @subtext));
				";

				//___________________________________________________________________________________________________________________________
				public MatchingGroups( string sought_after_text )
				{
					base.SetParameter = sought_after_text;
					base.SetCount = sql_count;
					base.SetSelect = sql_text;
				}
			}
		}
	}
}
