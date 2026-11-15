//___________________________________________________________________________________________________________________________________________________
//LOCAL
using PERSON_X_ADDRESS = CONTACTS.INTERFACE.CONNECTORS.Person_X_Address;
using PERSON_X_DEVICE = CONTACTS.INTERFACE.CONNECTORS.Person_X_Device;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONNECTORS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class X_Manager : Form
	{
		//___________________________________________________________________________________________________________________________________________
		public X_Manager()
		{
			InitializeComponent();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Person_X_Address_Click( object sender, EventArgs e )
		{
			PERSON_X_ADDRESS person_x_address = new PERSON_X_ADDRESS();
			person_x_address.ShowDialog( this );
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Person_X_Device_Click( object sender, EventArgs e )
		{
			PERSON_X_DEVICE person_x_device = new PERSON_X_DEVICE();
			person_x_device.ShowDialog( this );
		}
	}
}
