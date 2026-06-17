//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using DATE_TIME	= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using NULL_DATE  = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<System.DateTime>;
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
		public partial class DT_CurrencyDate : DATE_TIME
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.CurrencyDate];
			private NULL_DATE type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public DT_CurrencyDate( DateTime dt_currencydate ) : base( dt_currencydate )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public DT_CurrencyDate( NULL_DATE tnp ) : base( tnp )
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
					parameter.Value = this.DbWriteValue;
					return parameter;
				}
			}
			#endregion
		}
	}
}
