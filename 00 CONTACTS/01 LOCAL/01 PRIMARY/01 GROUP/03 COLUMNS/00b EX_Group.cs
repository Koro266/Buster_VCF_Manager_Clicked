//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using NULLITY	= CONTACTS.GLOBAL.Nullity;
using INT_32	= CONTACTS.GLOBAL.DATABASE.COLUMN.Integer_32;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// EXTENSIONS for PK_Group.
		/// </summary>
		public partial class PK_Group : INT_32
		{
			#region DECLARATIONS
			#endregion


			/*
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
			/// Returns true because this is a primary key.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return true; }
			}
			#endregion
			*/
		}
	}
}
