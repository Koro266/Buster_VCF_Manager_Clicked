//___________________________________________________________________________________________________________________________________________________
//LOCAL
using FAMILY_ROW = CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using READER = CONTACTS.LOCAL.PRIMARY.FAMILY.Database.FamilyReader;

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
			/// Returns singleton TDF_Person constrained by DefaultRow = True.
			/// </summary>
			public class DefaultFamily
			{
				public READER family_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Families.*
					FROM
						TDF_Families
					WHERE
						(((TDF_Families.is_DefaultRow) = True ));
				";

				//_______________________________________________________________________________________________________________________________
				public DefaultFamily()
				{
					family_Reader = new READER( sql_text );
				}
				//_______________________________________________________________________________________________________________________________
				public FAMILY_ROW Execute
				{
					get { return family_Reader.ReadFamily(); }
				}
			}
		}
	}
}
