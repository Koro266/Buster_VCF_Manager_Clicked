//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using INT_32		= CONTACTS.GLOBAL.DATABASE.COLUMN.Integer_32;
using SHORT_TEXT	= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
//LOCAL
using PERSON_ROW	= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using PERSON_SELECT	= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Select;
using PERSON_COUNT	= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Count;
using PERSON_FORM	= CONTACTS.INTERFACE.FORMS.FrmPerson;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.FORMS
{
	//___________________________________________________________________________________________________________________________________________________
	public partial class FrmOverseer
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Displays the person form.
		/// </summary>
		public void OpenPersonForm()
		{
			new PERSON_FORM().Show();
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Displays the person_x_entity form.
		/// </summary>
		public void OpenPersonXForm()
		{
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes the person with pk_Person = tbx_Primary_Key.Text.
		/// </summary>
		private void ExportOnePerson( int pk_person )
		{
			INT_32 pk = new INT_32( pk_person );
			SHORT_TEXT msg = new SHORT_TEXT();

			if ( new PERSON_COUNT.IsPersonExtant( pk_person ).Execute )
			{
				PERSON_ROW person_row = new PERSON_SELECT.ByPkPerson( pk_person ).Execute;
				person_row.ExportPerson();
				msg = new SHORT_TEXT( person_row.SortableName + " exported." );
			}
			else
			{
				msg = new SHORT_TEXT( pk.AsString + " does not exist as a primary key in Persons table." );
			}

			_Messenger.Message = msg.Value;
		}
		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all Persons with currency date >= dt_date_picker.Value.
		/// </summary>
		private void ExportRecentPersons( DateTime dt )
		{
			if ( new PERSON_COUNT.CountAfterCurrencyDate( dt ).Execute <= GLOBAL_PRESET.ZERO )
				return;

			Dictionary<int, BASE_ROW> base_rows = new PERSON_SELECT.SelectAfterCurrencyDate( dt ).Execute;
			foreach ( BASE_ROW base_row in base_rows.Values )
			{
				PERSON_ROW person_row = ( PERSON_ROW )base_row;
				person_row.ExportPerson();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all Person rows into VCF files.
		/// </summary>
		private void ExportAllPersons()
		{
			Dictionary<int, BASE_ROW> base_rows = new PERSON_SELECT.AllPersons().Execute;
			foreach ( BASE_ROW base_row in base_rows.Values )
			{
				PERSON_ROW person_row = ( PERSON_ROW )base_row;
				person_row.ExportPerson();
			}
		}
	}
}
