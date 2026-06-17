//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS		= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Column;
using READER		= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Database.FamilyEddressReader;
using XEDDRESS_ROW	= CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS.Row;

namespace CONTACTS.LOCAL.SECONDARY.FAMILY.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns FAMILY.X.Eddress constrained by pk_Eddress.
			/// </summary>
			public class ByPkEddress
			{
				READER family_eddress_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Families_X_Eddresses.pk_Family_X_Eddress,
						TDF_Families_X_Eddresses.fk_Family,
						TDF_Families_X_Eddresses.fk_Eddress,
						TDF_Families_X_Eddresses.st_ListOrder,
						TDF_Families_X_Eddresses.st_Label
					FROM 
						TDF_Families_X_Eddresses 
					WHERE 
						(((TDF_Families_X_Eddresses.fk_Eddress)=@fk_eddess));
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkEddress( int pk_eddress )
				{
					COLUMNS.FK_Eddress fk_eddress_column = new COLUMNS.FK_Eddress( pk_eddress );
					family_eddress_reader = new READER( sql_text, fk_eddress_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public XEDDRESS_ROW Execute
				{
					get { return family_eddress_reader.ReadFamilyEddress(); }
				}
			}
		}
	}
}
