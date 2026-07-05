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
		public partial class IS_Dissolved : YES_NO
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.Dissolved];
			private NULL_BOOL type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public IS_Dissolved( bool is_dissolved ) : base( is_dissolved )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public IS_Dissolved( NULL_BOOL tnp ) : base( tnp )
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
