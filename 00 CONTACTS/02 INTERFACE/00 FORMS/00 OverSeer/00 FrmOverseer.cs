//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using MESSENGER		= CONTACTS.GLOBAL.Messenger;
using GLOBAL_DB		= CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnector;
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using SHORT_TEXT	= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using DATE_TIME		= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.FORMS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class FrmOverseer : Form
	{
		#region 00 TODO / DECLARE / CONSTRUCT

		#region TODO LIST
		#endregion

		#region DECLARATIONS
		private GLOBAL_DB db_Connector = new GLOBAL_DB();
		private MESSENGER _Messenger;

		private const string export_Completed = "Export completed.";
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public FrmOverseer()
		{
			InitializeComponent();
			InitialiseForm();

			_Messenger = new GLOBAL.Messenger( tbx_Export_Status );
		}
		#endregion

		#endregion


		#region TERTIARY EDITORS
		//___________________________________________________________________________________________________________________________________________
		private void btn_Eddresses_Click( object sender, EventArgs e )
		{
			OpenEddressForm();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Devices_Click( object sender, EventArgs e )
		{
			OpenDeviceForm();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_OpenAddressForm_Click( object sender, EventArgs e )
		{
			OpenAddressForm();
		}
		#endregion


		#region PERSONS
		//___________________________________________________________________________________________________________________________________________
		private void btn_Open_Person_Form_Click( object sender, EventArgs e )
		{ 
			OpenPersonForm(); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Open_Person_X_Form_Click( object sender, EventArgs e )
		{
			OpenPersonXForm();
		}
		//___________________________________________________________________________________________________________________________________________
		private void _btn_Export_One_Person_Click( object sender, EventArgs e )
		{ 
			ExportOnePerson( UserSuppliedPrimaryKey ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void _btn_Export_Recent_Persons_Click( object sender, EventArgs e )
		{ 
			ExportRecentPersons( UserSuppliedDate );
		}
		//___________________________________________________________________________________________________________________________________________
		private void _btn_Export_All_Persons_Click( object sender, EventArgs e )
		{ 
			ExportAllPersons(); 
		}
		#endregion


		#region GROUPS
		//___________________________________________________________________________________________________________________________________________
		private void btn_Open_Group_Form_Click( object sender, EventArgs e )
		{
			OpenGroupForm(); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Open_Group_X_Form_Click( object sender, EventArgs e )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		private void _btn_Export_One_Group_Click( object sender, EventArgs e )
		{
			ExportOneGroup( UserSuppliedPrimaryKey ); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void _btn_Export_Recent_Groups_Click( object sender, EventArgs e )
		{
			ExportRecentGroups( UserSuppliedDate );
		}
		//___________________________________________________________________________________________________________________________________________
		private void _btn_Export_All_Groups_Click( object sender, EventArgs e )
		{
			ExportAllGroups(); 
		}
		#endregion


		#region FAMILYS
		//___________________________________________________________________________________________________________________________________________
		private void btn_OpenFamilyForm_Click( object sender, EventArgs e )
		{
			OpenFamilyForm(); 
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Open_Family_X_Form_Click( object sender, EventArgs e )
		{
			OpenFamilyXForm();
		}
		//___________________________________________________________________________________________________________________________________________
		private void _btn_Export_One_Family_Click( object sender, EventArgs e )
		{
			ExportOneFamily( UserSuppliedPrimaryKey );
		}
		//___________________________________________________________________________________________________________________________________________
		private void _btn_Export_Recent_Families_Click( object sender, EventArgs e )
		{
			ExportRecentFamilys( UserSuppliedDate );
		}
		//___________________________________________________________________________________________________________________________________________
		private void _btn_Export_All_Families_Click( object sender, EventArgs e )
		{ 
			ExportAllFamilys(); 
		}
		#endregion


		#region USER-SUPPLIED VALUES
		//___________________________________________________________________________________________________________________________________________
		private int UserSuppliedPrimaryKey
		{
			get { return Int32.Parse( tbx_Primary_Key.Text ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private DateTime UserSuppliedDate
		{
			get { return dt_date_picker.Value; }
		}
		#endregion


		#region INITIALISATION / FINALISATION
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseForm()
		{
			PutHeader();
			InitialiseDatePicker();
		}
		//___________________________________________________________________________________________________________________________________________
		private void PutHeader()
		{
			this.Text = db_Connector.PartiallyQualifiedFileName;
		}
		//___________________________________________________________________________________________________________________________________________
		private void InitialiseDatePicker()
		{
			dt_date_picker.Value = DATE_TIME.ExportCurrencyDate;
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_CloseForm_Click( object sender, EventArgs e )
		{
			this.Close();
		}
		#endregion
	}

	#region TEXT ACCUMULATOR
	//TODO: Remove this from here.
	//_______________________________________________________________________________________________________________________________________________
	public class TextAccumulator : SHORT_TEXT
	{

		//___________________________________________________________________________________________________________________________________________
		public TextAccumulator() : base( GLOBAL_PRESET.ZLS )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		public TextAccumulator( string s ) : base( s )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		public string CurrentText
		{
			get { return base.Value; }
		}
	}
	#endregion
}
