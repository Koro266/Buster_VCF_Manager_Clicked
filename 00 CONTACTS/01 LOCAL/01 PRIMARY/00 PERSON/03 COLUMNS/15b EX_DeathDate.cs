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
		/// EXTENSIONS for DT_DeathDate.
		/// </summary>
		public partial class DT_DeathDate : DATE_TIME
		{
			#region DECLARATIONS
			#endregion


			#region METHODS
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns DeathDate value that is displayed in a TextBox in format "ddd, d MMM yyyy".
			/// </summary>
			override public string TextboxValue
			{
				get { return base.As_ddd_d_MMM_yyyy; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns DeathDate as used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.As_YYYY_MM_DD; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true if person has a valid DeathDate value.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return base.IsNotAbsoluteNull; }
			}
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
				get { return base.DbWriteDate( DATE_TIME.DatabaseDeathDateFormat ); }
			}
			#endregion
		}
	}
}
