//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XWEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 5;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkPerson_X_Website	= 0;
			public const int FkPerson			= 1;
			public const int FkWebsite			= 2;
			public const int Website			= 3;
			public const int Notes				= 4;
		}
		//___________________________________________________________________________________________________________________________________		
		public static int[] OrdinalByValue =
		{
			0,	//PkPerson_X_Website
			1,	//FkPerson
			2,	//FkWebsite
			3,	//StWebsite
			4	//StNotes
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Names =
		{
			"Person_X_Website",
			"Person",
			"Website",
			"Website",
			"Notes"
		};
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =
		{
			"pk_Person_X_Website",
			"fk_Person",
			"fk_Website",
			"st_Website",
			"st_Notes"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_person_x_eddress",
			"@fk_person",
			"fk_website",
			"st_website",
			"st_notes"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,	//PkPerson_X_Website
			4,	//FkPerson
			4,	//FkWebsite
			1,	//StWebsite
			15	//StNotes
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"Primary Key, AutoNum, int.",
			"FK into TDF_Persons.pk_Person. Required=Yes.",
			"FK into TDF_Websitees.pk_Website. Required=Yes.",
			"Text field expects single-digit numerical values. Determines ordering of eddesses in the VCF card. Website no. 1 is deemed to be the preferred eddress.",
			"Text used as the eddress label in the VCF file. FkWebsite is appended to this: an.eddress@gmail.com{fk_eddress}. Typically lower cased."
		};
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkPerson_X_Website	="/pk";
			public const string FkPerson			="/fp";
			public const string FkWebsite			="/fw";
			public const string Website				="/wb";
			public const string Notes				="/nt";
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),	//PkPerson_X_Website
			new ColumnFactors( 1),	//FkPerson
			new ColumnFactors( 2),	//FkWebsite
			new ColumnFactors( 3),	//Website
			new ColumnFactors( 4)	//Notes
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
