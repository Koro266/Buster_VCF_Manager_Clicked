//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using DATE_TIME		= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using FAMILY_ROW	= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using FAMILY_COUNT	= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Count;
using FAMILY_SELECT	= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Select;
//INTERFACE
using FAMILY_FORM	= CONTACTS.INTERFACE.FORMS.FrmFamily;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.FORMS
{
	//___________________________________________________________________________________________________________________________________________________
	public partial class FrmOverseer
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Displays the family form.
		/// </summary>
		public void OpenFamilyForm()
		{
			new FAMILY_FORM().Show();
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Displays the family form.
		/// </summary>
		public void OpenFamilyXForm()
		{
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes the Family with pk_Family = tbx_Primary_Key.Text.
		/// </summary>
		private void ExportOneFamily( int pk_family )
		{
			string msg;
			FAMILY_ROW family_row;

			if ( new FAMILY_COUNT.IsFamilyExtant( pk_family ).Execute )
			{
				family_row = new FAMILY_SELECT.ByPkFamily( pk_family ).Execute;
				family_row.ExportFamily();

				msg = $"{family_row.SortableName.AsUpper} (PK = {family_row.PkFamily.AsString}) successfully exported.";
			}
			else
			{
				msg = $"Primary key: {pk_family} does not exist in Families table.";
			}

			_Messenger.Message = msg;
		}
		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all Familys with currency date >= dt_date_picker.Value.
		/// </summary>
		private void ExportRecentFamilys( DateTime dt )
		{
			string msg;
			DATE_TIME date_time = new DATE_TIME( dt );

			int count = new FAMILY_COUNT.CountAfterCurrencyDate( dt ).Execute;

			if ( count > GLOBAL_PRESET.ZERO )
			{
				Dictionary<int, BASE_ROW> base_rows = new FAMILY_SELECT.SelectAfterCurrencyDate( dt ).Execute;
				foreach ( BASE_ROW base_row in base_rows.Values )
				{
					FAMILY_ROW family_row = ( FAMILY_ROW )base_row;
					family_row.ExportFamily();
				}
				msg = $"{count} Families updated after {date_time.AsDisplayedDate} have been exported.";
			}
			else
			{
				msg = $"There are no Families updated after {date_time.As_d_MMM_yyyy}.";
			}

			_Messenger.Message = msg;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all Family rows into VCF files.
		/// </summary>
		private async void ExportAllFamilys()
		{
			_EventState.DisableButton( this._btn_Export_All_Families );

			Dictionary<int, BASE_ROW> base_rows = new FAMILY_SELECT.AllFamilys().Execute;

			int family_count = base_rows.Count;
			tbx_Export_Status.Text = $"Working on 0 of {family_count} Families ...";

			var progress = new Progress<int>
				(
					count =>
					{
						tbx_Export_Status.Text = $"Working on {count} of {family_count} Families ...";
					}
				);

			await
				Task.Run
					( () =>
					{
						int current_count = 0;
						foreach ( BASE_ROW base_row in base_rows.Values )
						{
							FAMILY_ROW family_row = ( FAMILY_ROW )base_row;
							family_row.ExportFamily();
							current_count++;

							( ( IProgress<int> )progress ).Report( current_count );
						}
					}
					);

			_Messenger.Message = "Done!";

			_EventState.EnableButton( _btn_Export_All_Families );
		}
	}
}
