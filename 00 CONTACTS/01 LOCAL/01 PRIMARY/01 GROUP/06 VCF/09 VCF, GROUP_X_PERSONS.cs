//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_GROUP			= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using XPERSON_ROW		= CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON.Row;
using SELECT_XPERSON	= CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes `Group's persons to VcfText.
	/// </summary>
	public class Vcf_09_GroupPersonLines
	{
		private TDF_GROUP _Group;
		private static string HEADER	= "GROUP'S Persons:" + PRESET.Functional_LF;
		private static string LINE		= PRESET.FauxTab + "#0 -- #1 {#2}" + PRESET.Functional_LF;
		private static string FOOTER	= PRESET.Functional_LF; //Effects a double space.

		//___________________________________________________________________________________________________________________________________________
		public Vcf_09_GroupPersonLines( TDF_GROUP person )
		{
			_Group = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> group_x_persons = new SELECT_XPERSON.ByPkGroup( _Group.PkGroup.DbParameter ).Execute;
			
			if ( group_x_persons.Count == 0 )
				return;

			vcf_text.NextNote = HEADER;

			foreach ( var kvp in group_x_persons )
			{
				XPERSON_ROW group_person_row = ( XPERSON_ROW )kvp.Value;

				string s = LINE;
				s = s.Replace( PRESET.S0, group_person_row.PersonName.VcfValue );
				s = s.Replace( PRESET.S1, group_person_row.Role.VcfValue );
				s = s.Replace( PRESET.S2, group_person_row.PkGroup_X_Person.VcfValue );

				vcf_text.NextNote = s;
			}

			vcf_text.NextNote = FOOTER;
		}
	}
}