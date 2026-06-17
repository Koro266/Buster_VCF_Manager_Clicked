namespace CONTACTS.INTERFACE.DIALOGS
{
	public partial class DlgFindFamily
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
			if ( disposing && ( components != null ) )
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
			lbx_MatchingFamilies = new ListBox();
			grp_GroupData = new GroupBox();
			btn_GetPk = new Button();
			label16 = new Label();
			label5 = new Label();
			tbx_FamilyName = new TextBox();
			tbx_PkFamily = new TextBox();
			btn_Cancel = new Button();
			btn_Close = new Button();
			grp_GroupData.SuspendLayout();
			SuspendLayout();
			// 
			// lbx_MatchingFamilies
			// 
			lbx_MatchingFamilies.BackColor = Color.MistyRose;
			lbx_MatchingFamilies.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			lbx_MatchingFamilies.ForeColor = Color.Blue;
			lbx_MatchingFamilies.FormattingEnabled = true;
			lbx_MatchingFamilies.ItemHeight = 15;
			lbx_MatchingFamilies.Location = new Point( 12, 9 );
			lbx_MatchingFamilies.Name = "lbx_MatchingFamilies";
			lbx_MatchingFamilies.Size = new Size( 303, 589 );
			lbx_MatchingFamilies.TabIndex = 1;
			lbx_MatchingFamilies.TabStop = false;
			lbx_MatchingFamilies.SelectedIndexChanged +=  lbx_MatchingFamilies_SelectedIndexChanged ;
			lbx_MatchingFamilies.DoubleClick +=  lbx_MatchingFamilies_DoubleClick ;
			// 
			// grp_GroupData
			// 
			grp_GroupData.BackColor = Color.FromArgb(     255,     224,     192 );
			grp_GroupData.Controls.Add( btn_GetPk );
			grp_GroupData.Controls.Add( label16 );
			grp_GroupData.Controls.Add( label5 );
			grp_GroupData.Controls.Add( tbx_FamilyName );
			grp_GroupData.Controls.Add( tbx_PkFamily );
			grp_GroupData.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			grp_GroupData.Location = new Point( 321, 9 );
			grp_GroupData.Name = "grp_GroupData";
			grp_GroupData.Size = new Size( 230, 509 );
			grp_GroupData.TabIndex = 0;
			grp_GroupData.TabStop = false;
			grp_GroupData.Text = "Family Filters";
			// 
			// btn_GetPk
			// 
			btn_GetPk.BackColor = Color.FromArgb(     255,     192,     192 );
			btn_GetPk.FlatStyle = FlatStyle.Popup;
			btn_GetPk.Font = new Font( "Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point );
			btn_GetPk.ForeColor = Color.Maroon;
			btn_GetPk.Location = new Point( 167, 25 );
			btn_GetPk.Name = "btn_GetPk";
			btn_GetPk.Size = new Size( 52, 23 );
			btn_GetPk.TabIndex = 34;
			btn_GetPk.Text = "PK";
			btn_GetPk.UseVisualStyleBackColor = false;
			btn_GetPk.Click +=  btn_GetPk_Click ;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label16.ForeColor = Color.FromArgb(     192,     0,     0 );
			label16.Location = new Point( 30, 26 );
			label16.Name = "label16";
			label16.Size = new Size( 70, 19 );
			label16.TabIndex = 3;
			label16.Text = "PkFamily";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label5.ForeColor = Color.FromArgb(     192,     0,     0 );
			label5.Location = new Point( 3, 57 );
			label5.Name = "label5";
			label5.Size = new Size( 97, 19 );
			label5.TabIndex = 18;
			label5.Text = "Family Name";
			// 
			// tbx_FamilyName
			// 
			tbx_FamilyName.BackColor = SystemColors.Window;
			tbx_FamilyName.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_FamilyName.Location = new Point( 104, 54 );
			tbx_FamilyName.Name = "tbx_FamilyName";
			tbx_FamilyName.Size = new Size( 115, 23 );
			tbx_FamilyName.TabIndex = 0;
			tbx_FamilyName.TextChanged +=  tbx_FamilyName_TextChanged ;
			// 
			// tbx_PkFamily
			// 
			tbx_PkFamily.BackColor = SystemColors.Window;
			tbx_PkFamily.Location = new Point( 104, 25 );
			tbx_PkFamily.Name = "tbx_PkFamily";
			tbx_PkFamily.Size = new Size( 57, 23 );
			tbx_PkFamily.TabIndex = 5;
			// 
			// btn_Cancel
			// 
			btn_Cancel.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Cancel.ForeColor = Color.Maroon;
			btn_Cancel.Location = new Point( 330, 564 );
			btn_Cancel.Name = "btn_Cancel";
			btn_Cancel.Size = new Size( 210, 34 );
			btn_Cancel.TabIndex = 10;
			btn_Cancel.Text = "Cancel";
			btn_Cancel.UseVisualStyleBackColor = true;
			btn_Cancel.Click +=  btn_Cancel_Click ;
			// 
			// btn_Close
			// 
			btn_Close.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Close.ForeColor = Color.Maroon;
			btn_Close.Location = new Point( 330, 524 );
			btn_Close.Name = "btn_Close";
			btn_Close.Size = new Size( 210, 34 );
			btn_Close.TabIndex = 9;
			btn_Close.Text = "Close";
			btn_Close.UseVisualStyleBackColor = true;
			btn_Close.Click +=  btn_Close_Click ;
			// 
			// DlgFindFamily
			// 
			AcceptButton = btn_Close;
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_Cancel;
			ClientSize = new Size( 561, 610 );
			Controls.Add( grp_GroupData );
			Controls.Add( btn_Cancel );
			Controls.Add( btn_Close );
			Controls.Add( lbx_MatchingFamilies );
			Name = "DlgFindFamily";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Family Finder";
			TopMost = true;
			grp_GroupData.ResumeLayout( false );
			grp_GroupData.PerformLayout();
			ResumeLayout( false );

		}

		#endregion

		private ListBox lbx_MatchingFamilies;
		private GroupBox grp_GroupData;
		private Label label16;
		private Label label5;
		private TextBox tbx_FamilyName;
		private TextBox tbx_PkFamily;
		private Button btn_Close;
		private Button btn_Cancel;
		private Button btn_GetPk;
	}
}