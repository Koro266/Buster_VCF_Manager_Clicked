//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON.Constants;
using FIELD		= CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XPERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Group_X_Person PkGroup_X_Person { get { return ( FIELD.PK_Group_X_Person )	base.GetField( CONST.OrdinalByName.PkGroup_X_Person ); } }
		public FIELD.PK_Person PkPerson					{ get { return ( FIELD.PK_Person )			base.GetField( CONST.OrdinalByName.PkPerson ); } }
		public FIELD.PK_Group PkGroup					{ get { return ( FIELD.PK_Group )			base.GetField( CONST.OrdinalByName.PkGroup ); } }
		public FIELD.PK_Role PkRole						{ get { return ( FIELD.PK_Role )			base.GetField( CONST.OrdinalByName.PkRole ); } }
		public FIELD.ST_PersonName PersonName			{ get { return ( FIELD.ST_PersonName )		base.GetField( CONST.OrdinalByName.PersonName ); } }
		public FIELD.ST_Role Role						{ get { return ( FIELD.ST_Role )			base.GetField( CONST.OrdinalByName.Role ); } }
	}
}
