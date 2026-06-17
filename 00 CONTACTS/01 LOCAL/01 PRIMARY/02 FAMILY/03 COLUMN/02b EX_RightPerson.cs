//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using NULLITY	= CONTACTS.GLOBAL.Nullity;
using INT_32	= CONTACTS.GLOBAL.DATABASE.COLUMN.Integer_32;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// EXTENSIONS for FK_RightPerson.
		/// </summary>
		public partial class FK_RightPerson : INT_32
		{
			#region DECLARATIONS
			#endregion


			#region METHODS
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is displayed on a form.
			/// </summary>
			public string DisplayValue
			{
				get { return base.AsString; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.VcfValue; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true iff there is a right person.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return base.NullState == NULLITY.NotNull; }
			}
			#endregion
		}
	}
}
