//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL INTERFACE
using LISTVIEW_ADDRESS	= CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW.ListViewAddress;
//LOCAL ADDRESS
using ADDRESS			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using SELECT_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select;
using LIKE				= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.DIALOGS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class DlgFindAddress : Form
	{
		#region DECLARATION & CONSTRUCTION
		private ADDRESS _SelectedAddress;
		private LISTVIEW_ADDRESS _ListViewAddress;

		//___________________________________________________________________________________________________________________________________________
		public DlgFindAddress()
		{
			InitializeComponent();
			_SelectedAddress = new SELECT_ADDRESS.DefaultAddress().Execute;
			_ListViewAddress = new LISTVIEW_ADDRESS( lvw_MatchingAddresses );
		}
		#endregion


		#region RESPONDERS

		#region ADDRESS/COUNTRY
		//___________________________________________________________________________________________________________________________________________
		private ADDRESS Address
		{
			get { return _SelectedAddress; }
			set { _SelectedAddress = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private int AddressPk
		{
			get { return Address.PkAddress.Value; }
			set { Address = new SELECT_ADDRESS.ByPkAddress( value ).Execute; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string AddressPkAsText
		{
			get { return AddressPk.ToString(); }
			set { AddressPk = Convert.ToInt32( value ); }
		}
		////___________________________________________________________________________________________________________________________________________
		private int CountryPk
		{
			get { return Address.FkCountry.Value; }
		}
		////___________________________________________________________________________________________________________________________________________
		private string CountryPkAsText
		{
			get { return Address.FkCountry.AsString; }
		}
		#endregion


		#region SELECTION
		//___________________________________________________________________________________________________________________________________________
		public ADDRESS SelectedAddress
		{
			get { return _SelectedAddress; }
			set { _SelectedAddress = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		public string SelectedIndexAsString
		{
			set { AddressPkAsText = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		public string DoubleClick
		{
			set
			{
				AddressPkAsText = value;
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}
		#endregion

		#endregion RESPONDERS

		#region TEXTCHANGED
		//___________________________________________________________________________________________________________________________________________
		private void tbx_STR_HouseNumber_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.HouseNumber = tbx_STR_HouseNumber.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_STR_StreetName_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.StreetName = tbx_STR_StreetName.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LOC_City_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.City = tbx_LOC_City.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LOC_Suburb_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.Suburb = tbx_LOC_Suburb.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_BOX_Number_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.PoBox = tbx_BOX_Number.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_BOX_RuralDelivery_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.RuralDelivery = tbx_BOX_RuralDelivery.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ZIP_PostalCode_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.PostCode = tbx_ZIP_PostalCode.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_EXT_Assemblage_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.Assemblage = tbx_EXT_Assemblage.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_EXT_Level_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.Level = tbx_EXT_Level.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_EXT_Unit_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.Unit = tbx_EXT_Unit.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_EXT_Extension_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.Extentions = tbx_EXT_Extension.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_MET_Metropolitan_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.Metropolitan = tbx_MET_Metropolitan.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PRV_Abbreviation_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.ProvinceAbbrev = tbx_PRV_Abbreviation.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PRV_Name_TextChanged( object sender, EventArgs e )
		{
			_ListViewAddress.ProvinceName = tbx_PRV_Name.Text;
		}
		#endregion


		#region TERMINATION
		//___________________________________________________________________________________________________________________________________________
		private void lvw_MatchingAddresses_DoubleClick( object sender, EventArgs e )
		{
			DoubleClick = lvw_MatchingAddresses.SelectedItems[0].Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_CloseForm_Click( object sender, EventArgs e )
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Cancel_Click( object sender, EventArgs e )
		{
			this.DialogResult = DialogResult.Cancel;
			this._SelectedAddress = new SELECT_ADDRESS.DefaultAddress().Execute;
			this.Close();
		}
		#endregion
	}
}
