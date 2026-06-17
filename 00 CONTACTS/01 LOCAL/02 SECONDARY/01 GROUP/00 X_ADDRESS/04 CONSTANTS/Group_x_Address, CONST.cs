//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 3;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkGroup_X_Address	= 0;
			public const int FkGroup			= 1;
			public const int FkAddress			= 2;
//			public const int AddressType		= 3;
		}
		//___________________________________________________________________________________________________________________________________		
		public static int[] OrdinalByValue =
		{
			0,	//PkGroup_X_Address
			1,	//FkGroup
			2,	//FkAddress
//			3	//StAddressType
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Names =
		{
			"pk_Group_X_Address",
			"fk_Group",
			"fk_Address",
//			"AddressType"
		};
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =
		{
			"pk_Group_X_Address",
			"fk_Group",
			"fk_Address",
//			"st_AddressType"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_group_x_address",
			"@fk_group",
			"@fk_address",
//			"@st_addresstype"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,	//PkGroup_X_Address
			4,	//FkGroup
			4,	//FkAddress
//			25	//StAddressType
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"Primary Key, AutoNum, int.",
			"FK into TDF_Groups. Required=Yes.",
			"FK into TDF_Addresses. Required=Yes.",
//			"HOME, WORK, BOTH (home & work), HOLIDAY, OTHER. This field may not be retained."
		};
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkGroup_X_Address	="/pk";
			public const string FkGroup			="/fp";
			public const string FkAddress			="/fa";
//			public const string StAddressType		="/at";
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),	//PkGroup_X_Address
			new ColumnFactors( 1),	//FkGroup
			new ColumnFactors( 2)	//FkAddress
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
