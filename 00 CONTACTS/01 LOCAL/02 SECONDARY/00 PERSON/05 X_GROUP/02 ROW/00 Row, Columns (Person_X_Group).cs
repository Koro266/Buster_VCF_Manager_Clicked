//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.PERSON.XGROUP.Constants;
using FIELD		= CONTACTS.LOCAL.SECONDARY.PERSON.XGROUP.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XGROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Person_X_Group PkPerson_X_Group { get { return ( FIELD.PK_Person_X_Group )	base.GetField( CONST.OrdinalByName.PkPerson_X_Group ); } }
		public FIELD.PK_Person PkPerson					{ get { return ( FIELD.PK_Person )			base.GetField( CONST.OrdinalByName.PkPerson ); } }
		public FIELD.PK_Group PkGroup					{ get { return ( FIELD.PK_Group )			base.GetField( CONST.OrdinalByName.PkGroup ); } }
		public FIELD.PK_Role PkRole						{ get { return ( FIELD.PK_Role )			base.GetField( CONST.OrdinalByName.PkRole ); } }
		public FIELD.ST_GroupName GroupName				{ get { return ( FIELD.ST_GroupName )		base.GetField( CONST.OrdinalByName.GroupName ); } }
		public FIELD.ST_Role Role						{ get { return ( FIELD.ST_Role )			base.GetField( CONST.OrdinalByName.Role ); } }
	}
}
