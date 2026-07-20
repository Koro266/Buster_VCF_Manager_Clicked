//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using COUNT		= CONTACTS.GLOBAL.DATABASE.READ.Count;
//LOCAL
using COLUMNS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Count
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Determines if pk_Address is represented in TDF_Addresses.
			/// </summary>
			public class IsPkExtant : COUNT
			{
				private const string sql_text =
				@"
					SELECT 
						Count([pk_Address]) AS RowCount 
					FROM 
						TDF_Addresses 
					WHERE 
						(((TDF_Addresses.pk_Address) = @pk_address));
				";
				//_______________________________________________________________________________________________________________________________
				public IsPkExtant( int pk_address ) : base( sql_text )
				{
					COLUMNS.PK_Address pk = new COLUMNS.PK_Address( pk_address );
					base.DbCommand.Parameters.Add( pk.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns true iff user-supplied pk_Address is represented in TDF_Addresses.
				/// </summary>
				public bool Execute
				{
					get { return base.RowCount > 0; }
				}
			}
		}
	}
}
