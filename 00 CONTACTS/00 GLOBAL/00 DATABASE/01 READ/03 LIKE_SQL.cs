//___________________________________________________________________________________________________________________________________________________
using System.Data;
using System.Data.OleDb;
//GLOBAL
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using BASE_READER = CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
using LIKE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.READ
{
	//___________________________________________________________________________________________________________________________________________
	public class Like : BASE_READER
	{
		private string _like_parm_name = "@subtext";
		private string _like_wildcard = "%";
		private string _not_blank_wildcard = "%[a-zA-Z0-9]%";
		private string _accept_all_not_blank = ".";

		private int pk_Ordinal = 0;
		private int st_Ordinal = 1;
		private int row_Count = PRESET.ZERO;

		//___________________________________________________________________________________________________________________________________________
		public Like() : base( "dummy sql_text" )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		public Like( string sql_text ) : base( sql_text )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Constructs the parameter that is used in a LIKE query. 
		/// Set.Value is the search string to which is attached the wildcards required.
		/// If set.value == ".", the wildcard is set to accept all values that are not blank.
		/// </summary>
		public string SetParameter
		{
			set
			{
				OleDbParameter parameter = new OleDbParameter();
				parameter.ParameterName = _like_parm_name;
				parameter.DbType = DbType.String;

				if ( value == _accept_all_not_blank )
					parameter.Value = _not_blank_wildcard;
				else
					parameter.Value = value + _like_wildcard;

				base.DbCommand.Parameters.Add( parameter );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Sets DbCommand.CommandText to the count SQL, executes the query, and sets the internal row count value.
		/// </summary>
		public string SetCount
		{
			set
			{
				try
				{
					Connection.Open();
					base.DbCommand.CommandText = value;
					var v = base.DbCommand.ExecuteScalar();
					Connection.Close();
					row_Count = Convert.ToInt32( v );
				}
				catch ( Exception e )
				{
					Connection.Close();
				}
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// (Re)sets DbCommand.CommandText to the select SQL.
		/// </summary>
		public string SetSelect
		{
			set { base.DbCommand.CommandText = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Executes a LIKE query and returns the result as a LikeRow array (LikeRow[]).
		/// The SQL must put a primary key into column 0 and a text value into column 1.
		/// Other columns, if they are present, are ignored.
		/// </summary>
		/// <returns>On exception returns zero-length LikeRow array (LikeRow[0]).</returns>
		public LIKE_ROW[] Execute
		{
			get
			{
				if ( row_Count == PRESET.ZERO )
					return new LIKE_ROW[0];

				try
				{
					LIKE_ROW[] items = new LIKE_ROW[row_Count];

					base.Connection.Open();
					OleDbDataReader reader = base.DbCommand.ExecuteReader();

					int i = 0;
					while ( reader.Read() )
					{
						int pk = reader.GetInt32( pk_Ordinal );
						string st = reader.GetString( st_Ordinal );
						items[i++] = new LIKE_ROW( pk, st );
					}

					reader.Close();
					base.Connection.Close();
					return items;
				}
				catch ( Exception e )
				{
					Connection.Close();
					return new LIKE_ROW[0];
				}
			}
		}

	}
}
