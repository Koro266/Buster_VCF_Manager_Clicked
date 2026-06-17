//___________________________________________________________________________________________________________________________________________________
//GLOBAL
//LOCAL
using ADDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//VCF
using LINE_01			= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.VCF.Vcf_01_PostalAddressLine;
using LINE_02			= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.VCF.Vcf_02_PhysicalAddressLine;
using LINE_03			= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.VCF.Vcf_03_ExtendedAddressLine;
using LINE_04			= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.VCF.Vcf_04_ExcelAddressLine;
using LINE_05			= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.VCF.Vcf_05_ComprehensiveAddressLine;
using SELECT_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select.ByPkAddress;
using VCF_TEXT 		= CONTACTS.GLOBAL.VCF.VcfText;
C: \Users\Brusster\ContactsManager\VcfManager\00 CONTACTS\01 LOCAL\02 SECONDARY\01 GROUP\00 X_ADDRESS\02 ROW\01 Row, Exporter (Group_X_Address).cs
//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Constructs address line(s)
	/// </summary>
	public partial class Row : BASE_ROW
	{
		//___________________________________________________________________________________________________________________________________
		public void AppendAddressLines( VCF_TEXT vcf_text )
		{
			ADDRESS_ROW address_row = new SELECT_ADDRESS( this.FkAddress.Value ).Execute;

			new LINE_01( address_row ).AppendLines( vcf_text );
			//new LINE_02( address_row ).AppendLines( vcf_text );
			//new LINE_03( address_row ).AppendLines( vcf_text );
			//new LINE_04( address_row ).AppendLines( vcf_text );
			new LINE_05( address_row ).AppendLines( vcf_text );
		}
	}
}
