//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using COUNT		= CONTACTS.GLOBAL.DATABASE.READ.Count;
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.PRIMARY.GROUP.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Count
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Determines if pk_Group is represented in TDF_Groups.
			/// </summary>
			public class IsPkExtant : COUNT
			{
				private const string sql_text =
				@"
					SELECT 
						Count([pk_Group]) AS RowCount 
					FROM 
						TDF_Groups 
					WHERE 
						(((TDF_Groups.pk_Group) = @pk_group));
				";
				//_______________________________________________________________________________________________________________________________
				public IsPkExtant( int pk_group ) : base( sql_text )
				{
					COLUMNS.PK_Group pk = new COLUMNS.PK_Group( pk_group );
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns true iff user-supplied pk_Group is represented in TDF_Groups.
				/// </summary>
				public bool Execute { get { return base.RowCount > 0; } }
			}
		}
	}
}
