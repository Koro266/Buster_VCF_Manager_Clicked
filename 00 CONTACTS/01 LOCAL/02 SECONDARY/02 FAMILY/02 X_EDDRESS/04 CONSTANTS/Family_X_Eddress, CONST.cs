//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 4;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkFamily_X_Eddress	= 0;
			public const int FkFamily			= 1;
			public const int FkEddress			= 2;
			public const int Eddress				= 3;
		}
		//___________________________________________________________________________________________________________________________________		
		public static int[] OrdinalByValue =
		{
			0,	//PkFamily_X_Eddress
			1,	//FkFamily
			2,	//FkEddress
			3	//StEddress
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Names =
		{
			"Family_X_Eddress",
			"Family",
			"Eddress",
			"Eddress"
		};
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =
		{
			"pk_Family_X_Eddress",
			"fk_Family",
			"fk_Eddress",
			"st_Eddress"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_person_x_eddress",
			"@fk_person",
			"@fk_eddress",
			"@st_label"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,	//PkFamily_X_Eddress
			4,	//FkFamily
			4,	//FkEddress
			15	//StEddress
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"Primary Key, AutoNum, int.",
			"FK into TDF_Familys.pk_Family. Required=Yes.",
			"FK into TDF_Eddresses.pk_Eddress. Required=Yes.",
			"Text field expects single-digit numerical values. Determines ordering of eddesses in the VCF card. Eddress no. 1 is deemed to be the preferred eddress.",
			"Text used as the eddress label in the VCF file. FkEddress is appended to this: an.eddress@gmail.com{fk_eddress}. Typically lower cased."
		};
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkFamily_X_Eddress	="/pk";
			public const string FkFamily			="/fp";
			public const string FkEddress			="/fe";
			public const string Eddress				="/lb";
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),	//PkFamily_X_Eddress
			new ColumnFactors( 1),	//FkFamily
			new ColumnFactors( 2),	//FkEddress
			new ColumnFactors( 3)	//Eddress
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
