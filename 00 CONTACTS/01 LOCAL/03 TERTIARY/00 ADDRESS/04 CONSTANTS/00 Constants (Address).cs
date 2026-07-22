//___________________________________________________________________________________________________________________________________________________
using FACTORS = CONTACTS.GLOBAL.TOOLS.ColumnFactors;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 34;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkAddress		=  0;
			public const int FkCountry		=  1;
			public const int Assemblage		=  2;
			public const int Level			=  3;
			public const int Unit			=  4;
			public const int Extension		=  5;
			public const int RuralDelivery	=  6;
			public const int PostalCode		=  7;
			public const int BoxNumber		=  8;
			public const int HouseNumber	=  9;
			public const int StreetName		= 10;
			public const int StreetType		= 11;
			public const int Compass		= 12;
			public const int Suburb			= 13;
			public const int City			= 14;
			public const int Metropolitan	= 15;
			public const int ProvinceName	= 16;
			public const int ProvinceCode	= 17;
			public const int VcfPostal		= 18;
			public const int VcfPhysical	= 19;
			public const int VcfExtended	= 20;
			public const int ExcelPattern	= 21;
			public const int Notes			= 22;

			public const int Selected		= 23;
			public const int DefaultRow		= 24;
			public const int Unattached		= 25;
			public const int X_Person		= 26;
			public const int X_Group		= 27;
			public const int X_Family		= 28;
			public const int Christmas		= 29;

			//Country 'qualifications'.
			public const int CountryName	= 30;
			public const int CountryCode	= 31;
			public const int ShortIsoCode	= 32;
			public const int LongIsoCode	= 33;
		}
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =	
		{
			"pk_Address",
			"fk_Country",
			"st_Assemblage",
			"st_Level",
			"st_Unit",
			"st_Extension",
			"st_RuralDelivery",
			"st_PostalCode",
			"st_BoxNumber",
			"st_HouseNumber",
			"st_StreetName",
			"st_StreetType",
			"st_Compass",
			"st_Suburb",
			"st_City",
			"st_Metropolitan",
			"st_ProvinceName",
			"st_ProvinceCode",
			"st_VcfPostal",
			"st_VcfPhysical",
			"st_VcfExtended",
			"st_ExcelPattern",
			"st_Notes",

			"is_Selected",
			"is_DefaultRow",
			"is_Unattached",
			"is_X_Person",
			"is_X_Group",
			"is_X_Family",
			"is_Christmas",

			"st_CountryName",
			"st_CountryCode",
			"st_ShortIsoCode",
			"st_LongIsoCode"
		};	
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_address",
			"@fk_country",
			"@st_assemblage",
			"@st_level",
			"@st_unit",
			"@st_extension",
			"@st_ruraldelivery",
			"@st_postalcode",
			"@st_boxnumber",
			"@st_housenumber",
			"@st_streetname",
			"@st_streettype",
			"@st_compass",
			"@st_suburb",
			"@st_city",
			"@st_metropolitan",
			"@st_provincename",
			"@st_provincecode",
			"@st_vcfpostal",
			"@st_vcfphysical",
			"@st_vcfextended",
			"@st_excelpattern",
			"@st_notes",

			"@is_selected",
			"@is_defaultrow",
			"@is_unattached",
			"@is_x_person",
			"@is_x_group",
			"@is_x_family",
			"@is_christmas",

			"@st_countryname",
			"@st_countrycode",
			"@st_shortisocode",
			"@st_longisocode"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkAddress
			4,		//FkCountry
			50,		//StAssemblage
			20,		//StLevel
			20,		//StUnit
			30,		//StExtension
			5,		//StRuralDelivery
			20,		//StPostalCode
			30,		//StBoxNumber
			10,		//StHouseNumber
			25,		//StStreetName
			20,		//StStreetType
			20,		//StCompass
			50,		//StSuburb
			50,		//StCity
			50,		//StMetropolitan
			50,		//StProvinceName
			5,		//StProvinceCode
			255,	//StVcfPostal
			255,	//StVcfPhysical
			255,	//StVcfExtended
			255,	//StExcelPattern
			255,	//StNotes

			1,		//IsSelected
			1,		//IsDefaultRow
			1,		//IsUnattached
			1,		//IsX_Person
			1,		//IsX_Group
			1,		//IsX_Family
			1,		//IsChristmas

			100,	//CountryName
			5,		//CountryCode
			2,		//ShortIsoCode
			3		//LongIsoCode
		};
		//___________________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkAddress					= "/pk";
			public const string FkCountry					= "/fk";

			//AsIs: Return entire token in the form in which it is stored.
			public const string Assemblage_AsIs				= "/as";
			public const string Level_AsIs					= "/lv";
			public const string Unit_AsIs					= "/un";
			public const string Extension_AsIs				= "/ex";
			public const string RuralDelivery_AsIs			= "/rd";
			public const string PostalCode_AsIs				= "/pc";
			public const string BoxNumber_AsIs				= "/bx";
			public const string HouseNumber_AsIs			= "/hn";
			public const string StreetName_AsIs				= "/sn";
			public const string StreetType_AsIs				= "/st";
			public const string Compass_AsIs				= "/cp";
			public const string Suburb_AsIs					= "/sb";
			public const string City_AsIs					= "/ct";
			public const string Metropolitan_AsIs			= "/mt";
			public const string ProvinceName_AsIs			= "/pv";
			public const string ProvinceCode_AsIs			= "/pa";
			public const string CountryName_AsIs			= "/cy";
			public const string CountryCode_AsIs			= "/cd";
			public const string ShortIsoCode_AsIs			= "/si";
			public const string LongIsoCode_AsIs			= "/li";

			//UPPER: Return entire token in UPPER case.
			public const string Assemblage_UPPER			= "^as";
			public const string Level_UPPER					= "^lv";
			public const string Unit_UPPER					= "^un";
			public const string Extension_UPPER				= "^ex";
			public const string RuralDelivery_UPPER			= "^rd";
			public const string PostalCode_UPPER			= "^pc";
			public const string BoxNumber_UPPER				= "^bx";
			public const string HouseNumber_UPPER			= "^hn";
			public const string StreetName_UPPER			= "^sn";
			public const string StreetType_UPPER			= "^st";
			public const string Compass_UPPER				= "^cp";
			public const string Suburb_UPPER				= "^sb";
			public const string City_UPPER					= "^ct";
			public const string Metropolitan_UPPER			= "^mt";
			public const string ProvinceName_UPPER			= "^pv";
			public const string ProvinceCode_UPPER			= "^pa";
			public const string CountryName_UPPER			= "^cy";
			public const string CountryCode_UPPER			= "^cd";
			public const string ShortIsoCode_UPPER			= "^si";
			public const string LongIsoCode_UPPER			= "^li";

			//Proper: Return entire token in Proper case.
			public const string Assemblage_Proper			= "|as";
			public const string Level_Proper				= "|lv";
			public const string Unit_Proper					= "|un";
			public const string Extension_Proper			= "|ex";
			public const string RuralDelivery_Proper		= "|rd";
			public const string PostalCode_Proper			= "|pc";
			public const string BoxNumber_Proper			= "|bx";
			public const string HouseNumber_Proper			= "|hn";
			public const string StreetName_Proper			= "|sn";
			public const string StreetType_Proper			= "|st";
			public const string Compass_Proper				= "|cp";
			public const string Suburb_Proper				= "|sb";
			public const string City_Proper					= "|ct";
			public const string Metropolitan_Proper			= "|mt";
			public const string ProvinceName_Proper			= "|pv";
			public const string ProvinceCode_Proper			= "|pa";
			public const string CountryName_Proper			= "|cy";
			public const string CountryCode_Proper			= "|cd";
			public const string ShortIsoCode_Proper			= "|si";
			public const string LongIsoCode_Proper			= "|li";

			//lower: Return entire token in lower case.
			public const string Assemblage_lower			= "~as";
			public const string Level_lower					= "~lv";
			public const string Unit_lower					= "~un";
			public const string Extension_lower				= "~ex";
			public const string RuralDelivery_lower			= "~rd";
			public const string PostalCode_lower			= "~pc";
			public const string BoxNumber_lower				= "~bx";
			public const string HouseNumber_lower			= "~hn";
			public const string StreetName_lower			= "~sn";
			public const string StreetType_lower			= "~st";
			public const string Compass_lower				= "~cp";
			public const string Suburb_lower				= "~sb";
			public const string City_lower					= "~ct";
			public const string Metropolitan_lower			= "~mt";
			public const string ProvinceName_lower			= "~pv";
			public const string ProvinceCode_lower			= "~pa";
			public const string CountryName_lower			= "~cy";
			public const string CountryCode_lower			= "~cd";
			public const string ShortIsoCode_lower			= "~si";
			public const string LongIsoCode_lower			= "~li";

			//Initial as lower: Return token's left-most character in lower case.
			public const string Assemblage_initial			= "<as";
			public const string Level_initial				= "<lv";
			public const string Unit_initial				= "<un";
			public const string Extension_initial			= "<ex";
			public const string RuralDelivery_initial		= "<rd";
			public const string PostalCode_initial			= "<pc";
			public const string BoxNumber_initial			= "<bx";
			public const string HouseNumber_initial			= "<hn";
			public const string StreetName_initial			= "<sn";
			public const string StreetType_initial			= "<st";
			public const string Compass_initial				= "<cp";
			public const string Suburb_initial				= "<sb";
			public const string City_initial				= "<ct";
			public const string Metropolitan_initial		= "<mt";
			public const string ProvinceName_initial		= "<pv";
			public const string ProvinceCode_initial		= "<pa";
			public const string CountryName_initial			= "<cy";
			public const string CountryCode_initial			= "<cd";
			public const string ShortIsoCode_initial		= "<si";
			public const string LongIsoCode_initial			= "<li";

			//Initial as upper: Return token's left-most character in UPPER case.
			public const string Assemblage_INITIAL			= ">as";
			public const string Level_INITIAL				= ">lv";
			public const string Unit_INITIAL				= ">un";
			public const string Extension_INITIAL			= ">ex";
			public const string RuralDelivery_INITIAL		= ">rd";
			public const string PostalCode_INITIAL			= ">pc";
			public const string BoxNumber_INITIAL			= ">bx";
			public const string HouseNumber_INITIAL			= ">hn";
			public const string StreetName_INITIAL			= ">sn";
			public const string StreetType_INITIAL			= ">st";
			public const string Compass_INITIAL				= ">cp";
			public const string Suburb_INITIAL				= ">sb";
			public const string City_INITIAL				= ">ct";
			public const string Metropolitan_INITIAL		= ">mt";
			public const string ProvinceName_INITIAL		= ">pv";
			public const string ProvinceCode_INITIAL		= ">pa";
			public const string CountryName_INITIAL			= ">cy";
			public const string CountryCode_INITIAL			= ">cd";
			public const string ShortIsoCode_INITIAL		= ">si";
			public const string LongIsoCode_INITIAL			= ">li";

			public const string NoValue						= "/nv";//There is no value associated with the field. Placeholder. Usage not required.

			//___________________________________________________________________________________________________________________________________________
			public static string[] Codes = new string[]
			{
				PkAddress,
				FkCountry,
				Assemblage_AsIs,		Assemblage_UPPER,		Assemblage_Proper,		Assemblage_lower,		Assemblage_initial,			Assemblage_INITIAL,
				Level_AsIs,				Level_UPPER,			Level_Proper,			Level_lower,			Level_initial,				Level_INITIAL,
				Unit_AsIs,				Unit_UPPER,				Unit_Proper,			Unit_lower,				Unit_initial,				Unit_INITIAL,
				Extension_AsIs,			Extension_UPPER,		Extension_Proper,		Extension_lower,		Extension_initial,			Extension_INITIAL,
				RuralDelivery_AsIs,		RuralDelivery_UPPER,	RuralDelivery_Proper,	RuralDelivery_lower,	RuralDelivery_initial,		RuralDelivery_INITIAL,
				PostalCode_AsIs,		PostalCode_UPPER,		PostalCode_Proper,		PostalCode_lower,		PostalCode_initial,			PostalCode_INITIAL,
				BoxNumber_AsIs,			BoxNumber_UPPER,		BoxNumber_Proper,		BoxNumber_lower,		BoxNumber_initial,			BoxNumber_INITIAL,
				HouseNumber_AsIs,		HouseNumber_UPPER,		HouseNumber_Proper,		HouseNumber_lower,		HouseNumber_initial,		HouseNumber_INITIAL,
				StreetName_AsIs,		StreetName_UPPER,		StreetName_Proper,		StreetName_lower,		StreetName_initial,			StreetName_INITIAL,
				StreetType_AsIs,		StreetType_UPPER,		StreetType_Proper,		StreetType_lower,		StreetType_initial,			StreetType_INITIAL,
				Compass_AsIs,			Compass_UPPER,			Compass_Proper,			Compass_lower,			Compass_initial,			Compass_INITIAL,
				Suburb_AsIs,			Suburb_UPPER,			Suburb_Proper,			Suburb_lower,			Suburb_initial,				Suburb_INITIAL,
				City_AsIs,				City_UPPER,				City_Proper,			City_lower,				City_initial,				City_INITIAL,
				Metropolitan_AsIs,		Metropolitan_UPPER,		Metropolitan_Proper,	Metropolitan_lower,		Metropolitan_initial,		Metropolitan_INITIAL,
				ProvinceName_AsIs,		ProvinceName_UPPER,		ProvinceName_Proper,	ProvinceName_lower,		ProvinceName_initial,		ProvinceName_INITIAL,
				ProvinceCode_AsIs,		ProvinceCode_UPPER,		ProvinceCode_Proper,	ProvinceCode_lower,		ProvinceCode_initial,		ProvinceCode_INITIAL,
				
				CountryName_AsIs,		CountryName_UPPER,		CountryName_Proper,		CountryName_lower,		CountryName_initial,		CountryName_INITIAL,
				CountryCode_AsIs,		CountryCode_UPPER,		CountryCode_Proper,		CountryCode_lower,		CountryCode_initial,		CountryCode_INITIAL,
				ShortIsoCode_AsIs,		ShortIsoCode_UPPER,		ShortIsoCode_Proper,	ShortIsoCode_lower,		ShortIsoCode_initial,		ShortIsoCode_INITIAL,
				LongIsoCode_AsIs,		LongIsoCode_UPPER,		LongIsoCode_Proper,		LongIsoCode_lower,		LongIsoCode_initial,		LongIsoCode_INITIAL,

				NoValue
			};

			//___________________________________________________________________________________________________________________________________________
			//Token strings for reconstructing/realising an output address.
			public const string VCF_Unrealisable	= "";
			public const string EXCEL_Unrealisable	= "";
			public const string Message				= @"/hn /sn /st, /ct, /pv /cy";						//Display some address information as a message.
			public const string VcfPostal			= @"/hn /sn /st\n/ct, /pc\n/cy";					//'Typical' residential Postal rule.
			public const string VcfPhysical			= @"/hn /sn /st\n/sb, /ct\n/mt, /pv\n/cy";			//'Typical' residential Physical rule.
			public const string VcfExtended			= @"/as\n/lv\n/un\n/ex";							//'Typical' Extensions rule.
			public const string ExcelPattern		= @"SID*AID*FID*SRT*OUT*/hn /sn /st*/ct*/pc*/cy";	//'Typical' Excel row rule/pattern. Asterisk is relaced by a tab.
			/*
			public const string Notification		= "Address PK: /pk|	Street: /hn /sn /st /sb /rd /pc /ct|" +
													  "Provincial: /mt /pv /pa|" +
													  "Country: FK: /fk, /cy /cd /si /li|" +
													  "Extensions: /as /lv /un /ex||Operation: *";
													  // vee-bars (|) are replaced by line breaks.
			*/

			//Reconstruction rules specific to building a Christmas letter address.
			public const string Christmas			= "";	   //?
			public const string SortId				= "SID";	//Replaced with a generic integer sort order.
			public const string AddressId			= "AID";	//Replaced with PK Address.
			public const string FamilyId			= "FID";	//Replaced with PK Family.
			public const string SortableName		= "SRT";	//Replaced with sortable family name.
			public const string OuterName			= "OUT";	//Replaced with family 'outside' postal name, i.e., name used on the envelope.

			//Token-level formatting instructions.
			public const string UPPER				= "^";	  //Return entire token in UPPER case.
			public const string Proper				= "|";	  //Return entire token in Proper case.
			public const string lower				= "~";	  //Return entire token in lower case.
			public const string initial				= "<";	  //Return token's left-most character in lower case.
			public const string INITIAL				= ">";	  //Return token's left-most character in upper case.
			public const string AsIs				= "/";	  //Return token as is.
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static FACTORS[] Factors =
		{
			new FACTORS(  0, FieldWidths[ 0], FieldNames[ 0], ParameterNames[ 0] ), //PkAddress
			new FACTORS(  1, FieldWidths[ 1], FieldNames[ 1], ParameterNames[ 1] ), //FkCountry
			new FACTORS(  2, FieldWidths[ 2], FieldNames[ 2], ParameterNames[ 2] ), //StAssemblage
			new FACTORS(  3, FieldWidths[ 3], FieldNames[ 3], ParameterNames[ 3] ), //StLevel
			new FACTORS(  4, FieldWidths[ 4], FieldNames[ 4], ParameterNames[ 4] ), //StUnit
			new FACTORS(  5, FieldWidths[ 5], FieldNames[ 5], ParameterNames[ 5] ), //StExtension
			new FACTORS(  6, FieldWidths[ 6], FieldNames[ 6], ParameterNames[ 6] ), //StRuralDelivery
			new FACTORS(  7, FieldWidths[ 7], FieldNames[ 7], ParameterNames[ 7] ), //StPostalCode
			new FACTORS(  8, FieldWidths[ 8], FieldNames[ 8], ParameterNames[ 8] ), //StBoxNumber
			new FACTORS(  9, FieldWidths[ 9], FieldNames[ 9], ParameterNames[ 9] ), //StHouseNumber
			new FACTORS( 10, FieldWidths[10], FieldNames[10], ParameterNames[10] ), //StStreetName
			new FACTORS( 11, FieldWidths[11], FieldNames[11], ParameterNames[11] ), //StStreetType
			new FACTORS( 12, FieldWidths[12], FieldNames[12], ParameterNames[12] ), //StCompass
			new FACTORS( 13, FieldWidths[13], FieldNames[13], ParameterNames[13] ), //StSuburb
			new FACTORS( 14, FieldWidths[14], FieldNames[14], ParameterNames[14] ), //StCity
			new FACTORS( 15, FieldWidths[15], FieldNames[15], ParameterNames[15] ), //StMetropolitan
			new FACTORS( 16, FieldWidths[16], FieldNames[16], ParameterNames[16] ), //StProvinceName
			new FACTORS( 17, FieldWidths[17], FieldNames[17], ParameterNames[17] ), //StProvinceCode
			new FACTORS( 18, FieldWidths[18], FieldNames[18], ParameterNames[18] ), //StVcfPostal
			new FACTORS( 19, FieldWidths[19], FieldNames[19], ParameterNames[19] ), //StVcfPhysical
			new FACTORS( 20, FieldWidths[20], FieldNames[20], ParameterNames[20] ), //StVcfExtended
			new FACTORS( 21, FieldWidths[21], FieldNames[21], ParameterNames[21] ), //StExcelPattern
			new FACTORS( 22, FieldWidths[22], FieldNames[22], ParameterNames[22] ), //StNotes
			new FACTORS( 23, FieldWidths[23], FieldNames[23], ParameterNames[23] ), //IsSelected
			new FACTORS( 24, FieldWidths[24], FieldNames[24], ParameterNames[24] ), //IsDefaultRow
			new FACTORS( 25, FieldWidths[25], FieldNames[25], ParameterNames[25] ), //IsUnattached
			new FACTORS( 26, FieldWidths[26], FieldNames[26], ParameterNames[26] ), //IsX_Person
			new FACTORS( 27, FieldWidths[27], FieldNames[27], ParameterNames[27] ), //IsX_Group
			new FACTORS( 28, FieldWidths[28], FieldNames[28], ParameterNames[28] ), //IsX_Family
			new FACTORS( 29, FieldWidths[29], FieldNames[29], ParameterNames[29] ), //IsChristmas
			new FACTORS( 30, FieldWidths[30], FieldNames[30], ParameterNames[30] ),	//StCountryName
			new FACTORS( 31, FieldWidths[31], FieldNames[31], ParameterNames[31] ),	//StCountryCode
			new FACTORS( 32, FieldWidths[32], FieldNames[32], ParameterNames[32] ),	//StShortIsoCode
			new FACTORS( 33, FieldWidths[33], FieldNames[33], ParameterNames[33] )  //StLongIsoCode
		};
		#endregion
	}
}
