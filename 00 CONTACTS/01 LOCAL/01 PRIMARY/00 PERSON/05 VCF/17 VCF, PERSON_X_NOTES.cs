//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using XNOTE_ROW			= CONTACTS.LOCAL.SECONDARY.PERSON.XNOTE.Row;
using SELECT_XNOTE		= CONTACTS.LOCAL.SECONDARY.PERSON.XNOTE.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Person's Notes to VcfText.
	/// </summary>
	public class Vcf_17_PersonNoteLines
	{
		private TDF_PERSON _Person;
		private static string HEADER	= "PERSON'S Notes:" + PRESET.Functional_LF;
		private static string LINE		= PRESET.FauxTab + "#0 {#1}" + PRESET.Functional_LF;
		private static string FOOTER	= PRESET.Functional_LF; //Effects a double space.

		//___________________________________________________________________________________________________________________________________________
		public Vcf_17_PersonNoteLines( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> person_x_notes = new SELECT_XNOTE.ByPkPerson( _Person.PkPerson.Value ).Execute;
			
			if ( person_x_notes.Count == 0 )
				return;

			vcf_text.NextNote = HEADER;

			foreach ( var kvp in person_x_notes )
			{
				XNOTE_ROW person_note_row = ( XNOTE_ROW )kvp.Value;

				string s = LINE;
				s = s.Replace( PRESET.S0, person_note_row.Note.VcfValue );
				s = s.Replace( PRESET.S1, person_note_row.PkPerson_X_Note.VcfValue );
				vcf_text.NextNote = s;
			}

			vcf_text.NextNote = FOOTER;
		}
	}
}