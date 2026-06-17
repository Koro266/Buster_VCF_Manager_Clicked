//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT		= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_PERSON	= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using XTAG_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XTAG.Row;
using SELECT_XTAG	= CONTACTS.LOCAL.SECONDARY.PERSON.XTAG.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Person's tags to VcfText.
	/// </summary>
	public class Vcf_14_PersonTagLines
	{
		private TDF_PERSON _Person;
		private static string HEADER	= "PERSON'S Tags:" + PRESET.Functional_LF;
		private static string LINE		= PRESET.FauxTab + "#0 -- #1 {#2}" + PRESET.Functional_LF;
		private static string FOOTER	= PRESET.Functional_LF; //This produces a double-space after the final entry.

		//___________________________________________________________________________________________________________________________________________
		public Vcf_14_PersonTagLines( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> person_x_tags = new SELECT_XTAG.ByPkPerson( _Person.PkPerson.DbParameter ).Execute;
			
			if ( person_x_tags.Count == 0 )
				return;

			vcf_text.NextNote = HEADER;

			foreach ( var kvp in person_x_tags )
			{
				XTAG_ROW person_tag_row = ( XTAG_ROW )kvp.Value;

				string s = LINE;
				s = s.Replace( PRESET.S0, person_tag_row.SuperTag.VcfValue );
				s = s.Replace( PRESET.S1, person_tag_row.SubTag.VcfValue );
				s = s.Replace( PRESET.S2, person_tag_row.PkPerson_X_Tag.VcfValue );
				vcf_text.NextNote = s;
			}

			vcf_text.NextNote = FOOTER;
		}
	}
}