//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using System.Data.OleDb;
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER	= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using NATION_ROW	= CONTACTS.LOCAL.TERTIARY.NATION.Row;
using FIELD			= CONTACTS.LOCAL.TERTIARY.NATION.Column;
using ORDINAL		= CONTACTS.LOCAL.TERTIARY.NATION.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.NATION
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class NationReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public NationReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public NationReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public NATION_ROW ReadNation()
			{
				NATION_ROW nation;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					nation = ReadRow();

					reader.Close();
					base.Connection.Close();
					return nation;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadNations()
			{
				Dictionary<int, BASE_ROW> nations = new Dictionary<int, BASE_ROW>();
				NATION_ROW nation;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						nation = ReadRow();
						nations.Add( nation.PkCountry.Value, nation );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return nations;
			}
			//___________________________________________________________________________________________________________________________________________
			private NATION_ROW ReadRow()
			{
				NATION_ROW nation = new NATION_ROW();

				nation.Append( new FIELD.PK_Country			( base.GetPrimaryKey		( ORDINAL.PkCountry )		) );
				nation.Append( new FIELD.SI_Order			( base.GetInt16				( ORDINAL.Order )			) );
				nation.Append( new FIELD.ST_CountryName		( base.GetShortText			( ORDINAL.CountryName )		) );
				nation.Append( new FIELD.ST_CountryCode		( base.GetShortText			( ORDINAL.CountryCode )		) );
				nation.Append( new FIELD.ST_ShortIsoCode	( base.GetShortText			( ORDINAL.ShortIsoCode )	) );
				nation.Append( new FIELD.ST_LongIsoCode		( base.GetShortText			( ORDINAL.LongIsoCode )		) );

				return nation;
			}
		}
	}
}
