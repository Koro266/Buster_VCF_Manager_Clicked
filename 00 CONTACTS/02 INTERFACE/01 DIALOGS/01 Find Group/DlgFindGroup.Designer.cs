namespace CONTACTS.INTERFACE.DIALOGS
{
	public partial class DlgFindGroup
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
			grp_GroupData = new GroupBox();
			label5 = new Label();
			tbx_GroupName = new TextBox();
			btn_Cancel = new Button();
			btn_Close = new Button();
			grp_GroupData.SuspendLayout();
			SuspendLayout();
			// 
			// lbx_MatchingGroups
			// 
			lbx_MatchingGroups.BackColor = Color.MistyRose;
			lbx_MatchingGroups.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			lbx_MatchingGroups.ForeColor = Color.Blue;
			lbx_MatchingGroups.FormattingEnabled = true;
			lbx_MatchingGroups.ItemHeight = 15;
			lbx_MatchingGroups.Location = new Point( 15, 79 );
			lbx_MatchingGroups.Name = "lbx_MatchingGroups";
			lbx_MatchingGroups.Size = new Size( 387, 514 );
			lbx_MatchingGroups.TabIndex = 0;
			lbx_MatchingGroups.TabStop = false;
			lbx_MatchingGroups.SelectedIndexChanged +=  lbx_MatchingGroups_SelectedIndexChanged ;
			lbx_MatchingGroups.DoubleClick +=  lbx_MatchingGroups_DoubleClick ;
			// 
			// grp_GroupData
			// 
			grp_GroupData.BackColor = Color.FromArgb(     255,     224,     192 );
			grp_GroupData.Controls.Add( label5 );
			grp_GroupData.Controls.Add( tbx_GroupName );
			grp_GroupData.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			grp_GroupData.Location = new Point( 12, 12 );
			grp_GroupData.Name = "grp_GroupData";
			grp_GroupData.Size = new Size( 404, 61 );
			grp_GroupData.TabIndex = 0;
			grp_GroupData.TabStop = false;
			grp_GroupData.Text = "Group Filters";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label5.ForeColor = Color.FromArgb(     192,     0,     0 );
			label5.Location = new Point( 3, 25 );
			label5.Name = "label5";
			label5.Size = new Size( 95, 19 );
			label5.TabIndex = 18;
			label5.Text = "Group Name";
			// 
			// tbx_GroupName
			// 
			tbx_GroupName.BackColor = SystemColors.Window;
			tbx_GroupName.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_GroupName.Location = new Point( 104, 22 );
			tbx_GroupName.Name = "tbx_GroupName";
			tbx_GroupName.Size = new Size( 286, 23 );
			tbx_GroupName.TabIndex = 1;
			tbx_GroupName.TextChanged +=  tbx_Group_TextChanged ;
			// 
			// btn_Cancel
			// 
			btn_Cancel.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Cancel.ForeColor = Color.Maroon;
			btn_Cancel.Location = new Point( 408, 560 );
			btn_Cancel.Name = "btn_Cancel";
			btn_Cancel.Size = new Size( 120, 34 );
			btn_Cancel.TabIndex = 2;
			btn_Cancel.Text = "Cancel";
			btn_Cancel.UseVisualStyleBackColor = true;
			btn_Cancel.Click +=  btn_Cancel_Click ;
			// 
			// btn_Close
			// 
			btn_Close.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Close.ForeColor = Color.Maroon;
			btn_Close.Location = new Point( 408, 520 );
			btn_Close.Name = "btn_Close";
			btn_Close.Size = new Size( 120, 34 );
			btn_Close.TabIndex = 1;
			btn_Close.Text = "Close";
			btn_Close.UseVisualStyleBackColor = true;
			btn_Close.Click +=  btn_Close_Click ;
			// 
			// DlgFindGroup
			// 
			AcceptButton = btn_Close;
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_Cancel;
			ClientSize = new Size( 543, 606 );
			Controls.Add( grp_GroupData );
			Controls.Add( btn_Cancel );
			Controls.Add( lbx_MatchingGroups );
			Controls.Add( btn_Close );
			Name = "DlgFindGroup";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Group Finder";
			TopMost = true;
			grp_GroupData.ResumeLayout( false );
			grp_GroupData.PerformLayout();
			ResumeLayout( false );

		}

		#endregion

		private ListBox lbx_MatchingGroups;
		private GroupBox grp_GroupData;
		private Label label5;
		private TextBox tbx_GroupName;
		private Button btn_Close;
		private Button btn_Cancel;
	}
}