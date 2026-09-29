//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using System.Windows.Forms;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX
{
	//___________________________________________________________________________________________________________________________________________
	public class Index05_Extensions : BaseAddress
	{
		private bool _isDataExtant = false;

		//___________________________________________________________________________________________________________________________________________
		public Index05_Extensions( ADDRESS_ROW address_row ) : base( address_row )
		{
			IsExtantData = base.IsDataExtant
			(
				address_row.Assemblage,
				address_row.Level,
				address_row.Unit,
				address_row.Extension
			);
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertLineValue( ListBox list_box )
		{
			if ( IsExtantData == false )
				return;

			string s = String.Empty;

			s = Assemblage + Level + Unit + Extensions;
			s = base.RealiseAddressRule( s );
			s = this.RemoveUnusedCodes( s );
			s = SHORT_TXT.RectifyString( s );

			list_box.Items.Add( s );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Remove unused RECON codes for the result string.
		/// </summary>
		private string RemoveUnusedCodes( string s )
		{
			s = s.Replace( this.HouseNumber, String.Empty );
			s = s.Replace( this.StreetName, String.Empty );
			s = s.Replace( this.StreetType, String.Empty );
			s = s.Replace( this.Compass, String.Empty );

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string Assemblage	{ get { return base.Assemblage + CONST.OneSpace; } }
		override public string Level		{ get { return base.Level + CONST.OneSpace; } }
		override public string Unit			{ get { return base.Unit + CONST.OneSpace; } }
		override public string Extensions	{ get { return base.Extensions + CONST.OneSpace; } }
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if at least one extensions column is NOT null.
		/// </summary>
		private bool IsExtantData
		{
			get { return _isDataExtant; }
			set { _isDataExtant = value; }
		}
	}
}
