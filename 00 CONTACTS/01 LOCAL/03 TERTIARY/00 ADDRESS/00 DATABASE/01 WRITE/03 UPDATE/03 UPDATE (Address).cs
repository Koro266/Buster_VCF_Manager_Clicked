//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.CONNECTION;
//LOCAL
using ADDRESS_ROW = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public class Update
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// UPDATEs existing TDF_Addresses row specified by PkAddress.
			/// </summary>
			public class Address : DbConnection
			{
				private const string sql_text =
				@"						
					UPDATE					
						TDF_Addresses				
					SET					
						TDF_Addresses.fk_Country			= @fk_country,	
						TDF_Addresses.st_Assemblage			= @st_assemblage,	
						TDF_Addresses.st_Level				= @st_level,	
						TDF_Addresses.st_Unit				= @st_unit,	
						TDF_Addresses.st_Extension			= @st_extension,	
						TDF_Addresses.st_RuralDelivery		= @st_ruraldelivery,	
						TDF_Addresses.st_PostalCode			= @st_postalcode,	
						TDF_Addresses.st_BoxNumber			= @st_boxnumber,	
						TDF_Addresses.st_HouseNumber		= @st_housenumber,	
						TDF_Addresses.st_StreetName			= @st_streetname,	
						TDF_Addresses.st_StreetType			= @st_streettype,	
						TDF_Addresses.st_Compass			= @st_compass,	
						TDF_Addresses.st_Suburb				= @st_suburb,	
						TDF_Addresses.st_City				= @st_city,	
						TDF_Addresses.st_Metropolitan		= @st_metropolitan,	
						TDF_Addresses.st_ProvinceName		= @st_provincename,	
						TDF_Addresses.st_ProvinceCode		= @st_provincecode,	
						TDF_Addresses.st_VcfPostal			= @st_vcfpostal,	
						TDF_Addresses.st_VcfPhysical		= @st_vcfphysical,	
						TDF_Addresses.st_VcfExtended		= @st_vcfextended,	
						TDF_Addresses.st_ExcelPattern		= @st_excelpattern,	
						TDF_Addresses.st_Notes				= @st_notes,	
						TDF_Addresses.is_Selected			= @is_selected,
						TDF_Addresses.is_DefaultRow			= @is_defaultrow,
						TDF_Addresses.is_Unattached			= @is_unattached,
						TDF_Addresses.is_X_Person			= @is_x_person,
						TDF_Addresses.is_X_Group			= @is_x_group,
						TDF_Addresses.is_X_Family			= @is_x_family,
						TDF_Addresses.is_Christmas			= @is_christmas
					WHERE					
						(((TDF_Addresses.pk_Address			= @pk_address)))
				";

				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Updates all columns of a single, existing, TDF_Addresses row specified by PkAddress.
				/// </summary>
				public Address( ADDRESS_ROW address ) : base( sql_text )
				{
					base.DbCommand.Parameters.Add( address.FkCountry.DbParameter );
					base.DbCommand.Parameters.Add( address.Assemblage.DbParameter );
					base.DbCommand.Parameters.Add( address.Level.DbParameter );
					base.DbCommand.Parameters.Add( address.Unit.DbParameter );
					base.DbCommand.Parameters.Add( address.Extension.DbParameter );
					base.DbCommand.Parameters.Add( address.RuralDelivery.DbParameter );
					base.DbCommand.Parameters.Add( address.PostalCode.DbParameter );
					base.DbCommand.Parameters.Add( address.BoxNumber.DbParameter );
					base.DbCommand.Parameters.Add( address.HouseNumber.DbParameter );
					base.DbCommand.Parameters.Add( address.StreetName.DbParameter );
					base.DbCommand.Parameters.Add( address.StreetType.DbParameter );
					base.DbCommand.Parameters.Add( address.Compass.DbParameter );
					base.DbCommand.Parameters.Add( address.Suburb.DbParameter );
					base.DbCommand.Parameters.Add( address.City.DbParameter );
					base.DbCommand.Parameters.Add( address.Metropolitan.DbParameter );
					base.DbCommand.Parameters.Add( address.ProvinceName.DbParameter );
					base.DbCommand.Parameters.Add( address.ProvinceCode.DbParameter );
					base.DbCommand.Parameters.Add( address.VcfPostal.DbParameter );
					base.DbCommand.Parameters.Add( address.VcfPhysical.DbParameter );
					base.DbCommand.Parameters.Add( address.VcfExtended.DbParameter );
					base.DbCommand.Parameters.Add( address.ExcelPattern.DbParameter );
					base.DbCommand.Parameters.Add( address.Notes.DbParameter );
					base.DbCommand.Parameters.Add( address.Selected.DbParameter );
					base.DbCommand.Parameters.Add( address.DefaultRow.DbParameter );
					base.DbCommand.Parameters.Add( address.Unattached.DbParameter );
					base.DbCommand.Parameters.Add( address.X_Person.DbParameter );
					base.DbCommand.Parameters.Add( address.X_Group.DbParameter );
					base.DbCommand.Parameters.Add( address.X_Family.DbParameter );
					base.DbCommand.Parameters.Add( address.Christmas.DbParameter );
					base.DbCommand.Parameters.Add( address.PkAddress.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns true if UPDATE SQL succeeds, false otherwise.
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
