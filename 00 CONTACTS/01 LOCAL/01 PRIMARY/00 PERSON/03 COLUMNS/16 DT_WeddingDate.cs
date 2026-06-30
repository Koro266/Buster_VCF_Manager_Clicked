//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using DATE_TIME	= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using NULL_DATE  = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<System.DateTime>;
using FACTORS	= CONTACTS.GLOBAL.TOOLS.ColumnFactors;
//LOCAL
using CONST		= CONTACTS.LOCAL.PRIMARY.PERSON.Constants;
using ORDINAL	= CONTACTS.LOCAL.PRIMARY.PERSON.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
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
			public DT_WeddingDate( DateTime value ) : base( value )
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
				return base.As_ddd_d_MMM_yyyy;
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns WeddingDate value that is displayed in a TextBox in format "ddd, d MMM yyyy".
			/// </summary>
			override public string TextboxValue
			{
				get { return base.As_ddd_d_MMM_yyyy; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns WeddingDate as used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.As_YYYY_MM_DD; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true if person has a valid WeddingDate value.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return base.IsNotAbsoluteNull; }
			}
			//___________________________________________________________________________________________________________________________________________
			override public DateTime DatePickerValue
			{
				get { return base.IsNull ? DATE_TIME.MinControllableDate : this.Value; }
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
				get { return base.DbWriteDate( DATE_TIME.DatabaseWeddingDateFormat ); }
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
