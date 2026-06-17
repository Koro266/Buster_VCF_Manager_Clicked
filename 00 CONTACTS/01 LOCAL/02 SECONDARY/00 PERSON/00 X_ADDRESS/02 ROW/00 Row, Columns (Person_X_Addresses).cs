//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{ }

		//_____________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Person_X_Address PkPerson_X_Address	{ get { return ( FIELD.PK_Person_X_Address )	base.GetField( ORDINAL.PkPerson_X_Address ); } }
		public FIELD.FK_Person FkPerson						{ get { return ( FIELD.FK_Person )				base.GetField( ORDINAL.FkPerson ); } }
		public FIELD.FK_Address FkAddress					{ get { return ( FIELD.FK_Address )				base.GetField( ORDINAL.FkAddress ); } }
		public FIELD.ST_AddressType AddressType				{ get { return ( FIELD.ST_AddressType )			base.GetField( ORDINAL.AddressType ); } }
	}
}
