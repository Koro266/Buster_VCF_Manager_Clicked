//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using GROUP_FORM	= CONTACTS.INTERFACE.FORMS.FrmGroup;
//LOCAL
using GROUP_ROW		= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using GROUP_SELECT	= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Select;

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
		/// Processes the group with pk_group.
		/// </summary>
		private void ExportOneGroup( int pk_group )
		{
			GROUP_ROW group_row = new GROUP_SELECT.ByPkGroup( pk_group ).Execute;
			group_row.ExportGroup();
		}
		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all Groups with currency date >= dt_date_picker.Value.
		/// </summary>
		private void ExportRecentGroups( DateTime dt )
		{
			//if{ new GROUP_COUNT.CountUpdatedPersons( dt ) <= GLOBAL_PRESET.ZERO )
			return;

			//	TDF_PERSON[] tdf_groups = new PERSON_SELECT.AfterCurrencyDate( group_count, dt ).Execute;
			//	VCF_Persons vcf_groups = new VCF_Persons();
			//	vcf_groups.ExportPersons( tdf_groups );
		}
		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all Groups.
		/// </summary>
		private void ExportAllGroups()
		{
			Dictionary<int, BASE_ROW> base_rows = new GROUP_SELECT.AllGroups().Execute;
			foreach ( BASE_ROW base_row in base_rows.Values )
			{
				GROUP_ROW group_row = ( GROUP_ROW )base_row;
				group_row.ExportGroup();
			}
		}
	}
}
