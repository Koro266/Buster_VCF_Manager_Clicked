//___________________________________________________________________________________________________________________________________________________
//LOCAL
using CONST		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants;
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using FIELD		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Column;
using ORDINAL	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.OrdinalByName;
using COUNTRY	= CONTACTS.LOCAL.TERTIARY.NATION.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		private COUNTRY address_Nation;

		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount ) { }
		//_____________________________________________________________(<----_CASTING --->)__________________________________________________________
		public FIELD.PK_Address 		PkAddress		{ get { return ( FIELD.PK_Address )			base.GetField( ORDINAL.PkAddress ); } }
		public FIELD.FK_Country 		FkCountry		{ get { return ( FIELD.FK_Country )			base.GetField( ORDINAL.FkCountry ); } }
		public FIELD.ST_Assemblage 		Assemblage		{ get { return ( FIELD.ST_Assemblage )		base.GetField( ORDINAL.Assemblage ); } }
		public FIELD.ST_Level 			Level			{ get { return ( FIELD.ST_Level )			base.GetField( ORDINAL.Level ); } }
		public FIELD.ST_Unit 			Unit			{ get { return ( FIELD.ST_Unit )			base.GetField( ORDINAL.Unit ); } }
		public FIELD.ST_Extension 		Extension		{ get { return ( FIELD.ST_Extension )		base.GetField( ORDINAL.Extension ); } }
		public FIELD.ST_RuralDelivery 	RuralDelivery	{ get { return ( FIELD.ST_RuralDelivery )	base.GetField( ORDINAL.RuralDelivery ); } }
		public FIELD.ST_PostalCode 		PostalCode		{ get { return ( FIELD.ST_PostalCode )		base.GetField( ORDINAL.PostalCode ); } }
		public FIELD.ST_BoxNumber 		BoxNumber		{ get { return ( FIELD.ST_BoxNumber )		base.GetField( ORDINAL.BoxNumber ); } }
		public FIELD.ST_HouseNumber 	HouseNumber		{ get { return ( FIELD.ST_HouseNumber )		base.GetField( ORDINAL.HouseNumber ); } }
		public FIELD.ST_StreetName 		StreetName		{ get { return ( FIELD.ST_StreetName )		base.GetField( ORDINAL.StreetName ); } }
		public FIELD.ST_StreetType 		StreetType		{ get { return ( FIELD.ST_StreetType )		base.GetField( ORDINAL.StreetType ); } }
		public FIELD.ST_Compass 		Compass			{ get { return ( FIELD.ST_Compass )			base.GetField( ORDINAL.Compass ); } }
		public FIELD.ST_Suburb 			Suburb			{ get { return ( FIELD.ST_Suburb )			base.GetField( ORDINAL.Suburb ); } }
		public FIELD.ST_City 			City			{ get { return ( FIELD.ST_City )			base.GetField( ORDINAL.City ); } }
		public FIELD.ST_Metropolitan 	Metropolitan	{ get { return ( FIELD.ST_Metropolitan )	base.GetField( ORDINAL.Metropolitan ); } }
		public FIELD.ST_ProvinceName 	ProvinceName	{ get { return ( FIELD.ST_ProvinceName )	base.GetField( ORDINAL.ProvinceName ); } }
		public FIELD.ST_ProvinceCode 	ProvinceCode	{ get { return ( FIELD.ST_ProvinceCode )	base.GetField( ORDINAL.ProvinceCode ); } }
		public FIELD.ST_VcfPostal 		VcfPostal		{ get { return ( FIELD.ST_VcfPostal )		base.GetField( ORDINAL.VcfPostal ); } }
		public FIELD.ST_VcfPhysical 	VcfPhysical		{ get { return ( FIELD.ST_VcfPhysical )		base.GetField( ORDINAL.VcfPhysical ); } }
		public FIELD.ST_VcfExtended 	VcfExtended		{ get { return ( FIELD.ST_VcfExtended )		base.GetField( ORDINAL.VcfExtended ); } }
		public FIELD.ST_ExcelPattern 	ExcelPattern	{ get { return ( FIELD.ST_ExcelPattern )	base.GetField( ORDINAL.ExcelPattern ); } }
		public FIELD.IS_Christmas 		Christmas		{ get { return ( FIELD.IS_Christmas )		base.GetField( ORDINAL.Christmas ); } }
		public FIELD.ST_CountryName	 	CountryName		{ get { return ( FIELD.ST_CountryName )		base.GetField( ORDINAL.CountryName ); } }
		public FIELD.ST_CountryCode	 	CountryCode		{ get { return ( FIELD.ST_CountryCode )		base.GetField( ORDINAL.CountryCode ); } }
		public FIELD.ST_ShortIsoCode 	ShortIsoCode	{ get { return ( FIELD.ST_ShortIsoCode )	base.GetField( ORDINAL.ShortIsoCode ); } }
		public FIELD.ST_LongIsoCode		LongIsoCode		{ get { return ( FIELD.ST_LongIsoCode )		base.GetField( ORDINAL.LongIsoCode ); } }
	}
}
