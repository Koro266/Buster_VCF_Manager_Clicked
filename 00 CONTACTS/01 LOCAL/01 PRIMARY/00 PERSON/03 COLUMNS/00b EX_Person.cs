//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset; 
using INT_32	= CONTACTS.GLOBAL.DATABASE.COLUMN.Integer_32;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// EXTENSIONS for PK_Person.
		/// </summary>
		public partial class PK_Person : INT_32
		{
			#region DECLARATIONS
			#endregion


			#region METHODS
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is displayed in a TextBox.
			/// </summary>
			override public string TextboxValue
			{
				get { return base.AsString; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns PkPerson.AsString.
			/// </summary>
			override public string VcfValue
			{
				get { return base.AsString; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true because this field is a primary key.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return true; }
			}
			#endregion
		}
	}
}
