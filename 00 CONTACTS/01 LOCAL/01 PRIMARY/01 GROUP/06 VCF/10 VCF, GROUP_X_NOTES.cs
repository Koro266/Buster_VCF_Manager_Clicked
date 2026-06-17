//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_GROUP			= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using XNOTE_ROW			= CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE.Row;
using SELECT_XNOTE		= CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Group's Notes to VcfText.
	/// </summary>
	public class Vcf_10_GroupNoteLines
	{
		private TDF_GROUP _Group;
		private static string HEADER	= "GROUP'S Notes:" + PRESET.Functional_LF;
		private static string LINE		= PRESET.FauxTab + "#0 {#1}" + PRESET.Functional_LF;
		private static string FOOTER	= PRESET.Functional_LF; //Effects a double space.

		//___________________________________________________________________________________________________________________________________________
		public Vcf_10_GroupNoteLines( TDF_GROUP group )
		{
			_Group = group;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> group_x_notes = new SELECT_XNOTE.ByPkGroup( _Group.PkGroup.Value ).Execute;
			
			if ( group_x_notes.Count == 0 )
				return;

			vcf_text.NextNote = HEADER;

			foreach ( var kvp in group_x_notes )
			{
				XNOTE_ROW group_note_row = ( XNOTE_ROW )kvp.Value;

				string s = LINE;
				s = s.Replace( PRESET.S0, group_note_row.Note.VcfValue );
				s = s.Replace( PRESET.S1, group_note_row.PkGroup_X_Note.VcfValue );
				vcf_text.NextNote = s;
			}

			vcf_text.NextNote = FOOTER;
		}
	}
}