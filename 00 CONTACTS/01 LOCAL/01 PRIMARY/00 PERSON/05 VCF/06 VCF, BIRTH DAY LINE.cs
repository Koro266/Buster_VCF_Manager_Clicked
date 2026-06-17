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
	/// Constructs person's birthday - 'BDAY' - line.
	///		BIRTH_Date = "BDAY:#0"
	/// </summary>
	public class Vcf_06_BirthDayLine
	{
		private TDF_PERSON _Person;
		private const string BIRTH_DATE = "BDAY:#0";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_06_BirthDayLine( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			if ( _Person.BirthDate.IsVcfValue )
			{
				string s = BIRTH_DATE;
				s = s.Replace( PRESET.S0, _Person.BirthDate.VcfValue );
				vcf_text.NextIndex = s;
			}
		}
	}
}
