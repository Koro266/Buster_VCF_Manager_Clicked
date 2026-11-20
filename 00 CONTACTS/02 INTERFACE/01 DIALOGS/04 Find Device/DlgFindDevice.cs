//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using LIKE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
using GLOBAL_PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using DEVICE_ROW		= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using SELECT_DEVICE		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Select;
//LOCAL INTERFACE
using LISTVIEW_DEVICE	= CONTACTS.INTERFACE.CONTROLS.DEVICE.HORIZONTAL.LISTVIEW.ListViewDevice;

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
		private int selected_Device = GLOBAL_PRESET.MINUS_ONE;
		private DialogResult dialog_Result = DialogResult.Cancel;

		//___________________________________________________________________________________________________________________________________________
		public DlgFindDevice()
		{
			InitializeComponent();
			_SelectedDevice = new SELECT_DEVICE.DefaultDevice().Execute;
			_ListViewDevice = new LISTVIEW_DEVICE( lvw_MatchingDevices );

			_ListViewDevice.DisplayDevice( _SelectedDevice );
		}
		#endregion


		#region RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the pk_Device of the selected device or GLOBAL_PRESET.MINUS_ONE is no device selected.
		/// </summary>
		public int SelectedDevice
		{
			get { return _SelectedDevice.PkDevice.Value; }
			set
			{
				if ( value == GLOBAL_PRESET.MINUS_ONE )
				{
					dialog_Result = DialogResult.Cancel;
				}
				else
				{
					dialog_Result = DialogResult.OK;
					selected_Device = value;
				}
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int MatchingDevicesSingleClicked
		{
			set { this.SelectedDevice = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private int MatchingDevicesDoubleClicked
		{
			set
			{
				SelectedDevice = value;
				this.DialogResult = dialog_Result;
				this.Close();
			}
		}
		#endregion


		#region EVENT HANDLERS
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
			this.DialogResult = dialog_Result;
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
