//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.TERTIARY.EDDRESS.Constants;
using ORDINAL	= CONTACTS.LOCAL.TERTIARY.EDDRESS.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.TERTIARY.EDDRESS.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.EDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{
		}
		//_____________________________________________________(_CASTING_)_______________________________________________________________
		public FIELD.PK_Eddress		PkEddress	{ get { return ( FIELD.PK_Eddress )		base.GetField( ORDINAL.PkEddress ); } }
		public FIELD.ST_Eddress		Eddress		{ get { return ( FIELD.ST_Eddress )		base.GetField( ORDINAL.Eddress ); } }
		public FIELD.ST_EddressType	EddressType	{ get { return ( FIELD.ST_EddressType )	base.GetField( ORDINAL.EddressType ); } }
		public FIELD.ST_Notes		Notes		{ get { return ( FIELD.ST_Notes )		base.GetField( ORDINAL.Notes ); } }
	}
}
