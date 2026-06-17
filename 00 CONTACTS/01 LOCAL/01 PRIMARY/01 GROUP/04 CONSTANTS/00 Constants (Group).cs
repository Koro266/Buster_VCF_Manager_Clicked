//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 5;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkGroup		= 0;
			public const int GroupName		= 1;
			public const int GroupType		= 2;
			public const int Notes			= 3;
			public const int CurrencyDate	= 4;
		}
		//_______________________________________________________________________________________________________________________________________
		public static int[] OrdinalByValue =
		{
			0,	//PkGroup
			1,	//StGroupName
			2,	//StGroupType
			3,	//StNotes
			4,	//DtCurrencyDate
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] FieldNames =
		{
			"pk_Group",
			"st_GroupName",
			"st_GroupType",
			"st_Notes",
			"dt_CurrencyDate"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_group",
			"@st_groupname",
			"@st_grouptype",
			"@st_notes",
			"@dt_currencydate"
			};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkGroup
			255,	//StGroupName
			50,		//StGroupType
			255,	//StNotes
			8		//DtCurrencyDate
		};
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkGroup			="/pk";
			public const string StGroupName		="/gn";
			public const string StGroupType		="/gt";
			public const string StNotes			="/nt";
			public const string DtCurrencyDate	="/dt";
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0 ),		//PkGroup
			new ColumnFactors( 1 ),		//StGroupName
			new ColumnFactors( 2 ),		//StGroupType
			new ColumnFactors( 3 ),		//StNotes
			new ColumnFactors( 4 )		//DtCurrencyDate
		};
		//_______________________________________________________________________________________________________________________________________
		public class ColumnFactors
		{
			private int		i_Ordinal;
			private string	s_FieldName;
			private string	s_ParameterName;
			private int		i_FieldWidth;

			//___________________________________________________________________________________________________________________________________
			public ColumnFactors( int ordinal )
			{
				this.i_Ordinal			= ordinal;
				this.s_FieldName		= FieldNames[ordinal];
				this.s_ParameterName	= ParameterNames[ordinal];
				this.i_FieldWidth		= FieldWidths[ordinal];
			}
			//___________________________________________________________________________________________________________________________________
			public int Ordinal			{ get { return i_Ordinal; } }
			public string FieldName		{ get { return s_FieldName; } }
			public string ParameterName	{ get { return s_ParameterName; } }
			public int FieldWidth		{ get { return i_FieldWidth; } }
		}
		#endregion
	}
}
