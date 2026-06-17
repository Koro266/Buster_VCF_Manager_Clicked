//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using NULLITY	= CONTACTS.GLOBAL.Nullity;
using YES_NO	= CONTACTS.GLOBAL.DATABASE.COLUMN.True_False;
//LOCAL
using CONST		= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// EXTENSIONS for IS_Dissolved.
		/// </summary>
		public partial class IS_Dissolved : YES_NO
		{
			#region DECLARATIONS
			#endregion


			/*
			#region METHODS
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the format used to display the value on a form.
			/// </summary>
			public string DisplayValue
			{
				get { return base.AsTRUEFALSE; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.AsTF; }
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true iff family has a valid is_Dissolved value.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return base.NullState == NULLITY.NotNull ; }
			}
			#endregion
			*/
		}
	}
}
