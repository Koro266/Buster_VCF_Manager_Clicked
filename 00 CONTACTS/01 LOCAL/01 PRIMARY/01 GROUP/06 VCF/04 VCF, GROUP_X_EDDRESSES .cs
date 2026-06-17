//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using GROUP_ROW			= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using XEDDRESS_ROW		= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Row;
using EDDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.EDDRESS.Row;
using SELECT_EDDRESS	= CONTACTS.LOCAL.TERTIARY.EDDRESS.Database.Select;
using SELECT_XEDDRESS	= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes GROUP's eddresses to VcfText.
	/// </summary>
	public class Vcf_04_GroupEddressLines
	{
		private GROUP_ROW _Group;
		private EDDRESS_ROW _Eddress;

		private const string EDDRESS_Line = "item#0.EMAIL;type=personal;type=pref:#1";
		private const string EDDRESS_Label = "item#0.X-ABLabel:eddress;";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_04_GroupEddressLines( GROUP_ROW GROUP )
		{
			_Group = GROUP;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> group_x_eddresses = new SELECT_XEDDRESS.ByPkGroup( _Group.PkGroup.Value ).Execute;
			if ( group_x_eddresses.Count == 0 )
				return;

			foreach ( var kvp in group_x_eddresses )
			{
				XEDDRESS_ROW pxe = ( XEDDRESS_ROW )kvp.Value;
				_Eddress = new SELECT_EDDRESS.ByPkEddress( pxe.FkEddress.Value ).Execute;
				Construction( vcf_text, pxe );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public void Construction( VCF_TEXT vcf_text, XEDDRESS_ROW xeddress_row )
		{
			string s;

			s = EDDRESS_Line;
			s = s.Replace( PRESET.S0, vcf_text.NextItem );
			s = s.Replace( PRESET.S1, _Eddress.Eddress.AsLower );
			vcf_text.NextIndex = s;

			s = EDDRESS_Label;
			s = s.Replace( PRESET.S0, vcf_text.CurrentItem );

			vcf_text.NextIndex = s;
		}
	}
}
