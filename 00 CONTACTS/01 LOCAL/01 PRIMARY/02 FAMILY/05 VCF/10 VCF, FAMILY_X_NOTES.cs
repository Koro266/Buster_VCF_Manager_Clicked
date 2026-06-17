//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_FAMILY		= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using XNOTE_ROW			= CONTACTS.LOCAL.SECONDARY.FAMILY.XNOTE.Row;
using SELECT_XNOTES		= CONTACTS.LOCAL.SECONDARY.FAMILY.XNOTE.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Family's Notes to VcfText.
	/// </summary>
	public class Vcf_10_FamilyNotesLines
	{
		private TDF_FAMILY _Family;
		private static string HEADER = "FAMILY'S Notes:" + PRESET.Functional_LF;
		private static string LINE = PRESET.FauxTab + "#0 {#1}" + PRESET.Functional_LF;
		private static string FOOTER = PRESET.Functional_LF; //Effects a double space.

		//___________________________________________________________________________________________________________________________________________
		public Vcf_10_FamilyNotesLines( TDF_FAMILY family )
		{
			_Family = family;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> family_x_notes = new SELECT_XNOTES.ByPkFamily( _Family.PkFamily.Value ).Execute;
			
			if ( family_x_notes.Count == 0 )
				return;

			vcf_text.NextNote = HEADER;

			foreach ( var kvp in family_x_notes )
			{
				XNOTE_ROW family_note_row = ( XNOTE_ROW )kvp.Value;

				string s = LINE;
				s = s.Replace( PRESET.S0, family_note_row.Note.VcfValue );
				s = s.Replace( PRESET.S1, family_note_row.PkFamily_X_Note.VcfValue );

				vcf_text.NextNote = s;
			}

			vcf_text.NextNote = FOOTER;
		}
	}
}