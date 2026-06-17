//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW	 = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL 
using ORDINAL	 = CONTACTS.LOCAL.PRIMARY.FAMILY.Constants.OrdinalByName;
using FIELD		 = CONTACTS.LOCAL.PRIMARY.FAMILY.Column;
using PERSON_ROW = CONTACTS.LOCAL.PRIMARY.PERSON.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		#region STRING FIELDS
		//___________________________________________________________________________________________________________________________________________
		public void SetDerivedNames()
		{
				DeriveFamilyName();
				DeriveSortableName();
				DeriveJointName();
				DeriveNaturalName();
				DerivePostalName();
		}
		//___________________________________________________________________________________________________________________________________________
		public PERSON_ROW NewLeftPerson
		{
			set 
			{
				Replace( ORDINAL.FkLeftPerson, new FIELD.FK_LeftPerson( value.PkPerson.Value ) );
				SetDerivedNames();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public PERSON_ROW NewRightPerson
		{
			set 
			{
				Replace( ORDINAL.FkRightPerson, new FIELD.FK_RightPerson( value.PkPerson.Value ) );
				SetDerivedNames();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewFamilyType
		{
			set 
			{
				Replace( ORDINAL.FamilyType, new FIELD.ST_FamilyType( value ) );
				SetDerivedNames();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewNotes
		{
			set { Replace( ORDINAL.Notes, new FIELD.ST_Notes( value ) ); }
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
		//___________________________________________________________________________________________________________________________________________
		public bool NewIsChristmas
		{
			set { Replace( ORDINAL.Christmas, new FIELD.IS_Christmas( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewIsDissolved
		{
			set { Replace( ORDINAL.Dissolved, new FIELD.IS_Dissolved( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewIsCorlettRd
		{
			set { Replace( ORDINAL.CorlettRd, new FIELD.IS_CorlettRd( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewIsStTheresa
		{
			set { Replace( ORDINAL.StTheresa, new FIELD.IS_StTheresa( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewIsDefaultRow
		{
			set { Replace( ORDINAL.DefaultRow, new FIELD.IS_DefaultRow( value ) ); }
		}
		#endregion
	}
}
