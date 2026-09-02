//___________________________________________________________________________________________________________________________________________________
using SBLDR = System.Text.StringBuilder;
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public partial class TheSevenSlots : BASE_ROW
	{
		private ADDRESS_ROW _AddressRow;

		private const string local_Pattern = "#0 #1 #2 #3"; //House number, street name, street type, compass.
		private const string burbcity_Pattern = "#0, #1";           //Suburb, City.
		private const string metro_Pattern = "#0 #1 #2";        //Metropolitan, Province, Province abbreviation.
		private const string post_Pattern = "#0 #1 #2";     //PO Box, RD, Post code.
		private const string extend_Pattern = "#0 #1 #2 #3";    //Assemblage, level, Unit, Extension.
		private const string country_Pattern = "#0";             //Country name.

		//___________________________________________________________________________________________________________________________________________
		public TheSevenSlots( ADDRESS_ROW parent_row )
		{
			_AddressRow = parent_row;
		}
		//_______________________________________________________________________________________________________________________________________
		public string[] SlotsAsArray
		{
			get
			{
				string[] addr_items = new string[7];

				addr_items[0] = Pk;
				addr_items[1] = LocalAddress;
				addr_items[2] = BurbCity;
				addr_items[3] = MetroProvince;
				addr_items[4] = Postal;
				addr_items[5] = Extensions;
				addr_items[6] = Nation;

				return addr_items;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string Pk
		{
			get
			{
				return _AddressRow.PkAddress.AsString;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string LocalAddress
		{
			get
			{
				SBLDR s = new SBLDR( local_Pattern );

				s.Replace( PRESET.S0, _AddressRow.HouseNumber.AsIs );
				s.Replace( PRESET.S1, _AddressRow.StreetName.AsIs );
				s.Replace( PRESET.S2, _AddressRow.StreetType.AsIs );
				s.Replace( PRESET.S3, _AddressRow.Compass.AsIs );

				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string BurbCity
		{
			get
			{
				SBLDR s = new SBLDR( burbcity_Pattern );

				s.Replace( PRESET.S0, _AddressRow.Suburb.AsIs );
				s.Replace( PRESET.S1, _AddressRow.City.AsIs );

				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string MetroProvince
		{
			get
			{
				SBLDR s = new SBLDR( metro_Pattern );

				s.Replace( PRESET.S0, _AddressRow.Metropolitan.AsIs );
				s.Replace( PRESET.S1, _AddressRow.ProvinceName.AsIs );
				s.Replace( PRESET.S2, _AddressRow.ProvinceCode.AsIs );

				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string Postal
		{
			get
			{
				SBLDR s = new SBLDR( post_Pattern );

				s.Replace( PRESET.S0, _AddressRow.BoxNumber.AsIs );
				s.Replace( PRESET.S1, _AddressRow.RuralDelivery.AsIs );
				s.Replace( PRESET.S2, _AddressRow.PostalCode.AsIs );

				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string Extensions
		{
			get
			{
				SBLDR s = new SBLDR( extend_Pattern );

				s.Replace( PRESET.S0, _AddressRow.Assemblage.AsIs );
				s.Replace( PRESET.S1, _AddressRow.Level.AsIs );
				s.Replace( PRESET.S2, _AddressRow.Unit.AsIs );
				s.Replace( PRESET.S3, _AddressRow.Extension.AsIs );

				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string Nation
		{
			get
			{
				SBLDR s = new SBLDR( country_Pattern );

				s.Replace( PRESET.S0, _AddressRow.CountryName.AsIs );

				return s.ToString();
			}
		}
	}
}
