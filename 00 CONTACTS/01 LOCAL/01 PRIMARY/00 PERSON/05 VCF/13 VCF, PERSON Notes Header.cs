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
	/// Writes header of the Notes section to a Person VCF.
	/// </summary>
	public class Vcf_13_PersonNotesHeader
	{
		private TDF_PERSON _Person;
		private static string NOTES_HEADER	= "NOTE:[PERSON]" + PRESET.Functional_LF;
		private static string NOTES_LINE		= "PERSON PK = #0" + PRESET.Functional_LFLF;

		//___________________________________________________________________________________________________________________________________________
		public Vcf_13_PersonNotesHeader( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			vcf_text.NextNote = NOTES_HEADER;

			string s = NOTES_LINE;
			s = s.Replace( PRESET.S0, _Person.PkPerson.VcfValue );
			vcf_text.NextNote = s;
		}
	}
}