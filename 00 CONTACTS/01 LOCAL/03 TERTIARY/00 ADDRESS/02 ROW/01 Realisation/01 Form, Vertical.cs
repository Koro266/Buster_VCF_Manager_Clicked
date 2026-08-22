//___________________________________________________________________________________________________________________________________________________
using SBLDR = System.Text.StringBuilder;
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using PARENT_ROW = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISATION
{
	//___________________________________________________________________________________________________________________________________________
	public partial class RealiseForm: BASE_ROW
	{
		private PARENT_ROW _ParentRow;
		private TheGiantSwitch _Switch;

		//___________________________________________________________________________________________________________________________________________
		public RealiseForm( PARENT_ROW parent_row )
		{
			_ParentRow = parent_row;
			_Switch = new TheGiantSwitch( parent_row );
		}
		#region THESE CREATE A STRING[] WHICH IS USED BY FORMS.
		//_______________________________________________________________________________________________________________________________________
		public string RealisePostalRule()
		{
			//TODO 'format' result ...
			return _Switch.RealiseAddressRule( _ParentRow.VcfPostal.Value );
			//return SplitAddress( realised_rule );
		}
		//_______________________________________________________________________________________________________________________________________
		public string RealisePhysicalRule()
		{
			return _Switch.RealiseAddressRule( _ParentRow.VcfPhysical.Value );
			//return realised_rule;
			//return SplitAddress( realised_rule );
		}
		//_______________________________________________________________________________________________________________________________________
		public string RealiseExtendedRule()
		{
			string realised_rule = _Switch.RealiseAddressRule( _ParentRow.VcfExtended.Value );
			return realised_rule;
			//return SplitAddress( realised_rule );
		}
		//_______________________________________________________________________________________________________________________________________
		public string RealiseExcelRule()
		{
			string realised_rule = _Switch.RealiseAddressRule( _ParentRow.ExcelPattern.Value );
			return realised_rule;
			//return SplitAddress( realised_rule );
		}
		//___________________________________________________________________________________________________________________________________________                                                                                                                                                   
		private string[] SplitAddress( string in_line )
		{
			return in_line.Split( PRESET.Functional_LF, StringSplitOptions.None );
		}
		#endregion
	}
}
