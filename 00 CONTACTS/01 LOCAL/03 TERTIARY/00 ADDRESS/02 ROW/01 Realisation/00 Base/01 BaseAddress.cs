//___________________________________________________________________________________________________________________________________________________
using System;
using System.Linq;
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
	public class BaseAddress : TheGiantSwitch
	{
		private static string SplitPattern	= "<:>";

		//___________________________________________________________________________________________________________________________________________
		public BaseAddress( ADDRESS_ROW address_row ) : base( address_row )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		public string[] RealiseRule( string address_rule )
		{
			string s = String.Empty;
			string[] ss;

			s = base.RealiseAddressRule( address_rule );
			s = this.RemoveUnusedReconCodes(s);

			ss = Regex.Split( s, SplitString );
			ss = SHORT_TXT.RectifyStrings( ss );

			return ss;
		}
		//___________________________________________________________________________________________________________________________________________
		virtual public string PkAddress		{ get { return RECON.PkAddress; } }
		virtual public string PkCountry		{ get { return RECON.FkCountry; } }
		virtual public string Notes			{ get { return RECON.Notes; } }

		virtual public string HouseNumber	{ get { return RECON.HouseNumber_AsIs; } }
		virtual public string StreetName	{ get { return RECON.StreetName_AsIs; } }
		virtual public string StreetType	{ get { return RECON.StreetType_AsIs; } }
		virtual public string Compass		{ get { return RECON.Compass_AsIs; } }
		virtual public string Suburb		{ get { return RECON.Suburb_AsIs; } }
		virtual public string City			{ get { return RECON.City_AsIs; } }
		virtual public string Metropolitan	{ get { return RECON.Metropolitan_AsIs; } }
		virtual public string Province		{ get { return RECON.ProvinceName_AsIs; } }
		virtual public string ProvCode		{ get { return RECON.ProvinceCode_AsIs; } }
		virtual public string BoxNumber		{ get { return RECON.BoxNumber_AsIs; } }
		virtual public string RuralDelivery	{ get { return RECON.RuralDelivery_AsIs; } }
		virtual public string PostalCode	{ get { return RECON.PostalCode_AsIs; } }
		virtual public string Assemblage	{ get { return RECON.Assemblage_AsIs; } }
		virtual public string Extensions	{ get { return RECON.Extension_AsIs; } }
		virtual public string Level			{ get { return RECON.Level_AsIs; } }
		virtual public string Unit			{ get { return RECON.Unit_AsIs; } }
		virtual public string Country		{ get { return RECON.CountryName_AsIs; } }
		virtual public string TeleCode		{ get { return RECON.CountryCode_AsIs; } }
		virtual public string IsoShort		{ get { return RECON.ShortIsoCode_AsIs; } }
		virtual public string IsoLong		{ get { return RECON.LongIsoCode_AsIs; } }

		virtual public string SplitString	{ get { return SplitPattern; } }

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
			s = s.Replace( this.Compass,		String.Empty );
			s = s.Replace( this.Suburb,			String.Empty );
			s = s.Replace( this.City,			String.Empty );
			s = s.Replace( this.Metropolitan,	String.Empty );
			s = s.Replace( this.Province,		String.Empty );
			s = s.Replace( this.ProvCode,		String.Empty );
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
/*
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the entire string array that derives from the default address-rule. 
		/// </summary>
		virtual public string[] Result
		{
			get { return _Result; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Return the 1st item (index=0) of the result array.
		/// </summary>
		virtual public string RootItem
		{
			get { return _Result[0]; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns items from index=1 to n of the result array.
		/// </summary>
		virtual public string[] Subitems
		{
			get { return _Result[1..]; }
		}		//___________________________________________________________________________________________________________________________________________
		private string[] ExtractLines(params int[] indices)
		{
			return indices
				.Where( i => i >= 0 && i < _Result.Length )
				.Select( i => _Result[i] )
				.Where( line => !string.IsNullOrWhiteSpace( line ) )
				.ToArray();
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns an empty string array
		/// </summary>
		virtual public string[] Result
		{
			get { return new string[] { }; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string intended to be assigned to the ListView.Item property.
		/// </summary>
		virtual public string RootItem
		{
			get { return String.Empty; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to the ListView.SubItems property.
		/// </summary>
		virtual public string[] Subitems
		{
			get { return Result[1..]; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to a ListBox.Items property.
		/// </summary>
		virtual public string[] ListBoxItems()
		{
			return Result;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to the TextBox.Lines property.
		/// </summary>
		virtual public string[] TextBoxLines()
		{
			return Result;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to a VCF output file; i.e., a 'vertical' address format.
		/// </summary>
		virtual public string[] VcfAddress()
		{
			return Result;
		}
 */