//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using static CONTACTS.LOCAL.PRIMARY.PERSON.Database.Like;
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using DBCONNECTOR	= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
//LOCAL
using LINE_01		= CONTACTS.LOCAL.PRIMARY.GROUP.VCF.Vcf_01_HeaderLines;
using LINE_02		= CONTACTS.LOCAL.PRIMARY.GROUP.VCF.Vcf_02_OrgLine;
using LINE_03		= CONTACTS.LOCAL.PRIMARY.GROUP.VCF.Vcf_03_GroupDeviceLines;
using LINE_04		= CONTACTS.LOCAL.PRIMARY.GROUP.VCF.Vcf_04_GroupEddressLines;
using LINE_05		= CONTACTS.LOCAL.PRIMARY.GROUP.VCF.Vcf_05_GroupAddressLines;
using LINE_06		= CONTACTS.LOCAL.PRIMARY.GROUP.VCF.Vcf_06_GroupWebsiteLines;
using NOTE_01		= CONTACTS.LOCAL.PRIMARY.GROUP.VCF.Vcf_07_GroupNotesHeader;
using NOTE_02		= CONTACTS.LOCAL.PRIMARY.GROUP.VCF.Vcf_08_GroupTagLines;
using NOTE_03		= CONTACTS.LOCAL.PRIMARY.GROUP.VCF.Vcf_09_GroupPersonLines;
using NOTE_04		= CONTACTS.LOCAL.PRIMARY.GROUP.VCF.Vcf_10_GroupNoteLines;
using NOTE_05		= CONTACTS.LOCAL.PRIMARY.GROUP.VCF.Vcf_11_GroupCurrency;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using VCF_TEXT		= CONTACTS.GLOBAL.VCF.VcfText;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		#region EXPORT GROUP
		//___________________________________________________________________________________________________________________________________
		public void ExportGroup()
		{
			VCF_TEXT vcf_text = new VCF_TEXT();

			new LINE_01(      ).AppendLines( vcf_text );
			new LINE_02( this ).AppendLines( vcf_text );
			new LINE_03( this ).AppendLines( vcf_text );
			new LINE_04( this ).AppendLines( vcf_text );
			new LINE_05( this ).AppendLines( vcf_text );
			new LINE_06( this ).AppendLines( vcf_text );
			new NOTE_01( this ).AppendLines( vcf_text );
			new NOTE_02( this ).AppendLines( vcf_text );
			new NOTE_03( this ).AppendLines( vcf_text );
			new NOTE_04( this ).AppendLines( vcf_text );
			new NOTE_05( this ).AppendLines( vcf_text );

			vcf_text.WriteLines( ExportFilename );
		}
		#endregion


		#region FILE NAME
		//_______________________________________________________________________________________________________________________________________
		public string ExportFilename
		{
			get
			{
				string s = DBCONNECTOR.GroupTemplate;

				s = s.Replace( PRESET.S0, this.GroupName.AsUpper );
				s = s.Replace( PRESET.S1, this.PkGroup.AsString );
				s = s.Replace( PRESET.S2, DateTime.Now.ToString( "yyyy.MM.dd.HHmm" ) );

				return s.ToString();
			}
		}
		#endregion
	}
}
