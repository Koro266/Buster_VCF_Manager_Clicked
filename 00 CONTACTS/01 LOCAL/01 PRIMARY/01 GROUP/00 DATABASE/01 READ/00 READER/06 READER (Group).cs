//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER	= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using GROUP_ROW		= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using FIELD			= CONTACTS.LOCAL.PRIMARY.GROUP.Column;
using ORDINAL		= CONTACTS.LOCAL.PRIMARY.GROUP.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class GroupReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public GroupReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public GroupReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public GROUP_ROW ReadGroup()
			{
				GROUP_ROW group;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					group = ReadRow();

					reader.Close();
					base.Connection.Close();
					return group;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadGroups()
			{
				Dictionary<int, BASE_ROW> all_groups = new Dictionary<int, BASE_ROW>();
				GROUP_ROW group;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						group = ReadRow();
						all_groups.Add( group.PkGroup.Value, group );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return all_groups;
			}
			//___________________________________________________________________________________________________________________________________________
			private GROUP_ROW ReadRow()
			{
				GROUP_ROW group = new GROUP_ROW();

				group.Append( new FIELD.PK_Group		( base.GetPrimaryKey	( ORDINAL.PkGroup)		) );
				group.Append( new FIELD.ST_GroupName	( base.GetText			( ORDINAL.GroupName)	) );
				group.Append( new FIELD.ST_GroupType	( base.GetText			( ORDINAL.GroupType)	) );
				group.Append( new FIELD.ST_Notes		( base.GetText			( ORDINAL.Notes)		) );
				group.Append( new FIELD.DT_CurrencyDate	( base.GetDateTime		( ORDINAL.CurrencyDate)	) );
				group.Append( new FIELD.IS_Selected		( base.GetBoolean		( ORDINAL.Selected)		) );
				group.Append( new FIELD.IS_DefaultRow	( base.GetBoolean		( ORDINAL.DefaultRow)	) );
				group.Append( new FIELD.IS_Export		( base.GetBoolean		( ORDINAL.Export)		) );
				group.Append( new FIELD.IS_Blocked		( base.GetBoolean		( ORDINAL.Blocked)		) );
				group.Append( new FIELD.IS_Inactive		( base.GetBoolean		( ORDINAL.Inactive)		) );
				group.Append( new FIELD.IS_StTheresa	( base.GetBoolean		( ORDINAL.StTheresa)	) );
				group.Append( new FIELD.IS_Tradesman	( base.GetBoolean		( ORDINAL.Tradesman)	) );
				group.Append( new FIELD.IS_Supplier		( base.GetBoolean		( ORDINAL.Supplier)		) );
				group.Append( new FIELD.IS_Writer		( base.GetBoolean		( ORDINAL.Writer)		) );

				return group;
			}
		}
	}
}
