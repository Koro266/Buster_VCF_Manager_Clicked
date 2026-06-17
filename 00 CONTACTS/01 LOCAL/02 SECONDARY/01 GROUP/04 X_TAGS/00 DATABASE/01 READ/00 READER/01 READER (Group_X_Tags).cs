
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using GROUP_XTAG_ROW		= CONTACTS.LOCAL.SECONDARY.GROUP.XTAG.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.GROUP.XTAG.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.GROUP.XTAG.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XTAG
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class GroupTagReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public GroupTagReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public GroupTagReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public GROUP_XTAG_ROW ReadGroupTag()
			{
				GROUP_XTAG_ROW group_tag;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					group_tag = ReadRow();

					reader.Close();
					base.Connection.Close();
					return group_tag;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadGroupTags()
			{
				Dictionary<int, BASE_ROW> group_tags = new Dictionary<int, BASE_ROW>();
				GROUP_XTAG_ROW group_tag;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						group_tag = ReadRow();
						group_tags.Add( group_tag.PkGroup_X_Tag.Value, group_tag );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return group_tags;
			}
			//___________________________________________________________________________________________________________________________________________
			private GROUP_XTAG_ROW ReadRow()
			{
				GROUP_XTAG_ROW group_x_tag = new GROUP_XTAG_ROW();

				group_x_tag.Append( new COLUMNS.PK_Group_X_Tag	( base.GetPrimaryKey	( ORDINAL.PkGroup_X_Tag )	) );
				group_x_tag.Append( new COLUMNS.PK_Group		( base.GetForeignKey	( ORDINAL.PkGroup )			) );
				group_x_tag.Append( new COLUMNS.PK_SuperTag		( base.GetForeignKey	( ORDINAL.PkSuperTag )		) );
				group_x_tag.Append( new COLUMNS.PK_SubTag		( base.GetForeignKey	( ORDINAL.PkSubTag )		) );
				group_x_tag.Append( new COLUMNS.ST_SuperTag		( base.GetShortText		( ORDINAL.SuperTag )		) );
				group_x_tag.Append( new COLUMNS.ST_SubTag		( base.GetShortText		( ORDINAL.SubTag )			) );

				return group_x_tag;
			}
		}
	}
}
