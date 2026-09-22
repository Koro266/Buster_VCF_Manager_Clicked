//___________________________________________________________________________________________________________________________________________________
using System.Text.RegularExpressions;
//GLOBAL
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using RECON			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reconstruction;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public class TextBoxAddress : BaseAddress
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
		private string[] _Result;

		//___________________________________________________________________________________________________________________________________________
		public TextBoxAddress( ADDRESS_ROW address_row ) : base( address_row )
		{
			string s = BuildAddressRule;
			_Result = base.RealiseRule( s );
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

				rule += HouseNumber + StreetName + StreetType + Compass	+ base.SplitPattern;
				rule += Suburb + City									+ base.SplitPattern;
				rule += Metropolitan									+ base.SplitPattern;
				rule += BoxNumber + RuralDelivery + PostalCode			+ base.SplitPattern;
				rule += Assemblage + Extensions + Level + Unit			+ base.SplitPattern;
				rule += Country + TeleCode;

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
		override public string PostalCode		{ get { return base.PostalCode; } }

		override public string BoxNumber		{ get { return "PO Box" + base.BoxNumber + CONST.OneSpace; } }
		override public string RuralDelivery	{ get { return base.RuralDelivery + CONST.OneSpace; } }

		override public string Assemblage		{ get { return base.Assemblage + CONST.OneSpace; } }
		override public string Extensions		{ get { return base.Extensions + CONST.OneSpace; } }
		override public string Level			{ get { return base.Level + CONST.OneSpace; } }
		override public string Unit				{ get { return base.Unit; } }

		override public string Country			{ get { return base.Country + CONST.OneSpace; } }
		override public string TeleCode			{ get { return "(" + base.TeleCode + ")"; } }
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns result array.
		/// </summary>
		public string[] Lines
		{
			get { return _Result; }
		}
	}
}
	