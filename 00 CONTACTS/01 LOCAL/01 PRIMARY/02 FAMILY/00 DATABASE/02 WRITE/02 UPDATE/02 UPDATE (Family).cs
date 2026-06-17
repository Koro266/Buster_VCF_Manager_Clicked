//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.CONNECTION;
//LOCAL
using FAMILY_ROW = CONTACTS.LOCAL.PRIMARY.FAMILY.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class Update
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// UPDATEs existing TDF_Families row specified by pk_Family.
			/// </summary>
			public class Family : DbConnection
			{
				private const string sql_text =
				@"
					UPDATE					
						TDF_Families				
					SET					
						TDF_Families.fk_LeftPerson		= @fk_leftperson,	
						TDF_Families.fk_RightPerson		= @fk_rightperson,	
						TDF_Families.st_FamilyType		= @st_familytype,	
						TDF_Families.st_FamilyName		= @st_familyname,	
						TDF_Families.st_SortableName	= @st_sortablename,	
						TDF_Families.st_JointName		= @st_jointname,	
						TDF_Families.st_NaturalName		= @st_naturalname,	
						TDF_Families.st_PostalName		= @st_postalname,	
						TDF_Families.st_Notes			= @st_notes,	
						TDF_Families.dt_WeddingDate		= @dt_weddingdate,	
						TDF_Families.dt_CurrencyDate	= @dt_currencydate,	
						TDF_Families.is_Christmas		= @is_christmas,	
						TDF_Families.is_Dissolved		= @is_dissolved,	
						TDF_Families.is_CorlettRd		= @is_corlettrd,	
						TDF_Families.is_StTheresa		= @is_sttheresa	
					WHERE					
						(((TDF_Families.pk_Family		= @pk_family)))
				";

				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Updates all columns of a single, existing, TDF_Persons row specified by pk_Person.
				/// </summary>
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
					base.DbCommand.Parameters.Add( family.PkFamily.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns true if update succeeds, false on exception.
				/// </summary>
				public bool Execute
				{
					get { return base.ExecuteNonQuery; }
				}
			}
		}
	}
}
