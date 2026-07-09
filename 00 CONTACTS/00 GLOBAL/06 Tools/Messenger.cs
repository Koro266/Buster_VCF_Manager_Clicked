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
		public Messenger( TextBox tbx_msg)
		{
			tbx_Messages = tbx_msg;
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
		public string NoItemSelected
		{
			get { return no_Item_Selected; }
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
		public string InsertFailed
		{
			get { return Insert_Failed; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "INSERT was successful.".
		/// </summary>
		public string InsertSucceeded
		{
			get { return Insert_Succeeded; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "UPDATE failed.".
		/// </summary>
		public string UpdateFailed
		{
			get { return Update_Failed; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns "UPDATE was successful.".
		/// </summary>
		public string UpdateSucceeded
		{
			get { return Update_Succeeded; }
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
