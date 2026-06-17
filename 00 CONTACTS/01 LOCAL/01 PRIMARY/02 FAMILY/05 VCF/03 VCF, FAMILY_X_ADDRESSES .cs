//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
//LOCAL
using FAMILY_ROW		= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using XADDRESS_ROW		= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Row;
using ADDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using SELECT_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select;
using SELECT_XADDRESS	= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Database.Select;
//LOCAL

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Family's addresses to VcfText.
	/// </summary>
	public class Vcf_03_FamilyAddressLines
	{
		private FAMILY_ROW	_Family;
		private ADDRESS_ROW	_Address;
		private VCF_TEXT	_VcfText;

		private const string ADDRESS_Line			= "item#0.ADR:#1";
		private const string ADDRESS_Item_Number	= "item#0.X-ABADR:#1";

		private const string ADDRESS_Postal_Label	= "item#0.X-ABLabel:postal address {#1}";
		private const string ADDRESS_Physical_Label = "item#0.X-ABLabel:physical address";
		private const string ADDRESS_Extended_Label = "item#0.X-ABLabel:address extensions";
		private const string ADDRESS_Excel_Label	= "item#0.X-ABLabel:christmas address";
		private const string ADDRESS_All_Label		= "item#0.X-ABLabel:all address data";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_03_FamilyAddressLines( FAMILY_ROW family )
		{
			_Family = family;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> family_x_addresses = new SELECT_XADDRESS.ByPkFamily( _Family.PkFamily.DbParameter ).Execute;
			if ( family_x_addresses.Count == 0 )
				return;

			_VcfText = vcf_text;
			foreach ( var kvp in family_x_addresses )
			{
				XADDRESS_ROW pxa = ( XADDRESS_ROW )kvp.Value;
				_Address = new SELECT_ADDRESS.FullyQualifiedAddress( pxa.FkAddress.Value ).Execute;

				AppendPostalLines();
				//AppendPhysicalLines();
				//AppendExtendedLines();
				//AppendExcelLines();
				//AppendAllDataLines();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void AppendPostalLines()
		{
			string s;
			string vcf_realisation = _Address.VcfPostalRule;

			s = ADDRESS_Line;
			s = s.Replace( PRESET.S0, _VcfText.NextItem );
			s = s.Replace( PRESET.S1, vcf_realisation );
			_VcfText.NextIndex = s;

			s = ADDRESS_Postal_Label;
			s = s.Replace( PRESET.S0, _VcfText.CurrentItem );
			s = s.Replace( PRESET.S1, _Address.PkAddress.AsString );
			_VcfText.NextIndex = s;

			s = ADDRESS_Item_Number;
			s = s.Replace( PRESET.S0, _VcfText.CurrentItem );
			s = s.Replace( PRESET.S1, _Address.ShortIsoCode.AsLower );
			_VcfText.NextIndex = s;
		}
		//___________________________________________________________________________________________________________________________________________
		private void AppendPhysicalLines()
		{
			string s;
			string vcf_realisation = _Address.VcfPhysicalRule;

			s = ADDRESS_Line;
			s = s.Replace( PRESET.S0, _VcfText.NextItem );
			s = s.Replace( PRESET.S1, vcf_realisation );
			_VcfText.NextIndex = s;

			s = ADDRESS_Physical_Label;
			s = s.Replace( PRESET.S0, _VcfText.CurrentItem );
			_VcfText.NextIndex = s;

			s = ADDRESS_Item_Number;
			s = s.Replace( PRESET.S0, _VcfText.CurrentItem );
			s = s.Replace( PRESET.S1, _Address.ShortIsoCode.AsLower );
			_VcfText.NextIndex = s;
		}
		//___________________________________________________________________________________________________________________________________________
		private void AppendExtendedLines()
		{
			string s;
			string vcf_realisation = _Address.VcfExtendedRule;

			s = ADDRESS_Line;
			s = s.Replace( PRESET.S0, _VcfText.NextItem );
			s = s.Replace( PRESET.S1, vcf_realisation );
			_VcfText.NextIndex = s;

			s = ADDRESS_Extended_Label;
			s = s.Replace( PRESET.S0, _VcfText.CurrentItem );
			_VcfText.NextIndex = s;

			s = ADDRESS_Item_Number;
			s = s.Replace( PRESET.S0, _VcfText.CurrentItem );
			s = s.Replace( PRESET.S1, _Address.ShortIsoCode.AsLower );
			_VcfText.NextIndex = s;
		}
		//___________________________________________________________________________________________________________________________________________
		private void AppendExcelLines()
		{
			string s;
			string vcf_realisation = _Address.VcfExcelRule;

			s = ADDRESS_Line;
			s = s.Replace( PRESET.S0, _VcfText.NextItem );
			s = s.Replace( PRESET.S1, vcf_realisation );
			_VcfText.NextIndex = s;

			s = ADDRESS_Excel_Label;
			s = s.Replace( PRESET.S0, _VcfText.CurrentItem );
			_VcfText.NextIndex = s;

			s = ADDRESS_Item_Number;
			s = s.Replace( PRESET.S0, _VcfText.CurrentItem );
			s = s.Replace( PRESET.S1, _Address.ShortIsoCode.AsLower );
			_VcfText.NextIndex = s;
		}
		//___________________________________________________________________________________________________________________________________________
		private void AppendAllDataLines()
		{
			string s;
			string vcf_realisation = _Address.RealiseComprehensiveAddress();

			s = ADDRESS_Line;
			s = s.Replace( PRESET.S0, _VcfText.NextItem );
			s = s.Replace( PRESET.S1, vcf_realisation );
			_VcfText.NextIndex = s;

			s = ADDRESS_All_Label;
			s = s.Replace( PRESET.S0, _VcfText.CurrentItem );
			_VcfText.NextIndex = s;

			s = ADDRESS_Item_Number;
			s = s.Replace( PRESET.S0, _VcfText.CurrentItem );
			s = s.Replace( PRESET.S1, _Address.ShortIsoCode.AsLower );
			_VcfText.NextIndex = s;
		}
	}
}