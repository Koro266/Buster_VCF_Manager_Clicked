//___________________________________________________________________________________________________________________________________________________					
using System.Data.OleDb;
//GLOBAL					
using INT_16	= CONTACTS.GLOBAL.DATABASE.COLUMN.Integer_16;
using NULL_INT	= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<short>;
//LOCAL					
using CONST		= CONTACTS.LOCAL.TERTIARY.NATION.Constants;
using ORDINAL	= CONTACTS.LOCAL.TERTIARY.NATION.Constants.OrdinalByName;
using FACTORS	= CONTACTS.LOCAL.TERTIARY.NATION.Constants.ColumnFactors;

//___________________________________________________________________________________________________________________________________________________					
namespace CONTACTS.LOCAL.TERTIARY.NATION
{
	//___________________________________________________________________________________________________________________________________________				
	public partial class Column
	{
		//_______________________________________________________________________________________________________________________________________			
		public class SI_Order : INT_16
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.Order];
			private NULL_INT type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public SI_Order( short pk_nation ) : base( pk_nation )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public SI_Order( NULL_INT tnp ) : base( tnp )
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
