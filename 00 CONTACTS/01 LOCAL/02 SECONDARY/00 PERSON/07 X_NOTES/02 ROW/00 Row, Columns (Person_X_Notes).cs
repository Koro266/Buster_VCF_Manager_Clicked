//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.PERSON.XNOTE.Constants;
using FIELD		= CONTACTS.LOCAL.SECONDARY.PERSON.XNOTE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XNOTE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Person_X_Note PkPerson_X_Note	{ get { return ( FIELD.PK_Person_X_Note )	base.GetField( CONST.OrdinalByName.PkPerson_X_Note ); } }
		public FIELD.PK_Person PkPerson					{ get { return ( FIELD.PK_Person )			base.GetField( CONST.OrdinalByName.PkPerson ); } }
		public FIELD.LT_Note Note						{ get { return ( FIELD.LT_Note )			base.GetField( CONST.OrdinalByName.Note ); } }
	}
}
