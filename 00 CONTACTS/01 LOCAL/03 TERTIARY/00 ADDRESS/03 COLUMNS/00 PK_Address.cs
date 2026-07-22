//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using INT_32	= CONTACTS.GLOBAL.DATABASE.COLUMN.Integer_32;
using NULL_INT	= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<int>;
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
		public class PK_Address : INT_32
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.PkAddress];
			private NULL_INT type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public PK_Address( int pk_address ) : base( pk_address )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public PK_Address( NULL_INT tnp ) : base( tnp )
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
