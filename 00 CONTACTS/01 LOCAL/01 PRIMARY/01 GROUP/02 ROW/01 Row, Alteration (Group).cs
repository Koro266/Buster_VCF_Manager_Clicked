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
		//___________________________________________________________________________________________________________________________________________
		public bool NewSelected
		{
			set { Replace( ORDINAL.Selected, new FIELD.IS_Selected( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewDefaultGroup
		{
			set { Replace( ORDINAL.DefaultRow, new FIELD.IS_DefaultRow( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewExport
		{
			set { Replace( ORDINAL.Export, new FIELD.IS_Export( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewBlocked
		{
			set { Replace( ORDINAL.Blocked, new FIELD.IS_Blocked( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewInactive
		{
			set { Replace( ORDINAL.Inactive, new FIELD.IS_Inactive( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewStTheresa
		{
			set { Replace( ORDINAL.StTheresa, new FIELD.IS_StTheresa( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewTrade
		{
			set { Replace( ORDINAL.Tradesman, new FIELD.IS_Tradesman( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewSupplier
		{
			set { Replace( ORDINAL.Supplier, new FIELD.IS_Supplier( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewWriter
		{
			set { Replace( ORDINAL.Writer, new FIELD.IS_Writer( value ) ); }
		}
	}
}
