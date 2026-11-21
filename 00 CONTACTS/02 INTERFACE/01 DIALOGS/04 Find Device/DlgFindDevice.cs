//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW;
//LOCAL
using DEVICE_ROW		= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using GLOBAL_PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using LIKE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
//LOCAL INTERFACE
using LISTVIEW_DEVICE	= CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW.ListViewDevice;
using SELECT_DEVICE		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.DIALOGS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class DlgFindDevice : Form
	{
		#region DECLARATIONS & CONSTRUCTION
		private DEVICE_ROW _SelectedDevice;
		private LISTVIEW_DEVICE _ListViewDevice;

		private LIKE_ROW[] matching_Devices;

		private int _SelectedPk;
		private DialogResult _DialogResult;

		//___________________________________________________________________________________________________________________________________________
		public DlgFindDevice()
		{
			InitializeComponent();
			_SelectedDevice = new SELECT_DEVICE.DefaultDevice().Execute;
			_SelectedPk = _SelectedDevice.PkDevice.Value;
			_DialogResult = DialogResult.Cancel;

			_ListViewDevice = new LISTVIEW_DEVICE( lvw_MatchingDevices );
			_ListViewDevice.ClearDevices();
			_ListViewDevice.DisplayDevice( _SelectedDevice );
		}
		#endregion


		#region RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the pk_Device of the selected device or GLOBAL_PRESET.MINUS_ONE is no device selected.
		/// </summary>
		public DEVICE_ROW SelectedDevice
		{
			get { return _SelectedDevice; }
			set { _SelectedDevice = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private DEVICE_ROW MatchingDevicesSingleClicked
		{
			set { this.SelectedDevice = 1; }
		}
		//___________________________________________________________________________________________________________________________________________
		private DEVICE_ROW MatchingDevicesDoubleClicked
		{
			set
			{
				SelectedDevice = 1;
				this.DialogResult = _DialogResult;
				this.Close();
			}
		}
		#endregion


		#region EVENT HANDLERS
		//___________________________________________________________________________________________________________________________________________
		private void lvw_MatchingDevices_SelectedIndexChanged( object sender, EventArgs e )
		{
			SelectedDevice = lvw_MatchingDevices.SelectedItems[0].Tag as DEVICE_ROW;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LongAreaCode_TextChanged( object sender, EventArgs e )
		{
			_ListViewDevice.LongAreaCode = this.tbx_LongAreaCode.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ShortAreaCode_TextChanged( object sender, EventArgs e )
		{
			_ListViewDevice.ShortAreaCode = this.tbx_ShortAreaCode.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LeadingDigits_TextChanged( object sender, EventArgs e )
		{
			_ListViewDevice.LeadingDigits = this.tbx_LeadingDigits.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_TrailingDigits_TextChanged( object sender, EventArgs e )
		{
			_ListViewDevice.TrailingDigits = this.tbx_TrailingDigits.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Location_TextChanged( object sender, EventArgs e )
		{
			_ListViewDevice.Location = this.tbx_Location.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Type_TextChanged( object sender, EventArgs e )
		{
			_ListViewDevice.Type = this.tbx_Type.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_CountryName_TextChanged( object sender, EventArgs e )
		{
			_ListViewDevice.CountryName = this.tbx_CountryName.Text;
		}
		#endregion


		#region TERMINATION OF FORM
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
			this.Close();
		}
		#endregion
	}
}
