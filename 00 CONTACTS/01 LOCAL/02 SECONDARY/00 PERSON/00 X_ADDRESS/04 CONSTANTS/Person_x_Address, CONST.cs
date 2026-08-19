//___________________________________________________________________________________________________________________________________________________
using FACTORS = CONTACTS.GLOBAL.TOOLS.ColumnFactors;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 5;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkPerson_X_Address	= 0;
			public const int FkPerson			= 1;
			public const int FkAddress			= 2;
			public const int AddressType		= 3;
			public const int Selected			= 4;
		}
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =
		{
			"pk_Person_X_Address",
			"fk_Person",
			"fk_Address",
			"st_AddressType",
			"is_Selected"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_person_x_address",
			"@fk_person",
			"@fk_address",
			"@st_addresstype",
			"@is_selected"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,	//PkPerson_X_Address
			4,	//FkPerson
			4,	//FkAddress
			25,	//StAddressType
			1	//IsSelected
		};
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static FACTORS[] Factors =
		{
			new FACTORS(  0, FieldWidths[ 0], FieldNames[ 0], ParameterNames[ 0] ), //PkPerson_X_Address
			new FACTORS(  1, FieldWidths[ 1], FieldNames[ 1], ParameterNames[ 1] ), //FkPerson
			new FACTORS(  2, FieldWidths[ 2], FieldNames[ 2], ParameterNames[ 2] ), //FkAddress
			new FACTORS(  3, FieldWidths[ 3], FieldNames[ 3], ParameterNames[ 3] ), //StAddressType
			new FACTORS(  4, FieldWidths[ 4], FieldNames[ 4], ParameterNames[ 4] ), //IsSelected
		};
		#endregion
	}
}
