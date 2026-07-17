namespace CONTACTS.INTERFACE.FORMS
{
	public partial class FrmAddress
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
			if (disposing && (components == null))
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
			cbx_PostalCode = new ComboBox();
			tbx_LongIsoCode = new TextBox();
			cbx_ProvinceName = new ComboBox();
			cbx_Country = new ComboBox();
			tbx_CountryCode = new TextBox();
			lbl_CountryCode = new Label();
			tbx_ExcelPattern = new TextBox();
			lbl_Metropolitan = new Label();
			tbx_VcfExtended = new TextBox();
			tbx_VcfPostal = new TextBox();
			lbl_PostalCode = new Label();
			tbx_VcfPhysical = new TextBox();
			tbx_ShortIsoCode = new TextBox();
			tbx_ProvinceName = new TextBox();
			tbx_PostalCode = new TextBox();
			tbx_CountryName = new TextBox();
			lbl_ProvinceCode = new Label();
			tbx_HouseNumber = new TextBox();
			lbl_CountryName = new Label();
			tbx_ProvinceCode = new TextBox();
			tbx_Metropolitan = new TextBox();
			lbl_Province = new Label();
			tbx_Extension = new TextBox();
			cbx_StreetName = new ComboBox();
			tbx_Suburb = new TextBox();
			cbx_City = new ComboBox();
			tbx_RuralDelivery = new TextBox();
			lbl_Suburb = new Label();
			lbl_City = new Label();
			lbl_Extention = new Label();
			tbx_City = new TextBox();
			lbl_HouseNumber = new Label();
			cbx_Suburb = new ComboBox();
			cbx_StreetType = new ComboBox();
			tbx_Assemblage = new TextBox();
			tbx_StreetName = new TextBox();
			lbl_Assemblage = new Label();
			lbl_RuralDelivery = new Label();
			lbl_StreetName = new Label();
			lbl_Compass = new Label();
			tbx_Level = new TextBox();
			tbx_Compass = new TextBox();
			tbx_BoxNumber = new TextBox();
			tbx_StreetType = new TextBox();
			lbl_StreetType = new Label();
			lbl_Level = new Label();
			lbl_POBox = new Label();
			tbx_Unit = new TextBox();
			lbl_Unit = new Label();
			btn_DefaultExtendedRule = new Button();
			btn_DefaultPhysicalRule = new Button();
			btn_DefaultPostalRule = new Button();
			tbx_PhysicalRealised = new TextBox();
			tbx_ExtendedRealised = new TextBox();
			tbx_PostalRealised = new TextBox();
			tbx_XL_RowRealised = new TextBox();
			lbl_N = new Label();
			lbl_One = new Label();
			btn_FindAddress = new Button();
			btn_FirstAddress = new Button();
			btn_InsertAddress = new Button();
			btn_PreviousAddress = new Button();
			btn_CloseForm = new Button();
			btn_LastAddress = new Button();
			btn_UpdateAddress = new Button();
			btn_NextAddress = new Button();
			lbl_PkAddress = new Label();
			tbx_Filter = new TextBox();
			tbx_PkAddress = new TextBox();
			lbl_Move = new Label();
			lbl_IsoCodes = new Label();
			lbl_Country = new Label();
			chk_Christmas = new CheckBox();
			tbx_FkCountry = new TextBox();
			btn_DefaultExcelRule = new Button();
			cbx_ProvinceCode = new ComboBox();
			cbx_Metropolitan = new ComboBox();
			tbx_Messages = new TextBox();
			SuspendLayout();
			// 
			// cbx_PostalCode
			// 
			cbx_PostalCode.BackColor = Color.PaleTurquoise;
			cbx_PostalCode.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			cbx_PostalCode.FormattingEnabled = true;
			cbx_PostalCode.Location = new Point( 293, 383 );
			cbx_PostalCode.Name = "cbx_PostalCode";
			cbx_PostalCode.Size = new Size( 172, 24 );
			cbx_PostalCode.TabIndex = 2;
			cbx_PostalCode.SelectedValueChanged +=  cbx_PostalCode_SelectedValueChanged ;
			// 
			// tbx_LongIsoCode
			// 
			tbx_LongIsoCode.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_LongIsoCode.Location = new Point( 402, 639 );
			tbx_LongIsoCode.Name = "tbx_LongIsoCode";
			tbx_LongIsoCode.Size = new Size( 60, 22 );
			tbx_LongIsoCode.TabIndex = 5;
			// 
			// cbx_ProvinceName
			// 
			cbx_ProvinceName.BackColor = Color.PaleTurquoise;
			cbx_ProvinceName.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			cbx_ProvinceName.FormattingEnabled = true;
			cbx_ProvinceName.Location = new Point( 293, 243 );
			cbx_ProvinceName.Name = "cbx_ProvinceName";
			cbx_ProvinceName.Size = new Size( 172, 24 );
			cbx_ProvinceName.TabIndex = 2;
			cbx_ProvinceName.SelectedValueChanged +=  cbx_Province_SelectedValueChanged ;
			// 
			// cbx_Country
			// 
			cbx_Country.BackColor = Color.PaleTurquoise;
			cbx_Country.DisplayMember = "\"CountryName\"";
			cbx_Country.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			cbx_Country.FormattingEnabled = true;
			cbx_Country.Location = new Point( 205, 577 );
			cbx_Country.Name = "cbx_Country";
			cbx_Country.Size = new Size( 259, 24 );
			cbx_Country.TabIndex = 0;
			cbx_Country.ValueMember = "\"PkAddress\"";
			cbx_Country.SelectedValueChanged +=  cbx_Country_SelectedValueChanged ;
			// 
			// tbx_CountryCode
			// 
			tbx_CountryCode.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_CountryCode.Location = new Point( 148, 637 );
			tbx_CountryCode.Name = "tbx_CountryCode";
			tbx_CountryCode.Size = new Size( 52, 22 );
			tbx_CountryCode.TabIndex = 3;
			// 
			// lbl_CountryCode
			// 
			lbl_CountryCode.AutoSize = true;
			lbl_CountryCode.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_CountryCode.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_CountryCode.Location = new Point( 18, 640 );
			lbl_CountryCode.Name = "lbl_CountryCode";
			lbl_CountryCode.Size = new Size( 126, 19 );
			lbl_CountryCode.TabIndex = 62;
			lbl_CountryCode.Text = "Country Code: cd";
			// 
			// tbx_ExcelPattern
			// 
			tbx_ExcelPattern.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_ExcelPattern.Location = new Point( 590, 569 );
			tbx_ExcelPattern.Name = "tbx_ExcelPattern";
			tbx_ExcelPattern.Size = new Size( 561, 22 );
			tbx_ExcelPattern.TabIndex = 1;
			tbx_ExcelPattern.TextChanged +=  tbx_XL_RowPattern_TextChanged ;
			// 
			// lbl_Metropolitan
			// 
			lbl_Metropolitan.AutoSize = true;
			lbl_Metropolitan.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Metropolitan.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Metropolitan.Location = new Point( 21, 219 );
			lbl_Metropolitan.Name = "lbl_Metropolitan";
			lbl_Metropolitan.Size = new Size( 123, 19 );
			lbl_Metropolitan.TabIndex = 40;
			lbl_Metropolitan.Text = "Metropolitan: mt";
			// 
			// tbx_VcfExtended
			// 
			tbx_VcfExtended.Font = new Font( "Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_VcfExtended.Location = new Point( 591, 391 );
			tbx_VcfExtended.Name = "tbx_VcfExtended";
			tbx_VcfExtended.Size = new Size( 385, 27 );
			tbx_VcfExtended.TabIndex = 5;
			tbx_VcfExtended.Tag = "";
			tbx_VcfExtended.TextChanged +=  tbx_ExtendedPattern_TextChanged ;
			// 
			// tbx_VcfPostal
			// 
			tbx_VcfPostal.Font = new Font( "Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_VcfPostal.Location = new Point( 591, 20 );
			tbx_VcfPostal.Name = "tbx_VcfPostal";
			tbx_VcfPostal.Size = new Size( 385, 27 );
			tbx_VcfPostal.TabIndex = 1;
			tbx_VcfPostal.TextChanged +=  tbx_PostalPattern_TextChanged ;
			// 
			// lbl_PostalCode
			// 
			lbl_PostalCode.AutoSize = true;
			lbl_PostalCode.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_PostalCode.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_PostalCode.Location = new Point( 31, 385 );
			lbl_PostalCode.Name = "lbl_PostalCode";
			lbl_PostalCode.Size = new Size( 113, 19 );
			lbl_PostalCode.TabIndex = 50;
			lbl_PostalCode.Text = "Postal Code: pc";
			// 
			// tbx_VcfPhysical
			// 
			tbx_VcfPhysical.Font = new Font( "Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_VcfPhysical.Location = new Point( 591, 202 );
			tbx_VcfPhysical.Name = "tbx_VcfPhysical";
			tbx_VcfPhysical.Size = new Size( 385, 27 );
			tbx_VcfPhysical.TabIndex = 3;
			tbx_VcfPhysical.Tag = "";
			tbx_VcfPhysical.TextChanged +=  tbx_PhysicalPattern_TextChanged ;
			// 
			// tbx_ShortIsoCode
			// 
			tbx_ShortIsoCode.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_ShortIsoCode.Location = new Point( 336, 639 );
			tbx_ShortIsoCode.Name = "tbx_ShortIsoCode";
			tbx_ShortIsoCode.Size = new Size( 60, 22 );
			tbx_ShortIsoCode.TabIndex = 4;
			// 
			// tbx_ProvinceName
			// 
			tbx_ProvinceName.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_ProvinceName.Location = new Point( 149, 243 );
			tbx_ProvinceName.Name = "tbx_ProvinceName";
			tbx_ProvinceName.Size = new Size( 138, 22 );
			tbx_ProvinceName.TabIndex = 3;
			tbx_ProvinceName.TextChanged +=  tbx_ProvinceName_TextChanged ;
			tbx_ProvinceName.Enter +=  tbx_ProvinceName_Enter ;
			tbx_ProvinceName.Leave +=  tbx_ProvinceName_Leave ;
			// 
			// tbx_PostalCode
			// 
			tbx_PostalCode.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_PostalCode.Location = new Point( 149, 383 );
			tbx_PostalCode.Name = "tbx_PostalCode";
			tbx_PostalCode.Size = new Size( 138, 22 );
			tbx_PostalCode.TabIndex = 3;
			tbx_PostalCode.TextChanged +=  tbx_PostalCode_TextChanged ;
			tbx_PostalCode.Enter +=  tbx_PostalCode_Enter ;
			tbx_PostalCode.Leave +=  tbx_PostalCode_Leave ;
			// 
			// tbx_CountryName
			// 
			tbx_CountryName.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_CountryName.Location = new Point( 148, 608 );
			tbx_CountryName.Name = "tbx_CountryName";
			tbx_CountryName.Size = new Size( 316, 22 );
			tbx_CountryName.TabIndex = 2;
			// 
			// lbl_ProvinceCode
			// 
			lbl_ProvinceCode.AutoSize = true;
			lbl_ProvinceCode.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_ProvinceCode.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_ProvinceCode.Location = new Point( 12, 274 );
			lbl_ProvinceCode.Name = "lbl_ProvinceCode";
			lbl_ProvinceCode.Size = new Size( 132, 19 );
			lbl_ProvinceCode.TabIndex = 46;
			lbl_ProvinceCode.Text = "Province Code: pa";
			// 
			// tbx_HouseNumber
			// 
			tbx_HouseNumber.BackColor = Color.White;
			tbx_HouseNumber.Font = new Font( "Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_HouseNumber.Location = new Point( 149, 12 );
			tbx_HouseNumber.Name = "tbx_HouseNumber";
			tbx_HouseNumber.Size = new Size( 138, 23 );
			tbx_HouseNumber.TabIndex = 0;
			tbx_HouseNumber.TextChanged +=  tbx_HouseNumber_TextChanged ;
			tbx_HouseNumber.Enter +=  tbx_HouseNumber_Enter ;
			tbx_HouseNumber.Leave +=  tbx_HouseNumber_Leave ;
			// 
			// lbl_CountryName
			// 
			lbl_CountryName.AutoSize = true;
			lbl_CountryName.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_CountryName.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_CountryName.Location = new Point( 14, 611 );
			lbl_CountryName.Name = "lbl_CountryName";
			lbl_CountryName.Size = new Size( 130, 19 );
			lbl_CountryName.TabIndex = 59;
			lbl_CountryName.Text = "Country Name: cy";
			// 
			// tbx_ProvinceCode
			// 
			tbx_ProvinceCode.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_ProvinceCode.Location = new Point( 149, 273 );
			tbx_ProvinceCode.Name = "tbx_ProvinceCode";
			tbx_ProvinceCode.Size = new Size( 138, 22 );
			tbx_ProvinceCode.TabIndex = 5;
			tbx_ProvinceCode.TextChanged +=  tbx_ProvinceCode_TextChanged ;
			tbx_ProvinceCode.Enter +=  tbx_ProvinceCode_Enter ;
			tbx_ProvinceCode.Leave +=  tbx_ProvinceCode_Leave ;
			// 
			// tbx_Metropolitan
			// 
			tbx_Metropolitan.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Metropolitan.Location = new Point( 149, 215 );
			tbx_Metropolitan.Name = "tbx_Metropolitan";
			tbx_Metropolitan.Size = new Size( 138, 22 );
			tbx_Metropolitan.TabIndex = 1;
			tbx_Metropolitan.TextChanged +=  tbx_Metropolitan_TextChanged ;
			tbx_Metropolitan.Enter +=  tbx_Metropolitan_Enter ;
			tbx_Metropolitan.Leave +=  tbx_Metropolitan_Leave ;
			// 
			// lbl_Province
			// 
			lbl_Province.AutoSize = true;
			lbl_Province.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Province.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Province.Location = new Point( 51, 245 );
			lbl_Province.Name = "lbl_Province";
			lbl_Province.Size = new Size( 93, 19 );
			lbl_Province.TabIndex = 43;
			lbl_Province.Text = "Province: pv";
			// 
			// tbx_Extension
			// 
			tbx_Extension.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Extension.Location = new Point( 149, 527 );
			tbx_Extension.Name = "tbx_Extension";
			tbx_Extension.Size = new Size( 316, 22 );
			tbx_Extension.TabIndex = 3;
			tbx_Extension.TextChanged +=  tbx_Extension_TextChanged ;
			tbx_Extension.Enter +=  tbx_Extension_Enter ;
			tbx_Extension.Leave +=  tbx_Extension_Leave ;
			// 
			// cbx_StreetName
			// 
			cbx_StreetName.BackColor = Color.PaleTurquoise;
			cbx_StreetName.Font = new Font( "Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point );
			cbx_StreetName.FormattingEnabled = true;
			cbx_StreetName.Location = new Point( 293, 41 );
			cbx_StreetName.Name = "cbx_StreetName";
			cbx_StreetName.Size = new Size( 172, 24 );
			cbx_StreetName.TabIndex = 1;
			cbx_StreetName.SelectedValueChanged +=  cbx_StreetName_SelectedValueChanged ;
			// 
			// tbx_Suburb
			// 
			tbx_Suburb.Font = new Font( "Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Suburb.Location = new Point( 149, 128 );
			tbx_Suburb.Name = "tbx_Suburb";
			tbx_Suburb.Size = new Size( 138, 23 );
			tbx_Suburb.TabIndex = 7;
			tbx_Suburb.TextChanged +=  tbx_Suburb_TextChanged ;
			tbx_Suburb.Enter +=  tbx_Suburb_Enter ;
			tbx_Suburb.Leave +=  tbx_Suburb_Leave ;
			// 
			// cbx_City
			// 
			cbx_City.BackColor = Color.PaleTurquoise;
			cbx_City.Font = new Font( "Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point );
			cbx_City.FormattingEnabled = true;
			cbx_City.Location = new Point( 293, 157 );
			cbx_City.Name = "cbx_City";
			cbx_City.Size = new Size( 172, 24 );
			cbx_City.TabIndex = 8;
			cbx_City.SelectedValueChanged +=  cbx_City_SelectedValueChanged ;
			// 
			// tbx_RuralDelivery
			// 
			tbx_RuralDelivery.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_RuralDelivery.Location = new Point( 149, 353 );
			tbx_RuralDelivery.Name = "tbx_RuralDelivery";
			tbx_RuralDelivery.Size = new Size( 138, 22 );
			tbx_RuralDelivery.TabIndex = 1;
			tbx_RuralDelivery.TextChanged +=  tbx_RuralDelivery_TextChanged ;
			tbx_RuralDelivery.Enter +=  tbx_RuralDelivery_Enter ;
			tbx_RuralDelivery.Leave +=  tbx_RuralDelivery_Leave ;
			// 
			// lbl_Suburb
			// 
			lbl_Suburb.AutoSize = true;
			lbl_Suburb.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Suburb.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Suburb.Location = new Point( 60, 132 );
			lbl_Suburb.Name = "lbl_Suburb";
			lbl_Suburb.Size = new Size( 84, 19 );
			lbl_Suburb.TabIndex = 33;
			lbl_Suburb.Text = "Suburb : sb";
			// 
			// lbl_City
			// 
			lbl_City.AutoSize = true;
			lbl_City.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_City.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_City.Location = new Point( 89, 161 );
			lbl_City.Name = "lbl_City";
			lbl_City.Size = new Size( 55, 19 );
			lbl_City.TabIndex = 37;
			lbl_City.Text = "City: ct";
			// 
			// lbl_Extention
			// 
			lbl_Extention.AutoSize = true;
			lbl_Extention.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Extention.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Extention.Location = new Point( 49, 530 );
			lbl_Extention.Name = "lbl_Extention";
			lbl_Extention.Size = new Size( 95, 19 );
			lbl_Extention.TabIndex = 15;
			lbl_Extention.Text = "Extention: ex";
			// 
			// tbx_City
			// 
			tbx_City.Font = new Font( "Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_City.Location = new Point( 149, 158 );
			tbx_City.Name = "tbx_City";
			tbx_City.Size = new Size( 138, 23 );
			tbx_City.TabIndex = 9;
			tbx_City.TextChanged +=  tbx_City_TextChanged ;
			tbx_City.Enter +=  tbx_City_Enter ;
			tbx_City.Leave +=  tbx_City_Leave ;
			// 
			// lbl_HouseNumber
			// 
			lbl_HouseNumber.AutoSize = true;
			lbl_HouseNumber.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_HouseNumber.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_HouseNumber.Location = new Point( 9, 15 );
			lbl_HouseNumber.Name = "lbl_HouseNumber";
			lbl_HouseNumber.Size = new Size( 135, 19 );
			lbl_HouseNumber.TabIndex = 18;
			lbl_HouseNumber.Text = "House Number: hn";
			// 
			// cbx_Suburb
			// 
			cbx_Suburb.BackColor = Color.PaleTurquoise;
			cbx_Suburb.Font = new Font( "Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point );
			cbx_Suburb.FormattingEnabled = true;
			cbx_Suburb.Location = new Point( 293, 128 );
			cbx_Suburb.Name = "cbx_Suburb";
			cbx_Suburb.Size = new Size( 172, 24 );
			cbx_Suburb.TabIndex = 6;
			cbx_Suburb.SelectedValueChanged +=  cbx_Suburb_SelectedValueChanged ;
			// 
			// cbx_StreetType
			// 
			cbx_StreetType.BackColor = Color.PaleTurquoise;
			cbx_StreetType.Font = new Font( "Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point );
			cbx_StreetType.FormattingEnabled = true;
			cbx_StreetType.Location = new Point( 293, 70 );
			cbx_StreetType.Name = "cbx_StreetType";
			cbx_StreetType.Size = new Size( 172, 24 );
			cbx_StreetType.TabIndex = 3;
			cbx_StreetType.SelectedValueChanged +=  cbx_StreetType_SelectedValueChanged ;
			// 
			// tbx_Assemblage
			// 
			tbx_Assemblage.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Assemblage.Location = new Point( 149, 442 );
			tbx_Assemblage.Name = "tbx_Assemblage";
			tbx_Assemblage.Size = new Size( 315, 22 );
			tbx_Assemblage.TabIndex = 0;
			tbx_Assemblage.TextChanged +=  tbx_Assemblage_TextChanged ;
			tbx_Assemblage.Enter +=  tbx_Assemblage_Enter ;
			tbx_Assemblage.Leave +=  tbx_Assemblage_Leave ;
			// 
			// tbx_StreetName
			// 
			tbx_StreetName.Font = new Font( "Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_StreetName.Location = new Point( 149, 41 );
			tbx_StreetName.Name = "tbx_StreetName";
			tbx_StreetName.Size = new Size( 138, 23 );
			tbx_StreetName.TabIndex = 2;
			tbx_StreetName.TextChanged +=  tbx_StreetName_TextChanged ;
			tbx_StreetName.Enter +=  tbx_StreetName_Enter ;
			tbx_StreetName.Leave +=  tbx_StreetName_Leave ;
			// 
			// lbl_Assemblage
			// 
			lbl_Assemblage.AutoSize = true;
			lbl_Assemblage.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Assemblage.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Assemblage.Location = new Point( 32, 444 );
			lbl_Assemblage.Name = "lbl_Assemblage";
			lbl_Assemblage.Size = new Size( 112, 19 );
			lbl_Assemblage.TabIndex = 6;
			lbl_Assemblage.Text = "Assemblage: as";
			// 
			// lbl_RuralDelivery
			// 
			lbl_RuralDelivery.AutoSize = true;
			lbl_RuralDelivery.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_RuralDelivery.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_RuralDelivery.Location = new Point( 16, 355 );
			lbl_RuralDelivery.Name = "lbl_RuralDelivery";
			lbl_RuralDelivery.Size = new Size( 128, 19 );
			lbl_RuralDelivery.TabIndex = 3;
			lbl_RuralDelivery.Text = "Rural Delivery: rd";
			// 
			// lbl_StreetName
			// 
			lbl_StreetName.AutoSize = true;
			lbl_StreetName.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_StreetName.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_StreetName.Location = new Point( 29, 41 );
			lbl_StreetName.Name = "lbl_StreetName";
			lbl_StreetName.Size = new Size( 115, 19 );
			lbl_StreetName.TabIndex = 22;
			lbl_StreetName.Text = "Street Name: sn";
			// 
			// lbl_Compass
			// 
			lbl_Compass.AutoSize = true;
			lbl_Compass.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Compass.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Compass.Location = new Point( 51, 102 );
			lbl_Compass.Name = "lbl_Compass";
			lbl_Compass.Size = new Size( 93, 19 );
			lbl_Compass.TabIndex = 29;
			lbl_Compass.Text = "Compass: cp";
			// 
			// tbx_Level
			// 
			tbx_Level.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Level.Location = new Point( 149, 471 );
			tbx_Level.Name = "tbx_Level";
			tbx_Level.Size = new Size( 138, 22 );
			tbx_Level.TabIndex = 1;
			tbx_Level.TextChanged +=  tbx_Level_TextChanged ;
			tbx_Level.Enter +=  tbx_Level_Enter ;
			tbx_Level.Leave +=  tbx_Level_Leave ;
			// 
			// tbx_Compass
			// 
			tbx_Compass.Font = new Font( "Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Compass.Location = new Point( 149, 99 );
			tbx_Compass.Name = "tbx_Compass";
			tbx_Compass.Size = new Size( 138, 23 );
			tbx_Compass.TabIndex = 5;
			tbx_Compass.TextChanged +=  tbx_Compass_TextChanged ;
			tbx_Compass.Enter +=  tbx_Compass_Enter ;
			tbx_Compass.Leave +=  tbx_Compass_Leave ;
			// 
			// tbx_BoxNumber
			// 
			tbx_BoxNumber.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_BoxNumber.Location = new Point( 149, 324 );
			tbx_BoxNumber.Name = "tbx_BoxNumber";
			tbx_BoxNumber.Size = new Size( 138, 22 );
			tbx_BoxNumber.TabIndex = 0;
			tbx_BoxNumber.TextChanged +=  tbx_BoxNumber_TextChanged ;
			tbx_BoxNumber.Enter +=  tbx_BoxNumber_Enter ;
			tbx_BoxNumber.Leave +=  tbx_BoxNumber_Leave ;
			// 
			// tbx_StreetType
			// 
			tbx_StreetType.Font = new Font( "Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_StreetType.Location = new Point( 149, 70 );
			tbx_StreetType.Name = "tbx_StreetType";
			tbx_StreetType.Size = new Size( 138, 23 );
			tbx_StreetType.TabIndex = 4;
			tbx_StreetType.TextChanged +=  tbx_StreetType_TextChanged ;
			tbx_StreetType.Enter +=  tbx_StreetType_Enter ;
			tbx_StreetType.Leave +=  tbx_StreetType_Leave ;
			// 
			// lbl_StreetType
			// 
			lbl_StreetType.AutoSize = true;
			lbl_StreetType.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_StreetType.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_StreetType.Location = new Point( 40, 73 );
			lbl_StreetType.Name = "lbl_StreetType";
			lbl_StreetType.Size = new Size( 104, 19 );
			lbl_StreetType.TabIndex = 26;
			lbl_StreetType.Text = "Street Type: st";
			// 
			// lbl_Level
			// 
			lbl_Level.AutoSize = true;
			lbl_Level.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Level.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Level.Location = new Point( 80, 473 );
			lbl_Level.Name = "lbl_Level";
			lbl_Level.Size = new Size( 64, 19 );
			lbl_Level.TabIndex = 9;
			lbl_Level.Text = "Level: lv";
			// 
			// lbl_POBox
			// 
			lbl_POBox.AutoSize = true;
			lbl_POBox.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_POBox.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_POBox.Location = new Point( 60, 327 );
			lbl_POBox.Name = "lbl_POBox";
			lbl_POBox.Size = new Size( 84, 19 );
			lbl_POBox.TabIndex = 0;
			lbl_POBox.Text = "PO Box: bx";
			// 
			// tbx_Unit
			// 
			tbx_Unit.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Unit.Location = new Point( 149, 500 );
			tbx_Unit.Name = "tbx_Unit";
			tbx_Unit.Size = new Size( 138, 22 );
			tbx_Unit.TabIndex = 2;
			tbx_Unit.TextChanged +=  tbx_Unit_TextChanged ;
			tbx_Unit.Enter +=  tbx_Unit_Enter ;
			tbx_Unit.Leave +=  tbx_Unit_Leave ;
			// 
			// lbl_Unit
			// 
			lbl_Unit.AutoSize = true;
			lbl_Unit.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Unit.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Unit.Location = new Point( 84, 502 );
			lbl_Unit.Name = "lbl_Unit";
			lbl_Unit.Size = new Size( 60, 19 );
			lbl_Unit.TabIndex = 12;
			lbl_Unit.Text = "Unit: un";
			// 
			// btn_DefaultExtendedRule
			// 
			btn_DefaultExtendedRule.Font = new Font( "Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point );
			btn_DefaultExtendedRule.Location = new Point( 490, 391 );
			btn_DefaultExtendedRule.Name = "btn_DefaultExtendedRule";
			btn_DefaultExtendedRule.Size = new Size( 97, 23 );
			btn_DefaultExtendedRule.TabIndex = 4;
			btn_DefaultExtendedRule.Text = "Extentions";
			btn_DefaultExtendedRule.UseVisualStyleBackColor = true;
			btn_DefaultExtendedRule.Click +=  btn_DefaultExtendedRule_Click ;
			// 
			// btn_DefaultPhysicalRule
			// 
			btn_DefaultPhysicalRule.Font = new Font( "Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point );
			btn_DefaultPhysicalRule.Location = new Point( 490, 202 );
			btn_DefaultPhysicalRule.Name = "btn_DefaultPhysicalRule";
			btn_DefaultPhysicalRule.Size = new Size( 97, 27 );
			btn_DefaultPhysicalRule.TabIndex = 2;
			btn_DefaultPhysicalRule.Text = "Physical";
			btn_DefaultPhysicalRule.UseVisualStyleBackColor = true;
			btn_DefaultPhysicalRule.Click +=  btn_DefaultPhysicalRule_Click ;
			// 
			// btn_DefaultPostalRule
			// 
			btn_DefaultPostalRule.Font = new Font( "Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point );
			btn_DefaultPostalRule.Location = new Point( 490, 20 );
			btn_DefaultPostalRule.Name = "btn_DefaultPostalRule";
			btn_DefaultPostalRule.Size = new Size( 94, 23 );
			btn_DefaultPostalRule.TabIndex = 0;
			btn_DefaultPostalRule.Text = "Postal";
			btn_DefaultPostalRule.UseVisualStyleBackColor = true;
			btn_DefaultPostalRule.Click +=  btn_DefaultPostalRule_Click ;
			// 
			// tbx_PhysicalRealised
			// 
			tbx_PhysicalRealised.AcceptsReturn = true;
			tbx_PhysicalRealised.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_PhysicalRealised.Location = new Point( 591, 235 );
			tbx_PhysicalRealised.Multiline = true;
			tbx_PhysicalRealised.Name = "tbx_PhysicalRealised";
			tbx_PhysicalRealised.Size = new Size( 385, 134 );
			tbx_PhysicalRealised.TabIndex = 5;
			tbx_PhysicalRealised.TabStop = false;
			// 
			// tbx_ExtendedRealised
			// 
			tbx_ExtendedRealised.AcceptsReturn = true;
			tbx_ExtendedRealised.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_ExtendedRealised.Location = new Point( 591, 424 );
			tbx_ExtendedRealised.Multiline = true;
			tbx_ExtendedRealised.Name = "tbx_ExtendedRealised";
			tbx_ExtendedRealised.Size = new Size( 385, 119 );
			tbx_ExtendedRealised.TabIndex = 9;
			tbx_ExtendedRealised.TabStop = false;
			// 
			// tbx_PostalRealised
			// 
			tbx_PostalRealised.AcceptsReturn = true;
			tbx_PostalRealised.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_PostalRealised.Location = new Point( 591, 53 );
			tbx_PostalRealised.Multiline = true;
			tbx_PostalRealised.Name = "tbx_PostalRealised";
			tbx_PostalRealised.Size = new Size( 385, 125 );
			tbx_PostalRealised.TabIndex = 1;
			tbx_PostalRealised.TabStop = false;
			// 
			// tbx_XL_RowRealised
			// 
			tbx_XL_RowRealised.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_XL_RowRealised.Location = new Point( 491, 600 );
			tbx_XL_RowRealised.Name = "tbx_XL_RowRealised";
			tbx_XL_RowRealised.Size = new Size( 660, 22 );
			tbx_XL_RowRealised.TabIndex = 2;
			tbx_XL_RowRealised.TabStop = false;
			// 
			// lbl_N
			// 
			lbl_N.AutoSize = true;
			lbl_N.Location = new Point( 1112, 127 );
			lbl_N.Name = "lbl_N";
			lbl_N.Size = new Size( 14, 15 );
			lbl_N.TabIndex = 13;
			lbl_N.Text = "n";
			// 
			// lbl_One
			// 
			lbl_One.AutoSize = true;
			lbl_One.Location = new Point( 1019, 127 );
			lbl_One.Name = "lbl_One";
			lbl_One.Size = new Size( 14, 15 );
			lbl_One.TabIndex = 12;
			lbl_One.Text = "1";
			// 
			// btn_FindAddress
			// 
			btn_FindAddress.BackColor = Color.FromArgb(     224,     224,     224 );
			btn_FindAddress.FlatStyle = FlatStyle.Popup;
			btn_FindAddress.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_FindAddress.ForeColor = Color.Maroon;
			btn_FindAddress.Location = new Point( 1013, 153 );
			btn_FindAddress.Name = "btn_FindAddress";
			btn_FindAddress.Size = new Size( 135, 35 );
			btn_FindAddress.TabIndex = 5;
			btn_FindAddress.Text = "Find Address";
			btn_FindAddress.UseVisualStyleBackColor = false;
			btn_FindAddress.Click +=  btn_FindAddress_Click ;
			// 
			// btn_FirstAddress
			// 
			btn_FirstAddress.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_FirstAddress.Location = new Point( 1013, 91 );
			btn_FirstAddress.Name = "btn_FirstAddress";
			btn_FirstAddress.Size = new Size( 32, 35 );
			btn_FirstAddress.TabIndex = 1;
			btn_FirstAddress.Text = "|<";
			btn_FirstAddress.UseVisualStyleBackColor = true;
			btn_FirstAddress.Click +=  btn_FirstAddress_Click ;
			// 
			// btn_InsertAddress
			// 
			btn_InsertAddress.BackColor = Color.FromArgb(     224,     224,     224 );
			btn_InsertAddress.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_InsertAddress.ForeColor = Color.Maroon;
			btn_InsertAddress.Location = new Point( 1013, 284 );
			btn_InsertAddress.Name = "btn_InsertAddress";
			btn_InsertAddress.Size = new Size( 135, 35 );
			btn_InsertAddress.TabIndex = 6;
			btn_InsertAddress.Text = "Insert Address";
			btn_InsertAddress.UseVisualStyleBackColor = false;
			btn_InsertAddress.Click +=  btn_InsertAddress_Click ;
			// 
			// btn_PreviousAddress
			// 
			btn_PreviousAddress.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_PreviousAddress.Location = new Point( 1048, 91 );
			btn_PreviousAddress.Name = "btn_PreviousAddress";
			btn_PreviousAddress.Size = new Size( 27, 35 );
			btn_PreviousAddress.TabIndex = 2;
			btn_PreviousAddress.Text = "<";
			btn_PreviousAddress.UseVisualStyleBackColor = true;
			btn_PreviousAddress.Click +=  btn_PreviousAddress_Click ;
			// 
			// btn_CloseForm
			// 
			btn_CloseForm.BackColor = Color.FromArgb(     224,     224,     224 );
			btn_CloseForm.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_CloseForm.ForeColor = Color.Maroon;
			btn_CloseForm.Location = new Point( 1009, 508 );
			btn_CloseForm.Name = "btn_CloseForm";
			btn_CloseForm.Size = new Size( 135, 35 );
			btn_CloseForm.TabIndex = 8;
			btn_CloseForm.Text = "Close";
			btn_CloseForm.UseVisualStyleBackColor = false;
			btn_CloseForm.Click +=  btn_CloseForm_Click ;
			// 
			// btn_LastAddress
			// 
			btn_LastAddress.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_LastAddress.Location = new Point( 1108, 91 );
			btn_LastAddress.Name = "btn_LastAddress";
			btn_LastAddress.Size = new Size( 27, 35 );
			btn_LastAddress.TabIndex = 4;
			btn_LastAddress.Text = ">|";
			btn_LastAddress.UseVisualStyleBackColor = true;
			btn_LastAddress.Click +=  btn_LastAddress_Click ;
			// 
			// btn_UpdateAddress
			// 
			btn_UpdateAddress.BackColor = Color.FromArgb(     224,     224,     224 );
			btn_UpdateAddress.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_UpdateAddress.ForeColor = Color.Maroon;
			btn_UpdateAddress.Location = new Point( 1013, 243 );
			btn_UpdateAddress.Name = "btn_UpdateAddress";
			btn_UpdateAddress.Size = new Size( 135, 35 );
			btn_UpdateAddress.TabIndex = 7;
			btn_UpdateAddress.Text = "Update Address";
			btn_UpdateAddress.UseVisualStyleBackColor = false;
			btn_UpdateAddress.Click +=  btn_Update_Click ;
			// 
			// btn_NextAddress
			// 
			btn_NextAddress.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_NextAddress.Location = new Point( 1078, 91 );
			btn_NextAddress.Name = "btn_NextAddress";
			btn_NextAddress.Size = new Size( 27, 35 );
			btn_NextAddress.TabIndex = 3;
			btn_NextAddress.Text = ">";
			btn_NextAddress.UseVisualStyleBackColor = true;
			btn_NextAddress.Click +=  btn_NextAddress_Click ;
			// 
			// lbl_PkAddress
			// 
			lbl_PkAddress.AutoSize = true;
			lbl_PkAddress.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_PkAddress.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_PkAddress.Location = new Point( 1027, 26 );
			lbl_PkAddress.Name = "lbl_PkAddress";
			lbl_PkAddress.Size = new Size( 30, 21 );
			lbl_PkAddress.TabIndex = 4;
			lbl_PkAddress.Text = "PK";
			// 
			// tbx_Filter
			// 
			tbx_Filter.BackColor = Color.FromArgb(     255,     192,     192 );
			tbx_Filter.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Filter.Location = new Point( 1060, 61 );
			tbx_Filter.MaxLength = 6;
			tbx_Filter.Name = "tbx_Filter";
			tbx_Filter.Size = new Size( 73, 25 );
			tbx_Filter.TabIndex = 0;
			tbx_Filter.TextAlign = HorizontalAlignment.Right;
			tbx_Filter.KeyUp +=  tbx_Filter_KeyUp ;
			// 
			// tbx_PkAddress
			// 
			tbx_PkAddress.AcceptsReturn = true;
			tbx_PkAddress.BackColor = Color.FromArgb(     192,     192,     255 );
			tbx_PkAddress.Enabled = false;
			tbx_PkAddress.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_PkAddress.Location = new Point( 1060, 24 );
			tbx_PkAddress.Name = "tbx_PkAddress";
			tbx_PkAddress.PlaceholderText = "PK";
			tbx_PkAddress.ReadOnly = true;
			tbx_PkAddress.Size = new Size( 73, 25 );
			tbx_PkAddress.TabIndex = 0;
			tbx_PkAddress.TabStop = false;
			// 
			// lbl_Move
			// 
			lbl_Move.AutoSize = true;
			lbl_Move.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Move.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Move.ImageAlign = ContentAlignment.MiddleRight;
			lbl_Move.Location = new Point( 1006, 63 );
			lbl_Move.Name = "lbl_Move";
			lbl_Move.Size = new Size( 53, 21 );
			lbl_Move.TabIndex = 0;
			lbl_Move.Text = "Move";
			lbl_Move.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_IsoCodes
			// 
			lbl_IsoCodes.AutoSize = true;
			lbl_IsoCodes.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_IsoCodes.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_IsoCodes.Location = new Point( 253, 639 );
			lbl_IsoCodes.Name = "lbl_IsoCodes";
			lbl_IsoCodes.Size = new Size( 81, 19 );
			lbl_IsoCodes.TabIndex = 65;
			lbl_IsoCodes.Text = "ISO Codes:";
			// 
			// lbl_Country
			// 
			lbl_Country.AutoSize = true;
			lbl_Country.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Country.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Country.Location = new Point( 60, 581 );
			lbl_Country.Name = "lbl_Country";
			lbl_Country.Size = new Size( 84, 19 );
			lbl_Country.TabIndex = 56;
			lbl_Country.Text = "Country: fk";
			// 
			// chk_Christmas
			// 
			chk_Christmas.AutoSize = true;
			chk_Christmas.CheckAlign = ContentAlignment.MiddleRight;
			chk_Christmas.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			chk_Christmas.ForeColor = Color.FromArgb(     192,     0,     0 );
			chk_Christmas.Location = new Point( 1019, 385 );
			chk_Christmas.Name = "chk_Christmas";
			chk_Christmas.Size = new Size( 99, 23 );
			chk_Christmas.TabIndex = 2;
			chk_Christmas.Text = "Christmas?";
			chk_Christmas.UseVisualStyleBackColor = true;
			chk_Christmas.CheckedChanged +=  chk_Christmas_CheckedChanged ;
			// 
			// tbx_FkCountry
			// 
			tbx_FkCountry.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_FkCountry.Location = new Point( 149, 578 );
			tbx_FkCountry.Name = "tbx_FkCountry";
			tbx_FkCountry.Size = new Size( 51, 22 );
			tbx_FkCountry.TabIndex = 1;
			tbx_FkCountry.TabStop = false;
			// 
			// btn_DefaultExcelRule
			// 
			btn_DefaultExcelRule.Font = new Font( "Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point );
			btn_DefaultExcelRule.Location = new Point( 491, 569 );
			btn_DefaultExcelRule.Name = "btn_DefaultExcelRule";
			btn_DefaultExcelRule.Size = new Size( 93, 23 );
			btn_DefaultExcelRule.TabIndex = 0;
			btn_DefaultExcelRule.Text = "Excel";
			btn_DefaultExcelRule.UseVisualStyleBackColor = true;
			btn_DefaultExcelRule.Click +=  btn_DefaultExcelRule_Click ;
			// 
			// cbx_ProvinceCode
			// 
			cbx_ProvinceCode.BackColor = Color.PaleTurquoise;
			cbx_ProvinceCode.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			cbx_ProvinceCode.FormattingEnabled = true;
			cbx_ProvinceCode.Location = new Point( 293, 272 );
			cbx_ProvinceCode.Name = "cbx_ProvinceCode";
			cbx_ProvinceCode.Size = new Size( 172, 24 );
			cbx_ProvinceCode.TabIndex = 4;
			cbx_ProvinceCode.SelectedValueChanged +=  cbx_ProvinceCode_SelectedValueChanged ;
			// 
			// cbx_Metropolitan
			// 
			cbx_Metropolitan.BackColor = Color.PaleTurquoise;
			cbx_Metropolitan.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			cbx_Metropolitan.FormattingEnabled = true;
			cbx_Metropolitan.Location = new Point( 293, 215 );
			cbx_Metropolitan.Name = "cbx_Metropolitan";
			cbx_Metropolitan.Size = new Size( 172, 24 );
			cbx_Metropolitan.TabIndex = 0;
			cbx_Metropolitan.SelectedValueChanged +=  cbx_Metropolitan_SelectedValueChanged ;
			// 
			// tbx_Messages
			// 
			tbx_Messages.BackColor = Color.FromArgb(     255,     255,     192 );
			tbx_Messages.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Messages.ForeColor = Color.ForestGreen;
			tbx_Messages.Location = new Point( 491, 635 );
			tbx_Messages.Name = "tbx_Messages";
			tbx_Messages.Size = new Size( 660, 23 );
			tbx_Messages.TabIndex = 147;
			tbx_Messages.TabStop = false;
			// 
			// FrmAddress
			// 
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_CloseForm;
			ClientSize = new Size( 1170, 692 );
			Controls.Add( tbx_Messages );
			Controls.Add( chk_Christmas );
			Controls.Add( tbx_Assemblage );
			Controls.Add( lbl_Unit );
			Controls.Add( cbx_Country );
			Controls.Add( lbl_CountryName );
			Controls.Add( tbx_BoxNumber );
			Controls.Add( lbl_Country );
			Controls.Add( tbx_RuralDelivery );
			Controls.Add( lbl_IsoCodes );
			Controls.Add( tbx_Unit );
			Controls.Add( tbx_CountryName );
			Controls.Add( cbx_ProvinceCode );
			Controls.Add( tbx_ShortIsoCode );
			Controls.Add( lbl_RuralDelivery );
			Controls.Add( tbx_FkCountry );
			Controls.Add( lbl_Level );
			Controls.Add( lbl_CountryCode );
			Controls.Add( tbx_StreetName );
			Controls.Add( tbx_LongIsoCode );
			Controls.Add( tbx_CountryCode );
			Controls.Add( lbl_POBox );
			Controls.Add( tbx_Level );
			Controls.Add( cbx_Metropolitan );
			Controls.Add( lbl_Assemblage );
			Controls.Add( btn_DefaultExcelRule );
			Controls.Add( lbl_Extention );
			Controls.Add( tbx_Extension );
			Controls.Add( cbx_Suburb );
			Controls.Add( cbx_PostalCode );
			Controls.Add( tbx_PostalCode );
			Controls.Add( tbx_XL_RowRealised );
			Controls.Add( lbl_PostalCode );
			Controls.Add( cbx_StreetName );
			Controls.Add( lbl_Province );
			Controls.Add( btn_DefaultExtendedRule );
			Controls.Add( tbx_Metropolitan );
			Controls.Add( tbx_ProvinceCode );
			Controls.Add( cbx_ProvinceName );
			Controls.Add( tbx_ExcelPattern );
			Controls.Add( lbl_ProvinceCode );
			Controls.Add( tbx_ProvinceName );
			Controls.Add( lbl_N );
			Controls.Add( lbl_Metropolitan );
			Controls.Add( btn_DefaultPhysicalRule );
			Controls.Add( tbx_HouseNumber );
			Controls.Add( tbx_Suburb );
			Controls.Add( btn_DefaultPostalRule );
			Controls.Add( lbl_HouseNumber );
			Controls.Add( lbl_One );
			Controls.Add( cbx_City );
			Controls.Add( tbx_PhysicalRealised );
			Controls.Add( cbx_StreetType );
			Controls.Add( tbx_ExtendedRealised );
			Controls.Add( lbl_Suburb );
			Controls.Add( btn_FindAddress );
			Controls.Add( lbl_StreetName );
			Controls.Add( tbx_VcfExtended );
			Controls.Add( lbl_Compass );
			Controls.Add( tbx_VcfPostal );
			Controls.Add( lbl_City );
			Controls.Add( tbx_PostalRealised );
			Controls.Add( tbx_Compass );
			Controls.Add( btn_FirstAddress );
			Controls.Add( tbx_StreetType );
			Controls.Add( tbx_VcfPhysical );
			Controls.Add( tbx_City );
			Controls.Add( lbl_StreetType );
			Controls.Add( btn_InsertAddress );
			Controls.Add( btn_PreviousAddress );
			Controls.Add( btn_CloseForm );
			Controls.Add( btn_LastAddress );
			Controls.Add( btn_UpdateAddress );
			Controls.Add( btn_NextAddress );
			Controls.Add( lbl_PkAddress );
			Controls.Add( tbx_PkAddress );
			Controls.Add( tbx_Filter );
			Controls.Add( lbl_Move );
			Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			Name = "FrmAddress";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Addresses";
			ResumeLayout( false );
			PerformLayout();

		}

		#endregion
		private Button btn_CloseForm;
		private Button btn_DefaultExcelRule;
		private Button btn_DefaultExtendedRule;
		private Button btn_DefaultPhysicalRule;
		private Button btn_DefaultPostalRule;
		private Button btn_FindAddress;
		private Button btn_FirstAddress;
		private Button btn_InsertAddress;
		private Button btn_LastAddress;
		private Button btn_NextAddress;
		private Button btn_PreviousAddress;
		private Button btn_UpdateAddress;
		private CheckBox chk_Christmas;
		private ComboBox cbx_City;
		private ComboBox cbx_Country;
		private ComboBox cbx_Metropolitan;
		private ComboBox cbx_PostalCode;
		private ComboBox cbx_ProvinceCode;
		private ComboBox cbx_ProvinceName;
		private ComboBox cbx_StreetName;
		private ComboBox cbx_StreetType;
		private ComboBox cbx_Suburb;
		private Label lbl_Assemblage;
		private Label lbl_City;
		private Label lbl_Compass;
		private Label lbl_Country;
		private Label lbl_CountryCode;
		private Label lbl_CountryName;
		private Label lbl_Extention;
		private Label lbl_HouseNumber;
		private Label lbl_IsoCodes;
		private Label lbl_Level;
		private Label lbl_Metropolitan;
		private Label lbl_Move;
		private Label lbl_N;
		private Label lbl_One;
		private Label lbl_PkAddress;
		private Label lbl_POBox;
		private Label lbl_PostalCode;
		private Label lbl_Province;
		private Label lbl_ProvinceCode;
		private Label lbl_RuralDelivery;
		private Label lbl_StreetName;
		private Label lbl_StreetType;
		private Label lbl_Suburb;
		private Label lbl_Unit;
		private TextBox tbx_Assemblage;
		private TextBox tbx_BoxNumber;
		private TextBox tbx_City;
		private TextBox tbx_Compass;
		private TextBox tbx_CountryCode;
		private TextBox tbx_CountryName;
		private TextBox tbx_ExcelPattern;
		private TextBox tbx_ExtendedRealised;
		private TextBox tbx_Extension;
		private TextBox tbx_Filter;
		private TextBox tbx_FkCountry;
		private TextBox tbx_HouseNumber;
		private TextBox tbx_Level;
		private TextBox tbx_LongIsoCode;
		private TextBox tbx_Metropolitan;
		private TextBox tbx_PhysicalRealised;
		private TextBox tbx_PkAddress;
		private TextBox tbx_PostalCode;
		private TextBox tbx_PostalRealised;
		private TextBox tbx_ProvinceCode;
		private TextBox tbx_ProvinceName;
		private TextBox tbx_RuralDelivery;
		private TextBox tbx_ShortIsoCode;
		private TextBox tbx_StreetName;
		private TextBox tbx_StreetType;
		private TextBox tbx_Suburb;
		private TextBox tbx_Unit;
		private TextBox tbx_VcfExtended;
		private TextBox tbx_VcfPhysical;
		private TextBox tbx_VcfPostal;
		private TextBox tbx_XL_RowRealised;
		private TextBox tbx_Messages;
	}
}