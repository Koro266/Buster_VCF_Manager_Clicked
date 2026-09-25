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
	public class StreetLine : BaseAddress
	{
		private static string _UnValue = "no street data";
		//_is_ExtantData = false if ALL columns that contribute to the street line are null. 
		private bool _is_ExtantData = false;

		//___________________________________________________________________________________________________________________________________________
		public StreetLine( ADDRESS_ROW address_row ) : base( address_row )
		{
			_is_ExtantData = base.IsDataExtant(
				address_row.HouseNumber,
				address_row.StreetName,
				address_row.StreetType,
				address_row.Compass
			);
		}
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns an address rule that assembles a 'default' street address:
		/// "/hn /sn /st %cp" <= NB: no appended space, no split pattern.
		/// If all columns are null, returns "no street data".
		/// </summary>
		public string Rule
		{
			get
			{
				if ( IsExtantData )
					return BuildAddressRule;
				else
					return _UnValue;
			}
		}
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if at least one street line column is not null.
		/// </summary>
		public bool IsExtantData
		{
			get { return _is_ExtantData; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string BuildAddressRule
		{
			get { return HouseNumber + StreetName + StreetType + Compass; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string HouseNumber		{ get { return base.HouseNumber + CONST.OneSpace; } }
		override public string StreetName		{ get { return base.StreetName + CONST.OneSpace; } }
		override public string StreetType		{ get { return base.StreetType + CONST.OneSpace; } }
		override public string Compass			{ get { return RECON.Compass_UPPER; } }
	}
}
