//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using SELECT = CONTACTS.GLOBAL.DATABASE.READ.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________
		public partial class Like
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns unique LongAreaCode + ShortAreaCode paired where the initial character of the code is '0'.
			/// Effectively, a NZ area code.
			/// </summary>
			public class NzAreaCodesPaired : SELECT
			{
				private const string sql_text =
				@"
					SELECT DISTINCT
						TDF_Devices.st_LongAreaCode,
						TDF_Devices.st_ShortAreaCode
					FROM
						TDF_Devices
					WHERE
						(((TDF_Devices.st_LongAreaCode) LIKE ""0*""))
					ORDER BY
						TDF_Devices.st_ShortAreaCode;
				";

				//_______________________________________________________________________________________________________________________________
				public NzAreaCodesPaired()
				{
					base.SetSelect = sql_text;
				}
			}
		}
	}
}
