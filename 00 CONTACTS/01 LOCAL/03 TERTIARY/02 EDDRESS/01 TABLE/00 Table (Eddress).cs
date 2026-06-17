//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_TABLE	= CONTACTS.GLOBAL.DATABASE.TABLE.BaseTable;
//LOCAL
using EDDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.EDDRESS.Row;
using INSERT		= CONTACTS.LOCAL.TERTIARY.EDDRESS.Database.Insert.Eddress;
using SELECT		= CONTACTS.LOCAL.TERTIARY.EDDRESS.Database.Select;
using UNIQUE		= CONTACTS.LOCAL.TERTIARY.EDDRESS.Database.Select.Unique;
using UPDATE		= CONTACTS.LOCAL.TERTIARY.EDDRESS.Database.Update.Eddress;
using MAX_PK		= CONTACTS.LOCAL.TERTIARY.EDDRESS.Database.Count.MaxPk;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.EDDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Table : BASE_TABLE
	{
		#region DECLARATIONS
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public Table() : base( new SELECT.AllEddresses().Execute )
		{
		}
		#endregion


		#region SPECIFIC NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the default Eddress.
		/// </summary>
		public EDDRESS_ROW DefaultEddress
		{
			get
			{
				base.CurrentRow = new SELECT.DefaultEddress().Execute;
				return ( EDDRESS_ROW )CurrentRow;
			}
		}
		#endregion


		#region GENERIC NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the current Eddress.
		/// </summary>
		public EDDRESS_ROW CurrentEddress
		{
			get { return ( EDDRESS_ROW )base.CurrentRow; }
			set { base.CurrentRow = value; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Eddress row addressed by CurrentKey.
		/// </summary>
		public EDDRESS_ROW CurrentKeyEddress
		{
			get
			{
				EDDRESS_ROW row = ( EDDRESS_ROW )base.CurrentKeyRow;
				return ( row == null ) ? this.DefaultEddress : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Eddress row addressed by CurrentIndex.
		/// </summary>
		public EDDRESS_ROW CurrentIndexEddress
		{
			get
			{
				EDDRESS_ROW row = ( EDDRESS_ROW )base.CurrentIndexRow;
				return ( row == null ) ? this.DefaultEddress : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Eddress row at index.
		/// </summary>
		public EDDRESS_ROW EddressByIndex( int index )
		{
			CurrentIndex = index;
			return CurrentEddress;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Eddress row by key.
		/// </summary>
		public EDDRESS_ROW EddressByKey( int key )
		{
			base.CurrentKey = key;
			return CurrentEddress;
		}
		#endregion


		#region INCREMENTAL NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns first Eddress row (index = 0).
		/// </summary>
		public EDDRESS_ROW FirstEddress
		{
			get { return ( EDDRESS_ROW )base.FirstRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Decrements CurrentIndex - 1 and retrieves EDDRESS[index].
		/// </summary>
		public EDDRESS_ROW PreviousEddress
		{
			get { return ( EDDRESS_ROW )base.PreviousRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Increments CurrentIndex + 1 and retrieves EDDRESS[index].
		/// </summary>
		public EDDRESS_ROW NextEddress
		{
			get { return ( EDDRESS_ROW )base.NextRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns last Eddress row (index = max_index).
		/// </summary>
		public EDDRESS_ROW LastEddress
		{
			get { return ( EDDRESS_ROW )base.LastRow; }
		}
		#endregion


		#region SQL
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// INSERTs EDDRESS_ROW. If INSERT successful, adds row to AllEddresss,
		/// sets CurrentIndex to that row, and returns true;
		/// otherwise does nothing, returns false.
		/// </summary>
		public bool InsertEddress( EDDRESS_ROW EDDRESS_ROW )
		{
			////Insert group into DB...
			//int insert_result = new INSERT( EDDRESS_ROW ).Execute;
			//if ( insert_result > 1 )
			//{
			//	//...get the new max PK...
			//	int key = new MAX_PK().Execute;

			//	//...retrieve the row that goes with the new max PK...
			//	EDDRESS_ROW inserted_row = new SELECT.ByPkEddress( key ).Execute;

			//	//...add the new row to the base row collection...
			//	base.AppendRow( key, inserted_row );

			//	return true;
			//}
			//else
			{
				return false;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// UPDATEs group_row.
		/// </summary>
		public bool UpdateEddress( EDDRESS_ROW group_row )
		{
			return new UPDATE( group_row ).Execute;
		}
		#endregion
	}
}
