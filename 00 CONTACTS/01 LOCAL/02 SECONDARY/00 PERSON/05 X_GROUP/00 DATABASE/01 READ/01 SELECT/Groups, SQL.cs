//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS		= CONTACTS.LOCAL.SECONDARY.PERSON.XGROUP.Column;
using READER		= CONTACTS.LOCAL.SECONDARY.PERSON.XGROUP.Database.PersonGroupReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XGROUP
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
				READER person_group_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Groups_X_Persons.pk_Group_X_Person,
						TDF_Persons.pk_Person,
						TDF_Groups.pk_Group,
						TDF_Roles.pk_Role,
						TDF_Groups.st_GroupName,
						TDF_Roles.st_Role 
					FROM 
						(
							(
								TDF_Groups_X_Persons 
								INNER JOIN TDF_Groups ON TDF_Groups_X_Persons.fk_Group = TDF_Groups.pk_Group
							)
							INNER JOIN TDF_Persons ON TDF_Groups_X_Persons.fk_Person = TDF_Persons.pk_Person
						)
						INNER JOIN TDF_Roles ON TDF_Groups_X_Persons.fk_Role = TDF_Roles.pk_Role 
					WHERE 
						(((TDF_Persons.pk_Person) = @pk_person)) 
					ORDER BY 
						TDF_Groups.st_GroupName;
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkPerson( int pk )
				{
					COLUMNS.PK_Person pk_column = new COLUMNS.PK_Person( pk );
					person_group_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public ByPkPerson( OleDbParameter parameter )
				{
					person_group_reader = new READER( sql_text, parameter );
				}
				//___________________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return person_group_reader.ReadPersonFamilys(); }
				}
			}
		}
	}
}
