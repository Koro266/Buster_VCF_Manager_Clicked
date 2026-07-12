

namespace CONTACTS.INTERFACE.FORMS
{
	public partial class FrmDevice
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
			tbx_PickerNumber = new TextBox();
			tbx_DialNumber = new TextBox();
			btn_UpdateDevice = new Button();
			tbx_TrailingDigits = new TextBox();
			tbx_LeadingDigits = new TextBox();
			tbx_ShortAreaCode = new TextBox();
			tbx_LongAreaCode = new TextBox();
			lbl_PickerNumber = new Label();
			lbl_DialNumber = new Label();
			lbl_TrailingDigits = new Label();
			lbl_LeadingDigits = new Label();
			lbl_ShortAreaCode = new Label();
			lbl_LongAreaCode = new Label();
			lbl_CountryId = new Label();
			tbx_Prompt = new TextBox();
			btn_CloseForm = new Button();
			btn_InsertDevice = new Button();
			lbl_ButtonLast = new Label();
			lbl_ButtonFirst = new Label();
			btn_FindDevice = new Button();
			btn_FirstDevice = new Button();
			btn_PreviousDevice = new Button();
			btn_LastDevice = new Button();
			btn_NextDevice = new Button();
			lbl_FindPk = new Label();
			tbx_Filter = new TextBox();
			tbx_DeviceId = new TextBox();
			lbl_PK = new Label();
			cbx_Countries = new ComboBox();
			lbx_MatchingDevices = new ListBox();
			tbx_Matches = new TextBox();
			tbx_Notes = new TextBox();
			lbl_Note = new Label();
			lbl_Search = new Label();
			grp_DeviceData = new GroupBox();
			cbx_DeviceType = new ComboBox();
			lbl_DeviceLocation = new Label();
			lbl_DeviceType = new Label();
			cbx_DeviceLocation = new ComboBox();
			grp_DeviceData.SuspendLayout();
			SuspendLayout();
			// 
			// tbx_PickerNumber
			// 
			tbx_PickerNumber.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_PickerNumber.Location = new Point( 130, 348 );
			tbx_PickerNumber.Name = "tbx_PickerNumber";
			tbx_PickerNumber.Size = new Size( 236, 25 );
			tbx_PickerNumber.TabIndex = 12;
			tbx_PickerNumber.TabStop = false;
			// 
			// tbx_DialNumber
			// 
			tbx_DialNumber.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_DialNumber.Location = new Point( 130, 317 );
			tbx_DialNumber.Name = "tbx_DialNumber";
			tbx_DialNumber.Size = new Size( 236, 25 );
			tbx_DialNumber.TabIndex = 11;
			tbx_DialNumber.TabStop = false;
			// 
			// btn_UpdateDevice
			// 
			btn_UpdateDevice.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_UpdateDevice.ForeColor = Color.Maroon;
			btn_UpdateDevice.Location = new Point( 385, 172 );
			btn_UpdateDevice.Name = "btn_UpdateDevice";
			btn_UpdateDevice.Size = new Size( 133, 35 );
			btn_UpdateDevice.TabIndex = 16;
			btn_UpdateDevice.Text = "Update Device";
			btn_UpdateDevice.UseVisualStyleBackColor = true;
			btn_UpdateDevice.Click +=  btn_UpdateDevice_Click ;
			// 
			// tbx_TrailingDigits
			// 
			tbx_TrailingDigits.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_TrailingDigits.Location = new Point( 130, 176 );
			tbx_TrailingDigits.Name = "tbx_TrailingDigits";
			tbx_TrailingDigits.Size = new Size( 91, 25 );
			tbx_TrailingDigits.TabIndex = 4;
			tbx_TrailingDigits.TextChanged +=  tbx_TrailingDigits_TextChanged ;
			// 
			// tbx_LeadingDigits
			// 
			tbx_LeadingDigits.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_LeadingDigits.Location = new Point( 130, 144 );
			tbx_LeadingDigits.Name = "tbx_LeadingDigits";
			tbx_LeadingDigits.Size = new Size( 91, 25 );
			tbx_LeadingDigits.TabIndex = 3;
			tbx_LeadingDigits.TextChanged +=  tbx_LeadingDigits_TextChanged ;
			// 
			// tbx_ShortAreaCode
			// 
			tbx_ShortAreaCode.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_ShortAreaCode.Location = new Point( 130, 112 );
			tbx_ShortAreaCode.Name = "tbx_ShortAreaCode";
			tbx_ShortAreaCode.Size = new Size( 91, 25 );
			tbx_ShortAreaCode.TabIndex = 2;
			tbx_ShortAreaCode.TextChanged +=  tbx_ShortAreaCode_TextChanged ;
			// 
			// tbx_LongAreaCode
			// 
			tbx_LongAreaCode.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_LongAreaCode.Location = new Point( 130, 82 );
			tbx_LongAreaCode.MaxLength = 80;
			tbx_LongAreaCode.Name = "tbx_LongAreaCode";
			tbx_LongAreaCode.Size = new Size( 91, 25 );
			tbx_LongAreaCode.TabIndex = 1;
			tbx_LongAreaCode.TextChanged +=  tbx_LongAreaCode_TextChanged ;
			// 
			// lbl_PickerNumber
			// 
			lbl_PickerNumber.AutoSize = true;
			lbl_PickerNumber.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_PickerNumber.ForeColor = Color.Blue;
			lbl_PickerNumber.Location = new Point( 16, 350 );
			lbl_PickerNumber.Name = "lbl_PickerNumber";
			lbl_PickerNumber.Size = new Size( 110, 19 );
			lbl_PickerNumber.TabIndex = 63;
			lbl_PickerNumber.Text = "Picker Number";
			lbl_PickerNumber.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_DialNumber
			// 
			lbl_DialNumber.AutoSize = true;
			lbl_DialNumber.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_DialNumber.ForeColor = Color.Blue;
			lbl_DialNumber.Location = new Point( 32, 319 );
			lbl_DialNumber.Name = "lbl_DialNumber";
			lbl_DialNumber.Size = new Size( 94, 19 );
			lbl_DialNumber.TabIndex = 62;
			lbl_DialNumber.Text = "Dial Number";
			lbl_DialNumber.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_TrailingDigits
			// 
			lbl_TrailingDigits.AutoSize = true;
			lbl_TrailingDigits.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_TrailingDigits.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_TrailingDigits.Location = new Point( 25, 178 );
			lbl_TrailingDigits.Name = "lbl_TrailingDigits";
			lbl_TrailingDigits.Size = new Size( 101, 19 );
			lbl_TrailingDigits.TabIndex = 58;
			lbl_TrailingDigits.Text = "Trailing Digits";
			lbl_TrailingDigits.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_LeadingDigits
			// 
			lbl_LeadingDigits.AutoSize = true;
			lbl_LeadingDigits.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_LeadingDigits.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_LeadingDigits.Location = new Point( 22, 146 );
			lbl_LeadingDigits.Name = "lbl_LeadingDigits";
			lbl_LeadingDigits.Size = new Size( 104, 19 );
			lbl_LeadingDigits.TabIndex = 56;
			lbl_LeadingDigits.Text = "Leading Digits";
			lbl_LeadingDigits.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_ShortAreaCode
			// 
			lbl_ShortAreaCode.AutoSize = true;
			lbl_ShortAreaCode.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_ShortAreaCode.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_ShortAreaCode.Location = new Point( 6, 114 );
			lbl_ShortAreaCode.Name = "lbl_ShortAreaCode";
			lbl_ShortAreaCode.Size = new Size( 120, 19 );
			lbl_ShortAreaCode.TabIndex = 54;
			lbl_ShortAreaCode.Text = "Short Area Code";
			lbl_ShortAreaCode.TextAlign = ContentAlignment.BottomLeft;
			// 
			// lbl_LongAreaCode
			// 
			lbl_LongAreaCode.AutoSize = true;
			lbl_LongAreaCode.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_LongAreaCode.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_LongAreaCode.Location = new Point( 9, 84 );
			lbl_LongAreaCode.Name = "lbl_LongAreaCode";
			lbl_LongAreaCode.Size = new Size( 117, 19 );
			lbl_LongAreaCode.TabIndex = 52;
			lbl_LongAreaCode.Text = "Long Area Code";
			lbl_LongAreaCode.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_CountryId
			// 
			lbl_CountryId.AutoSize = true;
			lbl_CountryId.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_CountryId.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_CountryId.Location = new Point( 45, 51 );
			lbl_CountryId.Name = "lbl_CountryId";
			lbl_CountryId.Size = new Size( 81, 19 );
			lbl_CountryId.TabIndex = 50;
			lbl_CountryId.Text = "Country ID";
			lbl_CountryId.TextAlign = ContentAlignment.MiddleRight;
			// 
			// tbx_Prompt
			// 
			tbx_Prompt.BackColor = Color.Beige;
			tbx_Prompt.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Prompt.ForeColor = Color.Gray;
			tbx_Prompt.Location = new Point( 267, 165 );
			tbx_Prompt.Multiline = true;
			tbx_Prompt.Name = "tbx_Prompt";
			tbx_Prompt.Size = new Size( 64, 32 );
			tbx_Prompt.TabIndex = 68;
			tbx_Prompt.TabStop = false;
			tbx_Prompt.Text = "Prompt...";
			tbx_Prompt.Visible = false;
			// 
			// btn_CloseForm
			// 
			btn_CloseForm.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			btn_CloseForm.ForeColor = Color.Maroon;
			btn_CloseForm.Location = new Point( 385, 338 );
			btn_CloseForm.Name = "btn_CloseForm";
			btn_CloseForm.Size = new Size( 133, 35 );
			btn_CloseForm.TabIndex = 17;
			btn_CloseForm.Text = "Close";
			btn_CloseForm.UseVisualStyleBackColor = true;
			btn_CloseForm.Click +=  btn_Close_Click ;
			// 
			// btn_InsertDevice
			// 
			btn_InsertDevice.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_InsertDevice.ForeColor = Color.Maroon;
			btn_InsertDevice.Location = new Point( 385, 213 );
			btn_InsertDevice.Name = "btn_InsertDevice";
			btn_InsertDevice.Size = new Size( 133, 35 );
			btn_InsertDevice.TabIndex = 15;
			btn_InsertDevice.Text = "Insert Device";
			btn_InsertDevice.UseVisualStyleBackColor = true;
			btn_InsertDevice.Click +=  btn_Insert_Click ;
			// 
			// lbl_ButtonLast
			// 
			lbl_ButtonLast.AutoSize = true;
			lbl_ButtonLast.Location = new Point( 496, 97 );
			lbl_ButtonLast.Name = "lbl_ButtonLast";
			lbl_ButtonLast.Size = new Size( 16, 17 );
			lbl_ButtonLast.TabIndex = 49;
			lbl_ButtonLast.Text = "n";
			// 
			// lbl_ButtonFirst
			// 
			lbl_ButtonFirst.AutoSize = true;
			lbl_ButtonFirst.Location = new Point( 392, 97 );
			lbl_ButtonFirst.Name = "lbl_ButtonFirst";
			lbl_ButtonFirst.Size = new Size( 15, 17 );
			lbl_ButtonFirst.TabIndex = 48;
			lbl_ButtonFirst.Text = "1";
			// 
			// btn_FindDevice
			// 
			btn_FindDevice.Font = new Font( "Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point );
			btn_FindDevice.ForeColor = Color.Maroon;
			btn_FindDevice.Location = new Point( 385, 121 );
			btn_FindDevice.Name = "btn_FindDevice";
			btn_FindDevice.Size = new Size( 133, 35 );
			btn_FindDevice.TabIndex = 13;
			btn_FindDevice.Text = "Find Device";
			btn_FindDevice.UseVisualStyleBackColor = true;
			btn_FindDevice.Click +=  btn_FindDevice_Click ;
			// 
			// btn_FirstDevice
			// 
			btn_FirstDevice.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_FirstDevice.Location = new Point( 385, 72 );
			btn_FirstDevice.Name = "btn_FirstDevice";
			btn_FirstDevice.Size = new Size( 27, 23 );
			btn_FirstDevice.TabIndex = 9;
			btn_FirstDevice.Text = "|<";
			btn_FirstDevice.UseVisualStyleBackColor = true;
			btn_FirstDevice.Click +=  btn_FirstDevice_Click ;
			// 
			// btn_PreviousDevice
			// 
			btn_PreviousDevice.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_PreviousDevice.Location = new Point( 419, 72 );
			btn_PreviousDevice.Name = "btn_PreviousDevice";
			btn_PreviousDevice.Size = new Size( 27, 23 );
			btn_PreviousDevice.TabIndex = 10;
			btn_PreviousDevice.Text = "<";
			btn_PreviousDevice.UseVisualStyleBackColor = true;
			btn_PreviousDevice.Click +=  btn_PreviousDevice_Click ;
			// 
			// btn_LastDevice
			// 
			btn_LastDevice.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_LastDevice.Location = new Point( 490, 72 );
			btn_LastDevice.Name = "btn_LastDevice";
			btn_LastDevice.Size = new Size( 27, 23 );
			btn_LastDevice.TabIndex = 12;
			btn_LastDevice.Text = ">|";
			btn_LastDevice.UseVisualStyleBackColor = true;
			btn_LastDevice.Click +=  btn_LastDevice_Click ;
			// 
			// btn_NextDevice
			// 
			btn_NextDevice.Font = new Font( "Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			btn_NextDevice.Location = new Point( 456, 72 );
			btn_NextDevice.Name = "btn_NextDevice";
			btn_NextDevice.Size = new Size( 27, 23 );
			btn_NextDevice.TabIndex = 11;
			btn_NextDevice.Text = ">";
			btn_NextDevice.UseVisualStyleBackColor = true;
			btn_NextDevice.Click +=  btn_NextDevice_Click ;
			// 
			// lbl_FindPk
			// 
			lbl_FindPk.AutoSize = true;
			lbl_FindPk.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_FindPk.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_FindPk.Location = new Point( 383, 44 );
			lbl_FindPk.Name = "lbl_FindPk";
			lbl_FindPk.Size = new Size( 71, 21 );
			lbl_FindPk.TabIndex = 47;
			lbl_FindPk.Text = "Find PK:";
			// 
			// tbx_Filter
			// 
			tbx_Filter.BackColor = Color.Honeydew;
			tbx_Filter.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Filter.Location = new Point( 456, 42 );
			tbx_Filter.MaxLength = 6;
			tbx_Filter.Name = "tbx_Filter";
			tbx_Filter.Size = new Size( 60, 25 );
			tbx_Filter.TabIndex = 8;
			tbx_Filter.TabStop = false;
			tbx_Filter.TextAlign = HorizontalAlignment.Right;
			tbx_Filter.KeyUp +=  tbx_Filter_KeyUp ;
			// 
			// tbx_DeviceId
			// 
			tbx_DeviceId.AcceptsReturn = true;
			tbx_DeviceId.BackColor = Color.FromArgb(     192,     192,     255 );
			tbx_DeviceId.Enabled = false;
			tbx_DeviceId.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_DeviceId.Location = new Point( 130, 20 );
			tbx_DeviceId.Name = "tbx_DeviceId";
			tbx_DeviceId.PlaceholderText = "PK";
			tbx_DeviceId.ReadOnly = true;
			tbx_DeviceId.Size = new Size( 60, 25 );
			tbx_DeviceId.TabIndex = 0;
			tbx_DeviceId.TabStop = false;
			// 
			// lbl_PK
			// 
			lbl_PK.AutoSize = true;
			lbl_PK.Font = new Font( "Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_PK.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_PK.Location = new Point( 94, 22 );
			lbl_PK.Name = "lbl_PK";
			lbl_PK.Size = new Size( 34, 21 );
			lbl_PK.TabIndex = 0;
			lbl_PK.Text = "PK:";
			lbl_PK.TextAlign = ContentAlignment.MiddleRight;
			// 
			// cbx_Countries
			// 
			cbx_Countries.FormattingEnabled = true;
			cbx_Countries.Location = new Point( 130, 50 );
			cbx_Countries.Name = "cbx_Countries";
			cbx_Countries.Size = new Size( 227, 25 );
			cbx_Countries.TabIndex = 0;
			cbx_Countries.SelectedIndexChanged +=  cbx_Countries_SelectedIndexChanged ;
			// 
			// lbx_MatchingDevices
			// 
			lbx_MatchingDevices.BackColor = Color.MistyRose;
			lbx_MatchingDevices.Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			lbx_MatchingDevices.ForeColor = Color.Blue;
			lbx_MatchingDevices.FormattingEnabled = true;
			lbx_MatchingDevices.ItemHeight = 15;
			lbx_MatchingDevices.Location = new Point( 532, 71 );
			lbx_MatchingDevices.Name = "lbx_MatchingDevices";
			lbx_MatchingDevices.Size = new Size( 158, 304 );
			lbx_MatchingDevices.TabIndex = 73;
			lbx_MatchingDevices.SelectedIndexChanged +=  lbx_MatchingDevices_SelectedIndexChanged ;
			// 
			// tbx_Matches
			// 
			tbx_Matches.Location = new Point( 532, 41 );
			tbx_Matches.Name = "tbx_Matches";
			tbx_Matches.Size = new Size( 158, 25 );
			tbx_Matches.TabIndex = 14;
			tbx_Matches.TextChanged +=  tbx_Matches_TextChanged ;
			// 
			// tbx_Notes
			// 
			tbx_Notes.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			tbx_Notes.Location = new Point( 130, 286 );
			tbx_Notes.Name = "tbx_Notes";
			tbx_Notes.Size = new Size( 388, 25 );
			tbx_Notes.TabIndex = 7;
			tbx_Notes.TextChanged +=  tbx_Notes_TextChanged ;
			tbx_Notes.Leave +=  tbx_Notes_Leave ;
			// 
			// lbl_Note
			// 
			lbl_Note.AutoSize = true;
			lbl_Note.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_Note.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_Note.Location = new Point( 82, 289 );
			lbl_Note.Name = "lbl_Note";
			lbl_Note.Size = new Size( 42, 19 );
			lbl_Note.TabIndex = 82;
			lbl_Note.Text = "Note";
			lbl_Note.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_Search
			// 
			lbl_Search.AutoSize = true;
			lbl_Search.ForeColor = Color.Black;
			lbl_Search.Location = new Point( 534, 20 );
			lbl_Search.Name = "lbl_Search";
			lbl_Search.Size = new Size( 146, 17 );
			lbl_Search.TabIndex = 83;
			lbl_Search.Text = "Search: Trailing digits.";
			// 
			// grp_DeviceData
			// 
			grp_DeviceData.Controls.Add( lbl_Search );
			grp_DeviceData.Controls.Add( lbx_MatchingDevices );
			grp_DeviceData.Controls.Add( lbl_ButtonLast );
			grp_DeviceData.Controls.Add( tbx_Matches );
			grp_DeviceData.Controls.Add( cbx_DeviceType );
			grp_DeviceData.Controls.Add( lbl_ButtonFirst );
			grp_DeviceData.Controls.Add( lbl_DeviceLocation );
			grp_DeviceData.Controls.Add( btn_FindDevice );
			grp_DeviceData.Controls.Add( lbl_DeviceType );
			grp_DeviceData.Controls.Add( btn_FirstDevice );
			grp_DeviceData.Controls.Add( cbx_DeviceLocation );
			grp_DeviceData.Controls.Add( btn_InsertDevice );
			grp_DeviceData.Controls.Add( cbx_Countries );
			grp_DeviceData.Controls.Add( btn_PreviousDevice );
			grp_DeviceData.Controls.Add( lbl_DialNumber );
			grp_DeviceData.Controls.Add( btn_CloseForm );
			grp_DeviceData.Controls.Add( tbx_Notes );
			grp_DeviceData.Controls.Add( btn_LastDevice );
			grp_DeviceData.Controls.Add( lbl_Note );
			grp_DeviceData.Controls.Add( btn_UpdateDevice );
			grp_DeviceData.Controls.Add( lbl_PickerNumber );
			grp_DeviceData.Controls.Add( btn_NextDevice );
			grp_DeviceData.Controls.Add( lbl_TrailingDigits );
			grp_DeviceData.Controls.Add( lbl_FindPk );
			grp_DeviceData.Controls.Add( lbl_LeadingDigits );
			grp_DeviceData.Controls.Add( tbx_Filter );
			grp_DeviceData.Controls.Add( tbx_LongAreaCode );
			grp_DeviceData.Controls.Add( tbx_DeviceId );
			grp_DeviceData.Controls.Add( lbl_ShortAreaCode );
			grp_DeviceData.Controls.Add( lbl_PK );
			grp_DeviceData.Controls.Add( tbx_ShortAreaCode );
			grp_DeviceData.Controls.Add( lbl_LongAreaCode );
			grp_DeviceData.Controls.Add( tbx_LeadingDigits );
			grp_DeviceData.Controls.Add( tbx_TrailingDigits );
			grp_DeviceData.Controls.Add( tbx_DialNumber );
			grp_DeviceData.Controls.Add( tbx_Prompt );
			grp_DeviceData.Controls.Add( tbx_PickerNumber );
			grp_DeviceData.Controls.Add( lbl_CountryId );
			grp_DeviceData.Font = new Font( "Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point );
			grp_DeviceData.Location = new Point( 12, 8 );
			grp_DeviceData.Name = "grp_DeviceData";
			grp_DeviceData.Padding = new Padding( 2 );
			grp_DeviceData.Size = new Size( 702, 387 );
			grp_DeviceData.TabIndex = 0;
			grp_DeviceData.TabStop = false;
			grp_DeviceData.Text = "Device Data";
			// 
			// cbx_DeviceType
			// 
			cbx_DeviceType.DropDownStyle = ComboBoxStyle.DropDownList;
			cbx_DeviceType.FormattingEnabled = true;
			cbx_DeviceType.Location = new Point( 130, 250 );
			cbx_DeviceType.Name = "cbx_DeviceType";
			cbx_DeviceType.Size = new Size( 168, 25 );
			cbx_DeviceType.TabIndex = 6;
			cbx_DeviceType.SelectedIndexChanged +=  cbx_DeviceType_SelectedIndexChanged ;
			// 
			// lbl_DeviceLocation
			// 
			lbl_DeviceLocation.AutoSize = true;
			lbl_DeviceLocation.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_DeviceLocation.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_DeviceLocation.Location = new Point( 9, 225 );
			lbl_DeviceLocation.Name = "lbl_DeviceLocation";
			lbl_DeviceLocation.Size = new Size( 115, 19 );
			lbl_DeviceLocation.TabIndex = 86;
			lbl_DeviceLocation.Text = "Device Location";
			lbl_DeviceLocation.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lbl_DeviceType
			// 
			lbl_DeviceType.AutoSize = true;
			lbl_DeviceType.Font = new Font( "Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point );
			lbl_DeviceType.ForeColor = Color.FromArgb(     192,     0,     0 );
			lbl_DeviceType.Location = new Point( 34, 252 );
			lbl_DeviceType.Name = "lbl_DeviceType";
			lbl_DeviceType.Size = new Size( 90, 19 );
			lbl_DeviceType.TabIndex = 85;
			lbl_DeviceType.Text = "Device Type";
			lbl_DeviceType.TextAlign = ContentAlignment.MiddleRight;
			// 
			// cbx_DeviceLocation
			// 
			cbx_DeviceLocation.DropDownStyle = ComboBoxStyle.DropDownList;
			cbx_DeviceLocation.FormattingEnabled = true;
			cbx_DeviceLocation.Location = new Point( 130, 219 );
			cbx_DeviceLocation.Name = "cbx_DeviceLocation";
			cbx_DeviceLocation.Size = new Size( 168, 25 );
			cbx_DeviceLocation.TabIndex = 5;
			cbx_DeviceLocation.SelectedIndexChanged +=  cbx_DeviceLocation_SelectedIndexChanged ;
			// 
			// FrmDevice
			// 
			AutoScaleDimensions = new SizeF( 7F, 15F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(     255,     224,     192 );
			CancelButton = btn_CloseForm;
			ClientSize = new Size( 724, 401 );
			Controls.Add( grp_DeviceData );
			Font = new Font( "Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point );
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "FrmDevice";
			SizeGripStyle = SizeGripStyle.Show;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Devices...";
			grp_DeviceData.ResumeLayout( false );
			grp_DeviceData.PerformLayout();
			ResumeLayout( false );

		}

		#endregion
		private Button btn_CloseForm;
		private Button btn_FindDevice;
		private Button btn_FirstDevice;
		private Button btn_InsertDevice;
		private Button btn_LastDevice;
		private Button btn_NextDevice;
		private Button btn_PreviousDevice;
		private Button btn_UpdateDevice;
		private ComboBox cbx_Countries;
		private ComboBox cbx_DeviceLocation;
		private ComboBox cbx_DeviceType;
		private GroupBox grp_DeviceData;
		private Label lbl_PK;
		private Label lbl_CountryId;
		private Label lbl_LongAreaCode;
		private Label lbl_ShortAreaCode;
		private Label lbl_LeadingDigits;
		private Label lbl_TrailingDigits;
		private Label lbl_DeviceType;
		private Label lbl_DialNumber;
		private Label lbl_PickerNumber;
		private Label lbl_Note;
		private Label lbl_Search;
		private Label lbl_DeviceLocation;
		private Label lbl_FindPk;
		private Label lbl_ButtonFirst;
		private Label lbl_ButtonLast;
		private ListBox lbx_MatchingDevices;
		private TextBox tbx_DeviceId;
		private TextBox tbx_DialNumber;
		private TextBox tbx_Filter;
		private TextBox tbx_LeadingDigits;
		private TextBox tbx_LongAreaCode;
		private TextBox tbx_Matches;
		private TextBox tbx_Notes;
		private TextBox tbx_PickerNumber;
		private TextBox tbx_Prompt;
		private TextBox tbx_ShortAreaCode;
		private TextBox tbx_TrailingDigits;
	}
}
