//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.CONNECTION;
//LOCAL
using Eddress_ROW = CONTACTS.LOCAL.TERTIARY.EDDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.EDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class Update
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// UPDATEs existing TDF_Eddress row specified by pk_Eddress.
			/// </summary>
			public class Eddress : DbConnection
			{
				private const string sql_text =
				@"
					UPDATE 
						TDF_Eddresss 
					SET 
						TDF_Eddresss.fk_Country			=	@fk_country,
						TDF_Eddresss.st_LongAreaCode		=	@st_longareacode,
						TDF_Eddresss.st_ShortAreaCode	=	@st_shortareacode,
						TDF_Eddresss.st_LeadingDigits	=	@st_leadingdigits,
						TDF_Eddresss.st_TrailingDigits	=	@st_trailingdigits,
						TDF_Eddresss.st_EddressLocation	=	@st_Eddresslocation,
						TDF_Eddresss.st_EddressType		=	@st_Eddresstype,
						TDF_Eddresss.st_DialNumber		=	@st_dialnumber,
						TDF_Eddresss.st_PickerNumber		=	@st_pickernumber,
						TDF_Eddresss.st_Notes			=	@st_notes
					WHERE 
						(((TDF_Eddresss.pk_Eddress)=@pk_Eddress));
				";

				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Updates all columns of a single, existing, TDF_Eddresss row specified by pk_Eddress.
				/// </summary>
				public Eddress( Eddress_ROW Eddress ) : base( sql_text )
				{
					//base.DbCommand.Parameters.Add( Eddress.FkCountry.DbParameter );
					//base.DbCommand.Parameters.Add( Eddress.LongAreaCode.DbParameter );
					//base.DbCommand.Parameters.Add( Eddress.ShortAreaCode.DbParameter );
					//base.DbCommand.Parameters.Add( Eddress.LeadingDigits.DbParameter );
					//base.DbCommand.Parameters.Add( Eddress.TrailingDigits.DbParameter );
					//base.DbCommand.Parameters.Add( Eddress.EddressLocation.DbParameter );
					//base.DbCommand.Parameters.Add( Eddress.EddressType.DbParameter );
					//base.DbCommand.Parameters.Add( Eddress.DialNumber.DbParameter );
					//base.DbCommand.Parameters.Add( Eddress.PickerNumber.DbParameter );
					//base.DbCommand.Parameters.Add( Eddress.Notes.DbParameter );
					//base.DbCommand.Parameters.Add( Eddress.PkEddress.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
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
