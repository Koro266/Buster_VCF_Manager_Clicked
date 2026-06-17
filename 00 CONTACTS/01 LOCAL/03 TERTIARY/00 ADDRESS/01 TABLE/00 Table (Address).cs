//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_TABLE	= CONTACTS.GLOBAL.DATABASE.TABLE.BaseTable;
//___________________________________________________________________________________________________________________________________________________
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using SELECT		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select;
using INSERT		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Insert.Address;
using UPDATE		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Update.Address;
using MAX_PK		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Count.MaxPk;
using UNIQUE		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select.Unique;

using NATIONS			= CONTACTS.LOCAL.TERTIARY.NATION.Table;
using NATION_ROW		= CONTACTS.LOCAL.TERTIARY.NATION.Row;
using SELECT_COUNTRY	= CONTACTS.LOCAL.TERTIARY.NATION.Database.Select;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Table : BASE_TABLE
	{
		#region DECLARATIONS
		private static NATIONS all_Nations = new NATIONS();
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public Table() : base( new SELECT.AllAddresses().Execute )
		{
		}
		#endregion


		#region SPECIFIC NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the default Address.
		/// </summary>
		public ADDRESS_ROW DefaultAddress
		{
			get
			{
				base.CurrentRow = new SELECT.DefaultAddress().Execute;
				return ( ADDRESS_ROW )CurrentRow;
			}
		}
		#endregion


		#region GENERIC NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the current Address.
		/// </summary>
		public ADDRESS_ROW CurrentAddress
		{
			get { return ( ADDRESS_ROW )base.CurrentRow; }
			set { base.CurrentRow = value; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Address row addressed by CurrentKey.
		/// </summary>
		public ADDRESS_ROW CurrentKeyAddress
		{
			get
			{
				ADDRESS_ROW row = ( ADDRESS_ROW )base.CurrentKeyRow;
				return ( row == null ) ? this.DefaultAddress : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Address row addressed by CurrentIndex.
		/// </summary>
		public ADDRESS_ROW CurrentIndexAddress
		{
			get
			{
				ADDRESS_ROW row = ( ADDRESS_ROW )base.CurrentIndexRow;
				return ( row == null ) ? this.DefaultAddress : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Address row at index.
		/// </summary>
		public ADDRESS_ROW AddressByIndex( int index )
		{
			CurrentIndex = index;
			return CurrentAddress;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Address row by key.
		/// </summary>
		public ADDRESS_ROW AddressByKey( int key )
		{
			base.CurrentKey = key;
			return CurrentAddress;
		}
		#endregion


		#region INCREMENTAL NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns first Address row (index = 0).
		/// </summary>
		public ADDRESS_ROW FirstAddress
		{
			get { return ( ADDRESS_ROW )base.FirstRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Decrements CurrentIndex - 1 and retrieves ADDRESS[index].
		/// </summary>
		public ADDRESS_ROW PreviousAddress
		{
			get { return ( ADDRESS_ROW )base.PreviousRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Increments CurrentIndex + 1 and retrieves ADDRESS[index].
		/// </summary>
		public ADDRESS_ROW NextAddress
		{
			get { return ( ADDRESS_ROW )base.NextRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns last Address row (index = max_index).
		/// </summary>
		public ADDRESS_ROW LastAddress
		{
			get { return ( ADDRESS_ROW )base.LastRow; }
		}
		#endregion


		#region SQL
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// INSERTs address_row. If INSERT successful, adds row to AllAddresses,
		/// sets CurrentIndex to that row, and returns true;
		/// otherwise does nothing, returns false.
		/// </summary>
		public bool InsertAddress( ADDRESS_ROW address_row )
		{
			//Insert address into DB...
			int insert_result = new INSERT( address_row ).Execute;
			if ( insert_result > 1 )
			{
				//...get the new max PK...
				int key = new MAX_PK().Execute;

				//...retrieve the row that goes with the new max PK...
				ADDRESS_ROW inserted_row = new SELECT.ByPkAddress( key ).Execute;

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
		public bool UpdateAddress( ADDRESS_ROW group_row )
		{
			return new UPDATE( group_row ).Execute;
		}
		#endregion


		#region UNIQUE-VALUE LISTS
		//_______________________________________________________________________________________________________________________________________
		public string[] StreetNames
		{
			get { return new UNIQUE.StreetNames().Execute.ToArray(); }
		}
		//_______________________________________________________________________________________________________________________________________
		public string[] StreetTypes
		{
			get { return new UNIQUE.StreetTypes().Execute.ToArray(); }
		}
		//_______________________________________________________________________________________________________________________________________
		public string[] SuburbNames
		{
			get { return new UNIQUE.Suburbs().Execute.ToArray(); }
		}
		//_______________________________________________________________________________________________________________________________________
		public string[] CityNames
		{
			get { return new UNIQUE.Cities().Execute.ToArray(); }
		}
		//_______________________________________________________________________________________________________________________________________
		public string[] Metropolitans
		{
			get { return new UNIQUE.Metropolitans().Execute.ToArray(); }
		}
		//_______________________________________________________________________________________________________________________________________
		public string[] ProvinceNames
		{
			get { return new UNIQUE.ProvinceNames().Execute.ToArray(); }
		}
		//_______________________________________________________________________________________________________________________________________
		public string[] ProvinceCodes
		{
			get { return new UNIQUE.ProvinceCodes().Execute.ToArray(); }
		}
		//_______________________________________________________________________________________________________________________________________
		public string[] PostalCodes
		{
			get { return new UNIQUE.PostalCodes().Execute.ToArray(); }
		}
		#endregion
	}
}
