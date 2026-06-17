//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.TERTIARY.WEBSITE.Constants;
using ORDINAL	= CONTACTS.LOCAL.TERTIARY.WEBSITE.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.TERTIARY.WEBSITE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.WEBSITE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________(_CASTING_)_______________________________________________________________
		public FIELD.PK_Website		PkWebsite	{ get { return ( FIELD.PK_Website )		base.GetField( ORDINAL.PkWebsite ); } }
		public FIELD.ST_Website		Website		{ get { return ( FIELD.ST_Website )		base.GetField( ORDINAL.Website ); } }
		public FIELD.ST_Notes		Notes		{ get { return ( FIELD.ST_Notes )		base.GetField( ORDINAL.Notes ); } }
	}
}
