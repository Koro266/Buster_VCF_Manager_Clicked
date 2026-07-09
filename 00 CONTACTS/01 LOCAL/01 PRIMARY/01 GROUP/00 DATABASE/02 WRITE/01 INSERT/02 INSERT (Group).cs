//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.CONNECTION;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using GROUP_ROW = CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using COLUMNS = CONTACTS.LOCAL.PRIMARY.GROUP.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//_______________________________________________________________________________________________________________________________________
		public class Insert
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// INSERTs new, fully-qualified TDF_Group. Returns the PK of the INSERTed row.
			/// </summary>
			public class Group : DbConnection
			{
				private const string sql_text =
				@"		
					INSERT INTO TDF_Groups	
					( 	
						st_GroupName,
						st_GroupType,
						st_Notes,
						dt_CurrencyDate,
						is_Selected,
						is_DefaultRow,
						is_Export,
						is_Blocked,
						is_Inactive,
						is_StTheresa,
						is_Tradesman,
						is_Supplier,
						is_Writer 
					) 	
					VALUES	
					(	
						@st_groupname,
						@st_grouptype,
						@st_notes,
						@dt_currencydate,
						@is_selected,
						@is_defaultrow,
						@is_export,
						@is_blocked,
						@is_inactive,
						@is_sttheresa,
						@is_tradesman,
						@is_supplier,
						@is_writer
					);	
				";
				//_______________________________________________________________________________________________________________________________
				public Group( GROUP_ROW group ) : base( sql_text )
				{
					base.DbCommand.Parameters.Add( group.GroupName.DbParameter );
					base.DbCommand.Parameters.Add( group.GroupType.DbParameter );
					base.DbCommand.Parameters.Add( group.Notes.DbParameter );
					base.DbCommand.Parameters.Add( group.CurrencyDate.DbParameter );
					base.DbCommand.Parameters.Add( group.Selected.DbParameter );
					base.DbCommand.Parameters.Add( group.DefaultRow.DbParameter );
					base.DbCommand.Parameters.Add( group.Export.DbParameter );
					base.DbCommand.Parameters.Add( group.Blocked.DbParameter );
					base.DbCommand.Parameters.Add( group.Inactive.DbParameter );
					base.DbCommand.Parameters.Add( group.StTheresa.DbParameter );
					base.DbCommand.Parameters.Add( group.Tradesman.DbParameter );
					base.DbCommand.Parameters.Add( group.Supplier.DbParameter );
					base.DbCommand.Parameters.Add( group.Writer.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns MaxPk if INSERT succeeds, -1 if INSERT fails.
				/// </summary>
				public int Execute
				{
					get
					{
						try
						{
							base.Connection.Open();
							base.DbCommand.ExecuteNonQuery();
							base.Connection.Close();
							return new Count.MaxPk().Execute;
						}
						catch ( Exception e )
						{
							//exception
							Connection.Close();
							return PRESET.MINUS_ONE;
						}
					}
				}
			}
		}
	}
}
