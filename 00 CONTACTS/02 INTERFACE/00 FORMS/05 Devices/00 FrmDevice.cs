//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using TXT_GATHER	= CONTACTS.GLOBAL.TOOLS.TextAccumulator;
using GLOBAL_DB		= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using LIKE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//DEVICE
using DEVICE		= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using DEVICES		= CONTACTS.LOCAL.TERTIARY.DEVICE.Table;
using REMINDER		= CONTACTS.LOCAL.TERTIARY.DEVICE.Constants.Reminders;
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

		private DEVICE one_Device;						  //One device.
		private DEVICES all_Devices = new DEVICES();		//Device table: manages collective devices.

		private NATION one_Nation;						  //One country.
		private NATIONS all_Nations = new NATIONS();		//Many countries.

		private LIKE_ROW[] matching_Devices;
		private bool is_event_Disabled = true;
		private TXT_GATHER txt_Accumulator;
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
			IsEventDisabled = true;

			tbx_DeviceId.Text			= DevicePkAsText;
			cbx_Countries.SelectedIndex	= FkCountry;
			tbx_LongAreaCode.Text		= LongAreaCode;
			tbx_ShortAreaCode.Text		= ShortAreaCode;
			tbx_LeadingDigits.Text		= LeadingDigits;
			tbx_TrailingDigits.Text		= TrailingDigits;
			cbx_DeviceLocation.Text		= DeviceLocation;
			cbx_DeviceType.Text			= DeviceType;
			tbx_DialNumber.Text			= DialNumber;
			tbx_PickerNumber.Text		= PickerNumber;
			tbx_Notes.Text				= Notes;

			IsEventDisabled = false;
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
			all_Devices.InsertDevice( Device );
			Device = all_Devices.CurrentDevice;
		}
		//___________________________________________________________________________________________________________________________________________
		private void UpdateDevice()
		{
			if ( all_Devices.UpdateDevice( Device ) )
			{
				UpdatePrompt( "Update succeeded." );
			}
			else
			{
				UpdatePrompt( "Update failed." );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string LongAreaCode
		{
			get { return Device.LongAreaCode.Value; }
			set
			{
				Device.LongAreaCodeAltered( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string ShortAreaCode
		{
			get { return Device.ShortAreaCode.Value; }
			set
			{
				Device.ShortAreaCodeAltered( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string LeadingDigits
		{
			get { return Device.LeadingDigits.Value; }
			set
			{
				Device.LeadingDigitsAltered( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string TrailingDigits
		{
			get { return Device.TrailingDigits.Value; }
			set
			{
				Device.TrailingDigitsAltered( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string DeviceLocation
		{
			get { return Device.DeviceLocation.Value; }
			set
			{
				Device.DeviceLocationAltered( value );
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string DeviceType
		{
			get { return Device.DeviceType.Value; }
			set
			{
				Device.DeviceTypeAltered( value );
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
				Device.NotesAltered( value );
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
		//___________________________________________________________________________________________________________________________________________
		private bool IsEventDisabled
		{
			get { return is_event_Disabled; }
			set { is_event_Disabled = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private bool IsEventEnabled
		{
			get { return is_event_Disabled == false; }
		}
		//___________________________________________________________________________________________________________________________________________
		private void Accumulator( string s )
		{
			txt_Accumulator = new TXT_GATHER( s );
		}
		#endregion


		#region EVENT HANDLERS

		#region VALUE CHANGED
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LongAreaCode_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				LongAreaCode = tbx_LongAreaCode.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ShortAreaCode_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				ShortAreaCode = tbx_ShortAreaCode.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LeadingDigits_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				LeadingDigits = tbx_LeadingDigits.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_TrailingDigits_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				TrailingDigits = tbx_TrailingDigits.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_DeviceLocation_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				DeviceLocation = cbx_DeviceLocation.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_DeviceType_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				DeviceType = cbx_DeviceType.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_Countries_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				CountrySelectedIndex = cbx_Countries.SelectedIndex;
		}
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingDevices_SelectedIndexChanged( object sender, EventArgs e )
		{
			DevicesSelectedIndex = this.lbx_MatchingDevices.SelectedIndex;
		}

		#region NOTES
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_Notes.Text );
			UpdatePrompt( Device.Notes.Factors.Prompt );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_Notes.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_Leave( object sender, EventArgs e )
		{
			Notes = txt_Accumulator.AsIs;
		}
		#endregion

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


		#region ENTER / PROMPTS / REMINDERS
		//___________________________________________________________________________________________________________________________________________
		private void UpdatePrompt( string reminder_text )
		{
			tbx_Prompt.Text = reminder_text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void UpdatePrompt( string[] reminder_text )
		{
			tbx_Prompt.Lines = reminder_text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_Countries_Enter( object sender, EventArgs e )
		{ UpdatePrompt( Device.FkCountry.Factors.Prompt ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LongAreaCode_Enter( object sender, EventArgs e )
		{ UpdatePrompt( Device.LongAreaCode.Factors.Prompt ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ShortAreaCode_Enter( object sender, EventArgs e )
		{ UpdatePrompt( Device.ShortAreaCode.Factors.Prompt ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LeadingDigits_Enter( object sender, EventArgs e )
		{ UpdatePrompt( Device.LeadingDigits.Factors.Prompt ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_TrailingDigits_Enter( object sender, EventArgs e )
		{ UpdatePrompt( Device.TrailingDigits.Factors.Prompt ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_DialNumber_Enter( object sender, EventArgs e )
		{ UpdatePrompt( Device.DialNumber.Factors.Prompt ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PickerNumber_Enter( object sender, EventArgs e )
		{ UpdatePrompt( Device.PickerNumber.Factors.Prompt ); }
		//___________________________________________________________________________________________________________________________________________
		private void grp_DeviceType_Enter( object sender, EventArgs e )
		{ UpdatePrompt( Device.DeviceType.Factors.Prompt ); }
		//___________________________________________________________________________________________________________________________________________
		private void grp_DeviceLocation_Enter( object sender, EventArgs e )
		{ UpdatePrompt( Device.DeviceLocation.Factors.Prompt ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_DeviceId_Enter( object sender, EventArgs e )
		{ UpdatePrompt( Device.PkDevice.Factors.Prompt ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Filter_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.Filter ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_FirstDevice_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.FirstDevice ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_PreviousDevice_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.PreviousDevice ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_NextDevice_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.NextDevice ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_LastDevice_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.LastDevice ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_FindDevice_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.FindDevice ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_Insert_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.InsertDevice ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_UpdateDevice_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.UpdateDevice ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_Close_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.CloseForm ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Matches_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.MatchesDevice ); }
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingDevices_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.MatchesDevice ); }
		#endregion

		#endregion


		#region INITIALISATION
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm()
		{
			Initialise( all_Devices.DefaultDevice );
			SetTabIndices();
			SetTabStops();
			SetEnabled();
		}
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm( int device_pk )
		{
			Initialise( all_Devices.DeviceByKey( device_pk ) );
			SetTabIndices();
			SetTabStops();
			SetEnabled();
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

			Device = device;
			Device.Country = Country;
		}
		//___________________________________________________________________________________________________________________________________________
		private void SetTabIndices()
		{
			cbx_Countries.TabIndex = 0;
			tbx_LongAreaCode.TabIndex = 1;
			tbx_ShortAreaCode.TabIndex = 2;
			tbx_LeadingDigits.TabIndex = 3;
			tbx_TrailingDigits.TabIndex = 4;
			cbx_DeviceLocation.TabIndex = 5;
			cbx_DeviceType.TabIndex = 6;
			tbx_Notes.TabIndex = 7;
			tbx_Filter.TabIndex = 8;
			btn_FirstDevice.TabIndex = 9;
			btn_PreviousDevice.TabIndex = 10;
			btn_NextDevice.TabIndex = 11;
			btn_LastDevice.TabIndex = 12;
			btn_FindDevice.TabIndex = 13;
			tbx_Matches.TabIndex = 14;
			btn_InsertDevice.TabIndex = 15;
			btn_UpdateDevice.TabIndex = 16;
			btn_CloseForm.TabIndex = 17;
			grp_DeviceData.TabIndex = 100;
			lbx_MatchingDevices.TabIndex = 101;
			tbx_Prompt.TabIndex = 102;
			tbx_DialNumber.TabIndex = 103;
			tbx_PickerNumber.TabIndex = 104;
			tbx_DeviceId.TabIndex = 105;
			lbl_PK.TabIndex = 106;
			lbl_CountryId.TabIndex = 107;
			lbl_LongAreaCode.TabIndex = 108;
			lbl_ShortAreaCode.TabIndex = 109;
			lbl_LeadingDigits.TabIndex = 110;
			lbl_TrailingDigits.TabIndex = 111;
			lbl_DeviceType.TabIndex = 112;
			lbl_DialNumber.TabIndex = 113;
			lbl_PickerNumber.TabIndex = 114;
			lbl_Note.TabIndex = 115;
			lbl_Search.TabIndex = 116;
			lbl_DeviceLocation.TabIndex = 117;
			lbl_FindPk.TabIndex = 118;
			lbl_ButtonFirst.TabIndex = 119;
			lbl_ButtonLast.TabIndex = 120;
		}
		//___________________________________________________________________________________________________________________________________________
		private void SetTabStops()
		{
			cbx_Countries.TabStop = true;
			tbx_LongAreaCode.TabStop = true;
			tbx_ShortAreaCode.TabStop = true;
			tbx_LeadingDigits.TabStop = true;
			tbx_TrailingDigits.TabStop = true;
			cbx_DeviceLocation.TabStop = true;
			cbx_DeviceType.TabStop = true;
			tbx_Notes.TabStop = true;
			tbx_Filter.TabStop = true;
			btn_FirstDevice.TabStop = true;
			btn_PreviousDevice.TabStop = true;
			btn_NextDevice.TabStop = true;
			btn_LastDevice.TabStop = true;
			btn_FindDevice.TabStop = true;
			tbx_Matches.TabStop = true;
			btn_InsertDevice.TabStop = true;
			btn_UpdateDevice.TabStop = true;
			btn_CloseForm.TabStop = true;
			grp_DeviceData.TabStop = false;
			lbx_MatchingDevices.TabStop = false;
			tbx_Prompt.TabStop = false;
			tbx_DialNumber.TabStop = false;
			tbx_PickerNumber.TabStop = false;
			tbx_DeviceId.TabStop = false;
			lbl_PK.TabStop = false;
			lbl_CountryId.TabStop = false;
			lbl_LongAreaCode.TabStop = false;
			lbl_ShortAreaCode.TabStop = false;
			lbl_LeadingDigits.TabStop = false;
			lbl_TrailingDigits.TabStop = false;
			lbl_DeviceType.TabStop = false;
			lbl_DialNumber.TabStop = false;
			lbl_PickerNumber.TabStop = false;
			lbl_Note.TabStop = false;
			lbl_Search.TabStop = false;
			lbl_DeviceLocation.TabStop = false;
			lbl_FindPk.TabStop = false;
			lbl_ButtonFirst.TabStop = false;
			lbl_ButtonLast.TabStop = false;
		}
		//___________________________________________________________________________________________________________________________________________
		private void SetEnabled()
		{
			cbx_Countries.Enabled = true;
			tbx_LongAreaCode.Enabled = true;
			tbx_ShortAreaCode.Enabled = true;
			tbx_LeadingDigits.Enabled = true;
			tbx_TrailingDigits.Enabled = true;
			cbx_DeviceLocation.Enabled = true;
			cbx_DeviceType.Enabled = true;
			tbx_Notes.Enabled = true;
			tbx_Filter.Enabled = true;
			btn_FirstDevice.Enabled = true;
			btn_PreviousDevice.Enabled = true;
			btn_NextDevice.Enabled = true;
			btn_LastDevice.Enabled = true;
			btn_FindDevice.Enabled = true;
			tbx_Matches.Enabled = true;
			btn_InsertDevice.Enabled = true;
			btn_UpdateDevice.Enabled = true;
			btn_CloseForm.Enabled = true;
			grp_DeviceData.Enabled = true;
			lbx_MatchingDevices.Enabled = true;
			tbx_Prompt.Enabled = true;
			tbx_DialNumber.Enabled = true;
			tbx_PickerNumber.Enabled = true;
			tbx_DeviceId.Enabled = true;
			lbl_PK.Enabled = true;
			lbl_CountryId.Enabled = true;
			lbl_LongAreaCode.Enabled = true;
			lbl_ShortAreaCode.Enabled = true;
			lbl_LeadingDigits.Enabled = true;
			lbl_TrailingDigits.Enabled = true;
			lbl_DeviceType.Enabled = true;
			lbl_DialNumber.Enabled = true;
			lbl_PickerNumber.Enabled = true;
			lbl_Note.Enabled = true;
			lbl_Search.Enabled = true;
			lbl_DeviceLocation.Enabled = true;
			lbl_FindPk.Enabled = true;
			lbl_ButtonFirst.Enabled = true;
			lbl_ButtonLast.Enabled = true;
		}
		#endregion
	}
}
