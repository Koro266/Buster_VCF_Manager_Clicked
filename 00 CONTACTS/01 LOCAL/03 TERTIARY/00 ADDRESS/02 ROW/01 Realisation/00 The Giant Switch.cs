//___________________________________________________________________________________________________________________________________________________
using System.Text.RegularExpressions;
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using PARENT_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using RECON			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reconstruction;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//___________________________________________________________________________________________________________________________________________
		public class TheGiantSwitch
		{
			private PARENT_ROW _ParentRow;

			//___________________________________________________________________________________________________________________________________________
			public TheGiantSwitch( PARENT_ROW parent_row )
			{
				_ParentRow = parent_row;
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
							s = Regex.Replace( s, RECON.PkAddress, _ParentRow.PkAddress.AsString );
							break;

						case RECON.FkCountry:
							s = Regex.Replace( s, RECON.FkCountry, _ParentRow.FkCountry.AsString );
							break;

						case RECON.Assemblage_AsIs:
							s = Regex.Replace( s, RECON.Assemblage_AsIs, _ParentRow.Assemblage.AsIs );
							break;

						case RECON.Level_AsIs:
							s = Regex.Replace( s, RECON.Level_AsIs, _ParentRow.Level.AsIs );
							break;

						case RECON.Unit_AsIs:
							s = Regex.Replace( s, RECON.Unit_AsIs, _ParentRow.Unit.AsIs );
							break;

						case RECON.Extension_AsIs:
							s = Regex.Replace( s, RECON.Extension_AsIs, _ParentRow.Extension.AsIs );
							break;

						case RECON.RuralDelivery_AsIs:
							s = Regex.Replace( s, RECON.RuralDelivery_AsIs, _ParentRow.RuralDelivery.AsIs );
							break;

						case RECON.PostalCode_AsIs:
							s = Regex.Replace( s, RECON.PostalCode_AsIs, _ParentRow.PostalCode.AsIs );
							break;

						case RECON.BoxNumber_AsIs:
							s = Regex.Replace( s, RECON.BoxNumber_AsIs, _ParentRow.BoxNumber.AsIs );
							break;

						case RECON.HouseNumber_AsIs:
							s = Regex.Replace( s, RECON.HouseNumber_AsIs, _ParentRow.HouseNumber.AsIs );
							break;

						case RECON.StreetName_AsIs:
							s = Regex.Replace( s, RECON.StreetName_AsIs, _ParentRow.StreetName.AsIs );
							break;

						case RECON.StreetType_AsIs:
							s = Regex.Replace( s, RECON.StreetType_AsIs, _ParentRow.StreetType.AsIs );
							break;

						case RECON.Compass_AsIs:
							s = Regex.Replace( s, RECON.Compass_AsIs, _ParentRow.Compass.AsIs );
							break;

						case RECON.Suburb_AsIs:
							s = Regex.Replace( s, RECON.Suburb_AsIs, _ParentRow.Suburb.AsIs );
							break;

						case RECON.City_AsIs:
							s = Regex.Replace( s, RECON.City_AsIs, _ParentRow.City.AsIs );
							break;

						case RECON.Metropolitan_AsIs:
							s = Regex.Replace( s, RECON.Metropolitan_AsIs, _ParentRow.Metropolitan.AsIs );
							break;

						case RECON.ProvinceName_AsIs:
							s = Regex.Replace( s, RECON.ProvinceName_AsIs, _ParentRow.ProvinceName.AsIs );
							break;

						case RECON.ProvinceCode_AsIs:
							s = Regex.Replace( s, RECON.ProvinceCode_AsIs, _ParentRow.ProvinceCode.AsIs );
							break;

						case RECON.CountryName_AsIs:
							s = Regex.Replace( s, RECON.CountryName_AsIs, _ParentRow.CountryName.AsIs );
							break;

						case RECON.CountryCode_AsIs:
							s = Regex.Replace( s, RECON.CountryCode_AsIs, _ParentRow.CountryCode.AsIs );
							break;

						case RECON.ShortIsoCode_AsIs:
							s = Regex.Replace( s, RECON.ShortIsoCode_AsIs, _ParentRow.ShortIsoCode.AsIs );
							break;

						case RECON.LongIsoCode_AsIs:
							s = Regex.Replace( s, RECON.LongIsoCode_AsIs, _ParentRow.LongIsoCode.AsIs );
							break;

						case RECON.Notes:
							s = Regex.Replace( s, RECON.Notes, _ParentRow.Notes.AsIs );
							break;
						#endregion


						#region UPPER: Return entire token in UPPER case.
						//___________________________________________________________________________________________________________________________
						case RECON.Assemblage_UPPER:
							s = s.Replace( RECON.Assemblage_UPPER, _ParentRow.Assemblage.AsUpper );
							break;

						case RECON.Level_UPPER:
							s = s.Replace( RECON.Level_UPPER, _ParentRow.Level.AsUpper );
							break;

						case RECON.Unit_UPPER:
							s = s.Replace( RECON.Unit_UPPER, _ParentRow.Unit.AsUpper );
							break;

						case RECON.Extension_UPPER:
							s = s.Replace( RECON.Extension_UPPER, _ParentRow.Extension.AsUpper );
							break;

						case RECON.RuralDelivery_UPPER:
							s = s.Replace( RECON.RuralDelivery_UPPER, _ParentRow.RuralDelivery.AsUpper );
							break;

						case RECON.PostalCode_UPPER:
							s = s.Replace( RECON.PostalCode_UPPER, _ParentRow.PostalCode.AsUpper );
							break;

						case RECON.BoxNumber_UPPER:
							s = s.Replace( RECON.BoxNumber_UPPER, _ParentRow.BoxNumber.AsUpper );
							break;

						case RECON.HouseNumber_UPPER:
							s = s.Replace( RECON.HouseNumber_UPPER, _ParentRow.HouseNumber.AsUpper );
							break;

						case RECON.StreetName_UPPER:
							s = s.Replace( RECON.StreetName_UPPER, _ParentRow.StreetName.AsUpper );
							break;

						case RECON.StreetType_UPPER:
							s = s.Replace( RECON.StreetType_UPPER, _ParentRow.StreetType.AsUpper );
							break;

						case RECON.Compass_UPPER:
							s = s.Replace( RECON.Compass_UPPER, _ParentRow.Compass.AsUpper );
							break;

						case RECON.Suburb_UPPER:
							s = s.Replace( RECON.Suburb_UPPER, _ParentRow.Suburb.AsUpper );
							break;

						case RECON.City_UPPER:
							s = s.Replace( RECON.City_UPPER, _ParentRow.City.AsUpper );
							break;

						case RECON.Metropolitan_UPPER:
							s = s.Replace( RECON.Metropolitan_UPPER, _ParentRow.Metropolitan.AsUpper );
							break;

						case RECON.ProvinceName_UPPER:
							s = s.Replace( RECON.ProvinceName_UPPER, _ParentRow.ProvinceName.AsUpper );
							break;

						case RECON.ProvinceCode_UPPER:
							s = s.Replace( RECON.ProvinceCode_UPPER, _ParentRow.ProvinceCode.AsUpper );
							break;


						//Country________________________________________________________________________________________________________________________
						case RECON.CountryName_UPPER:
							s = s.Replace( RECON.CountryName_UPPER, _ParentRow.CountryName.AsUpper );
							break;

						case RECON.CountryCode_UPPER:
							s = s.Replace( RECON.CountryCode_UPPER, _ParentRow.CountryCode.AsUpper );
							break;

						case RECON.ShortIsoCode_UPPER:
							s = s.Replace( RECON.ShortIsoCode_UPPER, _ParentRow.ShortIsoCode.AsUpper );
							break;

						case RECON.LongIsoCode_UPPER:
							s = s.Replace( RECON.LongIsoCode_UPPER, _ParentRow.LongIsoCode.AsUpper );
							break;
						#endregion


						#region Proper: Return entire token in Proper case.
						//___________________________________________________________________________________________________________________________
						case RECON.Assemblage_Proper:
							s = s.Replace( RECON.Assemblage_Proper, _ParentRow.Assemblage.AsProper );
							break;

						case RECON.Level_Proper:
							s = s.Replace( RECON.Level_Proper, _ParentRow.Level.AsProper );
							break;

						case RECON.Unit_Proper:
							s = s.Replace( RECON.Unit_Proper, _ParentRow.Unit.AsProper );
							break;

						case RECON.Extension_Proper:
							s = s.Replace( RECON.Extension_Proper, _ParentRow.Extension.AsProper );
							break;

						case RECON.RuralDelivery_Proper:
							s = s.Replace( RECON.RuralDelivery_Proper, _ParentRow.RuralDelivery.AsProper );
							break;

						case RECON.PostalCode_Proper:
							s = s.Replace( RECON.PostalCode_Proper, _ParentRow.PostalCode.AsProper );
							break;

						case RECON.BoxNumber_Proper:
							s = s.Replace( RECON.BoxNumber_Proper, _ParentRow.BoxNumber.AsProper );
							break;

						case RECON.HouseNumber_Proper:
							s = s.Replace( RECON.HouseNumber_Proper, _ParentRow.HouseNumber.AsProper );
							break;

						case RECON.StreetName_Proper:
							s = s.Replace( RECON.StreetName_Proper, _ParentRow.StreetName.AsProper );
							break;

						case RECON.StreetType_Proper:
							s = s.Replace( RECON.StreetType_Proper, _ParentRow.StreetType.AsProper );
							break;

						case RECON.Compass_Proper:
							s = s.Replace( RECON.Compass_Proper, _ParentRow.Compass.AsIs );
							break;

						case RECON.Suburb_Proper:
							s = s.Replace( RECON.Suburb_Proper, _ParentRow.Suburb.AsProper );
							break;

						case RECON.City_Proper:
							s = s.Replace( RECON.City_Proper, _ParentRow.City.AsProper );
							break;

						case RECON.Metropolitan_Proper:
							s = s.Replace( RECON.Metropolitan_Proper, _ParentRow.Metropolitan.AsProper );
							break;

						case RECON.ProvinceName_Proper:
							s = s.Replace( RECON.ProvinceName_Proper, _ParentRow.ProvinceName.AsProper );
							break;

						case RECON.ProvinceCode_Proper:
							s = s.Replace( RECON.ProvinceCode_Proper, _ParentRow.ProvinceCode.AsProper );
							break;


						//Country________________________________________________________________________________________________________________________
						case RECON.CountryName_Proper:
							s = s.Replace( RECON.CountryName_Proper, _ParentRow.CountryName.AsProper );
							break;

						case RECON.CountryCode_Proper:
							s = s.Replace( RECON.CountryCode_Proper, _ParentRow.CountryCode.AsIs );
							break;

						case RECON.ShortIsoCode_Proper:
							s = s.Replace( RECON.ShortIsoCode_Proper, _ParentRow.ShortIsoCode.AsIs );
							break;

						case RECON.LongIsoCode_Proper:
							s = s.Replace( RECON.LongIsoCode_Proper, _ParentRow.LongIsoCode.AsIs );
							break;
						#endregion


						#region lower: Return entire token in lower case.
						//___________________________________________________________________________________________________________________________
						case RECON.Assemblage_lower:
							s = s.Replace( RECON.Assemblage_lower, _ParentRow.Assemblage.AsLower );
							break;

						case RECON.Level_lower:
							s = s.Replace( RECON.Level_lower, _ParentRow.Level.AsLower );
							break;

						case RECON.Unit_lower:
							s = s.Replace( RECON.Unit_lower, _ParentRow.Unit.AsLower );
							break;

						case RECON.Extension_lower:
							s = s.Replace( RECON.Extension_lower, _ParentRow.Extension.AsLower );
							break;

						case RECON.RuralDelivery_lower:
							s = s.Replace( RECON.RuralDelivery_lower, _ParentRow.RuralDelivery.AsLower );
							break;

						case RECON.PostalCode_lower:
							s = s.Replace( RECON.PostalCode_lower, _ParentRow.PostalCode.AsLower );
							break;

						case RECON.BoxNumber_lower:
							s = s.Replace( RECON.BoxNumber_lower, _ParentRow.BoxNumber.AsLower );
							break;

						case RECON.HouseNumber_lower:
							s = s.Replace( RECON.HouseNumber_lower, _ParentRow.HouseNumber.AsLower );
							break;

						case RECON.StreetName_lower:
							s = s.Replace( RECON.StreetName_lower, _ParentRow.StreetName.AsLower );
							break;

						case RECON.StreetType_lower:
							s = s.Replace( RECON.StreetType_lower, _ParentRow.StreetType.AsLower );
							break;

						case RECON.Compass_lower:
							s = s.Replace( RECON.Compass_lower, _ParentRow.Compass.AsLower );
							break;

						case RECON.Suburb_lower:
							s = s.Replace( RECON.Suburb_lower, _ParentRow.Suburb.AsLower );
							break;

						case RECON.City_lower:
							s = s.Replace( RECON.City_lower, _ParentRow.City.AsLower );
							break;

						case RECON.Metropolitan_lower:
							s = s.Replace( RECON.Metropolitan_lower, _ParentRow.Metropolitan.AsLower );
							break;

						case RECON.ProvinceName_lower:
							s = s.Replace( RECON.ProvinceName_lower, _ParentRow.ProvinceName.AsLower );
							break;

						case RECON.ProvinceCode_lower:
							s = s.Replace( RECON.ProvinceCode_lower, _ParentRow.ProvinceCode.AsLower );
							break;


						//Country________________________________________________________________________________________________________________________
						case RECON.CountryName_lower:
							s = s.Replace( RECON.CountryName_lower, _ParentRow.CountryName.AsLower );
							break;

						case RECON.CountryCode_lower:
							s = s.Replace( RECON.CountryCode_lower, _ParentRow.CountryCode.AsIs );
							break;

						case RECON.ShortIsoCode_lower:
							s = s.Replace( RECON.ShortIsoCode_lower, _ParentRow.ShortIsoCode.AsIs );
							break;

						case RECON.LongIsoCode_lower:
							s = s.Replace( RECON.LongIsoCode_lower, _ParentRow.LongIsoCode.AsIs );
							break;
						#endregion


						#region Initial as lower: Return token's left-most character in lower case.
						//___________________________________________________________________________________________________________________________
						case RECON.Assemblage_initial:
							s = s.Replace( RECON.Assemblage_initial, _ParentRow.Assemblage.AsLowerInitial );
							break;

						case RECON.Level_initial:
							s = s.Replace( RECON.Level_initial, _ParentRow.Level.AsLowerInitial );
							break;

						case RECON.Unit_initial:
							s = s.Replace( RECON.Unit_initial, _ParentRow.Unit.AsLowerInitial );
							break;

						case RECON.Extension_initial:
							s = s.Replace( RECON.Extension_initial, _ParentRow.Extension.AsLowerInitial );
							break;

						case RECON.RuralDelivery_initial:
							s = s.Replace( RECON.RuralDelivery_initial, _ParentRow.RuralDelivery.AsLowerInitial );
							break;

						case RECON.PostalCode_initial:
							s = s.Replace( RECON.PostalCode_initial, _ParentRow.PostalCode.AsLowerInitial );
							break;

						case RECON.BoxNumber_initial:
							s = s.Replace( RECON.BoxNumber_initial, _ParentRow.BoxNumber.AsLowerInitial );
							break;

						case RECON.HouseNumber_initial:
							s = s.Replace( RECON.HouseNumber_initial, _ParentRow.HouseNumber.AsLowerInitial );
							break;

						case RECON.StreetName_initial:
							s = s.Replace( RECON.StreetName_initial, _ParentRow.StreetName.AsLowerInitial );
							break;

						case RECON.StreetType_initial:
							s = s.Replace( RECON.StreetType_initial, _ParentRow.StreetType.AsLowerInitial );
							break;

						case RECON.Compass_initial:
							s = s.Replace( RECON.Compass_initial, _ParentRow.Compass.AsLowerInitial );
							break;

						case RECON.Suburb_initial:
							s = s.Replace( RECON.Suburb_initial, _ParentRow.Suburb.AsLowerInitial );
							break;

						case RECON.City_initial:
							s = s.Replace( RECON.City_initial, _ParentRow.City.AsLowerInitial );
							break;

						case RECON.Metropolitan_initial:
							s = s.Replace( RECON.Metropolitan_initial, _ParentRow.Metropolitan.AsLowerInitial );
							break;

						case RECON.ProvinceName_initial:
							s = s.Replace( RECON.ProvinceName_initial, _ParentRow.ProvinceName.AsLowerInitial );
							break;

						case RECON.ProvinceCode_initial:
							s = s.Replace( RECON.ProvinceCode_initial, _ParentRow.ProvinceCode.AsLowerInitial );
							break;


						//Country________________________________________________________________________________________________________________________
						case RECON.CountryName_initial:
							s = s.Replace( RECON.CountryName_initial, _ParentRow.CountryName.AsLowerInitial );
							break;

						case RECON.CountryCode_initial:
							s = s.Replace( RECON.CountryCode_initial, _ParentRow.CountryCode.AsLowerInitial );
							break;

						case RECON.ShortIsoCode_initial:
							s = s.Replace( RECON.ShortIsoCode_initial, _ParentRow.ShortIsoCode.AsLowerInitial );
							break;

						case RECON.LongIsoCode_initial:
							s = s.Replace( RECON.LongIsoCode_initial, _ParentRow.LongIsoCode.AsLowerInitial );
							break;
						#endregion


						#region Initial as upper: Return token's left-most character in UPPER case.
						//___________________________________________________________________________________________________________________________
						case RECON.Assemblage_INITIAL:
							s = s.Replace( RECON.Assemblage_INITIAL, _ParentRow.Assemblage.AsUpperInitial );
							break;

						case RECON.Level_INITIAL:
							s = s.Replace( RECON.Level_INITIAL, _ParentRow.Level.AsUpperInitial );
							break;

						case RECON.Unit_INITIAL:
							s = s.Replace( RECON.Unit_INITIAL, _ParentRow.Unit.AsUpperInitial );
							break;

						case RECON.Extension_INITIAL:
							s = s.Replace( RECON.Extension_INITIAL, _ParentRow.Extension.AsUpperInitial );
							break;

						case RECON.RuralDelivery_INITIAL:
							s = s.Replace( RECON.RuralDelivery_INITIAL, _ParentRow.RuralDelivery.AsUpperInitial );
							break;

						case RECON.PostalCode_INITIAL:
							s = s.Replace( RECON.PostalCode_INITIAL, _ParentRow.PostalCode.AsUpperInitial );
							break;

						case RECON.BoxNumber_INITIAL:
							s = s.Replace( RECON.BoxNumber_INITIAL, _ParentRow.BoxNumber.AsUpperInitial );
							break;

						case RECON.HouseNumber_INITIAL:
							s = s.Replace( RECON.HouseNumber_INITIAL, _ParentRow.HouseNumber.AsUpperInitial );
							break;

						case RECON.StreetName_INITIAL:
							s = s.Replace( RECON.StreetName_INITIAL, _ParentRow.StreetName.AsUpperInitial );
							break;

						case RECON.StreetType_INITIAL:
							s = s.Replace( RECON.StreetType_INITIAL, _ParentRow.StreetType.AsUpperInitial );
							break;

						case RECON.Compass_INITIAL:
							s = s.Replace( RECON.Compass_INITIAL, _ParentRow.Compass.AsUpperInitial );
							break;

						case RECON.Suburb_INITIAL:
							s = s.Replace( RECON.Suburb_INITIAL, _ParentRow.Suburb.AsUpperInitial );
							break;

						case RECON.City_INITIAL:
							s = s.Replace( RECON.City_INITIAL, _ParentRow.City.AsUpperInitial );
							break;

						case RECON.Metropolitan_INITIAL:
							s = s.Replace( RECON.Metropolitan_INITIAL, _ParentRow.Metropolitan.AsUpperInitial );
							break;

						case RECON.ProvinceName_INITIAL:
							s = s.Replace( RECON.ProvinceName_INITIAL, _ParentRow.ProvinceName.AsUpperInitial );
							break;

						case RECON.ProvinceCode_INITIAL:
							s = s.Replace( RECON.ProvinceCode_INITIAL, _ParentRow.ProvinceCode.AsUpperInitial );
							break;


						//Country________________________________________________________________________________________________________________________
						case RECON.CountryName_INITIAL:
							s = s.Replace( RECON.CountryName_INITIAL, _ParentRow.CountryName.AsUpperInitial );
							break;

						case RECON.CountryCode_INITIAL:
							s = s.Replace( RECON.CountryCode_INITIAL, _ParentRow.CountryCode.AsUpperInitial );
							break;

						case RECON.ShortIsoCode_INITIAL:
							s = s.Replace( RECON.ShortIsoCode_INITIAL, _ParentRow.ShortIsoCode.AsUpperInitial );
							break;

						case RECON.LongIsoCode_INITIAL:
							s = s.Replace( RECON.LongIsoCode_INITIAL, _ParentRow.LongIsoCode.AsUpperInitial );
							break;
						#endregion


						#region Wrap it up...
						//Do nothing... .
						default:
							break;
						#endregion
					}
				}
				return s;
			}
		}
	}
}
