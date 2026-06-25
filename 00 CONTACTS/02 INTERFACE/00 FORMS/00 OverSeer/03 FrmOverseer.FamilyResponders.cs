//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using FAMILY_FORM	= CONTACTS.INTERFACE.FORMS.FrmFamily;
//LOCAL
using FAMILY_ROW	= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using FAMILY_SELECT	= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Select;

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
		/// Processes the family with pk_Family = tbx_Primary_Key.Text.
		/// </summary>
		private void ExportOneFamily( int pk_family )
		{
			FAMILY_ROW family_row = new FAMILY_SELECT.ByPkFamily( pk_family ).Execute;
			
			family_row.ExportFamily();

			//	VCF_Familys vcf_families = new VCF_Familys();
			//	vcf_families.ExportFamily( family_id );
		}
		//___________________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all Familys with currency date >= dt_date_picker.Value.
		/// </summary>
		private void ExportRecentFamilys( DateTime dt )
		{
			//int family_count = new FAMILY_COUNT.CountUpdatedFamilys( dt ).Execute;

			//if ( family_count > GLOBAL_PRESET.ZERO )
			//{
			//	TDF_FAMILY[] tdf_familys = new FAMILY_SELECT.AfterCurrencyDate( family_count, dt ).Execute;
			//	VCF_Familys vcf_familys = new VCF_Familys();
			//	vcf_familys.ExportFamilys( tdf_familys );
			//}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Processes all familys into VCF files.
		/// </summary>
		private void ExportAllFamilys()
		{
			Dictionary<int, BASE_ROW> base_rows = new FAMILY_SELECT.AllFamilys().Execute;
			foreach ( BASE_ROW base_row in base_rows.Values )
			{
				FAMILY_ROW family_row = ( FAMILY_ROW )base_row;
				family_row.ExportFamily();
			}
		}
	}
}
