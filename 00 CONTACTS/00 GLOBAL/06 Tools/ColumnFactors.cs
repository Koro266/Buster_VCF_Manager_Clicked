//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using SHORT_TEXT	= CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using GLOBAL_PRESET	= CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.TOOLS
{
	//_______________________________________________________________________________________________________________________________________
	public class ColumnFactors
	{
		private int _Ordinal;
		private int _FieldWidth;
		private string _FieldName;
		private string _ParameterName;

		//___________________________________________________________________________________________________________________________________
		/// <summary>
		/// 
		/// </summary>
		/// <param name="column_ordinal"></param>
		/// <param name="field_width"></param>
		/// <param name="field_name"></param>
		/// <param name="parm_name"></param>
		public ColumnFactors( int column_ordinal, int field_width, string field_name, string parm_name )
		{
			this._Ordinal = column_ordinal;
			this._FieldWidth = field_width;
			this._FieldName = field_name;
			this._ParameterName = field_name;
		}
		//___________________________________________________________________________________________________________________________________
		public int Ordinal { get { return _Ordinal; } }
		public int FieldWidth { get { return _FieldWidth; } }
		public string FieldName { get { return _FieldName; } }
		public string ParameterName { get { return _ParameterName; } }
	}
}
