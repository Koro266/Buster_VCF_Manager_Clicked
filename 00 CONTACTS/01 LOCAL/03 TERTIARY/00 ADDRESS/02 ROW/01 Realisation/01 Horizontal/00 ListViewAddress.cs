//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using RECON			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reconstruction;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public class ListViewAddress : BaseAddress
	{
		private string[] _Result;

		//___________________________________________________________________________________________________________________________________________
		public ListViewAddress( ADDRESS_ROW address_row ) : base( address_row )
		{
			string s = BuildAddressRule;
			_Result = base.RealiseRule( s );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns an address rule that incorporates all columns in an address row.
		/// "/pk<:>/hn /sn /st %cp<:>/sb /ct<:>/mt /pv (%pa)<:>/bx /rd /pc<:>/as /ex /lv /un<:>/fk<:>/cy, /cd<:>/si, /li<:>/nt";
		/// </summary>
		private string BuildAddressRule
		{
			get
			{
				string rule = String.Empty;

				rule += PkAddress										+ base.SplitString;
				rule += HouseNumber + StreetName + StreetType + Compass	+ base.SplitString;
				rule += Suburb + City									+ base.SplitString;
				rule += Metropolitan + Province + ProvCode				+ base.SplitString;
				rule += BoxNumber + RuralDelivery + PostalCode			+ base.SplitString;
				rule += Assemblage + Extensions + Level + Unit			+ base.SplitString;
				rule += PkCountry										+ base.SplitString;
				rule += Country + TeleCode								+ base.SplitString;
				rule += IsoLong + IsoShort								+ base.SplitString;
				rule += Notes;

				return rule;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		override public string PkAddress		{ get { return base.PkAddress; } }
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
		override public string PkCountry		{ get { return base.PkCountry; } }
		override public string Country			{ get { return base.Country + CONST.OneSpace; } }
		override public string TeleCode			{ get { return "(" + base.TeleCode + ")"; } }
		override public string IsoLong			{ get { return base.IsoLong + ", "; } }
		override public string IsoShort			{ get { return base.IsoShort; } }
		override public string Notes			{ get { return base.Notes; } }
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
		}
	}
}
