//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using GLOBAL_DB		= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using DATE_COLUMN	= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using GLOBAL_PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using LIKE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
//LOCAL
using ALL_GROUPS	= CONTACTS.LOCAL.PRIMARY.GROUP.Table;
using SELECT		= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Select;
using LIKE			= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Like;
using ONE_GROUP		= CONTACTS.LOCAL.PRIMARY.GROUP.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.FORMS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class FrmGroup : Form
	{
		#region 00 DECLARE / CONSTRUCT
		private GLOBAL_DB db_Connector = new GLOBAL_DB();

		private ONE_GROUP one_Group;
		private static ALL_GROUPS all_Groups = new ALL_GROUPS();

		private LIKE_ROW[] matching_Groups;
		private bool is_event_Disabled = false;
		private TextAccumulator txt_Accumulator;
		//___________________________________________________________________________________________________________________________________________
		public FrmGroup()
		{
			InitializeComponent();
			InitialiseForm();

			Group = all_Groups.DefaultGroup;
		}
		#endregion


		#region 01 INITIALISE & DISPLAY

		#region DISPLAY
		//___________________________________________________________________________________________________________________________________________
		private void DisplayGroup()
		{
			//DisableEvents();

			this.tbx_PkGroup.Text = GroupPkAsText;
			this.tbx_GroupName.Text = GroupName;
			this.cbx_GroupType.Text = GroupType;
			this.dbx_CurrencyDate.CustomFormat = Group.CurrencyDate.DatePickerFormat;
			this.dbx_CurrencyDate.Value = Group.CurrencyDate.DatePickerValue;
			this.tbx_Notes.Text = Notes;

			//EnableEvents();
		}
		//___________________________________________________________________________________________________________________________________________
		private void DisplayMatchingGroups( LIKE_ROW[] matching_groups )
		{
			this.lbx_MatchingGroups.Items.Clear();
			this.lbx_MatchingGroups.Items.AddRange( matching_groups );
		}
		#endregion


		#region INITIALISATION/FINALISATION
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm()
		{
			ValuateGroupTypes();
			PutHeader();
		}
		//___________________________________________________________________________________________________________________________________________
		private void ValuateGroupTypes()
		{
			List<string> uniqueGroupTypes = new SELECT.UniqueGroupTypes().Execute;
			cbx_GroupType.Items.AddRange( uniqueGroupTypes.ToArray() );
		}
		//___________________________________________________________________________________________________________________________________________
		private void PutHeader()
		{
			this.Text = db_Connector.PartiallyQualifiedFileName;
		}
		#endregion

		#endregion


		#region 02 RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		private ONE_GROUP Group
		{
			get { return one_Group; }
			set
			{
				one_Group = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private ALL_GROUPS Groups
		{
			get { return all_Groups; }
			set { all_Groups = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private int GroupPk
		{
			get { return Group.PkGroup.Value; }
			set { Group = all_Groups.GroupByKey( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private string GroupPkAsText
		{
			get { return Group.PkGroup.AsString; }
			set { GroupPk = Convert.ToInt32( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private void InsertGroup()
		{
			all_Groups.InsertGroup( Group );
			Group = all_Groups.CurrentGroup;
		}
		//___________________________________________________________________________________________________________________________________________
		private void UpdateGroup()
		{
			all_Groups.UpdateGroup( Group );
		}
		//___________________________________________________________________________________________________________________________________________
		private string GroupName
		{
			get { return Group.GroupName.Value; }
			set
			{
				Group.NewGroupName = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string GroupType
		{
			get { return Group.GroupType.Value; }
			set
			{
				Group.NewGroupType = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Notes
		{
			get { return Group.Notes.Value; }
			set
			{
				Group.NewNotes = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string MatchesText
		{
			set
			{
				lbx_MatchingGroups.Items.Clear();

				matching_Groups = new LIKE.MatchingGroups( value ).Execute;
				if ( matching_Groups.Length == 0 )
					return;

				lbx_MatchingGroups.Items.AddRange( matching_Groups );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int GroupsSelectedIndex
		{
			set
			{
				if ( value == GLOBAL_PRESET.NoItemSelected )
				{
					Group = all_Groups.DefaultGroup;
				}
				else
				{
					LIKE_ROW like_row = ( LIKE_ROW )( this.lbx_MatchingGroups.SelectedItem );
					this.GroupPk = like_row.PkRow;
				}
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private DateTime CurrencyDate
		{
			get { return Group.CurrencyDate.Value; }
			set
			{
				Group.NewCurrencyDate = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool IsEventEnabled
		{
			get { return is_event_Disabled == false; }
			set { bool is_event_Disabled = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string Accumulate
		{
			set { txt_Accumulator = new TextAccumulator( value ); }
		}
		#endregion


		#region 03 ENTER / CHANGE / LEAVE

		#region GROUP NAME
		//___________________________________________________________________________________________________________________________________________
		private void tbx_GroupName_Enter( object sender, EventArgs e )
		{
			Accumulate = tbx_GroupName.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_GroupName_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
			{
				string value = tbx_GroupName.Text;
				DisplayMatchingGroups( new LIKE.MatchingGroups( value ).Execute );
				Accumulate = tbx_GroupName.Text;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_GroupName_Leave( object sender, EventArgs e )
		{
			GroupName = txt_Accumulator.AsIs;
		}
		#endregion


		#region GROUP TYPE
		//___________________________________________________________________________________________________________________________________________
		private void cbx_GroupType_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				GroupType = cbx_GroupType.Text;
		}
		#endregion


		#region NOTES
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_Enter( object sender, EventArgs e )
		{
			Accumulate = tbx_Notes.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulate = tbx_Notes.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_Leave( object sender, EventArgs e )
		{
			Notes = txt_Accumulator.AsIs;
		}
		#endregion


		#region CURRENCY DATE
		//___________________________________________________________________________________________________________________________________________
		private void dbx_CurrencyDate_ValueChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				CurrencyDate = dbx_CurrencyDate.Value;
		}
		#endregion


		#region MATCHING GROUPS
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingGroups_SelectedIndexChanged( object sender, EventArgs e )
		{
			GroupsSelectedIndex = this.lbx_MatchingGroups.SelectedIndex;
		}
		#endregion

		#endregion


		#region 04 CLICK & 05 NAVIGATION ETC
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Matches_TextChanged( object sender, EventArgs e )
		{
			MatchesText = tbx_Matches.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_CurrencyNow_Click( object sender, EventArgs e )
		{
			CurrencyDate = DateTime.Now;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_FirstGroup_Click( object sender, EventArgs e )
		{
			Group = Groups.FirstGroup;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_PreviousGroup_Click( object sender, EventArgs e )
		{
			Group = Groups.PreviousGroup;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_NextGroup_Click( object sender, EventArgs e )
		{
			Group = Groups.NextGroup;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_LastGroup_Click( object sender, EventArgs e )
		{
			Group = Groups.LastGroup;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_ExportGroup_Click( object sender, EventArgs e )
		{
			Group.ExportGroup();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_CloseForm_Click( object sender, EventArgs e )
		{
			this.Close();
		}
		#endregion


		#region 06 SQL (INSERT, UPDATE)

		#region NEW/INSERT/UPDATE
		//___________________________________________________________________________________________________________________________________________
		private void btn_NewGroup_Click( object sender, EventArgs e )
		{
			this.Group = all_Groups.NewGroup;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_InsertGroup_Click( object sender, EventArgs e )
		{
			InsertGroup();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_UpdateGroup_Click( object sender, EventArgs e )
		{
			UpdateGroup();
		}
		#endregion


		#region KEY UP
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Filter_KeyUp( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Enter )
				GroupPkAsText = tbx_Filter.Text;
		}
		#endregion

		#endregion
	}
}
