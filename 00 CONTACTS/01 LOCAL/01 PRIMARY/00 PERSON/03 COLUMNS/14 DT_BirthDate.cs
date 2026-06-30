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
		public partial class DT_BirthDate : DATE_TIME
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.BirthDate];
			private NULL_DATE type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public DT_BirthDate( DateTime value ) : base( value )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public DT_BirthDate( NULL_DATE tnp ) : base( tnp )
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
			/// Returns BirthDate value that is displayed in a TextBox in format "ddd, d MMM yyyy".
			/// </summary>
			override public string TextboxValue
			{
				get { return base.As_ddd_d_MMM_yyyy; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns BirthDate as used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.As_YYYY_MM_DD; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true if person has a valid BirthDate value.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return base.IsNotAbsoluteNull; }
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
				get { return base.DbWriteDate( DATE_TIME.DatabaseBirthDateFormat ); }
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
