//___________________________________________________________________________________________________________________________________________________
using SBLDR = System.Text.StringBuilder;
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL 
using RECON		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reconstruction;
using COUNTRY	= CONTACTS.LOCAL.TERTIARY.NATION.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{

		#region THESE CREATE A STRING[] WHICH IS USED BY FORMS.
		//_______________________________________________________________________________________________________________________________________
		public string[] RealisePostalRule()
		{
			string realised_rule = RealiseAddressRule( this.VcfPostal.Value );
			return SplitAddress( realised_rule );
		}
		//_______________________________________________________________________________________________________________________________________
		public string[] RealisePhysicalRule()
		{
			string realised_rule = RealiseAddressRule( this.VcfPhysical.Value );
			return SplitAddress( realised_rule );
		}
		//_______________________________________________________________________________________________________________________________________
		public string[] RealiseExtendedRule()
		{
			string realised_rule = RealiseAddressRule( this.VcfExtended.Value );
			return SplitAddress( realised_rule );
		}
		//_______________________________________________________________________________________________________________________________________
		public string[] RealiseExcelRule()
		{
			string realised_rule = RealiseAddressRule( this.ExcelPattern.Value );
			return SplitAddress( realised_rule );
		}
		//___________________________________________________________________________________________________________________________________________                                                                                                                                                   
		private string[] SplitAddress( string in_line )
		{
			return in_line.Split( PRESET.Functional_LF, StringSplitOptions.None);
		}
		#endregion


		#region THESE CREATE A STRING WHICH IS INSERTED INTO THE VCF FILE.
		//_______________________________________________________________________________________________________________________________________
		public string VcfPostalRule
		{
			get
			{
				string s = RealiseAddressRule( this.VcfPostal.Value );
				return s.Replace( PRESET.Functional_LF, PRESET.CommaSpace );
			}
		}
		//_______________________________________________________________________________________________________________________________________
		public string VcfPhysicalRule
		{
			get
			{
				string s = RealiseAddressRule( this.VcfPhysical.Value );
				return s.Replace( PRESET.Functional_LF, PRESET.CommaSpace );
			}
		}
		//_______________________________________________________________________________________________________________________________________
		public string VcfExtendedRule
		{
			get
			{
				string s = RealiseAddressRule( this.VcfExtended.Value );
				return s.Replace( PRESET.Functional_LF, PRESET.CommaSpace );
			}
		}
		//_______________________________________________________________________________________________________________________________________
		public string VcfExcelRule
		{
			get
			{
				string s = RealiseAddressRule( this.ExcelPattern.Value );
				return s.Replace( PRESET.OneAster, PRESET.CommaSpace );
			}
		}
		#endregion


		#region REALISE ADDRESS RULES: THE GIANT SWITCH.
		//_______________________________________________________________________________________________________________________________________
		private string RealiseAddressRule( string address_pattern )
		{
			string s = address_pattern;

			foreach ( string code in RECON.Codes )
			{
				switch ( code )
				{
					#region AsIs: Return entire token in the form in which it is stored.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_AsIs:
						s = s.Replace( RECON.Assemblage_AsIs, this.Assemblage.AsIs );
						break;

					case RECON.Level_AsIs:
						s = s.Replace( RECON.Level_AsIs, this.Level.AsIs );
						break;

					case RECON.Unit_AsIs:
						s = s.Replace( RECON.Unit_AsIs, this.Unit.AsIs );
						break;

					case RECON.Extension_AsIs:
						s = s.Replace( RECON.Extension_AsIs, this.Extension.AsIs );
						break;

					case RECON.RuralDelivery_AsIs:
						s = s.Replace( RECON.RuralDelivery_AsIs, this.RuralDelivery.AsIs );
						break;

					case RECON.PostalCode_AsIs:
						s = s.Replace( RECON.PostalCode_AsIs, this.PostalCode.AsIs );
						break;

					case RECON.BoxNumber_AsIs:
						s = s.Replace( RECON.BoxNumber_AsIs, this.BoxNumber.AsIs );
						break;

					case RECON.HouseNumber_AsIs:
						s = s.Replace( RECON.HouseNumber_AsIs, this.HouseNumber.AsIs );
						break;

					case RECON.StreetName_AsIs:
						s = s.Replace( RECON.StreetName_AsIs, this.StreetName.AsIs );
						break;

					case RECON.StreetType_AsIs:
						s = s.Replace( RECON.StreetType_AsIs, this.StreetType.AsIs );
						break;

					case RECON.Compass_AsIs:
						s = s.Replace( RECON.Compass_AsIs, this.Compass.AsIs );
						break;

					case RECON.Suburb_AsIs:
						s = s.Replace( RECON.Suburb_AsIs, this.Suburb.AsIs );
						break;

					case RECON.City_AsIs:
						s = s.Replace( RECON.City_AsIs, this.City.AsIs );
						break;

					case RECON.Metropolitan_AsIs:
						s = s.Replace( RECON.Metropolitan_AsIs, this.Metropolitan.AsIs );
						break;

					case RECON.ProvinceName_AsIs:
						s = s.Replace( RECON.ProvinceName_AsIs, this.ProvinceName.AsIs );
						break;

					case RECON.ProvinceCode_AsIs:
						s = s.Replace( RECON.ProvinceCode_AsIs, this.ProvinceCode.AsIs );
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
					#endregion


					#region UPPER: Return entire token in UPPER case.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_UPPER:
						s = s.Replace( RECON.Assemblage_UPPER, this.Assemblage.AsUpper );
						break;

					case RECON.Level_UPPER:
						s = s.Replace( RECON.Level_UPPER, this.Level.AsUpper );
						break;

					case RECON.Unit_UPPER:
						s = s.Replace( RECON.Unit_UPPER, this.Unit.AsUpper );
						break;

					case RECON.Extension_UPPER:
						s = s.Replace( RECON.Extension_UPPER, this.Extension.AsUpper );
						break;

					case RECON.RuralDelivery_UPPER:
						s = s.Replace( RECON.RuralDelivery_UPPER, this.RuralDelivery.AsUpper );
						break;

					case RECON.PostalCode_UPPER:
						s = s.Replace( RECON.PostalCode_UPPER, this.PostalCode.AsUpper );
						break;

					case RECON.BoxNumber_UPPER:
						s = s.Replace( RECON.BoxNumber_UPPER, this.BoxNumber.AsUpper );
						break;

					case RECON.HouseNumber_UPPER:
						s = s.Replace( RECON.HouseNumber_UPPER, this.HouseNumber.AsUpper );
						break;

					case RECON.StreetName_UPPER:
						s = s.Replace( RECON.StreetName_UPPER, this.StreetName.AsUpper );
						break;

					case RECON.StreetType_UPPER:
						s = s.Replace( RECON.StreetType_UPPER, this.StreetType.AsUpper );
						break;

					case RECON.Compass_UPPER:
						s = s.Replace( RECON.Compass_UPPER, this.Compass.AsUpper );
						break;

					case RECON.Suburb_UPPER:
						s = s.Replace( RECON.Suburb_UPPER, this.Suburb.AsUpper );
						break;

					case RECON.City_UPPER:
						s = s.Replace( RECON.City_UPPER, this.City.AsUpper );
						break;

					case RECON.Metropolitan_UPPER:
						s = s.Replace( RECON.Metropolitan_UPPER, this.Metropolitan.AsUpper );
						break;

					case RECON.ProvinceName_UPPER:
						s = s.Replace( RECON.ProvinceName_UPPER, this.ProvinceName.AsUpper );
						break;

					case RECON.ProvinceCode_UPPER:
						s = s.Replace( RECON.ProvinceCode_UPPER, this.ProvinceCode.AsUpper );
						break;


					//Country________________________________________________________________________________________________________________________
					case RECON.CountryName_UPPER:
						s = s.Replace( RECON.CountryName_UPPER, this.CountryName.AsUpper );
						break;

					case RECON.CountryCode_UPPER:
						s = s.Replace( RECON.CountryCode_UPPER, this.CountryCode.AsUpper );
						break;

					case RECON.ShortIsoCode_UPPER:
						s = s.Replace( RECON.ShortIsoCode_UPPER, this.ShortIsoCode.AsUpper );
						break;

					case RECON.LongIsoCode_UPPER:
						s = s.Replace( RECON.LongIsoCode_UPPER, this.LongIsoCode.AsUpper );
						break;
					#endregion


					#region Proper: Return entire token in Proper case.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_Proper:
						s = s.Replace( RECON.Assemblage_Proper, this.Assemblage.AsProper );
						break;

					case RECON.Level_Proper:
						s = s.Replace( RECON.Level_Proper, this.Level.AsProper );
						break;

					case RECON.Unit_Proper:
						s = s.Replace( RECON.Unit_Proper, this.Unit.AsProper );
						break;

					case RECON.Extension_Proper:
						s = s.Replace( RECON.Extension_Proper, this.Extension.AsProper );
						break;

					case RECON.RuralDelivery_Proper:
						s = s.Replace( RECON.RuralDelivery_Proper, this.RuralDelivery.AsProper );
						break;

					case RECON.PostalCode_Proper:
						s = s.Replace( RECON.PostalCode_Proper, this.PostalCode.AsProper );
						break;

					case RECON.BoxNumber_Proper:
						s = s.Replace( RECON.BoxNumber_Proper, this.BoxNumber.AsProper );
						break;

					case RECON.HouseNumber_Proper:
						s = s.Replace( RECON.HouseNumber_Proper, this.HouseNumber.AsProper );
						break;

					case RECON.StreetName_Proper:
						s = s.Replace( RECON.StreetName_Proper, this.StreetName.AsProper );
						break;

					case RECON.StreetType_Proper:
						s = s.Replace( RECON.StreetType_Proper, this.StreetType.AsProper );
						break;

					case RECON.Compass_Proper:
						s = s.Replace( RECON.Compass_Proper, this.Compass.AsIs );
						break;

					case RECON.Suburb_Proper:
						s = s.Replace( RECON.Suburb_Proper, this.Suburb.AsProper );
						break;

					case RECON.City_Proper:
						s = s.Replace( RECON.City_Proper, this.City.AsProper );
						break;

					case RECON.Metropolitan_Proper:
						s = s.Replace( RECON.Metropolitan_Proper, this.Metropolitan.AsProper );
						break;

					case RECON.ProvinceName_Proper:
						s = s.Replace( RECON.ProvinceName_Proper, this.ProvinceName.AsProper );
						break;

					case RECON.ProvinceCode_Proper:
						s = s.Replace( RECON.ProvinceCode_Proper, this.ProvinceCode.AsProper );
						break;


					//Country________________________________________________________________________________________________________________________
					case RECON.CountryName_Proper:
						s = s.Replace( RECON.CountryName_Proper, this.CountryName.AsProper );
						break;

					case RECON.CountryCode_Proper:
						s = s.Replace( RECON.CountryCode_Proper, this.CountryCode.AsIs );
						break;

					case RECON.ShortIsoCode_Proper:
						s = s.Replace( RECON.ShortIsoCode_Proper, this.ShortIsoCode.AsIs );
						break;

					case RECON.LongIsoCode_Proper:
						s = s.Replace( RECON.LongIsoCode_Proper, this.LongIsoCode.AsIs );
						break;
					#endregion


					#region lower: Return entire token in lower case.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_lower:
						s = s.Replace( RECON.Assemblage_lower, this.Assemblage.AsLower );
						break;

					case RECON.Level_lower:
						s = s.Replace( RECON.Level_lower, this.Level.AsLower );
						break;

					case RECON.Unit_lower:
						s = s.Replace( RECON.Unit_lower, this.Unit.AsLower );
						break;

					case RECON.Extension_lower:
						s = s.Replace( RECON.Extension_lower, this.Extension.AsLower );
						break;

					case RECON.RuralDelivery_lower:
						s = s.Replace( RECON.RuralDelivery_lower, this.RuralDelivery.AsLower );
						break;

					case RECON.PostalCode_lower:
						s = s.Replace( RECON.PostalCode_lower, this.PostalCode.AsLower );
						break;

					case RECON.BoxNumber_lower:
						s = s.Replace( RECON.BoxNumber_lower, this.BoxNumber.AsLower );
						break;

					case RECON.HouseNumber_lower:
						s = s.Replace( RECON.HouseNumber_lower, this.HouseNumber.AsLower );
						break;

					case RECON.StreetName_lower:
						s = s.Replace( RECON.StreetName_lower, this.StreetName.AsLower );
						break;

					case RECON.StreetType_lower:
						s = s.Replace( RECON.StreetType_lower, this.StreetType.AsLower );
						break;

					case RECON.Compass_lower:
						s = s.Replace( RECON.Compass_lower, this.Compass.AsLower );
						break;

					case RECON.Suburb_lower:
						s = s.Replace( RECON.Suburb_lower, this.Suburb.AsLower );
						break;

					case RECON.City_lower:
						s = s.Replace( RECON.City_lower, this.City.AsLower );
						break;

					case RECON.Metropolitan_lower:
						s = s.Replace( RECON.Metropolitan_lower, this.Metropolitan.AsLower );
						break;

					case RECON.ProvinceName_lower:
						s = s.Replace( RECON.ProvinceName_lower, this.ProvinceName.AsLower );
						break;

					case RECON.ProvinceCode_lower:
						s = s.Replace( RECON.ProvinceCode_lower, this.ProvinceCode.AsLower );
						break;


					//Country________________________________________________________________________________________________________________________
					case RECON.CountryName_lower:
						s = s.Replace( RECON.CountryName_lower, this.CountryName.AsLower );
						break;

					case RECON.CountryCode_lower:
						s = s.Replace( RECON.CountryCode_lower, this.CountryCode.AsIs );
						break;

					case RECON.ShortIsoCode_lower:
						s = s.Replace( RECON.ShortIsoCode_lower, this.ShortIsoCode.AsIs );
						break;

					case RECON.LongIsoCode_lower:
						s = s.Replace( RECON.LongIsoCode_lower, this.LongIsoCode.AsIs );
						break;
					#endregion


					#region Initial as lower: Return token's left-most character in lower case.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_initial:
						s = s.Replace( RECON.Assemblage_initial, this.Assemblage.AsLowerInitial );
						break;

					case RECON.Level_initial:
						s = s.Replace( RECON.Level_initial, this.Level.AsLowerInitial );
						break;

					case RECON.Unit_initial:
						s = s.Replace( RECON.Unit_initial, this.Unit.AsLowerInitial );
						break;

					case RECON.Extension_initial:
						s = s.Replace( RECON.Extension_initial, this.Extension.AsLowerInitial );
						break;

					case RECON.RuralDelivery_initial:
						s = s.Replace( RECON.RuralDelivery_initial, this.RuralDelivery.AsLowerInitial );
						break;

					case RECON.PostalCode_initial:
						s = s.Replace( RECON.PostalCode_initial, this.PostalCode.AsLowerInitial );
						break;

					case RECON.BoxNumber_initial:
						s = s.Replace( RECON.BoxNumber_initial, this.BoxNumber.AsLowerInitial );
						break;

					case RECON.HouseNumber_initial:
						s = s.Replace( RECON.HouseNumber_initial, this.HouseNumber.AsLowerInitial );
						break;

					case RECON.StreetName_initial:
						s = s.Replace( RECON.StreetName_initial, this.StreetName.AsLowerInitial );
						break;

					case RECON.StreetType_initial:
						s = s.Replace( RECON.StreetType_initial, this.StreetType.AsLowerInitial );
						break;

					case RECON.Compass_initial:
						s = s.Replace( RECON.Compass_initial, this.Compass.AsLowerInitial );
						break;

					case RECON.Suburb_initial:
						s = s.Replace( RECON.Suburb_initial, this.Suburb.AsLowerInitial );
						break;

					case RECON.City_initial:
						s = s.Replace( RECON.City_initial, this.City.AsLowerInitial );
						break;

					case RECON.Metropolitan_initial:
						s = s.Replace( RECON.Metropolitan_initial, this.Metropolitan.AsLowerInitial );
						break;

					case RECON.ProvinceName_initial:
						s = s.Replace( RECON.ProvinceName_initial, this.ProvinceName.AsLowerInitial );
						break;

					case RECON.ProvinceCode_initial:
						s = s.Replace( RECON.ProvinceCode_initial, this.ProvinceCode.AsLowerInitial );
						break;


					//Country________________________________________________________________________________________________________________________
					case RECON.CountryName_initial:
						s = s.Replace( RECON.CountryName_initial, this.CountryName.AsLowerInitial );
						break;

					case RECON.CountryCode_initial:
						s = s.Replace( RECON.CountryCode_initial, this.CountryCode.AsLowerInitial );
						break;

					case RECON.ShortIsoCode_initial:
						s = s.Replace( RECON.ShortIsoCode_initial, this.ShortIsoCode.AsLowerInitial );
						break;

					case RECON.LongIsoCode_initial:
						s = s.Replace( RECON.LongIsoCode_initial, this.LongIsoCode.AsLowerInitial );
						break;
					#endregion


					#region Initial as upper: Return token's left-most character in UPPER case.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_INITIAL:
						s = s.Replace( RECON.Assemblage_INITIAL, this.Assemblage.AsUpperInitial );
						break;

					case RECON.Level_INITIAL:
						s = s.Replace( RECON.Level_INITIAL, this.Level.AsUpperInitial );
						break;

					case RECON.Unit_INITIAL:
						s = s.Replace( RECON.Unit_INITIAL, this.Unit.AsUpperInitial );
						break;

					case RECON.Extension_INITIAL:
						s = s.Replace( RECON.Extension_INITIAL, this.Extension.AsUpperInitial );
						break;

					case RECON.RuralDelivery_INITIAL:
						s = s.Replace( RECON.RuralDelivery_INITIAL, this.RuralDelivery.AsUpperInitial );
						break;

					case RECON.PostalCode_INITIAL:
						s = s.Replace( RECON.PostalCode_INITIAL, this.PostalCode.AsUpperInitial );
						break;

					case RECON.BoxNumber_INITIAL:
						s = s.Replace( RECON.BoxNumber_INITIAL, this.BoxNumber.AsUpperInitial );
						break;

					case RECON.HouseNumber_INITIAL:
						s = s.Replace( RECON.HouseNumber_INITIAL, this.HouseNumber.AsUpperInitial );
						break;

					case RECON.StreetName_INITIAL:
						s = s.Replace( RECON.StreetName_INITIAL, this.StreetName.AsUpperInitial );
						break;

					case RECON.StreetType_INITIAL:
						s = s.Replace( RECON.StreetType_INITIAL, this.StreetType.AsUpperInitial );
						break;

					case RECON.Compass_INITIAL:
						s = s.Replace( RECON.Compass_INITIAL, this.Compass.AsUpperInitial );
						break;

					case RECON.Suburb_INITIAL:
						s = s.Replace( RECON.Suburb_INITIAL, this.Suburb.AsUpperInitial );
						break;

					case RECON.City_INITIAL:
						s = s.Replace( RECON.City_INITIAL, this.City.AsUpperInitial );
						break;

					case RECON.Metropolitan_INITIAL:
						s = s.Replace( RECON.Metropolitan_INITIAL, this.Metropolitan.AsUpperInitial );
						break;

					case RECON.ProvinceName_INITIAL:
						s = s.Replace( RECON.ProvinceName_INITIAL, this.ProvinceName.AsUpperInitial );
						break;

					case RECON.ProvinceCode_INITIAL:
						s = s.Replace( RECON.ProvinceCode_INITIAL, this.ProvinceCode.AsUpperInitial );
						break;


					//Country________________________________________________________________________________________________________________________
					case RECON.CountryName_INITIAL:
						s = s.Replace( RECON.CountryName_INITIAL, this.CountryName.AsUpperInitial );
						break;

					case RECON.CountryCode_INITIAL:
						s = s.Replace( RECON.CountryCode_INITIAL, this.CountryCode.AsUpperInitial );
						break;

					case RECON.ShortIsoCode_INITIAL:
						s = s.Replace( RECON.ShortIsoCode_INITIAL, this.ShortIsoCode.AsUpperInitial );
						break;

					case RECON.LongIsoCode_INITIAL:
						s = s.Replace( RECON.LongIsoCode_INITIAL, this.LongIsoCode.AsUpperInitial );
						break;
					#endregion


					#region Wrap it up...
					//Replace the 'no value' code with two dashes.
					case RECON.NoValue:
//						s = s.Replace( RECON.NoValue, PRESET.TwoDashes );
						s = s.Replace( RECON.NoValue, String.Empty );
						break;

					//Do nothing... .
					default:
						break;
					#endregion
				}
			}
			return s;
		}
		#endregion
	}
}
