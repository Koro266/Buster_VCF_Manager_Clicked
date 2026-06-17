//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XTAG
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 6;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkPerson_X_Tag = 0;
			public const int PkPerson			= 1;
			public const int PkSuperTag			= 2;
			public const int PkSubTag			= 3;
			public const int SuperTag			= 4;
			public const int SubTag				= 5;
		}
		//___________________________________________________________________________________________________________________________________		
		public static int[] OrdinalByValue =
		{
			0,	//PkPerson_X_Tag
			1,	//PkPerson
			2,	//PkSuperTag
			3,	//PkSubTag
			4,	//SuperTag
			5	//SubTag
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Names =
		{
			"PkPerson",
			"PkPerson_X_Tag",
			"PkSuperTag",
			"PkSubTag",
			"SuperTag",
			"SubTag"
		};
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =
		{
			"pk_Person",
			"pk_Person_X_Tag",
			"pk_Tag",
			"pk_Tag",
			"st_TagText",
			"st_TagText"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_person",
			"@pk_person_x_tag",
			"@pk_tag",
			"@pk_tag",
			"@st_tagtext",
			"@st_tagtext"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkPerson
			4,		//PkPerson_X_Tag
			4,		//PkSuperTag
			4,		//PkSubTag
			80,		//SuperText
			80		//SubText
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"PkPerson",
			"PkPerson_X_Tag",
			"PkSuperTag",
			"PkSubTag",
			"SuperText",
			"SubText"
		};
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),
			new ColumnFactors( 1),
			new ColumnFactors( 2),
			new ColumnFactors( 3),
			new ColumnFactors( 4),
			new ColumnFactors( 5)
		};
		//_______________________________________________________________________________________________________________________________________
		public class ColumnFactors
		{
			private int		i_Ordinal;
			private	string	s_FieldName;
			private	string	s_ParameterName;
			private	int		i_FieldWidth;
			private	string	s_Prompt;

			//___________________________________________________________________________________________________________________________________
			public ColumnFactors( int ordinal )
			{
				this.i_Ordinal		 = ordinal;
				this.s_FieldName	 = FieldNames[ordinal];
				this.s_ParameterName = ParameterNames[ordinal];
				this.i_FieldWidth	 = FieldWidths[ordinal];
				this.s_Prompt		 = Prompts[ordinal];
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
