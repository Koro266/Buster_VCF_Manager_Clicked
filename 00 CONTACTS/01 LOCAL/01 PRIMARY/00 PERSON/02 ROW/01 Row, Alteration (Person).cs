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
//TODO Need 'New' responders for these fields
/*
 * 
		public FIELD.LI_EHS_Order EHS_Order				{ get { return ( FIELD.LI_EHS_Order )		base.GetField( CONST.OrdinalByName.EHS_Order ); } }
		public FIELD.IS_Selected Selected				{ get { return ( FIELD.IS_Selected )		base.GetField( CONST.OrdinalByName.Selected ); } }
		public FIELD.IS_Enlightened Enlightened			{ get { return ( FIELD.IS_Enlightened )		base.GetField( CONST.OrdinalByName.Enlightened ); } }
		public FIELD.IS_HolySomething HolySomething		{ get { return ( FIELD.IS_HolySomething )	base.GetField( CONST.OrdinalByName.HolySomething ); } }
		public FIELD.IS_NewLeftPerson NewLeftPerson		{ get { return ( FIELD.IS_NewLeftPerson )	base.GetField( CONST.OrdinalByName.NewLeftPerson ); } }
		public FIELD.IS_NoRightPerson NoRightPerson		{ get { return ( FIELD.IS_NoRightPerson )	base.GetField( CONST.OrdinalByName.NoRightPerson ); } }
		public FIELD.IS_DefaultRow DefaultRow			{ get { return ( FIELD.IS_DefaultRow )		base.GetField( CONST.OrdinalByName.DefaultRow ); } }
		public FIELD.IS_Export Export					{ get { return ( FIELD.IS_Export )			base.GetField( CONST.OrdinalByName.Export ); } }
		public FIELD.IS_TimeTalent TimeTalent			{ get { return ( FIELD.IS_TimeTalent )		base.GetField( CONST.OrdinalByName.TimeTalent ); } }
		public FIELD.IS_Minister Minister				{ get { return ( FIELD.IS_Minister )		base.GetField( CONST.OrdinalByName.Minister ); } }
		public FIELD.IS_Sacristan Sacristan				{ get { return ( FIELD.IS_Sacristan )		base.GetField( CONST.OrdinalByName.Sacristan ); } }
		public FIELD.IS_Vigil Vigil						{ get { return ( FIELD.IS_Vigil )			base.GetField( CONST.OrdinalByName.Vigil ); } }
		public FIELD.IS_Mass Mass						{ get { return ( FIELD.IS_Mass )			base.GetField( CONST.OrdinalByName.Mass ); } }

 */