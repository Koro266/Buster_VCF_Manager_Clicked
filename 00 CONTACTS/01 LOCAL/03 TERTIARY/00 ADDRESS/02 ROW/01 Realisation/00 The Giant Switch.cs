//___________________________________________________________________________________________________________________________________________________
using System.Text.RegularExpressions;
//GLOBAL
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using RECON			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reconstruction;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public class TheGiantSwitch
	{
		private ADDRESS_ROW _AddressRow;

		//___________________________________________________________________________________________________________________________________________
		public TheGiantSwitch( ADDRESS_ROW parent_row )
		{
			_AddressRow = parent_row;
		}
		//_______________________________________________________________________________________________________________________________________
		public string RealiseAddressRule( string address_pattern )
		{
			string s = address_pattern;

			foreach ( string code in RECON.Codes )
			{
				switch ( code )
				{
					#region AsIs: Return entire token in the form in which it is stored.
					//___________________________________________________________________________________________________________________________
					case RECON.PkAddress:
						s = Regex.Replace( s, RECON.PkAddress, _AddressRow.PkAddress.AsString );
						break;

					case RECON.FkCountry:
						s = Regex.Replace( s, RECON.FkCountry, _AddressRow.FkCountry.AsString );
						break;

					case RECON.Assemblage_AsIs:
						s = Regex.Replace( s, RECON.Assemblage_AsIs, _AddressRow.Assemblage.AsIs );
						break;

					case RECON.Level_AsIs:
						s = Regex.Replace( s, RECON.Level_AsIs, _AddressRow.Level.AsIs );
						break;

					case RECON.Unit_AsIs:
						s = Regex.Replace( s, RECON.Unit_AsIs, _AddressRow.Unit.AsIs );
						break;

					case RECON.Extension_AsIs:
						s = Regex.Replace( s, RECON.Extension_AsIs, _AddressRow.Extension.AsIs );
						break;

					case RECON.RuralDelivery_AsIs:
						s = Regex.Replace( s, RECON.RuralDelivery_AsIs, _AddressRow.RuralDelivery.AsIs );
						break;

					case RECON.PostalCode_AsIs:
						s = Regex.Replace( s, RECON.PostalCode_AsIs, _AddressRow.PostalCode.AsIs );
						break;

					case RECON.BoxNumber_AsIs:
						s = Regex.Replace( s, RECON.BoxNumber_AsIs, _AddressRow.BoxNumber.AsIs );
						break;

					case RECON.HouseNumber_AsIs:
						s = Regex.Replace( s, RECON.HouseNumber_AsIs, _AddressRow.HouseNumber.AsIs );
						break;

					case RECON.StreetName_AsIs:
						s = Regex.Replace( s, RECON.StreetName_AsIs, _AddressRow.StreetName.AsIs );
						break;

					case RECON.StreetType_AsIs:
						s = Regex.Replace( s, RECON.StreetType_AsIs, _AddressRow.StreetType.AsIs );
						break;

					case RECON.Compass_AsIs:
						s = Regex.Replace( s, RECON.Compass_AsIs, _AddressRow.Compass.AsIs );
						break;

					case RECON.Suburb_AsIs:
						s = Regex.Replace( s, RECON.Suburb_AsIs, _AddressRow.Suburb.AsIs );
						break;

					case RECON.City_AsIs:
						s = Regex.Replace( s, RECON.City_AsIs, _AddressRow.City.AsIs );
						break;

					case RECON.Metropolitan_AsIs:
						s = Regex.Replace( s, RECON.Metropolitan_AsIs, _AddressRow.Metropolitan.AsIs );
						break;

					case RECON.ProvinceName_AsIs:
						s = Regex.Replace( s, RECON.ProvinceName_AsIs, _AddressRow.ProvinceName.AsIs );
						break;

					case RECON.ProvinceCode_AsIs:
						s = Regex.Replace( s, RECON.ProvinceCode_AsIs, _AddressRow.ProvinceCode.AsIs );
						break;

					case RECON.CountryName_AsIs:
						s = Regex.Replace( s, RECON.CountryName_AsIs, _AddressRow.CountryName.AsIs );
						break;

					case RECON.CountryCode_AsIs:
						s = Regex.Replace( s, RECON.CountryCode_AsIs, _AddressRow.CountryCode.AsIs );
						break;

					case RECON.ShortIsoCode_AsIs:
						s = Regex.Replace( s, RECON.ShortIsoCode_AsIs, _AddressRow.ShortIsoCode.AsIs );
						break;

					case RECON.LongIsoCode_AsIs:
						s = Regex.Replace( s, RECON.LongIsoCode_AsIs, _AddressRow.LongIsoCode.AsIs );
						break;

					case RECON.Notes:
						s = Regex.Replace( s, RECON.Notes, _AddressRow.Notes.AsIs );
						break;
					#endregion


					#region UPPER: Return entire token in UPPER case.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_UPPER:
						s = s.Replace( RECON.Assemblage_UPPER, _AddressRow.Assemblage.AsUpper );
						break;

					case RECON.Level_UPPER:
						s = s.Replace( RECON.Level_UPPER, _AddressRow.Level.AsUpper );
						break;

					case RECON.Unit_UPPER:
						s = s.Replace( RECON.Unit_UPPER, _AddressRow.Unit.AsUpper );
						break;

					case RECON.Extension_UPPER:
						s = s.Replace( RECON.Extension_UPPER, _AddressRow.Extension.AsUpper );
						break;

					case RECON.RuralDelivery_UPPER:
						s = s.Replace( RECON.RuralDelivery_UPPER, _AddressRow.RuralDelivery.AsUpper );
						break;

					case RECON.PostalCode_UPPER:
						s = s.Replace( RECON.PostalCode_UPPER, _AddressRow.PostalCode.AsUpper );
						break;

					case RECON.BoxNumber_UPPER:
						s = s.Replace( RECON.BoxNumber_UPPER, _AddressRow.BoxNumber.AsUpper );
						break;

					case RECON.HouseNumber_UPPER:
						s = s.Replace( RECON.HouseNumber_UPPER, _AddressRow.HouseNumber.AsUpper );
						break;

					case RECON.StreetName_UPPER:
						s = s.Replace( RECON.StreetName_UPPER, _AddressRow.StreetName.AsUpper );
						break;

					case RECON.StreetType_UPPER:
						s = s.Replace( RECON.StreetType_UPPER, _AddressRow.StreetType.AsUpper );
						break;

					case RECON.Compass_UPPER:
						s = s.Replace( RECON.Compass_UPPER, _AddressRow.Compass.AsUpper );
						break;

					case RECON.Suburb_UPPER:
						s = s.Replace( RECON.Suburb_UPPER, _AddressRow.Suburb.AsUpper );
						break;

					case RECON.City_UPPER:
						s = s.Replace( RECON.City_UPPER, _AddressRow.City.AsUpper );
						break;

					case RECON.Metropolitan_UPPER:
						s = s.Replace( RECON.Metropolitan_UPPER, _AddressRow.Metropolitan.AsUpper );
						break;

					case RECON.ProvinceName_UPPER:
						s = s.Replace( RECON.ProvinceName_UPPER, _AddressRow.ProvinceName.AsUpper );
						break;

					case RECON.ProvinceCode_UPPER:
						s = s.Replace( RECON.ProvinceCode_UPPER, _AddressRow.ProvinceCode.AsUpper );
						break;


					//Country________________________________________________________________________________________________________________________
					case RECON.CountryName_UPPER:
						s = s.Replace( RECON.CountryName_UPPER, _AddressRow.CountryName.AsUpper );
						break;

					case RECON.CountryCode_UPPER:
						s = s.Replace( RECON.CountryCode_UPPER, _AddressRow.CountryCode.AsUpper );
						break;

					case RECON.ShortIsoCode_UPPER:
						s = s.Replace( RECON.ShortIsoCode_UPPER, _AddressRow.ShortIsoCode.AsUpper );
						break;

					case RECON.LongIsoCode_UPPER:
						s = s.Replace( RECON.LongIsoCode_UPPER, _AddressRow.LongIsoCode.AsUpper );
						break;
					#endregion


					#region Proper: Return entire token in Proper case.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_Proper:
						s = s.Replace( RECON.Assemblage_Proper, _AddressRow.Assemblage.AsProper );
						break;

					case RECON.Level_Proper:
						s = s.Replace( RECON.Level_Proper, _AddressRow.Level.AsProper );
						break;

					case RECON.Unit_Proper:
						s = s.Replace( RECON.Unit_Proper, _AddressRow.Unit.AsProper );
						break;

					case RECON.Extension_Proper:
						s = s.Replace( RECON.Extension_Proper, _AddressRow.Extension.AsProper );
						break;

					case RECON.RuralDelivery_Proper:
						s = s.Replace( RECON.RuralDelivery_Proper, _AddressRow.RuralDelivery.AsProper );
						break;

					case RECON.PostalCode_Proper:
						s = s.Replace( RECON.PostalCode_Proper, _AddressRow.PostalCode.AsProper );
						break;

					case RECON.BoxNumber_Proper:
						s = s.Replace( RECON.BoxNumber_Proper, _AddressRow.BoxNumber.AsProper );
						break;

					case RECON.HouseNumber_Proper:
						s = s.Replace( RECON.HouseNumber_Proper, _AddressRow.HouseNumber.AsProper );
						break;

					case RECON.StreetName_Proper:
						s = s.Replace( RECON.StreetName_Proper, _AddressRow.StreetName.AsProper );
						break;

					case RECON.StreetType_Proper:
						s = s.Replace( RECON.StreetType_Proper, _AddressRow.StreetType.AsProper );
						break;

					case RECON.Compass_Proper:
						s = s.Replace( RECON.Compass_Proper, _AddressRow.Compass.AsIs );
						break;

					case RECON.Suburb_Proper:
						s = s.Replace( RECON.Suburb_Proper, _AddressRow.Suburb.AsProper );
						break;

					case RECON.City_Proper:
						s = s.Replace( RECON.City_Proper, _AddressRow.City.AsProper );
						break;

					case RECON.Metropolitan_Proper:
						s = s.Replace( RECON.Metropolitan_Proper, _AddressRow.Metropolitan.AsProper );
						break;

					case RECON.ProvinceName_Proper:
						s = s.Replace( RECON.ProvinceName_Proper, _AddressRow.ProvinceName.AsProper );
						break;

					case RECON.ProvinceCode_Proper:
						s = s.Replace( RECON.ProvinceCode_Proper, _AddressRow.ProvinceCode.AsProper );
						break;


					//Country________________________________________________________________________________________________________________________
					case RECON.CountryName_Proper:
						s = s.Replace( RECON.CountryName_Proper, _AddressRow.CountryName.AsProper );
						break;

					case RECON.CountryCode_Proper:
						s = s.Replace( RECON.CountryCode_Proper, _AddressRow.CountryCode.AsIs );
						break;

					case RECON.ShortIsoCode_Proper:
						s = s.Replace( RECON.ShortIsoCode_Proper, _AddressRow.ShortIsoCode.AsIs );
						break;

					case RECON.LongIsoCode_Proper:
						s = s.Replace( RECON.LongIsoCode_Proper, _AddressRow.LongIsoCode.AsIs );
						break;
					#endregion


					#region lower: Return entire token in lower case.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_lower:
						s = s.Replace( RECON.Assemblage_lower, _AddressRow.Assemblage.AsLower );
						break;

					case RECON.Level_lower:
						s = s.Replace( RECON.Level_lower, _AddressRow.Level.AsLower );
						break;

					case RECON.Unit_lower:
						s = s.Replace( RECON.Unit_lower, _AddressRow.Unit.AsLower );
						break;

					case RECON.Extension_lower:
						s = s.Replace( RECON.Extension_lower, _AddressRow.Extension.AsLower );
						break;

					case RECON.RuralDelivery_lower:
						s = s.Replace( RECON.RuralDelivery_lower, _AddressRow.RuralDelivery.AsLower );
						break;

					case RECON.PostalCode_lower:
						s = s.Replace( RECON.PostalCode_lower, _AddressRow.PostalCode.AsLower );
						break;

					case RECON.BoxNumber_lower:
						s = s.Replace( RECON.BoxNumber_lower, _AddressRow.BoxNumber.AsLower );
						break;

					case RECON.HouseNumber_lower:
						s = s.Replace( RECON.HouseNumber_lower, _AddressRow.HouseNumber.AsLower );
						break;

					case RECON.StreetName_lower:
						s = s.Replace( RECON.StreetName_lower, _AddressRow.StreetName.AsLower );
						break;

					case RECON.StreetType_lower:
						s = s.Replace( RECON.StreetType_lower, _AddressRow.StreetType.AsLower );
						break;

					case RECON.Compass_lower:
						s = s.Replace( RECON.Compass_lower, _AddressRow.Compass.AsLower );
						break;

					case RECON.Suburb_lower:
						s = s.Replace( RECON.Suburb_lower, _AddressRow.Suburb.AsLower );
						break;

					case RECON.City_lower:
						s = s.Replace( RECON.City_lower, _AddressRow.City.AsLower );
						break;

					case RECON.Metropolitan_lower:
						s = s.Replace( RECON.Metropolitan_lower, _AddressRow.Metropolitan.AsLower );
						break;

					case RECON.ProvinceName_lower:
						s = s.Replace( RECON.ProvinceName_lower, _AddressRow.ProvinceName.AsLower );
						break;

					case RECON.ProvinceCode_lower:
						s = s.Replace( RECON.ProvinceCode_lower, _AddressRow.ProvinceCode.AsLower );
						break;


					//Country________________________________________________________________________________________________________________________
					case RECON.CountryName_lower:
						s = s.Replace( RECON.CountryName_lower, _AddressRow.CountryName.AsLower );
						break;

					case RECON.CountryCode_lower:
						s = s.Replace( RECON.CountryCode_lower, _AddressRow.CountryCode.AsIs );
						break;

					case RECON.ShortIsoCode_lower:
						s = s.Replace( RECON.ShortIsoCode_lower, _AddressRow.ShortIsoCode.AsIs );
						break;

					case RECON.LongIsoCode_lower:
						s = s.Replace( RECON.LongIsoCode_lower, _AddressRow.LongIsoCode.AsIs );
						break;
					#endregion


					#region Initial as lower: Return token's left-most character in lower case.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_initial:
						s = s.Replace( RECON.Assemblage_initial, _AddressRow.Assemblage.AsLowerInitial );
						break;

					case RECON.Level_initial:
						s = s.Replace( RECON.Level_initial, _AddressRow.Level.AsLowerInitial );
						break;

					case RECON.Unit_initial:
						s = s.Replace( RECON.Unit_initial, _AddressRow.Unit.AsLowerInitial );
						break;

					case RECON.Extension_initial:
						s = s.Replace( RECON.Extension_initial, _AddressRow.Extension.AsLowerInitial );
						break;

					case RECON.RuralDelivery_initial:
						s = s.Replace( RECON.RuralDelivery_initial, _AddressRow.RuralDelivery.AsLowerInitial );
						break;

					case RECON.PostalCode_initial:
						s = s.Replace( RECON.PostalCode_initial, _AddressRow.PostalCode.AsLowerInitial );
						break;

					case RECON.BoxNumber_initial:
						s = s.Replace( RECON.BoxNumber_initial, _AddressRow.BoxNumber.AsLowerInitial );
						break;

					case RECON.HouseNumber_initial:
						s = s.Replace( RECON.HouseNumber_initial, _AddressRow.HouseNumber.AsLowerInitial );
						break;

					case RECON.StreetName_initial:
						s = s.Replace( RECON.StreetName_initial, _AddressRow.StreetName.AsLowerInitial );
						break;

					case RECON.StreetType_initial:
						s = s.Replace( RECON.StreetType_initial, _AddressRow.StreetType.AsLowerInitial );
						break;

					case RECON.Compass_initial:
						s = s.Replace( RECON.Compass_initial, _AddressRow.Compass.AsLowerInitial );
						break;

					case RECON.Suburb_initial:
						s = s.Replace( RECON.Suburb_initial, _AddressRow.Suburb.AsLowerInitial );
						break;

					case RECON.City_initial:
						s = s.Replace( RECON.City_initial, _AddressRow.City.AsLowerInitial );
						break;

					case RECON.Metropolitan_initial:
						s = s.Replace( RECON.Metropolitan_initial, _AddressRow.Metropolitan.AsLowerInitial );
						break;

					case RECON.ProvinceName_initial:
						s = s.Replace( RECON.ProvinceName_initial, _AddressRow.ProvinceName.AsLowerInitial );
						break;

					case RECON.ProvinceCode_initial:
						s = s.Replace( RECON.ProvinceCode_initial, _AddressRow.ProvinceCode.AsLowerInitial );
						break;


					//Country________________________________________________________________________________________________________________________
					case RECON.CountryName_initial:
						s = s.Replace( RECON.CountryName_initial, _AddressRow.CountryName.AsLowerInitial );
						break;

					case RECON.CountryCode_initial:
						s = s.Replace( RECON.CountryCode_initial, _AddressRow.CountryCode.AsLowerInitial );
						break;

					case RECON.ShortIsoCode_initial:
						s = s.Replace( RECON.ShortIsoCode_initial, _AddressRow.ShortIsoCode.AsLowerInitial );
						break;

					case RECON.LongIsoCode_initial:
						s = s.Replace( RECON.LongIsoCode_initial, _AddressRow.LongIsoCode.AsLowerInitial );
						break;
					#endregion


					#region Initial as upper: Return token's left-most character in UPPER case.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_INITIAL:
						s = s.Replace( RECON.Assemblage_INITIAL, _AddressRow.Assemblage.AsUpperInitial );
						break;

					case RECON.Level_INITIAL:
						s = s.Replace( RECON.Level_INITIAL, _AddressRow.Level.AsUpperInitial );
						break;

					case RECON.Unit_INITIAL:
						s = s.Replace( RECON.Unit_INITIAL, _AddressRow.Unit.AsUpperInitial );
						break;

					case RECON.Extension_INITIAL:
						s = s.Replace( RECON.Extension_INITIAL, _AddressRow.Extension.AsUpperInitial );
						break;

					case RECON.RuralDelivery_INITIAL:
						s = s.Replace( RECON.RuralDelivery_INITIAL, _AddressRow.RuralDelivery.AsUpperInitial );
						break;

					case RECON.PostalCode_INITIAL:
						s = s.Replace( RECON.PostalCode_INITIAL, _AddressRow.PostalCode.AsUpperInitial );
						break;

					case RECON.BoxNumber_INITIAL:
						s = s.Replace( RECON.BoxNumber_INITIAL, _AddressRow.BoxNumber.AsUpperInitial );
						break;

					case RECON.HouseNumber_INITIAL:
						s = s.Replace( RECON.HouseNumber_INITIAL, _AddressRow.HouseNumber.AsUpperInitial );
						break;

					case RECON.StreetName_INITIAL:
						s = s.Replace( RECON.StreetName_INITIAL, _AddressRow.StreetName.AsUpperInitial );
						break;

					case RECON.StreetType_INITIAL:
						s = s.Replace( RECON.StreetType_INITIAL, _AddressRow.StreetType.AsUpperInitial );
						break;

					case RECON.Compass_INITIAL:
						s = s.Replace( RECON.Compass_INITIAL, _AddressRow.Compass.AsUpperInitial );
						break;

					case RECON.Suburb_INITIAL:
						s = s.Replace( RECON.Suburb_INITIAL, _AddressRow.Suburb.AsUpperInitial );
						break;

					case RECON.City_INITIAL:
						s = s.Replace( RECON.City_INITIAL, _AddressRow.City.AsUpperInitial );
						break;

					case RECON.Metropolitan_INITIAL:
						s = s.Replace( RECON.Metropolitan_INITIAL, _AddressRow.Metropolitan.AsUpperInitial );
						break;

					case RECON.ProvinceName_INITIAL:
						s = s.Replace( RECON.ProvinceName_INITIAL, _AddressRow.ProvinceName.AsUpperInitial );
						break;

					case RECON.ProvinceCode_INITIAL:
						s = s.Replace( RECON.ProvinceCode_INITIAL, _AddressRow.ProvinceCode.AsUpperInitial );
						break;


					//Country________________________________________________________________________________________________________________________
					case RECON.CountryName_INITIAL:
						s = s.Replace( RECON.CountryName_INITIAL, _AddressRow.CountryName.AsUpperInitial );
						break;

					case RECON.CountryCode_INITIAL:
						s = s.Replace( RECON.CountryCode_INITIAL, _AddressRow.CountryCode.AsUpperInitial );
						break;

					case RECON.ShortIsoCode_INITIAL:
						s = s.Replace( RECON.ShortIsoCode_INITIAL, _AddressRow.ShortIsoCode.AsUpperInitial );
						break;

					case RECON.LongIsoCode_INITIAL:
						s = s.Replace( RECON.LongIsoCode_INITIAL, _AddressRow.LongIsoCode.AsUpperInitial );
						break;
					#endregion


					default:
						break;
				}
			}
			return s;
		}
	}
}
