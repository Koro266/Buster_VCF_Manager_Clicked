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
		// TODO Delete / overwrite all VCF files before new files are exported.
		#endregion

		#region DECLARATIONS
		private GLOBAL_DB db_Connector = new GLOBAL_DB();
		private MESSENGER _Messenger;
		private const int _msg_Delay = 3000;
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public FrmOverseer()
		{
			InitializeComponent();
			InitialiseForm();

			_Messenger = new GLOBAL.Messenger( tbx_Export_Status );
			_Messenger.AsyncDelay = _msg_Delay;
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
		//___________________________________________________________________________________________________________________________________________
		private void btn_DoTheLot_Click( object sender, EventArgs e )
		{
			// TODO: This fails ... fix it.
			ExportAllGroups();
			ExportAllFamilys();
			ExportAllPersons();
		}
		#endregion


		#region USER-SUPPLIED VALUES
		//___________________________________________________________________________________________________________________________________________
		private int UserSuppliedPrimaryKey
		{
			get
			{
				if ( String.IsNullOrWhiteSpace( tbx_Primary_Key.Text ) )
					return GLOBAL_PRESET.ZERO;

				if ( String.IsNullOrEmpty( tbx_Primary_Key.Text ) )
					return GLOBAL_PRESET.ZERO;

				return Int32.Parse( tbx_Primary_Key.Text );
			}
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
		//___________________________________________________________________________________________________________________________________________
		private void DisableButton( Button button )
		{
			button.Enabled = false;
		}
		//___________________________________________________________________________________________________________________________________________
		private void EnableButton( Button button )
		{
			button.Enabled = true;
		}
		#endregion
	}

	#region TEXT ACCUMULATOR
	//TODO: Remove this from here.
	//_______________________________________________________________________________________________________________________________________________
	public class TextAccumulatorx : SHORT_TEXT
	{

		//___________________________________________________________________________________________________________________________________________
		public TextAccumulatorx() : base( GLOBAL_PRESET.ZLS )
		{
		}
		//___________________________________________________________________________________________________________________________________________
		public TextAccumulatorx	( string s ) : base( s )
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
