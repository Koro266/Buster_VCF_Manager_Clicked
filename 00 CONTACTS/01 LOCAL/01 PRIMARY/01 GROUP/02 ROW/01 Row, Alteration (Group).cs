//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL 
using ORDINAL	= CONTACTS.LOCAL.PRIMARY.GROUP.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.PRIMARY.GROUP.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		//___________________________________________________________________________________________________________________________________________
		public string NewGroupName
		{
			set { Replace( ORDINAL.GroupName, new FIELD.ST_GroupName( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewGroupType
		{
			set { Replace( ORDINAL.GroupType, new FIELD.ST_GroupType( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewNotes
		{
			set { Replace( ORDINAL.Notes, new FIELD.ST_Notes( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public DateTime NewCurrencyDate
		{
			set { Replace( ORDINAL.CurrencyDate, new FIELD.DT_CurrencyDate( value ) ); }
		}
	}
}
