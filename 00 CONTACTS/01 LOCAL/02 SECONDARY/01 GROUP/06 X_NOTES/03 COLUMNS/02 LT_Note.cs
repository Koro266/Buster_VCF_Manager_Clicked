//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using SHORT_TXT = CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using NULL_TEXT = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE.Constants.OrdinalByName;
using FACTORS	= CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE.Constants.ColumnFactors;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// The database type for this field is Memo (long text) but it is treated here as short text -- and we'll see how that plays out ... .
		/// </summary>
		public class LT_Note : SHORT_TXT
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.Note];
			private NULL_TEXT type_null_pair;
			#endregion	


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public LT_Note( string value ) : base( value )
			{
			}
			//_______________________________________________________________________________________________________________________________________
			public LT_Note( NULL_TEXT tnp ) : base( tnp )
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
			/// Returns PkGroup.AsString.
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
