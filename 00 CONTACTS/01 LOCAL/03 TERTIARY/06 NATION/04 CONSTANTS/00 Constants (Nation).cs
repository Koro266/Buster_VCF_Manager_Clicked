//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.NATION
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 6;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkCountry		= 0;
			public const int Order			= 1;
			public const int CountryName	= 2;
			public const int CountryCode	= 3;
			public const int ShortIsoCode	= 4;
			public const int LongIsoCode	= 5;
		}
		//_______________________________________________________________________________________________________________________________________
		public static int[] OrdinalByValue =
		{
			0,	//PkCountry
			1,	//Order
			2,	//CountryName
			3,	//CountryCode
			4,	//ShortIsoCode
			5,	//LongIsoCode
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] FieldNames =
		{
			"pk_Country",
			"si_Order",
			"st_CountryName",
			"st_CountryCode",
			"st_ShortIsoCode",
			"st_LongIsoCode",
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_country",
			"@si_order",
			"@st_countryname",
			"@st_countrycode",
			"@st_shortisocode",
			"@st_longisocode",
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkCountry
			2,		//Order
			100,	//CountryName
			5,		//CountryCode
			2,		//ShortIsoCode
			3,		//LongIsoCode
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"Primary Key,  int. TDF_Countries.pk_Country = 0 is New Zealand. All countries (count = 240) are included in this table.",
			"Specifies the presentation order of the list. That is, the order that country names appear in a list. Does NOT match alphabetical, by country name, order.",
			"ISO standard, i.e., conventionally accepted, name of the country.",
			"ISO telecommunications code of the country. NZ = 64.",
			"Two-character ISO code of the country. New Zealand = 'NZ'.",
			"Three-character ISO code of the country. New Zealand = 'NZL'.",
		};
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkCountry		="/pk";
			public const string Order			="/od";
			public const string CountryName		="/lc";
			public const string CountryCode		="/sc";
			public const string ShortIsoCode	="/ld";
			public const string LongIsoCode		="/td";
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),	//PkCountry
			new ColumnFactors( 1),	//Order
			new ColumnFactors( 2),	//CountryName
			new ColumnFactors( 3),	//CountryCode
			new ColumnFactors( 4),	//ShortIsoCode
			new ColumnFactors( 5),	//LongIsoCode
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
