//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_TABLE	= CONTACTS.GLOBAL.DATABASE.TABLE.BaseTable;
//LOCAL
using GROUP_ROW		= CONTACTS.LOCAL.PRIMARY.GROUP.Row;
using SELECT		= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Select;
using INSERT		= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Insert.Group;
using UPDATE		= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Update.Group;
using MAX_PK		= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Count.MaxPk;
using UNIQUE		= CONTACTS.LOCAL.PRIMARY.GROUP.Database.Select.UniqueGroupTypes;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.GROUP
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Table : BASE_TABLE
	{
		#region DECLARATIONS
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public Table() : base( new SELECT.AllGroups().Execute )
		{
		}
		#endregion


		#region SPECIFIC NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the default Group.
		/// </summary>
		public GROUP_ROW DefaultGroup
		{
			get 
			{
				base.CurrentRow = new SELECT.DefaultGroup().Execute;
				return ( GROUP_ROW )CurrentRow;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns a list of unique Group types.
		/// </summary>
		public List<string> AllTypes
		{
			get { return new UNIQUE().Execute; }
		}
		#endregion


		#region GENERIC NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the current Group.
		/// </summary>
		public GROUP_ROW CurrentGroup
		{
			get { return ( GROUP_ROW )base.CurrentRow; }
			set { base.CurrentRow = value; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Group row addressed by CurrentKey.
		/// </summary>
		public GROUP_ROW CurrentKeyGroup
		{
			get
			{
				GROUP_ROW row = ( GROUP_ROW )base.CurrentKeyRow;
				return ( row == null ) ? this.DefaultGroup : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Group row addressed by CurrentIndex.
		/// </summary>
		public GROUP_ROW CurrentIndexGroup
		{
			get
			{
				GROUP_ROW row = ( GROUP_ROW )base.CurrentIndexRow;
				return ( row == null ) ? this.DefaultGroup : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Group row at index.
		/// </summary>
		public GROUP_ROW GroupByIndex( int index )
		{
			CurrentIndex = index;
			return CurrentGroup;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Group row by key.
		/// </summary>
		public GROUP_ROW GroupByKey( int key )
		{
			base.CurrentKey = key;
			return CurrentGroup;
		}
		#endregion


		#region INCREMENTAL NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns first Group row (index = 0).
		/// </summary>
		public GROUP_ROW FirstGroup
		{
			get { return ( GROUP_ROW )base.FirstRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Decrements CurrentIndex - 1 and retrieves GROUP[index].
		/// </summary>
		public GROUP_ROW PreviousGroup
		{
			get { return ( GROUP_ROW )base.PreviousRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Increments CurrentIndex + 1 and retrieves GROUP[index].
		/// </summary>
		public GROUP_ROW NextGroup
		{
			get { return ( GROUP_ROW )base.NextRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns last Group row (index = max_index).
		/// </summary>
		public GROUP_ROW LastGroup
		{
			get { return ( GROUP_ROW )base.LastRow; }
		}
		#endregion


		#region SQL
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// INSERTs group_row. If INSERT successful, adds row to AllGroups,
		/// sets CurrentIndex to that row, and returns true;
		/// otherwise does nothing, returns false.
		/// </summary>
		public bool InsertGroup( GROUP_ROW group_row )
		{
			//Insert group into DB...
			int insert_result = new INSERT( group_row ).Execute;
			if ( insert_result > 1 )
			{
				//...get the new max PK...
				int key = new MAX_PK().Execute;

				//...retrieve the row that goes with the new max PK...
				GROUP_ROW inserted_row = new SELECT.ByPkGroup( key ).Execute;

				//...add the new row to the base row collection...
				base.AppendRow( key, inserted_row );

				return true;
			}
			else
			{
				return false;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// UPDATEs group_row.
		/// </summary>
		public bool UpdateGroup( GROUP_ROW group_row )
		{
			return new UPDATE( group_row ).Execute;
		}
		#endregion
	}
}
