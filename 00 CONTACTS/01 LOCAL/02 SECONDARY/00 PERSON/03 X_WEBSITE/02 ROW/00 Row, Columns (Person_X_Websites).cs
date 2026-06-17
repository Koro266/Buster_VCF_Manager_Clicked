//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.PERSON.XWEBSITE.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.PERSON.XWEBSITE.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.SECONDARY.PERSON.XWEBSITE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XWEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Person_X_Website PkPerson_X_Website		{ get { return ( FIELD.PK_Person_X_Website )	base.GetField( CONST.OrdinalByName.PkPerson_X_Website ); } }
		public FIELD.FK_Person FkPerson							{ get { return ( FIELD.FK_Person )				base.GetField( CONST.OrdinalByName.FkPerson ); } }
		public FIELD.FK_Website FkWebsite						{ get { return ( FIELD.FK_Website )				base.GetField( CONST.OrdinalByName.FkWebsite ); } }
		public FIELD.ST_Website Website							{ get { return ( FIELD.ST_Website )				base.GetField( CONST.OrdinalByName.Website ); } }
		public FIELD.ST_Notes Notes								{ get { return ( FIELD.ST_Notes )				base.GetField( CONST.OrdinalByName.Notes ); } }
	}
}
