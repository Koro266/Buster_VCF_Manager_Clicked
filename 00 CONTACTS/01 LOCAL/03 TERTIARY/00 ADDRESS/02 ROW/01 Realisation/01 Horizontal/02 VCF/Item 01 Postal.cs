//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.VCF
{
	//___________________________________________________________________________________________________________________________________________
	public class Item_01_Postal : BaseAddress
	{
		private static string _UnValue = "no address data";
		private bool _isDataExtant = false;

		//___________________________________________________________________________________________________________________________________________
		public Item_01_Postal( ADDRESS_ROW address_row) : base( address_row )
		{
			IsExtantData = base.IsDataExtant
			(
				address_row.Assemblage,
				address_row.Level,
				address_row.Unit,
				address_row.Extension,
				address_row.RuralDelivery,
				address_row.PostalCode,
				address_row.BoxNumber,
				address_row.HouseNumber,
				address_row.StreetName,
				address_row.StreetType,
				address_row.Compass,
				address_row.Suburb,
				address_row.City,
				address_row.Metropolitan,
				address_row.ProvinceName,
				address_row.ProvinceCode
			);
		}
		//___________________________________________________________________________________________________________________________________________
		public string InsertColumnValue( )
		{
			string s = String.Empty;

			s = this.Rule;
			s = base.RealiseAddressRule( s );
			s = this.RemoveUnusedCodes( s );
			s = SHORT_TXT.RectifyString( s );

			return s;
		}
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns an address rule that assembles a 'default' street address.
		/// If all columns are null, returns "no street data".
		/// </summary>
		private string Rule
		{
			get
			{
				if ( IsExtantData )
					return
						HouseNumber +
						Assemblage +
						Level +
						Unit +
						Extensions +
						RuralDelivery +
						PostalCode +
						BoxNumber +
						HouseNumber +
						StreetName +
						StreetType +
						Compass +
						Suburb +
						City +
						Metropolitan +
						Province +
						ProvCode;
				else
					return _UnValue;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Remove unused/unreplaced RECON codes from the result string.
		/// </summary>
		private string RemoveUnusedCodes( string s )
		{
			s = s.Replace( this.Assemblage,		 String.Empty );
			s = s.Replace( this.Level,			 String.Empty );
			s = s.Replace( this.Unit,			 String.Empty );
			s = s.Replace( this.Extensions,		 String.Empty );
			s = s.Replace( this.RuralDelivery,	 String.Empty );
			s = s.Replace( this.PostalCode,		 String.Empty );
			s = s.Replace( this.BoxNumber,		 String.Empty );
			s = s.Replace( this.HouseNumber,	 String.Empty );
			s = s.Replace( this.StreetName,		 String.Empty );
			s = s.Replace( this.StreetType,		 String.Empty );
			s = s.Replace( this.Compass,		 String.Empty );
			s = s.Replace( this.Suburb,			 String.Empty );
			s = s.Replace( this.City,			 String.Empty );
			s = s.Replace( this.Metropolitan,	 String.Empty );
			s = s.Replace( this.Province,		 String.Empty );
			s = s.Replace( this.ProvCode,		 String.Empty );

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string Notes			{ get { return base.Notes; } }
		override public string HouseNumber		{ get { return base.HouseNumber; } }
		override public string StreetName		{ get { return base.StreetName; } }
		override public string StreetType		{ get { return base.StreetType; } }
		override public string Compass			{ get { return base.Compass; } }
		override public string Suburb			{ get { return base.Suburb; } }
		override public string City				{ get { return base.City; } }
		override public string Metropolitan		{ get { return base.Metropolitan; } }
		override public string Province			{ get { return base.Province; } }
		override public string ProvCode			{ get { return base.ProvCode; } }
		override public string BoxNumber		{ get { return base.BoxNumber; } }
		override public string RuralDelivery	{ get { return base.RuralDelivery; } }
		override public string PostalCode		{ get { return base.PostalCode; } }
		override public string Assemblage		{ get { return base.Assemblage; } }
		override public string Extensions		{ get { return base.Extensions; } }
		override public string Level			{ get { return base.Level; } }
		override public string Unit				{ get { return base.Unit; } }
		override public string Country			{ get { return base.Country; } }
		override public string TeleCode			{ get { return base.TeleCode; } }
		override public string IsoShort			{ get { return base.IsoShort; } }
		override public string IsoLong			{ get { return base.IsoLong; } }

		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Gets/sets _isDataExtant == true if at least one street line column is NOT null.
		/// </summary>
		private bool IsExtantData
		{
			get { return _isDataExtant; }
			set { _isDataExtant = value; }
		}
	}
}
