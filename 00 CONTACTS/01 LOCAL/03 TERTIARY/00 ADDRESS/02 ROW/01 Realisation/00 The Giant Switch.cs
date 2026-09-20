//___________________________________________________________________________________________________________________________________________________
using System.Text.RegularExpressions;
//GLOBAL
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
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
		//___________________________________________________________________________________________________________________________________________
		virtual public string PkAddress		{ get { return RECON.PkAddress; } }
		virtual public string HouseNumber	{ get { return RECON.HouseNumber_AsIs; } }
		virtual public string StreetName	{ get { return RECON.StreetName_AsIs; } }
		virtual public string StreetType	{ get { return RECON.StreetType_AsIs; } }
		virtual public string Compass		{ get { return RECON.Compass_AsIs; } }
		virtual public string Suburb		{ get { return RECON.Suburb_AsIs; } }
		virtual public string City			{ get { return RECON.City_AsIs; } }
		virtual public string Metropolitan	{ get { return RECON.Metropolitan_AsIs; } }
		virtual public string Province		{ get { return RECON.ProvinceName_AsIs; } }
		virtual public string ProvCode		{ get { return RECON.ProvinceCode_AsIs; } }
		virtual public string BoxNumber		{ get { return RECON.BoxNumber_AsIs; } }
		virtual public string RuralDelivery	{ get { return RECON.RuralDelivery_AsIs; } }
		virtual public string PostalCode	{ get { return RECON.PostalCode_AsIs; } }
		virtual public string Assemblage	{ get { return RECON.Assemblage_AsIs; } }
		virtual public string Extensions	{ get { return RECON.Extension_AsIs; } }
		virtual public string Level			{ get { return RECON.Level_AsIs; } }
		virtual public string Unit			{ get { return RECON.Unit_AsIs; } }
		virtual public string PkCountry		{ get { return RECON.FkCountry; } }
		virtual public string Country		{ get { return RECON.CountryName_AsIs; } }
		virtual public string TeleCode		{ get { return RECON.CountryCode_AsIs; } }
		virtual public string IsoShort		{ get { return RECON.ShortIsoCode_AsIs; } }
		virtual public string IsoLong		{ get { return RECON.LongIsoCode_AsIs; } }
		virtual public string Notes			{ get { return RECON.Notes; } }
		//_______________________________________________________________________________________________________________________________________
		public string RealiseAddressRule( string address_rule )
		{
			string s = address_rule;

			foreach ( string code in RECON.Codes )
			{
				switch ( code )
				{
					#region FIXED FORMAT VALUES 
					case RECON.PkAddress:
						s = Regex.Replace( s, RECON.PkAddress, _AddressRow.PkAddress.AsString );
						break;

					case RECON.FkCountry:
						s = Regex.Replace( s, RECON.FkCountry, _AddressRow.FkCountry.AsString );
						break;

					case RECON.Notes:
						s = Regex.Replace( s, RECON.Notes, _AddressRow.Notes.AsIs );
						break;
					#endregion


					#region AsIs: Return entire token in the form in which it is stored.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_AsIs:
						if( _AddressRow.Assemblage.IsNotNull )
							s = Regex.Replace( s, RECON.Assemblage_AsIs, _AddressRow.Assemblage.AsIs );
						break;

					case RECON.Level_AsIs:
						if ( _AddressRow.Level.IsNotNull )
							s = Regex.Replace( s, RECON.Level_AsIs, _AddressRow.Level.AsIs );
						break;

					case RECON.Unit_AsIs:
						if ( _AddressRow.Unit.IsNotNull )
							s = Regex.Replace( s, RECON.Unit_AsIs, _AddressRow.Unit.AsIs );
						break;

					case RECON.Extension_AsIs:
						if ( _AddressRow.Extension.IsNotNull )
							s = Regex.Replace( s, RECON.Extension_AsIs, _AddressRow.Extension.AsIs );
						break;

					case RECON.RuralDelivery_AsIs:
						if ( _AddressRow.RuralDelivery.IsNotNull )
							s = Regex.Replace( s, RECON.RuralDelivery_AsIs, _AddressRow.RuralDelivery.AsIs );
						break;

					case RECON.PostalCode_AsIs:
						if ( _AddressRow.PostalCode.IsNotNull )
							s = Regex.Replace( s, RECON.PostalCode_AsIs, _AddressRow.PostalCode.AsIs );
						break;

					case RECON.BoxNumber_AsIs:
						if ( _AddressRow.BoxNumber.IsNotNull )
							s = Regex.Replace( s, RECON.BoxNumber_AsIs, _AddressRow.BoxNumber.AsIs );
						break;

					case RECON.HouseNumber_AsIs:
						if ( _AddressRow.HouseNumber.IsNotNull )
							s = Regex.Replace( s, RECON.HouseNumber_AsIs, _AddressRow.HouseNumber.AsIs );
						break;

					case RECON.StreetName_AsIs:
						if ( _AddressRow.StreetName.IsNotNull )
							s = Regex.Replace( s, RECON.StreetName_AsIs, _AddressRow.StreetName.AsIs );
						break;

					case RECON.StreetType_AsIs:
						if ( _AddressRow.StreetType.IsNotNull )
							s = Regex.Replace( s, RECON.StreetType_AsIs, _AddressRow.StreetType.AsIs );
						break;

					case RECON.Compass_AsIs:
						if ( _AddressRow.Compass.IsNotNull )
							s = Regex.Replace( s, RECON.Compass_AsIs, _AddressRow.Compass.AsIs );
						break;

					case RECON.Suburb_AsIs:
						if ( _AddressRow.Suburb.IsNotNull )
							s = Regex.Replace( s, RECON.Suburb_AsIs, _AddressRow.Suburb.AsIs );
						break;

					case RECON.City_AsIs:
						if ( _AddressRow.City.IsNotNull )
							s = Regex.Replace( s, RECON.City_AsIs, _AddressRow.City.AsIs );
						break;

					case RECON.Metropolitan_AsIs:
						if ( _AddressRow.Metropolitan.IsNotNull )
							s = Regex.Replace( s, RECON.Metropolitan_AsIs, _AddressRow.Metropolitan.AsIs );
						break;

					case RECON.ProvinceName_AsIs:
						if ( _AddressRow.ProvinceName.IsNotNull )
							s = Regex.Replace( s, RECON.ProvinceName_AsIs, _AddressRow.ProvinceName.AsIs );
						break;

					case RECON.ProvinceCode_AsIs:
						if ( _AddressRow.ProvinceCode.IsNotNull )
							s = Regex.Replace( s, RECON.ProvinceCode_AsIs, _AddressRow.ProvinceCode.AsIs );
						break;

					case RECON.CountryName_AsIs:
						if ( _AddressRow.CountryName.IsNotNull )
							s = Regex.Replace( s, RECON.CountryName_AsIs, _AddressRow.CountryName.AsIs );
						break;

					case RECON.CountryCode_AsIs:
						if ( _AddressRow.CountryCode.IsNotNull )
							s = Regex.Replace( s, RECON.CountryCode_AsIs, _AddressRow.CountryCode.AsIs );
						break;

					case RECON.ShortIsoCode_AsIs:
						if ( _AddressRow.ShortIsoCode.IsNotNull )
							s = Regex.Replace( s, RECON.ShortIsoCode_AsIs, _AddressRow.ShortIsoCode.AsIs );
						break;

					case RECON.LongIsoCode_AsIs:
						if ( _AddressRow.LongIsoCode.IsNotNull )
							s = Regex.Replace( s, RECON.LongIsoCode_AsIs, _AddressRow.LongIsoCode.AsIs );
						break;
					#endregion


					#region UPPER: Return entire token in UPPER case.
					case RECON.Assemblage_UPPER:
						if ( _AddressRow.Assemblage.IsNotNull )
							s = Regex.Replace( s, RECON.Assemblage_UPPER, _AddressRow.Assemblage.AsUpper );
						break;

					case RECON.Level_UPPER:
						if ( _AddressRow.Level.IsNotNull )
							s = Regex.Replace( s, RECON.Level_UPPER, _AddressRow.Level.AsUpper );
						break;

					case RECON.Unit_UPPER:
						if ( _AddressRow.Unit.IsNotNull )
							s = Regex.Replace( s, RECON.Unit_UPPER, _AddressRow.Unit.AsUpper );
						break;

					case RECON.Extension_UPPER:
						if ( _AddressRow.Extension.IsNotNull )
							s = Regex.Replace( s, RECON.Extension_UPPER, _AddressRow.Extension.AsUpper );
						break;

					case RECON.RuralDelivery_UPPER:
						if ( _AddressRow.RuralDelivery.IsNotNull )
							s = Regex.Replace( s, RECON.RuralDelivery_UPPER, _AddressRow.RuralDelivery.AsUpper );
						break;

					case RECON.PostalCode_UPPER:
						if ( _AddressRow.PostalCode.IsNotNull )
							s = Regex.Replace( s, RECON.PostalCode_UPPER, _AddressRow.PostalCode.AsUpper );
						break;

					case RECON.BoxNumber_UPPER:
						if ( _AddressRow.BoxNumber.IsNotNull )
							s = Regex.Replace( s, RECON.BoxNumber_UPPER, _AddressRow.BoxNumber.AsUpper );
						break;

					case RECON.HouseNumber_UPPER:
						if ( _AddressRow.HouseNumber.IsNotNull )
							s = Regex.Replace( s, RECON.HouseNumber_UPPER, _AddressRow.HouseNumber.AsUpper );
						break;

					case RECON.StreetName_UPPER:
						if ( _AddressRow.StreetName.IsNotNull )
							s = Regex.Replace( s, RECON.StreetName_UPPER, _AddressRow.StreetName.AsUpper );
						break;

					case RECON.StreetType_UPPER:
						if ( _AddressRow.StreetType.IsNotNull )
							s = Regex.Replace( s, RECON.StreetType_UPPER, _AddressRow.StreetType.AsUpper );
						break;

					case RECON.Compass_UPPER:
						if ( _AddressRow.Compass.IsNotNull )
							s = Regex.Replace( s, RECON.Compass_UPPER, _AddressRow.Compass.AsUpper );
						break;

					case RECON.Suburb_UPPER:
						if ( _AddressRow.Suburb.IsNotNull )
							s = Regex.Replace( s, RECON.Suburb_UPPER, _AddressRow.Suburb.AsUpper );
						break;

					case RECON.City_UPPER:
						if ( _AddressRow.City.IsNotNull )
							s = Regex.Replace( s, RECON.City_UPPER, _AddressRow.City.AsUpper );
						break;

					case RECON.Metropolitan_UPPER:
						if ( _AddressRow.Metropolitan.IsNotNull )
							s = Regex.Replace( s, RECON.Metropolitan_UPPER, _AddressRow.Metropolitan.AsUpper );
						break;

					case RECON.ProvinceName_UPPER:
						if ( _AddressRow.ProvinceName.IsNotNull )
							s = Regex.Replace( s, RECON.ProvinceName_UPPER, _AddressRow.ProvinceName.AsUpper );
						break;

					case RECON.ProvinceCode_UPPER:
						if ( _AddressRow.ProvinceCode.IsNotNull )
							s = Regex.Replace( s, RECON.ProvinceCode_UPPER, _AddressRow.ProvinceCode.AsUpper );
						break;

					case RECON.CountryName_UPPER:
						if ( _AddressRow.CountryName.IsNotNull )
							s = Regex.Replace( s, RECON.CountryName_UPPER, _AddressRow.CountryName.AsUpper );
						break;

					case RECON.CountryCode_UPPER:
						if ( _AddressRow.CountryCode.IsNotNull )
							s = Regex.Replace( s, RECON.CountryCode_UPPER, _AddressRow.CountryCode.AsUpper );
						break;

					case RECON.ShortIsoCode_UPPER:
						if ( _AddressRow.ShortIsoCode.IsNotNull )
							s = Regex.Replace( s, RECON.ShortIsoCode_UPPER, _AddressRow.ShortIsoCode.AsUpper );
						break;

					case RECON.LongIsoCode_UPPER:
						if ( _AddressRow.LongIsoCode.IsNotNull )
							s = Regex.Replace( s, RECON.LongIsoCode_UPPER, _AddressRow.LongIsoCode.AsUpper );
						break;
					#endregion


					#region Proper: Return entire token in Proper case.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_Proper:
						if ( _AddressRow.Assemblage.IsNotNull )
							s = Regex.Replace( s, RECON.Assemblage_Proper, _AddressRow.Assemblage.AsProper );
						break;

					case RECON.Level_Proper:
						if ( _AddressRow.Level.IsNotNull )
							s = Regex.Replace( s, RECON.Level_Proper, _AddressRow.Level.AsProper );
						break;

					case RECON.Unit_Proper:
						if ( _AddressRow.Unit.IsNotNull )
							s = Regex.Replace( s, RECON.Unit_Proper, _AddressRow.Unit.AsProper );
						break;

					case RECON.Extension_Proper:
						if ( _AddressRow.Extension.IsNotNull )
							s = Regex.Replace( s, RECON.Extension_Proper, _AddressRow.Extension.AsProper );
						break;

					case RECON.RuralDelivery_Proper:
						if ( _AddressRow.RuralDelivery.IsNotNull )
							s = Regex.Replace( s, RECON.RuralDelivery_Proper, _AddressRow.RuralDelivery.AsProper );
						break;

					case RECON.PostalCode_Proper:
						if ( _AddressRow.PostalCode.IsNotNull )
							s = Regex.Replace( s, RECON.PostalCode_Proper, _AddressRow.PostalCode.AsProper );
						break;

					case RECON.BoxNumber_Proper:
						if ( _AddressRow.BoxNumber.IsNotNull )
							s = Regex.Replace( s, RECON.BoxNumber_Proper, _AddressRow.BoxNumber.AsProper );
						break;

					case RECON.HouseNumber_Proper:
						if ( _AddressRow.HouseNumber.IsNotNull )
							s = Regex.Replace( s, RECON.HouseNumber_Proper, _AddressRow.HouseNumber.AsProper );
						break;

					case RECON.StreetName_Proper:
						if ( _AddressRow.StreetName.IsNotNull )
							s = Regex.Replace( s, RECON.StreetName_Proper, _AddressRow.StreetName.AsProper );
						break;

					case RECON.StreetType_Proper:
						if ( _AddressRow.StreetType.IsNotNull )
							s = Regex.Replace( s, RECON.StreetType_Proper, _AddressRow.StreetType.AsProper );
						break;

					case RECON.Compass_Proper:
						if ( _AddressRow.Compass.IsNotNull )
							s = Regex.Replace( s, RECON.Compass_Proper, _AddressRow.Compass.AsProper );
						break;

					case RECON.Suburb_Proper:
						if ( _AddressRow.Suburb.IsNotNull )
							s = Regex.Replace( s, RECON.Suburb_Proper, _AddressRow.Suburb.AsProper );
						break;

					case RECON.City_Proper:
						if ( _AddressRow.City.IsNotNull )
							s = Regex.Replace( s, RECON.City_Proper, _AddressRow.City.AsProper );
						break;

					case RECON.Metropolitan_Proper:
						if ( _AddressRow.Metropolitan.IsNotNull )
							s = Regex.Replace( s, RECON.Metropolitan_Proper, _AddressRow.Metropolitan.AsProper );
						break;

					case RECON.ProvinceName_Proper:
						if ( _AddressRow.ProvinceName.IsNotNull )
							s = Regex.Replace( s, RECON.ProvinceName_Proper, _AddressRow.ProvinceName.AsProper );
						break;

					case RECON.ProvinceCode_Proper:
						if ( _AddressRow.ProvinceCode.IsNotNull )
							s = Regex.Replace( s, RECON.ProvinceCode_Proper, _AddressRow.ProvinceCode.AsProper );
						break;

					case RECON.CountryName_Proper:
						if ( _AddressRow.CountryName.IsNotNull )
							s = Regex.Replace( s, RECON.CountryName_Proper, _AddressRow.CountryName.AsProper );
						break;

					case RECON.CountryCode_Proper:
						if ( _AddressRow.CountryCode.IsNotNull )
							s = Regex.Replace( s, RECON.CountryCode_Proper, _AddressRow.CountryCode.AsProper );
						break;

					case RECON.ShortIsoCode_Proper:
						if ( _AddressRow.ShortIsoCode.IsNotNull )
							s = Regex.Replace( s, RECON.ShortIsoCode_Proper, _AddressRow.ShortIsoCode.AsProper );
						break;

					case RECON.LongIsoCode_Proper:
						if ( _AddressRow.LongIsoCode.IsNotNull )
							s = Regex.Replace( s, RECON.LongIsoCode_Proper, _AddressRow.LongIsoCode.AsProper );
						break;
					#endregion


					#region lower: Return entire token in lower case.
					//___________________________________________________________________________________________________________________________
					case RECON.Assemblage_lower:
						if ( _AddressRow.Assemblage.IsNotNull )
							s = Regex.Replace( s, RECON.Assemblage_lower, _AddressRow.Assemblage.AsLower );
						break;

					case RECON.Level_lower:
						if ( _AddressRow.Level.IsNotNull )
							s = Regex.Replace( s, RECON.Level_lower, _AddressRow.Level.AsLower );
						break;

					case RECON.Unit_lower:
						if ( _AddressRow.Unit.IsNotNull )
							s = Regex.Replace( s, RECON.Unit_lower, _AddressRow.Unit.AsLower );
						break;

					case RECON.Extension_lower:
						if ( _AddressRow.Extension.IsNotNull )
							s = Regex.Replace( s, RECON.Extension_lower, _AddressRow.Extension.AsLower );
						break;

					case RECON.RuralDelivery_lower:
						if ( _AddressRow.RuralDelivery.IsNotNull )
							s = Regex.Replace( s, RECON.RuralDelivery_lower, _AddressRow.RuralDelivery.AsLower );
						break;

					case RECON.PostalCode_lower:
						if ( _AddressRow.PostalCode.IsNotNull )
							s = Regex.Replace( s, RECON.PostalCode_lower, _AddressRow.PostalCode.AsLower );
						break;

					case RECON.BoxNumber_lower:
						if ( _AddressRow.BoxNumber.IsNotNull )
							s = Regex.Replace( s, RECON.BoxNumber_lower, _AddressRow.BoxNumber.AsLower );
						break;

					case RECON.HouseNumber_lower:
						if ( _AddressRow.HouseNumber.IsNotNull )
							s = Regex.Replace( s, RECON.HouseNumber_lower, _AddressRow.HouseNumber.AsLower );
						break;

					case RECON.StreetName_lower:
						if ( _AddressRow.StreetName.IsNotNull )
							s = Regex.Replace( s, RECON.StreetName_lower, _AddressRow.StreetName.AsLower );
						break;

					case RECON.StreetType_lower:
						if ( _AddressRow.StreetType.IsNotNull )
							s = Regex.Replace( s, RECON.StreetType_lower, _AddressRow.StreetType.AsLower );
						break;

					case RECON.Compass_lower:
						if ( _AddressRow.Compass.IsNotNull )
							s = Regex.Replace( s, RECON.Compass_lower, _AddressRow.Compass.AsLower );
						break;

					case RECON.Suburb_lower:
						if ( _AddressRow.Suburb.IsNotNull )
							s = Regex.Replace( s, RECON.Suburb_lower, _AddressRow.Suburb.AsLower );
						break;

					case RECON.City_lower:
						if ( _AddressRow.City.IsNotNull )
							s = Regex.Replace( s, RECON.City_lower, _AddressRow.City.AsLower );
						break;

					case RECON.Metropolitan_lower:
						if ( _AddressRow.Metropolitan.IsNotNull )
							s = Regex.Replace( s, RECON.Metropolitan_lower, _AddressRow.Metropolitan.AsLower );
						break;

					case RECON.ProvinceName_lower:
						if ( _AddressRow.ProvinceName.IsNotNull )
							s = Regex.Replace( s, RECON.ProvinceName_lower, _AddressRow.ProvinceName.AsLower );
						break;

					case RECON.ProvinceCode_lower:
						if ( _AddressRow.ProvinceCode.IsNotNull )
							s = Regex.Replace( s, RECON.ProvinceCode_lower, _AddressRow.ProvinceCode.AsLower );
						break;

					case RECON.CountryName_lower:
						if ( _AddressRow.CountryName.IsNotNull )
							s = Regex.Replace( s, RECON.CountryName_lower, _AddressRow.CountryName.AsLower );
						break;

					case RECON.CountryCode_lower:
						if ( _AddressRow.CountryCode.IsNotNull )
							s = Regex.Replace( s, RECON.CountryCode_lower, _AddressRow.CountryCode.AsLower );
						break;

					case RECON.ShortIsoCode_lower:
						if ( _AddressRow.ShortIsoCode.IsNotNull )
							s = Regex.Replace( s, RECON.ShortIsoCode_lower, _AddressRow.ShortIsoCode.AsLower );
						break;

					case RECON.LongIsoCode_lower:
						if ( _AddressRow.LongIsoCode.IsNotNull )
							s = Regex.Replace( s, RECON.LongIsoCode_lower, _AddressRow.LongIsoCode.AsLower );
						break;
					#endregion


					#region Initial as lower: Return token's left-most character in lower case.
					case RECON.Assemblage_initial:
						if ( _AddressRow.Assemblage.IsNotNull )
							s = Regex.Replace( s, RECON.Assemblage_initial, _AddressRow.Assemblage.AsLowerInitial );
						break;

					case RECON.Level_initial:
						if ( _AddressRow.Level.IsNotNull )
							s = Regex.Replace( s, RECON.Level_initial, _AddressRow.Level.AsLowerInitial );
						break;

					case RECON.Unit_initial:
						if ( _AddressRow.Unit.IsNotNull )
							s = Regex.Replace( s, RECON.Unit_initial, _AddressRow.Unit.AsLowerInitial );
						break;

					case RECON.Extension_initial:
						if ( _AddressRow.Extension.IsNotNull )
							s = Regex.Replace( s, RECON.Extension_initial, _AddressRow.Extension.AsLowerInitial );
						break;

					case RECON.RuralDelivery_initial:
						if ( _AddressRow.RuralDelivery.IsNotNull )
							s = Regex.Replace( s, RECON.RuralDelivery_initial, _AddressRow.RuralDelivery.AsLowerInitial );
						break;

					case RECON.PostalCode_initial:
						if ( _AddressRow.PostalCode.IsNotNull )
							s = Regex.Replace( s, RECON.PostalCode_initial, _AddressRow.PostalCode.AsLowerInitial );
						break;

					case RECON.BoxNumber_initial:
						if ( _AddressRow.BoxNumber.IsNotNull )
							s = Regex.Replace( s, RECON.BoxNumber_initial, _AddressRow.BoxNumber.AsLowerInitial );
						break;

					case RECON.HouseNumber_initial:
						if ( _AddressRow.HouseNumber.IsNotNull )
							s = Regex.Replace( s, RECON.HouseNumber_initial, _AddressRow.HouseNumber.AsLowerInitial );
						break;

					case RECON.StreetName_initial:
						if ( _AddressRow.StreetName.IsNotNull )
							s = Regex.Replace( s, RECON.StreetName_initial, _AddressRow.StreetName.AsLowerInitial );
						break;

					case RECON.StreetType_initial:
						if ( _AddressRow.StreetType.IsNotNull )
							s = Regex.Replace( s, RECON.StreetType_initial, _AddressRow.StreetType.AsLowerInitial );
						break;

					case RECON.Compass_initial:
						if ( _AddressRow.Compass.IsNotNull )
							s = Regex.Replace( s, RECON.Compass_initial, _AddressRow.Compass.AsLowerInitial );
						break;

					case RECON.Suburb_initial:
						if ( _AddressRow.Suburb.IsNotNull )
							s = Regex.Replace( s, RECON.Suburb_initial, _AddressRow.Suburb.AsLowerInitial );
						break;

					case RECON.City_initial:
						if ( _AddressRow.City.IsNotNull )
							s = Regex.Replace( s, RECON.City_initial, _AddressRow.City.AsLowerInitial );
						break;

					case RECON.Metropolitan_initial:
						if ( _AddressRow.Metropolitan.IsNotNull )
							s = Regex.Replace( s, RECON.Metropolitan_initial, _AddressRow.Metropolitan.AsLowerInitial );
						break;

					case RECON.ProvinceName_initial:
						if ( _AddressRow.ProvinceName.IsNotNull )
							s = Regex.Replace( s, RECON.ProvinceName_initial, _AddressRow.ProvinceName.AsLowerInitial );
						break;

					case RECON.ProvinceCode_initial:
						if ( _AddressRow.ProvinceCode.IsNotNull )
							s = Regex.Replace( s, RECON.ProvinceCode_initial, _AddressRow.ProvinceCode.AsLowerInitial );
						break;

					case RECON.CountryName_initial:
						if ( _AddressRow.CountryName.IsNotNull )
							s = Regex.Replace( s, RECON.CountryName_initial, _AddressRow.CountryName.AsLowerInitial );
						break;

					case RECON.CountryCode_initial:
						if ( _AddressRow.CountryCode.IsNotNull )
							s = Regex.Replace( s, RECON.CountryCode_initial, _AddressRow.CountryCode.AsLowerInitial );
						break;

					case RECON.ShortIsoCode_initial:
						if ( _AddressRow.ShortIsoCode.IsNotNull )
							s = Regex.Replace( s, RECON.ShortIsoCode_initial, _AddressRow.ShortIsoCode.AsLowerInitial );
						break;

					case RECON.LongIsoCode_initial:
						if ( _AddressRow.LongIsoCode.IsNotNull )
							s = Regex.Replace( s, RECON.LongIsoCode_initial, _AddressRow.LongIsoCode.AsLowerInitial );
						break;
					#endregion


					#region Initial as upper: Return token's left-most character in UPPER case.
					case RECON.Assemblage_INITIAL:
						if ( _AddressRow.Assemblage.IsNotNull )
							s = Regex.Replace( s, RECON.Assemblage_INITIAL, _AddressRow.Assemblage.AsUpperInitial );
						break;

					case RECON.Level_INITIAL:
						if ( _AddressRow.Level.IsNotNull )
							s = Regex.Replace( s, RECON.Level_INITIAL, _AddressRow.Level.AsUpperInitial );
						break;

					case RECON.Unit_INITIAL:
						if ( _AddressRow.Unit.IsNotNull )
							s = Regex.Replace( s, RECON.Unit_INITIAL, _AddressRow.Unit.AsUpperInitial );
						break;

					case RECON.Extension_INITIAL:
						if ( _AddressRow.Extension.IsNotNull )
							s = Regex.Replace( s, RECON.Extension_INITIAL, _AddressRow.Extension.AsUpperInitial );
						break;

					case RECON.RuralDelivery_INITIAL:
						if ( _AddressRow.RuralDelivery.IsNotNull )
							s = Regex.Replace( s, RECON.RuralDelivery_INITIAL, _AddressRow.RuralDelivery.AsUpperInitial );
						break;

					case RECON.PostalCode_INITIAL:
						if ( _AddressRow.PostalCode.IsNotNull )
							s = Regex.Replace( s, RECON.PostalCode_INITIAL, _AddressRow.PostalCode.AsUpperInitial );
						break;

					case RECON.BoxNumber_INITIAL:
						if ( _AddressRow.BoxNumber.IsNotNull )
							s = Regex.Replace( s, RECON.BoxNumber_INITIAL, _AddressRow.BoxNumber.AsUpperInitial );
						break;

					case RECON.HouseNumber_INITIAL:
						if ( _AddressRow.HouseNumber.IsNotNull )
							s = Regex.Replace( s, RECON.HouseNumber_INITIAL, _AddressRow.HouseNumber.AsUpperInitial );
						break;

					case RECON.StreetName_INITIAL:
						if ( _AddressRow.StreetName.IsNotNull )
							s = Regex.Replace( s, RECON.StreetName_INITIAL, _AddressRow.StreetName.AsUpperInitial );
						break;

					case RECON.StreetType_INITIAL:
						if ( _AddressRow.StreetType.IsNotNull )
							s = Regex.Replace( s, RECON.StreetType_INITIAL, _AddressRow.StreetType.AsUpperInitial );
						break;

					case RECON.Compass_INITIAL:
						if ( _AddressRow.Compass.IsNotNull )
							s = Regex.Replace( s, RECON.Compass_INITIAL, _AddressRow.Compass.AsUpperInitial );
						break;

					case RECON.Suburb_INITIAL:
						if ( _AddressRow.Suburb.IsNotNull )
							s = Regex.Replace( s, RECON.Suburb_INITIAL, _AddressRow.Suburb.AsUpperInitial );
						break;

					case RECON.City_INITIAL:
						if ( _AddressRow.City.IsNotNull )
							s = Regex.Replace( s, RECON.City_INITIAL, _AddressRow.City.AsUpperInitial );
						break;

					case RECON.Metropolitan_INITIAL:
						if ( _AddressRow.Metropolitan.IsNotNull )
							s = Regex.Replace( s, RECON.Metropolitan_INITIAL, _AddressRow.Metropolitan.AsUpperInitial );
						break;

					case RECON.ProvinceName_INITIAL:
						if ( _AddressRow.ProvinceName.IsNotNull )
							s = Regex.Replace( s, RECON.ProvinceName_INITIAL, _AddressRow.ProvinceName.AsUpperInitial );
						break;

					case RECON.ProvinceCode_INITIAL:
						if ( _AddressRow.ProvinceCode.IsNotNull )
							s = Regex.Replace( s, RECON.ProvinceCode_INITIAL, _AddressRow.ProvinceCode.AsUpperInitial );
						break;

					case RECON.CountryName_INITIAL:
						if ( _AddressRow.CountryName.IsNotNull )
							s = Regex.Replace( s, RECON.CountryName_INITIAL, _AddressRow.CountryName.AsUpperInitial );
						break;

					case RECON.CountryCode_INITIAL:
						if ( _AddressRow.CountryCode.IsNotNull )
							s = Regex.Replace( s, RECON.CountryCode_INITIAL, _AddressRow.CountryCode.AsUpperInitial );
						break;

					case RECON.ShortIsoCode_INITIAL:
						if ( _AddressRow.ShortIsoCode.IsNotNull )
							s = Regex.Replace( s, RECON.ShortIsoCode_INITIAL, _AddressRow.ShortIsoCode.AsUpperInitial );
						break;

					case RECON.LongIsoCode_INITIAL:
						if ( _AddressRow.LongIsoCode.IsNotNull )
							s = Regex.Replace( s, RECON.LongIsoCode_INITIAL, _AddressRow.LongIsoCode.AsUpperInitial );
						break;
					#endregion


					default:
						break;
				}
			}
			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns an empty string array
		/// </summary>
		virtual public string[] Result
		{
			get { return new string[] { }; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string intended to be assigned to the ListView.Item property.
		/// </summary>
		virtual public string RootItem
		{
			get { return String.Empty; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to the ListView.SubItems property.
		/// </summary>
		virtual public string[] Subitems
		{
			get { return Result[1..]; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to a ListBox.Items property.
		/// </summary>
		virtual public string[] ListBoxItems()
		{
			return Result;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to the TextBox.Lines property.
		/// </summary>
		virtual public string[] TextBoxLines()
		{
			return Result;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to a VCF output file; i.e., a 'vertical' address format.
		/// </summary>
		virtual public string[] VcfAddress()
		{
			return Result;
		}
	}
}
