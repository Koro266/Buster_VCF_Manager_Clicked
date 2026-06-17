//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using LIKE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.LikeRow;
//LOCAL
using PERSON_ROW 	= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using SELECT		= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Select;
using LIKE			= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.DIALOGS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class DlgFindPerson : Form
	{
		#region DECLARATION & CONSTRUCTION
		private LIKE_ROW[] matching_Persons;
		private LIKE_ROW currently_selected_person;
		private int pk_SelectedPerson = PRESET.MINUS_ONE;

		//___________________________________________________________________________________________________________________________________________
		public DlgFindPerson()
		{
			InitializeComponent();
		}
		#endregion


		#region RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		private string ProperSurname
		{
			set
			{
				Clear();
				matching_Persons = new LIKE.ProperSurname( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string GivenName
		{
			set
			{
				Clear();
				matching_Persons = new LIKE.GivenName( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string MiddleNames
		{
			set
			{
				Clear();
				matching_Persons = new LIKE.MiddleNames( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string NickName
		{
			set
			{
				Clear();
				matching_Persons = new LIKE.NickName( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string BirthName
		{
			set
			{
				Clear();
				matching_Persons = new LIKE.BirthName( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Prefix
		{
			set
			{
				Clear();
				//matching_Persons = new LIKE.Prefix( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Suffix
		{
			set
			{
				Clear();
				//matching_Persons = new LIKE.Suffix( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Initials
		{
			set
			{
				Clear();
				//matching_Persons = new LIKE.Initials( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Gender
		{
			set
			{
				Clear();
				//matching_Persons = new LIKE.Gender( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Notes
		{
			set
			{
				Clear();
				//matching_Persons = new LIKE.Notes( value ).Execute;
				Display();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		//private int PkSelectedValue
		//{
		//	set
		//	{
		//		switch ( value )
		//		{
		//			case < 0:
		//				PkSelectedPerson = PRESET.MINUS_ONE;
		//				this.DialogResult = DialogResult.Cancel;
		//				break;

		//			default:
		//				PkSelectedPerson = this.matching_Persons[lbx_MatchingPersons.SelectedIndex].PkRow;
		//				this.DialogResult = DialogResult.OK;
		//				break;
		//		}

		//		this.Close();
		//	}
		//}
		//___________________________________________________________________________________________________________________________________________
		private int PkSelectedPerson
		{
			get { return pk_SelectedPerson; }
			set { pk_SelectedPerson = value; }
		}
		#endregion


		#region RETURN VALUE
		//___________________________________________________________________________________________________________________________________________
		public PERSON_ROW SelectedPerson
		{
			get { return new SELECT.ByPkPerson( PkSelectedPerson ).Execute; }
		}
		#endregion


		#region TEXT-CHANGED HANDLERS
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ProperSurname_TextChanged( object sender, EventArgs e )
		{
			ProperSurname = this.tbx_ProperSurname.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_GivenName_TextChanged( object sender, EventArgs e )
		{
			GivenName = this.tbx_GivenName.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_MiddleNames_TextChanged( object sender, EventArgs e )
		{
			MiddleNames = this.tbx_MiddleNames.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_NickName_TextChanged( object sender, EventArgs e )
		{
			NickName = this.tbx_NickName.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_BirthName_TextChanged( object sender, EventArgs e )
		{
			BirthName = this.tbx_BirthName.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Prefix_TextChanged( object sender, EventArgs e )
		{
			Prefix = this.tbx_Prefix.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Suffix_TextChanged( object sender, EventArgs e )
		{
			Suffix = this.tbx_Suffix.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Initials_TextChanged( object sender, EventArgs e )
		{
			Initials = this.tbx_Initials.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Gender_TextChanged( object sender, EventArgs e )
		{
			Gender = this.tbx_Gender.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_Notes_TextChanged( object sender, EventArgs e )
		{
			Notes = this.tbx_Notes.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingPersons_SelectedValueChanged( object sender, EventArgs e )
		{
			currently_selected_person = ( LIKE_ROW )lbx_MatchingPersons.SelectedItem;
			tbx_CurrentlySelectedPerson.Text = currently_selected_person.LikeValue;

			PkSelectedPerson = currently_selected_person.PkRow;
		}
		//___________________________________________________________________________________________________________________________________________
		private void lbx_MatchingPersons_DoubleClick( object sender, EventArgs e )
		{
			PkSelectedPerson = ( ( LIKE_ROW )lbx_MatchingPersons.SelectedItem ).PkRow;
			this.Close();
		}
		#endregion


		#region DISPLAY
		//___________________________________________________________________________________________________________________________________________
		private void Clear()
		{
			this.lbx_MatchingPersons.Items.Clear();
		}
		//___________________________________________________________________________________________________________________________________________
		private void Display()
		{
			this.lbx_MatchingPersons.Items.AddRange( matching_Persons );
		}
		#endregion


		#region TERMINATION
		//___________________________________________________________________________________________________________________________________________
		private void btn_CloseForm_Click( object sender, EventArgs e )
		{
			this.DialogResult = pk_SelectedPerson > 0 ? DialogResult.OK : DialogResult.Cancel;
			this.Close();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Cancel_Click( object sender, EventArgs e )
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		#endregion
	}
}
