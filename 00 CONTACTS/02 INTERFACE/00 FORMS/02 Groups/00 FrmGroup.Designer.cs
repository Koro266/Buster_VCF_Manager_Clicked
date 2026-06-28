namespace CONTACTS.INTERFACE.FORMS
{
	public partial class FrmGroup
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
			lbx_MatchingGroups = new ListBox();
			box_GroupData = new GroupBox();
			tbx_Messages = new TextBox();
			label3 = new Label();
			tbx_Matches = new TextBox();
			btn_ExportGroup = new Button();
			btn_NewGroup = new Button();
			lbl_Nth = new Label();
			lbl_Zero = new Label();
			btn_CloseForm = new Button();
			btn_FirstGroup = new Button();
			lbl_Notes = new Label();
			btn_InsertGroup = new Button();
			tbx_Notes = new TextBox();
			btn_PreviousGroup = new Button();
			cbx_GroupType = new ComboBox();
			btn_LastGroup = new Button();
			dbx_CurrencyDate = new DateTimePicker();
			btn_UpdateGroup = new Button();
			btn_CurrencyNow = new Button();
			btn_NextGroup = new Button();
			lbl_CurrencyDate = new Label();
			lbl_PK = new Label();
			lbl_GroupName = new Label();
			tbx_Filter = new TextBox();
			tbx_GroupName = new TextBox();
			tbx_PkGroup = new TextBox();
			lbl_FindPk = new Label();
			lbl_GroupType = new Label();
			box_GroupData.SuspendLayout();
			SuspendLayout();
			// 
			// lbx_MatchingGroups
			// 
			lbx_MatchingGroups.BackColor = Color.MistyRose;
			lbx_MatchingGroups.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			lbx_MatchingGroups.ForeColor = Color.Blue;
			lbx_MatchingGroups.FormattingEnabled = true;
			lbx_MatchingGroups.ItemHeight = 15;
			lbx_MatchingGroups.Location = new Point( 106, 178 );
			lbx_MatchingGroups.Name = "lbx_MatchingGroups";
			lbx_MatchingGroups.Size = new Size( 421, 229 );
			lbx_MatchingGroups.TabIndex = 1;
			lbx_MatchingGroups.TabStop = false;
			lbx_MatchingGroups.SelectedIndexChanged +=  lbx_MatchingGroups_SelectedIndexChanged ;
			// 
			// box_GroupData
			// 
			box_GroupData.Controls.Add( tbx_Messages );
			box_GroupData.Controls.Add( label3 );
			box_GroupData.Controls.Add( tbx_Matches );
			box_GroupData.Controls.Add( btn_ExportGroup );
			box_GroupData.Controls.Add( btn_NewGroup );
			box_GroupData.Controls.Add( lbl_Nth );
			box_GroupData.Controls.Add( lbl_Zero );
			box_GroupData.Controls.Add( lbx_MatchingGroups );
			box_GroupData.Controls.Add( btn_CloseForm );
			box_GroupData.Controls.Add( btn_FirstGroup );
			box_GroupData.Controls.Add( lbl_Notes );
			box_GroupData.Controls.Add( btn_InsertGroup );
			box_GroupData.Controls.Add( tbx_Notes );
			box_GroupData.Controls.Add( btn_PreviousGroup );
			box_GroupData.Controls.Add( cbx_GroupType );
			box_GroupData.Controls.Add( btn_LastGroup );
			box_GroupData.Controls.Add( dbx_CurrencyDate );
			box_GroupData.Controls.Add( btn_UpdateGroup );
			box_GroupData.Controls.Add( btn_CurrencyNow );
			box_GroupData.Controls.Add( btn_NextGroup );
			box_GroupData.Controls.Add( lbl_CurrencyDate );
			box_GroupData.Controls.Add( lbl_PK );
			box_GroupData.Controls.Add( lbl_GroupName );
			box_GroupData.Controls.Add( tbx_Filter );
			box_GroupData.Controls.Add( tbx_GroupName );
			box_GroupData.Controls.Add( tbx_PkGroup );
			box_GroupData.Controls.Add( lbl_FindPk );
			box_GroupData.Controls.Add( lbl_GroupType );
			box_GroupData.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			box_GroupData.Location = new Point( 12, 12 );
			box_GroupData.Name = "box_GroupData";
			box_GroupData.Size = new Size( 706, 444 );
			box_GroupData.TabIndex = 0;
			box_GroupData.TabStop = false;
			box_GroupData.Text = "Group Data";
			// 
			// tbx_Messages
			// 
			tbx_Messages.BackColor = Color.FromArgb(     255,     255,     192 );
			tbx_Messages.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Messages.ForeColor = Color.ForestGreen;
			tbx_Messages.Location = new Point( 106, 415 );
			tbx_Messages.Name = "tbx_Messages";
			tbx_Messages.Size = new Size( 585, 23 );
			tbx_Messages.TabIndex = 121;
			tbx_Messages.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label3.ForeColor = Color.Blue;
			label3.Location = new Point( 24, 27 );
			label3.Name = "label3";
			label3.Size = new Size( 78, 19 );
			label3.TabIndex = 120;
			label3.Text = "Pre-Find...";
			// 
			// tbx_Matches
			// 
			tbx_Matches.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Matches.Location = new Point( 106, 24 );
			tbx_Matches.Name = "tbx_Matches";
			tbx_Matches.Size = new Size( 122, 23 );
			tbx_Matches.TabIndex = 119;
			tbx_Matches.TextChanged +=  tbx_Matches_TextChanged ;
			// 
			// btn_ExportGroup
			// 
			btn_ExportGroup.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_ExportGroup.ForeColor = Color.Maroon;
			btn_ExportGroup.Location = new Point( 558, 289 );
			btn_ExportGroup.Name = "btn_ExportGroup";
			btn_ExportGroup.Size = new Size( 133, 28 );
			btn_ExportGroup.TabIndex = 13;
			btn_ExportGroup.Text = "Export Group";
			btn_ExportGroup.UseVisualStyleBackColor = true;
			btn_ExportGroup.Click +=  btn_ExportGroup_Click ;
			// 
			// btn_NewGroup
			// 
			btn_NewGroup.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_NewGroup.ForeColor = Color.Maroon;
			btn_NewGroup.Location = new Point( 558, 146 );
			btn_NewGroup.Name = "btn_NewGroup";
			btn_NewGroup.Size = new Size( 133, 28 );
			btn_NewGroup.TabIndex = 10;
			btn_NewGroup.Text = "New Group";
			btn_NewGroup.UseVisualStyleBackColor = true;
			btn_NewGroup.UseWaitCursor = true;
			btn_NewGroup.Click +=  btn_NewGroup_Click ;
			// 
			// lbl_Nth
			// 
			lbl_Nth.AutoSize = true;
			lbl_Nth.Location = new Point( 669, 110 );
			lbl_Nth.Name = "lbl_Nth";
			lbl_Nth.Size = new Size( 16, 17 );
			lbl_Nth.TabIndex = 14;
			lbl_Nth.Text = "n";
			// 
			// lbl_Zero
			// 
			lbl_Zero.AutoSize = true;
			lbl_Zero.Location = new Point( 566, 110 );
			lbl_Zero.Name = "lbl_Zero";
			lbl_Zero.Size = new Size( 15, 17 );
			lbl_Zero.TabIndex = 13;
			lbl_Zero.Text = "1";
			// 
			// btn_CloseForm
			// 
			btn_CloseForm.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_CloseForm.ForeColor = Color.Maroon;
			btn_CloseForm.Location = new Point( 559, 364 );
			btn_CloseForm.Name = "btn_CloseForm";
			btn_CloseForm.Size = new Size( 133, 28 );
			btn_CloseForm.TabIndex = 15;
			btn_CloseForm.Text = "Close";
			btn_CloseForm.UseVisualStyleBackColor = true;
			btn_CloseForm.Click +=  btn_CloseForm_Click ;
			// 
			// btn_FirstGroup
			// 
			btn_FirstGroup.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			btn_FirstGroup.Location = new Point( 559, 85 );
			btn_FirstGroup.Name = "btn_FirstGroup";
			btn_FirstGroup.Size = new Size( 27, 23 );
			btn_FirstGroup.TabIndex = 6;
			btn_FirstGroup.Text = "|<";
			btn_FirstGroup.UseVisualStyleBackColor = true;
			btn_FirstGroup.Click +=  btn_FirstGroup_Click ;
			// 
			// lbl_Notes
			// 
			lbl_Notes.AutoSize = true;
			lbl_Notes.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Notes.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Notes.Location = new Point( 54, 116 );
			lbl_Notes.Name = "lbl_Notes";
			lbl_Notes.Size = new Size( 48, 19 );
			lbl_Notes.TabIndex = 23;
			lbl_Notes.Text = "Notes";
			// 
			// btn_InsertGroup
			// 
			btn_InsertGroup.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_InsertGroup.ForeColor = Color.Maroon;
			btn_InsertGroup.Location = new Point( 558, 197 );
			btn_InsertGroup.Name = "btn_InsertGroup";
			btn_InsertGroup.Size = new Size( 133, 28 );
			btn_InsertGroup.TabIndex = 11;
			btn_InsertGroup.Text = "Insert Group";
			btn_InsertGroup.UseVisualStyleBackColor = true;
			btn_InsertGroup.Click +=  btn_InsertGroup_Click ;
			// 
			// tbx_Notes
			// 
			tbx_Notes.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Notes.Location = new Point( 106, 114 );
			tbx_Notes.Name = "tbx_Notes";
			tbx_Notes.Size = new Size( 421, 23 );
			tbx_Notes.TabIndex = 2;
			tbx_Notes.TextChanged +=  tbx_Notes_TextChanged ;
			tbx_Notes.Enter +=  tbx_Notes_Enter ;
			tbx_Notes.Leave +=  tbx_Notes_Leave ;
			// 
			// btn_PreviousGroup
			// 
			btn_PreviousGroup.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			btn_PreviousGroup.Location = new Point( 594, 85 );
			btn_PreviousGroup.Name = "btn_PreviousGroup";
			btn_PreviousGroup.Size = new Size( 27, 23 );
			btn_PreviousGroup.TabIndex = 7;
			btn_PreviousGroup.Text = "<";
			btn_PreviousGroup.UseVisualStyleBackColor = true;
			btn_PreviousGroup.Click +=  btn_PreviousGroup_Click ;
			// 
			// cbx_GroupType
			// 
			cbx_GroupType.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			cbx_GroupType.FormattingEnabled = true;
			cbx_GroupType.Location = new Point( 106, 83 );
			cbx_GroupType.Name = "cbx_GroupType";
			cbx_GroupType.Size = new Size( 421, 25 );
			cbx_GroupType.TabIndex = 1;
			cbx_GroupType.SelectedIndexChanged +=  cbx_GroupType_SelectedIndexChanged ;
			// 
			// btn_LastGroup
			// 
			btn_LastGroup.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			btn_LastGroup.Location = new Point( 664, 85 );
			btn_LastGroup.Name = "btn_LastGroup";
			btn_LastGroup.Size = new Size( 27, 23 );
			btn_LastGroup.TabIndex = 9;
			btn_LastGroup.Text = ">|";
			btn_LastGroup.UseVisualStyleBackColor = true;
			btn_LastGroup.Click +=  btn_LastGroup_Click ;
			// 
			// dbx_CurrencyDate
			// 
			dbx_CurrencyDate.CustomFormat = "ddd, d MMM yyyy HH:mm";
			dbx_CurrencyDate.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			dbx_CurrencyDate.Format = DateTimePickerFormat.Custom;
			dbx_CurrencyDate.Location = new Point( 106, 144 );
			dbx_CurrencyDate.Name = "dbx_CurrencyDate";
			dbx_CurrencyDate.Size = new Size( 219, 23 );
			dbx_CurrencyDate.TabIndex = 3;
			dbx_CurrencyDate.ValueChanged +=  dbx_CurrencyDate_ValueChanged ;
			// 
			// btn_UpdateGroup
			// 
			btn_UpdateGroup.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_UpdateGroup.ForeColor = Color.Maroon;
			btn_UpdateGroup.Location = new Point( 558, 228 );
			btn_UpdateGroup.Name = "btn_UpdateGroup";
			btn_UpdateGroup.Size = new Size( 133, 28 );
			btn_UpdateGroup.TabIndex = 12;
			btn_UpdateGroup.Text = "Update Group";
			btn_UpdateGroup.UseVisualStyleBackColor = true;
			btn_UpdateGroup.Click +=  btn_UpdateGroup_Click ;
			// 
			// btn_CurrencyNow
			// 
			btn_CurrencyNow.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_CurrencyNow.ForeColor = Color.Maroon;
			btn_CurrencyNow.Location = new Point( 331, 143 );
			btn_CurrencyNow.Name = "btn_CurrencyNow";
			btn_CurrencyNow.Size = new Size( 50, 25 );
			btn_CurrencyNow.TabIndex = 4;
			btn_CurrencyNow.Text = "Now";
			btn_CurrencyNow.UseVisualStyleBackColor = true;
			btn_CurrencyNow.Click +=  btn_CurrencyNow_Click ;
			// 
			// btn_NextGroup
			// 
			btn_NextGroup.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			btn_NextGroup.Location = new Point( 629, 85 );
			btn_NextGroup.Name = "btn_NextGroup";
			btn_NextGroup.Size = new Size( 27, 23 );
			btn_NextGroup.TabIndex = 8;
			btn_NextGroup.Text = ">";
			btn_NextGroup.UseVisualStyleBackColor = true;
			btn_NextGroup.Click +=  btn_NextGroup_Click ;
			// 
			// lbl_CurrencyDate
			// 
			lbl_CurrencyDate.AutoSize = true;
			lbl_CurrencyDate.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_CurrencyDate.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_CurrencyDate.Location = new Point( -2, 147 );
			lbl_CurrencyDate.Name = "lbl_CurrencyDate";
			lbl_CurrencyDate.Size = new Size( 104, 19 );
			lbl_CurrencyDate.TabIndex = 21;
			lbl_CurrencyDate.Text = "Currency Date";
			lbl_CurrencyDate.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_PK
			// 
			lbl_PK.AutoSize = true;
			lbl_PK.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_PK.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_PK.Location = new Point( 582, 23 );
			lbl_PK.Name = "lbl_PK";
			lbl_PK.Size = new Size( 34, 21 );
			lbl_PK.TabIndex = 4;
			lbl_PK.Text = "PK:";
			// 
			// lbl_GroupName
			// 
			lbl_GroupName.AutoSize = true;
			lbl_GroupName.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_GroupName.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_GroupName.Location = new Point( 7, 56 );
			lbl_GroupName.Name = "lbl_GroupName";
			lbl_GroupName.Size = new Size( 95, 19 );
			lbl_GroupName.TabIndex = 7;
			lbl_GroupName.Text = "Group Name";
			// 
			// tbx_Filter
			// 
			tbx_Filter.BackColor = Color.FromArgb(     255,     192,     192 );
			tbx_Filter.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Filter.Location = new Point( 618, 52 );
			tbx_Filter.MaxLength = 6;
			tbx_Filter.Name = "tbx_Filter";
			tbx_Filter.Size = new Size( 73, 25 );
			tbx_Filter.TabIndex = 5;
			tbx_Filter.TextAlign = HorizontalAlignment.Right;
			tbx_Filter.KeyUp +=  tbx_Filter_KeyUp ;
			// 
			// tbx_GroupName
			// 
			tbx_GroupName.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_GroupName.Location = new Point( 106, 53 );
			tbx_GroupName.Name = "tbx_GroupName";
			tbx_GroupName.Size = new Size( 421, 25 );
			tbx_GroupName.TabIndex = 0;
			tbx_GroupName.TextChanged +=  tbx_GroupName_TextChanged ;
			tbx_GroupName.Enter +=  tbx_GroupName_Enter ;
			tbx_GroupName.Leave +=  tbx_GroupName_Leave ;
			// 
			// tbx_PkGroup
			// 
			tbx_PkGroup.AcceptsReturn = true;
			tbx_PkGroup.BackColor = Color.FromArgb(     192,     192,     255 );
			tbx_PkGroup.Enabled = false;
			tbx_PkGroup.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_PkGroup.Location = new Point( 618, 21 );
			tbx_PkGroup.Name = "tbx_PkGroup";
			tbx_PkGroup.PlaceholderText = "PK";
			tbx_PkGroup.ReadOnly = true;
			tbx_PkGroup.Size = new Size( 73, 25 );
			tbx_PkGroup.TabIndex = 1;
			tbx_PkGroup.TabStop = false;
			tbx_PkGroup.TextAlign = HorizontalAlignment.Right;
			// 
			// lbl_FindPk
			// 
			lbl_FindPk.AutoSize = true;
			lbl_FindPk.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_FindPk.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_FindPk.ImageAlign = ContentAlignment.MiddleRight;
			lbl_FindPk.Location = new Point( 545, 54 );
			lbl_FindPk.Name = "lbl_FindPk";
			lbl_FindPk.Size = new Size( 71, 21 );
			lbl_FindPk.TabIndex = 0;
			lbl_FindPk.Text = "Find PK:";
			lbl_FindPk.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_GroupType
			// 
			lbl_GroupType.AutoSize = true;
			lbl_GroupType.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_GroupType.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_GroupType.Location = new Point( 15, 86 );
			lbl_GroupType.Name = "lbl_GroupType";
			lbl_GroupType.Size = new Size( 87, 19 );
			lbl_GroupType.TabIndex = 5;
			lbl_GroupType.Text = "Group Type";
			// 
			// FrmGroup
			// 
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_CloseForm;
			ClientSize = new Size( 730, 462 );
			Controls.Add( box_GroupData );
			Name = "FrmGroup";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Group Manager";
			box_GroupData.ResumeLayout( false );
			box_GroupData.PerformLayout();
			ResumeLayout( false );

		}

		#endregion
		private ListBox lbx_MatchingGroups;
		private GroupBox box_GroupData;
		private ComboBox cbx_GroupType;
		private DateTimePicker dbx_CurrencyDate;
		private Button btn_CurrencyNow;
		private Label lbl_CurrencyDate;
		private Label lbl_GroupName;
		private TextBox tbx_GroupName;
		private Label lbl_GroupType;
		private Label lbl_Notes;
		private TextBox tbx_Notes;
		private Label lbl_Nth;
		private Label lbl_Zero;
		private Button btn_CloseForm;
		private Button btn_FirstGroup;
		private Button btn_InsertGroup;
		private Button btn_PreviousGroup;
		private Button btn_LastGroup;
		private Button btn_UpdateGroup;
		private Button btn_NextGroup;
		private Label lbl_PK;
		private TextBox tbx_Filter;
		private TextBox tbx_PkGroup;
		private Label lbl_FindPk;
		private Button btn_NewGroup;
		private Button btn_ExportGroup;
		private Label label3;
		private TextBox tbx_Matches;
		private TextBox tbx_Messages;
	}
}