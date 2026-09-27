//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using CONST			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using RECON			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reconstruction;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL
{
	//___________________________________________________________________________________________________________________________________________
	public class Index03_Metro : BaseAddress
	{
		private bool _isDataExtant = false;

		//___________________________________________________________________________________________________________________________________________
		public Index03_Metro( ADDRESS_ROW address_row ) : base( address_row )
		{
			IsExtantData = base.IsDataExtant
			(
				address_row.Metropolitan,
				address_row.ProvinceName,
				address_row.ProvinceCode
			);
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertLineValue( TextBox text_box )
		{
			string s = String.Empty;

			s = Metropolitan + Province + ProvCode;
			s = base.RealiseAddressRule( s );
			s = this.RemoveUnusedCodes( s );
			s = SHORT_TXT.RectifyString( s );
			s = s + Environment.NewLine;

			text_box.AppendText( s );
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
