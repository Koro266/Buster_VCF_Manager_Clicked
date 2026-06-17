//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL 
using ORDINAL	= CONTACTS.LOCAL.PRIMARY.PERSON.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.PRIMARY.PERSON.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//__________________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		#region NEW-VALUE FIELDS
		//___________________________________________________________________________________________________________________________________________
		public void ElaborateDerivedNames()
		{
			//Recompute & replace the derived values (for 'data slab' data entry).
			//This means: when data is entered via a 'data slab' these derived fields are not auto-computed.
			Replace( ORDINAL.UpperSurname, new FIELD.ST_UpperSurname( this.ProperSurname.AsUpper ) );
			Replace( ORDINAL.SortableName, new FIELD.ST_SortableName( DerivedSortableName ) );
			Replace( ORDINAL.NaturalName, new FIELD.ST_NaturalName( DerivedNaturalName ) );
			Replace( ORDINAL.Initials, new FIELD.ST_Initials( DerivedInitials ) );
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// When ProperSurname changes, all the derived name elements must also change.
		///		ST_UpperSurname coerces the value to upper case.
		///		ST_SortableName is re-computed and replaced.
		///		ST_NaturalName is re-computed and replaced.
		///		ST_Initials is re-computed and replaced.
		/// </summary>
		public string NewProperSurname
		{
			set
			{
				//Inject the changed source value into the value array...
				Replace( ORDINAL.ProperSurname, new FIELD.ST_ProperSurname( value ) );

				//...then recompute & inject the derived values.
				Replace( ORDINAL.UpperSurname, new FIELD.ST_UpperSurname( this.ProperSurname.AsUpper ) );
				Replace( ORDINAL.SortableName, new FIELD.ST_SortableName( DerivedSortableName ) );
				Replace( ORDINAL.NaturalName, new FIELD.ST_NaturalName( DerivedNaturalName ) );
				Replace( ORDINAL.Initials, new FIELD.ST_Initials( DerivedInitials ) );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// When GivenName changes, some of the derived name elements also change.
		///		ST_UpperSurname does NOT change.
		///		ST_SortableName is re-computed and replaced.
		///		ST_NaturalName is re-computed and replaced.
		///		ST_Initials is re-computed and replaced.		
		/// </summary>
		public string NewGivenName
		{
			set
			{
				Replace( ORDINAL.GivenName, new FIELD.ST_GivenName( value ) );

				Replace( ORDINAL.SortableName, new FIELD.ST_SortableName( DerivedSortableName ) );
				Replace( ORDINAL.NaturalName, new FIELD.ST_NaturalName( DerivedNaturalName ) );
				Replace( ORDINAL.Initials, new FIELD.ST_Initials( DerivedInitials ) );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// When MiddleNames changes, some of the derived name elements also change.
		///		ST_UpperSurname does NOT change.
		///		ST_SortableName is re-computed and replaced.
		///		ST_NaturalName is re-computed and replaced.
		///		ST_Initials is re-computed and replaced.
		/// </summary>
		public string NewMiddleNames
		{
			set
			{
				FIELD.ST_MiddleNames mn = new FIELD.ST_MiddleNames( value );
				Replace( ORDINAL.MiddleNames, new FIELD.ST_MiddleNames( value ) );

				Replace( ORDINAL.SortableName, new FIELD.ST_SortableName( DerivedSortableName ) );
				Replace( ORDINAL.NaturalName, new FIELD.ST_NaturalName( DerivedNaturalName ) );
				Replace( ORDINAL.Initials, new FIELD.ST_Initials( DerivedInitials ) );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewNickName
		{
			set { Replace( ORDINAL.NickName, new FIELD.ST_NickName( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewBirthName
		{
			set { Replace( ORDINAL.BirthName, new FIELD.ST_BirthName( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewPrefix
		{
			set { Replace( ORDINAL.Prefix, new FIELD.ST_Prefix( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewSuffix
		{
			set { Replace( ORDINAL.Suffix, new FIELD.ST_Suffix( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewGender
		{
			set { Replace( ORDINAL.Gender, new FIELD.ST_Gender( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewNotes
		{
			set { Replace( ORDINAL.Notes, new FIELD.ST_Notes( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public DateTime NewBirthDate
		{
			set { Replace( ORDINAL.BirthDate, new FIELD.DT_BirthDate( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public DateTime NewDeathDate
		{
			set { Replace( ORDINAL.DeathDate, new FIELD.DT_DeathDate( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public DateTime NewWeddingDate
		{
			set { Replace( ORDINAL.WeddingDate, new FIELD.DT_WeddingDate( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public DateTime NewCurrencyDate
		{
			set { Replace( ORDINAL.CurrencyDate, new FIELD.DT_CurrencyDate( value ) ); }
		}
		#endregion
	}
}
