//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.TERTIARY.ROLE.Constants;
using ORDINAL	= CONTACTS.LOCAL.TERTIARY.ROLE.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.TERTIARY.ROLE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ROLE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________(_CASTING_)_______________________________________________________________
		public FIELD.PK_Role	PkRole	{ get { return ( FIELD.PK_Role )	base.GetField( ORDINAL.PkRole ); } }
		public FIELD.ST_Role	Role	{ get { return ( FIELD.ST_Role )	base.GetField( ORDINAL.Role ); } }
	}
}
