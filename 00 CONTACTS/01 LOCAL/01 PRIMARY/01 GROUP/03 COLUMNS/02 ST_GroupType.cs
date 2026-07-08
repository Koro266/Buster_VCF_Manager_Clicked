//___________________________________________________________________________________________________________________________________________________
using CONTACTS.GLOBAL;
using System.Data.OleDb;
//LOCAL
using CONST		= CONTACTS.LOCAL.PRIMARY.GROUP.Constants;
using FACTORS	= CONTACTS.LOCAL.PRIMARY.GROUP.Constants.ColumnFactors;
using NULL_TEXT = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
using ORDINAL	= CONTACTS.LOCAL.PRIMARY.GROUP.Constants.OrdinalByName;
//GLOBAL
using SHORT_TXT = CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class ST_GroupType : SHORT_TXT
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.GroupType];
			private NULL_TEXT type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public ST_GroupType( string value ) : base( value )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public ST_GroupType( NULL_TEXT tnp ) : base( tnp )
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
			override public string DatabaseValue
			{
				get { return base.Value; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is displayed on a form.
			/// </summary>
			override public string DisplayValue
			{
				get { return base.Value; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.Value; }
			}

			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true iff group has a valid GroupType value.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return base.NullState == NULLITY.NotNull; }
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
