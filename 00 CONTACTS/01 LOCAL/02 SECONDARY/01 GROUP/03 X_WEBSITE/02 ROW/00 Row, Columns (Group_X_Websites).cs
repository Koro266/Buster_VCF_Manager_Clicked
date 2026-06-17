//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XWEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Group_X_Website PkGroup_X_Website	{ get { return ( FIELD.PK_Group_X_Website )		base.GetField( CONST.OrdinalByName.PkGroup_X_Website ); } }
		public FIELD.FK_Group FkGroup						{ get { return ( FIELD.FK_Group )				base.GetField( CONST.OrdinalByName.FkGroup ); } }
		public FIELD.FK_Website FkWebsite					{ get { return ( FIELD.FK_Website )				base.GetField( CONST.OrdinalByName.FkWebsite ); } }
		public FIELD.ST_Website Website						{ get { return ( FIELD.ST_Website )				base.GetField( CONST.OrdinalByName.Website ); } }
	}
}
