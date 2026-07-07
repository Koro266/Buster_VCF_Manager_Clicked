//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST			= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants;
using FIELD			= CONTACTS.LOCAL.PRIMARY.FAMILY.Column;
using PERSON_ROW	= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using PERSON_SELECT = CONTACTS.LOCAL.PRIMARY.PERSON.Database.Select.ByPkPerson;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		#region DECLARATIONS
		#endregion

		//___________________________________________________________________________________________________________________________________________
		public Row( ) : base( CONST.ColumnCount )
		{
		}
		//_________________________________________________________(_CASTING TYPE_)__________________________________________________________________
		public FIELD.PK_Family PkFamily							{ get { return ( FIELD.PK_Family )				base.GetField( CONST.OrdinalByName.PkFamily ); } }
		public FIELD.FK_LeftPerson FkLeftPerson					{ get { return ( FIELD.FK_LeftPerson )			base.GetField( CONST.OrdinalByName.FkLeftPerson ); } }
		public FIELD.FK_RightPerson FkRightPerson				{ get { return ( FIELD.FK_RightPerson )			base.GetField( CONST.OrdinalByName.FkRightPerson ); } }
		public FIELD.ST_FamilyType FamilyType					{ get { return ( FIELD.ST_FamilyType )			base.GetField( CONST.OrdinalByName.FamilyType ); } }
		public FIELD.ST_FamilyName FamilyName					{ get { return ( FIELD.ST_FamilyName )			base.GetField( CONST.OrdinalByName.FamilyName ); } }
		public FIELD.ST_SortableName SortableName				{ get { return ( FIELD.ST_SortableName )		base.GetField( CONST.OrdinalByName.SortableName ); } }
		public FIELD.ST_JointName JointName						{ get { return ( FIELD.ST_JointName )			base.GetField( CONST.OrdinalByName.JointName ); } }
		public FIELD.ST_NaturalName NaturalName					{ get { return ( FIELD.ST_NaturalName )			base.GetField( CONST.OrdinalByName.NaturalName ); } }
		public FIELD.ST_PostalName PostalName					{ get { return ( FIELD.ST_PostalName )			base.GetField( CONST.OrdinalByName.PostalName ); } }
		public FIELD.ST_Notes Notes								{ get { return ( FIELD.ST_Notes )				base.GetField( CONST.OrdinalByName.Notes ); } }
		public FIELD.DT_WeddingDate WeddingDate					{ get { return ( FIELD.DT_WeddingDate )			base.GetField( CONST.OrdinalByName.WeddingDate ); } }
		public FIELD.DT_CurrencyDate CurrencyDate				{ get { return ( FIELD.DT_CurrencyDate )		base.GetField( CONST.OrdinalByName.CurrencyDate ); } }

		public FIELD.IS_Selected Selected						{ get { return ( FIELD.IS_Selected )			base.GetField( CONST.OrdinalByName.Selected ); } }
		public FIELD.IS_DefaultRow DefaultRow					{ get { return ( FIELD.IS_DefaultRow )			base.GetField( CONST.OrdinalByName.DefaultRow ); } }
		public FIELD.IS_Export Export							{ get { return ( FIELD.IS_Export )				base.GetField( CONST.OrdinalByName.Export ); } }
		public FIELD.IS_Blocked Blocked							{ get { return ( FIELD.IS_Blocked )				base.GetField( CONST.OrdinalByName.Blocked ); } }
		public FIELD.IS_Inactive Inactive						{ get { return ( FIELD.IS_Inactive )			base.GetField( CONST.OrdinalByName.Inactive ); } }
		public FIELD.IS_Christmas Christmas						{ get { return ( FIELD.IS_Christmas )			base.GetField( CONST.OrdinalByName.Christmas ); } }
		public FIELD.IS_ExChristmas ExChristmas					{ get { return ( FIELD.IS_ExChristmas )			base.GetField( CONST.OrdinalByName.ExChristmas ); } }
		public FIELD.IS_Dissolved Dissolved						{ get { return ( FIELD.IS_Dissolved )			base.GetField( CONST.OrdinalByName.Dissolved ); } }
		public FIELD.IS_CorlettRd CorlettRd						{ get { return ( FIELD.IS_CorlettRd )			base.GetField( CONST.OrdinalByName.CorlettRd ); } }
		public FIELD.IS_StTheresa StTheresa						{ get { return ( FIELD.IS_StTheresa )			base.GetField( CONST.OrdinalByName.StTheresa ); } }
		
		public FIELD.ST_LeftUpperSurname LeftUpperSurname		{ get { return ( FIELD.ST_LeftUpperSurname )	base.GetField( CONST.OrdinalByName.LeftUpperSurname ); } }
		public FIELD.ST_LeftProperSurname LeftProperSurname		{ get { return ( FIELD.ST_LeftProperSurname )	base.GetField( CONST.OrdinalByName.LeftProperSurname ); } }
		public FIELD.ST_LeftGivenName LeftGivenName				{ get { return ( FIELD.ST_LeftGivenName )		base.GetField( CONST.OrdinalByName.LeftGivenName ); } }
		public FIELD.ST_RightUpperSurname RightUpperSurname		{ get { return ( FIELD.ST_RightUpperSurname )	base.GetField( CONST.OrdinalByName.RightUpperSurname ); } }
		public FIELD.ST_RightProperSurname RightProperSurname	{ get { return ( FIELD.ST_RightProperSurname )	base.GetField( CONST.OrdinalByName.RightProperSurname ); } }
		public FIELD.ST_RightGivenName RightGivenName			{ get { return ( FIELD.ST_RightGivenName )		base.GetField( CONST.OrdinalByName.RightGivenName ); } }

		//___________________________________________________________________________________________________________________________________________
		public PERSON_ROW LeftPerson
		{
			get { return new PERSON_SELECT( FkLeftPerson.Value ).Execute; }
		}
		//___________________________________________________________________________________________________________________________________________
		public PERSON_ROW RightPerson
		{
			get { return new PERSON_SELECT( FkRightPerson.Value ).Execute; }
		}
	}
}
