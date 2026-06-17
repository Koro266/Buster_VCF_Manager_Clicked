//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.FAMILY.XNOTE.Constants;
using FIELD		= CONTACTS.LOCAL.SECONDARY.FAMILY.XNOTE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XNOTE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Family_X_Note PkFamily_X_Note	{ get { return ( FIELD.PK_Family_X_Note )	base.GetField( CONST.OrdinalByName.PkFamily_X_Note ); } }
		public FIELD.FK_Family FkFamily					{ get { return ( FIELD.FK_Family )			base.GetField( CONST.OrdinalByName.FkFamily ); } }
		public FIELD.LT_Note Note						{ get { return ( FIELD.LT_Note )			base.GetField( CONST.OrdinalByName.Note ); } }
	}
}
