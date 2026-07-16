//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using UNIQUE = CONTACTS.GLOBAL.DATABASE.READ.Unique;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________________
			public partial class Unique
			{
				//___________________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns all unique metropolitan names from TDF_Addresses.
				/// </summary>
				public class Metropolitans : UNIQUE
				{
					private const string sql_text =
					@"
						SELECT DISTINCT 
							TDF_Addresses.st_Metropolitan
						FROM 
							TDF_Addresses
						WHERE 
							((st_Metropolitan Is Not Null AND Len(RTrim(LTrim(st_Metropolitan))) > 0))
						ORDER 
							BY TDF_Addresses.st_Metropolitan;
					";

					//_______________________________________________________________________________________________________________________________
					public Metropolitans() : base( sql_text )
					{
					}
				}
			}
		}
	}
}
