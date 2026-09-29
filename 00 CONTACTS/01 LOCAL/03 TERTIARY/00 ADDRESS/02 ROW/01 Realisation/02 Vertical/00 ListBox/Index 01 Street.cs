//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX
{
	//___________________________________________________________________________________________________________________________________________
	public class Index01_Street : BaseAddress
	{
		private bool _isDataExtant = false;

		//___________________________________________________________________________________________________________________________________________
		public Index01_Street( ADDRESS_ROW address_row) : base( address_row )
		{
			IsExtantData = base.IsDataExtant
			(
				address_row.HouseNumber,
				address_row.StreetName,
				address_row.StreetType,
				address_row.Compass
			);
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertLineValue( ListBox list_box )
		{
			if ( IsExtantData == false )
				return;

			string s = String.Empty;

			s =  HouseNumber + StreetName + StreetType + Compass;
			s = base.RealiseAddressRule( s );
			s = this.RemoveUnusedCodes( s );
			s = SHORT_TXT.RectifyString( s );
//			s = s + Environment.NewLine;

			list_box.Items.Add( s );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Remove unused/unreplaced RECON codes from the result string.
		/// </summary>
		private string RemoveUnusedCodes( string s )
		{
			s = s.Replace( this.HouseNumber,	String.Empty );
			s = s.Replace( this.StreetName,		String.Empty );
			s = s.Replace( this.StreetType,		String.Empty );
			s = s.Replace( this.Compass,		String.Empty );

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string HouseNumber		{ get { return base.HouseNumber + CONST.OneSpace; } }
		override public string StreetName		{ get { return base.StreetName + CONST.OneSpace; } }
		override public string StreetType		{ get { return base.StreetType + CONST.OneSpace; } }
		override public string Compass			{ get { return base.Compass; } }
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
