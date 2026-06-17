//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using LIKE = CONTACTS.GLOBAL.DATABASE.READ.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.EDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________
		public partial class Like
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns device(s) that match (LIKE *) the specified portion of TrailingDigits field. 
			/// </summary>
			public class MatchingNumbersList : LIKE
			{
				private readonly string target_field = "st_TrailingDigits";
				private const string sql_text =
				@"
					SELECT 
						TDF_Devices.pk_Device, 
						[st_CountryCode] & "" "" & [st_LongAreaCode] & "" "" & [st_LeadingDigits] & "" "" & [st_TrailingDigits] AS Matches 
					FROM 
						TDF_Devices INNER JOIN TDF_Countries ON TDF_Devices.fk_Country = TDF_Countries.pk_Country 
					WHERE 
						(((TDF_Devices.st_TrailingDigits) LIKE @subtext)) 
					ORDER BY 
						TDF_Devices.st_DialNumber;
				";

				//_______________________________________________________________________________________________________________________________
				public MatchingNumbersList( string begins_with )
				{
					base.SetParameter = begins_with;
					base.SetCount = sql_count.Replace( PRESET.S0, target_field );
					base.SetSelect = sql_text;
				}
			}
		}
	}
}
