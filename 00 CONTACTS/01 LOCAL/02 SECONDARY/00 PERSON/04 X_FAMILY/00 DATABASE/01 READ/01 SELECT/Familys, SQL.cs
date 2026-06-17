//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY.Database.PersonFamilyReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns PERSON.X.Familys constrained by pk_Person.
			/// </summary>
			public class ByPkPerson
			{
				READER person_family_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Families_X_Persons.pk_Family_X_Person,
						TDF_Families_X_Persons.fk_Person,
						TDF_Families.pk_Family,
						TDF_Roles.pk_Role,
						TDF_Families.st_SortableName,
						TDF_Roles.st_Role
					FROM 
						(
							TDF_Families 
							INNER JOIN TDF_Families_X_Persons ON TDF_Families.pk_Family = TDF_Families_X_Persons.fk_Family
						)
						INNER JOIN TDF_Roles ON TDF_Families_X_Persons.fk_Role = TDF_Roles.pk_Role
					WHERE 
						(
							((TDF_Families_X_Persons.fk_Person) = @pk_person)
						)
					ORDER BY 
						TDF_Families.st_SortableName;
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkPerson( int pk )
				{
					COLUMNS.PK_Person pk_column = new COLUMNS.PK_Person( pk );
					person_family_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public ByPkPerson( OleDbParameter parameter )
				{
					person_family_reader = new READER( sql_text, parameter );
				}
				//___________________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return person_family_reader.ReadPersonFamilys(); }
				}
			}
		}
	}
}
