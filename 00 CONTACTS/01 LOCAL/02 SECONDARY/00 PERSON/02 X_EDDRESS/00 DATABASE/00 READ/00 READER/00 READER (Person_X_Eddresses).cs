
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using PERSON_XEDDRESS_ROW	= CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class PersonEddressReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public PersonEddressReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public PersonEddressReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public PERSON_XEDDRESS_ROW ReadPersonEddress()
			{
				PERSON_XEDDRESS_ROW person_eddress;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					person_eddress = ReadRow();

					reader.Close();
					base.Connection.Close();
					return person_eddress;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadPersonEddresses()
			{
				Dictionary<int, BASE_ROW> person_eddresses = new Dictionary<int, BASE_ROW>();
				PERSON_XEDDRESS_ROW person_eddress;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						person_eddress = ReadRow();
						person_eddresses.Add( person_eddress.PkPerson_X_Eddress.Value, person_eddress );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return person_eddresses;
			}
			//___________________________________________________________________________________________________________________________________________
			private PERSON_XEDDRESS_ROW ReadRow()
			{
				PERSON_XEDDRESS_ROW person_x_eddress = new PERSON_XEDDRESS_ROW();

				person_x_eddress.Append( new COLUMNS.PK_Person_X_Eddress	( base.GetPrimaryKey	( ORDINAL.PkPerson_X_Eddress )	) );
				person_x_eddress.Append( new COLUMNS.FK_Person				( base.GetForeignKey	( ORDINAL.FkPerson )			) );
				person_x_eddress.Append( new COLUMNS.FK_Eddress				( base.GetForeignKey	( ORDINAL.FkEddress )			) );
				person_x_eddress.Append( new COLUMNS.ST_ListOrder			( base.GetShortText		( ORDINAL.ListOrder )			) );
				person_x_eddress.Append( new COLUMNS.ST_Label				( base.GetShortText		( ORDINAL.Label )				) );


				return person_x_eddress;
			}
		}
	}
}
