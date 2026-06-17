//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using LIKE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
using GLOBAL_PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using LIKE = CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.DIALOGS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class DlgFindDevice : Form
	{
		#region DECLARATIONS & CONSTRUCTION
		private LIKE_ROW[] matching_Devices;
		private int selected_Device = GLOBAL_PRESET.MINUS_ONE;
		private DialogResult dialog_Result = DialogResult.Cancel;

		//___________________________________________________________________________________________________________________________________________
		public DlgFindDevice()
		{
			InitializeComponent();
		}
		#endregion


		#region DISPLAY
		//___________________________________________________________________________________________________________________________________________
		private void Display()
		{

			this.lbx_MatchingDevices.Items.Clear();
			if ( this.matching_Devices.Length == GLOBAL_PRESET.ZERO )
				return;

			this.lbx_MatchingDevices.Items.AddRange( this.matching_Devices );
		}
		#endregion


		#region RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		private string PrimaryKeyAsText
		{
			set
			{
				this.matching_Devices = new LIKE.PrimaryKey( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string PrimaryKey
		{
			set
			{
				this.matching_Devices = new LIKE.PrimaryKey( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string LongAreaCode
		{
			set
			{
				this.matching_Devices = new LIKE.LongAreaCode( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string ShortAreaCode
		{
			set
			{
				this.matching_Devices = new LIKE.ShortAreaCode( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string LeadingDigits
		{
			set
			{
				this.matching_Devices = new LIKE.LeadingDigits( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string TrailingDigits
		{
			set
			{
				this.matching_Devices = new LIKE.TrailingDigits( value ).Execute;
				Display();
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
		private void tbx_PkDevice_TextChanged( object sender, EventArgs e )
		{
			PrimaryKeyAsText = this.tbx_PkDevice.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LongAreaCode_TextChanged( object sender, EventArgs e )
		{
			LongAreaCode = this.tbx_LongAreaCode.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ShortAreaCode_TextChanged( object sender, EventArgs e )
		{
			ShortAreaCode = this.tbx_ShortAreaCode.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LeadingDigits_TextChanged( object sender, EventArgs e )
		{
			LeadingDigits = this.tbx_LeadingDigits.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_TrailingDigits_TextChanged( object sender, EventArgs e )
		{
			TrailingDigits = this.tbx_TrailingDigits.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingDevices_Click( object sender, EventArgs e )
		{
			if ( lbx_MatchingDevices.SelectedIndex == GLOBAL_PRESET.NoItemSelected )
				MatchingDevicesSingleClicked = GLOBAL_PRESET.MINUS_ONE;
			else
				MatchingDevicesSingleClicked = ( ( LIKE_ROW )( lbx_MatchingDevices.SelectedItem ) ).PkRow;
		}
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingDevices_DoubleClick( object sender, EventArgs e )
		{
			if ( lbx_MatchingDevices.SelectedIndex == GLOBAL_PRESET.NoItemSelected )
				MatchingDevicesDoubleClicked = GLOBAL_PRESET.MINUS_ONE;
			else
				MatchingDevicesDoubleClicked = ( ( LIKE_ROW )( lbx_MatchingDevices.SelectedItem ) ).PkRow;
		}
		#endregion


		#region TERMINATION OF FORM
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the pk_Device of the selected device or GLOBAL_PRESET.MINUS_ONE is no device selected.
		/// </summary>
		public int SelectedDevice
		{
			get { return this.selected_Device; }
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
