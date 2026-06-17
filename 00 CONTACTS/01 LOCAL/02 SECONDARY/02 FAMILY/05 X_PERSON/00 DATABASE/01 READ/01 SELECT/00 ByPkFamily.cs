//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.FAMILY.XPERSON.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.FAMILY.XPERSON.Database.FamilyPersonReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XPERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Family_X_Perons constrained by pk_Family.
			/// </summary>
			public class ByPkFamily
			{
				READER family_person_reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Families_X_Persons.pk_Family_X_Person,
						TDF_Families_X_Persons.fk_Family,
						TDF_Families_X_Persons.fk_Person,
						TDF_Families_X_Persons.fk_Role,
						TDF_Persons.st_SortableName,
						TDF_Roles.st_Role
					FROM
						(
							(
								TDF_Families_X_Persons
								INNER JOIN TDF_Families ON TDF_Families_X_Persons.fk_Family = TDF_Families.pk_Family
							)
							INNER JOIN TDF_Persons ON TDF_Families_X_Persons.fk_Person = TDF_Persons.pk_Person
						)
						INNER JOIN TDF_Roles ON TDF_Families_X_Persons.fk_Role = TDF_Roles.pk_Role
					WHERE
						(((TDF_Families_X_Persons.fk_Family) = @fk_family))
					ORDER BY
						TDF_Families_X_Persons.si_Order;
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkFamily( int pk_family )
				{
					COLUMNS.PK_Family pk_column = new COLUMNS.PK_Family( pk_family );
					family_person_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public ByPkFamily( OleDbParameter parameter )
				{
					family_person_reader = new READER( sql_text, parameter );
				}
				//___________________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return family_person_reader.ReadFamilyPersons(); }
				}
			}
		}
	}
}
