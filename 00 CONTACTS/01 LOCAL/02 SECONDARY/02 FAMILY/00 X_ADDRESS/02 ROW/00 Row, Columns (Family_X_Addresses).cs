//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{ }

		//_____________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Family_X_Address PkFamily_X_Address	{ get { return ( FIELD.PK_Family_X_Address )	base.GetField( ORDINAL.PkFamily_X_Address ); } }
		public FIELD.FK_Family FkFamily						{ get { return ( FIELD.FK_Family )				base.GetField( ORDINAL.FkFamily ); } }
		public FIELD.FK_Address FkAddress					{ get { return ( FIELD.FK_Address )				base.GetField( ORDINAL.FkAddress ); } }
		public FIELD.ST_AddressType AddressType				{ get { return ( FIELD.ST_AddressType )			base.GetField( ORDINAL.AddressType ); } }
	}
}
