//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 6;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkPerson_X_Family	= 0;
			public const int PkPerson			= 1;
			public const int PkFamily			= 2;
			public const int PkRole				= 3;
			public const int FamilyName			= 4;
			public const int Role				= 5;
		}
		//___________________________________________________________________________________________________________________________________		
		public static int[] OrdinalByValue =
		{
			0,	//PkPerson_X_Family
			1,	//PkPerson
			2,	//PkFamily
			3,	//PkRole
			4,	//FamilyName
			5	//Role
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Names =
		{
			"PkPerson_X_Family",
			"PkPerson",
			"PkFamily",
			"PkRole",
			"FamilyName",
			"Role"
		};
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =
		{
			"pk_Person_X_Family",
			"pk_Person",
			"pk_Family",
			"pk_Role",
			"st_FamilyName",
			"st_Role"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_person_x_family",
			"@pk_person",
			"@pk_family",
			"@pk_role",
			"@st_familyname",
			"@st_role"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkPerson_X_Family
			4,		//PkPerson
			4,		//PkSuperFamily
			4,		//PkSubFamily
			80,		//SuperText
			80		//SubText
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"PkPerson_X_Family",
			"PkPerson",
			"PkFamily",
			"PkRole",
			"FamilyName",
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
