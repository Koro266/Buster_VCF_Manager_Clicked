//PERSON_X_ADDRESS: 
//___________________________________________________________________________________________________________________________________________________
//GLOBAL: 
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow ;
using ADDRESS		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using DELETE_PERSON_X_ADDRESS	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Delete.Persons_X_Address;
using FIND_ADDRESS	= CONTACTS.INTERFACE.DIALOGS.DlgFindAddress;
using FIND_PERSON	= CONTACTS.INTERFACE.DIALOGS.DlgFindPerson;
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using INSERT_PERSON_X_ADDRESS	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Insert.Persons_X_Address;
using MESSENGER		= CONTACTS.GLOBAL.TOOLS.Messenger;
//LOCAL:
using PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using SELECT_XADDRESS = CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Select;
using SELECT_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select;
using SELECT_PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Select;
using XADDRESS_ROW	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Row;
using FINDER_REALISATION = CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISATION.RealiseFinderAddress;


//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONNECTORS
{
	//___________________________________________________________________________________________________________________________________________________
	public partial class Person_X_Address : Form
	{
		private PERSON person = null;
		private ADDRESS address = null;

		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Address()
		{
			InitializeComponent();

			person = new SELECT_PERSON.DefaultPerson().Execute;
			address = new SELECT_ADDRESS.DefaultAddress().Execute;

			DisplayPerson();
			DisplayAddress();
			DisplayPersonsAddresses();
		}
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Address( PERSON inbound_person )
		{
			InitializeComponent();

			person = inbound_person;
			address = new SELECT_ADDRESS.DefaultAddress().Execute;

			DisplayPerson();
			DisplayAddress();
		}
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Address( ADDRESS inbound_address )
		{
			InitializeComponent();

			person = new SELECT_PERSON.DefaultPerson().Execute;
			address = inbound_address;

			DisplayPerson();
			DisplayAddress();
		}
		//___________________________________________________________________________________________________________________________________________________
		private void DisplayPerson()
		{
			tbx_PkPerson.Text = person.PkPerson.AsString;
			tbx_PersonName.Text = person.NaturalName.AsIs;
			DisplayPersonsAddresses();
		}
		//___________________________________________________________________________________________________________________________________________________
		private void DisplayAddress()
		{
			tbx_PkAddress.Text = address.PkAddress.AsString;

			FINDER_REALISATION finder_realisation = new FINDER_REALISATION( address );
			string[] address_subparts = finder_realisation.GetStrings;
			//lvw_PersonsAddresses.Items.Add( s );
		}
		//___________________________________________________________________________________________________________________________________________________
		private void DisplayPersonsAddresses()
		{
			lvw_PersonsAddresses.Items.Clear();
			Dictionary<int, BASE_ROW> person_x_addresses = new SELECT_XADDRESS.ByPkPerson( person.PkPerson.Value ).Execute;
			int index = 0;

			foreach ( var kvp in person_x_addresses )
			{
				XADDRESS_ROW pxa = ( XADDRESS_ROW )kvp.Value;
				ADDRESS address = new SELECT_ADDRESS.ByPkAddress( pxa.FkAddress.Value ).Execute;
				FINDER_REALISATION finder_realisation = new FINDER_REALISATION( address );
				string[] address_subparts = finder_realisation.GetStrings;


				lvw_PersonsAddresses.Items.Add( address_subparts[0] );
				lvw_PersonsAddresses.Items[index].SubItems.Add( address_subparts[1] );
				lvw_PersonsAddresses.Items[index].SubItems.Add( address_subparts[2] );
				lvw_PersonsAddresses.Items[index].SubItems.Add( address_subparts[3] );
				lvw_PersonsAddresses.Items[index].SubItems.Add( address_subparts[4] );
				lvw_PersonsAddresses.Items[index].SubItems.Add( address_subparts[5] );
				lvw_PersonsAddresses.Items[index].SubItems.Add( address_subparts[6] );
				lvw_PersonsAddresses.Items[index].SubItems.Add( address_subparts[7] );

				index++;
			}
		}
		////___________________________________________________________________________________________________________________________________________
		//public void DisplayAddresses( Dictionary<int, BASE_ROW> address_rows )
		//{
		//	this.lvw_PersonsAddresses.Items.Clear();
		//	int index = 0;

		//	foreach ( KeyValuePair<int, BASE_ROW> row in address_rows )
		//	{
		//		ADDRESS address = ( ADDRESS )row.Value;
		//		string[] columns = address.RealiseFinderPattern();

		//		lvw_PersonsAddresses.Items.Add( columns[0] );
		//		lvw_PersonsAddresses.Items[index]..SubItems.Add( columns[1] );
		//		lvw_PersonsAddresses.Items[index].SubItems.Add( columns[2] );
		//		lvw_PersonsAddresses.Items[index].SubItems.Add( columns[3] );
		//		lvw_PersonsAddresses.Items[index].SubItems.Add( columns[4] );
		//		lvw_PersonsAddresses.Items[index].SubItems.Add( columns[5] );
		//		lvw_PersonsAddresses.Items[index++].SubItems.Add( columns[6] );
		//	}
		//}
		//___________________________________________________________________________________________________________________________________________________
		private void btn_Close_Click( object sender, EventArgs e )
		{
			this.Close();
		}
		//___________________________________________________________________________________________________________________________________________________
		private void btn_FindPerson_Click( object sender, EventArgs e )
		{
			FIND_PERSON find_person = new FIND_PERSON();
			find_person.ShowDialog();
			if ( find_person.DialogResult == DialogResult.OK )
			{
				person = find_person.SelectedPerson;
				DisplayPerson();
				DisplayPersonsAddresses();
			}
		}
		//___________________________________________________________________________________________________________________________________________________
		private void btn_FindAddress_Click( object sender, EventArgs e )
		{
			FIND_ADDRESS find_address = new FIND_ADDRESS();
			find_address.ShowDialog();
			if ( find_address.DialogResult == DialogResult.OK )
			{
				address = find_address.SelectedAddress;
				string[] s = address.RealiseFinderPattern();
				lbx_Address.Items.AddRange( s );
				tbx_PkAddress.Text = address.PkAddress.AsString;
			}
		}
		//___________________________________________________________________________________________________________________________________________________
		private void btn_Connect_Click( object sender, EventArgs e )
		{
		}
		//___________________________________________________________________________________________________________________________________________________
		private void btn_Disconnect_Click( object sender, EventArgs e )
		{

		}
	}
}
