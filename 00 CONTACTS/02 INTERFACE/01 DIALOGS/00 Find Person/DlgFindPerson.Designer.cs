namespace CONTACTS.INTERFACE.DIALOGS
{
	public partial class DlgFindPerson
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components == null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lbx_MatchingPersons = new ListBox();
			grp_AddressData = new GroupBox();
			tbx_Notes = new TextBox();
			label2 = new Label();
			btn_Cancel = new Button();
			tbx_Initials = new TextBox();
			label1 = new Label();
			btn_CloseForm = new Button();
			lbl_POBox = new Label();
			tbx_BirthName = new TextBox();
			label25 = new Label();
			label19 = new Label();
			label16 = new Label();
			tbx_GivenName = new TextBox();
			tbx_Suffix = new TextBox();
			tbx_Gender = new TextBox();
			label5 = new Label();
			tbx_NickName = new TextBox();
			tbx_ProperSurname = new TextBox();
			label10 = new Label();
			label7 = new Label();
			label6 = new Label();
			tbx_Prefix = new TextBox();
			tbx_MiddleNames = new TextBox();
			tbx_CurrentlySelectedPerson = new TextBox();
			grp_AddressData.SuspendLayout();
			SuspendLayout();
			// 
			// lbx_MatchingPersons
			// 
			lbx_MatchingPersons.BackColor = Color.MistyRose;
			lbx_MatchingPersons.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			lbx_MatchingPersons.ForeColor = Color.Blue;
			lbx_MatchingPersons.FormattingEnabled = true;
			lbx_MatchingPersons.ItemHeight = 15;
			lbx_MatchingPersons.Location = new Point( 12, 9 );
			lbx_MatchingPersons.Name = "lbx_MatchingPersons";
			lbx_MatchingPersons.Size = new Size( 495, 544 );
			lbx_MatchingPersons.TabIndex = 1;
			lbx_MatchingPersons.TabStop = false;
			lbx_MatchingPersons.SelectedValueChanged +=  lbx_MatchingPersons_SelectedValueChanged ;
			lbx_MatchingPersons.DoubleClick +=  lbx_MatchingPersons_DoubleClick ;
			// 
			// grp_AddressData
			// 
			grp_AddressData.BackColor = Color.FromArgb(     255,     224,     192 );
			grp_AddressData.Controls.Add( tbx_Notes );
			grp_AddressData.Controls.Add( label2 );
			grp_AddressData.Controls.Add( btn_Cancel );
			grp_AddressData.Controls.Add( tbx_Initials );
			grp_AddressData.Controls.Add( label1 );
			grp_AddressData.Controls.Add( btn_CloseForm );
			grp_AddressData.Controls.Add( lbl_POBox );
			grp_AddressData.Controls.Add( tbx_BirthName );
			grp_AddressData.Controls.Add( label25 );
			grp_AddressData.Controls.Add( label19 );
			grp_AddressData.Controls.Add( label16 );
			grp_AddressData.Controls.Add( tbx_GivenName );
			grp_AddressData.Controls.Add( tbx_Suffix );
			grp_AddressData.Controls.Add( tbx_Gender );
			grp_AddressData.Controls.Add( label5 );
			grp_AddressData.Controls.Add( tbx_NickName );
			grp_AddressData.Controls.Add( tbx_ProperSurname );
			grp_AddressData.Controls.Add( label10 );
			grp_AddressData.Controls.Add( label7 );
			grp_AddressData.Controls.Add( label6 );
			grp_AddressData.Controls.Add( tbx_Prefix );
			grp_AddressData.Controls.Add( tbx_MiddleNames );
			grp_AddressData.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			grp_AddressData.Location = new Point( 526, 12 );
			grp_AddressData.Name = "grp_AddressData";
			grp_AddressData.Size = new Size( 268, 586 );
			grp_AddressData.TabIndex = 0;
			grp_AddressData.TabStop = false;
			grp_AddressData.Text = "Person Filters";
			// 
			// tbx_Notes
			// 
			tbx_Notes.BackColor = SystemColors.Window;
			tbx_Notes.Location = new Point( 59, 298 );
			tbx_Notes.Name = "tbx_Notes";
			tbx_Notes.Size = new Size( 187, 23 );
			tbx_Notes.TabIndex = 62;
			tbx_Notes.TextChanged +=  tbx_Notes_TextChanged ;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label2.ForeColor = Color.FromArgb(     192,     0,     0 );
			label2.Location = new Point( 8, 300 );
			label2.Name = "label2";
			label2.Size = new Size( 48, 19 );
			label2.TabIndex = 63;
			label2.Text = "Notes";
			// 
			// btn_Cancel
			// 
			btn_Cancel.BackColor = Color.MistyRose;
			btn_Cancel.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Cancel.ForeColor = Color.Maroon;
			btn_Cancel.Location = new Point( 131, 528 );
			btn_Cancel.Name = "btn_Cancel";
			btn_Cancel.Size = new Size( 115, 34 );
			btn_Cancel.TabIndex = 10;
			btn_Cancel.Text = "Cancel";
			btn_Cancel.UseVisualStyleBackColor = false;
			btn_Cancel.Click +=  btn_Cancel_Click ;
			// 
			// tbx_Initials
			// 
			tbx_Initials.BackColor = SystemColors.Window;
			tbx_Initials.Location = new Point( 131, 226 );
			tbx_Initials.Name = "tbx_Initials";
			tbx_Initials.Size = new Size( 115, 23 );
			tbx_Initials.TabIndex = 7;
			tbx_Initials.TextChanged +=  tbx_Initials_TextChanged ;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label1.ForeColor = Color.FromArgb(     192,     0,     0 );
			label1.Location = new Point( 71, 228 );
			label1.Name = "label1";
			label1.Size = new Size( 52, 19 );
			label1.TabIndex = 61;
			label1.Text = "Initials";
			// 
			// btn_CloseForm
			// 
			btn_CloseForm.BackColor = Color.MistyRose;
			btn_CloseForm.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_CloseForm.ForeColor = Color.Maroon;
			btn_CloseForm.Location = new Point( 131, 488 );
			btn_CloseForm.Name = "btn_CloseForm";
			btn_CloseForm.Size = new Size( 115, 34 );
			btn_CloseForm.TabIndex = 9;
			btn_CloseForm.Text = "Close";
			btn_CloseForm.UseVisualStyleBackColor = false;
			btn_CloseForm.Click +=  btn_CloseForm_Click ;
			// 
			// lbl_POBox
			// 
			lbl_POBox.AutoSize = true;
			lbl_POBox.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_POBox.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_POBox.Location = new Point( 44, 144 );
			lbl_POBox.Name = "lbl_POBox";
			lbl_POBox.Size = new Size( 85, 19 );
			lbl_POBox.TabIndex = 0;
			lbl_POBox.Text = "Birth Name";
			// 
			// tbx_BirthName
			// 
			tbx_BirthName.BackColor = SystemColors.Window;
			tbx_BirthName.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_BirthName.Location = new Point( 131, 141 );
			tbx_BirthName.Name = "tbx_BirthName";
			tbx_BirthName.Size = new Size( 115, 23 );
			tbx_BirthName.TabIndex = 4;
			tbx_BirthName.TextChanged +=  tbx_BirthName_TextChanged ;
			// 
			// label25
			// 
			label25.AutoSize = true;
			label25.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label25.ForeColor = Color.FromArgb(     192,     0,     0 );
			label25.Location = new Point( 82, 199 );
			label25.Name = "label25";
			label25.Size = new Size( 47, 19 );
			label25.TabIndex = 50;
			label25.Text = "Suffix";
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label19.ForeColor = Color.FromArgb(     192,     0,     0 );
			label19.Location = new Point( 38, 56 );
			label19.Name = "label19";
			label19.Size = new Size( 91, 19 );
			label19.TabIndex = 22;
			label19.Text = "Given Name";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label16.ForeColor = Color.FromArgb(     192,     0,     0 );
			label16.Location = new Point( 80, 170 );
			label16.Name = "label16";
			label16.Size = new Size( 49, 19 );
			label16.TabIndex = 3;
			label16.Text = "Prefix";
			// 
			// tbx_GivenName
			// 
			tbx_GivenName.BackColor = SystemColors.Window;
			tbx_GivenName.Location = new Point( 131, 53 );
			tbx_GivenName.Name = "tbx_GivenName";
			tbx_GivenName.Size = new Size( 115, 23 );
			tbx_GivenName.TabIndex = 1;
			tbx_GivenName.TextChanged +=  tbx_GivenName_TextChanged ;
			// 
			// tbx_Suffix
			// 
			tbx_Suffix.BackColor = SystemColors.Window;
			tbx_Suffix.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Suffix.Location = new Point( 131, 197 );
			tbx_Suffix.Name = "tbx_Suffix";
			tbx_Suffix.Size = new Size( 115, 23 );
			tbx_Suffix.TabIndex = 6;
			tbx_Suffix.TextChanged +=  tbx_Suffix_TextChanged ;
			// 
			// tbx_Gender
			// 
			tbx_Gender.BackColor = SystemColors.Window;
			tbx_Gender.Location = new Point( 131, 255 );
			tbx_Gender.Name = "tbx_Gender";
			tbx_Gender.Size = new Size( 38, 23 );
			tbx_Gender.TabIndex = 8;
			tbx_Gender.TextChanged +=  tbx_Gender_TextChanged ;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label5.ForeColor = Color.FromArgb(     192,     0,     0 );
			label5.Location = new Point( 10, 27 );
			label5.Name = "label5";
			label5.Size = new Size( 119, 19 );
			label5.TabIndex = 18;
			label5.Text = "Proper Surname";
			// 
			// tbx_NickName
			// 
			tbx_NickName.BackColor = SystemColors.Window;
			tbx_NickName.Location = new Point( 131, 112 );
			tbx_NickName.Name = "tbx_NickName";
			tbx_NickName.Size = new Size( 115, 23 );
			tbx_NickName.TabIndex = 3;
			tbx_NickName.TextChanged +=  tbx_NickName_TextChanged ;
			// 
			// tbx_ProperSurname
			// 
			tbx_ProperSurname.BackColor = SystemColors.Window;
			tbx_ProperSurname.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_ProperSurname.Location = new Point( 131, 24 );
			tbx_ProperSurname.Name = "tbx_ProperSurname";
			tbx_ProperSurname.Size = new Size( 115, 23 );
			tbx_ProperSurname.TabIndex = 0;
			tbx_ProperSurname.TextChanged +=  tbx_ProperSurname_TextChanged ;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label10.ForeColor = Color.FromArgb(     192,     0,     0 );
			label10.Location = new Point( 71, 257 );
			label10.Name = "label10";
			label10.Size = new Size( 58, 19 );
			label10.TabIndex = 59;
			label10.Text = "Gender";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label7.ForeColor = Color.FromArgb(     192,     0,     0 );
			label7.Location = new Point( 50, 115 );
			label7.Name = "label7";
			label7.Size = new Size( 79, 19 );
			label7.TabIndex = 37;
			label7.Text = "NickName";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label6.ForeColor = Color.FromArgb(     192,     0,     0 );
			label6.Location = new Point( 13, 86 );
			label6.Name = "label6";
			label6.Size = new Size( 116, 19 );
			label6.TabIndex = 33;
			label6.Text = "Middle Name(s)";
			// 
			// tbx_Prefix
			// 
			tbx_Prefix.BackColor = SystemColors.Window;
			tbx_Prefix.Location = new Point( 131, 168 );
			tbx_Prefix.Name = "tbx_Prefix";
			tbx_Prefix.Size = new Size( 115, 23 );
			tbx_Prefix.TabIndex = 5;
			tbx_Prefix.TextChanged +=  tbx_Prefix_TextChanged ;
			// 
			// tbx_MiddleNames
			// 
			tbx_MiddleNames.BackColor = SystemColors.Window;
			tbx_MiddleNames.Location = new Point( 131, 82 );
			tbx_MiddleNames.Name = "tbx_MiddleNames";
			tbx_MiddleNames.Size = new Size( 115, 23 );
			tbx_MiddleNames.TabIndex = 2;
			tbx_MiddleNames.TextChanged +=  tbx_MiddleNames_TextChanged ;
			// 
			// tbx_CurrentlySelectedPerson
			// 
			tbx_CurrentlySelectedPerson.BackColor = SystemColors.Window;
			tbx_CurrentlySelectedPerson.Location = new Point( 12, 559 );
			tbx_CurrentlySelectedPerson.Name = "tbx_CurrentlySelectedPerson";
			tbx_CurrentlySelectedPerson.Size = new Size( 495, 23 );
			tbx_CurrentlySelectedPerson.TabIndex = 63;
			// 
			// DlgFindPerson
			// 
			AcceptButton = btn_CloseForm;
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_Cancel;
			ClientSize = new Size( 809, 610 );
			Controls.Add( tbx_CurrentlySelectedPerson );
			Controls.Add( grp_AddressData );
			Controls.Add( lbx_MatchingPersons );
			Name = "DlgFindPerson";
			StartPosition = FormStartPosition.CenterParent;
			Text = "(CONTACTS) Person";
			TopMost = true;
			grp_AddressData.ResumeLayout( false );
			grp_AddressData.PerformLayout();
			ResumeLayout( false );
			PerformLayout();

		}

		#endregion

		private ListBox lbx_MatchingPersons;
		private GroupBox grp_AddressData;
		private Label lbl_POBox;
		private TextBox tbx_BirthName;
		private Label label25;
		private Label label19;
		private Label label16;
		private TextBox tbx_GivenName;
		private TextBox tbx_Suffix;
		private TextBox tbx_Gender;
		private Label label5;
		private TextBox tbx_NickName;
		private TextBox tbx_ProperSurname;
		private Label label10;
		private Label label7;
		private Label label6;
		private TextBox tbx_Prefix;
		private TextBox tbx_MiddleNames;
		private Button btn_CloseForm;
		private TextBox tbx_Initials;
		private Label label1;
		private Button btn_Cancel;
		private TextBox tbx_Notes;
		private Label label2;
		private TextBox tbx_CurrentlySelectedPerson;
	}
}