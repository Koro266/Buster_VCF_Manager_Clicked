
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW				= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using BASE_READER			= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//LOCAL
using PERSON_XTAG_ROW		= CONTACTS.LOCAL.SECONDARY.FAMILY.XTAG.Row;
using COLUMNS				= CONTACTS.LOCAL.SECONDARY.FAMILY.XTAG.Column;
using ORDINAL				= CONTACTS.LOCAL.SECONDARY.FAMILY.XTAG.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XTAG
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class FamilyTagReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public FamilyTagReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public FamilyTagReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//_______________________________________________________________________________________________________________________________________
			public PERSON_XTAG_ROW ReadFamilyTag()
			{
				PERSON_XTAG_ROW family_tag;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					family_tag = ReadRow();

					reader.Close();
					base.Connection.Close();
					return family_tag;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadFamilyTags()
			{
				Dictionary<int, BASE_ROW> family_tags = new Dictionary<int, BASE_ROW>();
				PERSON_XTAG_ROW family_tag;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						family_tag = ReadRow();
						family_tags.Add( family_tag.PkFamily_X_Tag.Value, family_tag );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return family_tags;
			}
			//___________________________________________________________________________________________________________________________________________
			private PERSON_XTAG_ROW ReadRow()
			{
				PERSON_XTAG_ROW family_x_tag = new PERSON_XTAG_ROW();

				family_x_tag.Append( new COLUMNS.PK_Family_X_Tag	( base.GetPrimaryKey	( ORDINAL.PkFamily_X_Tag )	) );
				family_x_tag.Append( new COLUMNS.PK_Family			( base.GetForeignKey	( ORDINAL.PkFamily )		) );
				family_x_tag.Append( new COLUMNS.PK_SuperTag		( base.GetForeignKey	( ORDINAL.PkSuperTag )		) );
				family_x_tag.Append( new COLUMNS.PK_SubTag			( base.GetForeignKey	( ORDINAL.PkSubTag )		) );
				family_x_tag.Append( new COLUMNS.ST_SuperTag		( base.GetShortText		( ORDINAL.SuperTag )		) );
				family_x_tag.Append( new COLUMNS.ST_SubTag			( base.GetShortText		( ORDINAL.SubTag )			) );

				return family_x_tag;
			}
		}
	}
}
