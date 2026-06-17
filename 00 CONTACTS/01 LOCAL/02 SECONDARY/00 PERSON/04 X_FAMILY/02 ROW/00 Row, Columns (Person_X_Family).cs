//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY.Constants;
using FIELD		= CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XFAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Person_X_Family PkPerson_X_Family	{ get { return ( FIELD.PK_Person_X_Family)	base.GetField( CONST.OrdinalByName.PkPerson_X_Family ); } }
		public FIELD.PK_Person PkPerson						{ get { return ( FIELD.PK_Person )			base.GetField( CONST.OrdinalByName.PkPerson ); } }
		public FIELD.PK_Family PkFamily						{ get { return ( FIELD.PK_Family )			base.GetField( CONST.OrdinalByName.PkFamily ); } }
		public FIELD.PK_Role PkRole							{ get { return ( FIELD.PK_Role )			base.GetField( CONST.OrdinalByName.PkRole ); } }
		public FIELD.ST_FamilyName FamilyName				{ get { return ( FIELD.ST_FamilyName )		base.GetField( CONST.OrdinalByName.FamilyName ); } }
		public FIELD.ST_Role Role							{ get { return ( FIELD.ST_Role )			base.GetField( CONST.OrdinalByName.Role ); } }
	}
}
