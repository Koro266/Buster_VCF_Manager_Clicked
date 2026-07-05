//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 23;

		public enum FamilyType { NO_TYPE, L_EQ_R, L_NE_R, NO_R };
		public const string L_EQ_R	= "LEFT=RIGHT";		//Left and Right share a surname.
		public const string L_NE_R	= "LEFT<>RIGHT";	//Left and Right do not share a surname.
		public const string NO_R	= "NO_RIGHT";		//There is no Right person.

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public static class OrdinalByName
		{
			public const int PkFamily			= 0;
			public const int FkLeftPerson		= 1;
			public const int FkRightPerson		= 2;
			public const int FamilyType			= 3;
			public const int FamilyName			= 4;
			public const int SortableName		= 5;
			public const int JointName			= 6;
			public const int NaturalName		= 7;
			public const int PostalName			= 8;
			public const int Notes				= 9;
			public const int WeddingDate		= 10;
			public const int CurrencyDate		= 11;

			public const int Christmas			= 12;

			public const int Selected		= 19;
			public const int DefaultRow		= 20;
			public const int Export			= 21;
			public const int Blocked		= 22;
			public const int Inactive		= 23;
			public const int IsChristmas	= 24;
			public const int IsExChristmas	= 25;
			public const int Dissolved			= 13;
			public const int CorlettRd			= 14;
			public const int StTheresa			= 15;

			public const int LeftUpperSurname	= 17;
			public const int LeftProperSurname	= 18;
			public const int LeftGivenName		= 19;
			public const int RightUpperSurname	= 20;
			public const int RightProperSurname	= 21;
			public const int RightGivenName		= 22;
		}
		//_______________________________________________________________________________________________________________________________________
		public static int[] OrdinalByValue =
		{
			0,	//PkFamily
			1,	//FkLeftPerson
			2,	//FkRightPerson
			3,	//StFamilyType
			4,	//StFamilyName
			5,	//StSortableName
			6,	//StJointName
			7,	//StNaturalName
			8,	//StPostalName
			9,	//StNotes
			10,	//DtWeddingDate
			11,	//DtCurrencyDate
			12,	//IsChristmas
			13,	//IsDissolved
			14,	//IsCorlettRd
			15,	//IsStTheresa

			16,	//IsDefaultRow
			17,	//StLeftUpperSurname
			18,	//StLeftProperSurname
			19,	//StLeftGivenName
			20,	//StRightUpperSurname
			21,	//StRightProperSurname
			22	//StRightGivenName
		};
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
			"is_Christmas",
			"is_Dissolved",
			"is_CorlettRd",
			"is_StTheresa",

			"is_DefaultRow",
			"LeftUpperSurname,",
			"LeftProperSurname,",
			"LeftGivenName,",
			"RightUpperSurname,",
			"RightProperSurname,",
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
			"@is_christmas",
			"@is_dissolved",
			"@is_corlettrd",
			"@is_sttheresa",
			"@is_defaultrow",
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
			1,		//IsChristmas
			1,		//IsDissolved
			1,		//IsCorlettRd
			1,		//IsStTheresa
			1,		//IsDefaultRow
			255,	//StLeftUpperSurname
			255,	//StLeftProperSurname
			255,	//StLeftGivenName
			255,	//StRightUpperSurname
			255,	//StRightProperSurname
			255		//StRightGivenName
		};
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkFamily			= "/pk";
			public const string FkLeftPerson		= "/lp";
			public const string FkRightPerson		= "/rp";
			public const string FamilyType			= "/ft";
			public const string FamilyName			= "/fn";
			public const string SortableName		= "/sn";
			public const string JointName			= "/jn";
			public const string NaturalName			= "/nn";
			public const string PostalName			= "/pn";
			public const string Notes				= "/nt";
			public const string WeddingDate			= "/wd";
			public const string CurrencyDate		= "/cd";
			public const string Christmas			= "/xm";
			public const string Dissolved			= "/ds";
			public const string CorlettRd			= "/cr";
			public const string StTheresa			= "/st";
			public const string DefaultRow			= "/dr";
			public const string LeftUpperSurname	= "/ls";
			public const string LeftProperSurname	= "/lp";
			public const string LeftGivenName		= "/lg";
			public const string RightUpperSurname	= "/rs";
			public const string RightProperSurname	= "/rp";
			public const string RightGivenName		= "/rg";
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),		//PkFamily
			new ColumnFactors( 1),		//FkLeftPerson
			new ColumnFactors( 2),		//FkRightPerson
			new ColumnFactors( 3),		//FamilyType
			new ColumnFactors( 4),		//FamilyName
			new ColumnFactors( 5),		//SortableName
			new ColumnFactors( 6),		//JointName
			new ColumnFactors( 7),		//NaturalName
			new ColumnFactors( 8),		//PostalName
			new ColumnFactors( 9),		//Notes
			new ColumnFactors( 10),		//WeddingDate
			new ColumnFactors( 11),		//CurrencyDate
			new ColumnFactors( 12),		//Christmas
			new ColumnFactors( 13),		//Dissolved
			new ColumnFactors( 14),		//CorlettRd
			new ColumnFactors( 15),		//StTheresa
			new ColumnFactors( 16),		//DefaultRow
			new ColumnFactors( 17),		//LeftUpperSurname
			new ColumnFactors( 18),		//LeftProperSurname
			new ColumnFactors( 19),		//LeftGivenName
			new ColumnFactors( 20),		//RightUpperSurname
			new ColumnFactors( 21),		//RightProperSurname
			new ColumnFactors( 22)		//RightGivenName
		};
		//_______________________________________________________________________________________________________________________________________
		public class ColumnFactors
		{
			private int		i_Ordinal;
			private string	s_FieldName;
			private string	s_ParameterName;
			private int		i_FieldWidth;

			//___________________________________________________________________________________________________________________________________
			public ColumnFactors( int ordinal )
			{
				this.i_Ordinal			= ordinal;
				this.s_FieldName		= FieldNames[ordinal];
				this.s_ParameterName	= ParameterNames[ordinal];
				this.i_FieldWidth		= FieldWidths[ordinal];
			}
			//___________________________________________________________________________________________________________________________________
			public int Ordinal			{ get { return i_Ordinal; } }
			public string FieldName		{ get { return s_FieldName; } }
			public string ParameterName	{ get { return s_ParameterName; } }
			public int FieldWidth		{ get { return i_FieldWidth; } }
		}
		#endregion
	}
}
