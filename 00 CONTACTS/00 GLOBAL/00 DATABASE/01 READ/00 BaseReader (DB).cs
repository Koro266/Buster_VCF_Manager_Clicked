//___________________________________________________________________________________________________________________________________________________
using System.Data;
using System.Data.OleDb;
using DATE_TIME		= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
//GLOBAL
using DB_CONNECTION	= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnection;
using NULL_BOOL		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<bool>;
using NULL_DATE		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<System.DateTime>;
using NULL_INT		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<int>;
using NULL_SHORT	= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<short>;
using NULL_TEXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
using NULLITY		= CONTACTS.GLOBAL.Nullity;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.READ
{
	//___________________________________________________________________________________________________________________________________________
	public class BaseReader : DB_CONNECTION
	{
		private OleDbDataReader db_Reader;

		//___________________________________________________________________________________________________________________________________________
		public BaseReader( string sql_text ) : base( sql_text )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		public BaseReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
		{
			base.DbCommand.Parameters.Add( parameter );
		}
		//___________________________________________________________________________________________________________________________________________
		public OleDbDataReader ExecuteReader()
		{
			db_Reader = base.DbCommand.ExecuteReader();
			return db_Reader;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Reads a single string field and returns the values in a List<>.
		/// String to be read must be in ordinal position 0.
		/// All other fields -- if they exist -- are ignored.
		/// </summary>
		/// <returns>A List<string>. </returns>
		public List<string> ReadStringList
		{
			get
			{
				List<string> list = new List<string>();

				base.Connection.Open();
				db_Reader = base.DbCommand.ExecuteReader();

				if ( db_Reader.HasRows )
				{
					while ( db_Reader.Read() )
						list.Add( GetText( 0 ) );
				}
				db_Reader.Close();
				base.Connection.Close();

				return list;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Primary key is a value type (int) which is guaranteed to be a unique, non-null, non-negative value.
		/// Technically, no null checks are required but to enforce consistency, we return a TypeNullPair<int>.
		/// </summary>
		public NULL_INT GetPrimaryKey( int column_ordinal )
		{
			int pk_value = db_Reader.GetInt32( column_ordinal );
			return new NULL_INT( pk_value, NULLITY.NotNull );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Foreign key is a value type (int) and database null values are possible.
		/// </summary>
		public NULL_INT GetForeignKey( int column_ordinal )
		{
			int signal_value = db_Reader.IsDBNull( column_ordinal ) ?
				int.MinValue :
				db_Reader.GetInt32( column_ordinal );

			return signal_value == int.MinValue ?
				new NULL_INT() :
				new NULL_INT( signal_value, NULLITY.NotNull );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// INT_32 (int) is a value type and database null values are possible.
		/// </summary>
		public NULL_INT GetInt32( int column_ordinal )
		{
			int signal_value = db_Reader.IsDBNull( column_ordinal ) ?
				int.MinValue :
				db_Reader.GetInt32( column_ordinal );

			return signal_value == int.MinValue ?
				new NULL_INT() :
				new NULL_INT( signal_value, NULLITY.NotNull );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// INT_16 (short) is a value type and database null values are possible.
		/// </summary>
		public NULL_SHORT GetInt16( int column_ordinal )
		{
			short signal_value = db_Reader.IsDBNull( column_ordinal ) ?
				short.MinValue : 
				db_Reader.GetInt16( column_ordinal );

			return signal_value == short.MinValue ?
				new NULL_SHORT() : 
				new NULL_SHORT( signal_value, NULLITY.NotNull );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// String is a reference type.
		/// </summary>
		public NULL_TEXT GetShortText( int column_ordinal )
		{
			string signal_value = db_Reader.IsDBNull( column_ordinal ) ? 
				String.Empty : 
				db_Reader.GetString( column_ordinal );

			return String.IsNullOrEmpty( signal_value ) ?
				new NULL_TEXT() :
				new NULL_TEXT( signal_value, NULLITY.NotNull );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// DateTime is a reference type and hence Reader.IsDBNull behaves in the expected manner.
		/// </summary>
		public NULL_DATE GetDateTime( int column_ordinal )
		{
			DateTime signal_value = db_Reader.IsDBNull( column_ordinal ) ?
				DateTime.MinValue :
				db_Reader.GetDateTime( column_ordinal );

			if ( signal_value == DateTime.MinValue )
			{
				//IsDBNull == true
				return new NULL_DATE();
			}

			if ( signal_value < DATE_TIME.MinControllableDate )
			{
				//IsDBNull == false but date cannot be used in DateTimePicker control.
				return new NULL_DATE( signal_value, NULLITY.FunctionalNull );
			}

			if ( signal_value >= DATE_TIME.MinControllableDate )
			{
				//IsDBNull == false and date can be used in DateTimePicker control.
				return new NULL_DATE( signal_value, NULLITY.NotNull );
			}

			//everything went haywire ...
			return  new NULL_DATE( DATE_TIME.DbNullDate );   // 1 Jan 0001;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Boolean is a value type.
		/// SQL returns either TRUE or FALSE. No other values are available. 
		/// </summary>
		public NULL_BOOL GetBoolean( int column_ordinal )
		{
			bool signal_value = db_Reader.GetBoolean( column_ordinal );

			return signal_value ?
				new NULL_BOOL( signal_value, NULLITY.NotNull ) :	//TRUE
				new NULL_BOOL();									//FALSE
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// This reader is being phased out.
		/// </summary>
		public string GetText( int column_ordinal )
		{
			if ( db_Reader.IsDBNull( column_ordinal ) )
				return string.Empty;
			else
				return db_Reader.GetString( column_ordinal );
		}
	}
}
