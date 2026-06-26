//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using DATE_TIME		= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using PERSON_ROW	= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using PERSON_SELECT	= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Select;
using PERSON_COUNT	= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Count;
//INTERFACE
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
			string msg;
			PERSON_ROW person_row;
			
			if ( new PERSON_COUNT.IsPersonExtant( pk_person ).Execute )
			{
				person_row = new PERSON_SELECT.ByPkPerson( pk_person ).Execute;
				person_row.ExportPerson();

				msg = $"{person_row.SortableName.AsUpper} (PK = {person_row.PkPerson.AsString}) successfully exported.";
			}
			else
			{
				msg = $"Primary key: {pk_person} does not exist in Persons table.";
			}

			_Messenger.Message = msg;
		}
		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all Persons with currency date >= dt_date_picker.Value.
		/// </summary>
		private void ExportRecentPersons( DateTime dt )
		{
			string msg;
			DATE_TIME date_time =new DATE_TIME(dt);

			int count = new PERSON_COUNT.CountAfterCurrencyDate( dt ).Execute;

			if ( count > GLOBAL_PRESET.ZERO )
			{
				Dictionary<int, BASE_ROW> base_rows = new PERSON_SELECT.SelectAfterCurrencyDate( dt ).Execute;
				foreach ( BASE_ROW base_row in base_rows.Values )
				{
					PERSON_ROW person_row = ( PERSON_ROW )base_row;
					person_row.ExportPerson();
				}
				msg = $"{count} Persons updated after {date_time.AsDisplayedDate} have been exported.";
			}
			else
			{
				msg = $"There are no Persons updated after {date_time.As_d_MMM_yyyy}.";
			}

			_Messenger.Message = msg;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all Person rows into VCF files.
		/// </summary>
		private async void ExportAllPersons()
		{
			_EventState.DisableButton( _btn_Export_All_Persons );

			Dictionary<int, BASE_ROW> base_rows = new PERSON_SELECT.AllPersons().Execute;

			int person_count = base_rows.Count;
			tbx_Export_Status.Text = $"Working on 0 of {person_count} Persons ...";

			var progress = new Progress<int>
				( 
					count =>
					{
						tbx_Export_Status.Text = $"Working on {count} of {person_count} Persons ...";
					} 
				);

			await
				Task.Run
					( () =>
						{
							int current_count = 0;
							foreach ( BASE_ROW base_row in base_rows.Values )
							{
								PERSON_ROW person_row = ( PERSON_ROW )base_row;
								person_row.ExportPerson();
								current_count++;

								( ( IProgress<int> )progress ).Report( current_count );
							}
						} 
					);

			_Messenger.Message = "Done!";

			_EventState.EnableButton( _btn_Export_All_Persons );
		}
	}
}
