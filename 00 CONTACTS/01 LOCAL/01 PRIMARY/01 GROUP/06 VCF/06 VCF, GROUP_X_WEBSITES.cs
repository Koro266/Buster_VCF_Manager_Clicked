//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using GROUP_ROW			= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using WEBSITE_ROW		= CONTACTS.LOCAL.TERTIARY.WEBSITE.Row;
using XWEBSITE_ROW		= CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE.Row;
using SELECT_WEBSITE	= CONTACTS.LOCAL.TERTIARY.WEBSITE.Database.Select;
using SELECT_XWEBSITE	= CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Group's websites to VcfText.
	/// </summary>
	public class Vcf_06_GroupWebsiteLines
	{
		private GROUP_ROW _Group;
		private WEBSITE_ROW _Website;

		public static string WEBSITE_Line = "URL;type=url {#0}:#1";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_06_GroupWebsiteLines( GROUP_ROW group )
		{
			_Group = group;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> group_x_websites = new SELECT_XWEBSITE.ByPkGroup( _Group.PkGroup.Value ).Execute;
			if ( group_x_websites.Count == 0 )
				return;

			foreach ( var kvp in group_x_websites )
			{
				XWEBSITE_ROW pxw = ( XWEBSITE_ROW )kvp.Value;
				_Website = new SELECT_WEBSITE.ByPkWebsite( pxw.FkWebsite.Value ).Execute;
				Construction( vcf_text, pxw );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public void Construction( VCF_TEXT vcf_text, XWEBSITE_ROW xwebsite_row )
		{
			string s = WEBSITE_Line;

			s = s.Replace( PRESET.S0, vcf_text.NextItem );
			s = s.Replace( PRESET.S1, _Website.Website.AsLower );
			vcf_text.NextIndex = s;
		}
	}
}
