//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE.Constants;
using FIELD		= CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XNOTE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Group_X_Note PkGroup_X_Note	{ get { return ( FIELD.PK_Group_X_Note )	base.GetField( CONST.OrdinalByName.PkGroup_X_Note ); } }
		public FIELD.PK_Group PkGroup				{ get { return ( FIELD.PK_Group )			base.GetField( CONST.OrdinalByName.PkGroup ); } }
		public FIELD.LT_Note Note					{ get { return ( FIELD.LT_Note )			base.GetField( CONST.OrdinalByName.Note ); } }
	}
}
