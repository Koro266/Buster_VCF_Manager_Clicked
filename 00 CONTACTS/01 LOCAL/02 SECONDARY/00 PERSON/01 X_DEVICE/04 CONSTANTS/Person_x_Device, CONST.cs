//___________________________________________________________________________________________________________________________________________________

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public class Constants
	{
		public const int ColumnCount = 5;

		#region LISTS
		//_______________________________________________________________________________________________________________________________________
		public class OrdinalByName
		{
			public const int PkPerson_X_Device	= 0;
			public const int FkPerson			= 1;
			public const int FkDevice			= 2;
			public const int ListOrder			= 3;
			public const int Label				= 4;
		}
		//___________________________________________________________________________________________________________________________________		
		public static int[] OrdinalByValue =
		{
			0,	//PkPerson_X_Device
			1,	//FkPerson
			2,	//FkDevice
			3,	//StListOrder
			4	//StLabel
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Names =
		{
			"PkPerson_X_Device",
			"FkPerson",
			"FkDevice",
			"ListOrder",
			"Label"
		};
		//___________________________________________________________________________________________________________________________________	
		public static string[] FieldNames =
		{
			"pk_Person_X_Device",
			"fk_Person",
			"fk_Device",
			"st_ListOrder",
			"st_Label"
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] ParameterNames =
		{
			"@pk_person_x_device",
			"@fk_person",
			"@fk_device",
			"@st_listorder",
			"@st_label"
		};
		//_______________________________________________________________________________________________________________________________________
		public static int[] FieldWidths =
		{
			4,	//PkPerson_X_Device
			4,	//FkPerson
			4,	//FkDevice
			1,	//StListOrder
			15	//StLabel
		};
		//_______________________________________________________________________________________________________________________________________
		public static string[] Prompts =
		{
			"Primary Key, AutoNum, int.",
			"FK into TDF_Persons. Required=Yes.",
			"FK into TDF_Devices. Required=Yes.",
			"Single-digit number determines ordering of devices in the VCF. Device no. 1 is deemed to be the preferred device.",
			"Text used as the device label in VCF. Typically lower-cased."
		};
		//_______________________________________________________________________________________________________________________________________
		public static class Reconstruction
		{
			public const string PkPerson_X_Device	="/pk";
			public const string FkPerson			="/fp";
			public const string FkDevice			="/fd";
			public const string ListOrder			="/lo";
			public const string Label				="/lb";
		}
		#endregion


		#region COLUMN FACTORS
		//_______________________________________________________________________________________________________________________________________
		public static ColumnFactors[] Factors =
		{
			new ColumnFactors( 0),	//Person_X_Device
			new ColumnFactors( 1),	//Person
			new ColumnFactors( 2),	//Device
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
