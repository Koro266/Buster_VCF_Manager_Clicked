//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 6;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkGroup_X_Person	= 0;
			public const int PkGroup			= 1;
			public const int PkPerson			= 2;
			public const int PkRole				= 3;
			public const int PersonName			= 4;
			public const int Role				= 5;
		}
		//___________________________________________________________________________________________________________________________________		
		public static int[] OrdinalByValue =
		{
			0,	//PkGroup_X_Person	
			1,	//PkGroup			
			2,	//PkPerson			
			3,	//PkRole				
			4,	//PersonName			
			5	//Role				
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Names =
		{
			"PkGroup_X_Person",
			"PkGroup",
			"PkPerson",
			"PkRole",
			"PersonName",
			"Role"
		};
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =
		{
			"pk_Group_X_Person",
			"pk_Group",
			"pk_Person",
			"pk_Role",
			"st_PersonName",
			"st_Role"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_group_x_person",
			"@pk_group",
			"@pk_person",
			"@pk_role",
			"@st_personname",
			"@st_role"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkGroup_X_Person	
			4,		//PkGroup			
			4,		//PkPerson			
			4,		//PkRole			
			80,		//PersonName		
			80		//Role				
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"PkGroup_X_Person",
			"PkPerson",
			"PkGroup",
			"PkRole",
			"GroupName",
			"Role"
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
