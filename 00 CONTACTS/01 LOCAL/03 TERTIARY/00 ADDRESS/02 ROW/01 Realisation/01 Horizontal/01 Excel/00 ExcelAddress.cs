//___________________________________________________________________________________________________________________________________________________
//LOCAL
using FAMILY_ROW		= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using ADDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
/*
using IDX00_SORTER		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.EXCEL.Index00_Sorter;
using IDX01_PK_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.EXCEL.Index01_PkAddress;
using IDX02_PK_FAMILY	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.EXCEL.Index02_PkFamily;
using IDX03_SORT_NAME	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.EXCEL.Index03_SortableName;
using IDX04_OUT_NAME	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.EXCEL.Index04_OuterName;
using IDX05_OUT_LINE1	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.EXCEL.Index05_OuterLine_01;
using IDX06_OUT_LINE2	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.EXCEL.Index06_OuterLine_02;
using IDX07_OUT_LINE3	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.EXCEL.Index07_OuterLine_03;
using IDX08_OUT_LINE4	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.EXCEL.Index08_OuterLine_04;
*/

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.EXCEL
{
	//___________________________________________________________________________________________________________________________________________
	public class ExcelAddress : BaseAddress
	{
		/*
		private IDX00_SORTER		_Sorter;
		private IDX01_PK_ADDRESS	_PkAddress;
		private IDX02_PK_FAMILY		_PkFamily;
		private IDX03_SORT_NAME		_SortableName;
		private IDX04_OUT_NAME		_OuterName;
		private IDX05_OUT_LINE1		_OuterLine_01;
		private IDX06_OUT_LINE2		_OuterLine_02;
		private IDX07_OUT_LINE3		_OuterLine_03;
		private IDX08_OUT_LINE4		_OuterLine_04;

		*/

		//___________________________________________________________________________________________________________________________________________
		public ExcelAddress( FAMILY_ROW family_row, ADDRESS_ROW address_row) : base( address_row )
		{
			/*
			_Sorter			= new IDX00_SORTER();
			_PkAddress		= new IDX01_PK_ADDRESS();
			_PkFamily		= new IDX02_PK_FAMILY();
			_SortableName	= new IDX03_SORT_NAME();
			_OuterName		= new IDX04_OUT_NAME();
			_OuterLine_01	= new IDX05_OUT_LINE1();
			_OuterLine_02	= new IDX06_OUT_LINE2();
			_OuterLine_03	= new IDX07_OUT_LINE3();
			_OuterLine_04	= new IDX08_OUT_LINE4();
			*/
		}
		//___________________________________________________________________________________________________________________________________________
		public void InsertAddressValues()
		{
			/*
			ExcelLineItem list_view_item =_PkAddress.InsertColumnValue();
			_Sorter			.InsertColumnValue()
			_PkAddress		.InsertColumnValue()
			_PkFamily		.InsertColumnValue()
			_SortableName	.InsertColumnValue()
			_OuterName		.InsertColumnValue()
			_OuterLine_01	.InsertColumnValue()
			_OuterLine_02	.InsertColumnValue()
			_OuterLine_03	.InsertColumnValue()
			_OuterLine_04	.InsertColumnValue()
			*/
		}
	}
}
