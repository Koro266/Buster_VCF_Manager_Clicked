
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using FAMILY_XEDDRESS_ROW	= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class FamilyEddressReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public FamilyEddressReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public FamilyEddressReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public FAMILY_XEDDRESS_ROW ReadFamilyEddress()
			{
				FAMILY_XEDDRESS_ROW family_eddress;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					family_eddress = ReadRow();

					reader.Close();
					base.Connection.Close();
					return family_eddress;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadFamilyEddresses()
			{
				Dictionary<int, BASE_ROW> family_eddresses = new Dictionary<int, BASE_ROW>();
				FAMILY_XEDDRESS_ROW family_eddress;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						family_eddress = ReadRow();
						family_eddresses.Add( family_eddress.PkFamily_X_Eddress.Value, family_eddress );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return family_eddresses;
			}
			//___________________________________________________________________________________________________________________________________________
			private FAMILY_XEDDRESS_ROW ReadRow()
			{
				FAMILY_XEDDRESS_ROW family_x_eddress = new FAMILY_XEDDRESS_ROW();

				family_x_eddress.Append( new COLUMNS.PK_Family_X_Eddress	( base.GetPrimaryKey	( ORDINAL.PkFamily_X_Eddress )	) );
				family_x_eddress.Append( new COLUMNS.FK_Family				( base.GetForeignKey	( ORDINAL.FkFamily )			) );
				family_x_eddress.Append( new COLUMNS.FK_Eddress				( base.GetForeignKey	( ORDINAL.FkEddress )			) );
				family_x_eddress.Append( new COLUMNS.ST_Eddress				( base.GetShortText		( ORDINAL.Eddress )				) );

				return family_x_eddress;
			}
		}
	}
}
