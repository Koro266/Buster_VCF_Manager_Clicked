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
		public FIELD.PK_Group 			PkGroup			{ get { return ( FIELD.PK_Group )			base.GetField( ORDINAL.PkGroup ); } }
		public FIELD.ST_GroupName 		GroupName		{ get { return ( FIELD.ST_GroupName )		base.GetField( ORDINAL.GroupName ); } }
		public FIELD.ST_GroupType 		GroupType		{ get { return ( FIELD.ST_GroupType )		base.GetField( ORDINAL.GroupType ); } }
		public FIELD.ST_Notes 			Notes			{ get { return ( FIELD.ST_Notes )			base.GetField( ORDINAL.Notes ); } }
		public FIELD.DT_CurrencyDate 	CurrencyDate	{ get { return ( FIELD.DT_CurrencyDate )	base.GetField( ORDINAL.CurrencyDate ); } }
		public FIELD.IS_Selected 		Selected		{ get { return ( FIELD.IS_Selected )		base.GetField( ORDINAL.Selected ); } }
		public FIELD.IS_DefaultRow 		DefaultRow		{ get { return ( FIELD.IS_DefaultRow )		base.GetField( ORDINAL.DefaultRow ); } }
		public FIELD.IS_Export 			Export			{ get { return ( FIELD.IS_Export )			base.GetField( ORDINAL.Export ); } }
		public FIELD.IS_Blocked 		Blocked			{ get { return ( FIELD.IS_Blocked )			base.GetField( ORDINAL.Blocked ); } }
		public FIELD.IS_Inactive 		Inactive		{ get { return ( FIELD.IS_Inactive )		base.GetField( ORDINAL.Inactive ); } }
		public FIELD.IS_StTheresa 		StTheresa		{ get { return ( FIELD.IS_StTheresa )		base.GetField( ORDINAL.StTheresa ); } }
		public FIELD.IS_Tradesman 		Tradesman		{ get { return ( FIELD.IS_Tradesman )		base.GetField( ORDINAL.Tradesman ); } }
		public FIELD.IS_Supplier 		Supplier		{ get { return ( FIELD.IS_Supplier )		base.GetField( ORDINAL.Supplier ); } }
		public FIELD.IS_Writer 			Writer			{ get { return ( FIELD.IS_Writer )			base.GetField( ORDINAL.Writer ); } }

	}
}
