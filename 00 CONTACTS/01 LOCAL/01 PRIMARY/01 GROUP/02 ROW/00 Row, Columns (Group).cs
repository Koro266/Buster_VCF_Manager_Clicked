//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.PRIMARY.GROUP.Constants;
using ORDINAL	= CONTACTS.LOCAL.PRIMARY.GROUP.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.PRIMARY.GROUP.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{ }

		//_____________________________________________________________(_CASTING TYPE_)______________________________________________________________
		public FIELD.PK_Group 			PkGroup			{ get { return ( FIELD.PK_Group )			base.GetField( ORDINAL.PkGroup );		} }
		public FIELD.ST_GroupName 		GroupName		{ get { return ( FIELD.ST_GroupName )		base.GetField( ORDINAL.GroupName );		} }
		public FIELD.ST_GroupType 		GroupType		{ get { return ( FIELD.ST_GroupType )		base.GetField( ORDINAL.GroupType );		} }
		public FIELD.ST_Notes 			Notes			{ get { return ( FIELD.ST_Notes )			base.GetField( ORDINAL.Notes );			} }
		public FIELD.DT_CurrencyDate 	CurrencyDate	{ get { return ( FIELD.DT_CurrencyDate )	base.GetField( ORDINAL.CurrencyDate );	} }
	}
}
