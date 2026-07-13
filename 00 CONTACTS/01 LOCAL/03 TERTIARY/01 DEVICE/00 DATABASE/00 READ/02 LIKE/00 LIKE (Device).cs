//___________________________________________________________________________________________________________________________________________________
//GLOBAL

//___________________________________________________________________________________________________________________________________________________
using CONTACTS.GLOBAL.DATABASE.ROW;
using CONTACTS.GLOBAL.VALUES.CONSTANT;
using System.Data.OleDb;

namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________
		public partial class Like
		{
			private const string sql_count = @"SELECT Count(pk_Device) FROM TDF_Devices WHERE (((TDF_Devices.#0) LIKE @subtext));";
		}
		//_______________________________________________________________________________________________________________________________________
		public class AreaCodes
		{
			private string st_LongAreaCode;
			private string st_ShortAreaCode;

			//___________________________________________________________________________________________________________________________________
			public AreaCodes( string long_code, string short_code )
			{
				this.st_LongAreaCode = long_code;
				this.st_ShortAreaCode = short_code;
			}
			//___________________________________________________________________________________________________________________________________
			public string LongValue { get { return st_LongAreaCode; } }
			public string ShortValue { get { return st_ShortAreaCode; } }
			public override string ToString() { return st_LongAreaCode; }
		}

		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Executes a LIKE query and returns the result as a LikeRow array (LikeRow[]).
		/// The SQL must put a primary key into column 0 and a text value into column 1.
		/// Other columns, if they are present, are ignored.
		/// </summary>
		/// <returns>On exception returns zero-length LikeRow array (LikeRow[0]).</returns>
		public AreaCodes[] Execute
		{
			get
			{
				int row_Count = 17;

				try
				{
					AreaCodes[] items = new AreaCodes[row_Count];

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
				return null;
			}
		}


	}
}
