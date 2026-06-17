//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE.Database.GroupNoteReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns GROUP_X_Notes constrained by pk_Group.
			/// </summary>
			public class ByPkGroup
			{
				READER group_note_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Groups_X_Notes.pk_Group_X_Note,
						TDF_Groups_X_Notes.fk_Group,
						TDF_Groups_X_Notes.lt_Note 
					FROM 
						TDF_Groups_X_Notes
					WHERE 
						(((TDF_Groups_X_Notes.fk_Group) = @pk_group)) 
					ORDER BY
						TDF_Groups_X_Notes.lt_Note;
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkGroup( int pk_group )
				{
					COLUMNS.PK_Group pk_column = new COLUMNS.PK_Group( pk_group );
					group_note_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return group_note_reader.ReadGroupNotes(); }
				}
			}
		}
	}
}
