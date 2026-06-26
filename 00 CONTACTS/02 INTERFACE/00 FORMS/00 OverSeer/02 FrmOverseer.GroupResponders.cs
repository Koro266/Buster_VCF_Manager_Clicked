//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using DATE_TIME		= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using GROUP_ROW		= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using GROUP_SELECT	= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Select;
using GROUP_COUNT	= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Count;
//INTERFACE
using GROUP_FORM	= CONTACTS.INTERFACE.FORMS.FrmGroup;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.FORMS
{
	//___________________________________________________________________________________________________________________________________________________
	public partial class FrmOverseer
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Displays the group form.
		/// </summary>
		public void OpenGroupForm()
		{
			new GROUP_FORM().Show();
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Displays the group x form.
		/// </summary>
		public void OpenGroupXForm()
		{
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes the group with pk_group = tbx_Primary_Key.Text.
		/// </summary>
		private void ExportOneGroup( int pk_group )
		{
			string msg;
			GROUP_ROW group_row;

			if ( new GROUP_COUNT.IsPkExtant( pk_group ).Execute )
			{
				group_row = new GROUP_SELECT.ByPkGroup( pk_group ).Execute;
				group_row.ExportGroup();

				msg = $"{group_row.GroupName.AsUpper} (PK = {group_row.PkGroup.AsString}) successfully exported.";
			}
			else
			{
				msg = $"Primary key: {pk_group} does not exist in Groups table.";
			}

			_Messenger.Message = msg;
		}
		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all Groups with currency date >= dt_date_picker.Value.
		/// </summary>
		private void ExportRecentGroups( DateTime dt )
		{
			string msg;
			DATE_TIME date_time = new DATE_TIME( dt );

			int count = new GROUP_COUNT.CountAfterCurrencyDate( dt ).Execute;

			if ( count > GLOBAL_PRESET.ZERO )
			{
				Dictionary<int, BASE_ROW> base_rows = new GROUP_SELECT.SelectAfterCurrencyDate( dt ).Execute;
				foreach ( BASE_ROW base_row in base_rows.Values )
				{
					GROUP_ROW group_row = ( GROUP_ROW )base_row;
					group_row.ExportGroup();
				}
				msg = $"{count} Groups updated after {date_time.AsDisplayedDate} have been exported.";
			}
			else
			{
				msg = $"There are no Groups updated after {date_time.As_d_MMM_yyyy}.";
			}

			_Messenger.Message = msg;
		}
		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Exports all Groups to VCF files.
		/// </summary>
		private async void ExportAllGroups()
		{
			DisableButton( this._btn_Export_All_Groups );

			Dictionary<int, BASE_ROW> base_rows = new GROUP_SELECT.AllGroups().Execute;

			int group_count = base_rows.Count;
			tbx_Export_Status.Text = $"Working on 0 of {group_count} Groups ...";

			var progress = new Progress<int>
				(
					count =>
					{
						tbx_Export_Status.Text = $"Working on {count} of {group_count} Groups ...";
					}
				);

			await 
				Task.Run
					( () =>
						{
							int current_count = 0;
							foreach ( BASE_ROW base_row in base_rows.Values )
							{
								GROUP_ROW group_row = ( GROUP_ROW )base_row;
								group_row.ExportGroup();
								current_count++;

								( ( IProgress<int> )progress ).Report( current_count );
							}
						}
					);

			_Messenger.Message = "Done!";

			EnableButton( _btn_Export_All_Groups );
		}
	}
}
