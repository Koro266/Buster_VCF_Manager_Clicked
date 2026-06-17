//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL 
using RECON		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reconstruction;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		private static string FinderPattern = 
			"/pk"				+ "~" +
			"/hn /sn /st /cp"	+ "~" +
			"/sb /ct;"			+ "~" +
			"/mt /pv (/pa);"	+ "~" +
			"/bx /rd /pc;"		+ "~" +
			"/as /ex /lv /un;"	+ "~" +
			"/cy (/cd)";

		#region REALISE ADDRESS RULES: THE GIANT SWITCH.
		//_______________________________________________________________________________________________________________________________________
		public string[] RealiseFinderPattern()
		{
			string s = FinderPattern;

			foreach ( string code in RECON.Codes )
			{
				switch ( code )
				{
					#region AsIs: Return entire token in the form in which it is stored.
					//___________________________________________________________________________________________________________________________
					case RECON.PkAddress:
						s = s.Replace( RECON.PkAddress, this.PkAddress.AsString );
						break;

					case RECON.Assemblage_AsIs:
						s = s.Replace( RECON.Assemblage_AsIs, this.Assemblage.VcfValue );
						break;

					case RECON.Level_AsIs:
						s = s.Replace( RECON.Level_AsIs, this.Level.VcfValue );
						break;

					case RECON.Unit_AsIs:
						s = s.Replace( RECON.Unit_AsIs, this.Unit.VcfValue );
						break;

					case RECON.Extension_AsIs:
						s = s.Replace( RECON.Extension_AsIs, this.Extension.VcfValue );
						break;

					case RECON.RuralDelivery_AsIs:
						s = s.Replace( RECON.RuralDelivery_AsIs, this.RuralDelivery.VcfValue );
						break;

					case RECON.PostalCode_AsIs:
						s = s.Replace( RECON.PostalCode_AsIs, this.PostalCode.VcfValue );
						break;

					case RECON.BoxNumber_AsIs:
						s = s.Replace( RECON.BoxNumber_AsIs, this.BoxNumber.VcfValue );
						break;

					case RECON.HouseNumber_AsIs:
						s = s.Replace( RECON.HouseNumber_AsIs, this.HouseNumber.VcfValue );
						break;

					case RECON.StreetName_AsIs:
						s = s.Replace( RECON.StreetName_AsIs, this.StreetName.VcfValue );
						break;

					case RECON.StreetType_AsIs:
						s = s.Replace( RECON.StreetType_AsIs, this.StreetType.VcfValue );
						break;

					case RECON.Compass_AsIs:
						s = s.Replace( RECON.Compass_AsIs, this.Compass.VcfValue );
						break;

					case RECON.Suburb_AsIs:
						s = s.Replace( RECON.Suburb_AsIs, this.Suburb.VcfValue );
						break;

					case RECON.City_AsIs:
						s = s.Replace( RECON.City_AsIs, this.City.VcfValue );
						break;

					case RECON.Metropolitan_AsIs:
						s = s.Replace( RECON.Metropolitan_AsIs, this.Metropolitan.VcfValue );
						break;

					case RECON.ProvinceName_AsIs:
						s = s.Replace( RECON.ProvinceName_AsIs, this.ProvinceName.VcfValue );
						break;

					case RECON.ProvinceCode_AsIs:
						s = s.Replace( RECON.ProvinceCode_AsIs, this.ProvinceCode.VcfValue );
						break;


					//Country________________________________________________________________________________________________________________________
					case RECON.CountryName_AsIs:
						s = s.Replace( RECON.CountryName_AsIs, this.CountryName.AsIs );
						break;

					case RECON.CountryCode_AsIs:
						s = s.Replace( RECON.CountryCode_AsIs, this.CountryCode.AsIs );
						break;

					case RECON.ShortIsoCode_AsIs:
						s = s.Replace( RECON.ShortIsoCode_AsIs, this.ShortIsoCode.AsIs );
						break;

					case RECON.LongIsoCode_AsIs:
						s = s.Replace( RECON.LongIsoCode_AsIs, this.LongIsoCode.AsIs );
						break;

					//Do nothing... .
					default:
						break;
					#endregion
				}
			}
			return s.Split( PRESET.Tilde, StringSplitOptions.None );
		}
		#endregion
	}
}
