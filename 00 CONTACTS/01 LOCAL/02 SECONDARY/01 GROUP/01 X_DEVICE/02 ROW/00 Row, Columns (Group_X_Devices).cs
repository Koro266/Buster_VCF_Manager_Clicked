//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{ }

		//_____________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Group_X_Device PkGroup_X_Device		{ get { return ( FIELD.PK_Group_X_Device )	base.GetField( ORDINAL.PkGroup_X_Device ); } }
		public FIELD.FK_Group FkGroup						{ get { return ( FIELD.FK_Group )			base.GetField( ORDINAL.FkGroup ); } }
		public FIELD.FK_Device FkDevice						{ get { return ( FIELD.FK_Device )			base.GetField( ORDINAL.FkDevice ); } }
		public FIELD.ST_DialNumber DialNumber				{ get { return ( FIELD.ST_DialNumber )		base.GetField( ORDINAL.DialNumber ); } }
		public FIELD.ST_Label Label							{ get { return ( FIELD.ST_Label )			base.GetField( ORDINAL.Label ); } }
	}
}
