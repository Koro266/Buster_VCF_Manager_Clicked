
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using PERSON_XNOTE_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XNOTE.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.PERSON.XNOTE.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.PERSON.XNOTE.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XNOTE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class PersonNoteReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public PersonNoteReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public PersonNoteReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public PERSON_XNOTE_ROW ReadPersonNote()
			{
				PERSON_XNOTE_ROW person_note;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					person_note = ReadRow();

					reader.Close();
					base.Connection.Close();
					return person_note;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadPersonNotes()
			{
				Dictionary<int, BASE_ROW> person_notes = new Dictionary<int, BASE_ROW>();
				PERSON_XNOTE_ROW person_note;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						person_note = ReadRow();
						person_notes.Add( person_note.PkPerson_X_Note.Value, person_note );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return person_notes;
			}
			//___________________________________________________________________________________________________________________________________________
			private PERSON_XNOTE_ROW ReadRow()
			{
				PERSON_XNOTE_ROW person_x_tag = new PERSON_XNOTE_ROW();

				person_x_tag.Append( new COLUMNS.PK_Person_X_Note	( base.GetPrimaryKey	( ORDINAL.PkPerson_X_Note )	) );
				person_x_tag.Append( new COLUMNS.PK_Person			( base.GetForeignKey	( ORDINAL.PkPerson )		) );
				person_x_tag.Append( new COLUMNS.LT_Note			( base.GetShortText		( ORDINAL.Note )			) );

				return person_x_tag;
			}
		}
	}
}
