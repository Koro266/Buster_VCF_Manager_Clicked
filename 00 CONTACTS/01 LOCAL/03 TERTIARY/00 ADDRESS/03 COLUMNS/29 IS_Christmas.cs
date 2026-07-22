//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using YES_NO	= CONTACTS.GLOBAL.DATABASE.COLUMN.True_False;
using NULL_TEXT = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<bool>;
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
		public partial class IS_Christmas : YES_NO
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.Christmas];
			private NULL_TEXT type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public IS_Christmas( bool value ) : base( value )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public IS_Christmas( NULL_TEXT tnp ) : base( tnp )
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
				return base.AsTF;
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns value formatted for use in a Find this-or-that context.
			/// </summary>
			override public string FinderValue
			{
				get { return base.AsTRUEFALSE; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Assemblage as used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.AsTF; }
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
