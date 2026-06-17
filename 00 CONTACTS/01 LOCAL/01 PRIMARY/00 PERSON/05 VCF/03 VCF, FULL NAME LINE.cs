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
	/// Constructs person name - 'FN' - line: FN:First Middle(s) Last Suffix
	///		FULL_NAME = "FN:#0 #1 #2 #3"
	/// </summary>
	public class Vcf_03_FullNameLine
	{
		private TDF_PERSON _Person;
		private const string FULL_NAME = "FN:#0 #1 #2 #3";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_03_FullNameLine( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			string s = FULL_NAME;

			s = s.Replace( PRESET.S0, _Person.GivenName.VcfValue );
			s = s.Replace( PRESET.S1, _Person.MiddleNames.VcfValue );
			s = s.Replace( PRESET.S2, _Person.ProperSurname.VcfValue );
			s = s.Replace( PRESET.S3, _Person.Suffix.VcfValue );

			vcf_text.NextIndex = s;
		}
	}
}
