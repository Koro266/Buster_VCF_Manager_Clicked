//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using SHORT_TXT	= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using NULL_TEXT = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
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
		public class ST_CountryName: SHORT_TXT
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.CountryName];
			private NULL_TEXT type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public ST_CountryName( string country_name ) : base( country_name )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public ST_CountryName( NULL_TEXT tnp ) : base( tnp )
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
