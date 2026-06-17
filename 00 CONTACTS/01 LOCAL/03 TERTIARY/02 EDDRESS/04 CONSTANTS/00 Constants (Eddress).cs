//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.EDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 4;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkEddress		= 0;
			public const int Eddress		= 1;
			public const int EddressType	= 2;
			public const int Notes			= 3;
		}
		//_______________________________________________________________________________________________________________________________________
		public static int[] OrdinalByValue =
		{
			0,	//PkEddress
			1,	//Eddress
			2,	//EddressType
			3	//Notes
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] FieldNames =
		{
			"pk_Eddress",
			"st_Eddress",
			"st_EddressType",
			"st_Notes"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_eddress",
			"@st_eddress",
			"@st_eddresstype",
			"@st_notes"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkEddress
			255,	//Eddress
			15,		//EddressType
			255		//Notes
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"Primary Key, AutoNum, int",
			"Email address.",
			"PERSONAL;WORK;GENERIC;VOID",
			"Generic text field. Usually an conventional identifier (name) of the entity."
		};
		#endregion


		#region NON-ORDINAL CONSTANTS
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkEddress	="/pk";
			public const string Eddress		="/ed";
			public const string EddressType	="/et";
			public const string Notes		="/nt";
		}
		//___________________________________________________________________________________________________________________________________________
		public static class Reminders
		{
			public static readonly string[] Now				= { "Sets the Currency date to Now()." };
			public static readonly string[] Filter			= { "Filter by PkEddress: enter integer value, hit RETURN." };
			public static readonly string[] FirstEddress	= { "Moves the position of the row cursor to the first Eddress (MinPK) in TDF_Eddresss." };
			public static readonly string[] NextEddress		= { "Moves the position of the row cursor to the row with the next higher PkEddress in TDF_Eddresss.", "Does not move beyond Max PK." };
			public static readonly string[] PreviousEddress	= { "Moves the position of the row cursor to the row with the next lower TDF_Eddress in TDF_Eddresss.", "Does not move beyond Min PK." };
			public static readonly string[] LastEddress		= { "Moves the position of the row cursor to the last (Max PK) Eddress in TDF_Eddresss." };
			public static readonly string[] UpdateEddress	= { "Overwrites entire TDF_Eddresss row with values displayed on the form." };
			public static readonly string[] InsertEddress	= { "Adds (copies) a row to TDF_Eddresss and populates the row with values currently displayed on the form." };
			public static readonly string[] FindEddress		= { "Opens the Find Eddress form. Form makes available additional search options." };
			public static readonly string[] MatchesEddress	= { "Searches for devices based on the trailing digits." };
			public static readonly string[] CloseForm		= { "Closes form.", "Unsaved changes are lost." };
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),	//PkEddress
			new ColumnFactors( 1),	//Eddress
			new ColumnFactors( 2),	//EddressType
			new ColumnFactors( 3)	//Notes
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
