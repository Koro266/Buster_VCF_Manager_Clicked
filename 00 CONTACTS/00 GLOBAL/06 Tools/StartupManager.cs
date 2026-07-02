//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.TOOLS
{
	//___________________________________________________________________________________________________________________________________________________
	public static class StartupManager
	{
		//TODO: Standardise across all forms the "is enabled/disabled" approach.
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
			FindAddress,
			FindDevice
		};

		#if DEBUG
		private static StartupForm startup_Interface = StartupForm.Overseer;
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
