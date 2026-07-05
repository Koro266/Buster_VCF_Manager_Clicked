//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using INT_32	= CONTACTS.GLOBAL.DATABASE.COLUMN.Integer_32;
using NULL_INT	= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<int>;
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
		public partial class FK_LeftPerson : INT_32
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.FkLeftPerson];
			private NULL_INT type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public FK_LeftPerson( int fk_leftperson ) : base( fk_leftperson )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public FK_LeftPerson( NULL_INT tnp ) : base( tnp )
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
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is displayed on a form.
			/// </summary>
			public string DisplayValue
			{
				get { return base.AsString; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.VcfValue; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true because Left_Person is never null.
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
