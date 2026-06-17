//___________________________________________________________________________________________________________________________________________________
using System.Data;
using System.Data.OleDb;
//GLOBAL
using NULLITY		= CONTACTS.GLOBAL.Nullity;
using BASE_VAR		= CONTACTS.GLOBAL.DATABASE.COLUMN.BaseColumn;
using NULL_SHORT	= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<short>;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.COLUMN
{
	//_______________________________________________________________________________________________________________________________________________
	/// <summary>
	/// NULLITY.DbNull			==> The supplied value is null (e.g., a database field that contains no value).
	/// NULLITY.FunctionalNull	==> If DB read returns a -1 it means the internal MS access field is blank (null) hence, not null but no meaningful value..
	/// NULLITY.NotNull			==> The underlying value contains a non-null, usable short value.
	/// </summary>
	public class Integer_16 : BASE_VAR
	{
		#region DECLARATIONS
		private NULL_SHORT shrt_Value;
		#endregion


		#region CONSTRUCTOR
		//___________________________________________________________________________________________________________________________________________
		public Integer_16() : base()
		{
			shrt_Value = new NULL_SHORT();
		}
		//___________________________________________________________________________________________________________________________________________
		public Integer_16( short value ) : base( value )
		{
			shrt_Value = new NULL_SHORT( value );
		}
		//___________________________________________________________________________________________________________________________________________
		public Integer_16( NULL_SHORT value ) : base( value )
		{
			shrt_Value = value;
		}
		#endregion


		#region OUTPUT VALUES
		//___________________________________________________________________________________________________________________________________________
		virtual public short Value
		{
			get { return shrt_Value.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		virtual public string AsString
		{
			get { return this.IsNotAbsoluteNull ? Value.ToString() : String.Empty; }
		}

		//___________________________________________________________________________________________________________________________________________
		override public bool IsVcfValue
		{
			get { return this.IsNotAbsoluteNull; }
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


		#region NULL STATE.
		#endregion


		#region DB INTERFACE
		//___________________________________________________________________________________________________________________________________________
		virtual public OleDbParameter DbParameter
		{
			get
			{
				OleDbParameter parameter = new OleDbParameter();
				parameter.DbType = DbType.Int16;
				parameter.Value = this.DbWriteValue;
				return parameter;
			}
		}
		#endregion
	}
}
