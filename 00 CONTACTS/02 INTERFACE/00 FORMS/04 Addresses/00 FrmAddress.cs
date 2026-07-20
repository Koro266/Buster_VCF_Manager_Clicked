//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using static CONTACTS.LOCAL.PRIMARY.PERSON.Database.Select;
//LOCAL
using ADDRESS			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
//FORMS
using ADDRESS_FINDER	= CONTACTS.INTERFACE.DIALOGS.DlgFindAddress;
using ADDRESSES			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Table;
using COUNT				= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Count;
using GLOBAL_DB			= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using MESSENGER			= CONTACTS.GLOBAL.TOOLS.Messenger;
using NATION			= CONTACTS.LOCAL.TERTIARY.NATION.Row;
using NATIONS			= CONTACTS.LOCAL.TERTIARY.NATION.Table;
using RECON				= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.Reconstruction;
using TXT_GATHER		= CONTACTS.GLOBAL.TOOLS.TextAccumulator;

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
		private static MESSENGER _Messenger;
		private TXT_GATHER txt_Accumulator;
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public FrmAddress()
		{
			InitializeComponent();
			InitialiseForm();

			_Messenger = new MESSENGER( this.tbx_Messages );
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

			_Messenger = new MESSENGER( this.tbx_Messages );
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

			this.tbx_PkAddress.Text = AddressPkAsText;
			this.tbx_FkCountry.Text = CountryPkAsText;
			this.tbx_Assemblage.Text = Assemblage;
			this.tbx_Level.Text = Level;
			this.tbx_Unit.Text = Unit;
			this.tbx_Extension.Text = Extension;
			this.tbx_RuralDelivery.Text = RuralDelivery;
			this.tbx_PostalCode.Text = PostalCode;
			this.tbx_BoxNumber.Text = BoxNumber;
			this.tbx_HouseNumber.Text = HouseNumber;
			this.tbx_StreetName.Text = StreetName;
			this.tbx_StreetType.Text = StreetType;
			this.tbx_Compass.Text = Compass;
			this.tbx_Suburb.Text = Suburb;
			this.tbx_City.Text = City;
			this.tbx_Metropolitan.Text = Metropolitan;
			this.tbx_ProvinceName.Text = ProvinceName;
			this.tbx_ProvinceCode.Text = ProvinceCode;
			this.tbx_VcfPostal.Text = VcfPostal;
			this.tbx_VcfPhysical.Text = VcfPhysical;
			this.tbx_VcfExtended.Text = VcfExtended;
			this.tbx_ExcelPattern.Text = ExcelPattern;
			this.chk_Christmas.Checked = IsChristmas;

			this.tbx_PostalRealised.Lines = one_Address.RealisePostalRule();
			this.tbx_PhysicalRealised.Lines = one_Address.RealisePhysicalRule();
			this.tbx_ExtendedRealised.Lines = one_Address.RealiseExtendedRule();
			this.tbx_XL_RowRealised.Lines = one_Address.RealiseExcelRule();

			IsEventDisabled = false;
		}
		//___________________________________________________________________________________________________________________________________________
		private void DisplayInitialNation()
		{
			this.cbx_Country.Text = initial_Nation.CountryName.Value;
			this.tbx_FkCountry.Text = initial_Nation.PkCountry.AsString;
			this.tbx_CountryName.Text = initial_Nation.CountryName.Value;
			this.tbx_ShortIsoCode.Text = initial_Nation.ShortIsoCode.Value;
			this.tbx_LongIsoCode.Text = initial_Nation.LongIsoCode.Value;
			this.tbx_CountryCode.Text = initial_Nation.CountryCode.Value;
		}
		//___________________________________________________________________________________________________________________________________________
		private void DisplayCurrentNation()
		{
			this.cbx_Country.Text = current_Nation.CountryName.Value;
			this.tbx_FkCountry.Text = current_Nation.PkCountry.AsString;
			this.tbx_CountryName.Text = current_Nation.CountryName.Value;
			this.tbx_ShortIsoCode.Text = current_Nation.ShortIsoCode.Value;
			this.tbx_LongIsoCode.Text = current_Nation.LongIsoCode.Value;
			this.tbx_CountryCode.Text = current_Nation.CountryCode.Value;
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
			set
			{
				if ( int.TryParse( value, out int result ) )
					if ( new COUNT.IsPkExtant( result ).Execute )
						AddressPk = result;
			}
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
		private void btn_NewAddress_Click( object sender, EventArgs e )
		{
			Address = all_Addresses.NewAddress;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_InsertAddress_Click( object sender, EventArgs e )
		{
			if ( all_Addresses.InsertAddress( Address ) )
			{
				Address = all_Addresses.CurrentAddress;
				_Messenger.InsertSucceeded();
			}
			else
			{
				_Messenger.InsertFailed();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Update_Click( object sender, EventArgs e )
		{
			if ( all_Addresses.UpdateAddress( Address ) )
				_Messenger.UpdateSucceeded();
			else
				_Messenger.UpdateFailed();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_CloseForm_Click( object sender, EventArgs e )
		{
			this.Close();
		}
		#endregion

		#endregion


		#region INITIALISATION / FINALISATION
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm()
		{
			PopulateComboBoxes();
			PutHeader();
			SetTabIndices();
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

			btn_DefaultPostalRule.TabIndex = 30;
			tbx_VcfPostal.TabIndex = 31;
			tbx_PostalRealised.TabIndex = 32;

			btn_DefaultPhysicalRule.TabIndex = 33;
			tbx_VcfPhysical.TabIndex = 34;
			tbx_PhysicalRealised.TabIndex = 35;

			btn_DefaultExtendedRule.TabIndex = 36;
			tbx_VcfExtended.TabIndex = 37;
			tbx_ExtendedRealised.TabIndex = 38;

			btn_DefaultExcelRule.TabIndex = 39;
			tbx_ExcelPattern.TabIndex = 40;
			tbx_XL_RowRealised.TabIndex = 41;

			tbx_Filter.TabIndex = 42;
			btn_FirstAddress.TabIndex = 43;
			btn_PreviousAddress.TabIndex = 44;
			btn_NextAddress.TabIndex = 45;
			btn_LastAddress.TabIndex = 46;

			btn_FindAddress.TabIndex = 47;
			btn_InsertAddress.TabIndex = 48;
			btn_UpdateAddress.TabIndex = 49;

			chk_Selected.TabIndex = 50;
			chk_DefaultRow.TabIndex = 51;
			chk_Unattached.TabIndex = 52;
			chk_X_Person.TabIndex = 53;
			chk_X_Group.TabIndex = 54;
			chk_X_Family.TabIndex = 55;
			chk_Christmas.TabIndex = 56;

			btn_CloseForm.TabIndex = 57;
		}
		#endregion

		private void FrmAddress_Load( object sender, EventArgs e )
		{
			//TODO Use for initialisation? Yes, but do this as the next phase of work.
		}
	}
}
