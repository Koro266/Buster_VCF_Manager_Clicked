//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using DB			= CONTACTS.GLOBAL.DATABASE.CONNECTION;
using DATE_TIME		= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using VCF_TEXT		= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_PERSON	= CONTACTS.LOCAL.PRIMARY.PERSON.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Person's currency data to VcfText.
	///	CURRENCY:
	///		Database: 2026.03.20.01 VCF Builder.accdb
	///		Updated: 5 January 2026, 11:00
	///		Exported: 31 March 2026, 05:42
	/// </summary>
	public class Vcf_18_PersonCurrency
	{
		private TDF_PERSON _Person;
		private static string HEADER	= "PERSON'S Currency:" + PRESET.Functional_LF;
		private static string Database	= PRESET.FauxTab + "Database: #0" + PRESET.Functional_LF;
		private static string Updated	= PRESET.FauxTab + "Updated:  #0" + PRESET.Functional_LF;
		private static string Exported	= PRESET.FauxTab + "Exported: #0" + PRESET.Functional_LF;
		private static string FOOTER	= PRESET.Functional_LF; //Effects a double space.

		//___________________________________________________________________________________________________________________________________________
		public Vcf_18_PersonCurrency( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			string database = Database.Replace( PRESET.S0, DB.DbConnector.VcfDbFileName );
			string updated = Updated.Replace( PRESET.S0, _Person.CurrencyDate.As_VCF_CurrencyEntry );
			string exported = Exported.Replace( PRESET.S0, DateTime.Now.ToString( DATE_TIME.VcfCurrencyDateFormat ) );

			vcf_text.NextNote = HEADER;
			vcf_text.NextNote = database;
			vcf_text.NextNote = updated;
			vcf_text.NextNote = exported;
			vcf_text.NextNote = FOOTER;
		}
	}
}