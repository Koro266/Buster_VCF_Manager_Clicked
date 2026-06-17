//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 4;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkFamily_X_Address	= 0;
			public const int FkFamily			= 1;
			public const int FkAddress			= 2;
			public const int AddressType		= 3;
		}
		//___________________________________________________________________________________________________________________________________		
		public static int[] OrdinalByValue =
		{
			0,	//PkFamily_X_Address
			1,	//FkFamily
			2,	//FkAddress
			3	//StAddressType
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Names =
		{
			"Family_X_Address",
			"Family",
			"Address",
			"AddressType"
		};
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =
		{
			"pk_Family_X_Address",
			"fk_Family",
			"fk_Address",
			"st_AddressType"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_family_x_address",
			"@fk_family",
			"@fk_address",
			"@st_addresstype"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,	//PkFamily_X_Address
			4,	//FkFamily
			4,	//FkAddress
			25	//StAddressType
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"Primary Key, AutoNum, int.",
			"FK into TDF_Familys. Required=Yes.",
			"FK into TDF_Addresses. Required=Yes.",
			"HOME, WORK, BOTH (home & work), HOLIDAY, OTHER. This field may not be retained."
		};
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkFamily_X_Address	="/pk";
			public const string FkFamily			="/fp";
			public const string FkAddress			="/fa";
			public const string StAddressType		="/at";
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),	//PkFamily_X_Address
			new ColumnFactors( 1),	//FkFamily
			new ColumnFactors( 2),	//FkAddress
			new ColumnFactors( 3)	//StAddressType
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
