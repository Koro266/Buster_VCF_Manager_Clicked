//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using VCF_TEXT		= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_PERSON	= CONTACTS.LOCAL.PRIMARY.PERSON.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Constructs person name - 'N' - line: N:LAST;First;Middle(s);Prefix;Suffix
	///		NAME = "N:#0;#1;#2;#3;#4"
	/// </summary>
	public class Vcf_02_NameLine
	{
		private TDF_PERSON _Person;
		private const string NAME = "N:#0;#1;#2;#3;#4";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_02_NameLine( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			string s = NAME;

			s = s.Replace( PRESET.S0, _Person.UpperSurname.VcfValue );
			s = s.Replace( PRESET.S1, _Person.GivenName.VcfValue );
			s = s.Replace( PRESET.S2, _Person.MiddleNames.VcfValue );
			s = s.Replace( PRESET.S3, _Person.Prefix.VcfValue );
			s = s.Replace( PRESET.S4, _Person.Suffix.VcfValue );

			vcf_text.NextIndex = s;
		}
	}
}
