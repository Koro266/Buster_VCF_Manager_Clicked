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
			bool is_person = false;
			PERSON_ROW person_row;

			is_person = new PERSON_COUNT.IsPersonExtant( pk_person ).Execute;
			if ( !is_person )
			{
				_Messenger.Message = $"PK Person: {pk_person} does not exist in Persons table.";
				return;
			}

			person_row = new PERSON_SELECT.ByPkPerson( pk_person ).Execute;

			is_person = person_row.Export.Value;
			if ( !is_person )
			{
				_Messenger.Message = $"Person: {pk_person} is not exportable.";
				return;
			}

			person_row.ExportPerson();
			msg = $"{person_row.SortableName.AsUpper} (PK = {person_row.PkPerson.AsString}) successfully exported.";

			_Messenger.Message = msg;
		}
		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all Persons with currency date >= dt_date_picker.Value.
		/// </summary>
		private void ExportRecentPersons( DateTime dt )
		{
			string msg;
			int count = 0;
			DATE_TIME date_time =new DATE_TIME(dt);

			count = new PERSON_COUNT.CountAfterCurrencyDate( dt ).Execute;
			if ( count == 0 )
			{
				_Messenger.Message = $"There are no Persons updated after {date_time.As_d_MMM_yyyy}.";
				return;
			}

			count = 0;
			Dictionary<int, BASE_ROW> base_rows = new PERSON_SELECT.SelectAfterCurrencyDate( dt ).Execute;
			foreach ( BASE_ROW base_row in base_rows.Values )
			{
				PERSON_ROW person_row = ( PERSON_ROW )base_row;
				if ( person_row.Export.Value == false )
				{
					_Messenger.Message = $"Person: {person_row.PkPerson.Value} is not exportable.";
					break;
				}
				count++;
				person_row.ExportPerson();
			}
			_Messenger.Message = $"{count} Persons, updated after {date_time.AsDisplayedDate}, have been exported.";
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
								if ( person_row.Export.Value == true )
								{
									person_row.ExportPerson();
									current_count++;
								}

								( ( IProgress<int> )progress ).Report( current_count );
							}
						} 
					);

			_Messenger.Done();

			_EventState.EnableButton( _btn_Export_All_Persons );
		}
	}
}
