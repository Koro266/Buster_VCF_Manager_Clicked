//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.FAMILY.XTAG.Constants;
using FIELD		= CONTACTS.LOCAL.SECONDARY.FAMILY.XTAG.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XTAG
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Family_X_Tag PkFamily_X_Tag	{ get { return ( FIELD.PK_Family_X_Tag )	base.GetField( CONST.OrdinalByName.PkFamily_X_Tag ); } }
		public FIELD.PK_Family PkFamily				{ get { return ( FIELD.PK_Family )			base.GetField( CONST.OrdinalByName.PkFamily ); } }
		public FIELD.PK_SuperTag PkSuperTag			{ get { return ( FIELD.PK_SuperTag )		base.GetField( CONST.OrdinalByName.PkSuperTag ); } }
		public FIELD.PK_SubTag PksubTag				{ get { return ( FIELD.PK_SubTag )			base.GetField( CONST.OrdinalByName.PkSubTag ); } }
		public FIELD.ST_SuperTag SuperTag			{ get { return ( FIELD.ST_SuperTag )		base.GetField( CONST.OrdinalByName.SuperTag ); } }
		public FIELD.ST_SubTag SubTag				{ get { return ( FIELD.ST_SubTag )			base.GetField( CONST.OrdinalByName.SubTag ); } }
	}
}
