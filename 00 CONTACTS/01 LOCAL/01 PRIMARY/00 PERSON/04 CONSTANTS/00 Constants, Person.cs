//___________________________________________________________________________________________________________________________________________________
using FACTORS = CONTACTS.GLOBAL.TOOLS.ColumnFactors;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 34;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkPerson		=  0;
			public const int SortableName	=  1;
			public const int NaturalName	=  2;
			public const int UpperSurname	=  3;
			public const int ProperSurname	=  4;
			public const int GivenName		=  5;
			public const int MiddleNames	=  6;
			public const int NickName		=  7;
			public const int BirthName		=  8;
			public const int Prefix			=  9;
			public const int Suffix			= 10;
			public const int Initials		= 11;
			public const int Gender			= 12;
			public const int Notes			= 13;
			public const int BirthDate		= 14;
			public const int DeathDate		= 15;
			public const int WeddingDate	= 16;
			public const int CurrencyDate	= 17;
			public const int EHS_Order		= 18;
			public const int Selected		= 19;
			public const int DefaultRow		= 20;
			public const int Export			= 21;
			public const int Blocked		= 22;
			public const int Inactive		= 23;
			public const int NewLeftPerson	= 24;
			public const int NoRightPerson	= 25;
			public const int Enlightened	= 26;
			public const int HolySomething	= 27;
			public const int StTheresa		= 28;
			public const int TimeTalent		= 29;
			public const int Minister		= 30;
			public const int Sacristan		= 31;
			public const int Vigil			= 32;
			public const int Mass			= 33;
		}
		//_______________________________________________________________________________________________________________________________________
		public static string[] FieldNames =
		{
			"pk_Person",
			"st_SortableName",
			"st_NaturalName",
			"st_UpperSurname",
			"st_ProperSurname",
			"st_GivenName",
			"st_MiddleNames",
			"st_NickName",
			"st_BirthName",
			"st_Prefix",
			"st_Suffix",
			"st_Initials",
			"st_Gender",
			"st_Notes",
			"dt_BirthDate",
			"dt_DeathDate",
			"dt_WeddingDate",
			"dt_CurrencyDate",
			"li_EHS_Order",
			"is_Selected",
			"is_DefaultRow",
			"is_Export",
			"is_Blocked",
			"is_Inactive",
			"is_NewLeftPerson",
			"is_NoRightPerson",
			"is_Enlightened",
			"is_HolySomething",
			"is_StTheresa",
			"is_TimeTalent",
			"is_Minister",
			"is_Sacristan",
			"is_Vigil",
			"is_Mass"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_person",
			"@st_sortablename",
			"@st_naturalname",
			"@st_uppersurname",
			"@st_propersurname",
			"@st_givenname",
			"@st_middlenames",
			"@st_nickname",
			"@st_birthname",
			"@st_prefix",
			"@st_suffix",
			"@st_initials",
			"@st_gender",
			"@st_notes",
			"@dt_birthdate",
			"@dt_deathdate",
			"@dt_weddingdate",
			"@dt_currencydate",
			"@li_ehs_order",
			"@is_selected",
			"@is_defaultrow",
			"@is_export",
			"@is_blocked",
			"@is_inactive",
			"@is_newleftperson",
			"@is_norightperson",
			"@is_enlightened",
			"@is_holysomething",
			"@is_sttheresa",
			"@is_timetalent",
			"@is_minister",
			"@is_sacristan",
			"@is_vigil",
			"@is_mass"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkPerson
			200,	//StSortableName
			200,	//StNaturalName
			80,		//StUpperSurname
			80,		//StProperSurname
			80,		//StGivenName
			200,	//StMiddleNames
			50,		//StNickName
			100,	//StBirthName
			50,		//StPrefix
			50,		//StSuffix
			15,		//StInitials
			1,		//StGender
			255,	//StNotes
			8,		//DtBirthDate
			8,		//DtDeathDate
			8,		//DtWeddingDate
			8,		//DtCurrencyDate
			4,		//LiEHS_Order
			1,		//IsSelected
			1,		//IsDefaultRow
			1,		//IsExport
			1,		//IsBlocked
			1,		//IsInactive
			1,		//IsNewLeftPerson
			1,		//IsNoRightPerson
			1,		//IsEnlightened
			1,		//IsHolySomething
			1,		//IsStTheresa
			1,		//IsTimeTalent
			1,		//IsMinister
			1,		//IsSacristan
			1,		//IsVigil
			1		//IsMass
		};
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static FACTORS[] Factors =
		{
			new FACTORS(  0, FieldWidths[ 0], FieldNames[ 0], ParameterNames[ 0] ),	//PK_Person
			new FACTORS(  1, FieldWidths[ 1], FieldNames[ 1], ParameterNames[ 1] ),	//ST_SortableName
			new FACTORS(  2, FieldWidths[ 2], FieldNames[ 2], ParameterNames[ 2] ),	//ST_NaturalName
			new FACTORS(  3, FieldWidths[ 3], FieldNames[ 3], ParameterNames[ 3] ),	//ST_UpperSurname
			new FACTORS(  4, FieldWidths[ 4], FieldNames[ 4], ParameterNames[ 4] ),	//ST_ProperSurname
			new FACTORS(  5, FieldWidths[ 5], FieldNames[ 5], ParameterNames[ 5] ),	//ST_GivenName
			new FACTORS(  6, FieldWidths[ 6], FieldNames[ 6], ParameterNames[ 6] ),	//ST_MiddleNames
			new FACTORS(  7, FieldWidths[ 7], FieldNames[ 7], ParameterNames[ 7] ),	//ST_NickName
			new FACTORS(  8, FieldWidths[ 8], FieldNames[ 8], ParameterNames[ 8] ),	//ST_BirthName
			new FACTORS(  9, FieldWidths[ 9], FieldNames[ 9], ParameterNames[ 9] ),	//ST_Prefix
			new FACTORS( 10, FieldWidths[10], FieldNames[10], ParameterNames[10] ),	//ST_Suffix
			new FACTORS( 11, FieldWidths[11], FieldNames[11], ParameterNames[11] ),	//ST_Initials
			new FACTORS( 12, FieldWidths[12], FieldNames[12], ParameterNames[12] ),	//ST_Gender
			new FACTORS( 13, FieldWidths[13], FieldNames[13], ParameterNames[13] ),	//ST_Notes
			new FACTORS( 14, FieldWidths[14], FieldNames[14], ParameterNames[14] ),	//DT_BirthDate
			new FACTORS( 15, FieldWidths[15], FieldNames[15], ParameterNames[15] ),	//DT_DeathDate
			new FACTORS( 16, FieldWidths[16], FieldNames[16], ParameterNames[16] ),	//DT_WeddingDate
			new FACTORS( 17, FieldWidths[17], FieldNames[17], ParameterNames[17] ),	//DT_CurrencyDate
			new FACTORS( 18, FieldWidths[18], FieldNames[18], ParameterNames[18] ),	//LI_EHS_Order
			new FACTORS( 19, FieldWidths[19], FieldNames[19], ParameterNames[19] ),	//IS_Selected
			new FACTORS( 20, FieldWidths[20], FieldNames[20], ParameterNames[20] ),	//IS_DefaultRow
			new FACTORS( 21, FieldWidths[21], FieldNames[21], ParameterNames[21] ),	//IS_Export
			new FACTORS( 22, FieldWidths[22], FieldNames[22], ParameterNames[22] ),	//IS_Blocked
			new FACTORS( 23, FieldWidths[23], FieldNames[23], ParameterNames[23] ),	//IS_Inactive
			new FACTORS( 24, FieldWidths[24], FieldNames[24], ParameterNames[24] ),	//IS_NewLeftPerson
			new FACTORS( 25, FieldWidths[25], FieldNames[25], ParameterNames[25] ),	//IS_NoRightPerson
			new FACTORS( 26, FieldWidths[26], FieldNames[26], ParameterNames[26] ),	//IS_Enlightened
			new FACTORS( 27, FieldWidths[27], FieldNames[27], ParameterNames[27] ),	//IS_HolySomething
			new FACTORS( 28, FieldWidths[28], FieldNames[28], ParameterNames[28] ),	//IS_StTheresa
			new FACTORS( 29, FieldWidths[29], FieldNames[29], ParameterNames[29] ),	//IS_TimeTalent
			new FACTORS( 30, FieldWidths[30], FieldNames[30], ParameterNames[30] ),	//IS_Minister
			new FACTORS( 31, FieldWidths[31], FieldNames[31], ParameterNames[31] ),	//IS_Sacristan
			new FACTORS( 32, FieldWidths[32], FieldNames[32], ParameterNames[32] ),	//IS_Vigil
			new FACTORS( 33, FieldWidths[33], FieldNames[33], ParameterNames[33] )	//IS_Mass
		};
		#endregion
	}
}
