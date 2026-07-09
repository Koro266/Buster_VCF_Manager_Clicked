//___________________________________________________________________________________________________________________________________________________
using CONTACTS.GLOBAL.VALUES.CONSTANT;

namespace CONTACTS.GLOBAL.TOOLS
{
	//___________________________________________________________________________________________________________________________________________________
	public class Messenger
	{
		private TextBox tbx_Messages;
		private int async_Delay = 2000;
		private const string no_Item_Selected	= "No item selected.";
		private const string is_Valid_Selection	= "#0 is a valid selection.";
		private const string Update_Succeeded	= "UPDATE was successful.";
		private const string Update_Failed		= "UPDATE failed.";
		private const string Insert_Succeeded	= "INSERT was successful.";
		private const string Insert_Failed		= "INSERT failed.";
		private const string Finished			= "Done.";


		//___________________________________________________________________________________________________________________________________________________
		public Messenger( TextBox tbx_msg )
		{
			tbx_Messages = tbx_msg;
		}
		//___________________________________________________________________________________________________________________________________________________
		public Messenger( TextBox tbx_msg, int async_delay )
		{
			tbx_Messages = tbx_msg;
			async_Delay = async_delay;
		}
		//___________________________________________________________________________________________________________________________________________
		public string Message
		{
			set { AsyncMessage( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private async Task AsyncMessage( string msg )
		{
			this.tbx_Messages.Text = msg;
			await Task.Delay( async_Delay );
			this.tbx_Messages.Text = String.Empty;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Sets number of milliseconds message is displayed (default = 2000).
		/// </summary>
		public int AsyncDelay
		{
			set { async_Delay = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "No item selected..".
		/// </summary>
		public void NoItemSelected()
		{
			AsyncMessage( no_Item_Selected );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "value is a valid selection.".
		/// </summary>
		public string ValidSelection(string value)
		{
			return is_Valid_Selection.Replace( "#0", value );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "INSERT failed.".
		/// </summary>
		public void InsertFailed()
		{
			AsyncMessage(Insert_Failed );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "INSERT was successful.".
		/// </summary>
		public void InsertSucceeded()
		{
			AsyncMessage( Insert_Succeeded );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "UPDATE failed.".
		/// </summary>
		public void UpdateFailed()
		{
			AsyncMessage( Update_Failed );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "UPDATE was successful.".
		/// </summary>
		public void UpdateSucceeded()
		{
			AsyncMessage(Update_Succeeded );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "Done!".
		/// </summary>
		public void Done()
		{
			AsyncMessage( Finished );
		}
	}
}
