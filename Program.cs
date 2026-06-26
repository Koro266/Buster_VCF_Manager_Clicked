//___________________________________________________________________________________________________________________________________________________
using STARTUP_MAN	= CONTACTS.GLOBAL.TOOLS.StartupManager;
using OVERSEER		= CONTACTS.INTERFACE.FORMS.FrmOverseer;
using PERSON		= CONTACTS.INTERFACE.FORMS.FrmPerson;
using FAMILY		= CONTACTS.INTERFACE.FORMS.FrmFamily;
using GROUP			= CONTACTS.INTERFACE.FORMS.FrmGroup;
using DEVICE		= CONTACTS.INTERFACE.FORMS.FrmDevice;
using ADDRESS		= CONTACTS.INTERFACE.FORMS.FrmAddress;

using FIND_PERSON	= CONTACTS.INTERFACE.DIALOGS.DlgFindPerson;
using FIND_GROUP	= CONTACTS.INTERFACE.DIALOGS.DlgFindGroup;
using FIND_ADDRESS	= CONTACTS.INTERFACE.DIALOGS.DlgFindAddress;
using FIND_DEVICE	= CONTACTS.INTERFACE.DIALOGS.DlgFindDevice;


//___________________________________________________________________________________________________________________________________________________
namespace VcfManager
{
	//_______________________________________________________________________________________________________________________________________________
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// To customize application configuration such as set high DPI settings or default font, see https://aka.ms/applicationconfiguration.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();

			switch ( STARTUP_MAN.StartUpInterface )
			{
				case STARTUP_MAN.StartupForm.Overseer:
					Application.Run( new OVERSEER() );
					break;

				case STARTUP_MAN.StartupForm.Person:
					Application.Run( new PERSON() );
					break;

				case STARTUP_MAN.StartupForm.Family:
					Application.Run( new FAMILY() );

					break;

				case STARTUP_MAN.StartupForm.Group:
					Application.Run( new GROUP() );
					break;

				case STARTUP_MAN.StartupForm.Address:
					Application.Run( new ADDRESS() );
					break;

				case STARTUP_MAN.StartupForm.Device:
					Application.Run( new DEVICE() );
					break;

				case STARTUP_MAN.StartupForm.FindPerson:
					Application.Run( new FIND_PERSON() );
					break;

				case STARTUP_MAN.StartupForm.FindGroup:
					Application.Run( new FIND_GROUP() );
					break;

				case STARTUP_MAN.StartupForm.FindAddress:
					Application.Run( new FIND_ADDRESS() );
					break;

				case STARTUP_MAN.StartupForm.FindDevice:
					Application.Run( new FIND_DEVICE() );
					break;

				default:
					Application.Run( new OVERSEER() );
					break;

			}
		}
	}
}