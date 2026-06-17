//___________________________________________________________________________________________________________________________________________________
using System.Data;
using System.Data.OleDb;
//GLOBAL
using BASE_VAR		= CONTACTS.GLOBAL.DATABASE.COLUMN.BaseColumn;
using NULLITY		= CONTACTS.GLOBAL.Nullity;
using NULL_INT		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<int>;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.COLUMN
{
	//_______________________________________________________________________________________________________________________________________________
	/// <summary>
	/// NULLITY.DbNull			==> The supplied value is null (e.g., a database field that contains no value).
	/// NULLITY.FunctionalNull	==> Has no meaning in this class. Int values are either NotNull or DbNull
	/// NULLITY.NotNull			==> The underlying value contains a non-null, usable int value.
	/// </summary>
	public class Integer_32 : BASE_VAR
	{
		#region DECLARATIONS
		private NULL_INT int_Value;
		#endregion


		#region CONSTRUCTORS
		//___________________________________________________________________________________________________________________________________________
		public Integer_32() : base()
		{
			int_Value = new NULL_INT();
		}
		//___________________________________________________________________________________________________________________________________________
		public Integer_32( int value ) : base( value )
		{
			int_Value = new NULL_INT( value );
		}
		//___________________________________________________________________________________________________________________________________________
		public Integer_32( NULL_INT value ) : base( value )
		{
			int_Value = value;
		}
		#endregion


		#region OUTPUT VALUES
		//___________________________________________________________________________________________________________________________________________
		virtual public Int32 Value
		{
			get { return int_Value.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		virtual public string AsString
		{
			get { return this.IsNotNull ? Value.ToString() : String.Empty; }
		}
		//___________________________________________________________________________________________________________________________________________
		override public string FinderValue
		{
			get { return this.AsString; }
		}
		//___________________________________________________________________________________________________________________________________________
		override public string VcfValue
		{
			get { return this.AsString; }
		}
		//___________________________________________________________________________________________________________________________________________
		override public string TextboxValue
		{
			get { return this.AsString; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns (object)Value iff NullState == NotNull.
		/// Returns (object)System.DBNull.Value otherwise.
		/// </summary>
		override public object DbWriteValue
		{
			get { return this.IsNotAbsoluteNull ? ( object )this.Value : base.DbWriteValue; }
		}
		#endregion


		#region DB INTERFACE
		//___________________________________________________________________________________________________________________________________________
		virtual public OleDbParameter DbParameter
		{
			get
			{
				OleDbParameter parameter = new OleDbParameter();
				parameter.DbType = DbType.Int32;
				parameter.Value = this.DbWriteValue;
				return parameter;
			}
		}
		#endregion
	}
}
