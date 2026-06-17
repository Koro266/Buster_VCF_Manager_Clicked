//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 5;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkPerson_X_Eddress	= 0;
			public const int FkPerson			= 1;
			public const int FkEddress			= 2;
			public const int ListOrder			= 3;
			public const int Label				= 4;
		}
		//___________________________________________________________________________________________________________________________________		
		public static int[] OrdinalByValue =
		{
			0,	//PkPerson_X_Eddress
			1,	//FkPerson
			2,	//FkEddress
			3,	//StListOrder
			4	//StLabel
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Names =
		{
			"Person_X_Eddress",
			"Person",
			"Eddress",
			"ListOrder",
			"Label"
		};
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =
		{
			"pk_Person_X_Eddress",
			"fk_Person",
			"fk_Eddress",
			"st_ListOrder",
			"st_Label"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_person_x_eddress",
			"@fk_person",
			"@fk_eddress",
			"@st_listorder",
			"@st_label"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,	//PkPerson_X_Eddress
			4,	//FkPerson
			4,	//FkEddress
			1,	//StListOrder
			15	//StLabel
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"Primary Key, AutoNum, int.",
			"FK into TDF_Persons.pk_Person. Required=Yes.",
			"FK into TDF_Eddresses.pk_Eddress. Required=Yes.",
			"Text field expects single-digit numerical values. Determines ordering of eddesses in the VCF card. Eddress no. 1 is deemed to be the preferred eddress.",
			"Text used as the eddress label in the VCF file. FkEddress is appended to this: an.eddress@gmail.com{fk_eddress}. Typically lower cased."
		};
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkPerson_X_Eddress	="/pk";
			public const string FkPerson			="/fp";
			public const string FkEddress			="/fe";
			public const string ListOrder			="/lo";
			public const string Label				="/lb";
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),	//PkPerson_X_Eddress
			new ColumnFactors( 1),	//FkPerson
			new ColumnFactors( 2),	//FkEddress
			new ColumnFactors( 3),	//ListOrder
			new ColumnFactors( 4)	//Label
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
