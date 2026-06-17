//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using LIKE = CONTACTS.GLOBAL.DATABASE.READ.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________
		public partial class Like
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns PK_Person and concatenated TDF_Person rows where person NickName begins with the given character(s).
			/// </summary>
			public class NickName : LIKE
			{
				private readonly string target_field = "st_NickName";
				private const string sql_text =
				@"
					SELECT 
						TDF_Persons.pk_Person, 
						TDF_Persons.pk_Person & ""  |  "" & 
						TDF_Persons.st_NickName & ""		 : "" &  
						TDF_Persons.st_SortableName & "",		"" &  
						TDF_Persons.st_ProperSurname & "", "" &  
						TDF_Persons.st_GivenName & "",  "" & 
						TDF_Persons.st_MiddleNames & "",  "" & 
						TDF_Persons.st_Gender 
					FROM 
						TDF_Persons 
					WHERE 
						(((TDF_Persons.st_NickName) Like @subtext)) 
					ORDER BY 
						TDF_Persons.st_SortableName;
				";
				//_______________________________________________________________________________________________________________________________
				public NickName( string sought_after_text )
				{
					base.SetParameter = sought_after_text;
					base.SetCount = sql_count.Replace( PRESET.S0, target_field );
					base.SetSelect = sql_text;
				}
			}
		}
	}
}
