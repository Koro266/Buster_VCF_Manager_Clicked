//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_TABLE	= CONTACTS.GLOBAL.DATABASE.TABLE.BaseTable;
using PRESET		= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
//LOCAL
using PERSON_ROW	= CONTACTS.LOCAL.PRIMARY.PERSON.Row;
using SELECT		= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Select;
using INSERT		= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Insert.Person;
using UPDATE		= CONTACTS.LOCAL.PRIMARY.PERSON.Database.Update.Person;


//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Table : BASE_TABLE
	{
		#region DECLARATIONS
		private Dictionary<int, PERSON_ROW> person_Rows;
		#endregion


		#region CONSTRUCTION
		//___________________________________________________________________________________________________________________________________________
		public Table() : base ( new SELECT.AllPersons().Execute )
		{
			person_Rows = this.PersonRows;
		}
		#endregion


		#region CONVERSION
		//___________________________________________________________________________________________________________________________________________
		private Dictionary<int, PERSON_ROW> PersonRows
		{
			get
			{
				Dictionary<int, PERSON_ROW> persons = new Dictionary<int, PERSON_ROW>();
				foreach ( var kvp in base.AllRows )
					persons.Add( kvp.Key, ( PERSON_ROW )kvp.Value );

				return persons;
			}
		}
		#endregion


		#region SPECIFIC NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Retrieves the designated default Person.
		/// </summary>
		public PERSON_ROW DefaultPerson
		{
			get
			{
				base.CurrentRow = new SELECT.DefaultPerson().Execute;
				return ( PERSON_ROW )CurrentRow;
			}
		}
		#endregion


		#region GENERIC NAVIGATION
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the current Person.
		/// </summary>
		public PERSON_ROW CurrentPerson
		{
			get { return ( PERSON_ROW )base.CurrentRow; }
			set { base.CurrentRow = value; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Person row addressed by CurrentKey.
		/// </summary>
		public PERSON_ROW CurrentKeyPerson
		{
			get
			{
				PERSON_ROW row = ( PERSON_ROW )base.CurrentKeyRow;
				return ( row == null ) ? this.DefaultPerson : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Person row addressed by CurrentIndex.
		/// </summary>
		public PERSON_ROW CurrentIndexPerson
		{
			get
			{
				PERSON_ROW row = ( PERSON_ROW )base.CurrentIndexRow;
				return ( row == null ) ? this.DefaultPerson : row;
			}
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Person row at index.
		/// </summary>
		public PERSON_ROW PersonByIndex( int index )
		{
			CurrentIndex = index;
			return CurrentPerson;
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns the Person row by key.
		/// </summary>
		public PERSON_ROW PersonByKey( int key )
		{
			base.CurrentKey = key;
			return CurrentPerson;
		}
		#endregion


		#region INCREMENTAL NAVIGATION
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns first Person row (index = 0).
		/// </summary>
		public PERSON_ROW FirstPerson
		{
			get { return ( PERSON_ROW )base.FirstRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Decrements CurrentIndex - 1 and retrieves PERSON[index].
		/// </summary>
		public PERSON_ROW PreviousPerson
		{
			get { return ( PERSON_ROW )base.PreviousRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Increments CurrentIndex + 1 and retrieves PERSON[index].
		/// </summary>
		public PERSON_ROW NextPerson
		{
			get { return ( PERSON_ROW )base.NextRow; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns last Person row (index = max_index).
		/// </summary>
		public PERSON_ROW LastPerson
		{
			get { return ( PERSON_ROW )base.LastRow; }
		}
		#endregion


		#region SQL
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// INSERTs person_row. If INSERT successful, adds row to AllPersons,
		/// sets CurrentIndex to that row, and returns true;
		/// otherwise does nothing, returns false.
		/// </summary>
		public bool InsertPerson( PERSON_ROW person_row )
		{
			//Insert person into DB...
			int inserted_pk = new INSERT( person_row ).Execute;
			if ( inserted_pk <= PRESET.ZERO )
				return false;

			//...retrieve the row that goes with the new max PK...
			PERSON_ROW inserted_row = new SELECT.ByPkPerson( inserted_pk ).Execute;

			//...add the new row to the base row collection.
			base.AppendRow( inserted_pk, inserted_row );

			return true;
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// UPDATEs person_row. Returns true on success, false otherwise.
		/// </summary>
		public bool UpdatePerson( PERSON_ROW person_row )
		{
			return new UPDATE( person_row ).Execute;
		}
		#endregion


		#region SELECTION
		//___________________________________________________________________________________________________________________________________________
		public Dictionary<int, PERSON_ROW> PersonsAsDictionary
		{
			get { return person_Rows; }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns Persons as PERSON_ROW[].
		/// </summary>
		public PERSON_ROW[] PersonsAsArray
		{
			get { return person_Rows.Values.ToArray(); }
		}
		//_______________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns Persons as List<PERSON_ROW>.
		/// </summary>
		public List<PERSON_ROW> PersonsAsList
		{
			get { return person_Rows.Values.ToList(); }
		}
		#endregion
	}
}
