//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.TOOLS
{
	//___________________________________________________________________________________________________________________________________________________
	public static class StartupManager
	{
		//___________________________________________________________________________________________________________________________________________________
		public enum StartupForm
		{
			Overseer,
			Person,
			Group,
			Family,
			Address,
			Device,
			FindPerson,
			FindGroup,
			FindFamily,
			FindAddress,
			FindDevice,
			Person_X_Address,
			Person_X_Device
		};

		#if DEBUG
		private static StartupForm startup_Interface = StartupForm.Person_X_Address;
		#else
		private static StartupForm startup_Interface = StartupForm.Overseer;
		#endif

		//___________________________________________________________________________________________________________________________________________________
		public static StartupForm StartUpInterface
		{
			get { return startup_Interface; }
		}
	}
}
