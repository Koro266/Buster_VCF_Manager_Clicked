//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using DBCONNECTOR	= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using VCF_TEXT		= CONTACTS.GLOBAL.VCF.VcfText;
//LOCAL
using LINE_01		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_01_HeaderLines;
using LINE_02		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_02_NameLine;
using LINE_03		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_03_FullNameLine;
using LINE_04		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_04_NickNameLine;
using LINE_05		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_05_BirthNameLine;
using LINE_06		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_06_BirthDayLine;
using LINE_07		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_07_WeddingDayLine;
using LINE_08		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_08_DeathDayLine;
using LINE_09		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_09_PersonDeviceLines;
using LINE_10		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_10_PersonAddressLines;
using LINE_11		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_11_PersonEddressLines;
using LINE_12		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_12_PersonWebsiteLines;
using NOTE_01		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_13_PersonNotesHeader;
using NOTE_02		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_14_PersonTagLines;
using NOTE_03		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_15_PersonFamilyLines;
using NOTE_04		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_16_PersonGroupLines;
using NOTE_05		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_17_PersonNoteLines;
using NOTE_06		= CONTACTS.LOCAL.PRIMARY.PERSON.VCF.Vcf_18_PersonCurrency;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		#region EXPORT PERSON
		//___________________________________________________________________________________________________________________________________
		public void ExportPerson()
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
			new LINE_12( this ).AppendLines( vcf_text );
			new NOTE_01( this ).AppendLines( vcf_text );
			new NOTE_02( this ).AppendLines( vcf_text );
			new NOTE_03( this ).AppendLines( vcf_text );
			new NOTE_04( this ).AppendLines( vcf_text );
			new NOTE_05( this ).AppendLines( vcf_text );
			new NOTE_06( this ).AppendLines( vcf_text );

			vcf_text.WriteLines( ExportFilename );
		}
		#endregion


		#region FILE NAME
		//_______________________________________________________________________________________________________________________________________
		public string ExportFilename
		{
			get
			{
				string s = DBCONNECTOR.PersonTemplate;

				s = s.Replace( PRESET.S0, UpperSurname.AsUpper );
				s = s.Replace( PRESET.S1, GivenName.AsIs );
				s = s.Replace( PRESET.S2, PkPerson.AsString );
				s = s.Replace( PRESET.S3, DateTime.Now.ToString( "yyyy.MM.dd.HHmm" ) );

				return s.ToString();
			}
		}
		#endregion
	}
}
