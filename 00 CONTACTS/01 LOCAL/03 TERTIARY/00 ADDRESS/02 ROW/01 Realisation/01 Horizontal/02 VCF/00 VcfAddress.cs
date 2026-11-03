//___________________________________________________________________________________________________________________________________________________
//GLOBAL
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.VCF
{
	//___________________________________________________________________________________________________________________________________________
	public class VcfAddress : BaseAddress
	{
		private static string _UnValue = "no address data";
		private bool _IsDataExtant = false;

		//___________________________________________________________________________________________________________________________________________
		public VcfAddress( ADDRESS_ROW address_row) : base( address_row )
		{
			_IsDataExtant = base.IsDataExtant
			(
				address_row.BoxNumber,
				address_row.RuralDelivery,

				address_row.HouseNumber,
				address_row.StreetName,
				address_row.StreetType,
				address_row.Compass,
				
				address_row.Suburb,
				address_row.City,
				
				address_row.Metropolitan,
				address_row.ProvinceName,
				address_row.ProvinceCode,
				address_row.PostalCode,

				address_row.Assemblage,
				address_row.Level,
				address_row.Unit,
				address_row.Extension
			);
		}
		//___________________________________________________________________________________________________________________________________________
		public string RealiseAddressRule
		{
			get
			{
				string s = String.Empty;

				s = this.Rule;
				s = base.RealiseAddressRule( s );
				s = this.RemoveUnusedCodes( s );
				s = SHORT_TXT.RectifyString( s );

				return s;
			}
		}
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns an address rule that assembles a 'default' address.
		/// If all columns are null, returns "no address data".
		/// </summary>
		private string Rule
		{
			get
			{
				if ( _IsDataExtant )
					return
						BoxNumber +
						RuralDelivery +

						HouseNumber +
						StreetName +
						StreetType +
						Compass +

						Suburb +
						City +

						Metropolitan +
						Province +
						ProvCode +
						PostalCode +

						Assemblage +
						Level +
						Unit +
						Extensions +

						Country;
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
			s = s.Replace( this.BoxNumber,		 String.Empty );
			s = s.Replace( this.RuralDelivery,	 String.Empty );

			s = s.Replace( this.HouseNumber,	 String.Empty );
			s = s.Replace( this.StreetName,		 String.Empty );
			s = s.Replace( this.StreetType,		 String.Empty );
			s = s.Replace( this.Compass,		 String.Empty );
			
			s = s.Replace( this.Suburb,			 String.Empty );
			s = s.Replace( this.City,			 String.Empty );
			
			s = s.Replace( this.Metropolitan,	 String.Empty );
			s = s.Replace( this.Province,		 String.Empty );
			s = s.Replace( this.ProvCode,		 String.Empty );
			s = s.Replace( this.PostalCode,		 String.Empty );
			
			s = s.Replace( this.Assemblage,		 String.Empty );
			s = s.Replace( this.Level,			 String.Empty );
			s = s.Replace( this.Unit,			 String.Empty );
			s = s.Replace( this.Extensions,		 String.Empty );

			s = s.Replace( this.Country,		 String.Empty );

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string BoxNumber		{ get { return base.BoxNumber + CONST.OneSpace; } }
		override public string RuralDelivery	{ get { return base.RuralDelivery + CONST.OneSpace; } }
		override public string HouseNumber		{ get { return base.HouseNumber + CONST.OneSpace; } }
		override public string StreetName		{ get { return base.StreetName + CONST.OneSpace; } }
		override public string StreetType		{ get { return base.StreetType + CONST.OneSpace; } }
		override public string Compass			{ get { return base.Compass + CONST.OneSpace; } }
		override public string Suburb			{ get { return base.Suburb + CONST.OneSpace; } }
		override public string City				{ get { return base.City + CONST.OneSpace; } }
		override public string Metropolitan		{ get { return base.Metropolitan + CONST.OneSpace; } }
		override public string Province			{ get { return base.Province + CONST.OneSpace; } }
		override public string ProvCode			{ get { return base.ProvCode + CONST.OneSpace; } }
		override public string PostalCode		{ get { return base.PostalCode + CONST.OneSpace; } }
		override public string Assemblage		{ get { return base.Assemblage + CONST.OneSpace; } }
		override public string Level			{ get { return base.Level + CONST.OneSpace; } }
		override public string Unit				{ get { return base.Unit + CONST.OneSpace; } }
		override public string Extensions		{ get { return base.Extensions + CONST.OneSpace; } }
		override public string Country			{ get { return base.Country + CONST.OneSpace; } }
	}
}
