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
	/// Constructs person name - 'NICKNAME' - line.
	///		NICKNAME:Kororā
	/// </summary>
	public class Vcf_04_NickNameLine
	{
		private TDF_PERSON _Person;
		private const string NICK_NAME = "NICKNAME:#0";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_04_NickNameLine( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			if ( _Person.NickName.IsVcfValue )
			{
				string s = NICK_NAME;
				s = s.Replace( PRESET.S0, _Person.NickName.VcfValue );
				vcf_text.NextIndex = s;
			}
		}
	}
}
