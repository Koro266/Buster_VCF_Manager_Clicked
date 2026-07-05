//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using DATE_TIME	= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using NULL_DATE	= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<System.DateTime>;
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
		public partial class DT_WeddingDate : DATE_TIME
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.WeddingDate];
			private NULL_DATE type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public DT_WeddingDate( DateTime dt_weddingdate ) : base( dt_weddingdate )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public DT_WeddingDate( NULL_DATE tnp ) : base( tnp )
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
			//___________________________________________________________________________________________________________________________________________
			override public DateTime DatePickerValue
			{
				get { return base.IsNull ? DATE_TIME.MinControllableDate.Date : this.Value.Date; }
			}
			//___________________________________________________________________________________________________________________________________________
			override public string DatePickerFormat
			{
				get { return base.IsNull ? DATE_TIME.NullDateFormat : DATE_TIME.DisplayedDateFormat; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns value that is sent to the database.
			/// </summary>
			override public object DbWriteValue
			{
				get
				{
					if ( base.IsNull )
						return ( object )System.DBNull.Value;
					else
						return base.DbWriteDate( DATE_TIME.DatabaseWeddingDateFormat );
				}
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
