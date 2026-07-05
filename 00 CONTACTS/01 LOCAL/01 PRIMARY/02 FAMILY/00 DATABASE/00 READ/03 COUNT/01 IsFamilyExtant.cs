//___________________________________________________________________________________________________________________________________________________
using COUNT		= CONTACTS.GLOBAL.DATABASE.READ.Count;
using COLUMNS	= CONTACTS.LOCAL.PRIMARY.FAMILY.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Count
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true if pk_Family corresponds to an existing Family row.
			/// </summary>
			public class IsFamilyExtant : COUNT
			{
				private const string sql_text =
				@"
					SELECT 
						TDF_Families.* 
					FROM 
						TDF_Families 
					WHERE 
						(((TDF_Families.pk_Family)=@pk_family));
				";

				//_______________________________________________________________________________________________________________________________
				public IsFamilyExtant( int pk_family ) : base( sql_text )
				{
					COLUMNS.PK_Family pk_family_column = new COLUMNS.PK_Family( pk_family );
					base.DbCommand.Parameters.Add( pk_family_column.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns TRUE if TDF_Person contains a row with pk_Person == pk_person.
				/// </summary>
				public bool Execute 
				{
					get { return base.RowCount > 0; } 
				}
			}
		}
	}
}
