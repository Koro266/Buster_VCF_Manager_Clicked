//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using FAMILY_ROW		= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using XDEVICE_ROW		= CONTACTS.LOCAL.SECONDARY.FAMILY.XDEVICE.Row;
using SELECT_XDEVICES	= CONTACTS.LOCAL.SECONDARY.FAMILY.XDEVICE.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Family's devices to VcfText.
	/// </summary>
	public class Vcf_04_FamilyDeviceLines
	{
		private FAMILY_ROW _Family;

		private const string DEVICE_Line = "item#0.TEL;type=pref:#1";
		private const string DEVICE_Label = "item#0.X-ABLabel:#1 {#2};";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_04_FamilyDeviceLines( FAMILY_ROW family )
		{
			_Family = family;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> family_x_devices = new SELECT_XDEVICES.ByPkFamily( _Family.PkFamily.Value ).Execute;
			if ( family_x_devices.Count == 0 )
				return;

			foreach ( var kvp in family_x_devices )
			{
				XDEVICE_ROW pxd = ( XDEVICE_ROW )kvp.Value;
				Construction( vcf_text, pxd );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void Construction( VCF_TEXT vcf_text, XDEVICE_ROW xdevice_row )
		{
			string s;

			s = DEVICE_Line;
			s = s.Replace( PRESET.S0, vcf_text.NextItem );
			s = s.Replace( PRESET.S1, xdevice_row.DialNumber.VcfValue );
			vcf_text.NextIndex = s;

			s = DEVICE_Label;
			s = s.Replace( PRESET.S0, vcf_text.CurrentItem );
			s = s.Replace( PRESET.S1, xdevice_row.Label.Value );
			s = s.Replace( PRESET.S2, xdevice_row.PkFamily_X_Device.AsString );
			vcf_text.NextIndex = s;
		}
	}
}
