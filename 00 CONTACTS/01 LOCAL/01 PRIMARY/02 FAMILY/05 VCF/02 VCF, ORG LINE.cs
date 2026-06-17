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
	/// Constructs family name - 'ORG' - line: ORG:name
	/// </summary>
	public class Vcf_02_OrgLine
	{
		private TDF_FAMILY _Family;
		private const string NAME = "ORG:#0";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_02_OrgLine( TDF_FAMILY family )
		{
			_Family = family;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			string s = NAME;

			s = s.Replace( PRESET.S0, _Family.SortableName.VcfValue );

			vcf_text.NextIndex = s;
		}
	}
}
