//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.PERSON.XNOTE.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.PERSON.XNOTE.Database.PersonNoteReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XNOTE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns PERSON_X_Notes constrained by pk_Person.
			/// </summary>
			public class ByPkPerson
			{
				READER person_note_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Persons_X_Notes.pk_Person_X_Note,
						TDF_Persons_X_Notes.fk_Person,
						TDF_Persons_X_Notes.lt_Note 
					FROM 
						TDF_Persons_X_Notes 
					WHERE 
						(((TDF_Persons_X_Notes.fk_Person) = @pk_person)) 
					ORDER BY 
						TDF_Persons_X_Notes.si_Order;
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkPerson( int pk )
				{
					COLUMNS.PK_Person pk_column = new COLUMNS.PK_Person( pk );
					person_note_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public ByPkPerson( OleDbParameter parameter )
				{
					person_note_reader = new READER( sql_text, parameter );
				}
				//___________________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return person_note_reader.ReadPersonNotes(); }
				}
			}
		}
	}
}
