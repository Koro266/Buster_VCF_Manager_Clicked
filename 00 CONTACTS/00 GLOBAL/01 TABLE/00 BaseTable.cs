//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.TABLE
{
	//_______________________________________________________________________________________________________________________________________________
	public class BaseTable
	{
		#region DECLARATIONS
		private Dictionary<int, BASE_ROW> all_Rows;

		private BASE_ROW current_Row	= null;
		private int current_Index		= -1;
		private int current_Key			= -1;
		private int max_Index			= -1;
		#endregion


		#region CONSTRUCTION
		//_______________________________________________________________________________________________________________________________________
		public BaseTable( Dictionary<int, BASE_ROW> rows )
		{
			AllRows = rows;
			MaxIndex = RowCount - 1;
			CurrentIndex = MinIndex;
		}
		#endregion


		#region MANAGED NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns current BASE_ROW, i.e., the row pointed to by current index. 
		/// </summary>
		public BASE_ROW CurrentRow
		{
			get { return AllRows[current_Key]; }
			set 
			{
				current_Row = value;
				current_Key = current_Row.RowKey;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns current key value. 
		/// </summary>
		virtual public int CurrentKey
		{
			get { return current_Key; }
			protected set
			{
				current_Key = value;
				current_Index = IndexByKey( current_Key );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns current index value. 
		/// </summary>
		virtual public int CurrentIndex
		{
			get { return current_Index; }
			protected set
			{
				current_Index = value;
				current_Key = KeyByIndex( current_Index );
			}
		}
		#endregion


		#region DICTIONARY
		//___________________________________________________________________________________________________________________________________________
		virtual public Dictionary<int, BASE_ROW> AllRows
		{
			get { return all_Rows; }
			set { all_Rows = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		virtual public BASE_ROW[] AsBaseRows
		{
			get
			{
				BASE_ROW[] base_rows = new BASE_ROW[all_Rows.Count];
				all_Rows.Values.CopyTo( base_rows, 0 );
				return base_rows;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		virtual public int RowCount
		{
			get { return AllRows.Count; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns index value used for the first (smallest, lower-most) index (0). 
		/// </summary>
		private int MinIndex
		{
			get { return 0; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns index value used for the last (Largest, upper-most) index (current maximum value). 
		/// </summary>
		private int MaxIndex
		{
			get { return max_Index; }
			set { max_Index = value; }
		}
		#endregion


		#region DERIVED 'INDEXING'
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the row addressed by CurrentKey.
		/// </summary>
		public BASE_ROW CurrentKeyRow
		{
			get
			{
				try
				{
					return all_Rows[current_Key];
				}
				catch ( KeyNotFoundException ex )
				{
					return null;
				}
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the row addressed by CurrentIndex.
		/// </summary>
		public BASE_ROW CurrentIndexRow
		{
			get
			{
				try
				{
					return all_Rows.ElementAt( current_Index ).Value;
				}
				catch ( IndexOutOfRangeException ex )
				{
					return null;
				}
			}
		}
		#endregion


		#region INSERT/UPDATE ROW ELEMENTS
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Add a BaseRow to the list of rows.
		/// </summary>
		virtual public void AppendRow( int key, BASE_ROW value )
		{
			AllRows.Add( key, value );
			CurrentKey = key;
			MaxIndex = RowCount - 1;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Replaces the value at [pk_row] with value 'base_row'.
		/// </summary>
		virtual public void UpdateRow( int key, BASE_ROW value )
		{
			AllRows[key] = value;
		}
		#endregion


		#region KEY/INDEX ALIGNMENT
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the index into all_Rows with primary key == key.
		/// </summary>
		public int IndexByKey( int key )
		{
			List<KeyValuePair<int, BASE_ROW>> list = AllRows.ToList();
			return list.FindIndex( kvp => kvp.Key == key );
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Given an index into BaseRow dictionary, returns the key to that row.
		/// </summary>
		public int KeyByIndex( int index )
		{
			return AllRows.ElementAt( index ).Key;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Given a key into BaseRow dictionary, returns the index to that row.
		/// </summary>
		public BASE_ROW RowByKey( int key )
		{
			try
			{
				CurrentKey = key;
				return AllRows[CurrentKey];
			}
			catch ( KeyNotFoundException )
			{
				return FirstRow;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Retrieves row at given index.
		/// </summary>
		public BASE_ROW RowByIndex( int index )
		{
			try
			{
				CurrentIndex = index;
				return AllRows.ElementAt( CurrentIndex ).Value;
			}
			catch ( Exception e)
			{
				return FirstRow;
			}
		}
		#endregion
		
		
		#region APPLY CARDINAL INDEX
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Resets index to 0 and retrieves ROW[index].
		/// </summary>
		virtual public BASE_ROW FirstRow
		{
			get { return RowByIndex( FirstIndex ); }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Increments index + 1 and retrieves BASE_ROW[index].
		/// </summary>
		virtual public BASE_ROW NextRow
		{
			get { return RowByIndex( NextIndex ); }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Decrements index - 1 and retrieves BASE_ROW[index].
		/// </summary>
		virtual public BASE_ROW PreviousRow
		{
			get { return RowByIndex( PreviousIndex ); }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Resets index to current maximum and retrieves BASE_ROW[index].
		/// </summary>
		virtual public BASE_ROW LastRow
		{
			get { return RowByIndex( LastIndex ); }
		}
		#endregion


		#region DERIVE CARDINAL INDEX
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Resets index value to the first (smallest, lower-most) index (0) and returns that value. 
		/// </summary>
		private int FirstIndex
		{
			get
			{
				CurrentIndex = MinIndex;
				return CurrentIndex;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Resets index value to the last (current maximum) index and returns that value. 
		/// </summary>
		private int LastIndex
		{
			get
			{
				CurrentIndex = MaxIndex;
				return CurrentIndex;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Decrements index value by 1 and returns that value (stops at minimum index).  
		/// </summary>
		private int PreviousIndex
		{
			get
			{
				int index = CurrentIndex - 1;
				index = index < MinIndex ? MinIndex : index;

				CurrentIndex = index;
				return CurrentIndex;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Increments index value by 1 and returns that value (stops at current maximum index).  
		/// </summary>
		private int NextIndex
		{
			get
			{
				int index = CurrentIndex + 1;
				index = index > MaxIndex ? MaxIndex : index;

				CurrentIndex = index;
				return CurrentIndex;
			}
		}
		#endregion
	}
}
