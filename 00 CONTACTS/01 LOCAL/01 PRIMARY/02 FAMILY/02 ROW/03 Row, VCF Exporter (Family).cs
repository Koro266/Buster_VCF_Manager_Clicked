//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using DBCONNECTOR	= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using VCF_TEXT		= CONTACTS.GLOBAL.VCF.VcfText;
//LOCAL
using LINE_01		= CONTACTS.LOCAL.PRIMARY.FAMILY.VCF.Vcf_01_HeaderLines;
using LINE_02		= CONTACTS.LOCAL.PRIMARY.FAMILY.VCF.Vcf_02_OrgLine;
using LINE_03		= CONTACTS.LOCAL.PRIMARY.FAMILY.VCF.Vcf_03_FamilyAddressLines;
using LINE_04		= CONTACTS.LOCAL.PRIMARY.FAMILY.VCF.Vcf_04_FamilyDeviceLines;
using LINE_05		= CONTACTS.LOCAL.PRIMARY.FAMILY.VCF.Vcf_05_FamilyEddressLines;
using LINE_06		= CONTACTS.LOCAL.PRIMARY.FAMILY.VCF.Vcf_06_FamilyWebsiteLines;
using LINE_07		= CONTACTS.LOCAL.PRIMARY.FAMILY.VCF.Vcf_07_FamilyNotesHeader;
using LINE_08		= CONTACTS.LOCAL.PRIMARY.FAMILY.VCF.Vcf_08_FamilyTagLines;
using LINE_09		= CONTACTS.LOCAL.PRIMARY.FAMILY.VCF.Vcf_09_FamilyPersonLines;
using LINE_10		= CONTACTS.LOCAL.PRIMARY.FAMILY.VCF.Vcf_10_FamilyNotesLines;
using LINE_11		= CONTACTS.LOCAL.PRIMARY.FAMILY.VCF.Vcf_11_FamilyCurrency;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		#region EXPORT PERSON
		//___________________________________________________________________________________________________________________________________
		public void ExportFamily()
		{
			VCF_TEXT vcf_text = new VCF_TEXT();

			new LINE_01(      ).AppendLines( vcf_text );
			new LINE_02( this ).AppendLines( vcf_text );
			new LINE_03( this ).AppendLines( vcf_text );
			new LINE_04( this ).AppendLines( vcf_text );
			new LINE_05( this ).AppendLines( vcf_text );
			new LINE_06( this ).AppendLines( vcf_text );
			new LINE_07( this ).AppendLines( vcf_text );
			new LINE_08( this ).AppendLines( vcf_text );
			new LINE_09( this ).AppendLines( vcf_text );
			new LINE_10( this ).AppendLines( vcf_text );
			new LINE_11( this ).AppendLines( vcf_text );

			vcf_text.WriteLines( ExportFilename );
		}
		#endregion


		#region FILE NAME
		//_______________________________________________________________________________________________________________________________________
		public string ExportFilename
		{
			get
			{
				string s = DBCONNECTOR.FamilyTemplate;

				s = s.Replace( PRESET.S0, this.SortableName.AsIs );
				s = s.Replace( PRESET.S1, this.PkFamily.AsString );
				s = s.Replace( PRESET.S2, DateTime.Now.ToString( "yyyy.MM.dd.HHmm" ) );

				return s.ToString();
			}
		}
		#endregion
	}
}
