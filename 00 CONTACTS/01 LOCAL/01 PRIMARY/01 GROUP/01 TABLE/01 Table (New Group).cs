//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using NULL_TEXT	= CONTACTS.GLOBAL.DATABASE.COLUMN.TypeNullPair<string>;
//LOCAL
using GROUP_ROW	= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using FIELD		= CONTACTS.LOCAL.PRIMARY.GROUP.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class Table
	{
		//___________________________________________________________________________________________________________________________________________
		public GROUP_ROW NewGroup
		{
			get
			{
				NULL_TEXT null_text = new NULL_TEXT();
				GROUP_ROW new_group = new GROUP_ROW();

				new_group.Append( new FIELD.PK_Group		( -1 ) );
				new_group.Append( new FIELD.ST_GroupName	( null_text ) );
				new_group.Append( new FIELD.ST_GroupType	( null_text ) );
				new_group.Append( new FIELD.ST_Notes		( null_text ) );
				new_group.Append( new FIELD.DT_CurrencyDate	( DateTime.Now ) );

				return new_group;
			}
		}
	}
}
