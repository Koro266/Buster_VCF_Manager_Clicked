//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using GIANT_SWITCH	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.TheGiantSwitch;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER
{
	//___________________________________________________________________________________________________________________________________________
	public class VcfPostalRealiser : BASE_ROW
	{
		private ADDRESS_ROW _AddressRow;
		private GIANT_SWITCH _Switch;

		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Constructs a VCF Postal address using the postal definition in the database address row. 
		/// </summary>
		public VcfPostalRealiser( ADDRESS_ROW address_row )
		{
			_AddressRow = address_row;
			_Switch = new GIANT_SWITCH( address_row );
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to a ListBox.Items property; i.e., a 'vertical' address format.
		/// </summary>
		public string[] ListBoxItems()
		{
			return new string[] { "", "" };
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to the TextBox.Lines property; i.e., a 'vertical' address format.
		/// </summary>
		public string[] TextBoxLines()
		{
			return new string[] { "", "" };
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to the ListView.Item property; i.e., a 'horizontal' address format.
		/// </summary>
		public string[] ListViewItem()
		{
			return new string[] { "", "" };
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to the ListView.SubItems property; i.e., a 'horizontal' address format.
		/// </summary>
		public string[] ListViewSubItems()
		{
			return new string[] { "", "" };
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a string[] intended to be assigned to a VCF output file; i.e., a 'vertical' address format.
		/// </summary>
		public string[] VcfAddress()
		{
			return new string[] { "", "" };
		}

		#region THESE CREATE A STRING[] WHICH IS USED BY FORMS.
		//_______________________________________________________________________________________________________________________________________
		public string RealisePostalRule()
		{
			/// /hn /sn /st\n/ct, /pc\n/si
			//TODO 'format' result ...
			return _Switch.RealiseAddressRule( _AddressRow.VcfPostal.Value );
			//return SplitAddress( realised_rule );
		}
		//_______________________________________________________________________________________________________________________________________
		public string RealisePhysicalRule()
		{
			/// /hn /sn /st\n/sb, /ct\n/mt, /pv\n/si
			return _Switch.RealiseAddressRule( _AddressRow.VcfPhysical.Value );
			//return realised_rule;
			//return SplitAddress( realised_rule );
		}
		//_______________________________________________________________________________________________________________________________________
		public string RealiseExtendedRule()
		{
			/// /as\n/lv\n/un\n/ex
			string realised_rule = _Switch.RealiseAddressRule( _AddressRow.VcfExtended.Value );
			return realised_rule;
			//return SplitAddress( realised_rule );
		}
		//_______________________________________________________________________________________________________________________________________
		public string RealiseExcelRule()
		{
			/// SID*AID*FID*SRT*OUT*/hn /sn /st*/ct*/pc*/cy
			string realised_rule = _Switch.RealiseAddressRule( _AddressRow.ExcelPattern.Value );
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
