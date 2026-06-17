//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using CONST = CONTACTS.LOCAL.TERTIARY.NATION.Constants;
using FIELD = CONTACTS.LOCAL.TERTIARY.NATION.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.NATION
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//_______________________________________________________________________________________________________________________________________
		public Row() : base( CONST.ColumnCount )
		{ }
		//_______________________________________________________________________________________________________________________________________
		public override string ToString()
		{
			return this.CountryName.Value;
		}
		//_____________________________________________________________( CASTING )_______________________________________________________________
		public FIELD.PK_Country PkCountry			{ get { return ( FIELD.PK_Country )			base.GetField( CONST.OrdinalByName.PkCountry ); } }
		public FIELD.SI_Order Order					{ get { return ( FIELD.SI_Order )			base.GetField( CONST.OrdinalByName.Order ); } }
		public FIELD.ST_CountryName CountryName		{ get { return ( FIELD.ST_CountryName )		base.GetField( CONST.OrdinalByName.CountryName ); } }
		public FIELD.ST_CountryCode CountryCode		{ get { return ( FIELD.ST_CountryCode )		base.GetField( CONST.OrdinalByName.CountryCode ); } }
		public FIELD.ST_ShortIsoCode ShortIsoCode	{ get { return ( FIELD.ST_ShortIsoCode )	base.GetField( CONST.OrdinalByName.ShortIsoCode ); } }
		public FIELD.ST_LongIsoCode LongIsoCode		{ get { return ( FIELD.ST_LongIsoCode )		base.GetField( CONST.OrdinalByName.LongIsoCode ); } }
	}
}
