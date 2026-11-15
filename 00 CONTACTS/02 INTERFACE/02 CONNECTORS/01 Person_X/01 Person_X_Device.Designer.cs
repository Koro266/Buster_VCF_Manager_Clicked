namespace CONTACTS.INTERFACE.CONNECTORS
{
	partial class Person_X_Device
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
			tbx_PkPerson = new TextBox();
			tbx_PersonName = new TextBox();
			btn_FindPerson = new Button();
			btn_Connect = new Button();
			lbx_Device = new ListBox();
			grp_Address = new GroupBox();
			tbx_PkDevice = new TextBox();
			btn_FindDevice = new Button();
			btn_Disconnect = new Button();
			btn_Close = new Button();
			tbx_Messages = new TextBox();
			grp_Person.SuspendLayout();
			grp_Address.SuspendLayout();
			SuspendLayout();
			// 
			// grp_Person
			// 
			grp_Person.Controls.Add( tbx_PkPerson );
			grp_Person.Controls.Add( tbx_PersonName );
			grp_Person.Controls.Add( btn_FindPerson );
			grp_Person.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			grp_Person.Location = new Point( 28, 25 );
			grp_Person.Name = "grp_Person";
			grp_Person.Size = new Size( 356, 92 );
			grp_Person.TabIndex = 0;
			grp_Person.TabStop = false;
			grp_Person.Text = "Person";
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
			// btn_Connect
			// 
			btn_Connect.Font = new Font( "Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Connect.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_Connect.Location = new Point( 51, 126 );
			btn_Connect.Name = "btn_Connect";
			btn_Connect.Size = new Size( 320, 32 );
			btn_Connect.TabIndex = 0;
			btn_Connect.Text = "Connect Person to Device";
			btn_Connect.UseVisualStyleBackColor = true;
			btn_Connect.Click +=  btn_Connect_Click ;
			// 
			// lbx_Device
			// 
			lbx_Device.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbx_Device.FormattingEnabled = true;
			lbx_Device.ItemHeight = 15;
			lbx_Device.Location = new Point( 79, 51 );
			lbx_Device.Name = "lbx_Device";
			lbx_Device.Size = new Size( 264, 169 );
			lbx_Device.TabIndex = 1;
			// 
			// grp_Address
			// 
			grp_Address.Controls.Add( lbx_Device );
			grp_Address.Controls.Add( tbx_PkDevice );
			grp_Address.Controls.Add( btn_FindDevice );
			grp_Address.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			grp_Address.Location = new Point( 28, 161 );
			grp_Address.Name = "grp_Address";
			grp_Address.Size = new Size( 356, 226 );
			grp_Address.TabIndex = 1;
			grp_Address.TabStop = false;
			grp_Address.Text = "Device";
			// 
			// tbx_PkDevice
			// 
			tbx_PkDevice.Location = new Point( 23, 51 );
			tbx_PkDevice.Name = "tbx_PkDevice";
			tbx_PkDevice.Size = new Size( 50, 23 );
			tbx_PkDevice.TabIndex = 2;
			// 
			// btn_FindDevice
			// 
			btn_FindDevice.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_FindDevice.Location = new Point( 23, 22 );
			btn_FindDevice.Name = "btn_FindDevice";
			btn_FindDevice.Size = new Size( 109, 23 );
			btn_FindDevice.TabIndex = 0;
			btn_FindDevice.Text = "Find Device";
			btn_FindDevice.UseVisualStyleBackColor = true;
			btn_FindDevice.Click +=  btn_FindAddress_Click ;
			// 
			// btn_Disconnect
			// 
			btn_Disconnect.Font = new Font( "Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Disconnect.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_Disconnect.Location = new Point( 898, -84 );
			btn_Disconnect.Name = "btn_Disconnect";
			btn_Disconnect.Size = new Size( 121, 32 );
			btn_Disconnect.TabIndex = 1;
			btn_Disconnect.Text = "Disconnect";
			btn_Disconnect.UseVisualStyleBackColor = true;
			// 
			// btn_Close
			// 
			btn_Close.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Close.ForeColor = Color.Maroon;
			btn_Close.Location = new Point( 1153, 506 );
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
			tbx_Messages.Location = new Point( 28, 393 );
			tbx_Messages.Name = "tbx_Messages";
			tbx_Messages.Size = new Size( 356, 23 );
			tbx_Messages.TabIndex = 142;
			tbx_Messages.TabStop = false;
			// 
			// Person_X_Device
			// 
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_Close;
			ClientSize = new Size( 402, 428 );
			Controls.Add( tbx_Messages );
			Controls.Add( btn_Connect );
			Controls.Add( btn_Disconnect );
			Controls.Add( btn_Close );
			Controls.Add( grp_Address );
			Controls.Add( grp_Person );
			Name = "Person_X_Device";
			Text = "Person_X_Device";
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
		private Button btn_FindDevice;
		private Button btn_Disconnect;
		private Button btn_Connect;
		private Button btn_Close;
		private TextBox tbx_PersonName;
		private ListBox lbx_Device;
		private TextBox tbx_PkPerson;
		private TextBox tbx_PkDevice;
		private TextBox tbx_Messages;
	}
}