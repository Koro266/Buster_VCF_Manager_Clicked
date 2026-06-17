
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using PERSON_XNOTE_ROW		= CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class GroupNoteReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public GroupNoteReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public GroupNoteReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public PERSON_XNOTE_ROW ReadGroupNote()
			{
				PERSON_XNOTE_ROW group_note;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					group_note = ReadRow();

					reader.Close();
					base.Connection.Close();
					return group_note;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadGroupNotes()
			{
				Dictionary<int, BASE_ROW> group_notes = new Dictionary<int, BASE_ROW>();
				PERSON_XNOTE_ROW group_note;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						group_note = ReadRow();
						group_notes.Add( group_note.PkGroup_X_Note.Value, group_note );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return group_notes;
			}
			//___________________________________________________________________________________________________________________________________________
			private PERSON_XNOTE_ROW ReadRow()
			{
				PERSON_XNOTE_ROW group_x_tag = new PERSON_XNOTE_ROW();

				group_x_tag.Append( new COLUMNS.PK_Group_X_Note	( base.GetPrimaryKey	( ORDINAL.PkGroup_X_Note )	) );
				group_x_tag.Append( new COLUMNS.PK_Group			( base.GetForeignKey	( ORDINAL.PkGroup )		) );
				group_x_tag.Append( new COLUMNS.LT_Note			( base.GetShortText		( ORDINAL.Note )			) );

				return group_x_tag;
			}
		}
	}
}
