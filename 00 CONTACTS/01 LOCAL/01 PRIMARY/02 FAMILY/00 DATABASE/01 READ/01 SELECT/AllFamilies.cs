//___________________________________________________________________________________________________________________________________________________
using System.Windows.Forms;
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using READER		= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.FamilyReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns all TDF_Families rows.
			/// </summary>
			public class AllFamilys
			{
				private READER family_Reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Families.* 
					FROM 
						TDF_Families;
				";
				//_______________________________________________________________________________________________________________________________
				public AllFamilys()
				{
					family_Reader = new READER( sql_text );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return family_Reader.ReadFamilies(); }
				}
			}
		}
	}
}
