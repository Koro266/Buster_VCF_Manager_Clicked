//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using XGROUP_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XGROUP.Row;
using SELECT_XGROUP		= CONTACTS.LOCAL.SECONDARY.PERSON.XGROUP.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Person's Groups to VcfText.
	/// </summary>
	public class Vcf_16_PersonGroupLines
	{
		private TDF_PERSON _Person;
		private static string HEADER	= "PERSON'S Groups:" + PRESET.Functional_LF;
		private static string LINE		= PRESET.FauxTab + "#0 -- #1 {#2}" + PRESET.Functional_LF;
		private static string FOOTER	= PRESET.Functional_LF; //Effects a double space.

		//___________________________________________________________________________________________________________________________________________
		public Vcf_16_PersonGroupLines( TDF_PERSON person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> person_x_groups = new SELECT_XGROUP.ByPkPerson( _Person.PkPerson.DbParameter ).Execute;
			
			if ( person_x_groups.Count == 0 )
				return;

			vcf_text.NextNote = HEADER;

			foreach ( var kvp in person_x_groups )
			{
				XGROUP_ROW person_x_group = ( XGROUP_ROW )kvp.Value;

				string s = LINE;
				s = s.Replace( PRESET.S0, person_x_group.GroupName.VcfValue );
				s = s.Replace( PRESET.S1, person_x_group.Role.VcfValue );
				s = s.Replace( PRESET.S2, person_x_group.PkPerson_X_Group.VcfValue );

				vcf_text.NextNote = s;
			}

			vcf_text.NextNote = FOOTER;
		}
	}
}