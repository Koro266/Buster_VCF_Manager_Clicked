//___________________________________________________________________________________________________________________________________________________
using System;
using System.Data.OleDb;
//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using DATE_TIME		= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using NULL_BOOL		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<bool>;
using NULL_DATE		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<System.DateTime>;
using NULL_INT		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<int>;
using NULL_SHORT	= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<short>;
using NULL_TEXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
using NULLITY		= CONTACTS.GLOBAL.Nullity;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.COLUMN
{
	//_______________________________________________________________________________________________________________________________________________
	public class BaseColumn
	{
		#region DECLARATIONS
		private NULLITY nullity_Value;
		#endregion


		#region CONSTRUCTORS
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a BaseColumn with Nullity value = DbNull.
		/// </summary>
		public BaseColumn()
		{
			nullity_Value = NULLITY.DbNull;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a Base Text Column with Nullity value = either DbNull (value == null) or NotNull (value <ne> null ).
		/// </summary>
		public BaseColumn( object value )
		{
			nullity_Value = value is null ? NULLITY.DbNull : NULLITY.NotNull;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a Base Text Column with Nullity value = either DbNull (value == null) or NotNull (value <ne> null ).
		/// </summary>
		public BaseColumn( string value )
		{
			nullity_Value = value is null ? NULLITY.DbNull : NULLITY.NotNull;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a BaseColumn with Nullity value = either DbNull (value == null) or NotNull (value <ne> null ).
		/// </summary>
		public BaseColumn( DateTime value )
		{
			if ( value == DATE_TIME.DbNullDate )
			{
				nullity_Value = NULLITY.DbNull;
				return;
			}

			if ( value >= DATE_TIME.MinControllableDate )
			{
				nullity_Value = NULLITY.NotNull;
				return;
			}

			if ( value < DATE_TIME.MinControllableDate )
			{
				nullity_Value = NULLITY.FunctionalNull;
			}

			nullity_Value = NULLITY.DbNull;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a BaseColumn with Nullity value = either DbNull (value == null) or NotNull (value <ne> null ).
		/// </summary>
		public BaseColumn( bool value )
		{
			nullity_Value = NULLITY.NotNull;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a BaseColumn with Nullity value = either DbNull (value == null) or NotNull (value <ne> null ).
		/// </summary>
		public BaseColumn( int value )
		{
			nullity_Value = NULLITY.NotNull;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a BaseColumn with Nullity value = either DbNull (value == null) or NotNull (value <ne> null ).
		/// </summary>
		public BaseColumn( short value )
		{
			nullity_Value = NULLITY.NotNull;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a Base Text Column with Nullity value = either DbNull (value == null) or NotNull (value <ne> null ).
		/// </summary>
		public BaseColumn( NULL_TEXT value )
		{
			nullity_Value = value.NullState;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a BaseColumn with Nullity value = either DbNull (value == null) or NotNull (value <ne> null ).
		/// </summary>
		public BaseColumn( NULL_DATE value )
		{
			nullity_Value = value.NullState;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a BaseColumn with Nullity value = either DbNull (value == null) or NotNull (value <ne> null ).
		/// </summary>
		public BaseColumn( NULL_BOOL value )
		{
			nullity_Value = value.NullState;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a BaseColumn with Nullity value = either DbNull (value == null) or NotNull (value <ne> null ).
		/// </summary>
		public BaseColumn( NULL_INT value )
		{
			nullity_Value = value.NullState;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates a BaseColumn with Nullity value = either DbNull (value == null) or NotNull (value <ne> null ).
		/// </summary>
		public BaseColumn( NULL_SHORT value )
		{
			nullity_Value = value.NullState;
		}
		#endregion


		#region OUTPUT VALUES
		//___________________________________________________________________________________________________________________________________________
		virtual public string FinderValue
		{
			get { return string.Empty; }
		}
		//___________________________________________________________________________________________________________________________________________
		virtual public string VcfValue
		{
			get { return string.Empty; }
		}
		//___________________________________________________________________________________________________________________________________________
		virtual public bool IsVcfValue
		{
			get { return false; }
		}
		//___________________________________________________________________________________________________________________________________________
		virtual public bool IsDatePickerDisplayable
		{
			get { return true; }
		}
		//___________________________________________________________________________________________________________________________________________
		virtual public DateTime DatePickerValue
		{
			get { return DateTime.Now; }
		}
		//___________________________________________________________________________________________________________________________________________
		virtual public string DatePickerFormat
		{
			get { return string.Empty; }
		}
		//___________________________________________________________________________________________________________________________________________
		virtual public string TextboxValue
		{
			get { return string.Empty; }
		}
		//___________________________________________________________________________________________________________________________________________
		virtual public object DbWriteValue
		{
			get { return ( object )System.DBNull.Value; }
		}
		#endregion


		#region NULL STATE
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the NULLITY value.
		/// </summary>
		virtual public NULLITY NullState
		{
			get { return nullity_Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if nullity value == DbNull.
		/// </summary>
		virtual public bool IsNull
		{
			get { return NullState == NULLITY.DbNull; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if nullity value == FunctionalNull.
		/// </summary>
		virtual public bool IsFunctionalNull
		{
			get { return NullState == NULLITY.FunctionalNull; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if nullity value == NotNull.
		/// </summary>
		virtual public bool IsNotNull
		{
			get { return NullState == NULLITY.NotNull; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Absolute null means: the value cannot be used in any downstream context.
		/// Returns true if NullState == DbNull, false otherwise.
		/// </summary>
		virtual public bool IsAbsoluteNull
		{
			get { return IsNull; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// NOT Absolute null means: the value may be used in some, but not all, downstream contexts.
		/// That is, NullState may be either NotNull or FunctionalNull.
		/// Returns true if nullity value is NOT IsAbsoluteNull.
		/// </summary>
		virtual public bool IsNotAbsoluteNull
		{
			get { return IsAbsoluteNull; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Relative null means: the value may be used in some -- but not all -- downstream contexts.
		/// Returns true if nullity value == DbNull or FunctionalNull.
		/// Returns false if nullity value == NotNull.
		/// </summary>
		virtual public bool IsRelativeNull
		{
			get
			{
				switch ( NullState )
				{
					case NULLITY.NotNull:
						return false;

					case NULLITY.FunctionalNull:
						return true;

					case NULLITY.DbNull:
						return true;

					default:
						return false;
				}
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// NOT relative null means: the value is functionally null and therefore may not be used in any downstream context.
		/// Returns true if nullity value == DbNull, false otherwise.
		/// </summary>
		virtual public bool IsNotRelativeNull
		{
			get { return IsRelativeNull; }
		}
		#endregion
	}
}
