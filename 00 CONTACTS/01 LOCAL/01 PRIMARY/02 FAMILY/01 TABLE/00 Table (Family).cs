//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_TABLE	= CONTACTS.GLOBAL.DATABASE.TABLE.BaseTable;
//LOCAL
using FAMILY_ROW	= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;
using SELECT		= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Select;
using INSERT		= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Insert.Family;
using UPDATE		= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Update.Family;
using MAX_PK		= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.Count.MaxPk;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Table : BASE_TABLE
	{
		#region DECLARATIONS
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public Table() : base ( new SELECT.AllJoinedFamilyPersons().Execute )
		{
		}
		#endregion


		#region SPECIFIC NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the default Family.
		/// </summary>
		public FAMILY_ROW DefaultFamily
		{
			get
			{
				base.CurrentRow = new SELECT.DefaultFamily().Execute;
				return ( FAMILY_ROW )CurrentRow;
			}
		}
		#endregion


		#region GENERIC NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the current Family.
		/// </summary>
		public FAMILY_ROW CurrentFamily
		{
			get { return ( FAMILY_ROW )base.CurrentRow; }
			set { base.CurrentRow = value; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Family row addressed by CurrentKey.
		/// </summary>
		public FAMILY_ROW CurrentKeyFamily
		{
			get
			{
				FAMILY_ROW row = ( FAMILY_ROW )base.CurrentKeyRow;
				return ( row == null ) ? this.DefaultFamily : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Family row addressed by CurrentIndex.
		/// </summary>
		public FAMILY_ROW CurrentIndexFamily
		{
			get
			{
				FAMILY_ROW row = ( FAMILY_ROW )base.CurrentIndexRow;
				return ( row == null ) ? this.DefaultFamily : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Family row at index.
		/// </summary>
		public FAMILY_ROW FamilyByIndex( int index )
		{
			CurrentIndex = index;
			return CurrentFamily;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Family row by key.
		/// </summary>
		public FAMILY_ROW FamilyByKey( int key )
		{
			return (FAMILY_ROW)base.RowByKey( key );
		}
		#endregion


		#region INCREMENTAL NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns first Family row (index = 0).
		/// </summary>
		public FAMILY_ROW FirstFamily
		{
			get { return ( FAMILY_ROW )base.FirstRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Decrements CurrentIndex - 1 and retrieves FAMILY[index].
		/// </summary>
		public FAMILY_ROW PreviousFamily
		{
			get { return ( FAMILY_ROW )base.PreviousRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Increments CurrentIndex + 1 and retrieves FAMILY[index].
		/// </summary>
		public FAMILY_ROW NextFamily
		{
			get { return ( FAMILY_ROW )base.NextRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns last Family row (index = max_index).
		/// </summary>
		public FAMILY_ROW LastFamily
		{
			get { return ( FAMILY_ROW )base.LastRow; }
		}
		#endregion


		#region SQL
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// INSERTs family_row. If INSERT successful, adds row to AllFamilys,
		/// sets CurrentIndex to that row, and returns true;
		/// otherwise does nothing, returns false.
		/// </summary>
		public bool InsertFamily( FAMILY_ROW family_row )
		{
			//Insert group into DB...
			int insert_result = new INSERT( family_row ).Execute;
			if ( insert_result > 1 )
			{
				//...get the new max PK...
				int key = new MAX_PK().Execute;

				//...retrieve the row that goes with the new max PK...
				FAMILY_ROW inserted_row = new SELECT.ByPkFamily( key ).Execute;

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
		/// UPDATEs family_row.
		/// </summary>
		public bool UpdateFamily( FAMILY_ROW family_row )
		{
			return new UPDATE( family_row ).Execute;
		}
		#endregion
	}
}