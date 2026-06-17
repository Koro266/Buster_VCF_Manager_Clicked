//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset; 
using DATE_TIME = CONTACTS.GLOBAL.DATABASE.COLUMN.Date_Time;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// EXTENSIONS for DT_CurrencyDate.
		/// </summary>
		public partial class DT_CurrencyDate : DATE_TIME
		{
			#region DECLARATIONS
			#endregion


			#region METHODS
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns CurrencyDate value that is displayed in a TextBox in format "ddd, d MMM yyyy".
			/// </summary>
			override public string TextboxValue
			{
				get { return base.As_ddd_d_MMM_yyyy; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns CurrencyDate as used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.As_YYYY_MM_DD; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true because every person has a CurrencyDate.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return true; }
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
