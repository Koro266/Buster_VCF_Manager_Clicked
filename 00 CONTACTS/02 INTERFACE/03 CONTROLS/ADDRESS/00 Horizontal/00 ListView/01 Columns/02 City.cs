//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using BASE_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.BaseAddress;	
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col2_City : BASE_ROW
	{
		private static string _UnValue = "no city data";

		//___________________________________________________________________________________________________________________________________________
		public Col2_City( ADDRESS_ROW address_row ) : base( address_row )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		public string ColumnValue
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
		/// Returns an address rule that assembles a 'default' city line.
		/// If all columns are null, returns "no city data".
		/// </summary>
		public string Rule
		{
			get { return Suburb + City; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Remove unused/unreplaced RECON codes from the result string.
		/// </summary>
		public string RemoveUnusedCodes( string s )
		{
			s = s.Replace( this.Suburb, String.Empty );
			s = s.Replace( this.City, String.Empty );

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string Suburb	{ get { return base.Suburb + "," + CONST.OneSpace; } }
		override public string City		{ get { return base.City; } }
	}
}
