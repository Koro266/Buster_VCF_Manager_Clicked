//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using NULLITY		= CONTACTS.GLOBAL.Nullity;
using SHORT_TXT		= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
//LOCAL
using CONST			= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants;
using FAMILY_TYPE	= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants.FamilyType;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// EXTENSIONS for ST_FamilyType.
		/// </summary>
		public partial class ST_FamilyType : SHORT_TXT
		{
			#region DECLARATIONS
			private FAMILY_TYPE family_type = FAMILY_TYPE.NO_TYPE;
			#endregion


//			#region METHODS
			//_______________________________________________________________________________________________________________________________________
			/// <summary>
			/// Converts a string into an enum value.
			/// </summary>
			public FAMILY_TYPE FamilyType
			{
				get
				{
					switch ( base.Value.ToString() )
					{
						case CONST.L_EQ_R:
							return FAMILY_TYPE.L_EQ_R;

						case CONST.L_NE_R:
							return FAMILY_TYPE.L_NE_R;

						case CONST.NO_R:
							return FAMILY_TYPE.NO_R;

						default:
							return FAMILY_TYPE.NO_TYPE;
					}
				}
			}
			/*
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
			/// Returns true because a FamilyType is required.
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
