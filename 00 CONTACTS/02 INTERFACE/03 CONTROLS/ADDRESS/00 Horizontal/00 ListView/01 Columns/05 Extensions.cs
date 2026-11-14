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
	public class Col5_Extensions : BASE_ROW
	{
		private static string _UnValue = "no extensions";

		//___________________________________________________________________________________________________________________________________________
		public Col5_Extensions( ADDRESS_ROW address_row ) : base( address_row )
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
		/// Returns an address rule that assembles a 'default' extensions line.
		/// If all columns are null, returns "no extensions".
		/// </summary>
		public string Rule
		{
			get { return Assemblage + Level + Unit + Extensions; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Remove unused RECON codes for the result string.
		/// </summary>
		private string RemoveUnusedCodes( string s )
		{
			s = s.Replace( this.Assemblage, String.Empty );
			s = s.Replace( this.Level, String.Empty );
			s = s.Replace( this.Unit, String.Empty );
			s = s.Replace( this.Extensions, String.Empty );

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
	}
}
