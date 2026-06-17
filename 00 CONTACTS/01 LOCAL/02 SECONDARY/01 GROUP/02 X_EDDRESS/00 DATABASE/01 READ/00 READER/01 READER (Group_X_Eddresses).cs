
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using GROUP_XEDDRESS_ROW	= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class GroupEddressReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public GroupEddressReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public GroupEddressReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public GROUP_XEDDRESS_ROW ReadGroupEddress()
			{
				GROUP_XEDDRESS_ROW group_eddress;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					group_eddress = ReadRow();

					reader.Close();
					base.Connection.Close();
					return group_eddress;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadGroupEddresses()
			{
				Dictionary<int, BASE_ROW> group_eddresses = new Dictionary<int, BASE_ROW>();
				GROUP_XEDDRESS_ROW group_eddress;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						group_eddress = ReadRow();
						group_eddresses.Add( group_eddress.PkGroup_X_Eddress.Value, group_eddress );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return group_eddresses;
			}
			//___________________________________________________________________________________________________________________________________________
			private GROUP_XEDDRESS_ROW ReadRow()
			{
				GROUP_XEDDRESS_ROW group_x_eddress = new GROUP_XEDDRESS_ROW();

				group_x_eddress.Append( new COLUMNS.PK_Group_X_Eddress	( base.GetPrimaryKey	( ORDINAL.PkGroup_X_Eddress )	) );
				group_x_eddress.Append( new COLUMNS.FK_Group				( base.GetForeignKey	( ORDINAL.FkGroup )			) );
				group_x_eddress.Append( new COLUMNS.FK_Eddress				( base.GetForeignKey	( ORDINAL.FkEddress )			) );
				group_x_eddress.Append( new COLUMNS.ST_ListOrder			( base.GetShortText		( ORDINAL.ListOrder )			) );
				group_x_eddress.Append( new COLUMNS.ST_Label				( base.GetShortText		( ORDINAL.Label )				) );


				return group_x_eddress;
			}
		}
	}
}
