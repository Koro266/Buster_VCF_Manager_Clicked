//PERSON_X_ADDRESS: 
using System;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL: 
using GLOBAL_DB			= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow ;
using MESSENGER			= CONTACTS.GLOBAL.TOOLS.Messenger;
//LOCAL:PERSON
using PERSON_ROW		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using SELECT_PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Select;
using SELECT_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select;
//LOCAL:PERSON_X_ADDRESS
using XADDRESS_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Row;
using SELECT_P_X_A		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Select;
using DELETE_P_X_A		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Delete.Persons_X_Address;
using INSERT_P_X_A		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Insert.Persons_X_Address;
//LOCAL:ADDRESS
using ADDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using ADDRESS_VERTICAL	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.DefaultAddress;
using ADDRESS_FRACTIONS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.DefaultAddress;
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

		private string _MsgFindPersonDismissed = "Find Person dialog dismissed.";
		private string _MsgFindAddressDismissed = "Find Address dialog dismissed.";
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
			DisplayAddress();
			DisplayPersonsAddresses();
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
				DisplayPersonsAddresses();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int PkPerson
		{
			get { return Person.PkPerson.Value; }
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
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int PkAddress
		{
			get { return Address.PkAddress.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string PkAddressAsText
		{
			get { return Address.PkAddress.AsString; }
		}
		//___________________________________________________________________________________________________________________________________________
		private XADDRESS_ROW PersonXAddressRow
		{
			get { return _PersonXAddressRow; }
			set { _PersonXAddressRow = value;  }
		}
		//___________________________________________________________________________________________________________________________________________
		private int PkPersonAddress
		{
			get { return PersonXAddressRow.PkPerson_X_Address.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string PkPersonAddressText
		{
			get { return PersonXAddressRow.PkPerson_X_Address.AsString; }
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
				return;
			}

			Message = _MsgFindPersonDismissed;
		}
		//___________________________________________________________________________________________________________________________________________
		private void FindAddress()
		{
			FIND_ADDRESS dlg_find_address = new FIND_ADDRESS();

			dlg_find_address.ShowDialog();
			if ( dlg_find_address.DialogResult == DialogResult.OK )
			{
				Address = dlg_find_address.SelectedAddress;
				return;
			}

			Message = _MsgFindAddressDismissed;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the addresses that are attached to a person.
		/// </summary>
		private ADDRESS_ROW[] GetPersonsAddresses
		{
			get 
			{
				Dictionary<int, BASE_ROW> base_rows = new SELECT_P_X_A.ByPkPerson( Person.PkPerson.Value ).Execute;
				ADDRESS_ROW[] address_rows = new ADDRESS_ROW[base_rows.Count];

				int index = 0;
				foreach ( var kvp in base_rows )
				{
					XADDRESS_ROW x_address_row = ( XADDRESS_ROW )kvp.Value;
					address_rows[index++] = new SELECT_ADDRESS.ByPkAddress( x_address_row.FkAddress.Value ).Execute;
				}

				return address_rows;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the persons that are attached to an address.
		/// </summary>
		private PERSON_ROW[] GetAddressPersons
		{
			get
			{
				Dictionary<int, BASE_ROW> base_rows = new SELECT_P_X_A.ByPkAddress( Address.PkAddress.Value ).Execute;
				PERSON_ROW[] person_rows = new PERSON_ROW[base_rows.Count];

				int index = 0;
				foreach ( var kvp in base_rows )
				{
					XADDRESS_ROW x_address_row = ( XADDRESS_ROW )kvp.Value;
					person_rows[index++] = new SELECT_PERSON.ByPkPerson( x_address_row.FkPerson.Value ).Execute;
				}

				return person_rows;
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
		private void DisplayAddress()
		{
			lbx_Address.Items.Clear();

			tbx_PkAddress.Text = this.PkAddressAsText;

			ADDRESS_VERTICAL address_vertical = new ADDRESS_VERTICAL( Address );
			address_vertical.RealiseAddress();
			lbx_Address.Items.AddRange( address_vertical.Result );

			DisplayAddressPersons();
		}
		//___________________________________________________________________________________________________________________________________________________
		private void DisplayPersonsAddresses()
		{
			ADDRESS_ROW[] address_rows = GetPersonsAddresses;
			int count = address_rows.Count();

			lvw_PersonsAddresses.Items.Clear();

			for ( int index = 0; index < count; index++ )
			{
				ADDRESS_FRACTIONS horizontal_realisation = new ADDRESS_FRACTIONS( address_rows[index] );
				horizontal_realisation.RealiseAddress();

				lvw_PersonsAddresses.Items.Add( horizontal_realisation.RootItem );
				lvw_PersonsAddresses.Items[index].SubItems.AddRange( horizontal_realisation.Subitems );
			}
		}
		//___________________________________________________________________________________________________________________________________________________
		private void DisplayAddressPersons()
		{
			PERSON_ROW[] person_rows = GetAddressPersons;
			int count = person_rows.Count();

			lbx_AttachedPersons.Items.Clear();

			for ( int index = 0; index < count; index++ )
			{
				lbx_AttachedPersons.Items.Add( person_rows[index].SortableName.Value );
			}
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
			_Messenger.Message = "Connected ...";
		}
		//___________________________________________________________________________________________________________________________________________________
		private void btn_Disconnect_Click( object sender, EventArgs e )
		{
			_Messenger.Message = "Disconnected ...";
		}
		#endregion
	}
}
/* This here because VS thinks its ordering of alias declarations is superior to mine.
 
//PERSON_X_ADDRESS: 
using System;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL: 
using GLOBAL_DB			= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow ;
using MESSENGER			= CONTACTS.GLOBAL.TOOLS.Messenger;
//LOCAL:PERSON
using PERSON_ROW		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using SELECT_PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Select;
using SELECT_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select;
//LOCAL:PERSON_X_ADDRESS
using XADDRESS_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Row;
using SELECT_P_X_A		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Select;
using DELETE_P_X_A		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Delete.Persons_X_Address;
using INSERT_P_X_A		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Insert.Persons_X_Address;
//LOCAL:ADDRESS
using ADDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using ADDRESS_VERTICAL	= CONTACTS.LOCAL.TERTIARY.ADDRESS.XAddressVertical;
using ADDRESS_FRACTIONS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row.AddressFractions;
//INTERFACE:
using FIND_ADDRESS		= CONTACTS.INTERFACE.DIALOGS.DlgFindAddress;
using FIND_PERSON		= CONTACTS.INTERFACE.DIALOGS.DlgFindPerson;

 */
