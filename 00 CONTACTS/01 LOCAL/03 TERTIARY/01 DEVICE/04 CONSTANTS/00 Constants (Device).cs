//___________________________________________________________________________________________________________________________________________________
using FACTORS = CONTACTS.GLOBAL.TOOLS.ColumnFactors;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 21;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkDevice				=  0;
			public const int Country				=  1;
			public const int LongAreaCode			=  2;
			public const int ShortAreaCode			=  3;
			public const int LeadingDigits			=  4;
			public const int TrailingDigits			=  5;
			public const int DeviceLocation			=  6;
			public const int DeviceType				=  7;
			public const int DialNumber				=  8;
			public const int PickerNumber			=  9;
			public const int Notes					= 10;
			public const int Selected				= 11;
			public const int DefaultRow				= 12;
			public const int Blocked				= 13;
			public const int X_Person				= 14;
			public const int X_Group				= 15;
			public const int X_Family				= 16;

			//Country contributions
			public const int CountryName			= 17;
			public const int CountryCode			= 18;
			public const int ShortIsoCode			= 19;
			public const int LongIsoCode			= 20;
		}
		//_______________________________________________________________________________________________________________________________________
		public static string[] FieldNames =
		{
			"pk_Device",
			"fk_Country",
			"st_LongAreaCode",
			"st_ShortAreaCode",
			"st_LeadingDigits",
			"st_TrailingDigits",
			"st_DeviceLocation",
			"st_DeviceType",
			"st_DialNumber",
			"st_PickerNumber",
			"st_Notes",
			"is_Selected",
			"is_DefaultRow",
			"is_Blocked",
			"is_X_Person",
			"is_X_Group",
			"is_X_Family",

			//Country contributions
			"st_CountryName",
			"st_CountryCode",
			"st_ShortIsoCode",
			"st_LongIsoCode"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_device",
			"@fk_country",
			"@st_longareacode",
			"@st_shortareacode",
			"@st_leadingdigits",
			"@st_trailingdigits",
			"@st_devicelocation",
			"@st_devicetype",
			"@st_dialnumber",
			"@st_pickernumber",
			"@st_notes",
			"@is_selected",
			"@is_defaultrow",
			"@is_blocked",
			"@is_x_person",
			"@is_x_group",
			"@is_x_family",

			//Country contributions
			"@st_countryname",
			"@st_countrycode",
			"@st_shortisocode",
			"@st_longisocode"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,			//PkDevice
			4,			//FkCountry
			5,			//StLongAreaCode
			5,			//StShortAreaCode
			5,			//StLeadingDigits
			10,			//StTrailingDigits
			10,			//StDeviceLocation
			10,			//StDeviceType
			35,			//StDialNumber
			35,			//StPickerNumber
			255,		//StNotes
			1,			//IsSelected
			1,			//IsDefaultRow
			1,			//IsBlocked
			1,			//IsX_Person
			1,			//IsX_Group
			1,			//IsX_Family

			//Country contributions
			100,		//StCountryName
			5,			//StCountryCode
			2,			//StShortIsoCode
			3			//StLongIsoCode
		};
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static FACTORS[] Factors =
		{
			new FACTORS(  0, FieldWidths[ 0], FieldNames[ 0], ParameterNames[ 0] ),	//PkDevice
			new FACTORS(  1, FieldWidths[ 1], FieldNames[ 1], ParameterNames[ 1] ),	//FkCountry
			new FACTORS(  2, FieldWidths[ 2], FieldNames[ 2], ParameterNames[ 2] ),	//StLongAreaCode
			new FACTORS(  3, FieldWidths[ 3], FieldNames[ 3], ParameterNames[ 3] ),	//StShortAreaCode
			new FACTORS(  4, FieldWidths[ 4], FieldNames[ 4], ParameterNames[ 4] ),	//StLeadingDigits
			new FACTORS(  5, FieldWidths[ 5], FieldNames[ 5], ParameterNames[ 5] ),	//StTrailingDigits
			new FACTORS(  6, FieldWidths[ 6], FieldNames[ 6], ParameterNames[ 6] ),	//StDeviceLocation
			new FACTORS(  7, FieldWidths[ 7], FieldNames[ 7], ParameterNames[ 7] ),	//StDeviceType
			new FACTORS(  8, FieldWidths[ 8], FieldNames[ 8], ParameterNames[ 8] ),	//StDialNumber
			new FACTORS(  9, FieldWidths[ 9], FieldNames[ 9], ParameterNames[ 9] ),	//StPickerNumber
			new FACTORS( 10, FieldWidths[10], FieldNames[10], ParameterNames[10] ),	//StNotes
			new FACTORS( 11, FieldWidths[11], FieldNames[11], ParameterNames[11] ),	//IsSelected
			new FACTORS( 12, FieldWidths[12], FieldNames[12], ParameterNames[12] ),	//IsDefaultRow
			new FACTORS( 13, FieldWidths[13], FieldNames[13], ParameterNames[13] ),	//IsBlocked
			new FACTORS( 14, FieldWidths[14], FieldNames[14], ParameterNames[14] ),	//IsX_Person
			new FACTORS( 15, FieldWidths[15], FieldNames[15], ParameterNames[15] ),	//IsX_Group
			new FACTORS( 16, FieldWidths[16], FieldNames[16], ParameterNames[16] ),	//IsX_Family
			new FACTORS( 17, FieldWidths[17], FieldNames[17], ParameterNames[17] ),	//StCountryName
			new FACTORS( 18, FieldWidths[18], FieldNames[18], ParameterNames[18] ),	//StCountryCode
			new FACTORS( 19, FieldWidths[19], FieldNames[19], ParameterNames[19] ),	//StShortIsoCode
			new FACTORS( 20, FieldWidths[20], FieldNames[20], ParameterNames[20] )  //StLongIsoCode
		};
		#endregion
	}
}
