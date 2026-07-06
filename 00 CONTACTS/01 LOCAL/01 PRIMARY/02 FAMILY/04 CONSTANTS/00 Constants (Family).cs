//___________________________________________________________________________________________________________________________________________________
using FACTORS = CONTACTS.GLOBAL.TOOLS.ColumnFactors;


//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 22;

		public enum FamilyType { NO_TYPE, L_EQ_R, L_NE_R, NO_R };
		public const string L_EQ_R	= "LEFT=RIGHT";		//Left and Right share a surname.
		public const string L_NE_R	= "LEFT<>RIGHT";	//Left and Right do not share a surname.
		public const string NO_R	= "NO_RIGHT";		//There is no Right person.

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkFamily			=  0;
			public const int FkLeftPerson		=  1;
			public const int FkRightPerson		=  2;
			public const int FamilyType			=  3;
			public const int FamilyName			=  4;
			public const int SortableName		=  5;
			public const int JointName			=  6;
			public const int NaturalName		=  7;
			public const int PostalName			=  8;
			public const int Notes				=  9;
			public const int WeddingDate		= 10;
			public const int CurrencyDate		= 11;

			public const int Selected			= 12;
			public const int DefaultRow			= 13;
			public const int Export				= 14;
			public const int Blocked			= 15;
			public const int Inactive			= 16;
			public const int Christmas			= 17;
			public const int ExChristmas		= 18;
			public const int Dissolved			= 19;
			public const int CorlettRd			= 20;
			public const int StTheresa			= 21;

			public const int LeftUpperSurname	= 22;
			public const int LeftProperSurname	= 23;
			public const int LeftGivenName		= 24;
			public const int RightUpperSurname	= 25;
			public const int RightProperSurname	= 26;
			public const int RightGivenName		= 27;
		}
		//_______________________________________________________________________________________________________________________________________
		public static string[] FieldNames =
		{
			"pk_Family",
			"fk_LeftPerson",
			"fk_RightPerson",
			"st_FamilyType",
			"st_FamilyName",
			"st_SortableName",
			"st_JointName",
			"st_NaturalName",
			"st_PostalName",
			"st_Notes",
			"dt_WeddingDate",
			"dt_CurrencyDate",
			"is_Selected",
			"is_DefaultRow",
			"is_Export",
			"is_Blocked",
			"is_Inactive",
			"is_Christmas",
			"is_ExChristmas",
			"is_Dissolved",
			"is_CorlettRd",
			"is_StTheresa",

			"LeftUpperSurname",
			"LeftProperSurname",
			"LeftGivenName",
			"RightUpperSurname",
			"RightProperSurname",
			"RightGivenName"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_family",
			"@fk_leftperson",
			"@fk_rightperson",
			"@st_familytype",
			"@st_familyname",
			"@st_sortablename",
			"@st_jointname",
			"@st_naturalname",
			"@st_postalname",
			"@st_notes",
			"@dt_weddingdate",
			"@dt_currencydate",
			"@is_selected",
			"@is_defaultrow",
			"@is_export",
			"@is_blocked",
			"@is_inactive",
			"@is_christmas",
			"@is_exchristmas",
			"@is_dissolved",
			"@is_corlettrd",
			"@is_sttheresa",

			"@st_leftuppersurname",
			"@st_leftpropersurname",
			"@st_leftgivenname",
			"@st_rightuppersurname",
			"@st_rightpropersurname",
			"@st_rightgivenname"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkFamily
			4,		//FkLeftPerson
			4,		//FkRightPerson
			15,		//StFamilyType
			255,	//StFamilyName
			255,	//StSortableName
			255,	//StJointName
			255,	//StNaturalName
			255,	//StPostalName
			255,	//StNotes
			8,		//DtWeddingDate
			8,		//DtCurrencyDate
			1,		//IsSelected
			1,		//IsDefaultRow
			1,		//IsExport
			1,		//IsBlocked
			1,		//IsInactive
			1,		//IsChristmas
			1,		//IsExChristmas
			1,		//IsDissolved
			1,		//IsCorlettRd
			1,		//IsStTheresa

			255,	//StLeftUpperSurname
			255,	//StLeftProperSurname
			255,	//StLeftGivenName
			255,	//StRightUpperSurname
			255,	//StRightProperSurname
			255		//StRightGivenName
		};
		#endregion

		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static FACTORS[] Factors =
		{
			new FACTORS(  0, FieldWidths[ 0], FieldNames[ 0], ParameterNames[ 0] ),		//PkFamily
			new FACTORS(  1, FieldWidths[ 1], FieldNames[ 1], ParameterNames[ 1] ),		//FkLeftPerson
			new FACTORS(  2, FieldWidths[ 2], FieldNames[ 2], ParameterNames[ 2] ),		//FkRightPerson
			new FACTORS(  3, FieldWidths[ 3], FieldNames[ 3], ParameterNames[ 3] ),		//StFamilyType
			new FACTORS(  4, FieldWidths[ 4], FieldNames[ 4], ParameterNames[ 4] ),		//StFamilyName
			new FACTORS(  5, FieldWidths[ 5], FieldNames[ 5], ParameterNames[ 5] ),		//StSortableName
			new FACTORS(  6, FieldWidths[ 6], FieldNames[ 6], ParameterNames[ 6] ),		//StJointName
			new FACTORS(  7, FieldWidths[ 7], FieldNames[ 7], ParameterNames[ 7] ),		//StNaturalName
			new FACTORS(  8, FieldWidths[ 8], FieldNames[ 8], ParameterNames[ 8] ),		//StPostalName
			new FACTORS(  9, FieldWidths[ 9], FieldNames[ 9], ParameterNames[ 9] ),		//StNotes
			new FACTORS( 10, FieldWidths[10], FieldNames[10], ParameterNames[10] ),		//DtWeddingDate
			new FACTORS( 11, FieldWidths[11], FieldNames[11], ParameterNames[11] ),		//DtCurrencyDate
			new FACTORS( 12, FieldWidths[12], FieldNames[12], ParameterNames[12] ),		//IsSelected
			new FACTORS( 13, FieldWidths[13], FieldNames[13], ParameterNames[13] ),		//IsDefaultRow
			new FACTORS( 14, FieldWidths[14], FieldNames[14], ParameterNames[14] ),		//IsExport
			new FACTORS( 15, FieldWidths[15], FieldNames[15], ParameterNames[15] ),		//IsBlocked
			new FACTORS( 16, FieldWidths[16], FieldNames[16], ParameterNames[16] ),		//IsInactive
			new FACTORS( 17, FieldWidths[17], FieldNames[17], ParameterNames[17] ),		//IsChristmas
			new FACTORS( 18, FieldWidths[18], FieldNames[18], ParameterNames[18] ),		//IsExChristmas
			new FACTORS( 19, FieldWidths[19], FieldNames[19], ParameterNames[19] ),		//IsDissolved
			new FACTORS( 20, FieldWidths[20], FieldNames[20], ParameterNames[20] ),		//IsCorlettRd
			new FACTORS( 21, FieldWidths[21], FieldNames[21], ParameterNames[21] ),		//IsStTheresa
			new FACTORS( 22, FieldWidths[22], FieldNames[22], ParameterNames[22] ),		//StLeftUpperSurname
			new FACTORS( 23, FieldWidths[23], FieldNames[23], ParameterNames[23] ),		//StLeftProperSurname
			new FACTORS( 24, FieldWidths[24], FieldNames[24], ParameterNames[24] ),		//StLeftGivenName
			new FACTORS( 25, FieldWidths[25], FieldNames[25], ParameterNames[25] ),		//StRightUpperSurname
			new FACTORS( 26, FieldWidths[26], FieldNames[26], ParameterNames[26] ),		//StRightProperSurname
			new FACTORS( 27, FieldWidths[27], FieldNames[27], ParameterNames[27] )		//StRightGivenName
		};
		#endregion
	}
}
