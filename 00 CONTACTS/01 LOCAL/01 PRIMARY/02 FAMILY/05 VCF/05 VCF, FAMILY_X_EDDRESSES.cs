//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using FAMILY_ROW		= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using EDDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.EDDRESS.Row;
using XEDDRESS_ROW		= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Row;
using SELECT_EDDRESS	= CONTACTS.LOCAL.TERTIARY.EDDRESS.Database.Select;
using SELECT_XEDDRESS	= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Family's eddresses to VcfText.
	/// </summary>
	public class Vcf_05_FamilyEddressLines
	{
		private FAMILY_ROW _Family;
		private EDDRESS_ROW _Eddress;

		private const string EDDRESS_Line = "item#0.EMAIL;type=personal;type=pref:#1";
		private const string EDDRESS_Label = "item#0.X-ABLabel:eddress {#1};";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_05_FamilyEddressLines( FAMILY_ROW person )
		{
			_Family = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> person_x_eddresses = new SELECT_XEDDRESS.ByPkFamily( _Family.PkFamily.Value ).Execute;
			if ( person_x_eddresses.Count == 0 )
				return;

			foreach ( var kvp in person_x_eddresses )
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
			s = s.Replace( PRESET.S1, xeddress_row.FkEddress.VcfValue );

			vcf_text.NextIndex = s;
		}
	}
}
