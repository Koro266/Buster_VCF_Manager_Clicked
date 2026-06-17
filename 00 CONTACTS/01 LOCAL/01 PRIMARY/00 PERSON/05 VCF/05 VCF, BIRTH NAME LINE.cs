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
	/// Constructs person name - 'X-MAIDENNAME' - line.
	///		BIRTH_NAME = "X-MAIDENNAME:#0";
	/// </summary>
	public class Vcf_05_BirthNameLine
	{
		private TDF_PERSON _Person;
		private const string BIRTH_NAME = "X-MAIDENNAME:#0";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_05_BirthNameLine( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			if ( _Person.BirthName.IsVcfValue )
			{
				string s = BIRTH_NAME;
				s = s.Replace( PRESET.S0, _Person.BirthName.VcfValue );
				vcf_text.NextIndex = s;
			}
		}
	}
}
