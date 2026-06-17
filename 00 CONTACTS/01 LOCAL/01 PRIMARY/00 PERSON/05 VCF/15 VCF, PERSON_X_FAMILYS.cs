//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using XFAMILY_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY.Row;
using SELECT_XFAMILY	= CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Person's Familys to VcfText.
	/// </summary>
	public class Vcf_15_PersonFamilyLines
	{
		private TDF_PERSON _Person;
		private static string HEADER	= "PERSON'S Families:" + PRESET.Functional_LF;
		private static string LINE		= PRESET.FauxTab + "#0 -- #1 {#2}" + PRESET.Functional_LF;
		private static string FOOTER	= PRESET.Functional_LF; //Effects a double space.

		//___________________________________________________________________________________________________________________________________________
		public Vcf_15_PersonFamilyLines( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> person_x_familys = new SELECT_XFAMILY.ByPkPerson( _Person.PkPerson.DbParameter ).Execute;
			
			if ( person_x_familys.Count == 0 )
				return;

			vcf_text.NextNote = HEADER;

			foreach ( var kvp in person_x_familys )
			{
				XFAMILY_ROW person_family_row = ( XFAMILY_ROW )kvp.Value;

				string s = LINE;
				s = s.Replace( PRESET.S0, person_family_row.FamilyName.VcfValue );
				s = s.Replace( PRESET.S1, person_family_row.Role.VcfValue );
				s = s.Replace( PRESET.S2, person_family_row.PkFamily.VcfValue );

				vcf_text.NextNote = s;
			}

			vcf_text.NextNote = FOOTER;
		}
	}
}