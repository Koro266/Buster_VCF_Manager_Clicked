
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.COLUMN;
using ST = CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.VALUES.CONSTANT
{
	//___________________________________________________________________________________________________________________________________________
	public static class Regexs
	{
		public const string IsPositiveInteger	= @"^[0-9]+$";
	}
	//___________________________________________________________________________________________________________________________________________
	public static class LikeCriteria
	{
		public const string AcceptAll			= "%";				//Accepts any characters
		public const string Dot					= ".";				//If the user input is '.', all values that are non-blank values are included. 
		public const string SelectiveNotBlank	= "%[a-zA-Z0-9]%";  //The LIKE criteria for "Accept all non-blank values".
		public const string LikeParameterName	= "@subtext";
	}
	//___________________________________________________________________________________________________________________________________________
	public static class Words
	{
		public static ST Person					= new ST( "Person" );
		public static ST Group					= new ST( "Group" );
		public static ST Family					= new ST( "Family" );
		public static ST Persons				= new ST( "Persons" );
		public static ST Groups					= new ST( "Groups" );
		public static ST Families				= new ST( "Families" );

		public static ST ZeroCount				= new ST( "Count=0" );
		public static ST PkNotAvailable			= new ST( "PK:NA" );
		public static ST Done					= new ST( "Done" );
		public static ST Start					= new ST( "Start" );
		public static ST DonePersons			= new ST( "Done Persons" );
		public static ST DoneFamilies			= new ST( "Done Families" );
		public static ST DoneGroups				= new ST( "Done Groups" );
		public static ST NoRole					= new ST( "No role..." );
		public static ST Working				= new ST( "Working..." );

		public static ST Male					= new ST( "Male" );
		public static ST Female					= new ST( "Female" );
		public static ST Unknown				= new ST( "Unknown" );

		public static ST True					= new ST( "True" );		//Female, Yes, True
		public static ST False					= new ST( "False" );	//Male, No, False
		public static ST Yes					= new ST( "Yes" );
		public static ST No						= new ST( "No" );
		public static ST On						= new ST( "On" );
		public static ST Off					= new ST( "Off" );
		public static ST Ex						= new ST( "X" );

	}
	//___________________________________________________________________________________________________________________________________________
	public static class Preset
	{
		//'Signal' values.
		public const int ZERO					= 0;
		public const int MINUS_ONE				= -1;
		public const int NoItemSelected			= -1;	//Some controls return this value if no item is selected.

		//'Punctuation', special characters.
		public const string ZLS					= "";
		public const string Dot					= ".";
		public const string TwoDots				= "..";
		public const string AmperSpaces			= " & ";
		public const string OneSpace			= " ";
		public const string OneAster			= "*";
		public const string TwoAsters			= "**";
		public const string TwoDashes			= "--";
		public const string Comma				= ",";
		public const string CommaSpace			= ", ";
		public const string Semicolon			= ";";
		public const string Tilde				= "~";
		public const string FauxTab				= "     ";  //5 spaces

		//Replacement characters.
		public const string S0					= "#0";
		public const string S1					= "#1";
		public const string S2					= "#2";
		public const string S3					= "#3";
		public const string S4					= "#4";
		public const string S5					= "#5";
		public const string S6					= "#6";
		public const string S7					= "#7";
		public const string S8					= "#8";
		public const string S9					= "#9";

		//Line terminations, intercalations.
		public const string Functional_LF		= @"\n";
		public const string Functional_TAB		= @"\t";
		public const string Functional_CRLF		= @"\r\n";
		public const string Functional_LFLF		= @"\n\n";
		public const string Literal_LF			= @"\\n";
		public const string Literal_TAB			= @"\\t";
		public const string LiteralDoubleSpace	= @"\\n\\n";
		public const string Literal_CRLF		= @"\\r\\n";
	}
}
