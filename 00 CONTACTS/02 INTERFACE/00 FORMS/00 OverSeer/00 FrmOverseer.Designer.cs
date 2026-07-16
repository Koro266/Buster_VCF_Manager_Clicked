namespace CONTACTS.INTERFACE.FORMS
{
	public partial class FrmOverseer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null ))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label2 = new Label();
			tbx_Primary_Key = new TextBox();
			_btn_Export_One_Person = new Button();
			_btn_Export_Recent_Persons = new Button();
			_btn_Export_One_Family = new Button();
			_btn_Export_Recent_Families = new Button();
			_btn_Export_One_Group = new Button();
			_btn_Export_Recent_Groups = new Button();
			_btn_Export_All_Groups = new Button();
			label1 = new Label();
			dt_date_picker = new DateTimePicker();
			_btn_Export_All_Families = new Button();
			_btn_Export_All_Persons = new Button();
			bx_Groups = new GroupBox();
			btn_DoTheLot = new Button();
			bx_Families = new GroupBox();
			bx_Persons = new GroupBox();
			btn_OpenFamilyForm = new Button();
			btn_Devices = new Button();
			btn_OpenAddressForm = new Button();
			btn_Open_Person_Form = new Button();
			grp_Export = new GroupBox();
			tbx_Export_Status = new TextBox();
			grp_Add_Mod_Del = new GroupBox();
			btn_Open_Group_X_Form = new Button();
			btn_Open_Person_X_Form = new Button();
			btn_Open_FamilyX_Form = new Button();
			btn_Eddresses = new Button();
			btn_Open_Group_Form = new Button();
			btn_CloseForm = new Button();
			bx_Groups.SuspendLayout();
			bx_Families.SuspendLayout();
			bx_Persons.SuspendLayout();
			grp_Export.SuspendLayout();
			grp_Add_Mod_Del.SuspendLayout();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label2.Location = new Point( 37, 158 );
			label2.Name = "label2";
			label2.Size = new Size( 31, 19 );
			label2.TabIndex = 4;
			label2.Text = "PK:";
			// 
			// tbx_Primary_Key
			// 
			tbx_Primary_Key.BackColor = Color.FromArgb(     255,     192,     192 );
			tbx_Primary_Key.Font = new Font( "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Primary_Key.Location = new Point( 74, 153 );
			tbx_Primary_Key.Name = "tbx_Primary_Key";
			tbx_Primary_Key.Size = new Size( 100, 27 );
			tbx_Primary_Key.TabIndex = 3;
			tbx_Primary_Key.TextAlign = HorizontalAlignment.Right;
			// 
			// _btn_Export_One_Person
			// 
			_btn_Export_One_Person.Font = new Font( "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point );
			_btn_Export_One_Person.ForeColor = Color.Maroon;
			_btn_Export_One_Person.Location = new Point( 19, 105 );
			_btn_Export_One_Person.Name = "_btn_Export_One_Person";
			_btn_Export_One_Person.Size = new Size( 155, 35 );
			_btn_Export_One_Person.TabIndex = 2;
			_btn_Export_One_Person.Text = "Person";
			_btn_Export_One_Person.UseVisualStyleBackColor = true;
			_btn_Export_One_Person.Click +=  _btn_Export_One_Person_Click ;
			// 
			// _btn_Export_Recent_Persons
			// 
			_btn_Export_Recent_Persons.Font = new Font( "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point );
			_btn_Export_Recent_Persons.ForeColor = Color.Maroon;
			_btn_Export_Recent_Persons.Location = new Point( 19, 105 );
			_btn_Export_Recent_Persons.Name = "_btn_Export_Recent_Persons";
			_btn_Export_Recent_Persons.Size = new Size( 155, 35 );
			_btn_Export_Recent_Persons.TabIndex = 2;
			_btn_Export_Recent_Persons.Text = "Persons";
			_btn_Export_Recent_Persons.UseVisualStyleBackColor = true;
			_btn_Export_Recent_Persons.Click +=  _btn_Export_Recent_Persons_Click ;
			// 
			// _btn_Export_One_Family
			// 
			_btn_Export_One_Family.Font = new Font( "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point );
			_btn_Export_One_Family.ForeColor = Color.Maroon;
			_btn_Export_One_Family.Location = new Point( 19, 64 );
			_btn_Export_One_Family.Name = "_btn_Export_One_Family";
			_btn_Export_One_Family.Size = new Size( 155, 35 );
			_btn_Export_One_Family.TabIndex = 1;
			_btn_Export_One_Family.Text = "Family";
			_btn_Export_One_Family.UseVisualStyleBackColor = true;
			_btn_Export_One_Family.Click +=  _btn_Export_One_Family_Click ;
			// 
			// _btn_Export_Recent_Families
			// 
			_btn_Export_Recent_Families.Font = new Font( "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point );
			_btn_Export_Recent_Families.ForeColor = Color.Maroon;
			_btn_Export_Recent_Families.Location = new Point( 19, 64 );
			_btn_Export_Recent_Families.Name = "_btn_Export_Recent_Families";
			_btn_Export_Recent_Families.Size = new Size( 155, 35 );
			_btn_Export_Recent_Families.TabIndex = 1;
			_btn_Export_Recent_Families.Text = "Families";
			_btn_Export_Recent_Families.UseVisualStyleBackColor = true;
			_btn_Export_Recent_Families.Click +=  _btn_Export_Recent_Families_Click ;
			// 
			// _btn_Export_One_Group
			// 
			_btn_Export_One_Group.Font = new Font( "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point );
			_btn_Export_One_Group.ForeColor = Color.Maroon;
			_btn_Export_One_Group.Location = new Point( 19, 22 );
			_btn_Export_One_Group.Name = "_btn_Export_One_Group";
			_btn_Export_One_Group.Size = new Size( 155, 35 );
			_btn_Export_One_Group.TabIndex = 0;
			_btn_Export_One_Group.Text = "Group";
			_btn_Export_One_Group.UseVisualStyleBackColor = true;
			_btn_Export_One_Group.Click +=  _btn_Export_One_Group_Click ;
			// 
			// _btn_Export_Recent_Groups
			// 
			_btn_Export_Recent_Groups.Font = new Font( "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point );
			_btn_Export_Recent_Groups.ForeColor = Color.Maroon;
			_btn_Export_Recent_Groups.Location = new Point( 19, 22 );
			_btn_Export_Recent_Groups.Name = "_btn_Export_Recent_Groups";
			_btn_Export_Recent_Groups.Size = new Size( 155, 35 );
			_btn_Export_Recent_Groups.TabIndex = 0;
			_btn_Export_Recent_Groups.Text = "Groups";
			_btn_Export_Recent_Groups.UseVisualStyleBackColor = true;
			_btn_Export_Recent_Groups.Click +=  _btn_Export_Recent_Groups_Click ;
			// 
			// _btn_Export_All_Groups
			// 
			_btn_Export_All_Groups.Font = new Font( "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point );
			_btn_Export_All_Groups.ForeColor = Color.Maroon;
			_btn_Export_All_Groups.Location = new Point( 19, 22 );
			_btn_Export_All_Groups.Name = "_btn_Export_All_Groups";
			_btn_Export_All_Groups.Size = new Size( 155, 35 );
			_btn_Export_All_Groups.TabIndex = 0;
			_btn_Export_All_Groups.Text = "Groups";
			_btn_Export_All_Groups.UseVisualStyleBackColor = true;
			_btn_Export_All_Groups.Click +=  _btn_Export_All_Groups_Click ;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			label1.ForeColor = Color.Maroon;
			label1.Location = new Point( 21, 143 );
			label1.Name = "label1";
			label1.Size = new Size( 148, 19 );
			label1.TabIndex = 19;
			label1.Text = "Updated on or after:";
			// 
			// dt_date_picker
			// 
			dt_date_picker.CustomFormat = "ddd, d MMM yyyy";
			dt_date_picker.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			dt_date_picker.Format = DateTimePickerFormat.Custom;
			dt_date_picker.Location = new Point( 19, 166 );
			dt_date_picker.Name = "dt_date_picker";
			dt_date_picker.Size = new Size( 155, 25 );
			dt_date_picker.TabIndex = 3;
			// 
			// _btn_Export_All_Families
			// 
			_btn_Export_All_Families.Font = new Font( "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point );
			_btn_Export_All_Families.ForeColor = Color.Maroon;
			_btn_Export_All_Families.Location = new Point( 19, 63 );
			_btn_Export_All_Families.Name = "_btn_Export_All_Families";
			_btn_Export_All_Families.Size = new Size( 155, 36 );
			_btn_Export_All_Families.TabIndex = 1;
			_btn_Export_All_Families.Text = "Families";
			_btn_Export_All_Families.UseVisualStyleBackColor = true;
			_btn_Export_All_Families.Click +=  _btn_Export_All_Families_Click ;
			// 
			// _btn_Export_All_Persons
			// 
			_btn_Export_All_Persons.Font = new Font( "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point );
			_btn_Export_All_Persons.ForeColor = Color.Maroon;
			_btn_Export_All_Persons.Location = new Point( 19, 105 );
			_btn_Export_All_Persons.Name = "_btn_Export_All_Persons";
			_btn_Export_All_Persons.Size = new Size( 155, 35 );
			_btn_Export_All_Persons.TabIndex = 2;
			_btn_Export_All_Persons.Text = "Persons";
			_btn_Export_All_Persons.UseVisualStyleBackColor = true;
			_btn_Export_All_Persons.Click +=  _btn_Export_All_Persons_Click ;
			// 
			// bx_Groups
			// 
			bx_Groups.BackColor = Color.Moccasin;
			bx_Groups.Controls.Add( btn_DoTheLot );
			bx_Groups.Controls.Add( _btn_Export_All_Persons );
			bx_Groups.Controls.Add( _btn_Export_All_Families );
			bx_Groups.Controls.Add( _btn_Export_All_Groups );
			bx_Groups.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			bx_Groups.Location = new Point( 32, 20 );
			bx_Groups.Name = "bx_Groups";
			bx_Groups.Size = new Size( 198, 213 );
			bx_Groups.TabIndex = 0;
			bx_Groups.TabStop = false;
			bx_Groups.Text = "Export All";
			// 
			// btn_DoTheLot
			// 
			btn_DoTheLot.Enabled = false;
			btn_DoTheLot.Font = new Font( "Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_DoTheLot.ForeColor = Color.Maroon;
			btn_DoTheLot.Location = new Point( 19, 149 );
			btn_DoTheLot.Name = "btn_DoTheLot";
			btn_DoTheLot.Size = new Size( 155, 35 );
			btn_DoTheLot.TabIndex = 3;
			btn_DoTheLot.Text = "The Lot ...";
			btn_DoTheLot.UseVisualStyleBackColor = true;
			btn_DoTheLot.Click +=  btn_DoTheLot_Click ;
			// 
			// bx_Families
			// 
			bx_Families.BackColor = Color.Moccasin;
			bx_Families.Controls.Add( _btn_Export_Recent_Groups );
			bx_Families.Controls.Add( _btn_Export_Recent_Persons );
			bx_Families.Controls.Add( _btn_Export_Recent_Families );
			bx_Families.Controls.Add( label1 );
			bx_Families.Controls.Add( dt_date_picker );
			bx_Families.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			bx_Families.Location = new Point( 236, 20 );
			bx_Families.Name = "bx_Families";
			bx_Families.Size = new Size( 197, 213 );
			bx_Families.TabIndex = 1;
			bx_Families.TabStop = false;
			bx_Families.Text = "Export Recently Updated";
			// 
			// bx_Persons
			// 
			bx_Persons.BackColor = Color.Moccasin;
			bx_Persons.Controls.Add( _btn_Export_One_Person );
			bx_Persons.Controls.Add( _btn_Export_One_Group );
			bx_Persons.Controls.Add( _btn_Export_One_Family );
			bx_Persons.Controls.Add( tbx_Primary_Key );
			bx_Persons.Controls.Add( label2 );
			bx_Persons.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			bx_Persons.Location = new Point( 439, 20 );
			bx_Persons.Name = "bx_Persons";
			bx_Persons.Size = new Size( 199, 213 );
			bx_Persons.TabIndex = 2;
			bx_Persons.TabStop = false;
			bx_Persons.Text = "Export Single Entity by PK";
			// 
			// btn_OpenFamilyForm
			// 
			btn_OpenFamilyForm.BackColor = Color.MistyRose;
			btn_OpenFamilyForm.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_OpenFamilyForm.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_OpenFamilyForm.Location = new Point( 51, 75 );
			btn_OpenFamilyForm.Name = "btn_OpenFamilyForm";
			btn_OpenFamilyForm.Size = new Size( 155, 38 );
			btn_OpenFamilyForm.TabIndex = 1;
			btn_OpenFamilyForm.Text = "Families";
			btn_OpenFamilyForm.UseVisualStyleBackColor = false;
			btn_OpenFamilyForm.Click +=  btn_OpenFamilyForm_Click ;
			// 
			// btn_Devices
			// 
			btn_Devices.BackColor = Color.MistyRose;
			btn_Devices.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Devices.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_Devices.Location = new Point( 257, 75 );
			btn_Devices.Name = "btn_Devices";
			btn_Devices.Size = new Size( 155, 38 );
			btn_Devices.TabIndex = 4;
			btn_Devices.Text = "Devices";
			btn_Devices.UseVisualStyleBackColor = false;
			btn_Devices.Click +=  btn_Devices_Click ;
			// 
			// btn_OpenAddressForm
			// 
			btn_OpenAddressForm.BackColor = Color.MistyRose;
			btn_OpenAddressForm.Enabled = false;
			btn_OpenAddressForm.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_OpenAddressForm.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_OpenAddressForm.Location = new Point( 257, 31 );
			btn_OpenAddressForm.Name = "btn_OpenAddressForm";
			btn_OpenAddressForm.Size = new Size( 155, 38 );
			btn_OpenAddressForm.TabIndex = 3;
			btn_OpenAddressForm.Text = "Addresses";
			btn_OpenAddressForm.UseVisualStyleBackColor = false;
			btn_OpenAddressForm.Visible = false;
			btn_OpenAddressForm.Click +=  btn_OpenAddressForm_Click ;
			// 
			// btn_Open_Person_Form
			// 
			btn_Open_Person_Form.BackColor = Color.MistyRose;
			btn_Open_Person_Form.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Open_Person_Form.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_Open_Person_Form.Location = new Point( 51, 31 );
			btn_Open_Person_Form.Name = "btn_Open_Person_Form";
			btn_Open_Person_Form.Size = new Size( 155, 38 );
			btn_Open_Person_Form.TabIndex = 0;
			btn_Open_Person_Form.Text = "Persons";
			btn_Open_Person_Form.UseVisualStyleBackColor = false;
			btn_Open_Person_Form.Click +=  btn_Open_Person_Form_Click ;
			// 
			// grp_Export
			// 
			grp_Export.BackColor = Color.PapayaWhip;
			grp_Export.Controls.Add( tbx_Export_Status );
			grp_Export.Controls.Add( bx_Groups );
			grp_Export.Controls.Add( bx_Families );
			grp_Export.Controls.Add( bx_Persons );
			grp_Export.Location = new Point( 12, 192 );
			grp_Export.Name = "grp_Export";
			grp_Export.Size = new Size( 654, 276 );
			grp_Export.TabIndex = 2;
			grp_Export.TabStop = false;
			grp_Export.Text = "VCF Export";
			// 
			// tbx_Export_Status
			// 
			tbx_Export_Status.BackColor = Color.FromArgb(     255,     255,     192 );
			tbx_Export_Status.ForeColor = Color.ForestGreen;
			tbx_Export_Status.Location = new Point( 32, 239 );
			tbx_Export_Status.Name = "tbx_Export_Status";
			tbx_Export_Status.Size = new Size( 606, 23 );
			tbx_Export_Status.TabIndex = 4;
			tbx_Export_Status.TabStop = false;
			// 
			// grp_Add_Mod_Del
			// 
			grp_Add_Mod_Del.BackColor = Color.PeachPuff;
			grp_Add_Mod_Del.Controls.Add( btn_Open_Group_X_Form );
			grp_Add_Mod_Del.Controls.Add( btn_Open_Person_X_Form );
			grp_Add_Mod_Del.Controls.Add( btn_Open_FamilyX_Form );
			grp_Add_Mod_Del.Controls.Add( btn_Eddresses );
			grp_Add_Mod_Del.Controls.Add( btn_Open_Group_Form );
			grp_Add_Mod_Del.Controls.Add( btn_Devices );
			grp_Add_Mod_Del.Controls.Add( btn_Open_Person_Form );
			grp_Add_Mod_Del.Controls.Add( btn_OpenFamilyForm );
			grp_Add_Mod_Del.Controls.Add( btn_OpenAddressForm );
			grp_Add_Mod_Del.Location = new Point( 12, 12 );
			grp_Add_Mod_Del.Name = "grp_Add_Mod_Del";
			grp_Add_Mod_Del.Size = new Size( 654, 174 );
			grp_Add_Mod_Del.TabIndex = 0;
			grp_Add_Mod_Del.TabStop = false;
			grp_Add_Mod_Del.Text = "Add, Modify, Delete";
			// 
			// btn_Open_Group_X_Form
			// 
			btn_Open_Group_X_Form.BackColor = Color.MistyRose;
			btn_Open_Group_X_Form.Enabled = false;
			btn_Open_Group_X_Form.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Open_Group_X_Form.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_Open_Group_X_Form.Location = new Point( 451, 119 );
			btn_Open_Group_X_Form.Name = "btn_Open_Group_X_Form";
			btn_Open_Group_X_Form.Size = new Size( 155, 38 );
			btn_Open_Group_X_Form.TabIndex = 8;
			btn_Open_Group_X_Form.Text = "Group_X";
			btn_Open_Group_X_Form.UseVisualStyleBackColor = false;
			btn_Open_Group_X_Form.Visible = false;
			btn_Open_Group_X_Form.Click +=  btn_Open_Group_X_Form_Click ;
			// 
			// btn_Open_Person_X_Form
			// 
			btn_Open_Person_X_Form.BackColor = Color.MistyRose;
			btn_Open_Person_X_Form.Enabled = false;
			btn_Open_Person_X_Form.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Open_Person_X_Form.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_Open_Person_X_Form.Location = new Point( 451, 31 );
			btn_Open_Person_X_Form.Name = "btn_Open_Person_X_Form";
			btn_Open_Person_X_Form.Size = new Size( 155, 38 );
			btn_Open_Person_X_Form.TabIndex = 6;
			btn_Open_Person_X_Form.Text = "Person_X";
			btn_Open_Person_X_Form.UseVisualStyleBackColor = false;
			btn_Open_Person_X_Form.Visible = false;
			btn_Open_Person_X_Form.Click +=  btn_Open_Person_X_Form_Click ;
			// 
			// btn_Open_FamilyX_Form
			// 
			btn_Open_FamilyX_Form.BackColor = Color.MistyRose;
			btn_Open_FamilyX_Form.Enabled = false;
			btn_Open_FamilyX_Form.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Open_FamilyX_Form.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_Open_FamilyX_Form.Location = new Point( 451, 75 );
			btn_Open_FamilyX_Form.Name = "btn_Open_FamilyX_Form";
			btn_Open_FamilyX_Form.Size = new Size( 155, 38 );
			btn_Open_FamilyX_Form.TabIndex = 7;
			btn_Open_FamilyX_Form.Text = "Family_X";
			btn_Open_FamilyX_Form.UseVisualStyleBackColor = false;
			btn_Open_FamilyX_Form.Visible = false;
			btn_Open_FamilyX_Form.Click +=  btn_Open_Family_X_Form_Click ;
			// 
			// btn_Eddresses
			// 
			btn_Eddresses.BackColor = Color.MistyRose;
			btn_Eddresses.Enabled = false;
			btn_Eddresses.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Eddresses.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_Eddresses.Location = new Point( 257, 119 );
			btn_Eddresses.Name = "btn_Eddresses";
			btn_Eddresses.Size = new Size( 155, 38 );
			btn_Eddresses.TabIndex = 5;
			btn_Eddresses.Text = "Eddresses";
			btn_Eddresses.UseVisualStyleBackColor = false;
			btn_Eddresses.Visible = false;
			btn_Eddresses.Click +=  btn_Eddresses_Click ;
			// 
			// btn_Open_Group_Form
			// 
			btn_Open_Group_Form.BackColor = Color.MistyRose;
			btn_Open_Group_Form.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_Open_Group_Form.ForeColor = Color.FromArgb(     192,     0,     0 );
			btn_Open_Group_Form.Location = new Point( 51, 119 );
			btn_Open_Group_Form.Name = "btn_Open_Group_Form";
			btn_Open_Group_Form.Size = new Size( 155, 38 );
			btn_Open_Group_Form.TabIndex = 2;
			btn_Open_Group_Form.Text = "Groups";
			btn_Open_Group_Form.UseVisualStyleBackColor = false;
			btn_Open_Group_Form.Click +=  btn_Open_Group_Form_Click ;
			// 
			// btn_CloseForm
			// 
			btn_CloseForm.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_CloseForm.ForeColor = Color.Maroon;
			btn_CloseForm.Location = new Point( 553, 474 );
			btn_CloseForm.Name = "btn_CloseForm";
			btn_CloseForm.Size = new Size( 113, 32 );
			btn_CloseForm.TabIndex = 6;
			btn_CloseForm.Text = "Close";
			btn_CloseForm.UseVisualStyleBackColor = true;
			btn_CloseForm.Click +=  btn_CloseForm_Click ;
			// 
			// FrmOverseer
			// 
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_CloseForm;
			ClientSize = new Size( 687, 520 );
			Controls.Add( grp_Add_Mod_Del );
			Controls.Add( btn_CloseForm );
			Controls.Add( grp_Export );
			Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			ForeColor = Color.FromArgb(     192,     0,     0 );
			Name = "FrmOverseer";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "VCF Export Manager";
			bx_Groups.ResumeLayout( false );
			bx_Families.ResumeLayout( false );
			bx_Families.PerformLayout();
			bx_Persons.ResumeLayout( false );
			bx_Persons.PerformLayout();
			grp_Export.ResumeLayout( false );
			grp_Export.PerformLayout();
			grp_Add_Mod_Del.ResumeLayout( false );
			ResumeLayout( false );

		}

		#endregion

		private Label label2;
		private TextBox tbx_Primary_Key;
		private Button _btn_Export_One_Person;
		private Button _btn_Export_Recent_Persons;
		private Button _btn_Export_One_Family;
		private Button _btn_Export_Recent_Families;
		private Button _btn_Export_One_Group;
		private Button _btn_Export_Recent_Groups;
		private Button _btn_Export_All_Groups;
		private Label label1;
		private DateTimePicker dt_date_picker;
		private Button _btn_Export_All_Families;
		private Button _btn_Export_All_Persons;
		private GroupBox bx_Groups;
		private GroupBox bx_Families;
		private GroupBox bx_Persons;
		private Button btn_OpenFamilyForm;
		private Button btn_Devices;
		private Button btn_OpenAddressForm;
		private Button btn_Open_Person_Form;
		private GroupBox grp_Export;
		private GroupBox grp_Add_Mod_Del;
		private Button btn_CloseForm;
		private Button btn_Open_Group_Form;
		private Button btn_Eddresses;
		private Button btn_Open_Group_X_Form;
		private Button btn_Open_Person_X_Form;
		private Button btn_Open_FamilyX_Form;
		private TextBox tbx_Export_Status;
		private Button btn_DoTheLot;
	}
}