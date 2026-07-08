//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using INT_32	= CONTACTS.GLOBAL.DATABASE.COLUMN.Integer_32;
using NULL_INT	= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<int>;
using FACTORS	= CONTACTS.GLOBAL.TOOLS.ColumnFactors;
//LOCAL
using CONST		= CONTACTS.LOCAL.PRIMARY.GROUP.Constants;
using ORDINAL	= CONTACTS.LOCAL.PRIMARY.GROUP.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class PK_Group : INT_32
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.PkGroup];
			private NULL_INT type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public PK_Group( int pk_group ) : base( pk_group )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public PK_Group( NULL_INT tnp ) : base( tnp )
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
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is displayed on a form.
			/// </summary>
			public string DisplayValue
			{
				get { return base.AsString; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.VcfValue; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true because this is a primary key.
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
