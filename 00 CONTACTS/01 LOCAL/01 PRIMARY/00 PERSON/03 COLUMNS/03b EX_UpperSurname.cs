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
		/// EXTENSIONS for ST_UpperSurname.
		/// </summary>
		public partial class ST_UpperSurname : SHORT_TXT
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
			/// Returns String.Empty. UpperSurname is a derived value and VCF name fields are constructed at Person.Row level.
			/// </summary>
			override public string VcfValue
			{
				get { return base.AsIs; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns false because the UpperSurname value is not used in the VCF record.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return false; }
			}
			#endregion
		}
	}
}
