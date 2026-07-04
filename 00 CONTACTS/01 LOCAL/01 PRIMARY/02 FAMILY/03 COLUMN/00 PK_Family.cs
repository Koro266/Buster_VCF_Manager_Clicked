//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using INT_32	= CONTACTS.GLOBAL.DATABASE.COLUMN.Integer_32;
using NULL_INT	= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<int>;
//LOCAL
using CONST		= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants;
using ORDINAL	= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants.OrdinalByName;
using FACTORS	= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants.ColumnFactors;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class PK_Family : INT_32
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.PkFamily];
			private NULL_INT type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public PK_Family( int pk_family ) : base( pk_family )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public PK_Family( NULL_INT tnp ) : base( tnp )
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
