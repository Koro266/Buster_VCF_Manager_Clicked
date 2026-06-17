//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.CONNECTION;
//LOCAL
using GROUP_ROW = CONTACTS.LOCAL.PRIMARY.GROUP.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class Update
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// UPDATEs existing TDF_Groups row specified by pk_Group.
			/// </summary>
			public class Group : DbConnection
			{
				private const string sql_text =
				@"						
					UPDATE					
						TDF_Groups				
					SET					
						TDF_Groups.st_GroupName		= @st_groupname,	
						TDF_Groups.st_GroupType		= @st_grouptype,	
						TDF_Groups.st_Notes			= @st_notes,	
						TDF_Groups.dt_CurrencyDate	= @dt_currencydate	
					WHERE					
						(((TDF_Groups.pk_Group)		= @pk_group	));
				";

				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Updates all columns of a single, existing, TDF_Groups row specified by pk_Group.
				/// </summary>
				public Group( GROUP_ROW group ) : base( sql_text )
				{
					base.DbCommand.Parameters.Add( group.GroupName.DbParameter );
					base.DbCommand.Parameters.Add( group.GroupType.DbParameter );
					base.DbCommand.Parameters.Add( group.Notes.DbParameter );
					base.DbCommand.Parameters.Add( group.CurrencyDate.DbParameter );
					base.DbCommand.Parameters.Add( group.PkGroup.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns true if update succeeds, false on exception.
				/// </summary>
				public bool Execute
				{
					get
					{
						try
						{
							base.Connection.Open();
							base.DbCommand.ExecuteNonQuery();
							base.Connection.Close();
							return true;
						}
						catch ( Exception e )
						{
							Connection.Close();
							return false;
						}
					}
				}
			}
		}
	}
}
