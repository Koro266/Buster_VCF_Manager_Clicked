//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using SHORT_TXT	= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using NULL_TEXT = CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
using WORDS		= CONTACTS.GLOBAL.VALUES.CONSTANT.Words;
//LOCAL
using CONST		= CONTACTS.LOCAL.PRIMARY.PERSON.Constants;
using FACTORS	= CONTACTS.LOCAL.PRIMARY.PERSON.Constants.ColumnFactors;
using ORDINAL	= CONTACTS.LOCAL.PRIMARY.PERSON.Constants.OrdinalByName;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Column
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class ST_Gender : SHORT_TXT
		{
			#region DECLARATIONS
			private static FACTORS column_factors = CONST.Factors[ORDINAL.Gender];
			private NULL_TEXT type_null_pair;
			public enum Gender { Male, Female, Unknown };

			private static SHORT_TXT Male = WORDS.Male;
			private static SHORT_TXT Female = WORDS.Female;
			private static SHORT_TXT Unknown = WORDS.Unknown;

			private Gender type_Gender = Gender.Female;
			#endregion


			#region CONSTRUCTORS
			//_______________________________________________________________________________________________________________________________________
			public ST_Gender( string value ) : base( value )
			{
				type_Gender = GetGenderType;
			}
			//_______________________________________________________________________________________________________________________________________
			public ST_Gender( NULL_TEXT tnp ) : base( tnp )
			{
				type_null_pair = tnp;
			}
			#endregion


			#region METHODS
			//_______________________________________________________________________________________________________________________________________
			public FACTORS Factors
			{
				get { return column_factors; }
			}
			//_______________________________________________________________________________________________________________________________________
			public int Ordinal
			{
				get { return Factors.Ordinal; }
			}
			//_______________________________________________________________________________________________________________________________________
			override public string ToString()
			{
				return this.Value;
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Examines user input and determines the value of enum type_Gender.
			/// </summary>
			public Gender GetGenderType
			{
				get
				{
					//-----------------------------------------------
					//'m'
					if ( base.Value == Male.AsLowerInitial )
						return Gender.Male;

					//'M'
					else if ( base.Value == Male.AsUpperInitial )
						return Gender.Male;

					//'male'
					else if ( base.Value == Male.AsLower )
						return Gender.Male;

					//'Male'
					else if ( base.Value == Male.AsProper )
						return Gender.Male;

					//'MALE'
					else if ( base.Value == Male.AsUpper )
						return Gender.Male;

					//-----------------------------------------------
					//'f'
					else if ( base.Value == Female.AsLowerInitial )
						return Gender.Female;

					//'F'
					else if ( base.Value == Female.AsUpperInitial )
						return Gender.Female;

					//'female'
					if ( base.Value == Female.AsLower )
						return Gender.Female;

					//'Female'
					else if ( base.Value == Female.AsProper )
						return Gender.Female;

					//'FEMALE'
					else if ( base.Value == Female.AsUpper )
						return Gender.Female;

					//-----------------------------------------------
					else
						return Gender.Unknown;
				}
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns value that is sent to the database.
			/// </summary>
			override public object DbWriteValue
			{
				get
				{
					switch ( GetGenderType )
					{
						case Gender.Male:
							return Male.AsUpperInitial;

						case Gender.Female:
							return Female.AsUpperInitial;

						case Gender.Unknown:
							return Unknown.AsUpperInitial;

						default:
							return Unknown.AsUpperInitial;
					}
				}
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is displayed in a TextBox.
			/// </summary>
			override public string TextboxValue
			{
				get
				{
					switch ( GetGenderType )
					{
						case Gender.Male:
							return Male.AsProper;

						case Gender.Female:
							return Female.AsProper;

						case Gender.Unknown:
							return Unknown.AsUpper;

						default:
							return Unknown.AsUpper;
					}
				}
			}
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns the value that is used in a VCF file.
			/// </summary>
			override public string VcfValue
			{
				get
				{
					switch ( GetGenderType )
					{
						case Gender.Male:
							return Male.AsUpperInitial;

						case Gender.Female:
							return Female.AsUpperInitial;

						case Gender.Unknown:
							return Unknown.AsUpperInitial;

						default:
							return Unknown.AsUpperInitial;
					}
				}
			}
			//___________________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns true because the Gender field value is required.
			/// </summary>
			override public bool IsVcfValue
			{
				get { return true; }
			}
			//___________________________________________________________________________________________________________________________________
			public bool IsMale { get { return this.type_Gender == Gender.Male; } }
			public bool IsFemale { get { return this.type_Gender == Gender.Female; } }
			public bool IsUnknown { get { return this.type_Gender == Gender.Unknown; } }
			#endregion


			#region DB INTERFACE
			//_______________________________________________________________________________________________________________________________________
			override public OleDbParameter DbParameter
			{
				get
				{
					OleDbParameter parameter = base.DbParameter;
					parameter.ParameterName = Factors.ParameterName;
					parameter.Size = Factors.FieldWidth;
					parameter.Value = this.DbWriteValue;
					return parameter;
				}
			}
			#endregion
		}
	}
}
