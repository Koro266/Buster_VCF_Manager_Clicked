//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
//LOCAL
using PERSON_ROW		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using XADDRESS_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Row;
using SELECT_XADDRESS	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Select;
using ADDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using SELECT_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select;
using VCF_ADDRESS		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.VCF.VcfAddress;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Person's address to VcfText.
	/// </summary>
	public class Vcf_10_PersonAddressLines
	{
		private PERSON_ROW	_Person;
		private ADDRESS_ROW	_Address;
		private VCF_TEXT	_VcfText;

		private const string ADDRESS_Line			= "item#0.ADR;type=pref:#1";
		private const string ADDRESS_Item_Number	= "item#0.X-ABADR:#1";
		private const string ADDRESS_Label			= "item#0.X-ABLabel:address {#1}";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_10_PersonAddressLines( PERSON_ROW person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> person_x_addresses = new SELECT_XADDRESS.ByPkPerson( _Person.PkPerson.Value ).Execute;
			if ( person_x_addresses.Count == 0 )
				return;

			_VcfText = vcf_text;
			foreach ( var kvp in person_x_addresses )
			{
				XADDRESS_ROW pxa = ( XADDRESS_ROW )kvp.Value;
				_Address = new SELECT_ADDRESS.FullyQualifiedAddress( pxa.FkAddress.Value ).Execute;
				AppendAddressLines( new VCF_ADDRESS( _Address ).RealiseAddressRule );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void AppendAddressLines(string vcf_realisation )
		{
			string s = String.Empty;

			s = ADDRESS_Line;
			s = s.Replace( PRESET.S0, _VcfText.NextItem );
			s = s.Replace( PRESET.S1, vcf_realisation );
			_VcfText.NextIndex = s;

			s = ADDRESS_Label;
			s = s.Replace( PRESET.S0, _VcfText.CurrentItem );
			s = s.Replace( PRESET.S1, _Address.PkAddress.AsString );
			_VcfText.NextIndex = s;

			s = ADDRESS_Item_Number;
			s = s.Replace( PRESET.S0, _VcfText.CurrentItem );
			s = s.Replace( PRESET.S1, _Address.ShortIsoCode.AsLower );
			_VcfText.NextIndex = s;
		}
	}
}