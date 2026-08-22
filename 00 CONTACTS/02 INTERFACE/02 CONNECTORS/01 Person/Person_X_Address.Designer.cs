namespace CONTACTS.INTERFACE.CONNECTORS
{
	partial class Person_X_Address
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
			ListViewItem listViewItem1 = new ListViewItem( new string[] { "pk", "street", "burb", "metro", "postal", "extensions", "country", "notes" }, -1, Color.FromArgb(     192,     0,     0 ), Color.Empty, null );
			grp_Person = new GroupBox();
			lvw_PersonsAddresses = new ListView();
			hdr_PkAddress = new ColumnHeader();
			hdr_StreetAddress = new ColumnHeader();
			hdr_BurbCity = new ColumnHeader();
			hdr_Metropolitan = new ColumnHeader();
			hdr_Postal = new ColumnHeader();
			hdr_Extensions = new ColumnHeader();
			hdr_Country = new ColumnHeader();
			hdr_Notes = new ColumnHeader();
			tbx_PkPerson = new TextBox();
			tbx_PersonName = new TextBox();
			btn_FindPerson = new Button();
			grp_Address = new GroupBox();
			lbx_AttachedPersons = new ListBox();
			tbx_PkAddress = new TextBox();
			lbx_Address = new ListBox();
			btn_FindAddress = new Button();
			btn_Disconnect = new Button();
			btn_Connect = new Button();
			btn_Close = new Button();
			tbx_Messages = new TextBox();
			grp_Person.SuspendLayout();
			grp_Address.SuspendLayout();
			SuspendLayout();
			// 
			// grp_Person
			// 
			grp_Person.Controls.Add( lvw_PersonsAddresses );
			grp_Person.Controls.Add( tbx_PkPerson );
			grp_Person.Controls.Add( tbx_PersonName );
			grp_Person.Controls.Add( btn_FindPerson );
			grp_Person.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			grp_Person.Location = new Point( 28, 25 );
			grp_Person.Name = "grp_Person";
			grp_Person.Size = new Size( 1166, 227 );
			grp_Person.TabIndex = 0;
			grp_Person.TabStop = false;
			grp_Person.Text = "Person";
			// 
			// lvw_PersonsAddresses
			// 
			lvw_PersonsAddresses.Columns.AddRange( new ColumnHeader[] { hdr_PkAddress, hdr_StreetAddress, hdr_BurbCity, hdr_Metropolitan, hdr_Postal, hdr_Extensions, hdr_Country, hdr_Notes } );
			lvw_PersonsAddresses.Cursor = Cursors.No;
			lvw_PersonsAddresses.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			lvw_PersonsAddresses.FullRowSelect = true;
			lvw_PersonsAddresses.GridLines = true;
			lvw_PersonsAddresses.Items.AddRange( new ListViewItem[] { listViewItem1 } );
			lvw_PersonsAddresses.Location = new Point( 23, 80 );
			lvw_PersonsAddresses.MultiSelect = false;
			lvw_PersonsAddresses.Name = "lvw_PersonsAddresses";
			lvw_PersonsAddresses.Size = new Size( 1108, 121 );
			lvw_PersonsAddresses.TabIndex = 15;
			lvw_PersonsAddresses.UseCompatibleStateImageBehavior = false;
			lvw_PersonsAddresses.View = View.Details;
			// 
			// hdr_PkAddress
			// 
			hdr_PkAddress.Text = "PK";
			hdr_PkAddress.Width = 55;
			// 
			// hdr_StreetAddress
			// 
			hdr_StreetAddress.Text = "STREET";
			hdr_StreetAddress.Width = 133;
			// 
			// hdr_BurbCity
			// 
			hdr_BurbCity.Text = "BURB";
			hdr_BurbCity.Width = 133;
			// 
			// hdr_Metropolitan
			// 
			hdr_Metropolitan.Text = "METRO";
			hdr_Metropolitan.Width = 133;
			// 
			// hdr_Postal
			// 
			hdr_Postal.Text = "POSTAL";
			hdr_Postal.Width = 133;
			// 
			// hdr_Extensions
			// 
			hdr_Extensions.Text = "EXTENSIONS";
			hdr_Extensions.Width = 133;
			// 
			// hdr_Country
			// 
			hdr_Country.Text = "COUNTRY";
			hdr_Country.Width = 144;
			// 
			// hdr_Notes
			// 
			hdr_Notes.Text = "NOTES";
			hdr_Notes.Width = 200;
			// 
			// tbx_PkPerson
			// 
			tbx_PkPerson.Location = new Point( 24, 51 );
			tbx_PkPerson.Name = "tbx_PkPerson";
			tbx_PkPerson.Size = new Size( 50, 23 );
			tbx_PkPerson.TabIndex = 3;
			// 
			// tbx_PersonName
			// 
			tbx_PersonName.Location = new Point( 79, 51 );
			tbx_PersonName.Name = "tbx_PersonName";
			tbx_PersonName.Size = new Size( 264, 23 );
			tbx_PersonName.TabIndex = 1;
			// 
			// btn_FindPerson
			// 
			btn_FindPerson.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_FindPerson.Location = new Point( 23, 22 );
			btn_FindPerson.Name = "btn_FindPerson";
			btn_FindPerson.Size = new Size( 109, 23 );
			btn_FindPerson.TabIndex = 0;
			btn_FindPerson.Text = "Find Person";
			btn_FindPerson.UseVisualStyleBackColor = true;
			btn_FindPerson.Click +=  btn_FindPerson_Click ;
			// 
			// grp_Address
			// 
			grp_Address.Controls.Add( lbx_AttachedPersons );
			grp_Address.Controls.Add( tbx_PkAddress );
			grp_Address.Controls.Add( lbx_Address );
			grp_Address.Controls.Add( btn_FindAddress );
			grp_Address.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			grp_Address.Location = new Point( 31, 258 );
			grp_Address.Name = "grp_Address";
			grp_Address.Size = new Size( 935, 226 );
			grp_Address.TabIndex = 1;
			grp_Address.TabStop = false;
			grp_Address.Text = "Address";
			// 
			// lbx_AttachedPersons
			// 
			lbx_AttachedPersons.FormattingEnabled = true;
			lbx_AttachedPersons.ItemHeight = 15;
			lbx_AttachedPersons.Location = new Point( 370, 51 );
			lbx_AttachedPersons.Name = "lbx_AttachedPersons";
			lbx_AttachedPersons.Size = new Size( 501, 154 );
			lbx_AttachedPersons.TabIndex = 3;
			// 
			// tbx_PkAddress
			// 
			tbx_PkAddress.Location = new Point( 23, 51 );
			tbx_PkAddress.Name = "tbx_PkAddress";
			tbx_PkAddress.Size = new Size( 50, 23 );
			tbx_PkAddress.TabIndex = 2;
			// 
			// lbx_Address
			// 
			lbx_Address.FormattingEnabled = true;
			lbx_Address.ItemHeight = 15;
			lbx_Address.Location = new Point( 79, 51 );
			lbx_Address.Name = "lbx_Address";
			lbx_Address.Size = new Size( 264, 154 );
			lbx_Address.TabIndex = 1;
			// 
			// btn_FindAddress
			// 
			btn_FindAddress.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_FindAddress.Location = new Point( 23, 22 );
			btn_FindAddress.Name = "btn_FindAddress";
			btn_FindAddress.Size = new Size( 109, 23 );
			btn_FindAddress.TabIndex = 0;
			btn_FindAddress.Text = "Find Address";
			btn_FindAddress.UseVisualStyleBackColor = true;
			btn_FindAddress.Click +=  btn_FindAddress_Click ;
			// 
			// btn_Disconnect
			// 
			btn_Disconnect.Font = new Font( "Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Disconnect.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_Disconnect.Location = new Point( 982, 413 );
			btn_Disconnect.Name = "btn_Disconnect";
			btn_Disconnect.Size = new Size( 121, 32 );
			btn_Disconnect.TabIndex = 1;
			btn_Disconnect.Text = "Disconnect";
			btn_Disconnect.UseVisualStyleBackColor = true;
			btn_Disconnect.Click +=  btn_Disconnect_Click ;
			// 
			// btn_Connect
			// 
			btn_Connect.Font = new Font( "Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Connect.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_Connect.Location = new Point( 982, 375 );
			btn_Connect.Name = "btn_Connect";
			btn_Connect.Size = new Size( 121, 32 );
			btn_Connect.TabIndex = 0;
			btn_Connect.Text = "Connect";
			btn_Connect.UseVisualStyleBackColor = true;
			btn_Connect.Click +=  btn_Connect_Click ;
			// 
			// btn_Close
			// 
			btn_Close.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Close.ForeColor = Color.Maroon;
			btn_Close.Location = new Point( 818, 527 );
			btn_Close.Name = "btn_Close";
			btn_Close.Size = new Size( 133, 34 );
			btn_Close.TabIndex = 8;
			btn_Close.Text = "Close";
			btn_Close.UseVisualStyleBackColor = true;
			btn_Close.Click +=  btn_Close_Click ;
			// 
			// tbx_Messages
			// 
			tbx_Messages.BackColor = Color.FromArgb(     255,     255,     192 );
			tbx_Messages.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Messages.ForeColor = Color.ForestGreen;
			tbx_Messages.Location = new Point( 31, 517 );
			tbx_Messages.Name = "tbx_Messages";
			tbx_Messages.Size = new Size( 718, 23 );
			tbx_Messages.TabIndex = 142;
			tbx_Messages.TabStop = false;
			// 
			// Person_X_Address
			// 
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_Close;
			ClientSize = new Size( 1206, 573 );
			Controls.Add( tbx_Messages );
			Controls.Add( btn_Disconnect );
			Controls.Add( btn_Connect );
			Controls.Add( btn_Close );
			Controls.Add( grp_Address );
			Controls.Add( grp_Person );
			Name = "Person_X_Address";
			Text = "Person_X_Address";
			grp_Person.ResumeLayout( false );
			grp_Person.PerformLayout();
			grp_Address.ResumeLayout( false );
			grp_Address.PerformLayout();
			ResumeLayout( false );
			PerformLayout();
		}

		#endregion

		private GroupBox grp_Person;
		private Button btn_FindPerson;
		private GroupBox grp_Address;
		private Button btn_FindAddress;
		private Button btn_Disconnect;
		private Button btn_Connect;
		private Button btn_Close;
		private TextBox tbx_PersonName;
		private ListBox lbx_Address;
		private TextBox tbx_PkPerson;
		private TextBox tbx_PkAddress;
		private ListBox lbx_AttachedPersons;
		private ListView lvw_PersonsAddresses;
		private ColumnHeader hdr_StreetAddress;
		private ColumnHeader hdr_BurbCity;
		private ColumnHeader hdr_Metropolitan;
		private ColumnHeader hdr_Postal;
		private ColumnHeader hdr_Extensions;
		private ColumnHeader hdr_Country;
		private ColumnHeader hdr_Notes;
		private ColumnHeader hdr_PkAddress;
		private TextBox tbx_Messages;
	}
}