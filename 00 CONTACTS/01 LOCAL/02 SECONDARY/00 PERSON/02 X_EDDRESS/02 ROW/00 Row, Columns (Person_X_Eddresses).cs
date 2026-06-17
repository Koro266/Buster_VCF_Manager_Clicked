//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Person_X_Eddress PkPerson_X_Eddress		{ get { return ( FIELD.PK_Person_X_Eddress )	base.GetField( CONST.OrdinalByName.PkPerson_X_Eddress ); } }
		public FIELD.FK_Person FkPerson							{ get { return ( FIELD.FK_Person )				base.GetField( CONST.OrdinalByName.FkPerson ); } }
		public FIELD.FK_Eddress FkEddress						{ get { return ( FIELD.FK_Eddress )				base.GetField( CONST.OrdinalByName.FkEddress ); } }
		public FIELD.ST_ListOrder ListOrder						{ get { return ( FIELD.ST_ListOrder )			base.GetField( CONST.OrdinalByName.ListOrder ); } }
		public FIELD.ST_Label Label								{ get { return ( FIELD.ST_Label )				base.GetField( CONST.OrdinalByName.Label ); } }
	}
}
