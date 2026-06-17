//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using VCF_TEXT		= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_FAMILY	= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes header of the Notes section to a Family VCF.
	/// </summary>
	public class Vcf_07_FamilyNotesHeader
	{
		private TDF_FAMILY _Family;
		private static string NOTES_HEADER	= "NOTE:[FAMILY]" + PRESET.Functional_LF;
		private static string NOTES_LINE	= "FAMILY PK = #0" + PRESET.Functional_LFLF;

		//___________________________________________________________________________________________________________________________________________
		public Vcf_07_FamilyNotesHeader( TDF_FAMILY family )
		{
			_Family = family;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			vcf_text.NextNote = NOTES_HEADER;

			string s = NOTES_LINE;
			s = s.Replace( PRESET.S0, _Family.PkFamily.VcfValue );
			vcf_text.NextNote = s;
		}
	}
}