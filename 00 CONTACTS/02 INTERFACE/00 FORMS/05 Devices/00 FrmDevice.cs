//___________________________________________________________________________________________________________________________________________________
using System.Windows.Forms;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using GLOBAL_DB		= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using EVENT_STATE	= CONTACTS.GLOBAL.TOOLS.EventState;
using LIKE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
using MESSENGER		= CONTACTS.GLOBAL.TOOLS.Messenger;
using TXT_GATHER	= CONTACTS.GLOBAL.TOOLS.TextAccumulator;
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using DEVICE_ROWS	= CONTACTS.LOCAL.TERTIARY.DEVICE.Table;
using NATION_ROW	= CONTACTS.LOCAL.TERTIARY.NATION.Row;
using NATION_ROWS	= CONTACTS.LOCAL.TERTIARY.NATION.Table;
using LIKE			= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Like;
//INTERFACE
using FIND_DEVICE	= CONTACTS.INTERFACE.DIALOGS.DlgFindDevice;
using LIST_BOX		= CONTACTS.INTERFACE.CONTROLS.DEVICE.VERTICAL.LISTBOX.ListBoxDevice;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.FORMS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class FrmDevice : Form
	{
		#region DECLARATIONS
		private GLOBAL_DB db_Connector = new GLOBAL_DB();

		private DEVICE_ROW _Device;
		private DEVICE_ROWS _Devices = new DEVICE_ROWS();

		private NATION_ROW _Nation;
		private NATION_ROWS _Nations = new NATION_ROWS();

		private LIST_BOX _PreFindList;
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

			_PreFindList = new LIST_BOX( lbx_MatchingDevices );
		}
		//___________________________________________________________________________________________________________________________________________
		public FrmDevice( int device_pk )
		{
			InitializeComponent();

			InitialiseForm( device_pk );
			DisplayDevice();

			_PreFindList = new LIST_BOX( lbx_MatchingDevices );
		}
		#endregion


		#region DISPLAY
		//___________________________________________________________________________________________________________________________________________
		private void DisplayDevice()
		{
			_EventState.DisableEvents();

			tbx_DeviceId.Text = DevicePkAsText;
			cbx_Countries.SelectedIndex = FkCountry;
			tbx_LongAreaCode.Text = LongAreaCode;
			tbx_ShortAreaCode.Text = ShortAreaCode;
			tbx_LeadingDigits.Text = LeadingDigits;
			tbx_TrailingDigits.Text = TrailingDigits;
			cbx_DeviceLocation.Text = DeviceLocation;
			cbx_DeviceType.Text = DeviceType;
			tbx_DialNumber.Text = DialNumber;
			tbx_PickerNumber.Text = PickerNumber;
			tbx_Notes.Text = Notes;

			chk_Selected.Checked = Selected;
			chk_DefaultRow.Checked = DefaultRow;
			chk_Blocked.Checked = Blocked;
			chk_X_Person.Checked = XPerson;
			chk_X_Group.Checked = XGroup;
			chk_X_Family.Checked = XFamily;

			_EventState.EnableEvents();
		}
		#endregion


		#region RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		private DEVICE_ROW Device
		{
			get { return _Device; }
			set
			{
				_Device = value;
				FkCountry = _Device.FkCountry.Value;
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private NATION_ROW Country
		{
			get { return _Nations.NationByKey( Device.FkCountry.Value ); }
			set
			{
				_Nation = value;
				Device.CountryAltered( _Nation );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int DevicePk
		{
			get { return Device.PkDevice.Value; }
			set { Device = _Devices.DeviceByKey( value ); }
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
				Country = _Nations.NationByKey( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void NewDevice()
		{
			_Device = _Devices.NewDevice;
			DisplayDevice();
		}
		//___________________________________________________________________________________________________________________________________________
		private void InsertDevice()
		{
			if ( _Devices.InsertDevice( Device ) )
				_Messenger.InsertSucceeded();
			else
				_Messenger.InsertFailed();
		}
		//___________________________________________________________________________________________________________________________________________
		private void UpdateDevice()
		{
			if ( _Devices.UpdateDevice( Device ) )
				_Messenger.UpdateSucceeded();
			else
				_Messenger.UpdateFailed();
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
		private int CountrySelectedIndex
		{
			set
			{
				if ( value == GLOBAL_PRESET.NoItemSelected )
				{
					Country = _Nations.DefaultNation;
				}
				else
				{
					Country = _Nations.NationByIndex( value );
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
					Device = dlg_find_device.SelectedDevice;
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
		#endregion


		#region PRE-FIND
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Matches_TextChanged( object sender, EventArgs e )
		{
			_PreFindList.SoughtAfterText = tbx_Matches.Text;
		}
		#endregion


		#region NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		private void btn_FirstDevice_Click( object sender, EventArgs e )
		{
			Device = _Devices.FirstDevice;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_PreviousDevice_Click( object sender, EventArgs e )
		{
			Device = _Devices.PreviousDevice;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_NextDevice_Click( object sender, EventArgs e )
		{
			Device = _Devices.NextDevice;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_LastDevice_Click( object sender, EventArgs e )
		{
			Device = _Devices.LastDevice;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_FindDevice_Click( object sender, EventArgs e )
		{
			FindDevice();
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
		private void btn_NewDevice_Click( object sender, EventArgs e )
		{
			NewDevice();
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
			Initialise( _Devices.DefaultDevice );
			SetTabIndices();
		}
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm( int device_pk )
		{
			Initialise( _Devices.DeviceByKey( device_pk ) );
			SetTabIndices();
		}
		//___________________________________________________________________________________________________________________________________________
		private void Initialise( DEVICE_ROW device_row )
		{
			this.Text = db_Connector.PartiallyQualifiedFileName;

			cbx_Countries.Items.AddRange( _Nations.NationsAsArray );
			cbx_DeviceLocation.Items.AddRange( _Devices.AllLocations.ToArray() );
			cbx_DeviceType.Items.AddRange( _Devices.AllTypes.ToArray() );

			_EventState = new EVENT_STATE();
			_Messenger = new MESSENGER( this.tbx_Messages );

			Device = device_row;
			Device.Country = Country;
		}
		//___________________________________________________________________________________________________________________________________________
		private void SetTabIndices()
		{
			tbx_Matches.TabIndex = 0;
			cbx_Countries.TabIndex = 1;
			tbx_LongAreaCode.TabIndex = 2;
			tbx_ShortAreaCode.TabIndex = 3;
			tbx_LeadingDigits.TabIndex = 4;
			tbx_TrailingDigits.TabIndex = 5;
			cbx_DeviceLocation.TabIndex = 6;
			cbx_DeviceType.TabIndex = 7;
			tbx_Notes.TabIndex = 8;

			chk_Selected.TabIndex = 9;
			chk_DefaultRow.TabIndex = 10;
			chk_Blocked.TabIndex = 11;
			chk_X_Person.TabIndex = 12;
			chk_X_Group.TabIndex = 13;
			chk_X_Family.TabIndex = 14;

			tbx_Filter.TabIndex = 15;
			btn_FirstDevice.TabIndex = 16;
			btn_PreviousDevice.TabIndex = 17;
			btn_NextDevice.TabIndex = 18;
			btn_LastDevice.TabIndex = 19;
			btn_NewDevice.TabIndex = 20;
			btn_InsertDevice.TabIndex = 21;
			btn_UpdateDevice.TabIndex = 22;
			btn_FindDevice.TabIndex = 23;
			btn_CloseForm.TabIndex = 24;
		}
		#endregion
	}
}
