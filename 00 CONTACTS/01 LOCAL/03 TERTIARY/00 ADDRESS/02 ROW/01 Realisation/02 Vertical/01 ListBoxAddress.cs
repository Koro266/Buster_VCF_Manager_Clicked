//___________________________________________________________________________________________________________________________________________________
using System.Text.RegularExpressions;
//GLOBAL
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using RECON			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reconstruction;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public class TextBoxAddress : TheGiantSwitch
	{
		private static string AddressPattern = 
			"/hn /sn /st %cp<:>" +
			"/sb /ct<:>" +
			"/mt /pv (%pa)<:>" +
			"/bx /rd /pc<:>" +
			"/as /ex /lv /un<:>" +
			"/cy<:>" +
			"/nt<:>" +
			"/PK Address = pk<:>" +
			"/PK Country = fk";
		private static string SplitPattern	= "<:>";
		private string[] _Result;

		//___________________________________________________________________________________________________________________________________________
		public TextBoxAddress( ADDRESS_ROW address_row ) : base( address_row )
		{
			string s = BuildAddressRule;
			s = base.RealiseAddressRule( s );
			s = RemoveUnusedReconCodes( s );
			_Result = SHORT_TXT.RectifyStrings( Regex.Split( s, SplitPattern ) );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns Fully constructed Address Rule.
		/// "/pk<:>/hn /sn /st %cp<:>/sb /ct<:>/mt /pv (%pa)<:>/bx /rd /pc<:>/as /ex /lv /un<:>/fk<:>/cy, /cd<:>/si, /li<:>/nt";
		/// </summary>
		private string BuildAddressRule
		{
			get
			{
				string rule = String.Empty;

				rule += HouseNumber + StreetName + StreetType + Compass	+ SplitPattern;
				rule += Suburb + City									+ SplitPattern;
				rule += Metropolitan + Province + ProvCode				+ SplitPattern;
				rule += BoxNumber + RuralDelivery + PostalCode			+ SplitPattern;
				rule += Assemblage + Extensions + Level + Unit			+ SplitPattern;
				rule += Country + TeleCode								+ SplitPattern;
				rule += Notes											+ SplitPattern;
				rule += PkAddress										+ SplitPattern;
				rule += PkCountry;

				return rule;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		override public string HouseNumber		{ get { return base.HouseNumber + CONST.OneSpace; } }
		override public string StreetName		{ get { return base.StreetName + CONST.OneSpace; } }
		override public string StreetType		{ get { return base.StreetType + CONST.OneSpace; } }
		override public string Compass			{ get { return RECON.Compass_UPPER; } }

		override public string Suburb			{ get { return base.Suburb + ", "; } }
		override public string City				{ get { return base.City; } }

		override public string Metropolitan		{ get { return base.Metropolitan + ", "; } }
		override public string Province			{ get { return base.Province + CONST.OneSpace; } }
		override public string ProvCode			{ get { return "(" + RECON.ProvinceCode_UPPER + ")"; } }

		override public string BoxNumber		{ get { return base.BoxNumber + CONST.OneSpace; } }
		override public string RuralDelivery	{ get { return base.RuralDelivery + CONST.OneSpace; } }
		override public string PostalCode		{ get { return base.PostalCode; } }

		override public string Assemblage		{ get { return base.Assemblage + CONST.OneSpace; } }
		override public string Extensions		{ get { return base.Extensions + CONST.OneSpace; } }
		override public string Level			{ get { return base.Level + CONST.OneSpace; } }
		override public string Unit				{ get { return base.Unit; } }

		override public string Country			{ get { return base.Country + CONST.OneSpace; } }
		override public string TeleCode			{ get { return "(" + base.TeleCode + ")"; } }

		override public string Notes			{ get { return base.Notes; } }
		override public string PkAddress		{ get { return base.PkAddress; } }
		override public string PkCountry		{ get { return base.PkCountry; } }
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the entire string array that derives from the default address-rule. 
		/// </summary>
		override public string[] Result
		{
			get { return _Result; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Return the 1st item (index=0) of the result array.
		/// </summary>
		override public string RootItem
		{
			get { return _Result[0]; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns items from index=1 to n of the result array.
		/// </summary>
		override public string[] Subitems
		{
			get { return Result[1..]; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Remove unused RECON codes for the result string.
		/// </summary>
		private string RemoveUnusedReconCodes( string s )
		{
			s = s.Replace( this.PkAddress,		String.Empty ); //Included for completeness. PK_Person recon code is always replaced.
			s = s.Replace( this.HouseNumber,	String.Empty );
			s = s.Replace( this.StreetName,		String.Empty );
			s = s.Replace( this.StreetType,		String.Empty );
			s = s.Replace( this.Compass,		String.Empty );	//Coerced to upper case.
			s = s.Replace( this.Suburb,			String.Empty );
			s = s.Replace( this.City,			String.Empty );
			s = s.Replace( this.Metropolitan,	String.Empty );
			s = s.Replace( this.Province,		String.Empty );
			s = s.Replace( this.ProvCode,		String.Empty );	//Abbreviated province name coerced to upper case. Includes parentheses.
			s = s.Replace( this.BoxNumber,		String.Empty );
			s = s.Replace( this.RuralDelivery,	String.Empty );
			s = s.Replace( this.PostalCode,		String.Empty );
			s = s.Replace( this.Assemblage,		String.Empty );
			s = s.Replace( this.Extensions,		String.Empty );
			s = s.Replace( this.Level,			String.Empty );
			s = s.Replace( this.Unit,			String.Empty );
			s = s.Replace( this.PkCountry,		String.Empty ); //Included for completeness. PK_Country recon code is always replaced.
			s = s.Replace( this.Country,		String.Empty );
			s = s.Replace( this.TeleCode,		String.Empty );
			s = s.Replace( this.IsoShort,		String.Empty );
			s = s.Replace( this.IsoLong,		String.Empty );
			s = s.Replace( this.Notes,			String.Empty );

			return s;
		}
	}
}
	