//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using TXT_GATHER		= CONTACTS.GLOBAL.TOOLS.TextAccumulator;
using GLOBAL_DB			= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
//LOCAL
using ADDRESS			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using ADDRESSES			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Table;
using NATION			= CONTACTS.LOCAL.TERTIARY.NATION.Row;
using NATIONS			= CONTACTS.LOCAL.TERTIARY.NATION.Table;
using REMINDER			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reminders;
using RECON				= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reconstruction;
//FORMS
using ADDRESS_FINDER	= CONTACTS.INTERFACE.DIALOGS.DlgFindAddress;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.FORMS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class FrmAddress : Form
	{
		#region DECLARATIONS
		private static ADDRESSES all_Addresses = new ADDRESSES();
		private static NATIONS all_Nations = new NATIONS();

		private GLOBAL_DB db_Connector = new GLOBAL_DB();
		private ADDRESS one_Address;
		private NATION initial_Nation;
		private NATION current_Nation;

		private bool is_event_Disabled = false;
		private TXT_GATHER txt_Accumulator;
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public FrmAddress()
		{
			InitializeComponent();
			InitialiseForm();

			this.Address = all_Addresses.DefaultAddress;
			initial_Nation = all_Nations.NationByKey( Address.FkCountry.Value );
			current_Nation = initial_Nation;
			DisplayInitialNation();
		}
		//___________________________________________________________________________________________________________________________________________
		public FrmAddress( int pk_address )
		{
			InitializeComponent();
			InitialiseForm();

			AddressPk = pk_address;
			initial_Nation = all_Nations.NationByKey( Address.FkCountry.Value );
			current_Nation = initial_Nation;
			DisplayInitialNation();
		}
		#endregion


		#region MAIN LINE
		//___________________________________________________________________________________________________________________________________________
		private void DisplayAddress()
		{
			IsEventDisabled = true;

			this.tbx_PkAddress.Text			= AddressPkAsText;
			this.tbx_FkCountry.Text			= CountryPkAsText;
			this.tbx_Assemblage.Text		= Assemblage;
			this.tbx_Level.Text				= Level;
			this.tbx_Unit.Text				= Unit;
			this.tbx_Extension.Text			= Extension;
			this.tbx_RuralDelivery.Text		= RuralDelivery;
			this.tbx_PostalCode.Text		= PostalCode;
			this.tbx_BoxNumber.Text			= BoxNumber;
			this.tbx_HouseNumber.Text		= HouseNumber;
			this.tbx_StreetName.Text		= StreetName;
			this.tbx_StreetType.Text		= StreetType;
			this.tbx_Compass.Text			= Compass;
			this.tbx_Suburb.Text			= Suburb;
			this.tbx_City.Text				= City;
			this.tbx_Metropolitan.Text		= Metropolitan;
			this.tbx_ProvinceName.Text		= ProvinceName;
			this.tbx_ProvinceCode.Text		= ProvinceCode;
			this.tbx_VcfPostal.Text			= VcfPostal;
			this.tbx_VcfPhysical.Text		= VcfPhysical;
			this.tbx_VcfExtended.Text		= VcfExtended;
			this.tbx_ExcelPattern.Text		= ExcelPattern;
			this.chk_Christmas.Checked		= IsChristmas;

			this.tbx_PostalRealised.Lines	= one_Address.RealisePostalRule();
			this.tbx_PhysicalRealised.Lines	= one_Address.RealisePhysicalRule();
			this.tbx_ExtendedRealised.Lines	= one_Address.RealiseExtendedRule();
			this.tbx_XL_RowRealised.Lines	= one_Address.RealiseExcelRule();

			IsEventDisabled = false;
		}
		//___________________________________________________________________________________________________________________________________________
		private void DisplayInitialNation()
		{
			this.cbx_Country.Text		= initial_Nation.CountryName.Value;
			this.tbx_FkCountry.Text		= initial_Nation.PkCountry.AsString;
			this.tbx_CountryName.Text	= initial_Nation.CountryName.Value;
			this.tbx_ShortIsoCode.Text	= initial_Nation.ShortIsoCode.Value;
			this.tbx_LongIsoCode.Text	= initial_Nation.LongIsoCode.Value;
			this.tbx_CountryCode.Text	= initial_Nation.CountryCode.Value;
		}
		//___________________________________________________________________________________________________________________________________________
		private void DisplayCurrentNation()
		{
			this.cbx_Country.Text		= current_Nation.CountryName.Value;
			this.tbx_FkCountry.Text		= current_Nation.PkCountry.AsString;
			this.tbx_CountryName.Text	= current_Nation.CountryName.Value;
			this.tbx_ShortIsoCode.Text	= current_Nation.ShortIsoCode.Value;
			this.tbx_LongIsoCode.Text	= current_Nation.LongIsoCode.Value;
			this.tbx_CountryCode.Text	= current_Nation.CountryCode.Value;
		}
		#endregion


		#region RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		private ADDRESS Address
		{
			get { return one_Address; }
			set
			{
				one_Address = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int AddressPk
		{
			get { return Address.PkAddress.Value; }
			set { Address = all_Addresses.AddressByKey( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private string AddressPkAsText
		{
			get { return AddressPk.ToString(); }
			set { AddressPk = Convert.ToInt32( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private int CountryPk
		{
			get { return Address.FkCountry.Value; }
			set { CurrentNation = all_Nations.NationByKey( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private string CountryPkAsText
		{
			get { return CountryPk.ToString(); }
			set { CountryPk = Convert.ToInt32( value ); }
		}


		#region 'STREET' LEVEL
		//___________________________________________________________________________________________________________________________________________
		private string HouseNumber
		{
			get { return Address.HouseNumber.Value; }
			set
			{
				Address.NewHouseNumber = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string StreetName
		{
			get { return Address.StreetName.Value; }
			set
			{
				Address.NewStreetName = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string StreetType
		{
			get { return Address.StreetType.Value; }
			set
			{
				Address.NewStreetType = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Compass
		{
			get { return Address.Compass.TextboxValue; }
			set
			{
				Address.NewCompass = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Suburb
		{
			get { return Address.Suburb.Value; }
			set
			{
				Address.NewSuburb = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string City
		{
			get { return Address.City.Value; }
			set
			{
				Address.NewCity = value;
				DisplayAddress();
			}
		}
		#endregion


		#region METRO/PROVINCIAL
		//___________________________________________________________________________________________________________________________________________
		private string Metropolitan
		{
			get { return Address.Metropolitan.Value; }
			set
			{
				Address.NewMetropolitan = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string ProvinceName
		{
			get { return Address.ProvinceName.Value; }
			set
			{
				Address.NewProvinceName = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string ProvinceCode
		{
			get { return Address.ProvinceCode.Value; }
			set
			{
				Address.NewProvinceCode = value;
				DisplayAddress();
			}
		}
		#endregion


		#region  POSTAL
		//___________________________________________________________________________________________________________________________________________
		private string BoxNumber
		{
			get { return Address.BoxNumber.Value; }
			set
			{
				Address.NewBoxNumber = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string RuralDelivery
		{
			get { return Address.RuralDelivery.Value; }
			set
			{
				Address.NewRuralDelivery = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string PostalCode
		{
			get { return Address.PostalCode.Value; }
			set
			{
				Address.NewPostalCode = value;
				DisplayAddress();
			}
		}
		#endregion


		#region EXTENSIONS
		//___________________________________________________________________________________________________________________________________________
		private string Assemblage
		{
			get { return Address.Assemblage.Value; }
			set
			{
				Address.NewAssemblage = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Level
		{
			get { return Address.Level.Value; }
			set
			{
				Address.NewLevel = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Unit
		{
			get { return Address.Unit.Value; }
			set
			{
				Address.NewUnit = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Extension
		{
			get { return Address.Extension.Value; }
			set
			{
				Address.NewExtension = value;
				DisplayAddress();
			}
		}
		#endregion



		#region COUNTRY/NATION
		//___________________________________________________________________________________________________________________________________________
		private NATION CurrentNation
		{
			get { return current_Nation; }
			set 
			{
				current_Nation = value;
				Address.NewNation = current_Nation;
				DisplayCurrentNation();	
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string CountryName
		{
			get { return Address.CountryName.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string ShortIsoCode
		{
			get { return Address.ShortIsoCode.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string LongIsoCode
		{
			get { return Address.LongIsoCode.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string CountryCode
		{
			get { return Address.CountryCode.Value; }
		}
		#endregion


		#region VCF RULES
		//___________________________________________________________________________________________________________________________________________
		private string VcfPostal
		{
			get { return Address.VcfPostal.Value; }
			set
			{
				Address.NewVcfPostal = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string VcfPhysical
		{
			get { return Address.VcfPhysical.Value; }
			set
			{
				Address.NewVcfPhysical = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string VcfExtended
		{
			get { return Address.VcfExtended.Value; }
			set
			{
				Address.NewVcfExtended = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string ExcelPattern
		{
			get { return Address.ExcelPattern.Value; }
			set
			{
				Address.NewExcelPattern = value;
				DisplayAddress();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private bool IsChristmas
		{
			get { return Address.Christmas.Value; }
			set
			{
				Address.NewIsChristmas = value;
				DisplayAddress();
			}
		}
		#endregion


		#region THE OTHERS...
		//___________________________________________________________________________________________________________________________________________
		private bool IsEventDisabled
		{
			get { return is_event_Disabled; }
			set { is_event_Disabled = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private bool IsEventEnabled
		{
			get { return is_event_Disabled == false; }
		}
		//___________________________________________________________________________________________________________________________________________
		private void Accumulator( string s )
		{
			txt_Accumulator = new TXT_GATHER( s );
		}
		#endregion OTHERS...


		#endregion RESPONDERS


		#region EVENT HANDLERS

		#region VALUE CHANGED

		#region HOUSE NUMBER
		//___________________________________________________________________________________________________________________________________________
		private void tbx_HouseNumber_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_HouseNumber.Text );
			UpdatePrompt( Address.HouseNumber.Factors.Prompt );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_HouseNumber_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_HouseNumber.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_HouseNumber_Leave( object sender, EventArgs e )
		{
			HouseNumber = txt_Accumulator.AsIs;
		}
		#endregion

		#region STREET NAME
		//___________________________________________________________________________________________________________________________________________
		private void tbx_StreetName_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_StreetName.Text );
			UpdatePrompt( Address.StreetName.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_StreetName_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_StreetName.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_StreetName_Leave( object sender, EventArgs e )
		{
			StreetName = txt_Accumulator.AsIs;
		}
		#endregion

		#region STREET TYPE
		//___________________________________________________________________________________________________________________________________________
		private void tbx_StreetType_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_StreetType.Text );
			UpdatePrompt( Address.StreetType.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_StreetType_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_StreetType.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_StreetType_Leave( object sender, EventArgs e )
		{
			StreetType = txt_Accumulator.AsProper;
		}
		#endregion

		#region COMPASS
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Compass_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_Compass.Text );
			UpdatePrompt( Address.Compass.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Compass_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_Compass.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Compass_Leave( object sender, EventArgs e )
		{
			Compass = txt_Accumulator.AsUpper;
		}
		#endregion

		#region SUBURB
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Suburb_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_Suburb.Text );
			UpdatePrompt( Address.Suburb.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Suburb_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_Suburb.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Suburb_Leave( object sender, EventArgs e )
		{
			Suburb = txt_Accumulator.AsIs;
		}
		#endregion

		#region CITY
		//___________________________________________________________________________________________________________________________________________
		private void tbx_City_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_City.Text );
			UpdatePrompt( Address.City.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_City_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_City.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_City_Leave( object sender, EventArgs e )
		{
			City = txt_Accumulator.AsIs;
		}
		#endregion

		#region METROPOLITAN
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Metropolitan_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_Metropolitan.Text );
			UpdatePrompt( Address.Metropolitan.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Metropolitan_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_Metropolitan.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Metropolitan_Leave( object sender, EventArgs e )
		{
			Metropolitan = txt_Accumulator.AsIs;
		}
		#endregion

		#region PROVINCE NAME
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ProvinceName_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_ProvinceName.Text );
			UpdatePrompt( Address.ProvinceName.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ProvinceName_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_ProvinceName.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ProvinceName_Leave( object sender, EventArgs e )
		{
			ProvinceName = txt_Accumulator.AsIs;
		}
		#endregion

		#region PROVINCE CODE
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ProvinceCode_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_ProvinceCode.Text );
			UpdatePrompt( Address.ProvinceCode.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ProvinceCode_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_ProvinceCode.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ProvinceCode_Leave( object sender, EventArgs e )
		{
			ProvinceCode = txt_Accumulator.AsUpper;
		}
		#endregion

		#region BOX NUMBER
		//___________________________________________________________________________________________________________________________________________
		private void tbx_BoxNumber_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_BoxNumber.Text );
			UpdatePrompt( Address.BoxNumber.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_BoxNumber_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_BoxNumber.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_BoxNumber_Leave( object sender, EventArgs e )
		{
			BoxNumber = txt_Accumulator.AsIs;
		}
		#endregion

		#region RURAL DELIVERY
		//___________________________________________________________________________________________________________________________________________
		private void tbx_RuralDelivery_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_RuralDelivery.Text );
			UpdatePrompt( Address.RuralDelivery.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_RuralDelivery_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_RuralDelivery.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_RuralDelivery_Leave( object sender, EventArgs e )
		{
			RuralDelivery = txt_Accumulator.AsUpper;
		}
		#endregion

		#region POSTAL CODE
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PostalCode_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_PostalCode.Text );
			UpdatePrompt( Address.PostalCode.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PostalCode_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_PostalCode.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PostalCode_Leave( object sender, EventArgs e )
		{
			PostalCode = txt_Accumulator.AsIs;
		}
		#endregion

		#region ASSEMBLAGE
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Assemblage_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_Assemblage.Text );
			UpdatePrompt( Address.Assemblage.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Assemblage_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_Assemblage.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Assemblage_Leave( object sender, EventArgs e )
		{
			Assemblage = txt_Accumulator.AsIs;
		}
		#endregion

		#region LEVEL
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Level_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_Level.Text );
			UpdatePrompt( Address.Level.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Level_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_Level.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Level_Leave( object sender, EventArgs e )
		{
			Level = txt_Accumulator.AsIs;
		}
		#endregion

		#region UNIT
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Unit_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_Level.Text );
			UpdatePrompt( Address.Unit.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Unit_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_Level.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Unit_Leave( object sender, EventArgs e )
		{
			Unit = txt_Accumulator.AsIs;
		}
		#endregion

		#region EXTENSION
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Extension_Enter( object sender, EventArgs e )
		{
			Accumulator( tbx_Extension.Text );
			UpdatePrompt( Address.Extension.Factors.Prompt ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Extension_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Accumulator( tbx_Extension.Text );
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Extension_Leave( object sender, EventArgs e )
		{
			Extension = txt_Accumulator.AsIs;
		}
		#endregion


		#region ADDRESS PATTERNS
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PostalPattern_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				VcfPostal = tbx_VcfPostal.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PhysicalPattern_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				VcfPhysical = tbx_VcfPhysical.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ExtendedPattern_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				VcfExtended = tbx_VcfExtended.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_XL_RowPattern_TextChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				ExcelPattern = tbx_ExcelPattern.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void chk_Christmas_CheckedChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				IsChristmas = chk_Christmas.Checked;
		}
		#endregion
		
		#endregion


		#region COMBO_BOX SELECTIONS
		//___________________________________________________________________________________________________________________________________________
		private void cbx_StreetName_SelectedValueChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				StreetName = ( string )cbx_StreetName.SelectedItem;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_StreetType_SelectedValueChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				StreetType = ( string )cbx_StreetType.SelectedItem;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_Suburb_SelectedValueChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Suburb = ( string )cbx_Suburb.SelectedItem;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_City_SelectedValueChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				City = ( string )cbx_City.SelectedItem;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_Country_SelectedValueChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				CurrentNation = ( NATION )cbx_Country.SelectedItem;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_PostalCode_SelectedValueChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				PostalCode = ( string )cbx_PostalCode.SelectedItem;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_Province_SelectedValueChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				ProvinceName = ( string )cbx_ProvinceName.SelectedItem;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_Metropolitan_SelectedValueChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				Metropolitan = ( string )cbx_Metropolitan.SelectedItem;
		}
		//___________________________________________________________________________________________________________________________________________
		private void cbx_ProvinceCode_SelectedValueChanged( object sender, EventArgs e )
		{
			if ( IsEventEnabled )
				ProvinceCode = ( string )cbx_ProvinceCode.SelectedItem;
		}
		#endregion


		#region NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		private void btn_FindAddress_Click( object sender, EventArgs e )
		{
			using ( ADDRESS_FINDER find_address = new ADDRESS_FINDER() )
			{
				find_address.ShowDialog();
				if ( find_address.DialogResult == DialogResult.OK )
					Address = find_address.SelectedAddress;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Filter_KeyUp( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Enter )
				return;

			AddressPkAsText = this.tbx_Filter.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_FirstAddress_Click( object sender, EventArgs e )
		{
			Address = all_Addresses.FirstAddress;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_PreviousAddress_Click( object sender, EventArgs e )
		{
			Address = all_Addresses.PreviousAddress;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_NextAddress_Click( object sender, EventArgs e )
		{
			Address = all_Addresses.NextAddress;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_LastAddress_Click( object sender, EventArgs e )
		{
			Address = all_Addresses.LastAddress;
		}
		#endregion


		#region ADDRESS PATTERNS
		//___________________________________________________________________________________________________________________________________________
		private void btn_DefaultPostalRule_Click( object sender, EventArgs e )
		{
			VcfPostal = RECON.VcfPostal;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_DefaultPhysicalRule_Click( object sender, EventArgs e )
		{
			VcfPhysical = RECON.VcfPhysical;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_DefaultExtendedRule_Click( object sender, EventArgs e )
		{
			VcfExtended = RECON.VcfExtended;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_DefaultExcelRule_Click( object sender, EventArgs e )
		{
			ExcelPattern = RECON.ExcelPattern;
		}
		#endregion


		#region BUTTON CLICKS
		//___________________________________________________________________________________________________________________________________________
		private void btn_CloseForm_Click( object sender, EventArgs e )
		{
			this.Close();
		}
		#endregion


		#region INSERT/UPDATE
		//___________________________________________________________________________________________________________________________________________
		private void btn_InsertAddress_Click( object sender, EventArgs e )
		{
			all_Addresses.InsertAddress( Address );
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Update_Click( object sender, EventArgs e )
		{
			all_Addresses.UpdateAddress( Address );
		}
		#endregion


		#region ENTER / PROMPT
		//___________________________________________________________________________________________________________________________________________
		private void UpdatePrompt( string reminder_text )
		{
			tbx_Prompt.Text = reminder_text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void UpdatePrompt( string[] reminder_text )
		{
			tbx_Prompt.Lines = reminder_text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_FkCountry_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.FkCountry ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_CountryName_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.CountryName ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_CountryCode_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.CountryCode ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ShortIsoCode_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.ShortIsoCode ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LongIsoCode_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.LongIsoCode ); }
		//___________________________________________________________________________________________________________________________________________
		private void chk_Christmas_Enter( object sender, EventArgs e )
		{ UpdatePrompt( Address.Christmas.Factors.Prompt ); }
		//___________________________________________________________________________________________________________________________________________
		private void cbx_StreetName_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.CbxStreetName ); }
		//___________________________________________________________________________________________________________________________________________
		private void cbx_StreetType_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.CbxStreetType ); }
		//___________________________________________________________________________________________________________________________________________
		private void cbx_Suburb_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.CbxSuburb ); }
		//___________________________________________________________________________________________________________________________________________
		private void cbx_City_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.CbxCity ); }
		//___________________________________________________________________________________________________________________________________________
		private void cbx_ProvinceName_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.CbxProvince ); }
		//___________________________________________________________________________________________________________________________________________
		private void cbx_PostalCode_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.CbxPostalCode ); }
		//___________________________________________________________________________________________________________________________________________
		private void cbx_FkCountry_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.CbxCountry ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PkAddress_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnAddressFilter ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Filter_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnAddressFilter ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_FirstAddress_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnMoveToFirst ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_PreviousAddress_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnMoveToPrevious ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_NextAddress_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnMoveToNext ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_LastAddress_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnMoveToLast ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_InsertAddress_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnInsertAddress ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_UpdateAddress_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnUpdateAddress ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_CloseForm_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnCloseForm ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_AddressRealised_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.VcfRealised ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PostalAddress_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.VcfPostal ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ExtendedPattern_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.VcfExtended ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PhysicalAddress_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.VcfPhysical ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_XL_RowAddress_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.ExcelPattern ); }
		//___________________________________________________________________________________________________________________________________________
		private void tbx_XL_RowRealised_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.ExcelRealised ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_DefaultPostalRule_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnDefPostalRule ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_DefaultPhysicalRule_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnDefPhysicalRule ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_DefaultExtendedRule_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnDefExtendedRule ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_DefaultExcelRule_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnDefExcelRule ); }
		//___________________________________________________________________________________________________________________________________________
		private void btn_FindAddress_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.BtnFindAddress ); }
		//___________________________________________________________________________________________________________________________________________
		private void ctl_Void_Enter( object sender, EventArgs e )
		{ UpdatePrompt( REMINDER.Void ); }
		#endregion

		#endregion


		#region INITIALISATION / FINALISATION
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm()
		{
			PopulateComboBoxes();
			PutHeader();
			SetTabIndices();
			SetTabStops();
			SetEnabled();
		}
		//___________________________________________________________________________________________________________________________________________
		private void PopulateComboBoxes()
		{
			cbx_Country.DataSource = all_Nations.NationsAsArray;

			cbx_PostalCode.Items.AddRange( all_Addresses.PostalCodes );
			cbx_StreetName.Items.AddRange( all_Addresses.StreetNames );
			cbx_StreetType.Items.AddRange( all_Addresses.StreetTypes );
			cbx_Suburb.Items.AddRange( all_Addresses.SuburbNames );
			cbx_City.Items.AddRange( all_Addresses.CityNames );
			cbx_Metropolitan.Items.AddRange( all_Addresses.Metropolitans );
			cbx_ProvinceName.Items.AddRange( all_Addresses.ProvinceNames );
			cbx_ProvinceCode.Items.AddRange( all_Addresses.ProvinceCodes );
		}
		//___________________________________________________________________________________________________________________________________________
		private void PutHeader()
		{
			this.Text = db_Connector.PartiallyQualifiedFileName;
		}
		//___________________________________________________________________________________________________________________________________________
		private void SetTabIndices()
		{
			tbx_HouseNumber.TabIndex = 0;
			tbx_StreetName.TabIndex = 1;
			cbx_StreetName.TabIndex = 2;
			tbx_StreetType.TabIndex = 3;
			cbx_StreetType.TabIndex = 4;
			tbx_Compass.TabIndex = 5;
			tbx_Suburb.TabIndex = 6;
			cbx_Suburb.TabIndex = 7;
			tbx_City.TabIndex = 8;
			cbx_City.TabIndex = 9;
			tbx_Metropolitan.TabIndex = 10;
			cbx_Metropolitan.TabIndex = 11;
			tbx_ProvinceName.TabIndex = 12;
			cbx_ProvinceName.TabIndex = 13;
			tbx_ProvinceCode.TabIndex = 14;
			cbx_ProvinceCode.TabIndex = 15;
			tbx_BoxNumber.TabIndex = 16;
			tbx_RuralDelivery.TabIndex = 17;
			tbx_PostalCode.TabIndex = 18;
			cbx_PostalCode.TabIndex = 19;
			tbx_Assemblage.TabIndex = 20;
			tbx_Level.TabIndex = 21;
			tbx_Unit.TabIndex = 22;
			tbx_Extension.TabIndex = 23;
			tbx_FkCountry.TabIndex = 24;
			cbx_Country.TabIndex = 25;
			tbx_CountryName.TabIndex = 26;
			tbx_CountryCode.TabIndex = 27;
			tbx_ShortIsoCode.TabIndex = 28;
			tbx_LongIsoCode.TabIndex = 29;
			chk_Christmas.TabIndex = 30;
			btn_DefaultPostalRule.TabIndex = 31;
			tbx_VcfPostal.TabIndex = 32;
			tbx_PostalRealised.TabIndex = 33;
			btn_DefaultPhysicalRule.TabIndex = 34;
			tbx_VcfPhysical.TabIndex = 35;
			tbx_PhysicalRealised.TabIndex = 36;
			btn_DefaultExtendedRule.TabIndex = 37;
			tbx_VcfExtended.TabIndex = 38;
			tbx_ExtendedRealised.TabIndex = 39;
			btn_DefaultExcelRule.TabIndex = 40;
			tbx_ExcelPattern.TabIndex = 41;
			tbx_XL_RowRealised.TabIndex = 42;
			tbx_Filter.TabIndex = 43;
			btn_FirstAddress.TabIndex = 44;
			btn_PreviousAddress.TabIndex = 45;
			btn_NextAddress.TabIndex = 46;
			btn_LastAddress.TabIndex = 47;
			btn_FindAddress.TabIndex = 48;
			btn_InsertAddress.TabIndex = 49;
			btn_UpdateAddress.TabIndex = 50;
			btn_CloseForm.TabIndex = 51;
			tbx_PkAddress.TabIndex = 100;
			tbx_Prompt.TabIndex = 101;
			lbl_Unit.TabIndex = 102;
			lbl_Assemblage.TabIndex = 103;
			lbl_City.TabIndex = 104;
			lbl_Compass.TabIndex = 105;
			lbl_Country.TabIndex = 106;
			lbl_CountryCode.TabIndex = 107;
			lbl_CountryName.TabIndex = 108;
			lbl_Extention.TabIndex = 109;
			lbl_HouseNumber.TabIndex = 110;
			lbl_IsoCodes.TabIndex = 111;
			lbl_Level.TabIndex = 112;
			lbl_Metropolitan.TabIndex = 113;
			lbl_Move.TabIndex = 114;
			lbl_N.TabIndex = 115;
			lbl_One.TabIndex = 116;
			lbl_PkAddress.TabIndex = 117;
			lbl_POBox.TabIndex = 118;
			lbl_PostalCode.TabIndex = 119;
			lbl_Province.TabIndex = 120;
			lbl_ProvinceCode.TabIndex = 121;
			lbl_RuralDelivery.TabIndex = 122;
			lbl_StreetName.TabIndex = 123;
			lbl_StreetType.TabIndex = 124;
			lbl_Suburb.TabIndex = 125;
		}
		//___________________________________________________________________________________________________________________________________________
		private void SetTabStops()
		{
			tbx_HouseNumber.TabStop = true;
			tbx_StreetName.TabStop = true;
			cbx_StreetName.TabStop = true;
			tbx_StreetType.TabStop = true;
			cbx_StreetType.TabStop = true;
			tbx_Compass.TabStop = true;
			tbx_Suburb.TabStop = true;
			cbx_Suburb.TabStop = true;
			tbx_City.TabStop = true;
			cbx_City.TabStop = true;
			tbx_Metropolitan.TabStop = true;
			cbx_Metropolitan.TabStop = true;
			tbx_ProvinceName.TabStop = true;
			cbx_ProvinceName.TabStop = true;
			tbx_ProvinceCode.TabStop = true;
			cbx_ProvinceCode.TabStop = true;
			tbx_BoxNumber.TabStop = true;
			tbx_RuralDelivery.TabStop = true;
			tbx_PostalCode.TabStop = true;
			cbx_PostalCode.TabStop = true;
			tbx_Assemblage.TabStop = true;
			tbx_Level.TabStop = true;
			tbx_Unit.TabStop = true;
			tbx_Extension.TabStop = true;
			tbx_FkCountry.TabStop = true;
			cbx_Country.TabStop = true;
			tbx_CountryName.TabStop = true;
			tbx_CountryCode.TabStop = true;
			tbx_ShortIsoCode.TabStop = true;
			tbx_LongIsoCode.TabStop = true;
			chk_Christmas.TabStop = true;
			btn_DefaultPostalRule.TabStop = true;
			tbx_VcfPostal.TabStop = true;
			tbx_PostalRealised.TabStop = true;
			btn_DefaultPhysicalRule.TabStop = true;
			tbx_VcfPhysical.TabStop = true;
			tbx_PhysicalRealised.TabStop = true;
			btn_DefaultExtendedRule.TabStop = true;
			tbx_VcfExtended.TabStop = true;
			tbx_ExtendedRealised.TabStop = true;
			btn_DefaultExcelRule.TabStop = true;
			tbx_ExcelPattern.TabStop = true;
			tbx_XL_RowRealised.TabStop = true;
			tbx_Filter.TabStop = true;
			btn_FirstAddress.TabStop = true;
			btn_PreviousAddress.TabStop = true;
			btn_NextAddress.TabStop = true;
			btn_LastAddress.TabStop = true;
			btn_FindAddress.TabStop = true;
			btn_InsertAddress.TabStop = true;
			btn_UpdateAddress.TabStop = true;
			btn_CloseForm.TabStop = true;
			tbx_PkAddress.TabStop = false;
			tbx_Prompt.TabStop = false;
			lbl_Unit.TabStop = false;
			lbl_Assemblage.TabStop = false;
			lbl_City.TabStop = false;
			lbl_Compass.TabStop = false;
			lbl_Country.TabStop = false;
			lbl_CountryCode.TabStop = false;
			lbl_CountryName.TabStop = false;
			lbl_Extention.TabStop = false;
			lbl_HouseNumber.TabStop = false;
			lbl_IsoCodes.TabStop = false;
			lbl_Level.TabStop = false;
			lbl_Metropolitan.TabStop = false;
			lbl_Move.TabStop = false;
			lbl_N.TabStop = false;
			lbl_One.TabStop = false;
			lbl_PkAddress.TabStop = false;
			lbl_POBox.TabStop = false;
			lbl_PostalCode.TabStop = false;
			lbl_Province.TabStop = false;
			lbl_ProvinceCode.TabStop = false;
			lbl_RuralDelivery.TabStop = false;
			lbl_StreetName.TabStop = false;
			lbl_StreetType.TabStop = false;
			lbl_Suburb.TabStop = false;
		}
		//___________________________________________________________________________________________________________________________________________
		private void SetEnabled()
		{
			tbx_HouseNumber.Enabled = true;
			tbx_StreetName.Enabled = true;
			cbx_StreetName.Enabled = true;
			tbx_StreetType.Enabled = true;
			cbx_StreetType.Enabled = true;
			tbx_Compass.Enabled = true;
			tbx_Suburb.Enabled = true;
			cbx_Suburb.Enabled = true;
			tbx_City.Enabled = true;
			cbx_City.Enabled = true;
			tbx_Metropolitan.Enabled = true;
			cbx_Metropolitan.Enabled = true;
			tbx_ProvinceName.Enabled = true;
			cbx_ProvinceName.Enabled = true;
			tbx_ProvinceCode.Enabled = true;
			cbx_ProvinceCode.Enabled = true;
			tbx_BoxNumber.Enabled = true;
			tbx_RuralDelivery.Enabled = true;
			tbx_PostalCode.Enabled = true;
			cbx_PostalCode.Enabled = true;
			tbx_Assemblage.Enabled = true;
			tbx_Level.Enabled = true;
			tbx_Unit.Enabled = true;
			tbx_Extension.Enabled = true;
			tbx_FkCountry.Enabled = true;
			cbx_Country.Enabled = true;
			tbx_CountryName.Enabled = true;
			tbx_CountryCode.Enabled = true;
			tbx_ShortIsoCode.Enabled = true;
			tbx_LongIsoCode.Enabled = true;
			chk_Christmas.Enabled = true;
			btn_DefaultPostalRule.Enabled = true;
			tbx_VcfPostal.Enabled = true;
			tbx_PostalRealised.Enabled = true;
			btn_DefaultPhysicalRule.Enabled = true;
			tbx_VcfPhysical.Enabled = true;
			tbx_PhysicalRealised.Enabled = true;
			btn_DefaultExtendedRule.Enabled = true;
			tbx_VcfExtended.Enabled = true;
			tbx_ExtendedRealised.Enabled = true;
			btn_DefaultExcelRule.Enabled = true;
			tbx_ExcelPattern.Enabled = true;
			tbx_XL_RowRealised.Enabled = true;
			tbx_Filter.Enabled = true;
			btn_FirstAddress.Enabled = true;
			btn_PreviousAddress.Enabled = true;
			btn_NextAddress.Enabled = true;
			btn_LastAddress.Enabled = true;
			btn_FindAddress.Enabled = true;
			btn_InsertAddress.Enabled = true;
			btn_UpdateAddress.Enabled = true;
			btn_CloseForm.Enabled = true;
			tbx_PkAddress.Enabled = true;
			tbx_Prompt.Enabled = true;
			lbl_Unit.Enabled = true;
			lbl_Assemblage.Enabled = true;
			lbl_City.Enabled = true;
			lbl_Compass.Enabled = true;
			lbl_Country.Enabled = true;
			lbl_CountryCode.Enabled = true;
			lbl_CountryName.Enabled = true;
			lbl_Extention.Enabled = true;
			lbl_HouseNumber.Enabled = true;
			lbl_IsoCodes.Enabled = true;
			lbl_Level.Enabled = true;
			lbl_Metropolitan.Enabled = true;
			lbl_Move.Enabled = true;
			lbl_N.Enabled = true;
			lbl_One.Enabled = true;
			lbl_PkAddress.Enabled = true;
			lbl_POBox.Enabled = true;
			lbl_PostalCode.Enabled = true;
			lbl_Province.Enabled = true;
			lbl_ProvinceCode.Enabled = true;
			lbl_RuralDelivery.Enabled = true;
			lbl_StreetName.Enabled = true;
			lbl_StreetType.Enabled = true;
			lbl_Suburb.Enabled = true;
		}
		#endregion
	}
}
