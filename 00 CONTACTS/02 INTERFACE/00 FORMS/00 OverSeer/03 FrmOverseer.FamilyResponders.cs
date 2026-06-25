//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using FAMILY_ROW	= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using FAMILY_SELECT	= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Select;
using FAMILY_COUNT	= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Count;
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
				msg = $"Primary key: {pk_family} does not exist in Persons table.";
			}

			_Messenger.Message = msg;
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
