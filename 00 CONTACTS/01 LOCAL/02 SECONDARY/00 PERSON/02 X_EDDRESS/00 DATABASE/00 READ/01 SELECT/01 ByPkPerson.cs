//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS.Database.PersonEddressReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns PERSON.X.Eddresses constrained by pk_Person.
			/// </summary>
			public class ByPkPerson
			{
				READER person_eddress_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Persons_X_Eddresses.pk_Person_X_Eddress,
						TDF_Persons_X_Eddresses.fk_Person,
						TDF_Persons_X_Eddresses.fk_Eddress,
						TDF_Persons_X_Eddresses.st_ListOrder,
						TDF_Persons_X_Eddresses.st_Label
					FROM 
						TDF_Persons_X_Eddresses
					WHERE 
						(((TDF_Persons_X_Eddresses.fk_Person)=@fk_person))
					ORDER BY 
						TDF_Persons_X_Eddresses.st_ListOrder;
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkPerson( int pk_person )
				{
					COLUMNS.FK_Person fk_column = new COLUMNS.FK_Person( pk_person );
					person_eddress_reader = new READER( sql_text, fk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return person_eddress_reader.ReadPersonEddresses(); }
				}
			}
		}
	}
}
