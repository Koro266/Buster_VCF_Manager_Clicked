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
			bool is_group = false;
			GROUP_ROW group_row;

			is_group = new GROUP_COUNT.IsPkExtant( pk_group ).Execute;
			if ( !is_group )
			{
				_Messenger.Message = $"PK Group: {pk_group} does not exist in Persons table.";
				return;
			}

			group_row = new GROUP_SELECT.ByPkGroup( pk_group ).Execute;

			is_group = group_row.Export.Value;
			if ( !is_group )
			{
				_Messenger.Message = $"Group: {pk_group} is not exportable.";
				return;
			}

			group_row.ExportGroup();
			msg = $"{group_row.GroupName.AsUpper} (PK = {group_row.PkGroup.AsString}) successfully exported.";

			_Messenger.Message = msg;
		}
		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all Groups with currency date >= dt_date_picker.Value.
		/// </summary>
		private void ExportRecentGroups( DateTime dt )
		{
			string msg;
			int count = 0;
			DATE_TIME date_time = new DATE_TIME( dt );

			count = new GROUP_COUNT.CountAfterCurrencyDate( dt ).Execute;
			if ( count == 0 )
			{
				_Messenger.Message = $"There are no Groups updated after {date_time.As_d_MMM_yyyy}.";
				return;
			}

			count = 0;
			Dictionary<int, BASE_ROW> base_rows = new GROUP_SELECT.SelectAfterCurrencyDate( dt ).Execute;
			foreach ( BASE_ROW base_row in base_rows.Values )
			{
				GROUP_ROW group_row = ( GROUP_ROW )base_row;
				if ( group_row.Export.Value == false )
				{
					_Messenger.Message = $"Person: {group_row.PkGroup.Value} is not exportable.";
					break;
				}
				count++;
				group_row.ExportGroup();
			}
			_Messenger.Message = $"{count} Groups, updated after {date_time.AsDisplayedDate}, have been exported.";
		}
		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Exports all Groups to VCF files.
		/// </summary>
		private async void ExportAllGroups()
		{
			_EventState.DisableButton( _btn_Export_All_Persons );

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
							if ( group_row.Export.Value == true )
							{
								group_row.ExportGroup();
								current_count++;
							}

							( ( IProgress<int> )progress ).Report( current_count );
						}
					}
					);

			_Messenger.Done();

			_EventState.EnableButton( _btn_Export_All_Groups );
		}
	}
}
