//___________________________________________________________________________________________________________________________________________________
using System.Data;
using System.Data.OleDb;
//GLOBAL
using BASE_VAR		= CONTACTS.GLOBAL.DATABASE.COLUMN.BaseColumn;
using DATE_TIME		= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using NULLITY		= CONTACTS.GLOBAL.Nullity;
using NULL_DATE		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<System.DateTime>;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.COLUMN
{
	//_______________________________________________________________________________________________________________________________________________
	/// <summary>
	/// NULLITY.DbNull			==> The supplied value is null (e.g., a database cell that contains no value).
	/// NULLITY.FunctionalNull	==> The underlying value is a valid DateTime that precedes 1 Jan 1753. A FunctionalNull value cannot be used in a DateTime Picker control.
	/// NULLITY.NotNull			==> The underlying value is a valid DateTime >= 1 Jan 1753.
	/// </summary>
	public class Date_Time : BASE_VAR
	{
		#region CONSTANTS
		//___________________________________________________________________________________________________________________________________________
		public const string UpdatedDateFormat			= "d MMM yyyy";					//4 Sep 1947
		public const string UpdatedTimeFormat			= "HH:mm";						//13:45
		public const string DisplayedDateFormat			= "ddd, dd MMMM yyyy";			//Wed, 24 September 1947
		public const string DisplayedDateTimeFormat		= "d MMMM yyyy, HH:mm";			//24 September 1947, 12:34
		public const string EncodedDateFormat			= "yyyy.MM.dd";					//1947.09.24
		public const string FilenameFormat				= "yyyy.MM.dd.HHmmss";			//1947.09.24.123405
		public const string EncodedDateTimeFormat		= "yyyy.MM.dd.HHmm";			//1947.09.24.1234

		public const string BirthDeathWeddingDateFormat	= "dd MMM yyyy";				//02 Sep 2025
		public const string CurrencyDateFormat			= "ddd, dd MMM yyyy, HH:mm";	//Tue, 02 Sep 2025, 12:34
		public const string DefaultDateFormat			= "ddd, d MMM yyyy";			//Tue, 2 Sep 2025
		public const string DefaultDateTimeFormat		= "ddd, d MMM yyyy, HH:mm";		//Tue, 2 Sep 2025, 12:34
		public const string SignalDateFormat			= "d.M.yyyy";					//1.1.0001

		public const string DatabaseDateFormat			= "dd MMM yyyy";				//24 Sep 1947
		public const string DatabaseBirthDateFormat		= "ddd, d MMM yyyy";			//Wed, 24 Sep 1947
		public const string DatabaseDeathDateFormat		= "ddd, d MMM yyyy";			//Wed, 24 Sep 1947
		public const string DatabaseWeddingDateFormat	= "ddd, d MMM yyyy";			//Wed, 24 Sep 1947

		//The format specification in the DB is: "ddd, dd-mmm-yyyy hh:nn".
		public const string DatabaseCurrencyDateFormat	= "dd-MMM-yyyy, HH:mm";         //Wed, 24-Sep-1947, 12:34
		public const string VcfCurrencyDateFormat		= "dd MMMM yyyy, HH:mm";	    //24 September 1947, 12:34
		public const string NullDateFormat				= " ";							//This clears the date control. Weird, but it works.
		#endregion


		#region STATIC VALUES
		//___________________________________________________________________________________________________________________________________________
		public static DateTime DbNullDate				= new DateTime( 0001, 1, 1 );						// 1 Jan 0001
		public static DateTime DefaultDate				= new DateTime( 0001, 1, 2 );						// 2 Jan 0001
		public static DateTime MaxUncontrollableDate	= new DateTime( 1752, 12, 31, 23, 59, 59, 999 );	// 1772.12.31.23.59.59.999: the maximum date that cannot be used in DateTime control.
		public static DateTime MinControllableDate		= new DateTime( 1753, 1, 1 );                       // 1 Jan 1753: the earliest date that the DateTime control can handle.
		public static DateTime Now { get { return DateTime.Now; } }
		public static DateTime ExportCurrencyDate { get { return Now.AddDays( -7 ); } }
		#endregion


		#region DECLARATIONS
		private NULL_DATE dt_Value;
		#endregion


		#region CONSTRUCTOR
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Null constructor is called by base reader if the field being read is DB null.
		/// </summary>
		public Date_Time() : base()
		{
			dt_Value = new NULL_DATE();
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a Date_Time with dt_Value = value. Nullity is defined based on incoming value.
		/// </summary>
		public Date_Time( DateTime value ) : base( value )
		{
			dt_Value = new NULL_DATE( value, base.NullState );
		}
		//___________________________________________________________________________________________________________________________________________
		public Date_Time( NULL_DATE value ) : base( value )
		{
			dt_Value = value;
		}
		#endregion


		#region OUTPUT VALUES
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns dt_Value if nullity value == NotNull or FunctionalNull.
		/// Returns DbNullDate if nullity value == DbNull.
		/// </summary>
		virtual public DateTime Value
		{
			get { return base.IsNotAbsoluteNull ? this.dt_Value.Value : DbNullDate; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns value.ToString( "d MMMM yyyy, HH:mm" ).
		/// </summary>
		override public string TextboxValue
		{
			get { return Value.ToString( DisplayedDateTimeFormat ); }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true iff nullity value == NotNull.
		/// </summary>
		override public bool IsDatePickerDisplayable
		{
			get { return dt_Value.NullState == NULLITY.NotNull; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns dt_Value if nullity value == NotNull.
		/// Returns DbNullDate if nullity value == DbNull or FunctionalNull.
		/// </summary>
		override public DateTime DatePickerValue
		{
			get
			{
				if ( IsDatePickerDisplayable )
					return dt_Value.Value;
				else
					return DbNullDate;	

			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns Birth Death Wedding DateFormat if nullity value == NotNull.
		/// Returns NullDateFormat if nullity value == DbNull or FunctionalNull.
		/// </summary>
		override public string DatePickerFormat
		{
			get 
			{
				if ( IsDatePickerDisplayable )
					return DATE_TIME.DatabaseCurrencyDateFormat;
				else
					return DATE_TIME.NullDateFormat;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns underlying Date formatted for use in a VCF file.
		/// </summary>
		override public string VcfValue
		{
			get { return Value.ToString( EncodedDateFormat ); }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true iff object has a valid (i.e., "Functional") Date value.
		/// </summary>
		override public bool IsVcfValue
		{
			get { return this.IsNotAbsoluteNull; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns System.DBNull.Value if underlying value is DbNull.
		/// Otherwise, returns appropriately formatted (object)Value.
		/// Must be overridden in derived classes which are required to supply the appropriate format.
		/// IOWs, parameter.Value must be set in the derived class
		/// </summary>
		virtual public object DbWriteDate( string db_write_fmt )
		{
			switch ( base.NullState )
			{
				case NULLITY.DbNull:
					return base.DbWriteValue;

				case NULLITY.NotNull:
				case NULLITY.FunctionalNull:
					return ( object )Value.ToString( db_write_fmt );

				default:
					return base.DbWriteValue;
			}
		}
		#endregion


		#region TRANSFORMATIONS
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns System.ToString().
		/// </summary>
		virtual public string AsString
		{
			get
			{
				if ( base.NullState == NULLITY.NotNull )
					return Value.ToString();
				else
					return PRESET.TwoAsters;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Formats date as: "d MMMM yyyy" = 24 September 1947.
		/// </summary>
		virtual public string AsDisplayedDate
		{
			get
			{
				if ( base.NullState == NULLITY.NotNull )
					return Value.ToString( DisplayedDateFormat );
				else
					return PRESET.TwoAsters;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Formats date as: "d MMMM yyyy, HH:mm" = 24 September 1947, 12:34.
		/// </summary>
		virtual public string AsDisplayedDateTime
		{
			get
			{
				if ( base.NullState == NULLITY.NotNull )
					return Value.ToString( DisplayedDateTimeFormat );
				else
					return PRESET.TwoAsters;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Formats date as: "yyyy.MM.dd" = 1947.09.24.
		/// </summary>
		virtual public string As_YYYY_MM_DD
		{
			get
			{
				if ( base.NullState == NULLITY.NotNull )
					return Value.ToString( EncodedDateFormat );
				else
					return PRESET.TwoAsters;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Formats date portion of the value as: "d MMM yyyy" = 24 Sep 1947.
		/// </summary>
		virtual public string As_d_MMM_yyyy
		{
			get
			{
				if ( base.NullState == NULLITY.NotNull )
					return Value.ToString( UpdatedDateFormat );
				else
					return PRESET.TwoAsters;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Formats time portion of the value as: "HH:mm" = 13:45.
		/// </summary>
		virtual public string As_HH_mm
		{
			get
			{
				if ( base.NullState == NULLITY.NotNull )
					return Value.ToString( UpdatedTimeFormat );
				else
					return PRESET.TwoAsters;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Formats time portion of the value as: "ddd, d MMM yyyy" = Tue, 2 Sep 2025.
		/// </summary>
		virtual public string As_ddd_d_MMM_yyyy
		{
			get
			{
				if ( base.NullState == NULLITY.NotNull )
					return Value.ToString( DefaultDateFormat );
				else
					return PRESET.TwoAsters;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Formats date as: "yyyy.MM.dd.HHmm" = 1947.09.24.1234.
		/// </summary>
		virtual public string As_YYYY_MM_DD_HH_MM
		{
			get
			{
				if ( base.NullState == NULLITY.NotNull )
					return Value.ToString( EncodedDateTimeFormat );
				else
					return PRESET.TwoAsters;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Formats date as: ""yyyy.MM.dd.HHmms"", HH:mm = 1947.09.24.123405 (FilenameFormat).
		/// </summary>
		virtual public string As_YYYY_MM_DD_HH_MM_SS
		{
			get
			{
				if ( base.NullState == NULLITY.NotNull )
					return Value.ToString( FilenameFormat );
				else
					return PRESET.TwoAsters;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Formats date as: dd MMMM yyyy, HH:mm:ss = 24 September 1947, 12:34.
		/// </summary>
		virtual public string As_VCF_CurrencyEntry
		{
			get
			{
				if ( base.NullState == NULLITY.NotNull )
					return Value.ToString( VcfCurrencyDateFormat );
				else
					return PRESET.TwoAsters;
			}
		}
		#endregion


		#region DB INTERFACE
		//___________________________________________________________________________________________________________________________________________
		virtual public OleDbParameter DbParameter
		{
			get
			{
				OleDbParameter parameter = new OleDbParameter();
				parameter.DbType = DbType.DateTime;
				return parameter;
			}
		}
		#endregion
	}
}