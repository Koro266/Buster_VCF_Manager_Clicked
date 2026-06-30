//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.PRIMARY.PERSON.Constants;
using FIELD		= CONTACTS.LOCAL.PRIMARY.PERSON.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//___________________________________________________________________________________________________________________________________________
		public Row( ) : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Person PkPerson					{ get { return ( FIELD.PK_Person )			base.GetField( CONST.OrdinalByName.PkPerson ); } }
		public FIELD.ST_SortableName SortableName		{ get { return ( FIELD.ST_SortableName )	base.GetField( CONST.OrdinalByName.SortableName ); } }
		public FIELD.ST_NaturalName NaturalName			{ get { return ( FIELD.ST_NaturalName )		base.GetField( CONST.OrdinalByName.NaturalName ); } }
		public FIELD.ST_UpperSurname UpperSurname		{ get { return ( FIELD.ST_UpperSurname )	base.GetField( CONST.OrdinalByName.UpperSurname ); } }
		public FIELD.ST_ProperSurname ProperSurname		{ get { return ( FIELD.ST_ProperSurname )	base.GetField( CONST.OrdinalByName.ProperSurname ); } }
		public FIELD.ST_GivenName GivenName				{ get { return ( FIELD.ST_GivenName )		base.GetField( CONST.OrdinalByName.GivenName ); } }
		public FIELD.ST_MiddleNames MiddleNames			{ get { return ( FIELD.ST_MiddleNames )		base.GetField( CONST.OrdinalByName.MiddleNames ); } }
		public FIELD.ST_NickName NickName				{ get { return ( FIELD.ST_NickName )		base.GetField( CONST.OrdinalByName.NickName ); } }
		public FIELD.ST_BirthName BirthName				{ get { return ( FIELD.ST_BirthName )		base.GetField( CONST.OrdinalByName.BirthName ); } }
		public FIELD.ST_Prefix Prefix					{ get { return ( FIELD.ST_Prefix )			base.GetField( CONST.OrdinalByName.Prefix ); } }
		public FIELD.ST_Suffix Suffix					{ get { return ( FIELD.ST_Suffix )			base.GetField( CONST.OrdinalByName.Suffix ); } }
		public FIELD.ST_Initials Initials				{ get { return ( FIELD.ST_Initials )		base.GetField( CONST.OrdinalByName.Initials ); } }
		public FIELD.ST_Gender Gender					{ get { return ( FIELD.ST_Gender )			base.GetField( CONST.OrdinalByName.Gender ); } }
		public FIELD.ST_Notes Notes						{ get { return ( FIELD.ST_Notes )			base.GetField( CONST.OrdinalByName.Notes ); } }
		public FIELD.DT_BirthDate BirthDate				{ get { return ( FIELD.DT_BirthDate )		base.GetField( CONST.OrdinalByName.BirthDate ); } }
		public FIELD.DT_DeathDate DeathDate				{ get { return ( FIELD.DT_DeathDate )		base.GetField( CONST.OrdinalByName.DeathDate ); } }
		public FIELD.DT_WeddingDate WeddingDate			{ get { return ( FIELD.DT_WeddingDate )		base.GetField( CONST.OrdinalByName.WeddingDate ); } }
		public FIELD.DT_CurrencyDate CurrencyDate		{ get { return ( FIELD.DT_CurrencyDate )	base.GetField( CONST.OrdinalByName.CurrencyDate ); } }
		public FIELD.LI_EHS_Order EHS_Order				{ get { return ( FIELD.LI_EHS_Order )		base.GetField( CONST.OrdinalByName.EHS_Order ); } }
		public FIELD.IS_Selected Selected				{ get { return ( FIELD.IS_Selected )		base.GetField( CONST.OrdinalByName.Selected ); } }
		public FIELD.IS_Enlightened Enlightened			{ get { return ( FIELD.IS_Enlightened )		base.GetField( CONST.OrdinalByName.Enlightened ); } }
		public FIELD.IS_HolySomething HolySomething		{ get { return ( FIELD.IS_HolySomething )	base.GetField( CONST.OrdinalByName.HolySomething ); } }
		public FIELD.IS_NewLeftPerson NewLeftPerson		{ get { return ( FIELD.IS_NewLeftPerson )	base.GetField( CONST.OrdinalByName.NewLeftPerson ); } }
		public FIELD.IS_NoRightPerson NoRightPerson		{ get { return ( FIELD.IS_NoRightPerson )	base.GetField( CONST.OrdinalByName.NoRightPerson ); } }
		public FIELD.IS_DefaultRow DefaultRow			{ get { return ( FIELD.IS_DefaultRow )		base.GetField( CONST.OrdinalByName.DefaultRow ); } }
		public FIELD.IS_Export Export					{ get { return ( FIELD.IS_Export )			base.GetField( CONST.OrdinalByName.Export ); } }
		public FIELD.IS_TimeTalent TimeTalent			{ get { return ( FIELD.IS_TimeTalent )		base.GetField( CONST.OrdinalByName.TimeTalent ); } }
		public FIELD.IS_Minister Minister				{ get { return ( FIELD.IS_Minister )		base.GetField( CONST.OrdinalByName.Minister ); } }
		public FIELD.IS_Sacristan Sacristan				{ get { return ( FIELD.IS_Sacristan )		base.GetField( CONST.OrdinalByName.Sacristan ); } }
		public FIELD.IS_Vigil Vigil						{ get { return ( FIELD.IS_Vigil )			base.GetField( CONST.OrdinalByName.Vigil ); } }
		public FIELD.IS_Mass Mass						{ get { return ( FIELD.IS_Mass )			base.GetField( CONST.OrdinalByName.Mass ); } }

	}
}
