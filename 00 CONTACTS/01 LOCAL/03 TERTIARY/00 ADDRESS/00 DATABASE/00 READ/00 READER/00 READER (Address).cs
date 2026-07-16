//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER	= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
using SELECT		= CONTACTS.GLOBAL.DATABASE.READ.Select;
//LOCAL
using SELECT_NATION	= CONTACTS.LOCAL.TERTIARY.NATION.Database.Select.ByPkNation;
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using FIELD			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Column;
using ORDINAL		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class AddressReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public AddressReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public AddressReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public ADDRESS_ROW ReadAddress()
			{
				ADDRESS_ROW address;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					address = ReadRow();

					reader.Close();
					base.Connection.Close();
					return address;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadAddresses()
			{
				Dictionary<int, BASE_ROW> all_addresses = new Dictionary<int, BASE_ROW>();
				ADDRESS_ROW address;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						address = ReadRow();
						all_addresses.Add( address.PkAddress.Value, address );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return all_addresses;
			}
			//___________________________________________________________________________________________________________________________________________
			private ADDRESS_ROW ReadRow()
			{
				ADDRESS_ROW address = new ADDRESS_ROW();

				address.Append( new FIELD.PK_Address			( base.GetPrimaryKey	( ORDINAL.PkAddress )		) );
				address.Append( new FIELD.FK_Country			( base.GetForeignKey	( ORDINAL.FkCountry )		) );
				address.Append( new FIELD.ST_Assemblage			( base.GetShortText		( ORDINAL.Assemblage )		) );
				address.Append( new FIELD.ST_Level				( base.GetShortText		( ORDINAL.Level )			) );
				address.Append( new FIELD.ST_Unit				( base.GetShortText		( ORDINAL.Unit )			) );
				address.Append( new FIELD.ST_Extension			( base.GetShortText		( ORDINAL.Extension )		) );
				address.Append( new FIELD.ST_RuralDelivery		( base.GetShortText		( ORDINAL.RuralDelivery )	) );
				address.Append( new FIELD.ST_PostalCode			( base.GetShortText		( ORDINAL.PostalCode )		) );
				address.Append( new FIELD.ST_BoxNumber			( base.GetShortText		( ORDINAL.BoxNumber )		) );
				address.Append( new FIELD.ST_HouseNumber		( base.GetShortText		( ORDINAL.HouseNumber )		) );
				address.Append( new FIELD.ST_StreetName			( base.GetShortText		( ORDINAL.StreetName )		) );
				address.Append( new FIELD.ST_StreetType			( base.GetShortText		( ORDINAL.StreetType )		) );
				address.Append( new FIELD.ST_Compass			( base.GetShortText		( ORDINAL.Compass )			) );
				address.Append( new FIELD.ST_Suburb				( base.GetShortText		( ORDINAL.Suburb )			) );
				address.Append( new FIELD.ST_City				( base.GetShortText		( ORDINAL.City )			) );
				address.Append( new FIELD.ST_Metropolitan		( base.GetShortText		( ORDINAL.Metropolitan )	) );
				address.Append( new FIELD.ST_ProvinceName		( base.GetShortText		( ORDINAL.ProvinceName )	) );
				address.Append( new FIELD.ST_ProvinceCode		( base.GetShortText		( ORDINAL.ProvinceCode )	) );
				address.Append( new FIELD.ST_VcfPostal			( base.GetShortText		( ORDINAL.VcfPostal )		) );
				address.Append( new FIELD.ST_VcfPhysical		( base.GetShortText		( ORDINAL.VcfPhysical )		) );
				address.Append( new FIELD.ST_VcfExtended		( base.GetShortText		( ORDINAL.VcfExtended )		) );
				address.Append( new FIELD.ST_ExcelPattern		( base.GetShortText		( ORDINAL.ExcelPattern )	) );
				address.Append( new FIELD.IS_Christmas			( base.GetBoolean		( ORDINAL.Christmas )		) );
				address.Append( new FIELD.ST_CountryName		( base.GetShortText		( ORDINAL.CountryName)		) );
				address.Append( new FIELD.ST_CountryCode		( base.GetShortText		( ORDINAL.CountryCode)		) );
				address.Append( new FIELD.ST_ShortIsoCode		( base.GetShortText		( ORDINAL.ShortIsoCode)		) );
				address.Append( new FIELD.ST_LongIsoCode		( base.GetShortText		( ORDINAL.LongIsoCode)		) );

				return address;
			}
		}
	}
}
