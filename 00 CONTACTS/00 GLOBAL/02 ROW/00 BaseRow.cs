//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using INT_32		= CONTACTS.GLOBAL.DATABASE.COLUMN.Integer_32;
using BASE_VAR		= CONTACTS.GLOBAL.DATABASE.COLUMN.BaseColumn;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.ROW
{
	//_______________________________________________________________________________________________________________________________________________
	public class BaseRow
	{
		#region DECLARATIONS
		private int column_Index = PRESET.ZERO;
		private BASE_VAR[] base_Columns;
		#endregion


		#region CONSTRUCTORS
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Constructs a list array with item_count length.
		/// </summary>
		public BaseRow()
		{
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Constructs a list array with item_count length.
		/// </summary>
		public BaseRow( int item_count )
		{
			base_Columns = new BASE_VAR[item_count];
		}
		#endregion


		#region PROCEDURES
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// The primary key of every row is at index = 0.
		/// </summary>
		virtual public int RowKey
		{
			get { return ( ( INT_32 )base_Columns[0] ).Value; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Adds field to base_Columns using the internal column_Index: "base_Columns[column_Index++] = field".
		/// </summary>
		virtual public void Append( BASE_VAR field )
		{
			base_Columns[column_Index++] = field;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Replaces the item in base_Columns at index with field: "base_Columns[index] = field".
		/// </summary>
		virtual public void Replace( int index, BASE_VAR field )
		{
			base_Columns[index] = field;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the field at index: "base_Columns[index]".
		/// </summary>
		virtual public BASE_VAR GetField( int index )
		{
			return base_Columns[index];
		}
		#endregion
	}
}
