//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using CONTACTS.GLOBAL.DATABASE.COLUMN;
//LOCAL
using CONST			= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants;
using DATE_TIME		= CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;
using NULLITY		= CONTACTS.GLOBAL.Nullity;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// EXTENSIONS for DT_WeddingDate.
		/// </summary>
		public partial class DT_WeddingDate : DATE_TIME
		{
			#region DECLARATIONS
			#endregion


			#region METHODS
			//___________________________________________________________________________________________________________________________________________
			override public DateTime DatePickerValue
			{
				get { return base.IsNull ? DATE_TIME.MinControllableDate.Date : this.Value.Date; }
			}
			//___________________________________________________________________________________________________________________________________________
			override public string DatePickerFormat
			{
				get { return base.IsNull ? DATE_TIME.NullDateFormat : DATE_TIME.DisplayedDateFormat; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns value that is sent to the database.
			/// </summary>
			override public object DbWriteValue
			{
				get { return base.DbWriteDate( DATE_TIME.DatabaseCurrencyDateFormat ); }
			}
			#endregion
		}
	}
}
