
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using GROUP_XPERSON_ROW		= CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class GroupPersonReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public GroupPersonReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public GroupPersonReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public GROUP_XPERSON_ROW ReadPersonFamily()
			{
				GROUP_XPERSON_ROW group_person;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					group_person = ReadRow();

					reader.Close();
					base.Connection.Close();
					return group_person;
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
				Dictionary<int, BASE_ROW> group_persons = new Dictionary<int, BASE_ROW>();
				GROUP_XPERSON_ROW group_person;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						group_person = ReadRow();
						group_persons.Add( group_person.PkGroup_X_Person.Value, group_person );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return group_persons;
			}
			//___________________________________________________________________________________________________________________________________________
			private GROUP_XPERSON_ROW ReadRow()
			{
				GROUP_XPERSON_ROW group_person = new GROUP_XPERSON_ROW();

				group_person.Append( new COLUMNS.PK_Group_X_Person		( base.GetPrimaryKey	( ORDINAL.PkGroup_X_Person )	) );
				group_person.Append( new COLUMNS.PK_Group				( base.GetForeignKey	( ORDINAL.PkGroup )				) );
				group_person.Append( new COLUMNS.PK_Person				( base.GetForeignKey	( ORDINAL.PkPerson )			) );
				group_person.Append( new COLUMNS.PK_Role				( base.GetForeignKey	( ORDINAL.PkRole )				) );
				group_person.Append( new COLUMNS.ST_PersonName			( base.GetShortText		( ORDINAL.PersonName )			) );
				group_person.Append( new COLUMNS.ST_Role				( base.GetShortText		( ORDINAL.Role )				) );

				return group_person;
			}
		}
	}
}
