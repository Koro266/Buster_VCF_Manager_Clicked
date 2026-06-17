//___________________________________________________________________________________________________________________________________________________
using COUNT		= CONTACTS.GLOBAL.DATABASE.READ.Count;
using COLUMNS	= CONTACTS.LOCAL.PRIMARY.PERSON.Column;//.PK_Person;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Count
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true if pk_person corresponds to an existing Person row.
			/// </summary>
			public class IsPersonExtant : COUNT
			{
				private const string sql_text =
				@"
					SELECT 
						TDF_Persons.* 
					FROM 
						TDF_Persons 
					WHERE 
						(((TDF_Persons.pk_Person)=@pk_person));
				";

				//_______________________________________________________________________________________________________________________________
				public IsPersonExtant( int pk_person ) : base( sql_text )
				{
					COLUMNS.PK_Person pk_person_column = new COLUMNS.PK_Person( pk_person );
					base.DbCommand.Parameters.Add( pk_person_column.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				public IsPersonExtant( COLUMNS.PK_Person pk_person ) : base( sql_text )
				{
					base.DbCommand.Parameters.Add( pk_person.DbParameter );
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
