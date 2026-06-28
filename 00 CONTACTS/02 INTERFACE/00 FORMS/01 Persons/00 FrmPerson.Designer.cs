namespace CONTACTS.INTERFACE.FORMS
{
	public partial class FrmPerson
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components == null ))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lbl_PersonPK = new Label();
			lbl_Gender = new Label();
			lbl_ProperSurname = new Label();
			lbl_GivenName = new Label();
			lbl_MiddleNames = new Label();
			lbl_Nickname = new Label();
			lbl_BirthName = new Label();
			lbl_Prefixes = new Label();
			lbl_Suffixes = new Label();
			lbl_BirthDate = new Label();
			lbl_DeathDate = new Label();
			lbl_WeddingDate = new Label();
			lbl_FindPK = new Label();
			lbl_SURNAME = new Label();
			lbl_NaturalName = new Label();
			lbl_SortableName = new Label();
			lbl_CurrencyDate = new Label();
			btn_InsertPerson = new Button();
			btn_UpdatePerson = new Button();
			tbx_PersonId = new TextBox();
			tbx_Gender = new TextBox();
			tbx_ProperSurname = new TextBox();
			tbx_GivenName = new TextBox();
			tbx_MiddleNames = new TextBox();
			tbx_NickName = new TextBox();
			tbx_BirthName = new TextBox();
			tbx_Prefixes = new TextBox();
			tbx_Suffixes = new TextBox();
			tbx_UpperSurname = new TextBox();
			tbx_NaturalName = new TextBox();
			tbx_SortableName = new TextBox();
			btn_CurrencyNow = new Button();
			tbx_Filter = new TextBox();
			dbx_Birthday = new DateTimePicker();
			dbx_WeddingDate = new DateTimePicker();
			dbx_DeathDate = new DateTimePicker();
			dbx_CurrencyDate = new DateTimePicker();
			lbl_LastRecord = new Label();
			lbl_FirstRecord = new Label();
			btn_FindPerson = new Button();
			btn_FirstPerson = new Button();
			btn_PreviousPerson = new Button();
			btn_Close = new Button();
			btn_LastPerson = new Button();
			btn_NextPerson = new Button();
			tbx_Initials = new TextBox();
			lbl_Initials = new Label();
			lbx_MatchingPersons = new ListBox();
			tbx_Notes = new TextBox();
			lbl_Notes = new Label();
			grp_PersonData = new GroupBox();
			chk_SundayMass = new CheckBox();
			chk_Vigil = new CheckBox();
			chk_Sacristan = new CheckBox();
			chk_Minister = new CheckBox();
			chk_TimeTalent = new CheckBox();
			chk_Export = new CheckBox();
			chk_DefaultRow = new CheckBox();
			chk_NoRightPerson = new CheckBox();
			chk_NewLeftPerson = new CheckBox();
			chk_HolySomething = new CheckBox();
			chk_Enlightened = new CheckBox();
			chk_Selected = new CheckBox();
			tbx_Messages = new TextBox();
			label3 = new Label();
			tbx_Matches = new TextBox();
			label1 = new Label();
			btn_NewPerson = new Button();
			btn_ExportPersonVcf = new Button();
			btn_ElaborateNames = new Button();
			btn_ClearWeddingDate = new Button();
			btn_ClearDeathDate = new Button();
			btn_ClearBirthDate = new Button();
			grp_PersonData.SuspendLayout();
			SuspendLayout();
			// 
			// lbl_PersonPK
			// 
			lbl_PersonPK.AutoSize = true;
			lbl_PersonPK.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_PersonPK.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_PersonPK.Location = new Point( 896, 30 );
			lbl_PersonPK.Name = "lbl_PersonPK";
			lbl_PersonPK.Size = new Size( 30, 21 );
			lbl_PersonPK.TabIndex = 0;
			lbl_PersonPK.Text = "PK";
			lbl_PersonPK.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_Gender
			// 
			lbl_Gender.AutoSize = true;
			lbl_Gender.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Gender.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Gender.Location = new Point( 74, 275 );
			lbl_Gender.Name = "lbl_Gender";
			lbl_Gender.Size = new Size( 58, 19 );
			lbl_Gender.TabIndex = 101;
			lbl_Gender.Text = "Gender";
			lbl_Gender.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_ProperSurname
			// 
			lbl_ProperSurname.AutoSize = true;
			lbl_ProperSurname.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_ProperSurname.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_ProperSurname.Location = new Point( 13, 59 );
			lbl_ProperSurname.Name = "lbl_ProperSurname";
			lbl_ProperSurname.Size = new Size( 119, 19 );
			lbl_ProperSurname.TabIndex = 102;
			lbl_ProperSurname.Text = "Proper Surname";
			lbl_ProperSurname.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_GivenName
			// 
			lbl_GivenName.AutoSize = true;
			lbl_GivenName.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_GivenName.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_GivenName.Location = new Point( 41, 91 );
			lbl_GivenName.Name = "lbl_GivenName";
			lbl_GivenName.Size = new Size( 91, 19 );
			lbl_GivenName.TabIndex = 5;
			lbl_GivenName.Text = "Given Name";
			lbl_GivenName.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_MiddleNames
			// 
			lbl_MiddleNames.AutoSize = true;
			lbl_MiddleNames.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_MiddleNames.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_MiddleNames.Location = new Point( 16, 122 );
			lbl_MiddleNames.Name = "lbl_MiddleNames";
			lbl_MiddleNames.Size = new Size( 116, 19 );
			lbl_MiddleNames.TabIndex = 4;
			lbl_MiddleNames.Text = "Middle Name(s)";
			lbl_MiddleNames.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_Nickname
			// 
			lbl_Nickname.AutoSize = true;
			lbl_Nickname.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Nickname.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Nickname.Location = new Point( 56, 153 );
			lbl_Nickname.Name = "lbl_Nickname";
			lbl_Nickname.Size = new Size( 76, 19 );
			lbl_Nickname.TabIndex = 5;
			lbl_Nickname.Text = "Nickname";
			lbl_Nickname.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_BirthName
			// 
			lbl_BirthName.AutoSize = true;
			lbl_BirthName.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_BirthName.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_BirthName.Location = new Point( 47, 183 );
			lbl_BirthName.Name = "lbl_BirthName";
			lbl_BirthName.Size = new Size( 85, 19 );
			lbl_BirthName.TabIndex = 6;
			lbl_BirthName.Text = "Birth Name";
			lbl_BirthName.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_Prefixes
			// 
			lbl_Prefixes.AutoSize = true;
			lbl_Prefixes.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Prefixes.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Prefixes.Location = new Point( 69, 215 );
			lbl_Prefixes.Name = "lbl_Prefixes";
			lbl_Prefixes.Size = new Size( 63, 19 );
			lbl_Prefixes.TabIndex = 7;
			lbl_Prefixes.Text = "Prefixes";
			lbl_Prefixes.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_Suffixes
			// 
			lbl_Suffixes.AutoSize = true;
			lbl_Suffixes.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Suffixes.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Suffixes.Location = new Point( 71, 247 );
			lbl_Suffixes.Name = "lbl_Suffixes";
			lbl_Suffixes.Size = new Size( 61, 19 );
			lbl_Suffixes.TabIndex = 8;
			lbl_Suffixes.Text = "Suffixes";
			lbl_Suffixes.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_BirthDate
			// 
			lbl_BirthDate.AutoSize = true;
			lbl_BirthDate.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_BirthDate.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_BirthDate.Location = new Point( 56, 309 );
			lbl_BirthDate.Name = "lbl_BirthDate";
			lbl_BirthDate.Size = new Size( 76, 19 );
			lbl_BirthDate.TabIndex = 9;
			lbl_BirthDate.Text = "Birth Date";
			lbl_BirthDate.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_DeathDate
			// 
			lbl_DeathDate.AutoSize = true;
			lbl_DeathDate.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_DeathDate.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_DeathDate.Location = new Point( 49, 337 );
			lbl_DeathDate.Name = "lbl_DeathDate";
			lbl_DeathDate.Size = new Size( 83, 19 );
			lbl_DeathDate.TabIndex = 10;
			lbl_DeathDate.Text = "Death Date";
			lbl_DeathDate.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_WeddingDate
			// 
			lbl_WeddingDate.AutoSize = true;
			lbl_WeddingDate.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_WeddingDate.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_WeddingDate.Location = new Point( 27, 365 );
			lbl_WeddingDate.Name = "lbl_WeddingDate";
			lbl_WeddingDate.Size = new Size( 105, 19 );
			lbl_WeddingDate.TabIndex = 11;
			lbl_WeddingDate.Text = "Wedding Date";
			lbl_WeddingDate.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_FindPK
			// 
			lbl_FindPK.AutoSize = true;
			lbl_FindPK.Font = new Font( "Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_FindPK.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_FindPK.Location = new Point( 876, 65 );
			lbl_FindPK.Name = "lbl_FindPK";
			lbl_FindPK.Size = new Size( 47, 13 );
			lbl_FindPK.TabIndex = 47;
			lbl_FindPK.Text = "Find PK";
			// 
			// lbl_SURNAME
			// 
			lbl_SURNAME.AutoSize = true;
			lbl_SURNAME.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_SURNAME.ForeColor = Color.Blue;
			lbl_SURNAME.Location = new Point( 55, 519 );
			lbl_SURNAME.Name = "lbl_SURNAME";
			lbl_SURNAME.Size = new Size( 77, 19 );
			lbl_SURNAME.TabIndex = 13;
			lbl_SURNAME.Text = "SURNAME";
			lbl_SURNAME.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_NaturalName
			// 
			lbl_NaturalName.AutoSize = true;
			lbl_NaturalName.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_NaturalName.ForeColor = Color.Blue;
			lbl_NaturalName.Location = new Point( 29, 550 );
			lbl_NaturalName.Name = "lbl_NaturalName";
			lbl_NaturalName.Size = new Size( 103, 19 );
			lbl_NaturalName.TabIndex = 14;
			lbl_NaturalName.Text = "Natural Name";
			lbl_NaturalName.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_SortableName
			// 
			lbl_SortableName.AutoSize = true;
			lbl_SortableName.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_SortableName.ForeColor = Color.Blue;
			lbl_SortableName.Location = new Point( 22, 580 );
			lbl_SortableName.Name = "lbl_SortableName";
			lbl_SortableName.Size = new Size( 110, 19 );
			lbl_SortableName.TabIndex = 15;
			lbl_SortableName.Text = "Sortable Name";
			lbl_SortableName.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_CurrencyDate
			// 
			lbl_CurrencyDate.AutoSize = true;
			lbl_CurrencyDate.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_CurrencyDate.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_CurrencyDate.Location = new Point( 28, 391 );
			lbl_CurrencyDate.Name = "lbl_CurrencyDate";
			lbl_CurrencyDate.Size = new Size( 104, 19 );
			lbl_CurrencyDate.TabIndex = 16;
			lbl_CurrencyDate.Text = "Currency Date";
			lbl_CurrencyDate.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btn_InsertPerson
			// 
			btn_InsertPerson.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_InsertPerson.ForeColor = Color.Maroon;
			btn_InsertPerson.Location = new Point( 878, 183 );
			btn_InsertPerson.Name = "btn_InsertPerson";
			btn_InsertPerson.Size = new Size( 133, 32 );
			btn_InsertPerson.TabIndex = 5;
			btn_InsertPerson.Text = "Insert Person";
			btn_InsertPerson.UseVisualStyleBackColor = true;
			btn_InsertPerson.UseWaitCursor = true;
			btn_InsertPerson.Click +=  btn_InsertPerson_Click ;
			// 
			// btn_UpdatePerson
			// 
			btn_UpdatePerson.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_UpdatePerson.ForeColor = Color.Maroon;
			btn_UpdatePerson.Location = new Point( 878, 219 );
			btn_UpdatePerson.Name = "btn_UpdatePerson";
			btn_UpdatePerson.Size = new Size( 133, 32 );
			btn_UpdatePerson.TabIndex = 6;
			btn_UpdatePerson.Text = "Update Person";
			btn_UpdatePerson.UseVisualStyleBackColor = true;
			btn_UpdatePerson.Click +=  btn_UpdatePerson_Click ;
			// 
			// tbx_PersonId
			// 
			tbx_PersonId.BackColor = Color.FromArgb(     192,     192,     255 );
			tbx_PersonId.Enabled = false;
			tbx_PersonId.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_PersonId.Location = new Point( 929, 28 );
			tbx_PersonId.Name = "tbx_PersonId";
			tbx_PersonId.PlaceholderText = "PK";
			tbx_PersonId.ReadOnly = true;
			tbx_PersonId.Size = new Size( 82, 25 );
			tbx_PersonId.TabIndex = 0;
			tbx_PersonId.TabStop = false;
			// 
			// tbx_Gender
			// 
			tbx_Gender.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Gender.Location = new Point( 142, 272 );
			tbx_Gender.MaxLength = 1;
			tbx_Gender.Name = "tbx_Gender";
			tbx_Gender.Size = new Size( 91, 25 );
			tbx_Gender.TabIndex = 1;
			tbx_Gender.TextChanged +=  tbx_Gender_TextChanged ;
			tbx_Gender.Enter +=  tbx_Gender_Enter ;
			tbx_Gender.Leave +=  tbx_Gender_Leave ;
			// 
			// tbx_ProperSurname
			// 
			tbx_ProperSurname.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_ProperSurname.Location = new Point( 142, 55 );
			tbx_ProperSurname.Name = "tbx_ProperSurname";
			tbx_ProperSurname.Size = new Size( 233, 25 );
			tbx_ProperSurname.TabIndex = 2;
			tbx_ProperSurname.TextChanged +=  tbx_ProperSurname_TextChanged ;
			tbx_ProperSurname.Enter +=  tbx_ProperSurname_Enter ;
			tbx_ProperSurname.Leave +=  tbx_ProperSurname_Leave ;
			// 
			// tbx_GivenName
			// 
			tbx_GivenName.BackColor = Color.White;
			tbx_GivenName.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_GivenName.Location = new Point( 142, 86 );
			tbx_GivenName.Name = "tbx_GivenName";
			tbx_GivenName.Size = new Size( 233, 25 );
			tbx_GivenName.TabIndex = 3;
			tbx_GivenName.TextChanged +=  tbx_GivenName_TextChanged ;
			tbx_GivenName.Enter +=  tbx_GivenName_Enter ;
			tbx_GivenName.Leave +=  tbx_GivenName_Leave ;
			// 
			// tbx_MiddleNames
			// 
			tbx_MiddleNames.BackColor = Color.White;
			tbx_MiddleNames.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_MiddleNames.Location = new Point( 142, 117 );
			tbx_MiddleNames.Name = "tbx_MiddleNames";
			tbx_MiddleNames.Size = new Size( 233, 25 );
			tbx_MiddleNames.TabIndex = 3;
			tbx_MiddleNames.TextChanged +=  tbx_MiddleNames_TextChanged ;
			tbx_MiddleNames.Enter +=  tbx_MiddleNames_Enter ;
			tbx_MiddleNames.Leave +=  tbx_MiddleNames_Leave ;
			// 
			// tbx_NickName
			// 
			tbx_NickName.BackColor = Color.White;
			tbx_NickName.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_NickName.Location = new Point( 142, 148 );
			tbx_NickName.Name = "tbx_NickName";
			tbx_NickName.Size = new Size( 233, 25 );
			tbx_NickName.TabIndex = 4;
			tbx_NickName.TextChanged +=  tbx_NickName_TextChanged ;
			tbx_NickName.Enter +=  tbx_NickName_Enter ;
			tbx_NickName.Leave +=  tbx_NickName_Leave ;
			// 
			// tbx_BirthName
			// 
			tbx_BirthName.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_BirthName.Location = new Point( 142, 179 );
			tbx_BirthName.Name = "tbx_BirthName";
			tbx_BirthName.Size = new Size( 233, 25 );
			tbx_BirthName.TabIndex = 5;
			tbx_BirthName.TextChanged +=  tbx_BirthName_TextChanged ;
			tbx_BirthName.Enter +=  tbx_BirthName_Enter ;
			tbx_BirthName.Leave +=  tbx_BirthName_Leave ;
			// 
			// tbx_Prefixes
			// 
			tbx_Prefixes.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Prefixes.Location = new Point( 142, 210 );
			tbx_Prefixes.Name = "tbx_Prefixes";
			tbx_Prefixes.Size = new Size( 233, 25 );
			tbx_Prefixes.TabIndex = 6;
			tbx_Prefixes.TextChanged +=  tbx_Prefixes_TextChanged ;
			tbx_Prefixes.Enter +=  tbx_Prefixes_Enter ;
			tbx_Prefixes.Leave +=  tbx_Prefixes_Leave ;
			// 
			// tbx_Suffixes
			// 
			tbx_Suffixes.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Suffixes.Location = new Point( 142, 241 );
			tbx_Suffixes.Name = "tbx_Suffixes";
			tbx_Suffixes.Size = new Size( 233, 25 );
			tbx_Suffixes.TabIndex = 7;
			tbx_Suffixes.TextChanged +=  tbx_Suffixes_TextChanged ;
			tbx_Suffixes.Enter +=  tbx_Suffixes_Enter ;
			tbx_Suffixes.Leave +=  tbx_Suffixes_Leave ;
			// 
			// tbx_UpperSurname
			// 
			tbx_UpperSurname.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_UpperSurname.Location = new Point( 142, 515 );
			tbx_UpperSurname.Name = "tbx_UpperSurname";
			tbx_UpperSurname.Size = new Size( 416, 25 );
			tbx_UpperSurname.TabIndex = 14;
			tbx_UpperSurname.TabStop = false;
			// 
			// tbx_NaturalName
			// 
			tbx_NaturalName.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_NaturalName.Location = new Point( 142, 546 );
			tbx_NaturalName.Name = "tbx_NaturalName";
			tbx_NaturalName.Size = new Size( 416, 25 );
			tbx_NaturalName.TabIndex = 15;
			tbx_NaturalName.TabStop = false;
			// 
			// tbx_SortableName
			// 
			tbx_SortableName.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_SortableName.Location = new Point( 142, 577 );
			tbx_SortableName.Name = "tbx_SortableName";
			tbx_SortableName.Size = new Size( 416, 25 );
			tbx_SortableName.TabIndex = 16;
			tbx_SortableName.TabStop = false;
			// 
			// btn_CurrencyNow
			// 
			btn_CurrencyNow.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_CurrencyNow.ForeColor = Color.Maroon;
			btn_CurrencyNow.Location = new Point( 351, 390 );
			btn_CurrencyNow.Name = "btn_CurrencyNow";
			btn_CurrencyNow.Size = new Size( 50, 25 );
			btn_CurrencyNow.TabIndex = 15;
			btn_CurrencyNow.Text = "Now";
			btn_CurrencyNow.UseVisualStyleBackColor = true;
			btn_CurrencyNow.Click +=  btn_CurrencyNow_Click ;
			// 
			// tbx_Filter
			// 
			tbx_Filter.BackColor = Color.FromArgb(     255,     192,     192 );
			tbx_Filter.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Filter.HideSelection = false;
			tbx_Filter.Location = new Point( 929, 59 );
			tbx_Filter.MaxLength = 6;
			tbx_Filter.Name = "tbx_Filter";
			tbx_Filter.Size = new Size( 82, 25 );
			tbx_Filter.TabIndex = 0;
			tbx_Filter.TextAlign = HorizontalAlignment.Right;
			tbx_Filter.KeyUp +=  tbx_PkFilter_KeyUp ;
			// 
			// dbx_Birthday
			// 
			dbx_Birthday.CalendarFont = new Font( "Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point );
			dbx_Birthday.CustomFormat = "d MMMM yyyy";
			dbx_Birthday.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			dbx_Birthday.Format = DateTimePickerFormat.Custom;
			dbx_Birthday.Location = new Point( 142, 304 );
			dbx_Birthday.Name = "dbx_Birthday";
			dbx_Birthday.Size = new Size( 233, 23 );
			dbx_Birthday.TabIndex = 8;
			dbx_Birthday.ValueChanged +=  dbx_BirthDate_ValueChanged ;
			// 
			// dbx_WeddingDate
			// 
			dbx_WeddingDate.CalendarFont = new Font( "Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point );
			dbx_WeddingDate.CustomFormat = "d MMMM yyyy";
			dbx_WeddingDate.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			dbx_WeddingDate.Format = DateTimePickerFormat.Custom;
			dbx_WeddingDate.Location = new Point( 142, 362 );
			dbx_WeddingDate.Name = "dbx_WeddingDate";
			dbx_WeddingDate.Size = new Size( 233, 23 );
			dbx_WeddingDate.TabIndex = 12;
			dbx_WeddingDate.ValueChanged +=  dbx_WeddingDate_ValueChanged ;
			// 
			// dbx_DeathDate
			// 
			dbx_DeathDate.CalendarFont = new Font( "Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point );
			dbx_DeathDate.CustomFormat = "d MMMM yyyy";
			dbx_DeathDate.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			dbx_DeathDate.Format = DateTimePickerFormat.Custom;
			dbx_DeathDate.Location = new Point( 142, 333 );
			dbx_DeathDate.Name = "dbx_DeathDate";
			dbx_DeathDate.Size = new Size( 233, 23 );
			dbx_DeathDate.TabIndex = 10;
			dbx_DeathDate.ValueChanged +=  dbx_DeathDate_ValueChanged ;
			// 
			// dbx_CurrencyDate
			// 
			dbx_CurrencyDate.CustomFormat = "ddd, d MMM yyyy HH:mm";
			dbx_CurrencyDate.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			dbx_CurrencyDate.Format = DateTimePickerFormat.Custom;
			dbx_CurrencyDate.Location = new Point( 142, 391 );
			dbx_CurrencyDate.Name = "dbx_CurrencyDate";
			dbx_CurrencyDate.Size = new Size( 203, 23 );
			dbx_CurrencyDate.TabIndex = 14;
			dbx_CurrencyDate.ValueChanged +=  dbx_CurrencyDate_ValueChanged ;
			// 
			// lbl_LastRecord
			// 
			lbl_LastRecord.AutoSize = true;
			lbl_LastRecord.Location = new Point( 990, 118 );
			lbl_LastRecord.Name = "lbl_LastRecord";
			lbl_LastRecord.Size = new Size( 16, 17 );
			lbl_LastRecord.TabIndex = 49;
			lbl_LastRecord.Text = "n";
			// 
			// lbl_FirstRecord
			// 
			lbl_FirstRecord.AutoSize = true;
			lbl_FirstRecord.Location = new Point( 885, 118 );
			lbl_FirstRecord.Name = "lbl_FirstRecord";
			lbl_FirstRecord.Size = new Size( 15, 17 );
			lbl_FirstRecord.TabIndex = 48;
			lbl_FirstRecord.Text = "1";
			// 
			// btn_FindPerson
			// 
			btn_FindPerson.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_FindPerson.ForeColor = Color.Maroon;
			btn_FindPerson.Location = new Point( 878, 313 );
			btn_FindPerson.Name = "btn_FindPerson";
			btn_FindPerson.Size = new Size( 133, 28 );
			btn_FindPerson.TabIndex = 4;
			btn_FindPerson.Text = "Find Person";
			btn_FindPerson.UseVisualStyleBackColor = true;
			btn_FindPerson.UseWaitCursor = true;
			btn_FindPerson.Click +=  btn_FindPerson_Click ;
			// 
			// btn_FirstPerson
			// 
			btn_FirstPerson.Font = new Font( "Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point );
			btn_FirstPerson.Location = new Point( 881, 91 );
			btn_FirstPerson.Name = "btn_FirstPerson";
			btn_FirstPerson.Size = new Size( 27, 23 );
			btn_FirstPerson.TabIndex = 1;
			btn_FirstPerson.Text = "|<";
			btn_FirstPerson.UseVisualStyleBackColor = true;
			btn_FirstPerson.Click +=  btn_FirstPerson_Click ;
			// 
			// btn_PreviousPerson
			// 
			btn_PreviousPerson.Font = new Font( "Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point );
			btn_PreviousPerson.Location = new Point( 912, 91 );
			btn_PreviousPerson.Name = "btn_PreviousPerson";
			btn_PreviousPerson.Size = new Size( 27, 23 );
			btn_PreviousPerson.TabIndex = 2;
			btn_PreviousPerson.Text = "<";
			btn_PreviousPerson.UseVisualStyleBackColor = true;
			btn_PreviousPerson.Click +=  btn_PreviousPerson_Click ;
			// 
			// btn_Close
			// 
			btn_Close.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Close.ForeColor = Color.Maroon;
			btn_Close.Location = new Point( 878, 534 );
			btn_Close.Name = "btn_Close";
			btn_Close.Size = new Size( 133, 34 );
			btn_Close.TabIndex = 7;
			btn_Close.Text = "Close";
			btn_Close.UseVisualStyleBackColor = true;
			btn_Close.Click +=  btn_Close_Click ;
			// 
			// btn_LastPerson
			// 
			btn_LastPerson.Font = new Font( "Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point );
			btn_LastPerson.Location = new Point( 984, 91 );
			btn_LastPerson.Name = "btn_LastPerson";
			btn_LastPerson.Size = new Size( 27, 23 );
			btn_LastPerson.TabIndex = 4;
			btn_LastPerson.Text = ">|";
			btn_LastPerson.UseVisualStyleBackColor = true;
			btn_LastPerson.Click +=  btn_LastPerson_Click ;
			// 
			// btn_NextPerson
			// 
			btn_NextPerson.Font = new Font( "Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point );
			btn_NextPerson.Location = new Point( 949, 91 );
			btn_NextPerson.Name = "btn_NextPerson";
			btn_NextPerson.Size = new Size( 27, 23 );
			btn_NextPerson.TabIndex = 3;
			btn_NextPerson.Text = ">";
			btn_NextPerson.UseVisualStyleBackColor = true;
			btn_NextPerson.Click +=  btn_NextPerson_Click ;
			// 
			// tbx_Initials
			// 
			tbx_Initials.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Initials.Location = new Point( 142, 484 );
			tbx_Initials.Name = "tbx_Initials";
			tbx_Initials.Size = new Size( 73, 25 );
			tbx_Initials.TabIndex = 17;
			tbx_Initials.TabStop = false;
			// 
			// lbl_Initials
			// 
			lbl_Initials.AutoSize = true;
			lbl_Initials.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Initials.ForeColor = Color.Blue;
			lbl_Initials.Location = new Point( 80, 487 );
			lbl_Initials.Name = "lbl_Initials";
			lbl_Initials.Size = new Size( 52, 19 );
			lbl_Initials.TabIndex = 51;
			lbl_Initials.Text = "Initials";
			lbl_Initials.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbx_MatchingPersons
			// 
			lbx_MatchingPersons.BackColor = Color.MistyRose;
			lbx_MatchingPersons.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			lbx_MatchingPersons.ForeColor = Color.Blue;
			lbx_MatchingPersons.FormattingEnabled = true;
			lbx_MatchingPersons.ItemHeight = 15;
			lbx_MatchingPersons.Location = new Point( 564, 24 );
			lbx_MatchingPersons.Name = "lbx_MatchingPersons";
			lbx_MatchingPersons.Size = new Size( 306, 544 );
			lbx_MatchingPersons.TabIndex = 1;
			lbx_MatchingPersons.TabStop = false;
			lbx_MatchingPersons.Click +=  lbx_MatchingPersons_Click ;
			// 
			// tbx_Notes
			// 
			tbx_Notes.BackColor = SystemColors.Window;
			tbx_Notes.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Notes.Location = new Point( 142, 421 );
			tbx_Notes.Name = "tbx_Notes";
			tbx_Notes.Size = new Size( 416, 25 );
			tbx_Notes.TabIndex = 13;
			tbx_Notes.TextChanged +=  tbx_Notes_TextChanged ;
			tbx_Notes.Enter +=  tbx_Notes_Enter ;
			tbx_Notes.Leave +=  tbx_Notes_Leave ;
			// 
			// lbl_Notes
			// 
			lbl_Notes.AutoSize = true;
			lbl_Notes.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Notes.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Notes.Location = new Point( 80, 421 );
			lbl_Notes.Name = "lbl_Notes";
			lbl_Notes.Size = new Size( 48, 19 );
			lbl_Notes.TabIndex = 88;
			lbl_Notes.Text = "Notes";
			lbl_Notes.TextAlign = ContentAlignment.MiddleRight;
			// 
			// grp_PersonData
			// 
			grp_PersonData.Controls.Add( chk_SundayMass );
			grp_PersonData.Controls.Add( chk_Vigil );
			grp_PersonData.Controls.Add( chk_Sacristan );
			grp_PersonData.Controls.Add( chk_Minister );
			grp_PersonData.Controls.Add( chk_TimeTalent );
			grp_PersonData.Controls.Add( chk_Export );
			grp_PersonData.Controls.Add( chk_DefaultRow );
			grp_PersonData.Controls.Add( chk_NoRightPerson );
			grp_PersonData.Controls.Add( chk_NewLeftPerson );
			grp_PersonData.Controls.Add( chk_HolySomething );
			grp_PersonData.Controls.Add( chk_Enlightened );
			grp_PersonData.Controls.Add( chk_Selected );
			grp_PersonData.Controls.Add( tbx_Messages );
			grp_PersonData.Controls.Add( label3 );
			grp_PersonData.Controls.Add( tbx_Matches );
			grp_PersonData.Controls.Add( label1 );
			grp_PersonData.Controls.Add( btn_NewPerson );
			grp_PersonData.Controls.Add( btn_ExportPersonVcf );
			grp_PersonData.Controls.Add( lbl_LastRecord );
			grp_PersonData.Controls.Add( lbx_MatchingPersons );
			grp_PersonData.Controls.Add( btn_ElaborateNames );
			grp_PersonData.Controls.Add( lbl_FirstRecord );
			grp_PersonData.Controls.Add( btn_FindPerson );
			grp_PersonData.Controls.Add( btn_ClearWeddingDate );
			grp_PersonData.Controls.Add( btn_FirstPerson );
			grp_PersonData.Controls.Add( btn_ClearDeathDate );
			grp_PersonData.Controls.Add( btn_PreviousPerson );
			grp_PersonData.Controls.Add( btn_ClearBirthDate );
			grp_PersonData.Controls.Add( btn_Close );
			grp_PersonData.Controls.Add( tbx_ProperSurname );
			grp_PersonData.Controls.Add( btn_LastPerson );
			grp_PersonData.Controls.Add( lbl_Gender );
			grp_PersonData.Controls.Add( btn_NextPerson );
			grp_PersonData.Controls.Add( tbx_Notes );
			grp_PersonData.Controls.Add( lbl_FindPK );
			grp_PersonData.Controls.Add( lbl_ProperSurname );
			grp_PersonData.Controls.Add( tbx_Filter );
			grp_PersonData.Controls.Add( lbl_Notes );
			grp_PersonData.Controls.Add( btn_InsertPerson );
			grp_PersonData.Controls.Add( lbl_GivenName );
			grp_PersonData.Controls.Add( btn_UpdatePerson );
			grp_PersonData.Controls.Add( lbl_MiddleNames );
			grp_PersonData.Controls.Add( tbx_PersonId );
			grp_PersonData.Controls.Add( lbl_PersonPK );
			grp_PersonData.Controls.Add( lbl_Nickname );
			grp_PersonData.Controls.Add( lbl_BirthName );
			grp_PersonData.Controls.Add( lbl_Prefixes );
			grp_PersonData.Controls.Add( lbl_Suffixes );
			grp_PersonData.Controls.Add( lbl_BirthDate );
			grp_PersonData.Controls.Add( lbl_DeathDate );
			grp_PersonData.Controls.Add( lbl_WeddingDate );
			grp_PersonData.Controls.Add( lbl_SURNAME );
			grp_PersonData.Controls.Add( tbx_Initials );
			grp_PersonData.Controls.Add( lbl_NaturalName );
			grp_PersonData.Controls.Add( lbl_Initials );
			grp_PersonData.Controls.Add( lbl_SortableName );
			grp_PersonData.Controls.Add( lbl_CurrencyDate );
			grp_PersonData.Controls.Add( tbx_Gender );
			grp_PersonData.Controls.Add( dbx_CurrencyDate );
			grp_PersonData.Controls.Add( tbx_GivenName );
			grp_PersonData.Controls.Add( dbx_DeathDate );
			grp_PersonData.Controls.Add( tbx_MiddleNames );
			grp_PersonData.Controls.Add( dbx_WeddingDate );
			grp_PersonData.Controls.Add( tbx_NickName );
			grp_PersonData.Controls.Add( dbx_Birthday );
			grp_PersonData.Controls.Add( tbx_BirthName );
			grp_PersonData.Controls.Add( tbx_Prefixes );
			grp_PersonData.Controls.Add( tbx_Suffixes );
			grp_PersonData.Controls.Add( btn_CurrencyNow );
			grp_PersonData.Controls.Add( tbx_UpperSurname );
			grp_PersonData.Controls.Add( tbx_SortableName );
			grp_PersonData.Controls.Add( tbx_NaturalName );
			grp_PersonData.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			grp_PersonData.Location = new Point( 15, 12 );
			grp_PersonData.Name = "grp_PersonData";
			grp_PersonData.Size = new Size( 1021, 617 );
			grp_PersonData.TabIndex = 0;
			grp_PersonData.TabStop = false;
			grp_PersonData.Text = "Person Data";
			// 
			// chk_SundayMass
			// 
			chk_SundayMass.AutoSize = true;
			chk_SundayMass.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_SundayMass.Location = new Point( 422, 389 );
			chk_SundayMass.Name = "chk_SundayMass";
			chk_SundayMass.Size = new Size( 113, 21 );
			chk_SundayMass.TabIndex = 134;
			chk_SundayMass.Text = "Sunday Mass?";
			chk_SundayMass.UseVisualStyleBackColor = true;
			// 
			// chk_Vigil
			// 
			chk_Vigil.AutoSize = true;
			chk_Vigil.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_Vigil.Location = new Point( 422, 363 );
			chk_Vigil.Name = "chk_Vigil";
			chk_Vigil.Size = new Size( 62, 21 );
			chk_Vigil.TabIndex = 133;
			chk_Vigil.Text = "Vigil?";
			chk_Vigil.UseVisualStyleBackColor = true;
			// 
			// chk_Sacristan
			// 
			chk_Sacristan.AutoSize = true;
			chk_Sacristan.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_Sacristan.Location = new Point( 422, 337 );
			chk_Sacristan.Name = "chk_Sacristan";
			chk_Sacristan.Size = new Size( 88, 21 );
			chk_Sacristan.TabIndex = 132;
			chk_Sacristan.Text = "Sacristan?";
			chk_Sacristan.UseVisualStyleBackColor = true;
			// 
			// chk_Minister
			// 
			chk_Minister.AutoSize = true;
			chk_Minister.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_Minister.Location = new Point( 422, 311 );
			chk_Minister.Name = "chk_Minister";
			chk_Minister.Size = new Size( 84, 21 );
			chk_Minister.TabIndex = 131;
			chk_Minister.Text = "Minister?";
			chk_Minister.UseVisualStyleBackColor = true;
			// 
			// chk_TimeTalent
			// 
			chk_TimeTalent.AutoSize = true;
			chk_TimeTalent.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_TimeTalent.Location = new Point( 422, 285 );
			chk_TimeTalent.Name = "chk_TimeTalent";
			chk_TimeTalent.Size = new Size( 118, 21 );
			chk_TimeTalent.TabIndex = 130;
			chk_TimeTalent.Text = "Time + Talent?";
			chk_TimeTalent.UseVisualStyleBackColor = true;
			// 
			// chk_Export
			// 
			chk_Export.AutoSize = true;
			chk_Export.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_Export.Location = new Point( 422, 259 );
			chk_Export.Name = "chk_Export";
			chk_Export.Size = new Size( 72, 21 );
			chk_Export.TabIndex = 129;
			chk_Export.Text = "Export?";
			chk_Export.UseVisualStyleBackColor = true;
			// 
			// chk_DefaultRow
			// 
			chk_DefaultRow.AutoSize = true;
			chk_DefaultRow.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_DefaultRow.Location = new Point( 422, 233 );
			chk_DefaultRow.Name = "chk_DefaultRow";
			chk_DefaultRow.Size = new Size( 109, 21 );
			chk_DefaultRow.TabIndex = 128;
			chk_DefaultRow.Text = "Default Row?";
			chk_DefaultRow.UseVisualStyleBackColor = true;
			// 
			// chk_NoRightPerson
			// 
			chk_NoRightPerson.AutoSize = true;
			chk_NoRightPerson.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_NoRightPerson.Location = new Point( 422, 207 );
			chk_NoRightPerson.Name = "chk_NoRightPerson";
			chk_NoRightPerson.Size = new Size( 134, 21 );
			chk_NoRightPerson.TabIndex = 127;
			chk_NoRightPerson.Text = "No Right-Person?";
			chk_NoRightPerson.UseVisualStyleBackColor = true;
			// 
			// chk_NewLeftPerson
			// 
			chk_NewLeftPerson.AutoSize = true;
			chk_NewLeftPerson.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_NewLeftPerson.Location = new Point( 422, 181 );
			chk_NewLeftPerson.Name = "chk_NewLeftPerson";
			chk_NewLeftPerson.Size = new Size( 134, 21 );
			chk_NewLeftPerson.TabIndex = 126;
			chk_NewLeftPerson.Text = "New Left-Person?";
			chk_NewLeftPerson.UseVisualStyleBackColor = true;
			// 
			// chk_HolySomething
			// 
			chk_HolySomething.AutoSize = true;
			chk_HolySomething.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_HolySomething.Location = new Point( 422, 155 );
			chk_HolySomething.Name = "chk_HolySomething";
			chk_HolySomething.Size = new Size( 133, 21 );
			chk_HolySomething.TabIndex = 125;
			chk_HolySomething.Text = "Holy Something?";
			chk_HolySomething.UseVisualStyleBackColor = true;
			// 
			// chk_Enlightened
			// 
			chk_Enlightened.AutoSize = true;
			chk_Enlightened.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_Enlightened.Location = new Point( 422, 129 );
			chk_Enlightened.Name = "chk_Enlightened";
			chk_Enlightened.Size = new Size( 107, 21 );
			chk_Enlightened.TabIndex = 124;
			chk_Enlightened.Text = "Enlightened?";
			chk_Enlightened.UseVisualStyleBackColor = true;
			// 
			// chk_Selected
			// 
			chk_Selected.AutoSize = true;
			chk_Selected.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_Selected.Location = new Point( 422, 103 );
			chk_Selected.Name = "chk_Selected";
			chk_Selected.Size = new Size( 84, 21 );
			chk_Selected.TabIndex = 123;
			chk_Selected.Text = "Selected?";
			chk_Selected.UseVisualStyleBackColor = true;
			// 
			// tbx_Messages
			// 
			tbx_Messages.BackColor = Color.FromArgb(     255,     255,     192 );
			tbx_Messages.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Messages.ForeColor = Color.ForestGreen;
			tbx_Messages.Location = new Point( 564, 578 );
			tbx_Messages.Name = "tbx_Messages";
			tbx_Messages.Size = new Size( 447, 23 );
			tbx_Messages.TabIndex = 122;
			tbx_Messages.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label3.ForeColor = Color.Blue;
			label3.Location = new Point( 59, 28 );
			label3.Name = "label3";
			label3.Size = new Size( 78, 19 );
			label3.TabIndex = 118;
			label3.Text = "Pre-Find...";
			// 
			// tbx_Matches
			// 
			tbx_Matches.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Matches.Location = new Point( 142, 25 );
			tbx_Matches.Name = "tbx_Matches";
			tbx_Matches.Size = new Size( 233, 23 );
			tbx_Matches.TabIndex = 0;
			tbx_Matches.TextChanged +=  tbx_Matches_TextChanged ;
			tbx_Matches.Leave +=  tbx_Matches_Leave ;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font( "Segoe UI", 14.25F,    FontStyle.Bold  |  FontStyle.Underline , GraphicsUnit.Point );
			label1.ForeColor = Color.Blue;
			label1.Location = new Point( 6, 457 );
			label1.Name = "label1";
			label1.Size = new Size( 146, 25 );
			label1.TabIndex = 105;
			label1.Text = "Derived Names";
			// 
			// btn_NewPerson
			// 
			btn_NewPerson.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_NewPerson.ForeColor = Color.Maroon;
			btn_NewPerson.Location = new Point( 878, 148 );
			btn_NewPerson.Name = "btn_NewPerson";
			btn_NewPerson.Size = new Size( 133, 32 );
			btn_NewPerson.TabIndex = 104;
			btn_NewPerson.Text = "New Person";
			btn_NewPerson.UseVisualStyleBackColor = true;
			btn_NewPerson.UseWaitCursor = true;
			btn_NewPerson.Click +=  btn_NewPerson_Click ;
			// 
			// btn_ExportPersonVcf
			// 
			btn_ExportPersonVcf.Font = new Font( "Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point );
			btn_ExportPersonVcf.ForeColor = Color.Maroon;
			btn_ExportPersonVcf.Location = new Point( 878, 278 );
			btn_ExportPersonVcf.Name = "btn_ExportPersonVcf";
			btn_ExportPersonVcf.Size = new Size( 133, 32 );
			btn_ExportPersonVcf.TabIndex = 103;
			btn_ExportPersonVcf.Text = "Export Person";
			btn_ExportPersonVcf.UseVisualStyleBackColor = true;
			btn_ExportPersonVcf.Click +=  btn_ExportVcfPerson_Click ;
			// 
			// btn_ElaborateNames
			// 
			btn_ElaborateNames.BackColor = Color.FromArgb(     255,     255,     192 );
			btn_ElaborateNames.FlatStyle = FlatStyle.Popup;
			btn_ElaborateNames.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_ElaborateNames.ForeColor = Color.Maroon;
			btn_ElaborateNames.Location = new Point( 381, 57 );
			btn_ElaborateNames.Name = "btn_ElaborateNames";
			btn_ElaborateNames.Size = new Size( 20, 20 );
			btn_ElaborateNames.TabIndex = 2;
			btn_ElaborateNames.TextAlign = ContentAlignment.TopCenter;
			btn_ElaborateNames.UseVisualStyleBackColor = false;
			btn_ElaborateNames.Click +=  btn_ElaborateNames_Click ;
			// 
			// btn_ClearWeddingDate
			// 
			btn_ClearWeddingDate.BackColor = Color.FromArgb(     255,     255,     192 );
			btn_ClearWeddingDate.FlatStyle = FlatStyle.Popup;
			btn_ClearWeddingDate.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_ClearWeddingDate.ForeColor = Color.Maroon;
			btn_ClearWeddingDate.Location = new Point( 381, 362 );
			btn_ClearWeddingDate.Name = "btn_ClearWeddingDate";
			btn_ClearWeddingDate.Size = new Size( 20, 20 );
			btn_ClearWeddingDate.TabIndex = 13;
			btn_ClearWeddingDate.TextAlign = ContentAlignment.TopCenter;
			btn_ClearWeddingDate.UseVisualStyleBackColor = false;
			btn_ClearWeddingDate.Click +=  btn_ClearWeddingDate_Click ;
			// 
			// btn_ClearDeathDate
			// 
			btn_ClearDeathDate.BackColor = Color.FromArgb(     255,     255,     192 );
			btn_ClearDeathDate.FlatStyle = FlatStyle.Popup;
			btn_ClearDeathDate.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_ClearDeathDate.ForeColor = Color.Maroon;
			btn_ClearDeathDate.Location = new Point( 381, 334 );
			btn_ClearDeathDate.Name = "btn_ClearDeathDate";
			btn_ClearDeathDate.Size = new Size( 20, 20 );
			btn_ClearDeathDate.TabIndex = 11;
			btn_ClearDeathDate.TextAlign = ContentAlignment.TopCenter;
			btn_ClearDeathDate.UseVisualStyleBackColor = false;
			btn_ClearDeathDate.Click +=  btn_ClearDeathDate_Click ;
			// 
			// btn_ClearBirthDate
			// 
			btn_ClearBirthDate.BackColor = Color.FromArgb(     255,     255,     192 );
			btn_ClearBirthDate.FlatStyle = FlatStyle.Popup;
			btn_ClearBirthDate.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_ClearBirthDate.ForeColor = Color.Maroon;
			btn_ClearBirthDate.Location = new Point( 381, 304 );
			btn_ClearBirthDate.Name = "btn_ClearBirthDate";
			btn_ClearBirthDate.Size = new Size( 20, 20 );
			btn_ClearBirthDate.TabIndex = 9;
			btn_ClearBirthDate.TextAlign = ContentAlignment.TopCenter;
			btn_ClearBirthDate.UseVisualStyleBackColor = false;
			btn_ClearBirthDate.Click +=  btn_ClearBirthDate_Click ;
			// 
			// FrmPerson
			// 
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_Close;
			ClientSize = new Size( 1045, 635 );
			Controls.Add( grp_PersonData );
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Name = "FrmPerson";
			SizeGripStyle = SizeGripStyle.Hide;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Person Manager";
			grp_PersonData.ResumeLayout( false );
			grp_PersonData.PerformLayout();
			ResumeLayout( false );

		}

		#endregion

		private Button btn_ClearBirthDate;
		private Button btn_ClearDeathDate;
		private Button btn_ClearWeddingDate;
		private Button btn_Close;
		private Button btn_CurrencyNow;
		private Button btn_ElaborateNames;
		private Button btn_FindPerson;
		private Button btn_FirstPerson;
		private Button btn_InsertPerson;
		private Button btn_LastPerson;
		private Button btn_NextPerson;
		private Button btn_PreviousPerson;
		private Button btn_UpdatePerson;
		private DateTimePicker dbx_Birthday;
		private DateTimePicker dbx_CurrencyDate;
		private DateTimePicker dbx_DeathDate;
		private DateTimePicker dbx_WeddingDate;
		private GroupBox grp_PersonData;
		private Label lbl_PersonPK;
		private Label lbl_BirthDate;
		private Label lbl_DeathDate;
		private Label lbl_WeddingDate;
		private Label lbl_FindPK;
		private Label lbl_SURNAME;
		private Label lbl_NaturalName;
		private Label lbl_SortableName;
		private Label lbl_CurrencyDate;
		private Label lbl_Initials;
		private Label lbl_Notes;
		private Label lbl_Gender;
		private Label lbl_FirstRecord;
		private Label lbl_LastRecord;
		private Label lbl_ProperSurname;
		private Label lbl_GivenName;
		private Label lbl_MiddleNames;
		private Label lbl_Nickname;
		private Label lbl_BirthName;
		private Label lbl_Prefixes;
		private Label lbl_Suffixes;
		private ListBox lbx_MatchingPersons;
		private TextBox tbx_BirthName;
		private TextBox tbx_Filter;
		private TextBox tbx_Gender;
		private TextBox tbx_GivenName;
		private TextBox tbx_Initials;
		private TextBox tbx_MiddleNames;
		private TextBox tbx_NaturalName;
		private TextBox tbx_NickName;
		private TextBox tbx_Notes;
		private TextBox tbx_PersonId;
		private TextBox tbx_Prefixes;
		private TextBox tbx_ProperSurname;
		private TextBox tbx_SortableName;
		private TextBox tbx_Suffixes;
		private TextBox tbx_UpperSurname;
		private Button btn_ExportPersonVcf;
		private Button btn_NewPerson;
		private Label label1;
		private Label label3;
		private TextBox tbx_Matches;
		private TextBox tbx_Messages;
		private CheckBox chk_Selected;
		private CheckBox chk_SundayMass;
		private CheckBox chk_Vigil;
		private CheckBox chk_Sacristan;
		private CheckBox chk_Minister;
		private CheckBox chk_TimeTalent;
		private CheckBox chk_Export;
		private CheckBox chk_DefaultRow;
		private CheckBox chk_NoRightPerson;
		private CheckBox chk_NewLeftPerson;
		private CheckBox chk_HolySomething;
		private CheckBox chk_Enlightened;
	}
}