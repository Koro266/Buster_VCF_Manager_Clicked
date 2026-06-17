//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Family_X_Eddress PkFamily_X_Eddress		{ get { return ( FIELD.PK_Family_X_Eddress )	base.GetField( CONST.OrdinalByName.PkFamily_X_Eddress ); } }
		public FIELD.FK_Family FkFamily							{ get { return ( FIELD.FK_Family )				base.GetField( CONST.OrdinalByName.FkFamily ); } }
		public FIELD.FK_Eddress FkEddress						{ get { return ( FIELD.FK_Eddress )				base.GetField( CONST.OrdinalByName.FkEddress ); } }
		public FIELD.ST_Eddress Eddress							{ get { return ( FIELD.ST_Eddress )				base.GetField( CONST.OrdinalByName.Eddress ); } }
	}
}
