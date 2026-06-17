//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT		= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_GROUP		= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using XTAG_ROW		= CONTACTS.LOCAL.SECONDARY.GROUP.XTAG.Row;
using SELECT_XTAG	= CONTACTS.LOCAL.SECONDARY.GROUP.XTAG.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Group's tags to VcfText.
	/// </summary>
	public class Vcf_08_GroupTagLines
	{
		private TDF_GROUP _Group;
		private static string HEADER	= "GROUP'S Tags:" + PRESET.Functional_LF;
		private static string LINE		= PRESET.FauxTab + "#0 -- #1 {#2}" + PRESET.Functional_LF;
		private static string FOOTER	= PRESET.Functional_LF; //This produces a double-space after the final entry.

		//___________________________________________________________________________________________________________________________________________
		public Vcf_08_GroupTagLines( TDF_GROUP group )
		{
			_Group = group;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> group_x_tags = new SELECT_XTAG.ByPkGroup( _Group.PkGroup.DbParameter ).Execute;
			
			if ( group_x_tags.Count == 0 )
				return;

			vcf_text.NextNote = HEADER;

			foreach ( var kvp in group_x_tags )
			{
				XTAG_ROW group_tag_row = ( XTAG_ROW )kvp.Value;

				string s = LINE;
				s = s.Replace( PRESET.S0, group_tag_row.SuperTag.VcfValue );
				s = s.Replace( PRESET.S1, group_tag_row.SubTag.VcfValue );
				s = s.Replace( PRESET.S2, group_tag_row.PkGroup_X_Tag.VcfValue );
				vcf_text.NextNote = s;
			}

			vcf_text.NextNote = FOOTER;
		}
	}
}