//___________________________________________________________________________________________________________________________________________________
//GLOBAL: 
using MESSENGER			= CONTACTS.GLOBAL.TOOLS.Messenger;
using GLOBAL_DB			= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
//LOCAL:PERSON
using PERSON_ROW		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using SELECT_PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Select;
//LOCAL:PERSON_X_ADDRESS
using XDEVICE_DB		= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Database;
using XDEVICE_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Row;
using XDEVICE_INSERT	= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Database.Insert;
//LOCAL:DEVICE
using DEVICE_ROW		= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using SELECT_DEVICE		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Select;
//using LISTBOX_DEVICE	= CONTACTS.LOCAL.TERTIARY.DEVICE.REALISER.VERTICAL.LISTBOX.ListBoxAddress;
//INTERFACE:
using FIND_DEVICE		= CONTACTS.INTERFACE.DIALOGS.DlgFindDevice;
using FIND_PERSON		= CONTACTS.INTERFACE.DIALOGS.DlgFindPerson;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONNECTORS
{
	//___________________________________________________________________________________________________________________________________________________
	public partial class Person_X_Device : Form
	{
		#region DECLARATIONS
		private GLOBAL_DB db_Connector = new GLOBAL_DB();
		private static MESSENGER _Messenger;

		private PERSON_ROW _PersonRow = new SELECT_PERSON.DefaultPerson().Execute;
		private DEVICE_ROW _DeviceRow = new SELECT_DEVICE.DefaultDevice().Execute;
		private XDEVICE_ROW _PersonXDeviceRow;

		private string _MsgConnectionSuccess	= "Connect Person to Device successful.";
		private string _MsgConnectionFailed		= "Connect Person to Device failed.";
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Device()
		{
			InitializeComponent();
			InitialiseForm();
		}
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Device( PERSON_ROW person_row )
		{
			InitializeComponent();
			Person = person_row;
			InitialiseForm();
		}
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Device( DEVICE_ROW device_row )
		{
			InitializeComponent();
			Device = device_row;
			InitialiseForm();
		}
		#endregion


		#region INITIALISATION
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm()
		{
			this.Text = db_Connector.PartiallyQualifiedFileName;
			_Messenger = new MESSENGER( this.tbx_Messages );

			DisplayPerson();
			DisplayDevice();
		}
		#endregion


		#region RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		private PERSON_ROW Person
		{
			get { return _PersonRow; }
			set
			{
				_PersonRow = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string PkPersonAsText
		{
			get { return Person.PkPerson.AsString; }
		}
		//___________________________________________________________________________________________________________________________________________
		private DEVICE_ROW Device
		{
			get { return _DeviceRow; }
			set
			{
				_DeviceRow = value;
				DisplayDevice();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string PkAddressAsText
		{
			get { return Device.PkDevice.AsString; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string Message
		{
			set { _Messenger.Message = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private void FindPerson()
		{
			FIND_PERSON dlg_find_person = new FIND_PERSON();

			dlg_find_person.ShowDialog();
			if ( dlg_find_person.DialogResult == DialogResult.OK )
			{
				Person = dlg_find_person.SelectedPerson;
				tbx_PkPerson.Text = PkPersonAsText;
				return;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void FindAddress()
		{
			FIND_DEVICE dlg_find_device = new FIND_DEVICE();

			dlg_find_device.ShowDialog();
			if ( dlg_find_device.DialogResult == DialogResult.OK )
			{
				int pk = dlg_find_device.SelectedDevice;
				//tbx_PkDevice.Text = PkDeviceAsText;
				return;
			}
		}
		#endregion


		#region DISPLAY PERSON, ADDRESS, PERSON'S ADDRESSES, & ADDRESS' PERSONS
		//___________________________________________________________________________________________________________________________________________________
		private void DisplayPerson()
		{
			tbx_PkPerson.Text = PkPersonAsText;
			tbx_PersonName.Text = Person.NaturalName.AsIs;
		}
		//___________________________________________________________________________________________________________________________________________________
		private void DisplayDevice()
		{
			//LISTBOX_DEVICE listbox_device = new LISTBOX_DEVICE( Device, lbx_Device );
			//listbox_device.InsertLineValues();
		}
		#endregion


		#region BUTTON CLICKS
		//___________________________________________________________________________________________________________________________________________________
		private void btn_Close_Click( object sender, EventArgs e )
		{
			this.Close();
		}
		//___________________________________________________________________________________________________________________________________________________
		private void btn_FindPerson_Click( object sender, EventArgs e )
		{
			FindPerson();
		}
		//___________________________________________________________________________________________________________________________________________________
		private void btn_FindAddress_Click( object sender, EventArgs e )
		{
			FindAddress();
		}
		//___________________________________________________________________________________________________________________________________________________
		private void btn_Connect_Click( object sender, EventArgs e )
		{
			XDEVICE_ROW xdevice_row = XDEVICE_DB.ConstructDeviceRow( Person.PkPerson.Value, Device.PkDevice.Value, "1", "LABEL" );

			if ( new XDEVICE_INSERT.Persons_X_Device( xdevice_row ).Execute )
			{
				Message = _MsgConnectionSuccess;
			}
			else
			{
				Message = _MsgConnectionFailed;

			}
		}
		#endregion
	}
}
