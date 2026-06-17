//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset; 
using SHORT_TXT = CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// EXTENSIONS for ST_ProperSurname.
		/// </summary>
		public partial class ST_ProperSurname : SHORT_TXT
		{
			#region DECLARATIONS
			#endregion


			#region METHODS
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns value that is sent to the database.
			/// </summary>
			override public object DbWriteValue
			{
				get { return base.DbWriteValue; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is displayed in a TextBox.
			/// </summary>
			override public string TextboxValue
			{
				get { return base.TextboxValue; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns ProperSurname as used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.AsIs; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true if person has a valid ProperSurname value.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return base.IsNotAbsoluteNull; }
			}
			#endregion
		}
	}
}
