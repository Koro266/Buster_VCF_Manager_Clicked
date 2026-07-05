//___________________________________________________________________________________________________________________________________________________
//LOCAL
using FAMILY_ROW = CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using READER = CONTACTS.LOCAL.PRIMARY.FAMILY.Database.FamilyReader;
using COLUMNS = CONTACTS.LOCAL.PRIMARY.FAMILY.Column;

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
			/// Returns singleton TDF_Person constrained by PkPerson.
			/// </summary>
			public class ByPkFamily
			{
				public READER family_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Families.*
					FROM
						TDF_Families
					WHERE
						(((TDF_Families.pk_Family) = @pk_family ));
				";

				//_______________________________________________________________________________________________________________________________
				public ByPkFamily( int pk_family )
				{
					COLUMNS.PK_Family pk = new COLUMNS.PK_Family( pk_family );
					family_Reader = new READER( sql_text, pk.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				public FAMILY_ROW Execute
				{
					get 
					{
						FAMILY_ROW family_row = family_Reader.ReadFamily();
						return family_row;
					}
				}
			}
		}
	}
}
