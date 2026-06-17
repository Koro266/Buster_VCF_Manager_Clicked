//___________________________________________________________________________________________________________________________________________________
//LOCAL
using COLUMNS		= CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS.Column;
using READER		= CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS.Database.PersonEddressReader;
using XEDDRESS_ROW	= CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XEDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns PERSON.X.Eddress constrained by pk_Person_X_Eddress.
			/// </summary>
			public class ByPkEddress
			{
				READER person_eddress_reader;
				private const string sql_text =
				@"
					SELECT 
						TDF_Persons_X_Eddresses.pk_Person_X_Eddress,
						TDF_Persons_X_Eddresses.fk_Person,
						TDF_Persons_X_Eddresses.fk_Eddress,
						TDF_Persons_X_Eddresses.st_ListOrder,
						TDF_Persons_X_Eddresses.st_Label
					FROM 
						TDF_Persons_X_Eddresses 
					WHERE 
						(((TDF_Persons_X_Eddresses.pk_Person_X_Eddress)=@pk_person_x_eddess));
				";

				//___________________________________________________________________________________________________________________________________
				public ByPkEddress( int pk )
				{
					COLUMNS.PK_Person_X_Eddress pk_column = new COLUMNS.PK_Person_X_Eddress( pk );
					person_eddress_reader = new READER( sql_text, pk_column.DbParameter );
				}
				//___________________________________________________________________________________________________________________________________
				public XEDDRESS_ROW Execute
				{
					get { return person_eddress_reader.ReadPersonEddress(); }
				}
			}
		}
	}
}
