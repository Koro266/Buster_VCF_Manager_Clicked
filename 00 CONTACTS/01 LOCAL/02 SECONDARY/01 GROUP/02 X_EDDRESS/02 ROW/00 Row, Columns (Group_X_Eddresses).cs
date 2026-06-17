//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Group_X_Eddress PkGroup_X_Eddress		{ get { return ( FIELD.PK_Group_X_Eddress )	base.GetField( CONST.OrdinalByName.PkGroup_X_Eddress ); } }
		public FIELD.FK_Group FkGroup							{ get { return ( FIELD.FK_Group )				base.GetField( CONST.OrdinalByName.FkGroup ); } }
		public FIELD.FK_Eddress FkEddress						{ get { return ( FIELD.FK_Eddress )				base.GetField( CONST.OrdinalByName.FkEddress ); } }
		public FIELD.ST_ListOrder ListOrder						{ get { return ( FIELD.ST_ListOrder )			base.GetField( CONST.OrdinalByName.ListOrder ); } }
		public FIELD.ST_Label Label								{ get { return ( FIELD.ST_Label )				base.GetField( CONST.OrdinalByName.Label ); } }
	}
}
