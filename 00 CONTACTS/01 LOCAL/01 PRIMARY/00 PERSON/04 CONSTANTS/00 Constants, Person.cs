//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 31;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkPerson			=  0;
			public const int SortableName		=  1;
			public const int NaturalName		=  2;
			public const int UpperSurname		=  3;
			public const int ProperSurname		=  4;
			public const int GivenName			=  5;
			public const int MiddleNames		=  6;
			public const int NickName			=  7;
			public const int BirthName			=  8;
			public const int Prefix				=  9;
			public const int Suffix				= 10;
			public const int Initials			= 11;
			public const int Gender				= 12;
			public const int Notes				= 13;
			public const int BirthDate			= 14;
			public const int DeathDate			= 15;
			public const int WeddingDate		= 16;
			public const int CurrencyDate		= 17;
			public const int EHS_Order			= 18;
			public const int Selected			= 19;
			public const int Enlightened		= 20;
			public const int HolySomething		= 21;
			public const int NewLeftPerson		= 22;
			public const int NoRightPerson		= 23;
			public const int DefaultRow			= 24;
			public const int Export				= 25;
			public const int TimeTalent			= 26;
			public const int Minister			= 27;
			public const int Sacristan			= 28;
			public const int Vigil				= 29;
			public const int Mass				= 30;
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
			"is_Enlightened",
			"is_HolySomething",
			"is_NewLeftPerson",
			"is_NoRightPerson",
			"is_DefaultRow",
			"is_Export",
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
			"@is_enlightened",
			"@is_holysomething",
			"@is_newleftperson",
			"@is_norightperson",
			"@is_defaultrow",
			"@is_export",
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
			200,	//DVStSortableName
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
			1,		//IsEnlightened
			1,		//IsHolySomething
			1,		//IsNewLeftPerson
			1,		//IsNoRightPerson
			1,		//IsDefaultRow
			1,		//IsExport
			1,		//IsTimeTalent
			1,		//IsMinister
			1,		//IsSacristan
			1,		//IsVigil
			1		//IsMass
			};
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),	//PkPerson
			new ColumnFactors( 1),	//StSortableName
			new ColumnFactors( 2),	//StNaturalName
			new ColumnFactors( 3),	//StUpperSurname
			new ColumnFactors( 4),	//StProperSurname
			new ColumnFactors( 5),	//StGivenName
			new ColumnFactors( 6),	//StMiddleNames
			new ColumnFactors( 7),	//StNickName
			new ColumnFactors( 8),	//StBirthName
			new ColumnFactors( 9),	//StPrefix
			new ColumnFactors(10),	//StSuffix
			new ColumnFactors(11),	//StInitials
			new ColumnFactors(12),	//StGender
			new ColumnFactors(13),	//StNotes
			new ColumnFactors(14),	//DtBirthDate
			new ColumnFactors(15),	//DtDeathDate
			new ColumnFactors(16),	//DtWeddingDate
			new ColumnFactors(17),	//DtCurrencyDate
			new ColumnFactors(18),	//LiEHS_Order
			new ColumnFactors(19),	//IsSelected
			new ColumnFactors(20),	//IsEnlightened
			new ColumnFactors(21),	//IsHolySomething
			new ColumnFactors(22),	//IsNewLeftPerson
			new ColumnFactors(23),	//IsNoRightPerson
			new ColumnFactors(24),	//IsDefaultRow
			new ColumnFactors(25),	//IsExport
			new ColumnFactors(26),	//IsTimeTalent
			new ColumnFactors(27),	//IsMinister
			new ColumnFactors(28),	//IsSacristan
			new ColumnFactors(29),	//IsVigil
			new ColumnFactors(30)	//IsMass
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
