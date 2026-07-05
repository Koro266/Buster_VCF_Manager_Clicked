//___________________________________________________________________________________________________________________________________________________					
using System.Data.OleDb;
//GLOBAL
using SHORT_TXT	= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using NULL_TEXT = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
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
		public class ST_LeftProperSurname : SHORT_TXT			
		{			
			#region DECLARATIONS		
			private FACTORS column_factors = CONST.Factors[ORDINAL.LeftProperSurname];
			private NULL_TEXT type_null_pair;
			#endregion


			#region CONSTRUCTORS		
			//_______________________________________________________________________________________________________________________________________		
			public ST_LeftProperSurname( string st_leftpropersurname ) : base( st_leftpropersurname )		
			{		
			}
			//_______________________________________________________________________________________________________________________________________
			public ST_LeftProperSurname( NULL_TEXT tnp ) : base( tnp )
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
