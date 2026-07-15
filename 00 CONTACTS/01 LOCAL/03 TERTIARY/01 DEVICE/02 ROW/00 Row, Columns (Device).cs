//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST		= CONTACTS.LOCAL.TERTIARY.DEVICE.Constants;
using ORDINAL	= CONTACTS.LOCAL.TERTIARY.DEVICE.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.TERTIARY.DEVICE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{ }

		//_____________________________________________________________(_CASTING_)_______________________________________________________________
		public FIELD.PK_Device			PkDevice		{ get { return ( FIELD.PK_Device )			base.GetField( ORDINAL.PkDevice ); } }
		public FIELD.FK_Country			FkCountry		{ get { return ( FIELD.FK_Country )			base.GetField( ORDINAL.FkCountry ); } }
		public FIELD.ST_LongAreaCode	LongAreaCode	{ get { return ( FIELD.ST_LongAreaCode )	base.GetField( ORDINAL.LongAreaCode ); } }
		public FIELD.ST_ShortAreaCode	ShortAreaCode	{ get { return ( FIELD.ST_ShortAreaCode )	base.GetField( ORDINAL.ShortAreaCode ); } }
		public FIELD.ST_LeadingDigits	LeadingDigits	{ get { return ( FIELD.ST_LeadingDigits )	base.GetField( ORDINAL.LeadingDigits ); } }
		public FIELD.ST_TrailingDigits	TrailingDigits	{ get { return ( FIELD.ST_TrailingDigits )	base.GetField( ORDINAL.TrailingDigits ); } }
		public FIELD.ST_DeviceLocation	DeviceLocation	{ get { return ( FIELD.ST_DeviceLocation )	base.GetField( ORDINAL.DeviceLocation ); } }
		public FIELD.ST_DeviceType		DeviceType		{ get { return ( FIELD.ST_DeviceType )		base.GetField( ORDINAL.DeviceType ); } }
		public FIELD.ST_DialNumber		DialNumber		{ get { return ( FIELD.ST_DialNumber )		base.GetField( ORDINAL.DialNumber ); } }
		public FIELD.ST_PickerNumber	PickerNumber	{ get { return ( FIELD.ST_PickerNumber )	base.GetField( ORDINAL.PickerNumber ); } }
		public FIELD.ST_Notes			Notes			{ get { return ( FIELD.ST_Notes )			base.GetField( ORDINAL.Notes ); } }
		public FIELD.IS_Selected		Selected		{ get { return ( FIELD.IS_Selected )		base.GetField( ORDINAL.Selected ); } }
		public FIELD.IS_DefaultRow		DefaultRow		{ get { return ( FIELD.IS_DefaultRow )		base.GetField( ORDINAL.DefaultRow ); } }
		public FIELD.IS_Blocked			Blocked			{ get { return ( FIELD.IS_Blocked )			base.GetField( ORDINAL.Blocked ); } }
		public FIELD.IS_X_Person		X_Person		{ get { return ( FIELD.IS_X_Person )		base.GetField( ORDINAL.X_Person ); } }
		public FIELD.IS_X_Group			X_Group			{ get { return ( FIELD.IS_X_Group )			base.GetField( ORDINAL.X_Group ); } }
		public FIELD.IS_X_Family		X_Family		{ get { return ( FIELD.IS_X_Family )		base.GetField( ORDINAL.X_Family ); } }
		public FIELD.ST_CountryName	 	CountryName		{ get { return ( FIELD.ST_CountryName )		base.GetField( ORDINAL.CountryName ); } }
		public FIELD.ST_CountryCode	 	CountryCode		{ get { return ( FIELD.ST_CountryCode )		base.GetField( ORDINAL.CountryCode ); } }
		public FIELD.ST_ShortIsoCode 	ShortIsoCode	{ get { return ( FIELD.ST_ShortIsoCode )	base.GetField( ORDINAL.ShortIsoCode ); } }
		public FIELD.ST_LongIsoCode		LongIsoCode		{ get { return ( FIELD.ST_LongIsoCode )		base.GetField( ORDINAL.LongIsoCode ); } }
	}
}
