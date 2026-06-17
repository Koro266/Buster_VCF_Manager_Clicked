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
	/// Constructs group name - 'ORG' - line: ORG:name
	///		NAME = "ORG:#0"
	/// </summary>
	public class Vcf_02_OrgLine
	{
		private TDF_GROUP _Group;
		private const string NAME = "ORG:#0";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_02_OrgLine( TDF_GROUP group )
		{
			_Group = group;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			string s = NAME;

			s = s.Replace( PRESET.S0, _Group.GroupName.VcfValue );

			vcf_text.NextIndex = s;
		}
	}
}
