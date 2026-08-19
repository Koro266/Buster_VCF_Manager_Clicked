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


//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONNECTORS
{
	//___________________________________________________________________________________________________________________________________________________
	public partial class Person_X_Address : Form
	{
		private PERSON person = new SELECT_PERSON.DefaultPerson().Execute;
		private ADDRESS address = new SELECT_ADDRESS.DefaultAddress().Execute;

		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Address()
		{
			InitializeComponent();

			tbx_PkPerson.Text = person.PkPerson.AsString;
			tbx_PersonName.Text = person.NaturalName.AsIs;

			tbx_PkAddress.Text = address.PkAddress.AsString;
			lbx_Address.Items.AddRange( address.RealiseFinderPattern() );
		}
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Address( PERSON inbound_person )
		{
			InitializeComponent();
			person = inbound_person;

			tbx_PkPerson.Text = person.PkPerson.AsString;
			tbx_PersonName.Text = person.NaturalName.AsIs;

			tbx_PkAddress.Text = address.PkAddress.AsString;
			lbx_Address.Items.AddRange( address.RealiseFinderPattern() );
		}
		//___________________________________________________________________________________________________________________________________________________
		public Person_X_Address( ADDRESS inbound_address )
		{
			InitializeComponent();
			address = inbound_address;

			tbx_PkPerson.Text = person.PkPerson.AsString;
			tbx_PersonName.Text = person.NaturalName.AsIs;

			tbx_PkAddress.Text = address.PkAddress.AsString;
			lbx_Address.Items.AddRange( address.RealiseFinderPattern() );
		}
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
				tbx_PersonName.Text = person.NaturalName.Value;
				tbx_PkPerson.Text = person.PkPerson.AsString;

				Dictionary<int, BASE_ROW> person_x_addresses = new SELECT_XADDRESS.ByPkPerson( person.PkPerson.Value ).Execute;

				foreach ( var kvp in person_x_addresses )
				{
					XADDRESS_ROW pxa = ( XADDRESS_ROW )kvp.Value;
					lbx_AttachedAddresses.Items.AddRange( address.RealiseFinderPattern() );
				}
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
