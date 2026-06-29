//___________________________________________________________________________________________________________________________________________________
using System.Data;
using System.Data.OleDb;
//GLOBAL
using BASE_VAR	= CONTACTS.GLOBAL.DATABASE.COLUMN.BaseColumn;
using NULLITY	= CONTACTS.GLOBAL.Nullity;
using NULL_BOOL = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<bool>;
using WORDS		= CONTACTS.GLOBAL.VALUES.CONSTANT.Words;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.COLUMN
{
	//_______________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Access database boolean values are always either true or false. No other value is possible.
	/// Hence, this object does not have an underlying boolean value.
	/// NULLITY.DbNull			==> Treated as false.
	/// NULLITY.FunctionalNull	==> Treated as false.
	/// NULLITY.NotNull			==> Treated as true.
	/// </summary>
	public class True_False : BASE_VAR
	{
		#region CONSTANTS
		#endregion


		#region STATIC VALUES
		public static bool default_Bool = false;
		#endregion


		#region DECLARATIONS
		private NULL_BOOL tf_Value;
		#endregion


		#region CONSTRUCTOR
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a True_False with value = false and NullState = NotNull.
		/// </summary>
		public True_False() : base()
		{
			tf_Value = new NULL_BOOL();
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a True_False with value = value NullState = NotNull.
		/// </summary>
		public True_False( bool value ) : base( value )
		{
			tf_Value = new NULL_BOOL( value );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a True_False with value = value NullState = NotNull.
		/// </summary>
		public True_False( NULL_BOOL value ) : base( value )
		{
			tf_Value = value;
		}
		#endregion


		#region VALUE
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true or false -- no other values are possible.
		/// </summary>
		virtual public bool Value
		{
			get { return tf_Value.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns not Value.
		/// </summary>
		public bool NotValue
		{
			get { return !Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		override public string FinderValue
		{
			get { return AsUpper; }
		}
		//___________________________________________________________________________________________________________________________________________
		override public string VcfValue
		{
			get { return AsUpper; }
		}
		//___________________________________________________________________________________________________________________________________________
		override public string TextboxValue
		{
			get { return AsUpper; }
		}
		//___________________________________________________________________________________________________________________________________________
		override public object DbWriteValue
		{
			get { return ( object )Value; }
		}
		#endregion


		#region VALUE TRANSFORMATIONS.
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "True" or "False".
		/// </summary>
		virtual public string AsString
		{
			get { return AsTrueFalse; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "TRUE" or "FALSE".
		/// </summary>
		virtual public string AsUpper
		{
			get { return AsTRUEFALSE; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "TRUE" or "FALSE".
		/// </summary>
		virtual public string AsTRUEFALSE
		{
			get { return Value ? WORDS.True.AsUpper : WORDS.False.AsUpper; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "True" or "False".
		/// </summary>
		virtual public string AsTrueFalse
		{
			get { return Value ? WORDS.True.AsProper : WORDS.False.AsProper; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "true" or "false".
		/// </summary>
		virtual public string Astruefalse
		{
			get { return Value ? WORDS.True.AsLower : WORDS.False.AsLower; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "T" or "F".
		/// </summary>
		virtual public string AsTF
		{
			get { return Value ? WORDS.True.AsUpperInitial : WORDS.False.AsUpperInitial; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "Female" if true "Male" otherwise.
		/// </summary>
		virtual public string AsMaleFemale
		{
			get { return Value ? WORDS.Female.AsProper: WORDS.Male.AsProper; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "Yes" if true "No" otherwise.
		/// </summary>
		virtual public string AsYesNo
		{
			get { return Value ? WORDS.Yes.AsProper : WORDS.No.AsProper; }
		}
		#endregion


		#region DB INTERFACE
		//___________________________________________________________________________________________________________________________________________
		virtual public OleDbParameter DbParameter
		{
			get
			{
				OleDbParameter parameter = new OleDbParameter();
				parameter.DbType = DbType.Boolean;
				parameter.Value = this.DbWriteValue;
				return parameter;
			}
		}
		#endregion
	}
}

