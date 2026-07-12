//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_TABLE	= CONTACTS.GLOBAL.DATABASE.TABLE.BaseTable;
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL
using NATION_ROW	= CONTACTS.LOCAL.TERTIARY.NATION.Row;
using SELECT		= CONTACTS.LOCAL.TERTIARY.NATION.Database.Select;
using COUNT			= CONTACTS.LOCAL.TERTIARY.NATION.Database.Count;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.NATION
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Table : BASE_TABLE
	{
		//TODO: Indexing does not work correctly after pk_Country = 4 (USA). 

		#region DECLARATIONS
		private Dictionary<int, NATION_ROW> nation_Rows;
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public Table() : base( new SELECT.AllNations().Execute )
		{
			nation_Rows = this.NationRows;
		}
		#endregion


		#region CONVERSION
		//___________________________________________________________________________________________________________________________________________
		private Dictionary<int, NATION_ROW> NationRows
		{
			get
			{
				Dictionary<int, NATION_ROW> nations = new Dictionary<int, NATION_ROW>();
				foreach ( var kvp in base.AllRows )
					nations.Add( kvp.Key, ( NATION_ROW )kvp.Value );

				return nations;
			}
		}
		#endregion


		#region SPECIFIC NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the default Nation.
		/// </summary>
		public NATION_ROW DefaultNation
		{
			get
			{
				base.CurrentRow = new SELECT.DefaultNation().Execute;
				return ( NATION_ROW )CurrentRow;
			}
		}
		#endregion


		#region GENERIC NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the current Nation.
		/// </summary>
		public NATION_ROW CurrentNation
		{
			get { return ( NATION_ROW )base.CurrentRow; }
			set { base.CurrentRow = value; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Nation row addressed by CurrentKey.
		/// </summary>
		public NATION_ROW CurrentKeyNation
		{
			get
			{
				NATION_ROW row = ( NATION_ROW )base.CurrentKeyRow;
				return ( row == null ) ? this.DefaultNation : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Nation row addressed by CurrentIndex.
		/// </summary>
		public NATION_ROW CurrentIndexNation
		{
			get
			{
				NATION_ROW row = ( NATION_ROW )base.CurrentIndexRow;
				return ( row == null ) ? this.DefaultNation : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Nation row at index.
		/// </summary>
		public NATION_ROW NationByIndex( int index )
		{
			CurrentIndex = index;
			return CurrentNation;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Nation row by primary key.
		/// </summary>
		public NATION_ROW NationByKey( int key )
		{
			base.CurrentKey = key;
			return CurrentNation;
		}
		#endregion


		#region SELECTION
		//___________________________________________________________________________________________________________________________________________
		public Dictionary<int, NATION_ROW> NationsAsDictionary
		{
			get { return nation_Rows; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns Nations as List<NATION_ROW>.
		/// </summary>
		public NATION_ROW[] NationsAsArray
		{
			get { return nation_Rows.Values.ToArray(); }
		}
		#endregion
	}
}
