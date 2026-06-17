//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{ }

		//_____________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Group_X_Address PkGroup_X_Address	{ get { return ( FIELD.PK_Group_X_Address )		base.GetField( ORDINAL.PkGroup_X_Address ); } }
		public FIELD.FK_Group FkGroup						{ get { return ( FIELD.FK_Group )				base.GetField( ORDINAL.FkGroup ); } }
		public FIELD.FK_Address FkAddress					{ get { return ( FIELD.FK_Address )				base.GetField( ORDINAL.FkAddress ); } }
	}
}
