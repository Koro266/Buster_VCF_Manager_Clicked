//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using VCF_TEXT		= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_GROUP		= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes header of the Notes section to a Group VCF.
	/// </summary>
	public class Vcf_07_GroupNotesHeader
	{
		private TDF_GROUP _Group;
		private static string NOTES_HEADER	= "NOTE:[GROUP]" + PRESET.Functional_LF;
		private static string NOTES_LINE		= "GROUP PK = #0" + PRESET.Functional_LFLF;

		//___________________________________________________________________________________________________________________________________________
		public Vcf_07_GroupNotesHeader( TDF_GROUP group )
		{
			_Group = group;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			vcf_text.NextNote = NOTES_HEADER;

			string s = NOTES_LINE;
			s = s.Replace( PRESET.S0, _Group.PkGroup.VcfValue );
			vcf_text.NextNote = s;
		}
	}
}