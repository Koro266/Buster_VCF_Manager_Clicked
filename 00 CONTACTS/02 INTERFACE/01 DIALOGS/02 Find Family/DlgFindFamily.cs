//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using LIKE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
//LOCAL
using FAMILY_LIKE	= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Like;
using FAMILY_SELECT	= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Select;
using MATCH_FAMILYS = CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Like.MatchingFamilies;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.DIALOGS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class DlgFindFamily : Form
	{
		private LIKE_ROW[] matching_Families;
		private int selected_Family = GLOBAL_PRESET.MINUS_ONE;

		//___________________________________________________________________________________________________________________________________________
		public DlgFindFamily()
		{
			InitializeComponent();
		}


		#region RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		private string FamilyPkAsText
		{
			set
			{
				int search_value;
				if ( int.TryParse( value, out search_value ) )
				{
					this.lbx_MatchingFamilies.Items.Add( new FAMILY_SELECT.ByPkFamily( search_value ).Execute );
				}
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string FamilyName
		{
			set
			{
				//matching_Familys = new MATCH_FAMILYS( value ).Execute;

				//				this.matching_Families = new FAMILY_LIKE.FamilyName( value ).Execute;
				this.lbx_MatchingFamilies.Items.Clear();
				this.lbx_MatchingFamilies.Items.AddRange( matching_Families.ToArray() );

				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int SelectedIndex
		{
			set
			{
				switch ( value )
				{
					case < 0:
						SelectedFamily = GLOBAL_PRESET.MINUS_ONE;
						this.DialogResult = DialogResult.Cancel;
						break;

					default:
						SelectedFamily = this.matching_Families[lbx_MatchingFamilies.SelectedIndex].PkRow;
						this.DialogResult = DialogResult.OK;
						break;
				}

				this.Close();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public int SelectedFamily
		{
			get { return selected_Family; }
			set { selected_Family = value; }
		}
		#endregion


		#region EVENT HANDLERS
		//___________________________________________________________________________________________________________________________________________
		private void btn_GetPk_Click( object sender, EventArgs e )
		{
			FamilyPkAsText = this.tbx_PkFamily.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_FamilyName_TextChanged( object sender, EventArgs e )
		{
			FamilyName = this.tbx_FamilyName.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingFamilies_SelectedIndexChanged( object sender, EventArgs e )
		{
			SelectedIndex = lbx_MatchingFamilies.SelectedIndex;
		}
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingFamilies_DoubleClick( object sender, EventArgs e )
		{
			SelectedIndex = lbx_MatchingFamilies.SelectedIndex;
		}
		#endregion


		#region DISPLAY
		//___________________________________________________________________________________________________________________________________________
		private void Display()
		{
			this.lbx_MatchingFamilies.Items.Clear();
			this.lbx_MatchingFamilies.Items.AddRange( this.matching_Families.ToArray() );
		}
		#endregion


		#region TERMINATION
		//___________________________________________________________________________________________________________________________________________
		private void btn_Close_Click( object sender, EventArgs e )
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Cancel_Click( object sender, EventArgs e )
		
		
		{
			this.selected_Family = GLOBAL_PRESET.MINUS_ONE;
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		#endregion
	}
}
