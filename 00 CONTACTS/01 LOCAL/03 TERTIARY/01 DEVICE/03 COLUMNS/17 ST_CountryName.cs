//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using SHORT_TXT	= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using NULL_TEXT = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
using FACTORS	= CONTACTS.GLOBAL.TOOLS.ColumnFactors;
//LOCAL
using CONST		= CONTACTS.LOCAL.TERTIARY.DEVICE.Constants;
using ORDINAL	= CONTACTS.LOCAL.TERTIARY.DEVICE.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class ST_CountryName : SHORT_TXT
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.CountryName];
			private static string no_VCF_Value = "cn";
			private static string no_FINDER_Value = "cn";
			private NULL_TEXT type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public ST_CountryName( string value ) : base( value )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public ST_CountryName( NULL_TEXT tnp ) : base( tnp )
			{
				type_null_pair = tnp;
			}
			#endregion


			#region METHODS
			//_______________________________________________________________________________________________________________________________________
			public FACTORS Factors
			{
				get { return column_factors; }
			}
			//_______________________________________________________________________________________________________________________________________
			public int Ordinal
			{
				get { return Factors.Ordinal; }
			}
			//_______________________________________________________________________________________________________________________________________
			override public string ToString()
			{
				return base.Value;
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns value formatted for use in a Find this-or-that context.
			/// </summary>
			override public string FinderValue
			{
				get { return base.FinderValue == String.Empty ? no_FINDER_Value : base.AsIs; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns ExcelPattern as used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.VcfValue == String.Empty ? no_VCF_Value : base.AsIs; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns a value that is displayed in a TextBox.
			/// </summary>
			override public string TextboxValue
			{
				get { return base.TextboxValue == String.Empty ? String.Empty : base.AsIs; }
			}
			#endregion


			#region DB INTERFACE
			//_______________________________________________________________________________________________________________________________________
			override public OleDbParameter DbParameter
			{
				get
				{
					OleDbParameter parameter = base.DbParameter;
					parameter.ParameterName = Factors.ParameterName;
					parameter.Size = Factors.FieldWidth;
					parameter.Value = base.DbWriteValue;
					return parameter;
				}
			}
			#endregion
		}
	}
}
