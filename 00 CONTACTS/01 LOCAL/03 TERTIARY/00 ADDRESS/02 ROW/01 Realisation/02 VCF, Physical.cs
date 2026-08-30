//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW   = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using GIANT_SWITCH	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row.TheGiantSwitch;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class VcfPhysicalRealiser : BASE_ROW
		{
			private ADDRESS_ROW _AddressRow;
			private GIANT_SWITCH _Switch;
			private static string VcfAddressPattern = "/bx /rd;/sb /ct /mt /pc;/hn /sn /st /cp;/pv /pa;/as  /lv /un /ex;/cy";

			//___________________________________________________________________________________________________________________________________________
			public VcfPhysicalRealiser( ADDRESS_ROW address_row )
			{
				_AddressRow = address_row;
				_Switch = new GIANT_SWITCH( address_row );
			}
			//_______________________________________________________________________________________________________________________________________
			public string RealiseVcfRule()
			{
				string realised_rule = _Switch.RealiseAddressRule( VcfAddressPattern );
				return realised_rule;
				//return SplitAddress( realised_rule );
			}
			//___________________________________________________________________________________________________________________________________________                                                                                                                                                   
			private string[] SplitAddress( string in_line )
			{
				return in_line.Split( PRESET.Functional_LF, StringSplitOptions.None );
			}

			#region THESE CREATE A STRING[] WHICH IS USED BY FORMS.
			//_______________________________________________________________________________________________________________________________________
			public string[] RealisePostalRule()
			{
				//REALISE_FORM realise_form = new REALISE_FORM( this );
				//string s = realise_form.RealisePostalRule();
				//string realised_rule = RealiseAddressRule( _AddressRow.VcfPostal.Value );
				//return SplitAddress( realised_rule );
				return new string[0];
			}
			//_______________________________________________________________________________________________________________________________________
			public string[] RealisePhysicalRule()
			{
				//string realised_rule = RealiseAddressRule( _AddressRow.VcfPhysical.Value );
				//return SplitAddress( realised_rule );
				return new string[0];
			}
			//_______________________________________________________________________________________________________________________________________
			public string[] RealiseExtendedRule()
			{
				//string realised_rule = RealiseAddressRule( _AddressRow.VcfExtended.Value );
				//return SplitAddress( realised_rule );
				return new string[0];
			}
			//_______________________________________________________________________________________________________________________________________
			public string[] RealiseExcelRule()
			{
				//string realised_rule = RealiseAddressRule( _AddressRow.ExcelPattern.Value );
				//return SplitAddress( realised_rule );
				return new string[0];
			}
			////___________________________________________________________________________________________________________________________________________                                                                                                                                                   
			//private string[] SplitAddress( string in_line )
			//{
			//	return in_line.Split( PRESET.Functional_LF, StringSplitOptions.None );
			////	return new string[0];
			//}
			#endregion


			#region THESE CREATE A STRING WHICH IS INSERTED INTO THE VCF FILE.
			//_______________________________________________________________________________________________________________________________________
			public string VcfPostalRule
			{
				get
				{
					//string[] s = RealisePostalRule();
					//return s.Replace( PRESET.Functional_LF, PRESET.CommaSpace );
					string s = "";
					return s;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public string VcfPhysicalRule
			{
				get
				{
					//string s = RealiseAddressRule( this.VcfPhysicalRule );
					//return s.Replace( PRESET.Functional_LF, PRESET.CommaSpace );
					string s = "";
					return s;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public string VcfExtendedRule
			{
				get
				{
					//string s = RealiseAddressRule( this.VcfExtendedRule );
					//return s.Replace( PRESET.Functional_LF, PRESET.CommaSpace );
					string s = "";
					return s;
				}
			}
			//_______________________________________________________________________________________________________________________________________
			public string VcfExcelRule
			{
				get
				{
					//string s = RealiseAddressRule( this.ExcelPattern.Value );
					//return s.Replace( PRESET.OneAster, PRESET.CommaSpace );
					string s = "";
					return s;
				}
			}
			#endregion

		}
	}
}
