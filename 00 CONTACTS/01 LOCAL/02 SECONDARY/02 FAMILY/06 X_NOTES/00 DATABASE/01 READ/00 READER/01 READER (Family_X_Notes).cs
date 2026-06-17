
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using FAMILY_XNOTE_ROW		= CONTACTS.LOCAL.SECONDARY.FAMILY.XNOTE.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.FAMILY.XNOTE.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.FAMILY.XNOTE.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XNOTE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class FamilyNoteReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public FamilyNoteReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public FamilyNoteReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public FAMILY_XNOTE_ROW ReadFamilyNote()
			{
				FAMILY_XNOTE_ROW family_note;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					family_note = ReadRow();

					reader.Close();
					base.Connection.Close();
					return family_note;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadFamilyNotes()
			{
				Dictionary<int, BASE_ROW> family_notes = new Dictionary<int, BASE_ROW>();
				FAMILY_XNOTE_ROW family_note;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						family_note = ReadRow();
						family_notes.Add( family_note.PkFamily_X_Note.Value, family_note );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return family_notes;
			}
			//___________________________________________________________________________________________________________________________________________
			private FAMILY_XNOTE_ROW ReadRow()
			{
				FAMILY_XNOTE_ROW family_x_tag = new FAMILY_XNOTE_ROW();

				family_x_tag.Append( new COLUMNS.PK_Family_X_Note	( base.GetPrimaryKey	( ORDINAL.PkFamily_X_Note )	) );
				family_x_tag.Append( new COLUMNS.FK_Family			( base.GetForeignKey	( ORDINAL.FkFamily )		) );
				family_x_tag.Append( new COLUMNS.LT_Note			( base.GetShortText		( ORDINAL.Note )			) );

				return family_x_tag;
			}
		}
	}
}
