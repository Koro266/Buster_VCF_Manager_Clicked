//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_FAMILY		= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using XPERSON_ROW		= CONTACTS.LOCAL.SECONDARY.FAMILY.XPERSON.Row;
using SELECT_XPERSON	= CONTACTS.LOCAL.SECONDARY.FAMILY.XPERSON.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Family's Persons to VcfText.
	/// </summary>
	public class Vcf_09_FamilyPersonLines
	{
		private TDF_FAMILY _Family;
		private static string HEADER	= "FAMILY'S Persons:" + PRESET.Functional_LF;
		private static string LINE		= PRESET.FauxTab + "#0 -- #1 {#2}" + PRESET.Functional_LF;
		private static string FOOTER	= PRESET.Functional_LF; //Effects a double space.

		//___________________________________________________________________________________________________________________________________________
		public Vcf_09_FamilyPersonLines( TDF_FAMILY family )
		{
			_Family = family;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> family_x_persons = new SELECT_XPERSON.ByPkFamily( _Family.PkFamily.DbParameter ).Execute;
			
			if ( family_x_persons.Count == 0 )
				return;

			vcf_text.NextNote = HEADER;

			foreach ( var kvp in family_x_persons )
			{
				XPERSON_ROW person_family_row = ( XPERSON_ROW )kvp.Value;

				string s = LINE;
				s = s.Replace( PRESET.S0, person_family_row.PersonName.VcfValue );
				s = s.Replace( PRESET.S1, person_family_row.Role.VcfValue );
				s = s.Replace( PRESET.S2, person_family_row.PkPerson.VcfValue );

				vcf_text.NextNote = s;
			}

			vcf_text.NextNote = FOOTER;
		}
	}
}