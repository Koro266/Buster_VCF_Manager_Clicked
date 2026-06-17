//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.GROUP.XTAG.Constants;
using FIELD		= CONTACTS.LOCAL.SECONDARY.GROUP.XTAG.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XTAG
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Group_X_Tag PkGroup_X_Tag	{ get { return ( FIELD.PK_Group_X_Tag )	base.GetField( CONST.OrdinalByName.PkGroup_X_Tag ); } }
		public FIELD.PK_Group PkGroup				{ get { return ( FIELD.PK_Group )			base.GetField( CONST.OrdinalByName.PkGroup ); } }
		public FIELD.PK_SuperTag PkSuperTag			{ get { return ( FIELD.PK_SuperTag )		base.GetField( CONST.OrdinalByName.PkSuperTag ); } }
		public FIELD.PK_SubTag PksubTag				{ get { return ( FIELD.PK_SubTag )			base.GetField( CONST.OrdinalByName.PkSubTag ); } }
		public FIELD.ST_SuperTag SuperTag			{ get { return ( FIELD.ST_SuperTag )		base.GetField( CONST.OrdinalByName.SuperTag ); } }
		public FIELD.ST_SubTag SubTag				{ get { return ( FIELD.ST_SubTag )			base.GetField( CONST.OrdinalByName.SubTag ); } }
	}
}
