

//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
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
		public partial class FamilyReader
		{
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadPersonedFamilies()
			{
				Dictionary<int, BASE_ROW> personed_familys = new Dictionary<int, BASE_ROW>();
				FAMILY_ROW family;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						family = ReadPersonedRow();
						personed_familys.Add( family.PkFamily.Value, family );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return personed_familys;
			}
			//___________________________________________________________________________________________________________________________________________
			private FAMILY_ROW ReadPersonedRow()
			{
				FAMILY_ROW family = new FAMILY_ROW();

				family.Append( new FIELD.PK_Family				( base.GetPrimaryKey	( ORDINAL.PkFamily ) ) );
				family.Append( new FIELD.FK_LeftPerson			( base.GetForeignKey	( ORDINAL.FkLeftPerson ) ) );
				family.Append( new FIELD.FK_RightPerson			( base.GetForeignKey	( ORDINAL.FkRightPerson ) ) );
				family.Append( new FIELD.ST_FamilyType			( base.GetShortText		( ORDINAL.FamilyType ) ) );
				family.Append( new FIELD.ST_FamilyName			( base.GetShortText		( ORDINAL.FamilyName ) ) );
				family.Append( new FIELD.ST_SortableName		( base.GetShortText		( ORDINAL.SortableName ) ) );
				family.Append( new FIELD.ST_JointName			( base.GetShortText		( ORDINAL.JointName ) ) );
				family.Append( new FIELD.ST_NaturalName			( base.GetShortText		( ORDINAL.NaturalName ) ) );
				family.Append( new FIELD.ST_PostalName			( base.GetShortText		( ORDINAL.PostalName ) ) );
				family.Append( new FIELD.ST_Notes				( base.GetShortText		( ORDINAL.Notes ) ) );
				family.Append( new FIELD.DT_WeddingDate			( base.GetDateTime		( ORDINAL.WeddingDate ) ) );
				family.Append( new FIELD.DT_CurrencyDate		( base.GetDateTime		( ORDINAL.CurrencyDate ) ) );

				family.Append( new FIELD.IS_Selected			( base.GetBoolean		( ORDINAL.Selected )));
				family.Append( new FIELD.IS_DefaultRow			( base.GetBoolean		( ORDINAL.DefaultRow )));
				family.Append( new FIELD.IS_Export				( base.GetBoolean		( ORDINAL.Export )));
				family.Append( new FIELD.IS_Blocked				( base.GetBoolean		( ORDINAL.Blocked )));
				family.Append( new FIELD.IS_Inactive			( base.GetBoolean		( ORDINAL.Inactive )));
				family.Append( new FIELD.IS_Christmas			( base.GetBoolean		( ORDINAL.Christmas )));
				family.Append( new FIELD.IS_ExChristmas			( base.GetBoolean		( ORDINAL.ExChristmas )));
				family.Append( new FIELD.IS_Dissolved			( base.GetBoolean		( ORDINAL.Dissolved )));
				family.Append( new FIELD.IS_CorlettRd			( base.GetBoolean		( ORDINAL.CorlettRd )));
				family.Append( new FIELD.IS_StTheresa			( base.GetBoolean		( ORDINAL.StTheresa ) ));

				family.Append( new FIELD.ST_LeftUpperSurname	( base.GetShortText		(ORDINAL.LeftUpperSurname ) ) );
				family.Append( new FIELD.ST_LeftProperSurname	( base.GetShortText		(ORDINAL.LeftProperSurname ) ) );
				family.Append( new FIELD.ST_LeftGivenName		( base.GetShortText		(ORDINAL.LeftGivenName ) ) );
				family.Append( new FIELD.ST_RightUpperSurname	( base.GetShortText		(ORDINAL.RightUpperSurname ) ) );
				family.Append( new FIELD.ST_RightProperSurname	( base.GetShortText		(ORDINAL.RightProperSurname ) ) );
				family.Append( new FIELD.ST_RightGivenName		( base.GetShortText		(ORDINAL.RightGivenName ) ) );

				return family;
			}
		}
	}
}
