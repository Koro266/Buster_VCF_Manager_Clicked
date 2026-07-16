//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_TABLE	= CONTACTS.GLOBAL.DATABASE.TABLE.BaseTable;
//LOCAL
using DEVICE_ROW	= CONTACTS.LOCAL.TERTIARY.DEVICE.Row;
using INSERT		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Insert.Device;
using SELECT		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Select;
using UNIQUE		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Select.Unique;
using UPDATE		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Update.Device;
using MAX_PK		= CONTACTS.LOCAL.TERTIARY.DEVICE.Database.Count.MaxPk;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.DEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Table : BASE_TABLE
	{
		#region DECLARATIONS
		//TODO: Insert "New Device".
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public Table() : base( new SELECT.FullyQualifiedDevices().Execute )
		{
		}
		#endregion


		#region SPECIFIC NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the default Device.
		/// </summary>
		public DEVICE_ROW DefaultDevice
		{
			get
			{
				base.CurrentRow = new SELECT.DefaultDevice().Execute;
				return ( DEVICE_ROW )CurrentRow;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public List<string> AllLocations
		{
			get { return new UNIQUE.DeviceLocations().Execute; }
		}
		//___________________________________________________________________________________________________________________________________________
		public List<string> AllTypes
		{
			get { return new UNIQUE.DeviceTypes().Execute; }
		}
		#endregion


		#region GENERIC NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the current Device.
		/// </summary>
		public DEVICE_ROW CurrentDevice
		{
			get { return ( DEVICE_ROW )base.CurrentRow; }
			set { base.CurrentRow = value; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Device row addressed by CurrentKey.
		/// </summary>
		public DEVICE_ROW CurrentKeyDevice
		{
			get
			{
				DEVICE_ROW row = ( DEVICE_ROW )base.CurrentKeyRow;
				return ( row == null ) ? this.DefaultDevice : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Device row addressed by CurrentIndex.
		/// </summary>
		public DEVICE_ROW CurrentIndexDevice
		{
			get
			{
				DEVICE_ROW row = ( DEVICE_ROW )base.CurrentIndexRow;
				return ( row == null ) ? this.DefaultDevice : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Device row at index.
		/// </summary>
		public DEVICE_ROW DeviceByIndex( int index )
		{
			CurrentIndex = index;
			return CurrentDevice;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Device row by key.
		/// </summary>
		public DEVICE_ROW DeviceByKey( int key )
		{
			base.CurrentKey = key;
			return CurrentDevice;
		}
		#endregion


		#region INCREMENTAL NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns first Device row (index = 0).
		/// </summary>
		public DEVICE_ROW FirstDevice
		{
			get { return ( DEVICE_ROW )base.FirstRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Decrements CurrentIndex - 1 and retrieves DEVICE[index].
		/// </summary>
		public DEVICE_ROW PreviousDevice
		{
			get { return ( DEVICE_ROW )base.PreviousRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Increments CurrentIndex + 1 and retrieves DEVICE[index].
		/// </summary>
		public DEVICE_ROW NextDevice
		{
			get { return ( DEVICE_ROW )base.NextRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns last Device row (index = max_index).
		/// </summary>
		public DEVICE_ROW LastDevice
		{
			get { return ( DEVICE_ROW )base.LastRow; }
		}
		#endregion


		#region SQL
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// INSERTs device_row. If INSERT successful, adds row to AllDevices,
		/// sets CurrentIndex to that row, and returns true;
		/// otherwise does nothing, returns false.
		/// </summary>
		public bool InsertDevice( DEVICE_ROW device_row )
		{
			//Insert group into DB...
			int insert_result = new INSERT( device_row ).Execute;
			if ( insert_result > 1 )
			{
				//...get the new max PK...
				int key = new MAX_PK().Execute;

				//...retrieve the row that goes with the new max PK...
				DEVICE_ROW inserted_row = new SELECT.ByPkDevice( key ).Execute;

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
		public bool UpdateDevice( DEVICE_ROW group_row )
		{
			return new UPDATE( group_row ).Execute;
		}
		#endregion
	}
}
/*

		#region MANAGED NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		public DEVICE_ROW CurrentRow
		{
			get { return current_Row; }
			set { current_Row = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		private int CurrentKey
		{
			get { return current_Key; }
			set 
			{
				current_Key = value;
				current_Row = CurrentKeyDevice;
				current_Key = CurrentRow.PkDevice.Value;
				current_Index = DevicesAsList.FindIndex( kvp => kvp.Key == current_Key );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int CurrentIndex
		{
			get { return current_Index; }
			set 
			{
				current_Index = value;
				current_Row = CurrentIndexDevice;
				current_Key = CurrentRow.PkDevice.Value;
				current_Index = DevicesAsList.FindIndex( kvp => kvp.Key == current_Key );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private List<KeyValuePair<int, DEVICE_ROW>> DevicesAsList
		{
			get { return all_Devices.ToList(); }
		}
		#endregion


		#region COLLECTIONS
		//___________________________________________________________________________________________________________________________________________
		protected Dictionary<int, DEVICE_ROW> AllDevices
		{
			get { return all_Devices; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the default device.
		/// </summary>
		public DEVICE_ROW DefaultDevice
		{
			get { return new SELECT.DefaultDevice().Execute; }
		}
		#endregion


		#region NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Device row at 'device_index'.
		/// </summary>
		public DEVICE_ROW DeviceByIndex( int device_index )
		{
			CurrentIndex = device_index;
			return CurrentRow;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns Devices[device_pk] if pk_device refers to a valid row. Returns Default Device otherwise.
		/// </summary>
		public DEVICE_ROW DeviceByKey( int device_pk )
		{
			CurrentKey = device_pk;
			return CurrentRow;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the device row addressed by CurrentKey.
		/// </summary>
		private DEVICE_ROW CurrentKeyDevice
		{
			get
			{
				try
				{
					CurrentRow = all_Devices[current_Key];
				}
				catch ( KeyNotFoundException ex )
				{
					CurrentRow = DefaultDevice;
				}

				return CurrentRow;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the device row addressed by CurrentIndex.
		/// </summary>
		private DEVICE_ROW CurrentIndexDevice
		{
			get 
			{
				try
				{
					CurrentRow = all_Devices.ElementAt( current_Index ).Value;
				}
				catch ( IndexOutOfRangeException ex )
				{
					CurrentRow = DefaultDevice;
				}

				return CurrentRow;
			}
		}
		#endregion


		#region INCREMENTAL NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Resets index to 0 and retrieves DEVICE[index].
		/// </summary>
		public DEVICE_ROW FirstDevice
		{
			get 
			{
				FirstIndex();
				return CurrentRow;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Resets index to current_value -1 and retrieves DEVICE[index].
		/// </summary>
		public DEVICE_ROW PreviousDevice
		{
			get
			{
				DecrementIndex();
				return CurrentRow;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Resets index to current_value +1 and retrieves DEVICE[index].
		/// </summary>
		public DEVICE_ROW NextDevice
		{
			get
			{
				IncrementIndex();
				return CurrentRow;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Resets index to maximum value (current row count) and retrieves DEVICE[index].
		/// </summary>
		public DEVICE_ROW LastDevice
		{
			get
			{
				LastIndex();
				return CurrentRow;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		private int FirstIndex()
		{
			CurrentIndex = 0;
			return CurrentIndex;
		}
		//_______________________________________________________________________________________________________________________________________
		private int DecrementIndex()
		{
			current_Index--;
			CurrentIndex = current_Index < 0 ? FirstIndex() : CurrentIndex;
			return CurrentIndex;
		}
		//_______________________________________________________________________________________________________________________________________
		private int IncrementIndex()
		{
			current_Index++;
			CurrentIndex = current_Index > max_Index ? max_Index : CurrentIndex;
			return CurrentIndex;
		}
		//_______________________________________________________________________________________________________________________________________
		private int LastIndex()
		{
			CurrentIndex = max_Index;
			return CurrentIndex;
		}
		#endregion


		#region SQL
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// INSERTs device_row. If INSERT successful, adds row to AllDevices, returns true, and CurrentIndex to that row;
		/// otherwise does nothing, returns false.
		/// </summary>
		public bool InsertDevice( DEVICE_ROW device_row )
		{
			//Insert device into DB...
			int insert_result = new INSERT( device_row ).Execute;
			if ( insert_result > 1 )
			{
				//...get the new max PK...
				int max_pk = new MAX_PK().Execute;

				//...get the row that goes with the new max PK...
				DEVICE_ROW inserted_row = new SELECT.ByPkDevice( max_pk ).Execute;

				//...add the new row to the all_Devices collection...
				all_Devices.Add( inserted_row.PkDevice.Value, inserted_row );

				//...reset max_Index...
				max_Index = all_Devices.Count - 1;

				//...reset the current index to point to the new row.
				CurrentKey = device_row.PkDevice.Value;
				return true;
			}
			else
			{
				return false;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// UPDATEs device_row. Returns true UPDATE if succeeds, false otherwise.
		/// </summary>
		public bool UpdateDevice( DEVICE_ROW device_row )
		{
			return new UPDATE( device_row ).Execute;
		}
		#endregion
 
 */