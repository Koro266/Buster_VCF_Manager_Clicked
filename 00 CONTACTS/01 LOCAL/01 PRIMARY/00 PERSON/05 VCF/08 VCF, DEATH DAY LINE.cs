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
	/// Constructs person's DEATH DAY line.
	///		DEATH_Date =  "item#0.X-ABDATE:#1";
	///		DEATH_Label = "item#0.X-ABLabel:death date";
	/// </summary>
	public class Vcf_08_DeathDayLine
	{
		private TDF_PERSON _Person;
		private const string DEATH_Date = "item#0.X-ABDATE:#1";
		private const string DEATH_Label = "item#0.X-ABLabel:death date";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_08_DeathDayLine( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			if ( _Person.DeathDate.IsVcfValue )
			{
				string d = DEATH_Date;
				string l = DEATH_Label;

				d = d.Replace( PRESET.S0, vcf_text.NextItem );
				d = d.Replace( PRESET.S1, _Person.DeathDate.VcfValue );
				vcf_text.NextIndex = d;

				l = l.Replace( PRESET.S0, vcf_text.CurrentItem );
				vcf_text.NextIndex = l;
			}
		}
	}
}
