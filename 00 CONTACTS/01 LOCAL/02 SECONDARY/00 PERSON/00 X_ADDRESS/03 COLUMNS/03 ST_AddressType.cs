//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using SHORT_TXT = CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using NULL_TEXT = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
using FACTORS	= CONTACTS.GLOBAL.TOOLS.ColumnFactors;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		public class ST_AddressType : SHORT_TXT
		{
			#region DECLARATIONS
			private static FACTORS _columnFactors = CONST.Factors[ORDINAL.AddressType];
			private NULL_TEXT type_null_pair;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public ST_AddressType( string value ) : base( value )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public ST_AddressType( NULL_TEXT tnp ) : base( tnp )
			{
				type_null_pair = tnp;
			}
			#endregion


			#region METHODS
			//_______________________________________________________________________________________________________________________________________
			public FACTORS ColumnFactors
			{
				get { return _columnFactors; }
			}
			//_______________________________________________________________________________________________________________________________________
			public int Ordinal
			{
				get { return ColumnFactors.Ordinal; }
			}
			//_______________________________________________________________________________________________________________________________________
			override public string ToString()
			{
				return base.Value.ToString();
			}
			//___________________________________________________________________________________________________________________________________________				
			/// <summary>				
			/// Returns AddressType formatted for use in a VCF file.				
			/// </summary>				
			override public string VcfValue
			{
				get { return base.AsIs; }
			}
			//___________________________________________________________________________________________________________________________________________				
			/// <summary>				
			/// Returns true iff AddressType has a valid value.				
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
					parameter.ParameterName = ColumnFactors.ParameterName;
					parameter.Size = ColumnFactors.FieldWidth;
					return parameter;
				}
			}
			#endregion
		}
	}
}
