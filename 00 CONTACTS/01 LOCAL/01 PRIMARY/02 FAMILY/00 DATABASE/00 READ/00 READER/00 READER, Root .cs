
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_READER	= CONTACTS.GLOBAL.DATABASE.READ.BaseReader;
//FAMILY
using FAMILY_ROW	= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using FIELD			= CONTACTS.LOCAL.PRIMARY.FAMILY.Column;
using ORDINAL		= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class FamilyReader : BASE_READER
		{
			//___________________________________________________________________________________________________________________________________________
			public FamilyReader( string sql_text ) : base( sql_text )
			{
			}
			//___________________________________________________________________________________________________________________________________________
			public FamilyReader( string sql_text, OleDbParameter parameter ) : base( sql_text )
			{
				base.DbCommand.Parameters.Add( parameter );
			}
			//___________________________________________________________________________________________________________________________________________
			private FAMILY_ROW ReadRow()
			{
				FAMILY_ROW family = new FAMILY_ROW();

				family.Append( new FIELD.PK_Family			( base.GetPrimaryKey	( ORDINAL.PkFamily )		) );
				family.Append( new FIELD.FK_LeftPerson		( base.GetForeignKey	( ORDINAL.FkLeftPerson )	) );
				family.Append( new FIELD.FK_RightPerson		( base.GetForeignKey	( ORDINAL.FkRightPerson )	) );
				family.Append( new FIELD.ST_FamilyType		( base.GetShortText		( ORDINAL.FamilyType )		) );
				family.Append( new FIELD.ST_FamilyName		( base.GetShortText		( ORDINAL.FamilyName )		) );
				family.Append( new FIELD.ST_SortableName	( base.GetShortText		( ORDINAL.SortableName )	) );
				family.Append( new FIELD.ST_JointName		( base.GetShortText		( ORDINAL.JointName )		) );
				family.Append( new FIELD.ST_NaturalName		( base.GetShortText		( ORDINAL.NaturalName )		) );
				family.Append( new FIELD.ST_PostalName		( base.GetShortText		( ORDINAL.PostalName )		) );
				family.Append( new FIELD.ST_Notes			( base.GetShortText		( ORDINAL.Notes )			) );
				family.Append( new FIELD.DT_WeddingDate		( base.GetDateTime		( ORDINAL.WeddingDate )		) );
				family.Append( new FIELD.DT_CurrencyDate	( base.GetDateTime		( ORDINAL.CurrencyDate )	) );
				family.Append( new FIELD.IS_Christmas		( base.GetBoolean		( ORDINAL.Christmas )		) );
				family.Append( new FIELD.IS_Dissolved		( base.GetBoolean		( ORDINAL.Dissolved )		) );
				family.Append( new FIELD.IS_CorlettRd		( base.GetBoolean		( ORDINAL.CorlettRd )		) );
				family.Append( new FIELD.IS_StTheresa		( base.GetBoolean		( ORDINAL.StTheresa )		) );

				return family;
			}
		}
	}
}
