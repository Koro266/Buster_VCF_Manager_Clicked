//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS		= CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON.Column;
using READER		= CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON.Database.GroupPersonReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns PERSONs attached to a group.
			/// </summary>
			public class ByPkGroup
			{
				READER group_person_reader;
				private const string sql_text =
				@"
				SELECT
					TDF_Groups_X_Persons.pk_Group_X_Person,
					TDF_Groups_X_Persons.fk_Group,
					TDF_Groups_X_Persons.fk_Person,
					TDF_Groups_X_Persons.fk_Role,
					TDF_Persons.st_SortableName,
					TDF_Roles.st_Role
				FROM
					(
						TDF_Groups_X_Persons
						INNER JOIN TDF_Persons ON TDF_Groups_X_Persons.fk_Person = TDF_Persons.pk_Person
					)
					INNER JOIN TDF_Roles ON TDF_Groups_X_Persons.fk_Role = TDF_Roles.pk_Role
				WHERE
					(((TDF_Groups_X_Persons.fk_Group) = @pk_group));
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkGroup( int pk )
				{
					COLUMNS.PK_Person pk_column = new COLUMNS.PK_Person( pk );
					group_person_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public ByPkGroup( OleDbParameter parameter )
				{
					group_person_reader = new READER( sql_text, parameter );
				}
				//___________________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return group_person_reader.ReadPersonFamilys(); }
				}
			}
		}
	}
}
