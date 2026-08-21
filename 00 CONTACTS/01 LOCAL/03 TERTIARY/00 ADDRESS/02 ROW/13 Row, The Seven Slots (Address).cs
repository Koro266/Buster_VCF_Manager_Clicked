//___________________________________________________________________________________________________________________________________________________
using SBLDR = System.Text.StringBuilder;
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL 

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		private const string local_Pattern		= "#0 #1 #2 #3";	//House number, street name, street type, compass.
		private const string burbcity_Pattern	= "#0, #1";			//Suburb, City.
		private const string metro_Pattern		= "#0 #1 #2";		//Metropolitan, Province, Province abbreviation.
		private const string post_Pattern		= "#0 #1 #2";		//PO Box, RD, Post code.
		private const string extend_Pattern		= "#0 #1 #2 #3";	//Assemblage, level, Unit, Extension.
		private const string country_Pattern	= "#0";				//Country name.

		//_______________________________________________________________________________________________________________________________________
		public string[] TheSevenSlots
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
				return PkAddress.Value.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string LocalAddress
		{
			get
			{
				SBLDR s = new SBLDR( local_Pattern );

				s.Replace( PRESET.S0, HouseNumber.AsIs );
				s.Replace( PRESET.S1, StreetName.AsIs );
				s.Replace( PRESET.S2, StreetType.AsIs );
				s.Replace( PRESET.S3, Compass.AsIs );

				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string BurbCity
		{
			get
			{
				SBLDR s = new SBLDR( burbcity_Pattern );

				s.Replace( PRESET.S0, Suburb.AsIs );
				s.Replace( PRESET.S1, City.AsIs );

				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string MetroProvince
		{
			get
			{
				SBLDR s = new SBLDR( metro_Pattern );

				s.Replace( PRESET.S0, Metropolitan.AsIs );
				s.Replace( PRESET.S1, ProvinceName.AsIs );
				s.Replace( PRESET.S2, ProvinceCode.AsIs );

				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string Postal
		{
			get
			{
				SBLDR s = new SBLDR( post_Pattern );

				s.Replace( PRESET.S0, BoxNumber.AsIs );
				s.Replace( PRESET.S1, RuralDelivery.AsIs );
				s.Replace( PRESET.S2, PostalCode.AsIs );

				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string Extensions
		{
			get
			{
				SBLDR s = new SBLDR( extend_Pattern );

				s.Replace( PRESET.S0, Assemblage.AsIs );
				s.Replace( PRESET.S1, Level.AsIs );
				s.Replace( PRESET.S2, Unit.AsIs );
				s.Replace( PRESET.S3, Extension.AsIs );

				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private string Nation
		{
			get
			{
				SBLDR s = new SBLDR( country_Pattern );

				s.Replace( PRESET.S0, this.address_Nation.CountryName.AsIs );

				return s.ToString();
			}
		}
	}
}
