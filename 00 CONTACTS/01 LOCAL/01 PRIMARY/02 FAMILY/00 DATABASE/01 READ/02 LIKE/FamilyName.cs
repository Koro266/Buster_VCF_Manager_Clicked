//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using LIKE = CONTACTS.GLOBAL.DATABASE.READ.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________
		public partial class Like
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Families[] LIKE TDF_Families.st_SortableName == sought_after_text.
			/// </summary>
			public class FamilyName : LIKE
			{
				private readonly string target_field = "st_BirthName";
				private const string sql_text =
				@"
					SELECT 
						TDF_Families.pk_Family, 
						TDF_Families.st_SortableName 
					FROM 
						TDF_Families 
					WHERE 
						(((TDF_Families.st_SortableName) Like @subtext)) 
					ORDER BY 
						TDF_Families.st_SortableName;
				";
				//_______________________________________________________________________________________________________________________________
				public FamilyName( string sought_after_text ) : base( sql_text )
				{
					base.SetParameter = sought_after_text;
					base.SetCount = sql_count.Replace( PRESET.S0, target_field );
					base.SetSelect = sql_text;
				}
			}
		}
	}
}
