//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER	= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using EDDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.EDDRESS.Row;
using FIELD			= CONTACTS.LOCAL.TERTIARY.EDDRESS.Column;
using ORDINAL		= CONTACTS.LOCAL.TERTIARY.EDDRESS.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.EDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class EddressReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public EddressReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public EddressReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public EDDRESS_ROW ReadEddress()
			{
				EDDRESS_ROW eddress;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					eddress = ReadRow();

					reader.Close();
					base.Connection.Close();
					return eddress;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadEddresses()
			{
				Dictionary<int, BASE_ROW> all_eddresses = new Dictionary<int, BASE_ROW>();
				EDDRESS_ROW eddress;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						eddress = ReadRow();
						all_eddresses.Add( eddress.PkEddress.Value, eddress );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return all_eddresses;
			}
			//___________________________________________________________________________________________________________________________________________
			private EDDRESS_ROW ReadRow()
			{
				EDDRESS_ROW eddress = new EDDRESS_ROW();

				eddress.Append( new FIELD.PK_Eddress		( base.GetPrimaryKey	( ORDINAL.PkEddress ) ) );
				eddress.Append( new FIELD.ST_Eddress		( base.GetShortText		( ORDINAL.Eddress ) ) );
				eddress.Append( new FIELD.ST_EddressType	( base.GetShortText		( ORDINAL.EddressType ) ) );
				eddress.Append( new FIELD.ST_Notes			( base.GetShortText		( ORDINAL.Notes ) ) );

				return eddress;
			}
		}
	}
}
