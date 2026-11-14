//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using BASE_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.BaseAddress;	
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using RECON			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reconstruction;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col3_Metro : BASE_ROW
	{
		private static string _UnValue = "no metro data";

		//___________________________________________________________________________________________________________________________________________
		public Col3_Metro( ADDRESS_ROW address_row ) : base( address_row )
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
		/// Returns an address rule that assembles a 'default' metro line.
		/// If all columns are null, returns "no metro data".
		/// </summary>
		public string Rule
		{
			get { return Metropolitan + Province + ProvCode; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Remove unused/unreplaced RECON codes from the result string.
		/// </summary>
		private string RemoveUnusedCodes( string s )
		{
			s = s.Replace( this.Metropolitan, String.Empty );
			s = s.Replace( this.Province, String.Empty );
			s = s.Replace( this.ProvCode, String.Empty );

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string Metropolitan		{ get { return base.Metropolitan + "," + CONST.OneSpace; } }
		override public string Province			{ get { return base.Province + CONST.OneSpace; } }
		override public string ProvCode			{ get { return "(" + RECON.ProvinceCode_UPPER + ")"; } }
	}
}
