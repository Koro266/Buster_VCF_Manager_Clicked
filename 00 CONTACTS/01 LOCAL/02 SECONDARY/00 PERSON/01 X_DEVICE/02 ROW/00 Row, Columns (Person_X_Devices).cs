//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{ }

		//_____________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Person_X_Device PkPerson_X_Device	{ get { return ( FIELD.PK_Person_X_Device )	base.GetField( ORDINAL.PkPerson_X_Device ); } }
		public FIELD.FK_Person FkPerson						{ get { return ( FIELD.FK_Person )			base.GetField( ORDINAL.FkPerson ); } }
		public FIELD.FK_Device FkDevice						{ get { return ( FIELD.FK_Device )			base.GetField( ORDINAL.FkDevice ); } }
		public FIELD.ST_ListOrder ListOrder					{ get { return ( FIELD.ST_ListOrder )		base.GetField( ORDINAL.ListOrder ); } }
		public FIELD.ST_Label Label							{ get { return ( FIELD.ST_Label )			base.GetField( ORDINAL.Label ); } }
	}
}
