//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.SECONDARY.FAMILY.XWEBSITE.Constants;
using ORDINAL	= CONTACTS.LOCAL.SECONDARY.FAMILY.XWEBSITE.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.SECONDARY.FAMILY.XWEBSITE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XWEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_________________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Family_X_Website PkFamily_X_Website	{ get { return ( FIELD.PK_Family_X_Website )	base.GetField( CONST.OrdinalByName.PkFamily_X_Website ); } }
		public FIELD.FK_Family FkFamily						{ get { return ( FIELD.FK_Family )				base.GetField( CONST.OrdinalByName.FkFamily ); } }
		public FIELD.FK_Website FkWebsite					{ get { return ( FIELD.FK_Website )				base.GetField( CONST.OrdinalByName.FkWebsite ); } }
		public FIELD.ST_Website Website						{ get { return ( FIELD.ST_Website )				base.GetField( CONST.OrdinalByName.Website ); } }
	}
}
