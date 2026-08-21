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
			grp_Person = new GroupBox();
			lbx_AttachedAddresses = new ListBox();
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
			grp_Person.SuspendLayout();
			grp_Address.SuspendLayout();
			SuspendLayout();
			// 
			// grp_Person
			// 
			grp_Person.Controls.Add( lbx_AttachedAddresses );
			grp_Person.Controls.Add( tbx_PkPerson );
			grp_Person.Controls.Add( tbx_PersonName );
			grp_Person.Controls.Add( btn_FindPerson );
			grp_Person.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			grp_Person.Location = new Point( 28, 25 );
			grp_Person.Name = "grp_Person";
			grp_Person.Size = new Size( 935, 227 );
			grp_Person.TabIndex = 0;
			grp_Person.TabStop = false;
			grp_Person.Text = "Person";
			// 
			// lbx_AttachedAddresses
			// 
			lbx_AttachedAddresses.FormattingEnabled = true;
			lbx_AttachedAddresses.ItemHeight = 15;
			lbx_AttachedAddresses.Location = new Point( 370, 22 );
			lbx_AttachedAddresses.Name = "lbx_AttachedAddresses";
			lbx_AttachedAddresses.Size = new Size( 553, 94 );
			lbx_AttachedAddresses.TabIndex = 4;
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
			// Person_X_Address
			// 
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_Close;
			ClientSize = new Size( 1206, 573 );
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
		private ListBox lbx_AttachedAddresses;
		private ListBox lbx_AttachedPersons;
	}
}