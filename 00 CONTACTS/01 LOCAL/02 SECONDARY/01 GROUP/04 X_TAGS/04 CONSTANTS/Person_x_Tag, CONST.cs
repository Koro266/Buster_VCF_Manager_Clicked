//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XTAG
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 6;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkGroup_X_Tag = 0;
			public const int PkGroup			= 1;
			public const int PkSuperTag			= 2;
			public const int PkSubTag			= 3;
			public const int SuperTag			= 4;
			public const int SubTag				= 5;
		}
		//___________________________________________________________________________________________________________________________________		
		public static int[] OrdinalByValue =
		{
			0,	//PkGroup_X_Tag
			1,	//PkGroup
			2,	//PkSuperTag
			3,	//PkSubTag
			4,	//SuperTag
			5	//SubTag
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Names =
		{
			"PkGroup_X_Tag",
			"PkGroup",
			"PkSuperTag",
			"PkSubTag",
			"SuperTag",
			"SubTag"
		};
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =
		{
			"pk_Group_X_Tag",
			"pk_Group",
			"pk_Tag",
			"pk_Tag",
			"st_TagText",
			"st_TagText"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_group_x_tag",
			"@pk_group",
			"@pk_tag",
			"@pk_tag",
			"@st_tagtext",
			"@st_tagtext"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkGroup_X_Tag
			4,		//PkGroup
			4,		//PkSuperTag
			4,		//PkSubTag
			80,		//SuperText
			80		//SubText
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"PkGroup_X_Tag",
			"PkGroup",
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
