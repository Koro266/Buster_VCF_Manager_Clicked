//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using SHORT_TXT = CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using NULL_TEXT = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
using NULLITY	= CONTACTS.GLOBAL.Nullity;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Constants.OrdinalByName;
using FACTORS	= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Constants.ColumnFactors;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		public class ST_AddressType : SHORT_TXT
		{
			#region DECLARATIONS
			private FACTORS _columnFactors = CONST.Factors[ORDINAL.AddressType];
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
			/// Returns true iff person has a valid AddressType value.				
			/// </summary>				
			override public bool IsVcfValue
			{
				get
				{
					switch ( base.NullState )
					{
						case NULLITY.DbNull:
							return false;

						case NULLITY.NotNull:
							return true;

						default:
							return false;
					}
				}
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
