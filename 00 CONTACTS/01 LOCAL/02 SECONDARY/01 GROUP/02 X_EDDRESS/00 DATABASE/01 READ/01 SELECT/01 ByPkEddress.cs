//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS		= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Column;
using READER		= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Database.GroupEddressReader;
using XEDDRESS_ROW	= CONTACTS.LOCAL.SECONDARY.GROUP.XEDDRESS.Row;

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
			/// Returns GROUP.X.Eddress constrained by pk_Eddress.
			/// </summary>
			public class ByPkEddress
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
						(((TDF_Groups_X_Eddresses.fk_Eddress)=@fk_eddress));
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkEddress( int pk_eddress )
				{
					COLUMNS.FK_Eddress fk_eddress_column = new COLUMNS.FK_Eddress( pk_eddress );
					group_eddress_reader = new READER( sql_text, fk_eddress_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public XEDDRESS_ROW Execute
				{
					get { return group_eddress_reader.ReadGroupEddress(); }
				}
			}
		}
	}
}
