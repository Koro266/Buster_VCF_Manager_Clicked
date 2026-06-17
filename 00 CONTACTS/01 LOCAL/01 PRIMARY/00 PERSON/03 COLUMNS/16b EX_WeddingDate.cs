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
		/// EXTENSIONS for DT_WeddingDate.
		/// </summary>
		public partial class DT_WeddingDate : DATE_TIME
		{
			#region DECLARATIONS
			#endregion


			#region METHODS
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns WeddingDate value that is displayed in a TextBox in format "ddd, d MMM yyyy".
			/// </summary>
			override public string TextboxValue
			{
				get { return base.As_ddd_d_MMM_yyyy; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns WeddingDate as used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.As_YYYY_MM_DD; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true if person has a valid WeddingDate value.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return base.IsNotAbsoluteNull; }
			}
			//___________________________________________________________________________________________________________________________________________
			override public DateTime DatePickerValue
			{
				get { return base.IsNull ? DATE_TIME.MinControllableDate : this.Value; }
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
				get { return base.DbWriteDate( DATE_TIME.DatabaseWeddingDateFormat ); }
			}
			#endregion
		}
	}
}
