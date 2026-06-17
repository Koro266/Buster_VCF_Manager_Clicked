
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using PERSON_XGROUP_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XGROUP.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.PERSON.XGROUP.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.PERSON.XGROUP.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XGROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class PersonGroupReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public PersonGroupReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public PersonGroupReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public PERSON_XGROUP_ROW ReadPersonFamily()
			{
				PERSON_XGROUP_ROW person_group;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					person_group = ReadRow();

					reader.Close();
					base.Connection.Close();
					return person_group;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadPersonFamilys()
			{
				Dictionary<int, BASE_ROW> person_groups = new Dictionary<int, BASE_ROW>();
				PERSON_XGROUP_ROW person_group;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						person_group = ReadRow();
						person_groups.Add( person_group.PkPerson_X_Group.Value, person_group );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return person_groups;
			}
			//___________________________________________________________________________________________________________________________________________
			private PERSON_XGROUP_ROW ReadRow()
			{
				PERSON_XGROUP_ROW person_group = new PERSON_XGROUP_ROW();

				person_group.Append( new COLUMNS.PK_Person_X_Group		( base.GetPrimaryKey	( ORDINAL.PkPerson_X_Group )	) );
				person_group.Append( new COLUMNS.PK_Person				( base.GetForeignKey	( ORDINAL.PkPerson )			) );
				person_group.Append( new COLUMNS.PK_Group				( base.GetForeignKey	( ORDINAL.PkGroup )				) );
				person_group.Append( new COLUMNS.PK_Role				( base.GetForeignKey	( ORDINAL.PkRole )				) );
				person_group.Append( new COLUMNS.ST_GroupName			( base.GetShortText		( ORDINAL.GroupName )			) );
				person_group.Append( new COLUMNS.ST_Role				( base.GetShortText		( ORDINAL.Role )				) );

				return person_group;
			}
		}
	}
}
