
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_READER = CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.READ
{
	//___________________________________________________________________________________________________________________________________________
	public class Count : BASE_READER
	{
		//___________________________________________________________________________________________________________________________________________
		public Count( string sql_text ): base( sql_text )
		{
			base.DbCommand.CommandText = sql_text;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Counts rows returned by supplied SQL. Returns 0 on exception.
		/// </summary>
		virtual public int RowCount
		{
			get { return ScalarInt( PRESET.ZERO ); }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns current maximum PK. Returns -1 on exception.
		/// </summary>
		virtual public int MaxPk
		{
			get { return ScalarInt( PRESET.MINUS_ONE ); }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns current minimum PK. Returns int.MaxValue on exception.
		/// </summary>
		virtual public int MinPk
		{
			get { return ScalarInt( int.MaxValue ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private int ScalarInt( int ret_val )
		{
			try
			{
				Connection.Open();
				var v = base.DbCommand.ExecuteScalar();
				Connection.Close();
				return Convert.ToInt32( v );
			}
			catch ( Exception e )
			{
				Connection.Close();
				return ret_val;
			}
		}
	}
}
