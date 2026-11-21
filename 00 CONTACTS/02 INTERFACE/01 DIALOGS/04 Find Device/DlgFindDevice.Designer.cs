namespace CONTACTS.INTERFACE.DIALOGS
{
	public partial class DlgFindDevice
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
			ListViewItem listViewItem1 = new ListViewItem( new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem( null, "1234" ), new ListViewItem.ListViewSubItem( null, "+64 27 266 1200", Color.FromArgb(     192,     0,     0 ), SystemColors.Window, new Font( "Rockwell", 9.75F, FontStyle.Bold, GraphicsUnit.Point ) ), new ListViewItem.ListViewSubItem( null, "NZ, 64" ), new ListViewItem.ListViewSubItem( null, "27, 027" ), new ListViewItem.ListViewSubItem( null, "266" ), new ListViewItem.ListViewSubItem( null, "1200" ), new ListViewItem.ListViewSubItem( null, "Mobile", Color.FromArgb(     192,     0,     0 ), SystemColors.Window, new Font( "Rockwell", 8.25F, FontStyle.Bold, GraphicsUnit.Point ) ), new ListViewItem.ListViewSubItem( null, "Cell", Color.FromArgb(     192,     0,     0 ), SystemColors.Window, new Font( "Rockwell", 8.25F, FontStyle.Bold, GraphicsUnit.Point ) ), new ListViewItem.ListViewSubItem( null, "Goods Shed, Naenae.Rangi's cell: 022 041 5054." ) }, -1 );
			grp_DeviceData = new GroupBox();
			tbx_Location = new TextBox();
			tbx_Type = new TextBox();
			tbx_CountryName = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			label19 = new Label();
			tbx_ShortAreaCode = new TextBox();
			label5 = new Label();
			tbx_TrailingDigits = new TextBox();
			tbx_LongAreaCode = new TextBox();
			label7 = new Label();
			label6 = new Label();
			tbx_LeadingDigits = new TextBox();
			btn_Cancel = new Button();
			btn_CloseForm = new Button();
			lvw_MatchingDevices = new ListView();
			ch_PkDevice = new ColumnHeader();
			ch_DialNumber = new ColumnHeader();
			ch_Country = new ColumnHeader();
			ch_AreaCode = new ColumnHeader();
			ch_LeadingDigits = new ColumnHeader();
			ch_TrailingDigits = new ColumnHeader();
			ch_DeviceLocation = new ColumnHeader();
			ch_DeviceType = new ColumnHeader();
			ch_Notes = new ColumnHeader();
			grp_DeviceData.SuspendLayout();
			SuspendLayout();
			// 
			// grp_DeviceData
			// 
			grp_DeviceData.BackColor = Color.FromArgb(     255,     224,     192 );
			grp_DeviceData.Controls.Add( tbx_Location );
			grp_DeviceData.Controls.Add( tbx_Type );
			grp_DeviceData.Controls.Add( tbx_CountryName );
			grp_DeviceData.Controls.Add( label3 );
			grp_DeviceData.Controls.Add( label2 );
			grp_DeviceData.Controls.Add( label1 );
			grp_DeviceData.Controls.Add( label19 );
			grp_DeviceData.Controls.Add( tbx_ShortAreaCode );
			grp_DeviceData.Controls.Add( label5 );
			grp_DeviceData.Controls.Add( tbx_TrailingDigits );
			grp_DeviceData.Controls.Add( tbx_LongAreaCode );
			grp_DeviceData.Controls.Add( label7 );
			grp_DeviceData.Controls.Add( label6 );
			grp_DeviceData.Controls.Add( tbx_LeadingDigits );
			grp_DeviceData.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			grp_DeviceData.Location = new Point( 12, 12 );
			grp_DeviceData.Name = "grp_DeviceData";
			grp_DeviceData.Size = new Size( 255, 242 );
			grp_DeviceData.TabIndex = 0;
			grp_DeviceData.TabStop = false;
			grp_DeviceData.Text = "Device Filters";
			// 
			// tbx_Location
			// 
			tbx_Location.BackColor = SystemColors.Window;
			tbx_Location.Location = new Point( 124, 140 );
			tbx_Location.Name = "tbx_Location";
			tbx_Location.Size = new Size( 115, 23 );
			tbx_Location.TabIndex = 43;
			tbx_Location.TextChanged +=  tbx_Location_TextChanged ;
			// 
			// tbx_Type
			// 
			tbx_Type.BackColor = SystemColors.Window;
			tbx_Type.Location = new Point( 124, 169 );
			tbx_Type.Name = "tbx_Type";
			tbx_Type.Size = new Size( 115, 23 );
			tbx_Type.TabIndex = 42;
			tbx_Type.TextChanged +=  tbx_Type_TextChanged ;
			// 
			// tbx_CountryName
			// 
			tbx_CountryName.BackColor = SystemColors.Window;
			tbx_CountryName.Location = new Point( 124, 198 );
			tbx_CountryName.Name = "tbx_CountryName";
			tbx_CountryName.Size = new Size( 115, 23 );
			tbx_CountryName.TabIndex = 41;
			tbx_CountryName.TextChanged +=  tbx_CountryName_TextChanged ;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label3.ForeColor = Color.FromArgb(     192,     0,     0 );
			label3.Location = new Point( 19, 200 );
			label3.Name = "label3";
			label3.Size = new Size( 102, 19 );
			label3.TabIndex = 40;
			label3.Text = "Country Code";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label2.ForeColor = Color.FromArgb(     192,     0,     0 );
			label2.Location = new Point( 81, 172 );
			label2.Name = "label2";
			label2.Size = new Size( 41, 19 );
			label2.TabIndex = 39;
			label2.Text = "Type";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label1.ForeColor = Color.FromArgb(     192,     0,     0 );
			label1.Location = new Point( 56, 143 );
			label1.Name = "label1";
			label1.Size = new Size( 66, 19 );
			label1.TabIndex = 38;
			label1.Text = "Location";
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label19.ForeColor = Color.FromArgb(     192,     0,     0 );
			label19.Location = new Point( 2, 54 );
			label19.Name = "label19";
			label19.Size = new Size( 120, 19 );
			label19.TabIndex = 22;
			label19.Text = "Short Area Code";
			// 
			// tbx_ShortAreaCode
			// 
			tbx_ShortAreaCode.BackColor = SystemColors.Window;
			tbx_ShortAreaCode.Location = new Point( 124, 51 );
			tbx_ShortAreaCode.Name = "tbx_ShortAreaCode";
			tbx_ShortAreaCode.Size = new Size( 115, 23 );
			tbx_ShortAreaCode.TabIndex = 1;
			tbx_ShortAreaCode.TextChanged +=  tbx_ShortAreaCode_TextChanged ;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label5.ForeColor = Color.FromArgb(     192,     0,     0 );
			label5.Location = new Point( 5, 25 );
			label5.Name = "label5";
			label5.Size = new Size( 117, 19 );
			label5.TabIndex = 18;
			label5.Text = "Long Area Code";
			// 
			// tbx_TrailingDigits
			// 
			tbx_TrailingDigits.BackColor = SystemColors.Window;
			tbx_TrailingDigits.Location = new Point( 124, 110 );
			tbx_TrailingDigits.Name = "tbx_TrailingDigits";
			tbx_TrailingDigits.Size = new Size( 115, 23 );
			tbx_TrailingDigits.TabIndex = 3;
			tbx_TrailingDigits.TextChanged +=  tbx_TrailingDigits_TextChanged ;
			// 
			// tbx_LongAreaCode
			// 
			tbx_LongAreaCode.BackColor = SystemColors.Window;
			tbx_LongAreaCode.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_LongAreaCode.Location = new Point( 124, 22 );
			tbx_LongAreaCode.Name = "tbx_LongAreaCode";
			tbx_LongAreaCode.Size = new Size( 115, 23 );
			tbx_LongAreaCode.TabIndex = 0;
			tbx_LongAreaCode.TextChanged +=  tbx_LongAreaCode_TextChanged ;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label7.ForeColor = Color.FromArgb(     192,     0,     0 );
			label7.Location = new Point( 21, 113 );
			label7.Name = "label7";
			label7.Size = new Size( 101, 19 );
			label7.TabIndex = 37;
			label7.Text = "Trailing Digits";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label6.ForeColor = Color.FromArgb(     192,     0,     0 );
			label6.Location = new Point( 18, 83 );
			label6.Name = "label6";
			label6.Size = new Size( 104, 19 );
			label6.TabIndex = 33;
			label6.Text = "Leading Digits";
			// 
			// tbx_LeadingDigits
			// 
			tbx_LeadingDigits.BackColor = SystemColors.Window;
			tbx_LeadingDigits.Location = new Point( 124, 80 );
			tbx_LeadingDigits.Name = "tbx_LeadingDigits";
			tbx_LeadingDigits.Size = new Size( 115, 23 );
			tbx_LeadingDigits.TabIndex = 2;
			tbx_LeadingDigits.TextChanged +=  tbx_LeadingDigits_TextChanged ;
			// 
			// btn_Cancel
			// 
			btn_Cancel.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Cancel.ForeColor = Color.Maroon;
			btn_Cancel.Location = new Point( 997, 635 );
			btn_Cancel.Name = "btn_Cancel";
			btn_Cancel.Size = new Size( 122, 34 );
			btn_Cancel.TabIndex = 10;
			btn_Cancel.Text = "Cancel";
			btn_Cancel.UseVisualStyleBackColor = true;
			btn_Cancel.Click +=  btn_Cancel_Click ;
			// 
			// btn_CloseForm
			// 
			btn_CloseForm.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_CloseForm.ForeColor = Color.Maroon;
			btn_CloseForm.Location = new Point( 1125, 635 );
			btn_CloseForm.Name = "btn_CloseForm";
			btn_CloseForm.Size = new Size( 122, 34 );
			btn_CloseForm.TabIndex = 9;
			btn_CloseForm.Text = "Close";
			btn_CloseForm.UseVisualStyleBackColor = true;
			btn_CloseForm.Click +=  btn_CloseForm_Click ;
			// 
			// lvw_MatchingDevices
			// 
			lvw_MatchingDevices.Columns.AddRange( new ColumnHeader[] { ch_PkDevice, ch_DialNumber, ch_Country, ch_AreaCode, ch_LeadingDigits, ch_TrailingDigits, ch_DeviceLocation, ch_DeviceType, ch_Notes } );
			lvw_MatchingDevices.Font = new Font( "Rockwell", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			lvw_MatchingDevices.ForeColor = Color.FromArgb(     192,     0,     0 );
			lvw_MatchingDevices.FullRowSelect = true;
			lvw_MatchingDevices.GridLines = true;
			lvw_MatchingDevices.Items.AddRange( new ListViewItem[] { listViewItem1 } );
			lvw_MatchingDevices.Location = new Point( 273, 21 );
			lvw_MatchingDevices.Name = "lvw_MatchingDevices";
			lvw_MatchingDevices.Size = new Size( 974, 608 );
			lvw_MatchingDevices.TabIndex = 11;
			lvw_MatchingDevices.UseCompatibleStateImageBehavior = false;
			lvw_MatchingDevices.View = View.Details;
			lvw_MatchingDevices.SelectedIndexChanged +=  lvw_MatchingDevices_SelectedIndexChanged ;
			// 
			// ch_PkDevice
			// 
			ch_PkDevice.Text = "PK";
			ch_PkDevice.Width = 50;
			// 
			// ch_DialNumber
			// 
			ch_DialNumber.Text = "Dial Number";
			ch_DialNumber.Width = 125;
			// 
			// ch_Country
			// 
			ch_Country.Text = "Country";
			ch_Country.Width = 70;
			// 
			// ch_AreaCode
			// 
			ch_AreaCode.Text = "Area Code";
			ch_AreaCode.Width = 80;
			// 
			// ch_LeadingDigits
			// 
			ch_LeadingDigits.Text = "Leading";
			ch_LeadingDigits.Width = 70;
			// 
			// ch_TrailingDigits
			// 
			ch_TrailingDigits.Text = "Trailing";
			ch_TrailingDigits.Width = 75;
			// 
			// ch_DeviceLocation
			// 
			ch_DeviceLocation.Text = "Location";
			ch_DeviceLocation.Width = 80;
			// 
			// ch_DeviceType
			// 
			ch_DeviceType.Text = "Type";
			ch_DeviceType.Width = 85;
			// 
			// ch_Notes
			// 
			ch_Notes.Text = "Notes";
			ch_Notes.Width = 300;
			// 
			// DlgFindDevice
			// 
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_Cancel;
			ClientSize = new Size( 1270, 682 );
			Controls.Add( lvw_MatchingDevices );
			Controls.Add( btn_Cancel );
			Controls.Add( grp_DeviceData );
			Controls.Add( btn_CloseForm );
			Name = "DlgFindDevice";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Find Devices";
			TopMost = true;
			grp_DeviceData.ResumeLayout( false );
			grp_DeviceData.PerformLayout();
			ResumeLayout( false );

		}

		#endregion
		private GroupBox grp_DeviceData;
		private Label label19;
		private TextBox tbx_ShortAreaCode;
		private Label label5;
		private TextBox tbx_TrailingDigits;
		private TextBox tbx_LongAreaCode;
		private Label label7;
		private Label label6;
		private TextBox tbx_LeadingDigits;
		private Button btn_CloseForm;
		private Button btn_Cancel;
		private ListView lvw_MatchingDevices;
		private ColumnHeader ch_PkDevice;
		private ColumnHeader ch_DialNumber;
		private ColumnHeader ch_AreaCode;
		private ColumnHeader ch_LeadingDigits;
		private ColumnHeader ch_TrailingDigits;
		private ColumnHeader ch_DeviceLocation;
		private ColumnHeader ch_DeviceType;
		private ColumnHeader ch_Notes;
		private Label label2;
		private Label label1;
		private ColumnHeader ch_Country;
		private Label label3;
		private TextBox tbx_Location;
		private TextBox tbx_Type;
		private TextBox tbx_CountryName;
	}
}