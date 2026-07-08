//___________________________________________________________________________________________________________________________________________________
using FACTORS = CONTACTS.GLOBAL.TOOLS.ColumnFactors;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 14;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
<<<<<<< HEAD
			public const int PkGroup = 0;
			public const int GroupName = 1;
			public const int GroupType = 2;
			public const int Notes = 3;
			public const int CurrencyDate = 4;
			public const int Selected = 5;
			public const int DefaultRow = 6;
			public const int Export = 7;
			public const int Blocked = 8;
			public const int Inactive = 9;
			public const int StTheresa = 10;
			public const int Tradesman = 11;
			public const int Supplier = 12;
			public const int Writer = 13;
=======
			public const int PkGroup		= 0;
			public const int GroupName		= 1;
			public const int GroupType		= 2;
			public const int Notes			= 3;
			public const int CurrencyDate	= 4;
			public const int Selected		= 5;
			public const int DefaultRow		= 6;
			public const int Export			= 7;
			public const int Blocked		= 8;
			public const int Inactive		= 9;
			public const int StTheresa		= 10;
			public const int Tradesman		= 11;
			public const int Supplier		= 12;
			public const int Writer			= 13;
>>>>>>> frm_group
		}
		//_______________________________________________________________________________________________________________________________________
		public static string[] FieldNames =
		{
			"pk_Group",
			"st_GroupName",
			"st_GroupType",
			"st_Notes",
			"dt_CurrencyDate",
			"is_Selected",
			"is_DefaultRow",
			"is_Export",
			"is_Blocked",
			"is_Inactive",
			"is_StTheresa",
			"is_Tradesman",
			"is_Supplier",
			"is_Writer"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_group",
			"@st_groupname",
			"@st_grouptype",
			"@st_notes",
			"@dt_currencydate",
			"@is_selected",
			"@is_defaultrow",
			"@is_export",
			"@is_blocked",
			"@is_inactive",
			"@is_sttheresa",
			"@is_tradesman",
			"@is_supplier",
			"@is_writer"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,		//PkGroup
			255,	//StGroupName
			50,		//StGroupType
			255,	//StNotes
			8,		//DtCurrencyDate
			1,		//IsSelected
			1,		//IsDefaultRow
			1,		//IsExport
			1,		//IsBlocked
			1,		//IsInactive
			1,		//IsStTheresa
			1,		//IsTradesman
			1,		//IsSupplier
			1,		//IsWriter
		};
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static FACTORS[] Factors =
		{
			new FACTORS(  0, FieldWidths[ 0], FieldNames[ 0], ParameterNames[ 0] ), //PkGroup
			new FACTORS(  1, FieldWidths[ 1], FieldNames[ 1], ParameterNames[ 1] ), //StGroupName
			new FACTORS(  2, FieldWidths[ 2], FieldNames[ 2], ParameterNames[ 2] ), //StGroupType
			new FACTORS(  3, FieldWidths[ 3], FieldNames[ 3], ParameterNames[ 3] ), //StNotes
			new FACTORS(  4, FieldWidths[ 4], FieldNames[ 4], ParameterNames[ 4] ), //DtCurrencyDate
			new FACTORS(  5, FieldWidths[ 5], FieldNames[ 5], ParameterNames[ 5] ), //IsSelected
			new FACTORS(  6, FieldWidths[ 6], FieldNames[ 6], ParameterNames[ 6] ), //IsDefaultRow
			new FACTORS(  7, FieldWidths[ 7], FieldNames[ 7], ParameterNames[ 7] ), //IsExport
			new FACTORS(  8, FieldWidths[ 8], FieldNames[ 8], ParameterNames[ 8] ), //IsBlocked
			new FACTORS(  9, FieldWidths[ 9], FieldNames[ 9], ParameterNames[ 9] ), //IsInactive
			new FACTORS( 10, FieldWidths[10], FieldNames[10], ParameterNames[10] ), //IsStTheresa
			new FACTORS( 11, FieldWidths[11], FieldNames[11], ParameterNames[11] ), //IsTradesman
			new FACTORS( 12, FieldWidths[12], FieldNames[12], ParameterNames[12] ), //IsSupplier
			new FACTORS( 13, FieldWidths[13], FieldNames[13], ParameterNames[13] )  //IsWriter
		};
		#endregion
	}
}
