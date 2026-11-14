//___________________________________________________________________________________________________________________________________________________
//LOCAL
using CONTACTS.GLOBAL.DATABASE.COLUMN;
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using BASE_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.BaseAddress;	

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
{
	//___________________________________________________________________________________________________________________________________________
	public class Col8_Notes : BASE_ROW
	{
		private static string _UnValue = "no notes";
		
		//___________________________________________________________________________________________________________________________________________
		public Col8_Notes( ADDRESS_ROW address_row ) : base( address_row )
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

				return s;
			}

		}
		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns an address rule that assembles a 'default' notes.
		/// If all columns are null, returns "no notes".
		/// </summary>
		public string Rule
		{
			get { return Notes; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Remove unused RECON codes for the result string.
		/// </summary>
		private string RemoveUnusedCodes( string s )
		{
			s = s.Replace( this.Notes, String.Empty );

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Override all the base class reconstruction codes that need a specific function in this class. 
		/// </summary>
		override public string Notes	{ get { return base.Notes; } }
	}
}
