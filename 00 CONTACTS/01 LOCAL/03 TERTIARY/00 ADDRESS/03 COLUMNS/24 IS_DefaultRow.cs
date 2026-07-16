//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BOOL		= CONTACTS.GLOBAL.DATABASE.COLUMN.True_False;
using NULL_BOOL = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<bool>;
using FACTORS	= CONTACTS.GLOBAL.TOOLS.ColumnFactors;
//LOCAL
using CONST		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants;
using ORDINAL	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class IS_DefaultRow : BOOL
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.DefaultRow];
			private NULL_BOOL type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public IS_DefaultRow( bool value ) : base( value )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public IS_DefaultRow( NULL_BOOL tnp ) : base( tnp )
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
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Selected as used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.AsTF; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true: Boolean columns always have a usable value.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return true; }
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
					return parameter;
				}
			}
			#endregion
		}
	}
}
