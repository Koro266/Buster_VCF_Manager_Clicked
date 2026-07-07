//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using TXT_GATHER	= CONTACTS.GLOBAL.TOOLS.TextAccumulator;
using EVENT_STATE	= CONTACTS.GLOBAL.TOOLS.EventState;
using MESSENGER		= CONTACTS.GLOBAL.TOOLS.Messenger;
using GLOBAL_PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using DATE_TIME		= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using GLOBAL_DB		= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using GLOBAL_LIKE	= CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
//LOCAL
using FAMILYS		= CONTACTS.LOCAL.PRIMARY.FAMILY.Table;
using FAMILY		= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using MATCH_FAMILYS = CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Like.MatchingFamilies;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.FORMS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class FrmFamily : Form
	{
		#region 00 TODO / DECLARE / CONSTRUCT

		#region TODO LIST
		#endregion

		#region DECLARATIONS
		private GLOBAL_DB db_Connector = new GLOBAL_DB();
		private static FAMILYS all_Familys = new FAMILYS();
		private FAMILY one_Family;
		private GLOBAL_LIKE[] matching_Familys;

		private TXT_GATHER txt_Accumulator;
		private static EVENT_STATE _EventState;
		private static MESSENGER _Messenger;

		//TODO: Consider moving these constants into Family constants file. 
		private const string no_Item_Selected = "No item selected. Move to default Family.";
		private const string is_Valid_Selection = " is a valid selection.";
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public FrmFamily()
		{
			InitializeComponent();
			_EventState = new EVENT_STATE();
			_Messenger = new MESSENGER( this.tbx_Messages );

			InitialiseForm();
		}
		//___________________________________________________________________________________________________________________________________________
		public FrmFamily( int family_pk )
		{
			InitializeComponent();

			_EventState = new EVENT_STATE();
			_Messenger = new MESSENGER( this.tbx_Messages );

			InitialiseForm( family_pk );
		}
		#endregion

		#endregion


		#region 01 INITIALISE & DISPLAY

		#region DISPLAY
		//___________________________________________________________________________________________________________________________________________
		private void DisplayFamily()
		{
			_EventState.DisableEvents();

			tbx_LeftPersonName.Text = LeftPerson.SortableName.AsIs;
			tbx_RightPersonName.Text = RightPerson.SortableName.AsIs;
			tbx_PkFamily.Text = PkFamilyAsText;
			cbx_FamilyType.Text = FamilyType;
			tbx_Notes.Text = Notes;

			//Derived names
			tbx_FamilyName.Text = FamilyName;
			tbx_SortableName.Text = SortableName;
			tbx_JointName.Text = JointName;
			tbx_NaturalName.Text = NaturalName;
			tbx_PostalName.Text = PostalName;

			chk_IsDissolved.Checked = Dissolved;
			chk_IsCorlettRd.Checked = CorlettRd;
			chk_IsStTheresa.Checked = StTheresa;
			chk_IsChristmas.Checked = Christmas;
			chk_IsDefaultFamily.Checked = DefaultFamily;

			ValuateWeddingDateboxes();

			_EventState.EnableEvents();
		}
		#endregion


		#region RE-INITIALISATION
		//___________________________________________________________________________________________________________________________________________
		private void DisplayMatchingFamilies()
		{
			this.lbx_MatchingFamilies.Items.Clear();
			this.lbx_MatchingFamilies.Items.AddRange( matching_Familys.ToArray() );
		}
		#endregion


		#region INITIALISATION
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm()
		{
			Initial_Family = all_Familys.DefaultFamily;
			CommonInitialisers();
			DisplayFamily();
		}
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm( int family_pk )
		{
			Initial_Family = all_Familys.FamilyByKey( family_pk );
			CommonInitialisers();
			DisplayFamily();
		}
		//___________________________________________________________________________________________________________________________________________
		private FAMILY Initial_Family
		{
			set { one_Family = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private void CommonInitialisers()
		{
			PutHeader();
			SetTabIndices();
			ValuateWeddingDateboxes();
		}
		//___________________________________________________________________________________________________________________________________________
		private void PutHeader()
		{
			this.Text = db_Connector.PartiallyQualifiedFileName;
		}
		//___________________________________________________________________________________________________________________________________________
		private void ValuateWeddingDateboxes()
		{
			dbx_WeddingDate.CustomFormat = Family.WeddingDate.DatePickerFormat;
			dbx_WeddingDate.Value = Family.WeddingDate.DatePickerValue;
			this.dbx_CurrencyDate.Value = Family.CurrencyDate.Value;
		}
		//___________________________________________________________________________________________________________________________________________
		private void SetTabIndices()
		{
			tbx_Matches.TabIndex			=  0;
			cbx_FamilyType.TabIndex			=  1;
			tbx_Notes.TabIndex				=  2;
			dbx_WeddingDate.TabIndex		=  3;
			btn_ClearWeddingDate.TabIndex	=  4;
			dbx_CurrencyDate.TabIndex		=  5;
			btn_CurrencyNow.TabIndex		=  6;
			chk_IsDissolved.TabIndex		=  7;
			chk_IsCorlettRd.TabIndex		=  8;
			chk_IsStTheresa.TabIndex		=  9;
			chk_IsChristmas.TabIndex		= 10;
			chk_IsDefaultFamily.TabIndex	= 11;
			btn_TriggerDerivation.TabIndex	= 12;
			tbx_Filter.TabIndex				= 13;
			btn_FirstFamily.TabIndex		= 14;
			btn_PreviousFamily.TabIndex		= 15;
			btn_NextFamily.TabIndex			= 16;
			btn_LastFamily.TabIndex			= 17;
			btn_NewFamily.TabIndex			= 18;
			btn_InsertFamily.TabIndex		= 19;
			btn_UpdateFamily.TabIndex		= 20;
			btn_ExportFamilyVcf.TabIndex	= 21;
			btn_FindFamily.TabIndex			= 22;
			lbx_MatchingFamilies.TabIndex	= 23;
			btn_CloseForm.TabIndex			= 24;
		}
		#endregion

		#endregion


		#region 02 RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		private FAMILY Family
		{
			get { return one_Family; }
			set
			{
				one_Family = value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int PkFamily
		{
			get { return Family.PkFamily.Value; }
			set { Family = all_Familys.FamilyByKey( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private string PkFamilyAsText
		{
			get { return Family.PkFamily.AsString; }
			set { PkFamily = Convert.ToInt32( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private PERSON LeftPerson
		{
			get
			{
				return Family.LeftPerson;
			}
			set
			{
				Family.NewLeftPerson = value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private PERSON RightPerson
		{
			get
			{
				return Family.RightPerson;
			}
			set
			{
				Family.NewRightPerson = value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private GLOBAL_LIKE SelectedFamily
		{
			set
			{
				GLOBAL_LIKE selected_row = ( GLOBAL_LIKE )lbx_MatchingFamilies.SelectedItem;
				if ( selected_row == null )
					return;

				PkFamily = selected_row.PkRow;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string FamilyMatch
		{
			set
			{
				matching_Familys = new MATCH_FAMILYS( value ).Execute;
				if ( matching_Familys.Count() > 0 )
					DisplayMatchingFamilies();

			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int FamilySelectedIndex
		{
			set
			{
				if ( value == GLOBAL_PRESET.NoItemSelected )
				{
					Family = all_Familys.DefaultFamily;
					AsyncMessage( no_Item_Selected );
				}
				else
				{
					GLOBAL_LIKE like_row = ( GLOBAL_LIKE )( this.lbx_MatchingFamilies.SelectedItem );
					AsyncMessage( like_row.LikeValue + is_Valid_Selection );
					this.PkFamily = like_row.PkRow;
				}

				this.tbx_LeftPersonName.Focus();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void AsyncMessage( string msg )
		{
			_Messenger.Message = msg;
			this.tbx_Matches.Focus();
		}
		//___________________________________________________________________________________________________________________________________________
		private string FamilyType
		{
			get { return Family.FamilyType.AsIs; }
			set
			{
				Family.NewFamilyType = value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string FamilyName
		{
			get { return Family.FamilyName.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string SortableName
		{
			get { return Family.SortableName.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string JointName
		{
			get { return Family.JointName.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string NaturalName
		{
			get { return Family.NaturalName.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string PostalName
		{
			get { return Family.PostalName.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string Notes
		{
			get { return Family.Notes.Value; }
			set
			{
				Family.NewNotes = value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private DateTime Wedding_DateTime
		{
			get { return Family.WeddingDate.Value; }
			set
			{
				Family.NewWeddingDate = value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private DATE_TIME Wedding_DATETIME
		{
			get { return Family.WeddingDate; }
			set
			{
				Family.NewWeddingDate = value.Value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private DateTime Currency_DateTime
		{
			get { return Family.CurrencyDate.Value; }
			set
			{
				Family.NewCurrencyDate = value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private DATE_TIME Currency_DATETIME
		{
			get { return Family.CurrencyDate; }
			set
			{
				Family.NewCurrencyDate = value.Value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Christmas
		{
			get { return Family.Christmas.Value; }
			set
			{
				Family.NewIsChristmas = value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool DefaultFamily
		{
			get { return Family.DefaultRow.Value; }
			set
			{
				Family.NewIsDefaultRow = value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Dissolved
		{
			get { return Family.Dissolved.Value; }
			set
			{
				Family.NewIsDissolved = value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool CorlettRd
		{
			get { return Family.CorlettRd.Value; }
			set
			{
				Family.NewIsCorlettRd = value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool StTheresa
		{
			get { return Family.StTheresa.Value; }
			set
			{
				Family.NewIsStTheresa = value;
				DisplayFamily();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private FAMILY InsertFamily
		{
			//TODO: update INSERT & UPDATE to match code in FrmPerson
			set { all_Familys.InsertFamily( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private FAMILY UpdateFamily
		{
			set { all_Familys.UpdateFamily( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private void Accumulator( string s )
		{
			txt_Accumulator = new TXT_GATHER( s );
		}
		#endregion


		#region 03 ENTER / CHANGE / LEAVE

		#region 05 FAMILY TYPE
		//___________________________________________________________________________________________________________________________________________
		private void cbx_FamilyType_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				FamilyType = cbx_FamilyType.Text;
		}
		#endregion


		#region 06 NOTES
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_Notes.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Accumulator( tbx_Notes.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_Leave( object sender, EventArgs e )
		{
			Notes = txt_Accumulator.AsIs;
		}
		#endregion


		#region 07 WEDDING DATE
		//___________________________________________________________________________________________________________________________________________
		private void dbx_WeddingDate_ValueChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Wedding_DateTime = dbx_WeddingDate.Value;
		}
		#endregion


		#region 08 CURRENCY DATE
		//___________________________________________________________________________________________________________________________________________
		private void dbx_CurrencyDate_ValueChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Currency_DateTime = dbx_CurrencyDate.Value;
		}
		#endregion


		#region 09 IS CHRISTMAS
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsChristmas_CheckedChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Christmas = chk_IsChristmas.Checked;
		}
		#endregion


		#region 11 IS DISSOLVED
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsDissolved_CheckedChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Dissolved = chk_IsDissolved.Checked;
		}
		#endregion


		#region 12 IS CORLETT RD
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsCorlettRd_CheckedChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				CorlettRd = chk_IsCorlettRd.Checked;
		}
		#endregion


		#region 13 IS ST THERESA
		//___________________________________________________________________________________________________________________________________________
		private void chk_IsStTheresa_CheckedChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				StTheresa = chk_IsStTheresa.Checked;
		}
		#endregion

		#endregion


		#region 04 CLICK
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingFamilies_Click( object sender, EventArgs e )
		{
			FamilySelectedIndex = lbx_MatchingFamilies.SelectedIndex;
		}
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingFamilies_DoubleClick( object sender, EventArgs e )
		{
			// TODO:Review what to do about in the context of Messenger.
			SelectedFamily = ( GLOBAL_LIKE )lbx_MatchingFamilies.SelectedItem;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_TriggerDerivation_Click( object sender, EventArgs e )
		{
			Family.SetDerivedNames();
			DisplayFamily();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_NewFamily_Click( object sender, EventArgs e )
		{
			Family = all_Familys.NewFamily;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_ExportFamilyVcf_Click( object sender, EventArgs e )
		{
			Family.ExportFamily();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_CurrencyNow_Click( object sender, EventArgs e )
		{
			Currency_DateTime = DateTime.Now;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_ClearWeddingDate_Click( object sender, EventArgs e )
		{
			dbx_WeddingDate.CustomFormat = DATE_TIME.NullDateFormat;
			Wedding_DateTime = DATE_TIME.DbNullDate;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_CloseForm_Click( object sender, EventArgs e )
		{
			this.Close();
		}
		#endregion


		#region 05 NAVIGATION ETC
		//___________________________________________________________________________________________________________________________________________
		private void btn_FirstFamily_Click( object sender, EventArgs e )
		{
			Family = all_Familys.FirstFamily;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_PreviousFamily_Click( object sender, EventArgs e )
		{
			Family = all_Familys.PreviousFamily;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_NextFamily_Click( object sender, EventArgs e )
		{
			Family = all_Familys.NextFamily;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_LastFamily_Click( object sender, EventArgs e )
		{
			Family = all_Familys.LastFamily;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Matches_TextChanged( object sender, EventArgs e )
		{
			FamilyMatch = this.tbx_Matches.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Filter_KeyUp( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Enter )
				PkFamilyAsText = tbx_Filter.Text;
		}
		#endregion


		#region 06 SQL (INSERT, UPDATE)
		//___________________________________________________________________________________________________________________________________________
		private void btn_InsertFamily_Click( object sender, EventArgs e )
		{
			InsertFamily = Family;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_UpdateFamily_Click( object sender, EventArgs e )
		{
			UpdateFamily = Family;
		}
		#endregion
	}
}
