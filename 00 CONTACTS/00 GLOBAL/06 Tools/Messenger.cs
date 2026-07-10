//___________________________________________________________________________________________________________________________________________________
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.TOOLS
{
	//___________________________________________________________________________________________________________________________________________________
	public class Messenger
	{
		#region DECLARATIONS
		private TextBox tbx_Messages;		//User-supplied TextBox into which messages are placed.
		private int async_Delay = 2000;		//Default delay (2 seconds)

		//Stock messages
		private const string no_Item_Selected	= "No item selected.";
		private const string is_Valid_Selection	= PRESET.S0 + " is a valid selection.";
		private const string Person_Exported	= "PERSON: " + PRESET.S0 + " exported.";
		private const string Group_Exported		= "GROUP: " + PRESET.S0 + " exported.";
		private const string Family_Exported	= "FAMILY: " + PRESET.S0 + " exported.";
		private const string Update_Succeeded	= "UPDATE successful.";
		private const string Update_Failed		= "UPDATE failed.";
		private const string Insert_Succeeded	= "INSERT successful.";
		private const string Insert_Failed		= "INSERT failed.";
		private const string Finished			= "Done.";
		private const string NoMessage			= "--";
		#endregion


		#region CONSTRUCTION
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
		#endregion


		#region MESSAGING
		//___________________________________________________________________________________________________________________________________________
		private async Task AsyncMessage( string msg )
		{
			this.tbx_Messages.Text = msg;
			await Task.Delay( async_Delay );
			this.tbx_Messages.Text = NoMessage;
		}
		//___________________________________________________________________________________________________________________________________________
		public string Message
		{
			set { AsyncMessage( value ); }
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
		/// Displays "No item selected.".
		/// </summary>
		public void NoItemSelected()
		{
			AsyncMessage( no_Item_Selected );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Inserts 'value' into "value is a valid selection." and displays the result.
		/// </summary>
		public void ValidSelection( string value )
		{
			AsyncMessage( is_Valid_Selection.Replace( PRESET.S0, value ) );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Inserts 'person_name' into "PERSON: person_name exported." and displays the result.
		/// </summary>
		public void PersonExported( string person_name)
		{
			AsyncMessage( Person_Exported.Replace( PRESET.S0, person_name ) );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Inserts 'group_name' into "GROUP: group_name exported." and displays the result.
		/// </summary>
		public void GroupExported( string group_name )
		{
			AsyncMessage( Group_Exported.Replace( PRESET.S0, group_name ) );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Inserts 'family_name' into "FAMILY: family_name exported." and displays the result.
		/// </summary>
		public void FamilyExported( string family_name )
		{
			AsyncMessage( Family_Exported.Replace( PRESET.S0, family_name ) );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Displays "INSERT failed.".
		/// </summary>
		public void InsertFailed()
		{
			AsyncMessage(Insert_Failed );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Displays "INSERT successful.".
		/// </summary>
		public void InsertSucceeded()
		{
			AsyncMessage( Insert_Succeeded );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Displays "UPDATE failed.".
		/// </summary>
		public void UpdateFailed()
		{
			AsyncMessage( Update_Failed );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Displays "UPDATE successful.".
		/// </summary>
		public void UpdateSucceeded()
		{
			AsyncMessage(Update_Succeeded );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Displays "Done.".
		/// </summary>
		public void Done()
		{
			AsyncMessage( Finished );
		}
		#endregion
	}
}
