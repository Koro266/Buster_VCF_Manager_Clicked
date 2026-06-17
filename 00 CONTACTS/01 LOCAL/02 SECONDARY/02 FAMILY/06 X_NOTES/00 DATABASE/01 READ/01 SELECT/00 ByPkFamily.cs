//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.FAMILY.XNOTE.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.FAMILY.XNOTE.Database.FamilyNoteReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XNOTE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns FAMILY_X_Notes constrained by pk_Family.
			/// </summary>
			public class ByPkFamily
			{
				READER family_note_reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Families_X_Notes.pk_Family_X_Note,
						TDF_Families_X_Notes.fk_Family,
						TDF_Families_X_Notes.lt_Note
					FROM
						TDF_Families_X_Notes
					WHERE
						(((TDF_Families_X_Notes.fk_Family) = @fk_family));
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkFamily( int pk_family )
				{
					COLUMNS.FK_Family pk_column = new COLUMNS.FK_Family( pk_family );
					family_note_reader = new READER( sql_text, pk_column.DbParameter );
				}
				////___________________________________________________________________________________________________________________________________
				//public ByPkFamily( OleDbParameter parameter )
				//{
				//	family_note_reader = new READER( sql_text, parameter );
				//}
				//___________________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return family_note_reader.ReadFamilyNotes(); }
				}
			}
		}
	}
}
