//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 15;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkDevice			= 0;
			public const int FkCountry			= 1;
			public const int LongAreaCode		= 2;
			public const int ShortAreaCode		= 3;
			public const int LeadingDigits		= 4;
			public const int TrailingDigits		= 5;
			public const int DeviceLocation		= 6;
			public const int DeviceType			= 7;
			public const int DialNumber			= 8;
			public const int PickerNumber		= 9;
			public const int Notes				= 10;

			//Country 'qualifications'.
			public const int CountryName		= 11;
			public const int CountryCode		= 12;
			public const int ShortIsoCode		= 13;
			public const int LongIsoCode		= 14;
		}
		//_______________________________________________________________________________________________________________________________________
		public static int[] OrdinalByValue =
		{
			0,		//PkDevice
			1,		//FkCountry
			2,		//LongAreaCode
			3,		//ShortAreaCode
			4,		//LeadingDigits
			5,		//TrailingDigits
			6,		//DeviceLocation
			7,		//DeviceType
			8,		//DialNumber
			9,		//PickerNumber
			10,		//Notes

			11,		//CountryName
			12,		//CountryCode
			13,		//ShortIsoCode
			14		//LongIsoCode
		};
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

			"@st_countryname",
			"@st_countrycode",
			"@st_shortisocode",
			"@st_longisocode"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkDevice
			4,		//FkCountry
			5,		//LongAreaCode
			5,		//ShortAreaCode
			5,		//LeadingDigits
			10,		//TrailingDigits
			10,		//DeviceLocation
			10,		//DeviceType
			35,		//DialNumber
			35,		//PickerNumber
			255,	//Notes

			100,	//CountryName
			5,		//CountryCode
			2,		//ShortIsoCode
			3		//LongIsoCode
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"Primary Key, AutoNum, int.",
			"FK into TDF_Countries.pk_Country. Default value = 0 (i.e., New Zealand, country code: 64).",
			"Long within-country, out-of-area code. Includes leading 0s, eg: 04.  Default value = '027'. Applied to NZ numbers only. [5].",
			"Short within-country, within-area code. Omits leading 0s, eg: '04' becomes '4'. Default value = '27'. Applied to NZ numbers only. [5].",
			"Digits preceding the hyphen of an in-area telecom number. eg: 233 of '233-9777'. [5].",
			"Digits following the hyphen of an in-area telecom number. eg: 9777 of '233-9777'. [10].",
			"Physical location. HOME; RECEPTION (primary dial-in of an organisation); DDI (Direct dial, by-passes RECEPTION); MOBILE; OTHER (everything else). Limit-to-List=Yes. Default value = 'MOBILE'. [10].",
			"Device type: CELL (CELL & MOBILE are linked: CELL is the type and MOBILE is the behaviour); LANDLINE; TOLLFREE. Limit-to-List=Yes. Default value = 'CELL'. [10].",
			"Fully-decorated telecom number, e.g., +64 4 233 9777. Device is expected to interpret appropriate local dialling requirements. Indexed, no duplicates. [35].",
			"EG: 9777 233 04 64 NZ: Components reversed: TrailingDigits + LeadingDigits + AreaCode + CountryCode + Short ISO Code, to facilitate assignment selection. [35].",
			"General-purpose text field. [255].",
			"CountryName",
			"CountryCode",
			"ShortIsoCode",
			"LongIsoCode"
		};
		#endregion


		#region NON-ORDINAL CONSTANTS
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkDevice		= "/pk";
			public const string FkCountry		= "/fk";
			public const string LongAreaCode	= "/lc";
			public const string ShortAreaCode	= "/sc";
			public const string LeadingDigits	= "/ld";
			public const string TrailingDigits	= "/td";
			public const string DeviceLocation	= "/dl";
			public const string DeviceType		= "/dt";
			public const string DialNumber		= "/dn";
			public const string PickerNumber	= "/pn";
			public const string Notes			= "/nt";

			public const string CountryName		= "/cy";
			public const string CountryCode		= "/cd";
			public const string ShortIsoCode	= "/si";
			public const string LongIsoCode		= "/li";
		}
		//___________________________________________________________________________________________________________________________________________
		public static class Reminders
	{
			public static readonly string[] Now				= { "Sets the Currency date to Now()." };
			public static readonly string[] Filter			= { "Filter by PkDevice: enter integer value, hit RETURN." };
			public static readonly string[] FirstDevice		= { "Moves the position of the row cursor to the first Device (MinPK) in TDF_Devices." };
			public static readonly string[] NextDevice		= { "Moves the position of the row cursor to the row with the next higher PkDevice in TDF_Devices.", "Does not move beyond Max PK." };
			public static readonly string[] PreviousDevice	= { "Moves the position of the row cursor to the row with the next lower TDF_Device in TDF_Devices.", "Does not move beyond Min PK." };
			public static readonly string[] LastDevice		= { "Moves the position of the row cursor to the last (Max PK) Device in TDF_Devices." };
			public static readonly string[] UpdateDevice	= { "Overwrites entire TDF_Devices row with values displayed on the form." };
			public static readonly string[] InsertDevice	= { "Adds (copies) a row to TDF_Devices and populates the row with values currently displayed on the form." };
			public static readonly string[] FindDevice		= { "Opens the Find Device form. Form makes available additional search options." };
			public static readonly string[] MatchesDevice	= { "Searches for devices based on the trailing digits." };
			public static readonly string[] CloseForm		= { "Closes form.", "Unsaved changes are lost." };
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),	//PkDevice
			new ColumnFactors( 1),	//FkCountry
			new ColumnFactors( 2),	//LongAreaCode
			new ColumnFactors( 3),	//ShortAreaCode
			new ColumnFactors( 4),	//LeadingDigits
			new ColumnFactors( 5),	//TrailingDigits
			new ColumnFactors( 6),	//DeviceLocation
			new ColumnFactors( 7),	//DeviceType
			new ColumnFactors( 8),	//DialNumber
			new ColumnFactors( 9),	//PickerNumber
			new ColumnFactors(10),	//Notes
			new ColumnFactors(11),	//CountryName
			new ColumnFactors(12),	//CountryCode
			new ColumnFactors(13),	//ShortIsoCode
			new ColumnFactors(14)	//LongIsoCode
			};
		//_______________________________________________________________________________________________________________________________________
		public class ColumnFactors
		{
			private int		i_Ordinal;
			private string	s_FieldName;
			private string	s_ParameterName;
			private int		i_FieldWidth;
			private string	s_Prompt;

			//___________________________________________________________________________________________________________________________________
			public ColumnFactors( int ordinal )
			{
				this.i_Ordinal			= ordinal;
				this.s_FieldName		= FieldNames[ordinal];
				this.s_ParameterName	= ParameterNames[ordinal];
				this.i_FieldWidth		= FieldWidths[ordinal];
				this.s_Prompt			= Prompts[ordinal];
			}
			//___________________________________________________________________________________________________________________________________
			public int Ordinal			{ get { return i_Ordinal; } }
			public string FieldName		{ get { return s_FieldName; } }
			public string ParameterName	{ get { return s_ParameterName; } }
			public int FieldWidth		{ get { return i_FieldWidth; } }
			public string Prompt		{ get { return s_Prompt; } }
		}
		#endregion
	}
}
