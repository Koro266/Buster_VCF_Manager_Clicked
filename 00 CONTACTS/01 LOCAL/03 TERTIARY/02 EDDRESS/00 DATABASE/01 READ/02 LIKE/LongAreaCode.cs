//__________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using SELECT = CONTACTS.GLOBAL.DATABASE.READ.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.EDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________
		public partial class Like
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns pk_Device and concatenated TDF_Device rows where person LongAreaCode begins with the given character(s).
			/// </summary>
			public class LongAreaCode : SELECT
			{
				private readonly string target_field = "st_LongAreaCode";
				private const string sql_text =
				@"
					SELECT 
						[TDF_Devices].[pk_Device], 
						[TDF_Devices].[st_LongAreaCode] & ""		 | "" &  
						[TDF_Devices].[st_DialNumber] & "",		"" &  
						[TDF_Devices].[st_LongAreaCode] & "", "" &  
						[TDF_Devices].[st_ShortAreaCode] & "",  "" & 
						[TDF_Devices].[st_LeadingDigits] & "",  "" & 
						[TDF_Devices].[st_TrailingDigits] 
					FROM 
						TDF_Devices 
					WHERE 
						(((TDF_Devices.st_LongAreaCode) Like @subtext)) 
					ORDER BY 
						TDF_Devices.st_DialNumber;
				";

				//_______________________________________________________________________________________________________________________________
				public LongAreaCode( string sought_after_text )
				{
					base.SetParameter = sought_after_text;
					base.SetCount = sql_count.Replace( PRESET.S0, target_field );
					base.SetSelect = sql_text;
				}
			}
		}
	}
}
