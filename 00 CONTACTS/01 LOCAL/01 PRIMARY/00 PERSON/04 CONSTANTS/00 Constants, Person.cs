//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 18;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkPerson		= 0;
			public const int SortableName	= 1;
			public const int NaturalName	= 2;
			public const int UpperSurname	= 3;
			public const int ProperSurname	= 4;
			public const int GivenName		= 5;
			public const int MiddleNames	= 6;
			public const int NickName		= 7;
			public const int BirthName		= 8;
			public const int Prefix			= 9;
			public const int Suffix			= 10;
			public const int Initials		= 11;
			public const int Gender			= 12;
			public const int Notes			= 13;
			public const int BirthDate		= 14;
			public const int DeathDate		= 15;
			public const int WeddingDate	= 16;
			public const int CurrencyDate	= 17;
		}
		//_______________________________________________________________________________________________________________________________________
		public static int[] OrdinalByValue =
		{
			0,		//PkPerson
			1,		//SortableName
			2,		//NaturalName
			3,		//UpperSurname
			4,		//ProperSurname
			5,		//GivenName
			6,		//MiddleNames
			7,		//NickName
			8,		//BirthName
			9,		//Prefix
			10,		//Suffix
			11,		//Initials
			12,		//Gender
			13,		//Notes
			14,		//BirthDate
			15,		//DeathDate
			16,		//WeddingDate
			17		//CurrencyDate
		};
		//_______________________________________________________________________________________________________________________________________
		public struct ColumnNames
		{
			public const string PkPerson			= "PkPerson";
			public const string SortableName		= "SortableName";
			public const string NaturalName			= "NaturalName";
			public const string UpperSurname		= "UpperSurname";
			public const string ProperSurname		= "ProperSurname";
			public const string GivenName			= "GivenName";
			public const string MiddleNames			= "MiddleNames";
			public const string NickName			= "NickName";
			public const string BirthName			= "BirthName";
			public const string Prefix				= "Prefix";
			public const string Suffix				= "Suffix";
			public const string Initials			= "Initials";
			public const string Gender				= "Gender";
			public const string Notes				= "Notes";
			public const string BirthDate			= "BirthDate";
			public const string DeathDate			= "DeathDate";
			public const string WeddingDate			= "WeddingDate";
			public const string CurrencyDate		= "CurrencyDate";
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Names =
		{
			"Person",
			"SortableName",
			"NaturalName",
			"UpperSurname",
			"ProperSurname",
			"GivenName",
			"MiddleNames",
			"NickName",
			"BirthName",
			"Prefix",
			"Suffix",
			"Initials",
			"Gender",
			"Notes",
			"BirthDate",
			"DeathDate",
			"WeddingDate",
			"CurrencyDate"
		};
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
			"dt_CurrencyDate"
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
			"@dt_currencydate"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkPerson		
			200,	//SortableName	
			200,	//NaturalName	
			80,		//UpperSurname	
			80,		//ProperSurname
			80,		//GivenName	
			200,	//MiddleNames	
			50,		//NickName		
			100,	//BirthName	
			50,		//Prefix		
			50,		//Suffix		
			15,		//Initials		
			1,		//Gender		
			255,	//Notes		
			8,		//BirthDate	
			8,		//DeathDate	
			8,		//WeddingDate	
			8,		//CurrencyDate	
		};
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkPerson		= "/pk";
			public const string SortableName	= "/sn";
			public const string NaturalName		= "/nn";
			public const string UpperSurname	= "/us";
			public const string ProperSurname	= "/ps";
			public const string GivenName		= "/gn";
			public const string MiddleNames		= "/mn";
			public const string NickName		= "/nn";
			public const string BirthName		= "/bn";
			public const string Prefix			= "/px";
			public const string Suffix			= "/sx";
			public const string Initials		= "/in";
			public const string Gender			= "/gn";
			public const string Notes			= "/nt";
			public const string BirthDate		= "/bd";
			public const string DeathDate		= "/dd";
			public const string WeddingDate		= "/wd";
			public const string CurrencyDate	= "/cd";

			//^ UPPER,
			//| Proper,
			//* Initial
			/// Patro part of patronymic

			//public const string SortableName	=  "^sn, |gn |mn";
			//public const string NaturalName	=  "|gn |mn |sn";
			//public const string UpperSurname	=  "^sn";
			//public const string ProperSurname	=  "|sn";
			//public const string GivenName		=  "|gn";
			//public const string MiddleNames	=  "|mn";
			//public const string NickName		=  "|nk";
			//public const string BirthName		=  "|bn";
			//public const string Prefix		=  "|px";
			//public const string Suffix		=  "|sx";
			//public const string Initials		=  "*in";
			//public const string Gender		=  "^gn";
			//public const string BirthDate		=  " bd";
			//public const string DeathDate		=  " dd";
			//public const string WeddingDate	=  " wd";
			//public const string CurrencyDate	=  " cd";
			//public const string Archived		=  " ar";
			//public const string Selected		=  " sl";
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors(  0 ),		//PkPerson
			new ColumnFactors(  1 ),		//SortableName
			new ColumnFactors(  2 ),		//NaturalName
			new ColumnFactors(  3 ),		//UpperSurname
			new ColumnFactors(  4 ),		//ProperSurnam
			new ColumnFactors(  5 ),		//GivenName
			new ColumnFactors(  6 ),		//MiddleNames
			new ColumnFactors(  7 ),		//NickName
			new ColumnFactors(  8 ),		//BirthName
			new ColumnFactors(  9 ),		//Prefix
			new ColumnFactors( 10 ),		//Suffix
			new ColumnFactors( 11 ),		//Initials
			new ColumnFactors( 12 ),		//Gender
			new ColumnFactors( 13 ),		//Notes
			new ColumnFactors( 14 ),		//BirthDate
			new ColumnFactors( 15 ),		//DeathDate
			new ColumnFactors( 16 ),		//WeddingDate
			new ColumnFactors( 17 )			//CurrencyDate
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
