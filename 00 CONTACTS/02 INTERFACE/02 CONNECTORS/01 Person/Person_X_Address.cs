//PERSON_X_ADDRESS: 
//___________________________________________________________________________________________________________________________________________________
//GLOBAL: 
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using MESSENGER		= CONTACTS.GLOBAL.TOOLS.Messenger;
//LOCAL:
using PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using ADDRESS		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using XADDRESS_ROW	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Row;

using FIND_PERSON	= CONTACTS.INTERFACE.DIALOGS.DlgFindPerson;
using FIND_ADDRESS	= CONTACTS.INTERFACE.DIALOGS.DlgFindAddress;

using INSERT_ADDRESS	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Insert.Persons_X_Address;
using DELETE_ADDRESS	= CONTACTS.LOCAL.SECONDARY.PERSON.XADDRESS.Database.Delete.Persons_X_Address;


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

				//foreach ( var kvp in person_x_addresses )
				//{
				//	XADDRESS_ROW pxa = ( XADDRESS_ROW )kvp.Value;
				//	_Address = new SELECT_ADDRESS.FullyQualifiedAddress( pxa.FkAddress.Value ).Execute;

				//	AppendPostalLines();
				//	AppendPhysicalLines();
				//	AppendExtendedLines();
				//	AppendExcelLines();
				//	AppendAllDataLines();
				//}


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
