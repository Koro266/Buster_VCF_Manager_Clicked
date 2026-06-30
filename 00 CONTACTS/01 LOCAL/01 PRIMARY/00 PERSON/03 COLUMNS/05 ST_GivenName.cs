//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using SHORT_TXT	= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using NULL_TEXT = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
using FACTORS	= CONTACTS.GLOBAL.TOOLS.ColumnFactors;
//LOCAL
using CONST		= CONTACTS.LOCAL.PRIMARY.PERSON.Constants;
using ORDINAL	= CONTACTS.LOCAL.PRIMARY.PERSON.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class ST_GivenName : SHORT_TXT
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.GivenName];
			private NULL_TEXT type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public ST_GivenName( string value ) : base( value )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public ST_GivenName( NULL_TEXT tnp ) : base( tnp )
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
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns value that is sent to the database.
			/// </summary>
			override public object DbWriteValue
			{
				get { return base.DbWriteValue; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is displayed in a TextBox.
			/// </summary>
			override public string TextboxValue
			{
				get { return base.TextboxValue; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns GivenName as used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.AsIs; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true if person has a valid GivenName value.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return base.IsNotAbsoluteNull; }
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
