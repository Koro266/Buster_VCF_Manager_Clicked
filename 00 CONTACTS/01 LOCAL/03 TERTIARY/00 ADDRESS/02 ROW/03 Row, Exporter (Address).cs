//___________________________________________________________________________________________________________________________________________________
using SBLDR = System.Text.StringBuilder;
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		public const string ExportPattern = "+#0 #1 #2 #3";	 //"+/cy /sc /ld /td" not really..., placeholder

		//_______________________________________________________________________________________________________________________________________
		public string ExportNamex
		{
			get
			{
				SBLDR s = new SBLDR( ExportPattern );
				//placeholder...
				//s.Replace( PRESET.S0, this.FkCountry.CountryCode.AsIs );
				s.Replace( PRESET.S1, this.BoxNumber.AsIs );
				s.Replace( PRESET.S2, this.StreetName.AsIs );
				s.Replace( PRESET.S3, this.ProvinceName.AsIs );

				return s.ToString();
			}
		}
	}
}
