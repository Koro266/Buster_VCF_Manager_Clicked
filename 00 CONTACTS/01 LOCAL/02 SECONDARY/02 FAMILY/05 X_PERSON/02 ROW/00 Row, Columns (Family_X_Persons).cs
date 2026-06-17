//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.FAMILY.XPERSON.Constants;
using FIELD		= CONTACTS.LOCAL.SECONDARY.FAMILY.XPERSON.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XPERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Family_X_Person PkFamily_X_Person	{ get { return ( FIELD.PK_Family_X_Person)	base.GetField( CONST.OrdinalByName.PkFamily_X_Person ); } }
		public FIELD.PK_Family PkFamily						{ get { return ( FIELD.PK_Family )			base.GetField( CONST.OrdinalByName.PkFamily ); } }
		public FIELD.PK_Person PkPerson						{ get { return ( FIELD.PK_Person )			base.GetField( CONST.OrdinalByName.PkPerson ); } }
		public FIELD.PK_Role PkRole							{ get { return ( FIELD.PK_Role )			base.GetField( CONST.OrdinalByName.PkRole ); } }
		public FIELD.ST_PersonName PersonName				{ get { return ( FIELD.ST_PersonName )		base.GetField( CONST.OrdinalByName.PersonName ); } }
		public FIELD.ST_Role Role							{ get { return ( FIELD.ST_Role )			base.GetField( CONST.OrdinalByName.Role ); } }
	}
}
