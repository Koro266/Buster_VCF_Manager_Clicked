//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using MESSENGER		= CONTACTS.GLOBAL.TOOLS.Messenger;
using TXT_GATHER	= CONTACTS.GLOBAL.TOOLS.TextAccumulator;
using DATE_TIME		= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using EVENT_STATE	= CONTACTS.GLOBAL.TOOLS.EventState;
using GLOBAL_DB		= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using GLOBAL_PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using LIKE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
//LOCAL	
using PERSON		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using PERSONS		= CONTACTS.LOCAL.PRIMARY.PERSON.Table;
using LIKE			= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Like;
//FORMS
using FIND_PERSON	= CONTACTS.INTERFACE.DIALOGS.DlgFindPerson;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.FORMS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class FrmPerson : Form
	{
		#region 00 TODO / DECLARE / CONSTRUCT

		#region TODO LIST
		//TODO: Fix the record indexing and look again at the interaction with the database. (?)
		#endregion


		#region DECLARATIONS
		private GLOBAL_DB db_Connector = new GLOBAL_DB();
		private PERSON one_Person;
		private PERSONS all_Persons = new PERSONS();

		private static EVENT_STATE _EventState;
		private static MESSENGER _Messenger;
		private TXT_GATHER txt_Accumulator;
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public FrmPerson()
		{
			InitializeComponent();
			_EventState = new EVENT_STATE();
			_Messenger = new MESSENGER( this.tbx_Messages );
			Person = all_Persons.DefaultPerson;
			InitialiseForm();
		}
		//___________________________________________________________________________________________________________________________________________
		public FrmPerson( int pk_person )
		{
			InitializeComponent();
			_EventState = new EVENT_STATE();
			_Messenger = new MESSENGER( this.tbx_Messages );
			Person = all_Persons.PersonByKey( pk_person );
			InitialiseForm();
		}
		#endregion

		#endregion


		#region DISPLAY
		//___________________________________________________________________________________________________________________________________________
		private void DisplayPerson()
		{
			_EventState.DisableEvents();

			this.tbx_PersonId.Text			= PkPersonAsText;
			this.tbx_Gender.Text			= Gender;
			this.tbx_ProperSurname.Text		= ProperSurname;
			this.tbx_GivenName.Text			= GivenName;
			this.tbx_MiddleNames.Text		= MiddleNames;
			this.tbx_NickName.Text			= NickName;
			this.tbx_BirthName.Text			= BirthName;
			this.tbx_Prefixes.Text			= Prefix;
			this.tbx_Suffixes.Text			= Suffix;
			this.tbx_Notes.Text				= Notes;
			this.tbx_UpperSurname.Text		= UpperSurname;
			this.tbx_NaturalName.Text		= NaturalName;
			this.tbx_SortableName.Text		= SortableName;
			this.tbx_Initials.Text			= Initials;

			ValuateBirthdayDatebox();
			ValuateDeathDatebox();
			ValuateWeddingDatebox();
			ValuateCurrencyDatebox();

			this.chk_Selected.Checked		= Selected;
			this.chk_Enlightened.Checked	= Enlightened;
			this.chk_HolySomething.Checked	= HolySomething;
			this.chk_NewLeftPerson.Checked	= NewLeftPerson;
			this.chk_NoRightPerson.Checked	= NoRightPerson;
			this.chk_DefaultRow.Checked		= DefaultRow;
			this.chk_Export.Checked			= Export;
			this.chk_TimeTalent.Checked		= TimeTalent;
			this.chk_Minister.Checked		= Minister;
			this.chk_Sacristan.Checked		= Sacristan;
			this.chk_Vigil.Checked			= Vigil;
			this.chk_SundayMass.Checked		= Mass;

			this.tbx_EhsOrder.Text			= EhsOrderAsText;

			_EventState.EnableEvents();
		}
		#endregion


		#region DATES / MATCHING PERSONS
		//___________________________________________________________________________________________________________________________________________
		private void ValuateBirthdayDatebox()
		{
			dbx_Birthday.CustomFormat = Person.BirthDate.DatePickerFormat;
			dbx_Birthday.Value = Person.BirthDate.DatePickerValue;
		}
		//___________________________________________________________________________________________________________________________________________
		private void ValuateWeddingDatebox()
		{
			dbx_WeddingDate.CustomFormat = Person.WeddingDate.DatePickerFormat;
			dbx_WeddingDate.Value = Person.WeddingDate.DatePickerValue;
		}
		//___________________________________________________________________________________________________________________________________________
		private void ValuateDeathDatebox()
		{
			dbx_DeathDate.CustomFormat = Person.DeathDate.DatePickerFormat;
			dbx_DeathDate.Value = Person.DeathDate.DatePickerValue;
		}
		//___________________________________________________________________________________________________________________________________________
		private void ValuateCurrencyDatebox()
		{
			this.dbx_CurrencyDate.Value = Person.CurrencyDate.Value;
		}
		//___________________________________________________________________________________________________________________________________________
		private void DisplayMatchingPersons( LIKE_ROW[] matching_persons )
		{
			this.lbx_MatchingPersons.Items.Clear();
			this.lbx_MatchingPersons.Items.AddRange( matching_persons );
		}
		#endregion


		#region INITIALISATION
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm()
		{
			this.Text = db_Connector.PartiallyQualifiedFileName;
			SetTabIndices();
			tbx_Matches.Focus();
		}
		//___________________________________________________________________________________________________________________________________________
		private void SetTabIndices()
		{
			tbx_Matches.TabIndex				=  0;
			tbx_ProperSurname.TabIndex			=  1;
			btn_ElaborateNames.TabIndex			=  2;
			tbx_GivenName.TabIndex				=  3;
			tbx_Gender.TabIndex					=  4;
			tbx_MiddleNames.TabIndex			=  5;
			tbx_NickName.TabIndex				=  6;
			tbx_BirthName.TabIndex				=  7;
			tbx_Prefixes.TabIndex				=  8;
			tbx_Suffixes.TabIndex				=  9;
			dbx_Birthday.TabIndex				= 10;
			btn_ClearBirthDate.TabIndex			= 11;
			dbx_DeathDate.TabIndex				= 12;
			btn_ClearDeathDate.TabIndex			= 13;
			dbx_WeddingDate.TabIndex			= 14;
			btn_ClearWeddingDate.TabIndex		= 15;
			dbx_CurrencyDate.TabIndex			= 16;
			btn_CurrencyNow.TabIndex			= 17;
			tbx_Notes.TabIndex					= 18;
			chk_Selected.TabIndex				= 19;
			chk_Enlightened.TabIndex			= 20;
			chk_HolySomething.TabIndex			= 21;
			chk_NewLeftPerson.TabIndex			= 22;
			chk_NoRightPerson.TabIndex			= 23;
			chk_SundayMass.TabIndex				= 24;
			chk_DefaultRow.TabIndex				= 25;
			chk_Export.TabIndex					= 26;
			chk_TimeTalent.TabIndex				= 27;
			chk_Minister.TabIndex				= 28;
			chk_Sacristan.TabIndex				= 29;
			chk_Vigil.TabIndex					= 30;
			chk_SundayMass.TabIndex				= 31;
			tbx_Filter.TabIndex					= 32;
			btn_FirstPerson.TabIndex			= 33;
			btn_PreviousPerson.TabIndex			= 34;
			btn_NextPerson.TabIndex				= 35;
			btn_LastPerson.TabIndex				= 36;
			btn_NewPerson.TabIndex				= 37;
			btn_InsertPerson.TabIndex			= 38;
			btn_UpdatePerson.TabIndex			= 39;
			btn_ExportPersonVcf.TabIndex		= 40;
			btn_FindPerson.TabIndex				= 41;
			btn_Close.TabIndex					= 42;
		}
		#endregion


		#region RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		private PERSON Person
		{
			get { return one_Person; }
			set
			{
				one_Person = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int PkPerson
		{
			get { return Person.PkPerson.Value; }
			set { Person = all_Persons.PersonByKey( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private string PkPersonAsText
		{
			get { return Person.PkPerson.AsString; }
			set { PkPerson = Convert.ToInt32( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private string SortableName
		{
			get { return Person.SortableName.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string NaturalName
		{
			get { return Person.NaturalName.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string UpperSurname
		{
			get { return Person.UpperSurname.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string Initials
		{
			get { return Person.Initials.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private void ElaborateDerivedNames()
		{
			Person.ElaborateDerivedNames();
			DisplayPerson();
		}
		//___________________________________________________________________________________________________________________________________________
		private string ProperSurname
		{
			get { return Person.ProperSurname.TextboxValue; }
			set
			{
				Person.NewProperSurname = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string GivenName
		{
			get { return Person.GivenName.TextboxValue; }
			set
			{
				Person.NewGivenName = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string MiddleNames
		{
			get { return Person.MiddleNames.TextboxValue; }
			set
			{
				Person.NewMiddleNames = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string NickName
		{
			get { return Person.NickName.TextboxValue; }
			set
			{
				Person.NewNickName = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string BirthName
		{
			get { return Person.BirthName.TextboxValue; }
			set
			{
				Person.NewBirthName = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Prefix
		{
			get { return Person.Prefix.TextboxValue; }
			set
			{
				Person.NewPrefix = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Suffix
		{
			get { return Person.Suffix.TextboxValue; }
			set
			{
				Person.NewSuffix = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Gender
		{
			get { return Person.Gender.TextboxValue; }
			set
			{
				Person.NewGender = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Notes
		{
			get { return Person.Notes.TextboxValue; }
			set
			{
				Person.NewNotes = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private DateTime BirthDate
		{
			get { return Person.BirthDate.Value; }
			set
			{
				Person.NewBirthDate = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private DateTime DeathDate
		{
			get { return Person.DeathDate.Value; }
			set
			{
				Person.NewDeathDate = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private DateTime WeddingDate
		{
			get { return Person.WeddingDate.Value; }
			set
			{
				Person.NewWeddingDate = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private DateTime CurrencyDate
		{
			get { return Person.CurrencyDate.Value; }
			set
			{
				Person.NewCurrencyDate = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int EhsOrder
		{
			get { return Person.EhsOrder.Value; }
			set
			{
				Person.NewEHSOrder = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string EhsOrderAsText
		{
			get { return Person.EhsOrder.TextboxValue; }
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Selected
		{
			get { return Person.Selected.Value; }
			set
			{
				Person.NewSelected = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Enlightened
		{
			get { return Person.Enlightened.Value; }
			set
			{
				Person.NewEnlightened = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool HolySomething
		{
			get { return Person.HolySomething.Value; }
			set
			{
				Person.NewHolySomething = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool NewLeftPerson
		{
			get { return Person.NewLeftPerson.Value; }
			set
			{
				Person.New_NewLeftPerson = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool NoRightPerson
		{
			get { return Person.NoRightPerson.Value; }
			set
			{
				Person.NewNoRightPerson = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool DefaultRow
		{
			get { return Person.DefaultRow.Value; }
			set
			{
				Person.NewDefaultRow = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Export
		{
			get { return Person.Export.Value; }
			set
			{
				Person.NewExport = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool TimeTalent
		{
			get { return Person.TimeTalent.Value; }
			set
			{
				Person.NewTimeTalent = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Minister
		{
			get { return Person.Minister.Value; }
			set
			{
				Person.NewMinister = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Sacristan
		{
			get { return Person.Sacristan.Value; }
			set
			{
				Person.NewSacristan = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Vigil
		{
			get { return Person.Vigil.Value; }
			set
			{
				Person.NewVigil = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool Mass
		{
			get { return Person.Mass.Value; }
			set
			{
				Person.NewMass = value;
				DisplayPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int PersonSelectedIndex
		{
			set
			{
				if ( value == GLOBAL_PRESET.NoItemSelected )
				{
					Person = all_Persons.DefaultPerson;
					_Messenger.NoItemSelected();
				}
				else
				{
					LIKE_ROW like_row = ( LIKE_ROW )( this.lbx_MatchingPersons.SelectedItem );
					_Messenger.ValidSelection( like_row.LikeValue );
					this.PkPerson = like_row.PkRow;
				}

				this.tbx_ProperSurname.Focus();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void InsertPerson()
		{
			if (all_Persons.InsertPerson( Person ) )
			{
				Person = all_Persons.CurrentPerson;
				_Messenger.InsertSucceeded();
			}
			else
			{
				_Messenger.InsertFailed();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void UpdatePerson()
		{
			if ( all_Persons.UpdatePerson( Person ) )
				_Messenger.UpdateSucceeded();
			else
				_Messenger.UpdateFailed();
		}
		//___________________________________________________________________________________________________________________________________________
		private void FindPerson()
		{
			using ( FIND_PERSON find_person = new FIND_PERSON() )
			{
				find_person.ShowDialog();
				if ( find_person.DialogResult == DialogResult.OK )
					Person = find_person.SelectedPerson;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private TXT_GATHER NewAccumulator( string s )
		{
			return new TXT_GATHER( s );
		}
		//___________________________________________________________________________________________________________________________________________
		private string Accumulate
		{
			set { txt_Accumulator = new TXT_GATHER( value ); }
		}
		#endregion


		#region ENTER / CHANGE / LEAVE

		#region 03 PRE-FIND
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Matches_Leave( object sender, EventArgs e )
		{
			_EventState.DisableEvents();
			tbx_Matches.Clear();
			_EventState.EnableEvents();
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Matches_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				DisplayMatchingPersons( new LIKE.ProperSurname( tbx_Matches.Text ).Execute );
		}
		#endregion


		#region 04 PROPER SURNAME
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ProperSurname_Enter( object sender, EventArgs e )
		{
			txt_Accumulator = NewAccumulator( tbx_ProperSurname.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ProperSurname_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Accumulate = tbx_ProperSurname.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ProperSurname_Leave( object sender, EventArgs e )
		{
			ProperSurname = txt_Accumulator.AsProper;
		}
		#endregion


		#region 05 GIVEN NAME
		//___________________________________________________________________________________________________________________________________________
		private void tbx_GivenName_Enter( object sender, EventArgs e )
		{
			txt_Accumulator = NewAccumulator( tbx_GivenName.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_GivenName_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Accumulate = tbx_GivenName.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_GivenName_Leave( object sender, EventArgs e )
		{
			GivenName = txt_Accumulator.AsProper;
		}
		#endregion


		#region 06 MIDDLE NAMES
		//___________________________________________________________________________________________________________________________________________
		private void tbx_MiddleNames_Enter( object sender, EventArgs e )
		{
			txt_Accumulator = NewAccumulator( tbx_MiddleNames.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_MiddleNames_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Accumulate = tbx_MiddleNames.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_MiddleNames_Leave( object sender, EventArgs e )
		{
			MiddleNames = txt_Accumulator.AsProper;
		}
		#endregion


		#region 07 NICK NAME
		//___________________________________________________________________________________________________________________________________________
		private void tbx_NickName_Enter( object sender, EventArgs e )
		{
			txt_Accumulator = NewAccumulator( tbx_NickName.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_NickName_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Accumulate = tbx_NickName.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_NickName_Leave( object sender, EventArgs e )
		{
			NickName = txt_Accumulator.AsProper;
		}
		#endregion


		#region 08 BIRTH NAME
		//___________________________________________________________________________________________________________________________________________
		private void tbx_BirthName_Enter( object sender, EventArgs e )
		{
			txt_Accumulator = NewAccumulator( tbx_BirthName.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_BirthName_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Accumulate = tbx_BirthName.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_BirthName_Leave( object sender, EventArgs e )
		{
			BirthName = txt_Accumulator.AsProper;
		}
		#endregion


		#region 09 PREFIX
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Prefixes_Enter( object sender, EventArgs e )
		{
			txt_Accumulator = NewAccumulator( tbx_Prefixes.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Prefixes_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Accumulate = tbx_Prefixes.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Prefixes_Leave( object sender, EventArgs e )
		{
			Prefix = txt_Accumulator.AsProper;
		}
		#endregion


		#region 10 SUFFIX
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Suffixes_Enter( object sender, EventArgs e )
		{
			txt_Accumulator = NewAccumulator( tbx_Suffixes.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Suffixes_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Accumulate = tbx_Suffixes.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Suffixes_Leave( object sender, EventArgs e )
		{
			Suffix = txt_Accumulator.AsUpper;
		}
		#endregion


		#region 12 GENDER
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Gender_Enter( object sender, EventArgs e )
		{
			txt_Accumulator = NewAccumulator( tbx_Gender.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Gender_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Accumulate = tbx_Gender.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Gender_Leave( object sender, EventArgs e )
		{
			Gender = txt_Accumulator.AsUpperInitial;
		}
		#endregion


		#region 13 NOTES
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_Enter( object sender, EventArgs e )
		{
			txt_Accumulator = NewAccumulator( tbx_Notes.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_TextChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				Accumulate = tbx_Notes.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_Leave( object sender, EventArgs e )
		{
			Notes = txt_Accumulator.AsIs;
		}
		#endregion


		#region 14 BIRTHDATE
		//___________________________________________________________________________________________________________________________________________
		private void dbx_BirthDate_ValueChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				BirthDate = dbx_Birthday.Value;
		}
		#endregion


		#region 15 DEATHDATE
		//___________________________________________________________________________________________________________________________________________
		private void dbx_DeathDate_ValueChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				DeathDate = dbx_DeathDate.Value;
		}
		#endregion


		#region 16 WEDDING DATE
		//___________________________________________________________________________________________________________________________________________
		private void dbx_WeddingDate_ValueChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				WeddingDate = dbx_WeddingDate.Value;
		}
		#endregion


		#region 17 CURRENCY DATE
		//___________________________________________________________________________________________________________________________________________
		private void dbx_CurrencyDate_ValueChanged( object sender, EventArgs e )
		{
			if ( _EventState.IsEnabled )
				CurrencyDate = dbx_CurrencyDate.Value;
		}
		#endregion

		#endregion


		#region BUTTON CLICKS
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingPersons_Click( object sender, EventArgs e )
		{
			PersonSelectedIndex = lbx_MatchingPersons.SelectedIndex;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_ClearBirthDate_Click( object sender, EventArgs e )
		{
			this.dbx_Birthday.CustomFormat = DATE_TIME.NullDateFormat;
			BirthDate = DATE_TIME.DbNullDate;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_ClearDeathDate_Click( object sender, EventArgs e )
		{
			this.dbx_DeathDate.CustomFormat = DATE_TIME.NullDateFormat;
			DeathDate = DATE_TIME.DbNullDate;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_ClearWeddingDate_Click( object sender, EventArgs e )
		{
			this.dbx_WeddingDate.CustomFormat = DATE_TIME.NullDateFormat;
			WeddingDate = DATE_TIME.DbNullDate;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_ElaborateNames_Click( object sender, EventArgs e )
		{
			ElaborateDerivedNames();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_CurrencyNow_Click( object sender, EventArgs e )
		{
			CurrencyDate = DateTime.Now;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_NewPerson_Click( object sender, EventArgs e )
		{
			Person = all_Persons.NewPerson;
			this.tbx_ProperSurname.Select();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_InsertPerson_Click( object sender, EventArgs e )
		{
			InsertPerson();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_UpdatePerson_Click( object sender, EventArgs e )
		{
			UpdatePerson();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_ExportVcfPerson_Click( object sender, EventArgs e )
		{
			Person.ExportPerson();
			_Messenger.PersonExported( Person.SortableName.Value );
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Close_Click( object sender, EventArgs e )
		{
			this.Close();
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_Selected_Click( object sender, EventArgs e )
		{
			Selected = chk_Selected.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_Enlightened_Click( object sender, EventArgs e )
		{
			Enlightened = chk_Enlightened.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_HolySomething_Click( object sender, EventArgs e )
		{
			HolySomething = chk_HolySomething.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_NewLeftPerson_Click( object sender, EventArgs e )
		{
			NewLeftPerson = chk_NewLeftPerson.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_NoRightPerson_Click( object sender, EventArgs e )
		{
			NoRightPerson = chk_NoRightPerson.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_DefaultRow_Click( object sender, EventArgs e )
		{
			DefaultRow = chk_DefaultRow.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_Export_Click( object sender, EventArgs e )
		{
			Export = chk_Export.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_TimeTalent_Click( object sender, EventArgs e )
		{
			TimeTalent = chk_TimeTalent.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_Minister_Click( object sender, EventArgs e )
		{
			Minister = chk_Minister.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_Sacristan_Click( object sender, EventArgs e )
		{
			Sacristan = chk_Sacristan.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_Vigil_Click( object sender, EventArgs e )
		{
			Vigil = chk_Vigil.Checked;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_SundayMass_Click( object sender, EventArgs e )
		{
			Mass = chk_SundayMass.Checked;
		}
		#endregion


		#region NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		private void btn_FindPerson_Click( object sender, EventArgs e )
		{
			FindPerson();
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PkFilter_KeyUp( object sender, KeyEventArgs e )
		{
			if ( _EventState.IsEnabled )
				if ( e.KeyCode == Keys.Enter )
					PkPersonAsText = this.tbx_Filter.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_FirstPerson_Click( object sender, EventArgs e )
		{
			Person = all_Persons.FirstPerson;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_PreviousPerson_Click( object sender, EventArgs e )
		{
			Person = all_Persons.PreviousPerson;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_NextPerson_Click( object sender, EventArgs e )
		{
			Person = all_Persons.NextPerson;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_LastPerson_Click( object sender, EventArgs e )
		{
			Person = all_Persons.LastPerson;
		}
		#endregion
	}
}
