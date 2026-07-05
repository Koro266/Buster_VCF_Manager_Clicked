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
		public class IS_ExChristmas : YES_NO
		{			
			#region DECLARATIONS		
			private FACTORS column_factors = CONST.Factors[ORDINAL.DefaultRow];
			private NULL_BOOL type_null_pair;
			#endregion


			#region CONSTRUCTORS		
			//_______________________________________________________________________________________________________________________________________		
			public IS_ExChristmas( bool is_defaultrow ) : base( is_defaultrow )		
			{		
			}
			//_______________________________________________________________________________________________________________________________________
			public IS_ExChristmas( NULL_BOOL tnp ) : base( tnp )
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
