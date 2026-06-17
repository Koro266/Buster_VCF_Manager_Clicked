using System.Data.OleDb;			
//GLOBAL			
using INT_32	= CONTACTS.GLOBAL.DATABASE.COLUMN.Integer_32;		
using NULL_INT	= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<int>;		
//LOCAL			
using CONST		= CONTACTS.LOCAL.TERTIARY.ROLE.Constants;	
using ORDINAL	= CONTACTS.LOCAL.TERTIARY.ROLE.Constants.OrdinalByName;		
using FACTORS	= CONTACTS.LOCAL.TERTIARY.ROLE.Constants.ColumnFactors;		

//___________________________________________________________________________________________________________________________________________________					
namespace CONTACTS.LOCAL.TERTIARY.ROLE
{
	//_______________________________________________________________________________________________________________________________________________				
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________			
		public class PK_Role : INT_32
		{
			#region DECLARATIONS		
			private static FACTORS column_factors = CONST.Factors[ORDINAL.PkRole];
			private NULL_INT type_null_pair;
			#endregion


			#region CONSTRUCTORS		
			//_______________________________________________________________________________________________________________________________________	
			public PK_Role( int PkRole ) : base( PkRole )
			{
			}
			//_______________________________________________________________________________________________________________________________________	
			public PK_Role( NULL_INT tnp ) : base( tnp )
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


			#region EXTENSIONS		
			//___________________________________________________________________________________________________________________________________		
			/// <summary>		
			/// Returns the value that is displayed in a TextBox.		
			/// </summary>		
			override public string TextboxValue
			{
				get { return base.AsString; }
			}
			//___________________________________________________________________________________________________________________________________		
			/// <summary>		
			/// Returns PkPerson.AsString.		
			/// </summary>		
			override public string VcfValue
			{
				get { return base.AsString; }
			}
			//___________________________________________________________________________________________________________________________________________		
			/// <summary>		
			/// Returns true because this field is a primary key.		
			/// </summary>		
			override public bool IsVcfValue
			{
				get { return true; }
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
