namespace CONTACTS.INTERFACE.DIALOGS
{
	public partial class DlgFindAddress
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
			ListViewItem listViewItem1 = new ListViewItem( new string[] { "287", "24 Corlett Rd", "Plimmerton, Porirua", "WELLINGTON", "PO Box 1234, 5024", "Level 1", "New Zealand" }, -1 );
			btn_Cancel = new Button();
			tbx_EXT_Assemblage = new TextBox();
			label15 = new Label();
			tbx_EXT_Unit = new TextBox();
			btn_CloseForm = new Button();
			lbl_POBox = new Label();
			label14 = new Label();
			tbx_BOX_Number = new TextBox();
			tbx_EXT_Level = new TextBox();
			label25 = new Label();
			label19 = new Label();
			label16 = new Label();
			label13 = new Label();
			tbx_STR_StreetName = new TextBox();
			tbx_ZIP_PostalCode = new TextBox();
			label5 = new Label();
			tbx_LOC_City = new TextBox();
			tbx_STR_HouseNumber = new TextBox();
			label4 = new Label();
			label7 = new Label();
			label6 = new Label();
			tbx_BOX_RuralDelivery = new TextBox();
			tbx_LOC_Suburb = new TextBox();
			tbx_EXT_Extension = new TextBox();
			lvw_MatchingAddresses = new ListView();
			hdr_PrimaryKey = new ColumnHeader();
			hdr_StreetAddress = new ColumnHeader();
			hdr_BurbCity = new ColumnHeader();
			hdr_Metropolitan = new ColumnHeader();
			hdr_Postal = new ColumnHeader();
			hdr_Extensions = new ColumnHeader();
			hdr_Country = new ColumnHeader();
			tbx_PRV_Abbreviation = new TextBox();
			label1 = new Label();
			label2 = new Label();
			tbx_MET_Metropolitan = new TextBox();
			label3 = new Label();
			tbx_PRV_Name = new TextBox();
			SuspendLayout();
			// 
			// btn_Cancel
			// 
			btn_Cancel.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Cancel.ForeColor = Color.Maroon;
			btn_Cancel.Location = new Point( 1124, 431 );
			btn_Cancel.Name = "btn_Cancel";
			btn_Cancel.Size = new Size( 93, 34 );
			btn_Cancel.TabIndex = 15;
			btn_Cancel.Text = "Cancel";
			btn_Cancel.UseVisualStyleBackColor = true;
			btn_Cancel.Click +=  btn_Cancel_Click ;
			// 
			// tbx_EXT_Assemblage
			// 
			tbx_EXT_Assemblage.BackColor = SystemColors.Window;
			tbx_EXT_Assemblage.Location = new Point( 135, 222 );
			tbx_EXT_Assemblage.Name = "tbx_EXT_Assemblage";
			tbx_EXT_Assemblage.Size = new Size( 115, 23 );
			tbx_EXT_Assemblage.TabIndex = 7;
			tbx_EXT_Assemblage.TextChanged +=  tbx_EXT_Assemblage_TextChanged ;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label15.ForeColor = Color.FromArgb(     192,     0,     0 );
			label15.Location = new Point( 91, 286 );
			label15.Name = "label15";
			label15.Size = new Size( 36, 19 );
			label15.TabIndex = 12;
			label15.Text = "Unit";
			// 
			// tbx_EXT_Unit
			// 
			tbx_EXT_Unit.BackColor = SystemColors.Window;
			tbx_EXT_Unit.Location = new Point( 135, 282 );
			tbx_EXT_Unit.Name = "tbx_EXT_Unit";
			tbx_EXT_Unit.Size = new Size( 115, 23 );
			tbx_EXT_Unit.TabIndex = 9;
			tbx_EXT_Unit.TextChanged +=  tbx_EXT_Unit_TextChanged ;
			// 
			// btn_CloseForm
			// 
			btn_CloseForm.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_CloseForm.ForeColor = Color.Maroon;
			btn_CloseForm.Location = new Point( 1223, 431 );
			btn_CloseForm.Name = "btn_CloseForm";
			btn_CloseForm.Size = new Size( 93, 34 );
			btn_CloseForm.TabIndex = 16;
			btn_CloseForm.Text = "Close";
			btn_CloseForm.UseVisualStyleBackColor = true;
			btn_CloseForm.Click +=  btn_CloseForm_Click ;
			// 
			// lbl_POBox
			// 
			lbl_POBox.AutoSize = true;
			lbl_POBox.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_POBox.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_POBox.Location = new Point( 68, 136 );
			lbl_POBox.Name = "lbl_POBox";
			lbl_POBox.Size = new Size( 59, 19 );
			lbl_POBox.TabIndex = 0;
			lbl_POBox.Text = "PO Box";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label14.ForeColor = Color.FromArgb(     192,     0,     0 );
			label14.Location = new Point( 83, 256 );
			label14.Name = "label14";
			label14.Size = new Size( 44, 19 );
			label14.TabIndex = 9;
			label14.Text = "Level";
			// 
			// tbx_BOX_Number
			// 
			tbx_BOX_Number.BackColor = SystemColors.Window;
			tbx_BOX_Number.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_BOX_Number.Location = new Point( 135, 132 );
			tbx_BOX_Number.Name = "tbx_BOX_Number";
			tbx_BOX_Number.Size = new Size( 115, 23 );
			tbx_BOX_Number.TabIndex = 4;
			tbx_BOX_Number.TextChanged +=  tbx_BOX_Number_TextChanged ;
			// 
			// tbx_EXT_Level
			// 
			tbx_EXT_Level.BackColor = SystemColors.Window;
			tbx_EXT_Level.Location = new Point( 135, 252 );
			tbx_EXT_Level.Name = "tbx_EXT_Level";
			tbx_EXT_Level.Size = new Size( 115, 23 );
			tbx_EXT_Level.TabIndex = 8;
			tbx_EXT_Level.TextChanged +=  tbx_EXT_Level_TextChanged ;
			// 
			// label25
			// 
			label25.AutoSize = true;
			label25.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label25.ForeColor = Color.FromArgb(     192,     0,     0 );
			label25.Location = new Point( 38, 196 );
			label25.Name = "label25";
			label25.Size = new Size( 89, 19 );
			label25.TabIndex = 50;
			label25.Text = "Postal Code";
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label19.ForeColor = Color.FromArgb(     192,     0,     0 );
			label19.Location = new Point( 34, 46 );
			label19.Name = "label19";
			label19.Size = new Size( 93, 19 );
			label19.TabIndex = 22;
			label19.Text = "Street Name";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label16.ForeColor = Color.FromArgb(     192,     0,     0 );
			label16.Location = new Point( 22, 166 );
			label16.Name = "label16";
			label16.Size = new Size( 105, 19 );
			label16.TabIndex = 3;
			label16.Text = "Rural Delivery";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label13.ForeColor = Color.FromArgb(     192,     0,     0 );
			label13.Location = new Point( 37, 226 );
			label13.Name = "label13";
			label13.Size = new Size( 90, 19 );
			label13.TabIndex = 6;
			label13.Text = "Assemblage";
			// 
			// tbx_STR_StreetName
			// 
			tbx_STR_StreetName.BackColor = SystemColors.Window;
			tbx_STR_StreetName.Location = new Point( 135, 42 );
			tbx_STR_StreetName.Name = "tbx_STR_StreetName";
			tbx_STR_StreetName.Size = new Size( 115, 23 );
			tbx_STR_StreetName.TabIndex = 1;
			tbx_STR_StreetName.TextChanged +=  tbx_STR_StreetName_TextChanged ;
			// 
			// tbx_ZIP_PostalCode
			// 
			tbx_ZIP_PostalCode.BackColor = SystemColors.Window;
			tbx_ZIP_PostalCode.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_ZIP_PostalCode.Location = new Point( 135, 192 );
			tbx_ZIP_PostalCode.Name = "tbx_ZIP_PostalCode";
			tbx_ZIP_PostalCode.Size = new Size( 115, 23 );
			tbx_ZIP_PostalCode.TabIndex = 6;
			tbx_ZIP_PostalCode.TextChanged +=  tbx_ZIP_PostalCode_TextChanged ;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label5.ForeColor = Color.FromArgb(     192,     0,     0 );
			label5.Location = new Point( 17, 16 );
			label5.Name = "label5";
			label5.Size = new Size( 110, 19 );
			label5.TabIndex = 18;
			label5.Text = "House Number";
			// 
			// tbx_LOC_City
			// 
			tbx_LOC_City.BackColor = SystemColors.Window;
			tbx_LOC_City.Location = new Point( 135, 102 );
			tbx_LOC_City.Name = "tbx_LOC_City";
			tbx_LOC_City.Size = new Size( 115, 23 );
			tbx_LOC_City.TabIndex = 3;
			tbx_LOC_City.TextChanged +=  tbx_LOC_City_TextChanged ;
			// 
			// tbx_STR_HouseNumber
			// 
			tbx_STR_HouseNumber.BackColor = SystemColors.Window;
			tbx_STR_HouseNumber.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_STR_HouseNumber.Location = new Point( 135, 12 );
			tbx_STR_HouseNumber.Name = "tbx_STR_HouseNumber";
			tbx_STR_HouseNumber.Size = new Size( 115, 23 );
			tbx_STR_HouseNumber.TabIndex = 0;
			tbx_STR_HouseNumber.TextChanged +=  tbx_STR_HouseNumber_TextChanged ;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label4.ForeColor = Color.FromArgb(     192,     0,     0 );
			label4.Location = new Point( 56, 316 );
			label4.Name = "label4";
			label4.Size = new Size( 71, 19 );
			label4.TabIndex = 15;
			label4.Text = "Extention";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label7.ForeColor = Color.FromArgb(     192,     0,     0 );
			label7.Location = new Point( 92, 106 );
			label7.Name = "label7";
			label7.Size = new Size( 35, 19 );
			label7.TabIndex = 37;
			label7.Text = "City";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label6.ForeColor = Color.FromArgb(     192,     0,     0 );
			label6.Location = new Point( 70, 76 );
			label6.Name = "label6";
			label6.Size = new Size( 57, 19 );
			label6.TabIndex = 33;
			label6.Text = "Suburb";
			// 
			// tbx_BOX_RuralDelivery
			// 
			tbx_BOX_RuralDelivery.BackColor = SystemColors.Window;
			tbx_BOX_RuralDelivery.Location = new Point( 135, 162 );
			tbx_BOX_RuralDelivery.Name = "tbx_BOX_RuralDelivery";
			tbx_BOX_RuralDelivery.Size = new Size( 115, 23 );
			tbx_BOX_RuralDelivery.TabIndex = 5;
			tbx_BOX_RuralDelivery.TextChanged +=  tbx_BOX_RuralDelivery_TextChanged ;
			// 
			// tbx_LOC_Suburb
			// 
			tbx_LOC_Suburb.BackColor = SystemColors.Window;
			tbx_LOC_Suburb.Location = new Point( 135, 72 );
			tbx_LOC_Suburb.Name = "tbx_LOC_Suburb";
			tbx_LOC_Suburb.Size = new Size( 115, 23 );
			tbx_LOC_Suburb.TabIndex = 2;
			tbx_LOC_Suburb.TextChanged +=  tbx_LOC_Suburb_TextChanged ;
			// 
			// tbx_EXT_Extension
			// 
			tbx_EXT_Extension.BackColor = SystemColors.Window;
			tbx_EXT_Extension.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_EXT_Extension.Location = new Point( 135, 312 );
			tbx_EXT_Extension.Name = "tbx_EXT_Extension";
			tbx_EXT_Extension.Size = new Size( 115, 23 );
			tbx_EXT_Extension.TabIndex = 10;
			tbx_EXT_Extension.TextChanged +=  tbx_EXT_Extension_TextChanged ;
			// 
			// lvw_MatchingAddresses
			// 
			lvw_MatchingAddresses.Columns.AddRange( new ColumnHeader[] { hdr_PrimaryKey, hdr_StreetAddress, hdr_BurbCity, hdr_Metropolitan, hdr_Postal, hdr_Extensions, hdr_Country } );
			lvw_MatchingAddresses.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			lvw_MatchingAddresses.FullRowSelect = true;
			lvw_MatchingAddresses.GridLines = true;
			lvw_MatchingAddresses.Items.AddRange( new ListViewItem[] { listViewItem1 } );
			lvw_MatchingAddresses.Location = new Point( 271, 12 );
			lvw_MatchingAddresses.MultiSelect = false;
			lvw_MatchingAddresses.Name = "lvw_MatchingAddresses";
			lvw_MatchingAddresses.Size = new Size( 1045, 413 );
			lvw_MatchingAddresses.TabIndex = 14;
			lvw_MatchingAddresses.UseCompatibleStateImageBehavior = false;
			lvw_MatchingAddresses.View = View.Details;
			lvw_MatchingAddresses.DoubleClick +=  lvw_MatchingAddresses_DoubleClick ;
			// 
			// hdr_PrimaryKey
			// 
			hdr_PrimaryKey.Text = "PK";
			// 
			// hdr_StreetAddress
			// 
			hdr_StreetAddress.Text = "STREET ADDRESS";
			hdr_StreetAddress.Width = 180;
			// 
			// hdr_BurbCity
			// 
			hdr_BurbCity.Text = "'BURB, CITY";
			hdr_BurbCity.Width = 150;
			// 
			// hdr_Metropolitan
			// 
			hdr_Metropolitan.Text = "METROPOLITAN";
			hdr_Metropolitan.Width = 150;
			// 
			// hdr_Postal
			// 
			hdr_Postal.Text = "PO BOX, ETC";
			hdr_Postal.Width = 150;
			// 
			// hdr_Extensions
			// 
			hdr_Extensions.Text = "EXTENSIONS";
			hdr_Extensions.Width = 180;
			// 
			// hdr_Country
			// 
			hdr_Country.Text = "COUNTRY";
			hdr_Country.Width = 150;
			// 
			// tbx_PRV_Abbreviation
			// 
			tbx_PRV_Abbreviation.BackColor = SystemColors.Window;
			tbx_PRV_Abbreviation.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_PRV_Abbreviation.Location = new Point( 135, 402 );
			tbx_PRV_Abbreviation.Name = "tbx_PRV_Abbreviation";
			tbx_PRV_Abbreviation.Size = new Size( 115, 23 );
			tbx_PRV_Abbreviation.TabIndex = 13;
			tbx_PRV_Abbreviation.TextChanged +=  tbx_PRV_Abbreviation_TextChanged ;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label1.ForeColor = Color.FromArgb(     192,     0,     0 );
			label1.Location = new Point( 26, 406 );
			label1.Name = "label1";
			label1.Size = new Size( 101, 19 );
			label1.TabIndex = 52;
			label1.Text = "Prov. Abbrev.";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label2.ForeColor = Color.FromArgb(     192,     0,     0 );
			label2.Location = new Point( 30, 346 );
			label2.Name = "label2";
			label2.Size = new Size( 97, 19 );
			label2.TabIndex = 53;
			label2.Text = "Metropolitan";
			// 
			// tbx_MET_Metropolitan
			// 
			tbx_MET_Metropolitan.BackColor = SystemColors.Window;
			tbx_MET_Metropolitan.Location = new Point( 135, 342 );
			tbx_MET_Metropolitan.Name = "tbx_MET_Metropolitan";
			tbx_MET_Metropolitan.Size = new Size( 115, 23 );
			tbx_MET_Metropolitan.TabIndex = 11;
			tbx_MET_Metropolitan.TextChanged +=  tbx_MET_Metropolitan_TextChanged ;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label3.ForeColor = Color.FromArgb(     192,     0,     0 );
			label3.Location = new Point( 59, 376 );
			label3.Name = "label3";
			label3.Size = new Size( 68, 19 );
			label3.TabIndex = 55;
			label3.Text = "Province";
			// 
			// tbx_PRV_Name
			// 
			tbx_PRV_Name.BackColor = SystemColors.Window;
			tbx_PRV_Name.Location = new Point( 135, 372 );
			tbx_PRV_Name.Name = "tbx_PRV_Name";
			tbx_PRV_Name.Size = new Size( 115, 23 );
			tbx_PRV_Name.TabIndex = 12;
			tbx_PRV_Name.TextChanged +=  tbx_PRV_Name_TextChanged ;
			// 
			// DlgFindAddress
			// 
			AcceptButton = btn_CloseForm;
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_Cancel;
			ClientSize = new Size( 1337, 482 );
			Controls.Add( label3 );
			Controls.Add( tbx_PRV_Name );
			Controls.Add( label2 );
			Controls.Add( tbx_MET_Metropolitan );
			Controls.Add( tbx_PRV_Abbreviation );
			Controls.Add( label1 );
			Controls.Add( btn_Cancel );
			Controls.Add( lvw_MatchingAddresses );
			Controls.Add( tbx_EXT_Assemblage );
			Controls.Add( btn_CloseForm );
			Controls.Add( tbx_EXT_Unit );
			Controls.Add( tbx_EXT_Extension );
			Controls.Add( label4 );
			Controls.Add( label15 );
			Controls.Add( label5 );
			Controls.Add( tbx_STR_HouseNumber );
			Controls.Add( tbx_EXT_Level );
			Controls.Add( label14 );
			Controls.Add( label19 );
			Controls.Add( tbx_STR_StreetName );
			Controls.Add( lbl_POBox );
			Controls.Add( tbx_BOX_Number );
			Controls.Add( label13 );
			Controls.Add( label25 );
			Controls.Add( tbx_ZIP_PostalCode );
			Controls.Add( label6 );
			Controls.Add( label16 );
			Controls.Add( tbx_LOC_Suburb );
			Controls.Add( label7 );
			Controls.Add( tbx_BOX_RuralDelivery );
			Controls.Add( tbx_LOC_City );
			Name = "DlgFindAddress";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Find Address";
			TopMost = true;
			ResumeLayout( false );
			PerformLayout();

		}

		#endregion
		private TextBox tbx_EXT_Assemblage;
		private Label label15;
		private TextBox tbx_EXT_Unit;
		private Label lbl_POBox;
		private Label label14;
		private TextBox tbx_BOX_Number;
		private TextBox tbx_EXT_Level;
		private Label label25;
		private Label label19;
		private Label label16;
		private Label label13;
		private TextBox tbx_STR_StreetName;
		private TextBox tbx_ZIP_PostalCode;
		private Label label5;
		private TextBox tbx_LOC_City;
		private TextBox tbx_STR_HouseNumber;
		private Label label4;
		private Label label7;
		private Label label6;
		private TextBox tbx_BOX_RuralDelivery;
		private TextBox tbx_LOC_Suburb;
		private TextBox tbx_EXT_Extension;
		private Button btn_CloseForm;
		private Button btn_Cancel;
		private ListView lvw_MatchingAddresses;
		private ColumnHeader hdr_StreetAddress;
		private ColumnHeader hdr_BurbCity;
		private ColumnHeader hdr_Metropolitan;
		private ColumnHeader hdr_Postal;
		private ColumnHeader hdr_Extensions;
		private ColumnHeader hdr_Country;
		private ColumnHeader hdr_PrimaryKey;
		private TextBox tbx_PRV_Abbreviation;
		private Label label1;
		private Label label2;
		private TextBox tbx_MET_Metropolitan;
		private Label label3;
		private TextBox tbx_PRV_Name;
	}
}