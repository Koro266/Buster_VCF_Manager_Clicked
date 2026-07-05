//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL					
using YES_NO	= CONTACTS.GLOBAL.DATABASE.COLUMN.True_False;
using NULL_BOOL = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<bool>;
using FACTORS	= CONTACTS.GLOBAL.TOOLS.ColumnFactors;
//LOCAL					
using CONST		= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants;
using ORDINAL	= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class IS_Christmas : YES_NO
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.Christmas];
			private NULL_BOOL type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public IS_Christmas( bool is_christmas ) : base( is_christmas )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public IS_Christmas( NULL_BOOL tnp ) : base( tnp )
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
				return base.Value.ToString();
			}
			/*
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the format used to display the value on a form.
			/// </summary>
			public string DisplayValue
			{
				get { return base.AsTRUEFALSE; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.AsTF; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true iff family has a valid is_Christmas value.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return base.NullState == NULLITY.NotNull; }
			}
			*/
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
