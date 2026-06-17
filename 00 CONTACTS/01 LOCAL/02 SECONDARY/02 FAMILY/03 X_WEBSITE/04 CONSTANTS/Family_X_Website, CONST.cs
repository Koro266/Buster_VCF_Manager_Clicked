//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XWEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 4;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkFamily_X_Website	= 0;
			public const int FkFamily			= 1;
			public const int FkWebsite			= 2;
			public const int Website			= 3;
		}
		//___________________________________________________________________________________________________________________________________		
		public static int[] OrdinalByValue =
		{
			0,	//PkFamily_X_Website
			1,	//FkFamily
			2,	//FkWebsite
			3	//StWebsite
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Names =
		{
			"Family_X_Website",
			"Family",
			"Website",
			"Website"
		};
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =
		{
			"pk_Family_X_Website",
			"fk_Family",
			"fk_Website",
			"st_Website"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pkgroup_x_website",
			"@fk_group",
			"@fk_website",
			"@st_website"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkFamily_X_Website
			4,		//FkFamily
			4,		//FkWebsite
			255		//StWebsite
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"Primary Key, AutoNum, int.",
			"FK into TDF_Familys.pk_Family. Required=Yes.",
			"FK into TDF_Websitees.pk_Website. Required=Yes.",
			"Text field expects single-digit numerical values. Determines ordering of eddesses in the VCF card. Website no. 1 is deemed to be the preferred eddress.",
		};
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkFamily_X_Website	="/pk";
			public const string FkFamily				="/fg";
			public const string FkWebsite			="/fw";
			public const string Website				="/wb";
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),	//PkFamily_X_Website
			new ColumnFactors( 1),	//FkFamily
			new ColumnFactors( 2),	//FkWebsite
			new ColumnFactors( 3)	//Website
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
