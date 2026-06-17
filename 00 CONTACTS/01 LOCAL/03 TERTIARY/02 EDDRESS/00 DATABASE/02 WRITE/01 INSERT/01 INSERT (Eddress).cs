//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.CONNECTION;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using EDDRESS_ROW = CONTACTS.LOCAL.TERTIARY.EDDRESS.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.EDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//_______________________________________________________________________________________________________________________________________
		public class Insert
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// INSERTs new, fully-qualified TDF_Device. Returns the PK of the INSERTed row.
			/// </summary>
			public class Eddress : DbConnection
			{
				private const string sql_text =
				@"
			//		INSERT INTO TDF_Devices 
			//		( 
			//			fk_Country,
			//			st_LongAreaCode,
			//			st_ShortAreaCode,
			//			st_LeadingDigits,
			//			st_TrailingDigits,
			//			st_DeviceLocation,
			//			st_DeviceType,
			//			st_DialNumber,
			//			st_PickerNumber,
			//			st_Notes
			//		)
			//		VALUES
			//		(
			//			@fk_country,
			//			@st_longareacode,
			//			@st_shortareacode,
			//			@st_leadingdigits,
			//			@st_trailingdigits,
			//			@st_devicelocation,
			//			@st_devicetype,
			//			@st_dialnumber,
			//			@st_pickernumber,
			//			@st_notes
			//		);
				";
				//_______________________________________________________________________________________________________________________________
				public Eddress( EDDRESS_ROW eddress ) : base( sql_text )
				{
			//		base.DbCommand.Parameters.Add( device.FkCountry.DbParameter );
			//		base.DbCommand.Parameters.Add( device.LongAreaCode.DbParameter );
			//		base.DbCommand.Parameters.Add( device.ShortAreaCode.DbParameter );
			//		base.DbCommand.Parameters.Add( device.LeadingDigits.DbParameter );
			//		base.DbCommand.Parameters.Add( device.TrailingDigits.DbParameter );
			//		base.DbCommand.Parameters.Add( device.DeviceLocation.DbParameter );
			//		base.DbCommand.Parameters.Add( device.DeviceType.DbParameter );
			//		base.DbCommand.Parameters.Add( device.DialNumber.DbParameter );
			//		base.DbCommand.Parameters.Add( device.PickerNumber.DbParameter );
			//		base.DbCommand.Parameters.Add( device.Notes.DbParameter );
				}
				//_______________________________________________________________________________________________________________________________
				/// <summary>
				/// Returns MaxPk if INSERT succeeds, -1 if INSERT fails.
				/// </summary>
			//	public int Execute
			//	{
			//		get
			//		{
			//			try
			//			{
			//				base.Connection.Open();
			//				base.DbCommand.ExecuteNonQuery();
			//				base.Connection.Close();
			//				return new Count.MaxPk().Execute;
			//			}
			//			catch ( Exception e )
			//			{
			//				//exception
			//				Connection.Close();
			//				return PRESET.MINUS_ONE;
			//			}
			//		}
			//	}
			}
		}
	}
}
