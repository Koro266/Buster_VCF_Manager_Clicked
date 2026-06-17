//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT		= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_FAMILY	= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using XTAG_ROW		= CONTACTS.LOCAL.SECONDARY.FAMILY.XTAG.Row;
using SELECT_XTAG	= CONTACTS.LOCAL.SECONDARY.FAMILY.XTAG.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Family's tags to VcfText.
	/// </summary>
	public class Vcf_08_FamilyTagLines
	{
		private TDF_FAMILY _Family;
		private static string HEADER	= "FAMILY'S Tags:" + PRESET.Functional_LF;
		private static string LINE		= PRESET.FauxTab + "#0 -- #1 {#2}" + PRESET.Functional_LF;
		private static string FOOTER	= PRESET.Functional_LF; //This produces a double-space after the final entry.

		//___________________________________________________________________________________________________________________________________________
		public Vcf_08_FamilyTagLines( TDF_FAMILY family )
		{
			_Family = family;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> family_x_tags = new SELECT_XTAG.ByPkFamily( _Family.PkFamily.Value ).Execute;
			
			if ( family_x_tags.Count == 0 )
				return;

			vcf_text.NextNote = HEADER;

			foreach ( var kvp in family_x_tags )
			{
				XTAG_ROW family_tag_row = ( XTAG_ROW )kvp.Value;

				string s = LINE;
				s = s.Replace( PRESET.S0, family_tag_row.SuperTag.VcfValue );
				s = s.Replace( PRESET.S1, family_tag_row.SubTag.VcfValue );
				s = s.Replace( PRESET.S2, family_tag_row.PkFamily_X_Tag.VcfValue );
				vcf_text.NextNote = s;
			}

			vcf_text.NextNote = FOOTER;
		}
	}
}