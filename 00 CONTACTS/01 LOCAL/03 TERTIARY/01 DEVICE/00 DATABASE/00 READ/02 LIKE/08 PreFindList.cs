//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using LIKE = CONTACTS.GLOBAL.DATABASE.READ.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________
		public partial class Like
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// PreFind is intended to avoid duplicating device numbers that are already present in the Devices table.
			/// </summary>
			public class PreFindList : LIKE
			{
				private readonly string target_field = "st_TrailingDigits";
				private const string sql_text =
				@"
					SELECT
						TDF_Devices.st_DialNumber
					FROM
						TDF_Devices
					WHERE
						(((TDF_Devices.st_TrailingDigits) = LIKE @subtext))
					ORDER BY
						TDF_Devices.st_DialNumber;
				";

				//_______________________________________________________________________________________________________________________________
				public PreFindList( string begins_with )
				{
					base.SetParameter = begins_with;
					//base.SetCount = sql_count.Replace( PRESET.S0, target_field );
					base.SetSelect = sql_text;
				}
			}
		}
	}
}
