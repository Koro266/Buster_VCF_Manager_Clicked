//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using SHORT_TXT	= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using NULL_TEXT = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
using FACTORS	= CONTACTS.GLOBAL.TOOLS.ColumnFactors;
//LOCAL
using CONST		= CONTACTS.LOCAL.TERTIARY.DEVICE.Constants;
using ORDINAL	= CONTACTS.LOCAL.TERTIARY.DEVICE.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class ST_LeadingDigits : SHORT_TXT
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.LeadingDigits];
			private NULL_TEXT type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public ST_LeadingDigits( string value ) : base( value )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public ST_LeadingDigits( NULL_TEXT tnp ) : base( tnp )
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
				return base.Value;
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
