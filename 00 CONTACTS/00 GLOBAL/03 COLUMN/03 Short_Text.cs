//___________________________________________________________________________________________________________________________________________________
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
//GLOBAL
using NULLITY		= CONTACTS.GLOBAL.Nullity;
using NULL_TEXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
using BASE_COLUMN	= CONTACTS.GLOBAL.DATABASE.COLUMN.BaseColumn;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.COLUMN
{
	//_______________________________________________________________________________________________________________________________________________
	/// <summary>
	/// NULLITY.DbNull			==> The supplied value is null (e.g., a database field that contains no value).
	/// NULLITY.FunctionalNull	==> The underlying value contains is String.Empty or whitespace only, i.e., a valid but useless value.
	/// NULLITY.NotNull			==> The underlying value contains rectified blackspace, i.e., a meaningful,  not null value.
	/// </summary>
	public class Short_Text : BASE_COLUMN
	{
		#region CONSTANTS
		private const string WhiteSpace				= @"\s";		//Finds whitespace.
		private const string BlackSpace				= @"\S";		//Finds not-whitespace (blackspace).
		private const string LeadingWhitespace		= @"^\s{1,}";	//Finds leading whitespace.
		private const string TrailingingWhitespace	= @"\s{1,}$";	//Finds trailing whitespace.
		private const string InterstitialWhitespace	= @"\s{2,}";	//Finds interstitial whitespace 2 or more characters long.
		#endregion


		#region STATIC VALUES
		public static string default_Text = String.Empty;
		#endregion


		#region DECLARATIONS
		private NULL_TEXT txt_Value;
		#endregion


		#region CONSTRUCTOR
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Null constructor is called by base reader if the field being read is DB null.
		/// NullState is DbNull so txt_Value becomes irrelevant.
		/// </summary>
		public Short_Text() : base()
		{
			txt_Value = new NULL_TEXT();
		}
		//___________________________________________________________________________________________________________________________________________
		public Short_Text( string value ) : base( value )
		{
			if ( value.Length > 0 )
			{
				txt_Value = new NULL_TEXT( value, NULLITY.NotNull );
			}
			else if ( value == String.Empty )
			{
				txt_Value = new NULL_TEXT( value, NULLITY.FunctionalNull );
			}
			else
			{
				txt_Value = new NULL_TEXT( value, NULLITY.DbNull );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public Short_Text( NULL_TEXT value ) : base( value )
		{
			txt_Value = value;
		}
		#endregion


		#region VALUE TRANSFORMATIONS.
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the rectified -- but otherwise untransformed -- version of the value supplied to the constructor.
		/// </summary>
		virtual public string Value
		{
			get { return this.IsNotAbsoluteNull ? this.txt_Value.Value : String.Empty; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the rectified -- but otherwise untransformed -- version of the value supplied to the constructor.
		/// </summary>
		virtual public string AsIs
		{
			get { return this.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the rectified -- but otherwise untransformed -- version of the value supplied to the constructor.
		/// </summary>
		virtual public string AsString
		{
			get { return this.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns rectified value coerced to upper case.
		/// </summary>
		virtual public string AsUpper
		{
			get { return this.Value.ToUpper(); }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns rectified value coerced to lower case.
		/// </summary>
		virtual public string AsLower
		{
			get { return this.Value.ToLower(); }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns, unmodified, the left-most char of value.
		/// </summary>
		private string Initial
		{
			get 
			{
				switch ( Value.Length )
				{
					case 0:
						return DefaultValue;

					case 1:
					case > 1:
						return this.Value.Substring( 0, 1 );

					default:
						return DefaultValue;
				}
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns, unmodified, the left-most char of value.
		/// </summary>
		virtual public string AsInitial
		{
			get { return this.Initial; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the left-most char of value coerced to upper case.
		/// </summary>
		virtual public string AsUpperInitial
		{
			get { return this.Initial.ToUpper(); }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the left-most char of value coerced to lower case.
		/// </summary>
		virtual public string AsLowerInitial
		{
			get { return this.Initial.ToLower(); }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns Value with left-most character in upper case and all succeeding characters in lower case.
		/// </summary>
		virtual public string AsProper
		{
			get
			{
				switch ( Value.Length )
				{
					case 0: //un-necessary.
						return DefaultValue;

					case 1:
						return Value.ToUpper();

					case > 1:
					default:
						return Value.Substring( 0, 1 ).ToUpper() + Value.Substring( 1 ).ToLower();
				}
			}
		}
		#endregion


		#region VALUE OVERRIDES
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns value formatted for use in a Find this-or-that context.
		/// </summary>
		override public string FinderValue
		{
			get { return base.IsNotNull ? this.AsIs : String.Empty; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns value formatted for use in a VCF file.
		/// </summary>
		override public string VcfValue
		{
			get { return base.IsNotNull ? this.AsIs : String.Empty; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns value compliant with TextBox.Value.
		/// </summary>
		override public string TextboxValue
		{
			get { return base.IsNotNull ? this.AsIs : String.Empty; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns (object)Value if nullity is not null.
		/// Returns (object)System.DBNull.Value if NullState == all other forms of nullity.
		/// </summary>
		override public object DbWriteValue
		{
			get { return base.IsNotNull ? ( object )Value : ( object )System.DBNull.Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns default value (String.Empty). 
		/// </summary>
		virtual public string DefaultValue
		{
			get { return default_Text; }
		}
		#endregion


		#region REGEX
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if string s contains at least one non-whitespace character.
		/// </summary>
		public static bool ContainsBlackSpace( string s )
		{
			return Regex.IsMatch( s, BlackSpace );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// If string s contains blackspace, s is rectified.
		/// That is:
		///		1. Removes all leading and trailing spaces and,
		///		2. Replaces 2+ interstitial spaces with 1 space.
		/// </summary>
		public string RectifyString( string s )
		{
			if ( this.IsNotAbsoluteNull )
			{
				//s has a least one char that is not whitespace, rectify that and send it back.
				s = Regex.Replace( s, LeadingWhitespace, PRESET.ZLS );
				s = Regex.Replace( s, TrailingingWhitespace, PRESET.ZLS );
				s = Regex.Replace( s, InterstitialWhitespace, PRESET.OneSpace );
			}

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// If string s contains blackspace, s is rectified.
		/// That is:
		///		1. Removes all leading and trailing spaces and,
		///		2. Replaces 2+ interstitial spaces with 1 space.
		/// </summary>
		public static string RectifyText( string s )
		{
			if ( s.Length > 0 )
			{
				//s is not and empty string.
				s = Regex.Replace( s, LeadingWhitespace, PRESET.ZLS );
				s = Regex.Replace( s, TrailingingWhitespace, PRESET.ZLS );
				s = Regex.Replace( s, InterstitialWhitespace, PRESET.OneSpace );
			}

			return s;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Removes all whitespace regardless of where it appears in the string.
		/// </summary>
		public static string DeSpace( string s )
		{
			return Regex.Replace( s, WhiteSpace, PRESET.ZLS );
		}
		#endregion


		#region DB INTERFACE
		//___________________________________________________________________________________________________________________________________________
		virtual public OleDbParameter DbParameter
		{
			get
			{
				OleDbParameter parameter = new OleDbParameter();
				parameter.DbType = DbType.String;
				parameter.Value = this.DbWriteValue;
				return parameter;
			}
		}
		#endregion
	}
}
