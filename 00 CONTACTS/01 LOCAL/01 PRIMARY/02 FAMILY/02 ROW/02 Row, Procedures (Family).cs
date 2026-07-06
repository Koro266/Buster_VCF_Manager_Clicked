//___________________________________________________________________________________________________________________________________________________
using SBLDR			= System.Text.StringBuilder;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL 
using FIELD			= CONTACTS.LOCAL.PRIMARY.FAMILY.Column;
using ORDINAL		= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants.OrdinalByName;
using FAMILY_TYPE	= CONTACTS.LOCAL.PRIMARY.FAMILY.Constants.FamilyType;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		#region CONSTANTS
		private const string family_name_Pattern_L_ne_R		= "#0-#1";

		private const string sortable_name_Pattern_L_eq_R	= "#0, #1 & #2";
		private const string sortable_name_Pattern_L_ne_R	= "#0-#1, #2 & #3";
		private const string sortable_name_Pattern_L_no_R	= "#0, #1";

		private const string joint_name_Pattern_L_eq_R		= "#0, #1 & #2";
		private const string joint_name_Pattern_L_ne_R		= "#0, #1 & #2, #3";
		private const string joint_name_Pattern_L_no_R		= "#0, #1";

		private const string natural_name_Pattern_L_eq_R	= "#0 & #1 #2";
		private const string natural_name_Pattern_L_ne_R	= "#0 #1 & #2 #3";
		private const string natural_name_Pattern_L_no_R	= "#0 #1";

		private const string postal_name_Pattern_L_eq_R		= "#0 & #1 #2";
		private const string postal_name_Pattern_L_ne_R		= "#0 & #1 #2-#3";
		private const string postal_name_Pattern_L_no_R		= "#0 #1";
		#endregion


		#region DERIVED FIELDS
		//___________________________________________________________________________________________________________________________________________
		private void DeriveFamilyName()
		{
			switch ( this.FamilyType.TypeAsEnum )
			{
				case FAMILY_TYPE.L_EQ_R:
					Replace( ORDINAL.FamilyName, new FIELD.ST_FamilyName( FamilyName_Left_EQ_Right ) );
					break;
				case FAMILY_TYPE.L_NE_R:
					Replace( ORDINAL.FamilyName, new FIELD.ST_FamilyName( FamilyName_Left_NE_Right ) );
					break;
				case FAMILY_TYPE.NO_R:
					Replace( ORDINAL.FamilyName, new FIELD.ST_FamilyName( FamilyName_Left_NO_Right ) );
					break;
				case FAMILY_TYPE.NO_TYPE:
					Replace( ORDINAL.FamilyName, new FIELD.ST_FamilyName( FamilyName_NO_Type ) );
					break;
				default:
					break;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public void DeriveSortableName()
		{
			switch ( this.FamilyType.TypeAsEnum )
			{
				case FAMILY_TYPE.L_EQ_R:
					Replace( ORDINAL.SortableName, new FIELD.ST_SortableName( SortableName_Left_EQ_Right ) );
					break;
				case FAMILY_TYPE.L_NE_R:
					Replace( ORDINAL.SortableName, new FIELD.ST_SortableName( SortableName_Left_NE_Right ) );
					break;
				case FAMILY_TYPE.NO_R:
					Replace( ORDINAL.SortableName, new FIELD.ST_SortableName( SortableName_Left_NO_Right ) );
					break;
				case FAMILY_TYPE.NO_TYPE:
					Replace( ORDINAL.SortableName, new FIELD.ST_SortableName( SortableName_NO_Type ) );
					break;
				default:
					break;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public void DeriveJointName()
		{
			switch ( this.FamilyType.TypeAsEnum )
			{
				case FAMILY_TYPE.L_EQ_R:
					Replace( ORDINAL.JointName, new FIELD.ST_JointName( JointName_Left_EQ_Right ) );
					break;
				case FAMILY_TYPE.L_NE_R:
					Replace( ORDINAL.JointName, new FIELD.ST_JointName( JointName_Left_NE_Right ) );
					break;
				case FAMILY_TYPE.NO_R:
					Replace( ORDINAL.JointName, new FIELD.ST_JointName( JointName_Left_NO_Right ) );
					break;
				case FAMILY_TYPE.NO_TYPE:
					Replace( ORDINAL.JointName, new FIELD.ST_JointName( JointName_NO_Type ) );
					break;
				default:
					break;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public void DeriveNaturalName()
		{
			switch ( this.FamilyType.TypeAsEnum )
			{
				case FAMILY_TYPE.L_EQ_R:
					Replace( ORDINAL.NaturalName, new FIELD.ST_NaturalName( NaturalName_Left_EQ_Right ) );
					break;
				case FAMILY_TYPE.L_NE_R:
					Replace( ORDINAL.NaturalName, new FIELD.ST_NaturalName( NaturalName_Left_NE_Right ) );
					break;
				case FAMILY_TYPE.NO_R:
					Replace( ORDINAL.NaturalName, new FIELD.ST_NaturalName( NaturalName_Left_NO_Right ) );
					break;
				case FAMILY_TYPE.NO_TYPE:
					Replace( ORDINAL.NaturalName, new FIELD.ST_NaturalName( NaturalName_NO_Type ) );
					break;
				default:
					break;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public void DerivePostalName()
		{
			switch ( this.FamilyType.TypeAsEnum )
			{
				case FAMILY_TYPE.L_EQ_R:
					Replace( ORDINAL.PostalName, new FIELD.ST_PostalName( PostalName_Left_EQ_Right ) );
					break;
				case FAMILY_TYPE.L_NE_R:
					Replace( ORDINAL.PostalName, new FIELD.ST_PostalName( PostalName_Left_NE_Right ) );
					break;
				case FAMILY_TYPE.NO_R:
					Replace( ORDINAL.PostalName, new FIELD.ST_PostalName( PostalName_Left_NO_Right ) );
					break;
				case FAMILY_TYPE.NO_TYPE:
					Replace( ORDINAL.PostalName, new FIELD.ST_PostalName( PostalName_NO_Type ) );
					break;
				default:
					break;
			}
		}
		#endregion


		#region FAMILY NAME
		//___________________________________________________________________________________________________________________________________________
		private string FamilyName_Left_EQ_Right
		{
			get { return this.LeftUpperSurname.AsIs; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string FamilyName_Left_NE_Right
		{
			get
			{
				SBLDR s = new SBLDR( family_name_Pattern_L_ne_R );
				s.Replace( PRESET.S0, this.LeftUpperSurname.AsIs );
				s.Replace( PRESET.S1, this.RightUpperSurname.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string FamilyName_Left_NO_Right
		{
			get { return this.LeftUpperSurname.AsIs; }
		}
		//___________________________________________________________________________________________________________________________________________
		private string FamilyName_NO_Type
		{
			get { return PRESET.TwoDashes; }
		}
		#endregion


		#region SORTABLE NAME
		//___________________________________________________________________________________________________________________________________________
		private string SortableName_Left_EQ_Right
		{
			get
			{
				SBLDR s = new SBLDR( sortable_name_Pattern_L_eq_R );
				s.Replace( PRESET.S0, this.LeftUpperSurname.AsIs );
				s.Replace( PRESET.S1, this.LeftGivenName.AsIs );
				s.Replace( PRESET.S2, this.RightGivenName.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string SortableName_Left_NE_Right
		{
			get
			{
				SBLDR s = new SBLDR( sortable_name_Pattern_L_ne_R );
				s.Replace( PRESET.S0, this.LeftUpperSurname.AsIs );
				s.Replace( PRESET.S1, this.RightUpperSurname.AsIs );
				s.Replace( PRESET.S2, this.LeftGivenName.AsIs );
				s.Replace( PRESET.S3, this.RightGivenName.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string SortableName_Left_NO_Right
		{
			get
			{
				SBLDR s = new SBLDR( sortable_name_Pattern_L_no_R );
				s.Replace( PRESET.S0, this.LeftUpperSurname.AsIs );
				s.Replace( PRESET.S1, this.LeftGivenName.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string SortableName_NO_Type
		{
			get { return PRESET.TwoDashes; }
		}
		#endregion


		#region JOINT NAME
		//___________________________________________________________________________________________________________________________________________
		private string JointName_Left_EQ_Right
		{
			get
			{
				SBLDR s = new SBLDR( joint_name_Pattern_L_eq_R );
				s.Replace( PRESET.S0, this.LeftProperSurname.AsIs );
				s.Replace( PRESET.S1, this.LeftGivenName.AsIs );
				s.Replace( PRESET.S2, this.RightGivenName.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string JointName_Left_NE_Right
		{
			get
			{
				SBLDR s = new SBLDR( joint_name_Pattern_L_ne_R );
				s.Replace( PRESET.S0, this.LeftProperSurname.AsIs );
				s.Replace( PRESET.S1, this.LeftGivenName.AsIs );
				s.Replace( PRESET.S2, this.RightProperSurname.AsIs );
				s.Replace( PRESET.S3, this.RightGivenName.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string JointName_Left_NO_Right
		{
			get
			{
				SBLDR s = new SBLDR( joint_name_Pattern_L_no_R );
				s.Replace( PRESET.S0, this.LeftProperSurname.AsIs );
				s.Replace( PRESET.S1, this.LeftGivenName.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string JointName_NO_Type
		{
			get { return PRESET.TwoDashes; }
		}
		#endregion


		#region NATURAL NAME
		//___________________________________________________________________________________________________________________________________________
		private string NaturalName_Left_EQ_Right
		{
			get
			{
				SBLDR s = new SBLDR( natural_name_Pattern_L_eq_R );
				s.Replace( PRESET.S0, this.LeftGivenName.AsIs );
				s.Replace( PRESET.S1, this.RightGivenName.AsIs );
				s.Replace( PRESET.S2, this.LeftProperSurname.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string NaturalName_Left_NE_Right
		{
			get
			{
				SBLDR s = new SBLDR( natural_name_Pattern_L_ne_R );
				s.Replace( PRESET.S0, this.LeftGivenName.AsIs );
				s.Replace( PRESET.S1, this.LeftProperSurname.AsIs );
				s.Replace( PRESET.S2, this.RightGivenName.AsIs );
				s.Replace( PRESET.S3, this.RightProperSurname.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string NaturalName_Left_NO_Right
		{
			get
			{
				SBLDR s = new SBLDR( natural_name_Pattern_L_no_R );
				s.Replace( PRESET.S0, this.LeftGivenName.AsIs );
				s.Replace( PRESET.S1, this.LeftProperSurname.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string NaturalName_NO_Type
		{
			get { return PRESET.TwoDashes; }
		}
		#endregion


		#region POSTAL NAME
		//___________________________________________________________________________________________________________________________________________
		private string PostalName_Left_EQ_Right
		{
			get
			{
				SBLDR s = new SBLDR( postal_name_Pattern_L_eq_R );
				s.Replace( PRESET.S0, this.LeftGivenName.AsUpperInitial );
				s.Replace( PRESET.S1, this.RightGivenName.AsUpperInitial );
				s.Replace( PRESET.S2, this.LeftProperSurname.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string PostalName_Left_NE_Right
		{
			get
			{
				SBLDR s = new SBLDR( postal_name_Pattern_L_ne_R );
				s.Replace( PRESET.S0, this.LeftGivenName.AsUpperInitial );
				s.Replace( PRESET.S1, this.RightGivenName.AsUpperInitial );
				s.Replace( PRESET.S2, this.LeftProperSurname.AsIs );
				s.Replace( PRESET.S3, this.RightProperSurname.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string PostalName_Left_NO_Right
		{
			get
			{
				SBLDR s = new SBLDR( postal_name_Pattern_L_no_R );
				s.Replace( PRESET.S0, this.LeftGivenName.AsUpperInitial );
				s.Replace( PRESET.S1, this.LeftProperSurname.AsIs );
				return s.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string PostalName_NO_Type
		{
			get { return PRESET.TwoDashes; }
		}
		#endregion
	}
}
