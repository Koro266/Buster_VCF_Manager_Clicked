//___________________________________________________________________________________________________________________________________________________
using System.Text;
//GLOBAL
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.VCF
{
	//_______________________________________________________________________________________________________________________________________________
	public class VcfText
	{
		#region DECLARATIONS
		private string[] _VcfLines;
		private StringBuilder _VcfNotes;
		private const string END = "END:VCARD";

		private int _InitialCount = 99;
		private int _CurrentIndex = PRESET.MINUS_ONE;
		private int _CurrentItem = PRESET.ZERO;
		#endregion


		#region CONSTRUCTORS
		//___________________________________________________________________________________________________________________________________________
		public VcfText()
		{
			_VcfLines = new string[_InitialCount];
			_VcfNotes = new StringBuilder();
		}
		#endregion


		#region LINES
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Return current contents of VcfLines.
		/// </summary>
		public string[] Lines
		{
			get { return _VcfLines; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Return true if the line count is > 0;
		/// </summary>
		public bool HasLines
		{
			get { return ItemCount > PRESET.ZERO; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Return true if the line count == 0;
		/// </summary>
		public bool HasNoLines
		{
			get { return ItemCount == PRESET.ZERO; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns VcfLine item count.
		/// </summary>
		public int ItemCount
		{
			get { return _VcfLines.Count(); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string CurrentItem
		{
			get { return _CurrentItem.ToString(); }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// The VCF interpreter maintains "item#0" specifiers to associate individual data items.
		/// NextItem increments the 'item' specifier and returns that value.
		/// </summary>
		public string NextItem
		{
			get
			{
				++_CurrentItem;
				return _CurrentItem.ToString();
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// NextIndex increments CurrentIndex before inserting value into the VcfLines array at that index.
		/// </summary>
		public string NextIndex
		{
			set { _VcfLines[++_CurrentIndex] = value; }
		}
		#endregion


		#region NOTES
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns contents of VcfNotes (a StringBuilder object) as a string.
		/// </summary>
		public string Notes
		{
			get { return _VcfNotes.ToString(); }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns VcfNotes.Length > 0;
		/// </summary>
		public bool HasNotes
		{
			get { return _VcfNotes.Length > PRESET.ZERO; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns VcfNotes.Length == 0;
		/// </summary>
		public bool HasNoNotes
		{
			get { return _VcfNotes.Length == PRESET.ZERO; }
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Appends value to VcfNotes.
		/// </summary>
		public string NextNote
		{
			set { _VcfNotes.Append( value ); }
		}
		#endregion


		#region APPENDS 'END' LINE, WRITES OUTPUT FILE 
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Write both VcfLines and VcfNotes to the specified text file.
		/// </summary>
		/// <param name="file_name"></param>
		public void WriteLines( string file_name )
		{
			using ( StreamWriter outputFile = new StreamWriter( file_name, false ) )
			{
				foreach ( string s in _VcfLines )
				{
					if ( s == null )
						break;
					outputFile.WriteLine( s );
				}

				outputFile.WriteLine( _VcfNotes.ToString() );
				outputFile.WriteLine( END );

				outputFile.Close();
			}
		}
		#endregion
	}
}
