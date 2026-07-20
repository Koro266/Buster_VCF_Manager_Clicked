//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.CONNECTION;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using ADDRESS_ROW = CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//_______________________________________________________________________________________________________________________________________
		public class Insert
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// INSERTs new, fully-qualified TDF_Address. Returns the PK of the INSERTed row.
			/// </summary>
			public class Address : DbConnection
			{
				private const string sql_text =
				@"		
					INSERT INTO TDF_Addresses	
					( 	
						fk_Country,
						st_Assemblage,
						st_Level,
						st_Unit,
						st_Extension,
						st_RuralDelivery,
						st_PostalCode,
						st_BoxNumber,
						st_HouseNumber,
						st_StreetName,
						st_StreetType,
						st_Compass,
						st_Suburb,
						st_City,
						st_Metropolitan,
						st_ProvinceName,
						st_ProvinceCode,
						st_VcfPostal,
						st_VcfPhysical,
						st_VcfExtended,
						st_ExcelPattern,
						st_Notes,
						is_Selected,
						is_DefaultRow,
						is_Unattached,
						is_X_Person,
						is_X_Group,
						is_X_Family,
						is_Christmas 
					) 	
					VALUES	
					(	
						@fk_country,
						@st_assemblage,
						@st_level,
						@st_unit,
						@st_extension,
						@st_ruraldelivery,
						@st_postalcode,
						@st_boxnumber,
						@st_housenumber,
						@st_streetname,
						@st_streettype,
						@st_compass,
						@st_suburb,
						@st_city,
						@st_metropolitan,
						@st_provincename,
						@st_provincecode,
						@st_vcfpostal,
						@st_vcfphysical,
						@st_vcfextended,
						@st_excelpattern,
						@st_notes,
						@is_selected,
						@is_defaultrow,
						@is_unattached,
						@is_x_person,
						@is_x_group,
						@is_x_family,
						@is_christmas
					);
				";
				//_______________________________________________________________________________________________________________________________
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
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns the PK of the INSERTed row if SQL succeeds, -1 if INSERT fails.
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
