//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using NULLITY		= CONTACTS.GLOBAL.Nullity;
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
//LOCAL
using CONST			= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// EXTENSIONS for ST_SortableName.
		/// </summary>
		public partial class ST_SortableName : SHORT_TXT
		{
			#region DECLARATIONS
			#endregion

			/*
			#region METHODS
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns value that is sent to the database.
			/// </summary>
			override public string DatabaseValue
			{
				get { return base.Value; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is displayed on a form.
			/// </summary>
			override public string DisplayValue
			{
				get { return base.Value; }
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get { return base.Value; }
			}

			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true iff SortableName is valid.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return base.NullState == NULLITY.NotNull; }
			}
			#endregion
			*/
		}
	}
}
