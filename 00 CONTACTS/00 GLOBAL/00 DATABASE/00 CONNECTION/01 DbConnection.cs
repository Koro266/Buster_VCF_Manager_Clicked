//___________________________________________________________________________________________________________________________________________________
using System.Data;
using System.Data.OleDb;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.CONNECTION
{
	//_______________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Establishes the appropriate (DEBUG or RELEASE) connection to the database and provides base-level database interaction.
	/// </summary>
	public class DbConnection
	{
		private static DbConnector db_Connector = new DbConnector();
		private static OleDbConnection db_Connection;
		private OleDbCommand db_Command;

		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Instantiates DbConnection and a DbCommand object and sets the CommandText.
		/// </summary>
		public DbConnection( string sql_text)
		{
			db_Connection			= new OleDbConnection( db_Connector.FullyQualifiedConnectionString );
			db_Command				= new OleDbCommand();
			db_Command.Connection	= db_Connection;
			db_Command.CommandType	= CommandType.Text;
			db_Command.CommandText	= sql_text;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Gets OleDbConnection object.
		/// </summary>
		virtual public OleDbConnection Connection
		{
			get { return db_Connection; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Gets OleDbCommand object.
		/// </summary>
		virtual protected OleDbCommand DbCommand
		{
			get { return db_Command; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Executes a a generic DbCommand.ExecuteNonQuery. Returns TRUE on success, FALSE otherwise.
		/// </summary>
		public bool ExecuteNonQuery
		{
			get
			{
				try
				{
					db_Connection.Open();
					db_Command.ExecuteNonQuery();
					db_Connection.Close();
					return true;
				}
				catch ( Exception e ) 
				{
					db_Connection.Close();
					return false;
				}
			}
		}

	}
}
