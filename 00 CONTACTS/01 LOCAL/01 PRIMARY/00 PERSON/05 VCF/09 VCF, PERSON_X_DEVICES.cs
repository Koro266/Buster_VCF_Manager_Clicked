//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using VCF_TEXT			= CONTACTS.GLOBAL.VCF.VcfText;
using PRESET			= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using PERSON_ROW		= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using DEVICE_ROW		= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using XDEVICE_ROW		= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Row;
using SELECT_DEVICE		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Select;
using SELECT_XDEVICES	= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON.VCF
{
	//___________________________________________________________________________________________________________________________________________
	/// <summary>
	/// Writes Person's devices to VcfText.
	/// </summary>
	public class Vcf_09_PersonDeviceLines
	{
		private PERSON_ROW _Person;
		private DEVICE_ROW _Device;

		private const string DEVICE_Line = "item#0.TEL;type=pref:#1";
		private const string DEVICE_Label = "item#0.X-ABLabel:#1 {#2};";

		//___________________________________________________________________________________________________________________________________________
		public Vcf_09_PersonDeviceLines( PERSON_ROW person )
		{
			_Person = person;
		}
		//___________________________________________________________________________________________________________________________________________
		public void AppendLines( VCF_TEXT vcf_text )
		{
			Dictionary<int, BASE_ROW> person_x_devices = new SELECT_XDEVICES.ByPkPerson( _Person.PkPerson.Value ).Execute;
			if ( person_x_devices.Count == 0 )
				return;

			foreach ( var kvp in person_x_devices )
			{
				XDEVICE_ROW pxd = ( XDEVICE_ROW )kvp.Value;
				_Device = new SELECT_DEVICE.ByPkDevice( pxd.FkDevice.Value ).Execute;
				Construction( vcf_text, pxd );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private void Construction( VCF_TEXT vcf_text, XDEVICE_ROW xdevice_row )
		{
			string s;

			s = DEVICE_Line;
			s = s.Replace( PRESET.S0, vcf_text.NextItem );
			s = s.Replace( PRESET.S1, _Device.DialNumber.Value );
			vcf_text.NextIndex = s;

			s = DEVICE_Label;
			s = s.Replace( PRESET.S0, vcf_text.CurrentItem );
			s = s.Replace( PRESET.S1, xdevice_row.Label.Value );
			s = s.Replace( PRESET.S2, xdevice_row.PkPerson_X_Device.AsString );
			vcf_text.NextIndex = s;
		}
	}
}
