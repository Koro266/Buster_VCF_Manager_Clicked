//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using static CONTACTS.LOCAL.PRIMARY.GROUP.Database.Like;
//LOCAL
using GROUP_ROW	= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using LIKE		= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Like;
using LIKE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
using PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using SELECT	= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.DIALOGS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class DlgFindGroup : Form
	{
		private LIKE_ROW matching_group;
		private LIKE_ROW[] matching_groups;

		private GROUP_ROW selected_group;
		private GROUP_ROW default_group = new SELECT.DefaultGroup().Execute;

		//___________________________________________________________________________________________________________________________________________
		public DlgFindGroup()
		{
			InitializeComponent();
			selected_group = default_group;
		}

		#region CHANGE HANDLERS
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Group_TextChanged( object sender, EventArgs e )
		{
			Clear();
			this.matching_groups = new LIKE.MatchingGroups( tbx_GroupName.Text ).Execute;
			Display();
		}
		//___________________________________________________________________________________________________________________________________________
		private void Clear()
		{
			this.lbx_MatchingGroups.Items.Clear();
		}
		//___________________________________________________________________________________________________________________________________________
		private void Display()
		{
			this.lbx_MatchingGroups.Items.AddRange( this.matching_groups );
		}
		#endregion


		#region Helpers...
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingGroups_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( lbx_MatchingGroups.SelectedIndex == PRESET.NoItemSelected )
				return;

			matching_group = ( LIKE_ROW )matching_groups[lbx_MatchingGroups.SelectedIndex];
			selected_group = new SELECT.ByPkGroup( matching_group.PkRow ).Execute;
		}
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingGroups_DoubleClick( object sender, EventArgs e )
		{
			if ( lbx_MatchingGroups.SelectedIndex == PRESET.NoItemSelected )
			{
				selected_group = default_group;
				this.DialogResult = DialogResult.Abort;
			}
			else 
			{
				matching_group = ( LIKE_ROW )matching_groups[lbx_MatchingGroups.SelectedIndex];
				selected_group = new SELECT.ByPkGroup( matching_group.PkRow ).Execute;
				this.DialogResult = DialogResult.OK;
			}

			Close();
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the selected Group row. 
		/// </summary>
		public GROUP_ROW SelectedGroup
		{
			get { return this.selected_group; }
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Close_Click( object sender, EventArgs e )
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Cancel_Click( object sender, EventArgs e )
		{
			selected_group = null;
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		#endregion
	}
}
