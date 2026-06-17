//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using TDF_GROUP			= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using X_DEVICE_ROW		= CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE.Row;
using SELECT_XDEVICE	= CONTACTS.LOCAL.SECONDARY.GROUP.XDEVICE.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Group's devices to VcfText.
	/// </summary>
	public class Vcf_03_GroupDeviceLines
	{
		private TDF_GROUP _Group;
		private const string DEVICE_Line = "item#0.TEL;type=pref:#1";
		private const string DEVICE_Label = "item#0.X-ABLabel:#1 {#2};";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_03_GroupDeviceLines( TDF_GROUP group )
		{
			_Group = group;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> group_x_devices = new SELECT_XDEVICE.ByPkGroup( _Group.PkGroup.Value ).Execute;
			
			if ( group_x_devices.Count == 0 )
				return;

			foreach ( var kvp in group_x_devices )
			{
				string s;
				X_DEVICE_ROW group_x_device = ( X_DEVICE_ROW )kvp.Value;

				s = DEVICE_Line;
				s = s.Replace( PRESET.S0, vcf_text.NextItem );
				s = s.Replace( PRESET.S1, group_x_device.DialNumber.VcfValue );
				vcf_text.NextIndex = s;

				s = DEVICE_Label;
				s = s.Replace( PRESET.S0, vcf_text.CurrentItem );
				s = s.Replace( PRESET.S1, group_x_device.Label.VcfValue );
				s = s.Replace( PRESET.S2, group_x_device.FkDevice.VcfValue );
				vcf_text.NextIndex = s;
			}
		}
	}
}