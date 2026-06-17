//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using FAMILY_ROW		= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using XWEBSITE_ROW		= CONTACTS.LOCAL.SECONDARY.FAMILY.XWEBSITE.Row;
using SELECT_XWEBSITE	= CONTACTS.LOCAL.SECONDARY.FAMILY.XWEBSITE.Database.Select;
using SELECT_WEBSITE	= CONTACTS.LOCAL.TERTIARY.EDDRESS.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Family's websites to VcfText.
	/// </summary>
	public class Vcf_06_FamilyWebsiteLines
	{
		private FAMILY_ROW _Family;

		public static string WEBSITE_Line = "URL;type=url {#0}:#1";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_06_FamilyWebsiteLines( FAMILY_ROW family )
		{
			_Family = family;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> family_x_websites = new SELECT_XWEBSITE.ByPkFamily( _Family.PkFamily.Value ).Execute;
			if ( family_x_websites.Count == 0 )
				return;

			foreach ( var kvp in family_x_websites )
			{
				XWEBSITE_ROW pxe = ( XWEBSITE_ROW )kvp.Value;
				Construction( vcf_text, pxe );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public void Construction( VCF_TEXT vcf_text, XWEBSITE_ROW xwebsite_row )
		{
			string s = WEBSITE_Line;
			s = s.Replace( PRESET.S0, xwebsite_row.FkWebsite.VcfValue );
			s = s.Replace( PRESET.S1, xwebsite_row.Website.AsLower );
			vcf_text.NextIndex = s;
		}
	}
}
