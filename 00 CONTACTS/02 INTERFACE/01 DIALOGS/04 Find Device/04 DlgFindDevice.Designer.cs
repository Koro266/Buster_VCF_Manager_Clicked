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
			this.lbx_MatchingDevices = new System.Windows.Forms.ListBox();
			this.grp_AddressData = new System.Windows.Forms.GroupBox();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_CloseForm = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.tbx_ShortAreaCode = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbx_TrailingDigits = new System.Windows.Forms.TextBox();
			this.tbx_LongAreaCode = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbx_PkDevice = new System.Windows.Forms.TextBox();
			this.tbx_LeadingDigits = new System.Windows.Forms.TextBox();
			this.grp_AddressData.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbx_MatchingDevices
			// 
			this.lbx_MatchingDevices.BackColor = System.Drawing.Color.MistyRose;
			this.lbx_MatchingDevices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbx_MatchingDevices.ForeColor = System.Drawing.Color.Blue;
			this.lbx_MatchingDevices.FormattingEnabled = true;
			this.lbx_MatchingDevices.ItemHeight = 15;
			this.lbx_MatchingDevices.Location = new System.Drawing.Point(12, 9);
			this.lbx_MatchingDevices.Name = "lbx_MatchingDevices";
			this.lbx_MatchingDevices.Size = new System.Drawing.Size(375, 589);
			this.lbx_MatchingDevices.TabIndex = 1;
			this.lbx_MatchingDevices.TabStop = false;
			this.lbx_MatchingDevices.Click += new System.EventHandler(this.lbx_MatchingDevices_Click);
			this.lbx_MatchingDevices.DoubleClick += new System.EventHandler(this.lbx_MatchingDevices_DoubleClick);
			// 
			// grp_AddressData
			// 
			this.grp_AddressData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.grp_AddressData.Controls.Add(this.btn_Cancel);
			this.grp_AddressData.Controls.Add(this.btn_CloseForm);
			this.grp_AddressData.Controls.Add(this.label19);
			this.grp_AddressData.Controls.Add(this.label16);
			this.grp_AddressData.Controls.Add(this.tbx_ShortAreaCode);
			this.grp_AddressData.Controls.Add(this.label5);
			this.grp_AddressData.Controls.Add(this.tbx_TrailingDigits);
			this.grp_AddressData.Controls.Add(this.tbx_LongAreaCode);
			this.grp_AddressData.Controls.Add(this.label7);
			this.grp_AddressData.Controls.Add(this.label6);
			this.grp_AddressData.Controls.Add(this.tbx_PkDevice);
			this.grp_AddressData.Controls.Add(this.tbx_LeadingDigits);
			this.grp_AddressData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.grp_AddressData.Location = new System.Drawing.Point(393, 12);
			this.grp_AddressData.Name = "grp_AddressData";
			this.grp_AddressData.Size = new System.Drawing.Size(268, 586);
			this.grp_AddressData.TabIndex = 0;
			this.grp_AddressData.TabStop = false;
			this.grp_AddressData.Text = "Device Filters";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_Cancel.ForeColor = System.Drawing.Color.Maroon;
			this.btn_Cancel.Location = new System.Drawing.Point(91, 542);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(171, 34);
			this.btn_Cancel.TabIndex = 10;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_CloseForm
			// 
			this.btn_CloseForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_CloseForm.ForeColor = System.Drawing.Color.Maroon;
			this.btn_CloseForm.Location = new System.Drawing.Point(91, 502);
			this.btn_CloseForm.Name = "btn_CloseForm";
			this.btn_CloseForm.Size = new System.Drawing.Size(171, 34);
			this.btn_CloseForm.TabIndex = 9;
			this.btn_CloseForm.Text = "Close";
			this.btn_CloseForm.UseVisualStyleBackColor = true;
			this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label19.Location = new System.Drawing.Point(9, 86);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(120, 19);
			this.label19.TabIndex = 22;
			this.label19.Text = "Short Area Code";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Enabled = false;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label16.Location = new System.Drawing.Point(52, 28);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(71, 19);
			this.label16.TabIndex = 3;
			this.label16.Text = "PkDevice";
			this.label16.Visible = false;
			// 
			// tbx_ShortAreaCode
			// 
			this.tbx_ShortAreaCode.BackColor = System.Drawing.SystemColors.Window;
			this.tbx_ShortAreaCode.Location = new System.Drawing.Point(131, 83);
			this.tbx_ShortAreaCode.Name = "tbx_ShortAreaCode";
			this.tbx_ShortAreaCode.Size = new System.Drawing.Size(115, 23);
			this.tbx_ShortAreaCode.TabIndex = 1;
			this.tbx_ShortAreaCode.TextChanged += new System.EventHandler(this.tbx_ShortAreaCode_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label5.Location = new System.Drawing.Point(12, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 19);
			this.label5.TabIndex = 18;
			this.label5.Text = "Long Area Code";
			// 
			// tbx_TrailingDigits
			// 
			this.tbx_TrailingDigits.BackColor = System.Drawing.SystemColors.Window;
			this.tbx_TrailingDigits.Location = new System.Drawing.Point(131, 142);
			this.tbx_TrailingDigits.Name = "tbx_TrailingDigits";
			this.tbx_TrailingDigits.Size = new System.Drawing.Size(115, 23);
			this.tbx_TrailingDigits.TabIndex = 3;
			this.tbx_TrailingDigits.TextChanged += new System.EventHandler(this.tbx_TrailingDigits_TextChanged);
			// 
			// tbx_LongAreaCode
			// 
			this.tbx_LongAreaCode.BackColor = System.Drawing.SystemColors.Window;
			this.tbx_LongAreaCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.tbx_LongAreaCode.Location = new System.Drawing.Point(131, 54);
			this.tbx_LongAreaCode.Name = "tbx_LongAreaCode";
			this.tbx_LongAreaCode.Size = new System.Drawing.Size(115, 23);
			this.tbx_LongAreaCode.TabIndex = 0;
			this.tbx_LongAreaCode.TextChanged += new System.EventHandler(this.tbx_LongAreaCode_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label7.Location = new System.Drawing.Point(28, 145);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(101, 19);
			this.label7.TabIndex = 37;
			this.label7.Text = "Trailing Digits";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label6.Location = new System.Drawing.Point(25, 115);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 19);
			this.label6.TabIndex = 33;
			this.label6.Text = "Leading Digits";
			// 
			// tbx_PkDevice
			// 
			this.tbx_PkDevice.BackColor = System.Drawing.SystemColors.Window;
			this.tbx_PkDevice.Enabled = false;
			this.tbx_PkDevice.Location = new System.Drawing.Point(131, 25);
			this.tbx_PkDevice.Name = "tbx_PkDevice";
			this.tbx_PkDevice.Size = new System.Drawing.Size(115, 23);
			this.tbx_PkDevice.TabIndex = 5;
			this.tbx_PkDevice.Visible = false;
			this.tbx_PkDevice.TextChanged += new System.EventHandler(this.tbx_PkDevice_TextChanged);
			// 
			// tbx_LeadingDigits
			// 
			this.tbx_LeadingDigits.BackColor = System.Drawing.SystemColors.Window;
			this.tbx_LeadingDigits.Location = new System.Drawing.Point(131, 112);
			this.tbx_LeadingDigits.Name = "tbx_LeadingDigits";
			this.tbx_LeadingDigits.Size = new System.Drawing.Size(115, 23);
			this.tbx_LeadingDigits.TabIndex = 2;
			this.tbx_LeadingDigits.TextChanged += new System.EventHandler(this.tbx_LeadingDigits_TextChanged);
			// 
			// DlgFindDevice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.CancelButton = this.btn_Cancel;
			this.ClientSize = new System.Drawing.Size(677, 610);
			this.Controls.Add(this.grp_AddressData);
			this.Controls.Add(this.lbx_MatchingDevices);
			this.Name = "DlgFindDevice";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Devices";
			this.TopMost = true;
			this.grp_AddressData.ResumeLayout(false);
			this.grp_AddressData.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ListBox lbx_MatchingDevices;
		private GroupBox grp_AddressData;
		private Label label19;
		private Label label16;
		private TextBox tbx_ShortAreaCode;
		private Label label5;
		private TextBox tbx_TrailingDigits;
		private TextBox tbx_LongAreaCode;
		private Label label7;
		private Label label6;
		private TextBox tbx_PkDevice;
		private TextBox tbx_LeadingDigits;
		private Button btn_CloseForm;
		private Button btn_Cancel;
	}
}