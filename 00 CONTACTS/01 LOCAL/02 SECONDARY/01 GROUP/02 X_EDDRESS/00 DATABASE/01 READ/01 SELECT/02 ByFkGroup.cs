//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Column;
using READER	= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Database.GroupEddressReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns Eddresses attached to a Group.
			/// </summary>
			public class ByPkGroup
			{
				READER group_eddress_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Groups_X_Eddresses.pk_Group_X_Eddress,
						TDF_Groups_X_Eddresses.fk_Group,
						TDF_Groups_X_Eddresses.fk_Eddress,
						TDF_Groups_X_Eddresses.st_ListOrder,
						TDF_Groups_X_Eddresses.st_Label
					FROM 
						TDF_Groups_X_Eddresses
					WHERE 
						(((TDF_Groups_X_Eddresses.fk_Group)=@fk_group))
					ORDER BY 
						TDF_Groups_X_Eddresses.st_ListOrder;
				";
				//___________________________________________________________________________________________________________________________________
				public ByPkGroup( int pk_group )
				{
					COLUMNS.FK_Group fk_column = new COLUMNS.FK_Group( pk_group );
					group_eddress_reader = new READER( sql_text, fk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return group_eddress_reader.ReadGroupEddresses(); }
				}
			}
		}
	}
}
