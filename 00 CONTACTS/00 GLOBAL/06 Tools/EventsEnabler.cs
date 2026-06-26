//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.TOOLS
{
	//___________________________________________________________________________________________________________________________________________________
	public class EventState
	{
		private bool are_EventsEnabled;

		//___________________________________________________________________________________________________________________________________________
		public void DisableButton( Button button )
		{
			button.Enabled = false;
		}
		//___________________________________________________________________________________________________________________________________________
		public void EnableButton( Button button )
		{
			button.Enabled = true;
		}
		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// EnabledState is initialised to true.
		/// </summary>
		public EventState()
		{
			EnableEvents();
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if controls accept user input, false otherwise.
		/// </summary>
		public bool EnabledState
		{
			get{ return are_EventsEnabled; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if controls accept user input, false otherwise.
		/// </summary>
		public bool IsEnabled
		{
			get { return are_EventsEnabled == true; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if control ignore user input, false otherwise.
		/// </summary>
		public bool IsDisabled
		{
			get { return are_EventsEnabled == false; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Sets EnabledState = true: allows user input, prevents internal changes.
		/// </summary>
		public void EnableEvents()
		{
			are_EventsEnabled = true;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Sets EnabledState = false: ignores user input, accepts internal changes.
		/// </summary>
		public void DisableEvents()
		{
			are_EventsEnabled = false;
		}
	}
}

