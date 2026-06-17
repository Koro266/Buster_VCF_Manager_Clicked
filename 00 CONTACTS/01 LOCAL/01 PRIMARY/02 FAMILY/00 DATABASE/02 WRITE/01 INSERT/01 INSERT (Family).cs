//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using DB_CONNECTION = CONTACTS.GLOBAL.DATABASE.CONNECTION.DbConnection;
//LOCAL
using FAMILY_ROW = CONTACTS.LOCAL.PRIMARY.FAMILY.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//_______________________________________________________________________________________________________________________________________
		public class Insert
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// INSERTs new, fully-qualified TDF_Family. Returns the PK of the INSERTed row.
			/// </summary>
			public class Family : DB_CONNECTION
			{
				private const string sql_text =
				@"		
					INSERT INTO TDF_Families	
					( 	
						fk_LeftPerson,
						fk_RightPerson,
						st_FamilyType,
						st_FamilyName,
						st_SortableName,
						st_JointName,
						st_NaturalName,
						st_PostalName,
						st_Notes,
						dt_WeddingDate,
						dt_CurrencyDate,
						is_Christmas,
						is_Dissolved,
						is_CorlettRd,
						is_StTheresa
					) 	
					VALUES	
					(	
						= @fk_leftperson,
						= @fk_rightperson,
						= @st_familytype,
						= @st_familyname,
						= @st_sortablename,
						= @st_jointname,
						= @st_naturalname,
						= @st_postalname,
						= @st_notes,
						= @dt_weddingdate,
						= @dt_currencydate,
						= @is_christmas,
						= @is_dissolved,
						= @is_corlettrd,
						= @is_sttheresa
					);	
				";
				//_______________________________________________________________________________________________________________________________
				public Family( FAMILY_ROW family ) : base( sql_text )
				{
					base.DbCommand.Parameters.Add( family.FkLeftPerson.DbParameter );
					base.DbCommand.Parameters.Add( family.FkRightPerson.DbParameter );
					base.DbCommand.Parameters.Add( family.FamilyType.DbParameter );
					base.DbCommand.Parameters.Add( family.FamilyName.DbParameter );
					base.DbCommand.Parameters.Add( family.SortableName.DbParameter );
					base.DbCommand.Parameters.Add( family.JointName.DbParameter );
					base.DbCommand.Parameters.Add( family.NaturalName.DbParameter );
					base.DbCommand.Parameters.Add( family.PostalName.DbParameter );
					base.DbCommand.Parameters.Add( family.Notes.DbParameter );
					base.DbCommand.Parameters.Add( family.WeddingDate.DbParameter );
					base.DbCommand.Parameters.Add( family.CurrencyDate.DbParameter );
					base.DbCommand.Parameters.Add( family.Christmas.DbParameter );
					base.DbCommand.Parameters.Add( family.Dissolved.DbParameter );
					base.DbCommand.Parameters.Add( family.CorlettRd.DbParameter );
					base.DbCommand.Parameters.Add( family.StTheresa.DbParameter );
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
