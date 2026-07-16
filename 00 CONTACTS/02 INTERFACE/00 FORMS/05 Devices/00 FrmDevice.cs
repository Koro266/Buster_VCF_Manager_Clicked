//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using GLOBAL_DB		= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using LIKE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using TXT_GATHER	= CONTACTS.GLOBAL.TOOLS.TextAccumulator;
using MESSENGER		= CONTACTS.GLOBAL.TOOLS.Messenger;
using EVENT_STATE	= CONTACTS.GLOBAL.TOOLS.EventState;
//DEVICE
using DEVICE		= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using DEVICES		= CONTACTS.LOCAL.TERTIARY.DEVICE.Table;
using LIKE			= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Like;
//COUNTRIES
using NATION		= CONTACTS.LOCAL.TERTIARY.NATION.Row;
using NATIONS		= CONTACTS.LOCAL.TERTIARY.NATION.Table;
//FORMS
using FIND_DEVICE	= CONTACTS.INTERFACE.DIALOGS.DlgFindDevice;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.FORMS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class FrmDevice : Form
	{
		#region DECLARATIONS
		private GLOBAL_DB db_Connector = new GLOBAL_DB();

		private DEVICE one_Device;						//One device.
		private DEVICES all_Devices = new DEVICES();    //Device table (all devices).

		private NATION one_Nation;						//One country.
		private NATIONS all_Nations = new NATIONS();	//All countries.

		private LIKE_ROW[] matching_Devices;
		private MESSENGER _Messenger;
		private EVENT_STATE _EventState;
		#endregion


		#region CONSTRUCTORS
		//___________________________________________________________________________________________________________________________________________
		public FrmDevice()
		{
			InitializeComponent();

			InitialiseForm();
			DisplayDevice();
		}
		//___________________________________________________________________________________________________________________________________________
		public FrmDevice( int device_pk )
		{
			InitializeComponent();

			InitialiseForm( device_pk );
			DisplayDevice();
		}
		#endregion


		#region DISPLAY
		//___________________________________________________________________________________________________________________________________________
		private void DisplayDevice()
		{
			_EventState.DisableEvents();

			tbx_DeviceId.Text				= DevicePkAsText;
			cbx_Countries.SelectedIndex		= FkCountry;
			tbx_LongAreaCode.Text			= LongAreaCode;
			tbx_ShortAreaCode.Text			= ShortAreaCode;
			tbx_LeadingDigits.Text			= LeadingDigits;
			tbx_TrailingDigits.Text			= TrailingDigits;
			cbx_DeviceLocation.Text			= DeviceLocation;
			cbx_DeviceType.Text				= DeviceType;
			tbx_DialNumber.Text				= DialNumber;
			tbx_PickerNumber.Text			= PickerNumber;
			tbx_Notes.Text					= Notes;

			chk_Selected.Checked			= Selected;
			chk_DefaultRow.Checked			= DefaultRow;
			chk_Blocked.Checked				= Blocked;
			chk_X_Person.Checked			= XPerson;
			chk_X_Group.Checked				= XGroup;
			chk_X_Family.Checked			= XFamily;

			_EventState.EnableEvents();
		}
		#endregion


		#region RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		private DEVICE Device
		{
			get { return one_Device; }
			set
			{
				one_Device = value;
				FkCountry = one_Device.FkCountry.Value;
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private NATION Country
		{
			get { return all_Nations.NationByKey( Device.FkCountry.Value ); }
			set
			{
				one_Nation = value;
				Device.CountryAltered( one_Nation );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int DevicePk
		{
			get { return Device.PkDevice.Value; }
			set { Device = all_Devices.DeviceByKey( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private string DevicePkAsText
		{
			get { return Device.PkDevice.AsString; }
			set { DevicePk = Convert.ToInt32( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private int FkCountry
		{
			get { return Device.FkCountry.Value; }
			set
			{
				Country = all_Nations.NationByKey( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void InsertDevice()
		{
			if ( all_Devices.InsertDevice( Device ) )
			{
				_Messenger.InsertSucceeded();
				//Device = all_Devices.CurrentDevice;
			}
			else
			{
				_Messenger.InsertFailed();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void UpdateDevice()
		{
			if ( all_Devices.UpdateDevice( Device ) )
			{
				_Messenger.UpdateSucceeded();
			}
			else
			{
				_Messenger.UpdateFailed();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string LongAreaCode
		{
			get { return Device.LongAreaCode.Value; }
			set
			{
				Device.NewLongAreaCode( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string ShortAreaCode
		{
			get { return Device.ShortAreaCode.Value; }
			set
			{
				Device.NewShortAreaCode( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string LeadingDigits
		{
			get { return Device.LeadingDigits.Value; }
			set
			{
				Device.NewLeadingDigits( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string TrailingDigits
		{
			get { return Device.TrailingDigits.Value; }
			set
			{
				Device.NewTrailingDigits( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string DeviceLocation
		{
			get { return Device.DeviceLocation.Value; }
			set
			{
				Device.NewDeviceLocation( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string DeviceType
		{
			get { return Device.DeviceType.Value; }
			set
			{
				Device.NewDeviceType( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string DialNumber
		{
			get { return Device.DialNumber.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string PickerNumber
		{
			get { return Device.PickerNumber.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string Notes
		{
			get { return Device.Notes.Value; }
			set
			{
				Device.NewNotes( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Selected
		{
			get { return Device.Selected.Value; }
			set
			{
				Device.NewSelected = value;
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool DefaultRow
		{
			get { return Device.DefaultRow.Value; }
			set
			{
				Device.NewDefaultRow = value;
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Blocked
		{
			get { return Device.Blocked.Value; }
			set
			{
				Device.NewBlocked = value;
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool XPerson
		{
			get { return Device.X_Person.Value; }
			set
			{
				Device.New_X_Person = value;
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool XGroup
		{
			get { return Device.X_Group.Value; }
			set
			{
				Device.New_X_Group = value;
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool XFamily
		{
			get { return Device.X_Family.Value; }
			set
			{
				Device.New_X_Family = value;
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string MatchesText
		{
			set
			{
				this.lbx_MatchingDevices.Items.Clear();

				matching_Devices = new LIKE.MatchingNumbersList( value ).Execute;
				if ( matching_Devices.Length == 0 )
					return;

				this.lbx_MatchingDevices.Items.AddRange( matching_Devices );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int DevicesSelectedIndex
		{
			set
			{
				if ( value == GLOBAL_PRESET.NoItemSelected )
				{
					Device = all_Devices.DefaultDevice;
				}
				else
				{
					LIKE_ROW like_row = ( LIKE_ROW )( this.lbx_MatchingDevices.SelectedItem );
					this.DevicePk = like_row.PkRow;
				}
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int CountrySelectedIndex
		{
			set
			{
				if ( value == GLOBAL_PRESET.NoItemSelected )
				{
					Country = all_Nations.DefaultNation;
				}
				else
				{
					Country = all_Nations.NationByIndex( value );
				}
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private Keys FindDeviceKeyDown
		{
			set
			{
				if ( value == Keys.Enter )
					this.DevicePkAsText = this.tbx_Filter.Text;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void FindDevice()
		{
			using ( FIND_DEVICE dlg_find_device = new FIND_DEVICE() )

			{
				dlg_find_device.ShowDialog();
				if ( dlg_find_device.DialogResult == DialogResult.OK )
					DevicePk = dlg_find_device.SelectedDevice;
			}
		}
		#endregion


		#region EVENT HANDLERS

		#region VALUE CHANGED
		//___________________________________________________________________________________________________________________________________________
		private void chk_Selected_CheckedChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Selected = chk_Selected.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_DefaultRow_CheckedChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				DefaultRow = chk_DefaultRow.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_Blocked_CheckedChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Blocked = chk_Blocked.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_X_Person_CheckedChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				XPerson = chk_X_Person.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_X_Group_CheckedChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				XGroup = chk_X_Group.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_X_Family_CheckedChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				XFamily = chk_X_Family.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LongAreaCode_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				LongAreaCode = tbx_LongAreaCode.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ShortAreaCode_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				ShortAreaCode = tbx_ShortAreaCode.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LeadingDigits_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				LeadingDigits = tbx_LeadingDigits.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_TrailingDigits_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				TrailingDigits = tbx_TrailingDigits.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Notes = tbx_Notes.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_DeviceLocation_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				DeviceLocation = cbx_DeviceLocation.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_DeviceType_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				DeviceType = cbx_DeviceType.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_Countries_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				CountrySelectedIndex = cbx_Countries.SelectedIndex;
		}
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingDevices_SelectedIndexChanged( object sender, EventArgs e )
		{
			DevicesSelectedIndex = this.lbx_MatchingDevices.SelectedIndex;
		}
		#endregion


		#region NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		private void btn_FirstDevice_Click( object sender, EventArgs e )
		{
			Device = all_Devices.FirstDevice;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_PreviousDevice_Click( object sender, EventArgs e )
		{
			Device = all_Devices.PreviousDevice;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_NextDevice_Click( object sender, EventArgs e )
		{
			Device = all_Devices.NextDevice;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_LastDevice_Click( object sender, EventArgs e )
		{
			Device = all_Devices.LastDevice;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_FindDevice_Click( object sender, EventArgs e )
		{
			FindDevice();
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Matches_TextChanged( object sender, EventArgs e )
		{
			MatchesText = this.tbx_Matches.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Filter_KeyUp( object sender, KeyEventArgs e )
		{
			FindDeviceKeyDown = e.KeyCode;
		}
		#endregion


		#region BUTTON CLICKS
		//___________________________________________________________________________________________________________________________________________
		private void btn_Close_Click( object sender, EventArgs e )
		{
			this.Close();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Insert_Click( object sender, EventArgs e )
		{
			InsertDevice();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_UpdateDevice_Click( object sender, EventArgs e )
		{
			UpdateDevice();
		}
		#endregion

		#endregion


		#region INITIALISATION
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm()
		{
			Initialise( all_Devices.DefaultDevice );
			SetTabIndices();
		}
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm( int device_pk )
		{
			Initialise( all_Devices.DeviceByKey( device_pk ) );
			SetTabIndices();
		}
		//___________________________________________________________________________________________________________________________________________
		private void Initialise( DEVICE device )
		{
			//Tack on the header text.
			this.Text = db_Connector.PartiallyQualifiedFileName;

			//Initialise the comboboxes.
			cbx_Countries.Items.AddRange( all_Nations.NationsAsArray );
			cbx_DeviceLocation.Items.AddRange( all_Devices.AllLocations.ToArray() );
			cbx_DeviceType.Items.AddRange( all_Devices.AllTypes.ToArray() );

			_EventState = new EVENT_STATE();
			_Messenger = new MESSENGER( this.tbx_Messages );

			Device = device;
			Device.Country = Country;
		}
		//___________________________________________________________________________________________________________________________________________
		private void SetTabIndices()
		{
			tbx_Matches.TabIndex				=  0;	//Pre-Find
			cbx_Countries.TabIndex				=  1;
			tbx_LongAreaCode.TabIndex			=  2;
			tbx_ShortAreaCode.TabIndex			=  3;
			tbx_LeadingDigits.TabIndex			=  4;
			tbx_TrailingDigits.TabIndex			=  5;
			cbx_DeviceLocation.TabIndex			=  6;
			cbx_DeviceType.TabIndex				=  7;
			tbx_Notes.TabIndex					=  8;

			chk_Selected.TabIndex				=  9;
			chk_DefaultRow.TabIndex				= 10;
			chk_Blocked.TabIndex				= 11;
			chk_X_Person.TabIndex				= 12;
			chk_X_Group.TabIndex				= 13;
			chk_X_Family.TabIndex				= 14;

			tbx_Filter.TabIndex					= 15;
			btn_FirstDevice.TabIndex			= 16;
			btn_PreviousDevice.TabIndex			= 17;
			btn_NextDevice.TabIndex				= 18;
			btn_LastDevice.TabIndex				= 19;
			btn_NewDevice.TabIndex				= 20;
			btn_InsertDevice.TabIndex			= 21;
			btn_UpdateDevice.TabIndex			= 22;
			btn_FindDevice.TabIndex				= 23;
			btn_CloseForm.TabIndex				= 24;
		}
		#endregion
	}
}
