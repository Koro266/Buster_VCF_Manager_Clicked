//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using INT_32	= CONTACTS.GLOBAL.DATABASE.COLUMN.Integer_32;
using NULL_INT	= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<int>;
using FACTORS	= CONTACTS.GLOBAL.TOOLS.ColumnFactors;
//LOCAL
using ORDINAL	= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants.OrdinalByName;
using CONST		= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class FK_RightPerson : INT_32
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.FkRightPerson];
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public FK_RightPerson( int fk_rightperson ) : base( fk_rightperson )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public FK_RightPerson( NULL_INT fk_rightperson ) : base( fk_rightperson.Value )
			{
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
			/// <summary>
			/// Returns true because Right_Person is never null.
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
					parameter.Value = base.DbWriteValue;
					return parameter;
				}
			}
			#endregion
		}
	}
}
