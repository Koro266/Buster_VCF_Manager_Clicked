//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.ROW;
using static CONTACTS.LOCAL.PRIMARY.GROUP.Database.Select;
//LOCAL
using ALL_GROUPS	= CONTACTS.LOCAL.PRIMARY.GROUP.Table;
using COUNT			= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Count;
using EVENT_STATE	= CONTACTS.GLOBAL.TOOLS.EventState;
using GLOBAL_DB		= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using LIKE			= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Like;
using LIKE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
using MESSENGER		= CONTACTS.GLOBAL.TOOLS.Messenger;
using ONE_GROUP		= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using SELECT		= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Select;
using TXT_GATHER	= CONTACTS.GLOBAL.TOOLS.TextAccumulator;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.FORMS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class FrmGroup : Form
	{
		#region 00 TODO / DECLARE / CONSTRUCT

		#region TODO LIST
		//TODO: Fix the record indexing and look again at the interaction with the database. (?)
		#endregion


		#region DECLARATIONS
		private GLOBAL_DB db_Connector = new GLOBAL_DB();
		private ONE_GROUP one_Group;
		private static ALL_GROUPS all_Groups = new ALL_GROUPS();

		private static EVENT_STATE _EventState;
		private static MESSENGER _Messenger;
		private LIKE_ROW[] matching_Groups;
		private TXT_GATHER txt_Accumulator;
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public FrmGroup()
		{
			InitializeComponent();
			_EventState = new EVENT_STATE();
			_Messenger = new MESSENGER( this.tbx_Messages );
			InitialiseForm();

			Group = all_Groups.DefaultGroup;
		}
		#endregion

		#endregion


		#region 01 INITIALISE & DISPLAY

		#region INITIALISATION/FINALISATION
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm()
		{
			SetTabIndices();
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
		//___________________________________________________________________________________________________________________________________________
		private void SetTabIndices()
		{
			this.tbx_Matches.TabIndex = 0;
			//TODO Complete the tab index list.
		}
		#endregion


		#region DISPLAY
		//___________________________________________________________________________________________________________________________________________
		private void DisplayGroup()
		{
			_EventState.DisableEvents();

			this.tbx_Matches.Clear();

			this.tbx_PkGroup.Text				= GroupPkAsText;
			this.tbx_GroupName.Text				= GroupName;
			this.cbx_GroupType.Text				= GroupType;
			this.dbx_CurrencyDate.CustomFormat	= Group.CurrencyDate.DatePickerFormat;
			this.dbx_CurrencyDate.Value			= Group.CurrencyDate.DatePickerValue;
			this.tbx_Notes.Text					= Notes;

			this.chk_IsSelected.Checked			= Selected;
			this.chk_IsDefaultGroup.Checked		= DefaultGroup;
			this.chk_IsExport.Checked			= Export;
			this.chk_IsBlocked.Checked			= Blocked;
			this.chk_IsInactive.Checked			= Inactive;
			this.chk_IsStTheresa.Checked		= StTheresa;
			this.chk_IsTrade.Checked			= Trade;
			this.chk_IsSupplier.Checked			= Supplier;
			this.chk_IsWriter.Checked			= Writer;

			_EventState.EnableEvents();
		}
		//___________________________________________________________________________________________________________________________________________
		private void DisplayMatchingGroups( LIKE_ROW[] matching_groups )
		{
			this.lbx_MatchingGroups.Items.Clear();
			this.lbx_MatchingGroups.Items.AddRange( matching_groups );
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
			set
			{
				if ( int.TryParse( value, out int result ) )
					//TODO consider moving this to the table object.
					if ( new COUNT.IsPkExtant( result ).Execute )
						GroupPk = result;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void InsertGroup()
		{
			if ( all_Groups.InsertGroup( Group ) )
			{
				Group = all_Groups.CurrentGroup;
				_Messenger.InsertSucceeded();
			}
			else
			{
				_Messenger.InsertFailed();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void UpdateGroup()
		{
			if ( all_Groups.UpdateGroup( Group ) )
				_Messenger.UpdateSucceeded();
			else
				_Messenger.UpdateFailed();
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
					_Messenger.NoItemSelected();
				}
				else
				{
					LIKE_ROW like_row = ( LIKE_ROW )( this.lbx_MatchingGroups.SelectedItem );
					_Messenger.ValidSelection( like_row.LikeValue );
					this.GroupPk = like_row.PkRow;
				}

				this.tbx_GroupName.Focus();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private DateTime CurrencyDate
		{
			//TODO: No apparent interaction with CurrencyDate.
			get { return Group.CurrencyDate.Value; }
			set
			{
				Group.NewCurrencyDate = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Selected
		{
			get { return Group.Selected.Value; }
			set
			{
				Group.NewSelected = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool DefaultGroup
		{
			get { return Group.DefaultRow.Value; }
			set
			{
				Group.NewDefaultGroup = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Export
		{
			get { return Group.Export.Value; }
			set
			{
				Group.NewExport = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Blocked
		{
			get { return Group.Blocked.Value; }
			set
			{
				Group.NewBlocked = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Inactive
		{
			get { return Group.Inactive.Value; }
			set
			{
				Group.NewInactive = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool StTheresa
		{
			get { return Group.StTheresa.Value; }
			set
			{
				Group.NewStTheresa = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Trade
		{
			get { return Group.Tradesman.Value; }
			set
			{
				Group.NewTrade = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Supplier
		{
			get { return Group.Supplier.Value; }
			set
			{
				Group.NewSupplier = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Writer
		{
			get { return Group.Writer.Value; }
			set
			{
				Group.NewWriter = value;
				DisplayGroup();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Accumulate
		{
			set { txt_Accumulator = new TXT_GATHER( value ); }
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
			if ( _EventState.IsEnabled )
				Accumulate = tbx_GroupName.Text;
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
			CurrencyDate = dbx_CurrencyDate.Value;
		}
		#endregion



		#region CHECK CHANGED
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsSelected_CheckedChanged( object sender, EventArgs e )
		{
			Selected = chk_IsSelected.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsDefaultGroup_CheckedChanged( object sender, EventArgs e )
		{
			DefaultGroup = chk_IsDefaultGroup.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsExport_CheckedChanged( object sender, EventArgs e )
		{
			Export = chk_IsExport.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsBlocked_CheckedChanged( object sender, EventArgs e )
		{
			Blocked = chk_IsBlocked.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsInactive_CheckedChanged( object sender, EventArgs e )
		{
			Inactive = chk_IsInactive.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsStTheresa_CheckedChanged( object sender, EventArgs e )
		{
			StTheresa = chk_IsStTheresa.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsTrade_CheckedChanged( object sender, EventArgs e )
		{
			Trade = chk_IsTrade.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsSupplier_CheckedChanged( object sender, EventArgs e )
		{
			Supplier = chk_IsSupplier.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsWriter_CheckedChanged( object sender, EventArgs e )
		{
			Writer = chk_IsWriter.Checked;
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


		#region 05 SQL (INSERT, UPDATE) & KEY_UP

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
