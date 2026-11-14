//___________________________________________________________________________________________________________________________________________________
//GLOBAL: 
using MESSENGER			= CONTACTS.GLOBAL.TOOLS.Messenger;
using GLOBAL_DB			= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
//LOCAL:PERSON
using PERSON_ROW		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using SELECT_PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Select;
//LOCAL:PERSON_X_ADDRESS
using XADDRESS_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Row;
using XADDRESS_INSERT	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Insert.Persons_X_Address;
//LOCAL:ADDRESS
using SELECT_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select;
using ADDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using LISTBOX_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.VERTICAL.LISTBOX.ListBoxAddress;
//INTERFACE:
using FIND_ADDRESS		= CONTACTS.INTERFACE.DIALOGS.DlgFindAddress;
using FIND_PERSON		= CONTACTS.INTERFACE.DIALOGS.DlgFindPerson;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONNECTORS
{
	//___________________________________________________________________________________________________________________________________________________
	public partial class Person_X_Address : Form
	{
		#region DECLARATIONS
		private GLOBAL_DB db_Connector = new GLOBAL_DB();
		private static MESSENGER _Messenger;

		private PERSON_ROW _PersonRow = new SELECT_PERSON.DefaultPerson().Execute;
		private ADDRESS_ROW _AddressRow = new SELECT_ADDRESS.DefaultAddress().Execute;
		private XADDRESS_ROW _PersonXAddressRow;

		private string _MsgConnectionSuccess	= "Connect Person to Address successful.";
		private string _MsgConnectionFailed		= "Connect Person to Address failed.";
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Address()
		{
			InitializeComponent();
			InitialiseForm();
		}
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Address( PERSON_ROW person_row )
		{
			InitializeComponent();
			Person = person_row;
			InitialiseForm();
		}
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Address( ADDRESS_ROW address_row )
		{
			InitializeComponent();
			Address = address_row;
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
			DisplayListBoxAddress();
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
		private ADDRESS_ROW Address
		{
			get { return _AddressRow; }
			set
			{
				_AddressRow = value;
				DisplayListBoxAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string PkAddressAsText
		{
			get { return Address.PkAddress.AsString; }
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
			FIND_ADDRESS dlg_find_address = new FIND_ADDRESS();

			dlg_find_address.ShowDialog();
			if ( dlg_find_address.DialogResult == DialogResult.OK )
			{
				Address = dlg_find_address.SelectedAddress;
				tbx_PkAddress.Text = PkAddressAsText;
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
		private void DisplayListBoxAddress()
		{
			LISTBOX_ADDRESS listbox_address = new LISTBOX_ADDRESS( Address, lbx_Address );
			listbox_address.InsertLineValues();
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
			if ( new XADDRESS_INSERT( _PersonRow, _AddressRow ).Execute )
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
