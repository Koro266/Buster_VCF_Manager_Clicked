//PERSON_X_ADDRESS: 
//___________________________________________________________________________________________________________________________________________________
//GLOBAL: 
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow ;
using MESSENGER			= CONTACTS.GLOBAL.TOOLS.Messenger;
//LOCAL:PERSON
using PERSON_ROW		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using SELECT_PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Select;
//LOCAL:ADDRESS
using ADDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using SELECT_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select;
using ADDRESS_VERTICAL	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISATION.XAddressVertical;
using FINDER_HORIZONTAL	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISATION.RealiseFinderAddress;
//LOCAL:PERSON_X_ADDRESS
using XADDRESS_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Row;
using DELETE_P_X_A		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Delete.Persons_X_Address;
using INSERT_P_X_A		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Insert.Persons_X_Address;
using SELECT_P_X_A		= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Select;
//INTERFACE:
using FIND_PERSON		= CONTACTS.INTERFACE.DIALOGS.DlgFindPerson;
using FIND_ADDRESS		= CONTACTS.INTERFACE.DIALOGS.DlgFindAddress;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONNECTORS
{
	//___________________________________________________________________________________________________________________________________________________
	public partial class Person_X_Address : Form
	{
		#region DECLARATIONS
		private PERSON_ROW _PersonRow = new SELECT_PERSON.DefaultPerson().Execute;
		private ADDRESS_ROW _AddressRow = new SELECT_ADDRESS.DefaultAddress().Execute;
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Address()
		{
			InitializeComponent();

			DisplayPerson();
			DisplayAddress();
			DisplayPersonsAddresses();
		}
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Address( PERSON_ROW inbound_person )
		{
			InitializeComponent();

			Person = inbound_person;

			DisplayPerson();
			DisplayAddress();
		}
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Address( ADDRESS_ROW inbound_address )
		{
			InitializeComponent();

			Address = inbound_address;

			DisplayPerson();
			DisplayAddress();
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
		private bool FindAddress()
		{
			FIND_ADDRESS find_address = new FIND_ADDRESS();
			find_address.ShowDialog();
			if ( find_address.DialogResult == DialogResult.OK )
			{
				Address = find_address.SelectedAddress;
				lbx_Address.Items.Clear();
				lbx_Address.Items.AddRange( Address.RealiseFinderPattern() );
				tbx_PkAddress.Text = Address.PkAddress.AsString;
				return true;
			}
			else
			{
				return false;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool FindPerson()
		{
			FIND_PERSON find_person = new FIND_PERSON();
			find_person.ShowDialog();
			if ( find_person.DialogResult == DialogResult.OK )
			{
				Person = find_person.SelectedPerson;
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion


		#region DISPLAY
		//___________________________________________________________________________________________________________________________________________________
		private void DisplayPerson()
		{
			tbx_PkPerson.Text = Person.PkPerson.AsString;
			tbx_PersonName.Text = Person.NaturalName.AsIs;
			DisplayPersonsAddresses();
		}
		//___________________________________________________________________________________________________________________________________________________
		private void DisplayAddress()
		{
			lbx_Address.Items.Clear();

			tbx_PkAddress.Text = Address.PkAddress.AsString;

			ADDRESS_VERTICAL address_vertical = new ADDRESS_VERTICAL( Address );
			lbx_Address.Items.AddRange( address_vertical.GetStrings );
			DisplayAddressesPersons();
		}
		//___________________________________________________________________________________________________________________________________________________
		private void DisplayAddressesPersons()
		{
			lbx_AttachedPersons.Items.Clear();

			Dictionary<int, BASE_ROW> address_x_persons = new SELECT_P_X_A.ByPkAddress( Address.PkAddress.Value ).Execute;

			int index = 0;
			foreach ( var kvp in address_x_persons )
			{
				XADDRESS_ROW pxa = ( XADDRESS_ROW )kvp.Value;

				PERSON_ROW person_row = new SELECT_PERSON.ByPkPerson( pxa.FkPerson.Value ).Execute;

				lbx_AttachedPersons.Items.Add( person_row.SortableName.Value );
			}
		}
		//___________________________________________________________________________________________________________________________________________________
		private void DisplayPersonsAddresses()
		{
			lvw_PersonsAddresses.Items.Clear();

			Dictionary<int, BASE_ROW> person_x_addresses = new SELECT_P_X_A.ByPkPerson( Person.PkPerson.Value ).Execute;

			int index = 0;
			foreach ( var kvp in person_x_addresses )
			{
				XADDRESS_ROW pxa = ( XADDRESS_ROW )kvp.Value;
				ADDRESS_ROW address_row = new SELECT_ADDRESS.ByPkAddress( pxa.FkAddress.Value ).Execute;
				FINDER_HORIZONTAL horizontal_realisation = new FINDER_HORIZONTAL( address_row );
				horizontal_realisation.RealiseAddress();

				string root_item = horizontal_realisation.RootItem;
				string[] sub_items = horizontal_realisation.Subitems;

				lvw_PersonsAddresses.Items.Add( root_item );
				lvw_PersonsAddresses.Items[index].SubItems.AddRange( sub_items );

				index++;
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
		}
		//___________________________________________________________________________________________________________________________________________________
		private void btn_Disconnect_Click( object sender, EventArgs e )
		{

		}
		#endregion
	}
}
