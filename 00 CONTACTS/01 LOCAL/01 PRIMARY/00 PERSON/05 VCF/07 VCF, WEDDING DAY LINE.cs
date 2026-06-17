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
	/// Constructs person's WEDDING DAY line.
	///		WEDDING_Date  = "item#0.X-ABDATE:#1";
	///		WEDDING_Label = "item#0.X-ABLabel:wedding date";
	/// </summary>
	public class Vcf_07_WeddingDayLine
	{
		private TDF_PERSON _Person;
		private const string WEDDING_Date = "item#0.X-ABDATE:#1";
		private const string WEDDING_Label = "item#0.X-ABLabel:wedding date";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_07_WeddingDayLine( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			if ( _Person.WeddingDate.IsVcfValue )
			{
				string d = WEDDING_Date;
				string l = WEDDING_Label;

				d = d.Replace( PRESET.S0, vcf_text.NextItem );
				d = d.Replace( PRESET.S1, _Person.WeddingDate.VcfValue );
				vcf_text.NextIndex = d;

				l = l.Replace( PRESET.S0, vcf_text.CurrentItem );
				vcf_text.NextIndex = l;
			}
		}
	}
}
