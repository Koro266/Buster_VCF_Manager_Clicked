//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using SHORT_TXT = CONTACTS.GLOBAL.DATABASE.COLUMN.Short_Text;
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using FIELD = CONTACTS.LOCAL.PRIMARY.PERSON.Column;
//LOCAL 
using ORDINAL = CONTACTS.LOCAL.PRIMARY.PERSON.Constants.OrdinalByName;
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;
using SBLDR = System.Text.StringBuilder;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.PERSON
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		#region PATTERNS
		private const string sortable_name_Pattern = "#0, #1 #2";
		private const string natural_name_Pattern = "#0 #1 #2";
		#endregion


		#region RECOMPUTE DERIVED FIELDS
		//___________________________________________________________________________________________________________________________________________
		private string DerivedSortableName
		{
			get
			{
				SBLDR s = new SBLDR( sortable_name_Pattern );

				s.Replace( PRESET.S0, ( ( FIELD.ST_ProperSurname )base.GetField( ORDINAL.ProperSurname ) ).AsUpper );
				s.Replace( PRESET.S1, ( ( FIELD.ST_GivenName )base.GetField( ORDINAL.GivenName ) ).AsIs );
				s.Replace( PRESET.S2, ( ( FIELD.ST_MiddleNames )base.GetField( ORDINAL.MiddleNames ) ).AsIs );

				return SHORT_TXT.RectifyText( s.ToString() );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string DerivedNaturalName
		{
			get
			{
				SBLDR s = new SBLDR( natural_name_Pattern );

				s.Replace( PRESET.S0, ( ( FIELD.ST_GivenName )base.GetField( ORDINAL.GivenName ) ).AsIs );
				s.Replace( PRESET.S1, ( ( FIELD.ST_MiddleNames )base.GetField( ORDINAL.MiddleNames ) ).AsIs );
				s.Replace( PRESET.S2, ( ( FIELD.ST_ProperSurname )base.GetField( ORDINAL.ProperSurname ) ).AsIs );

				return SHORT_TXT.RectifyText( s.ToString() );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string DerivedInitials
		{
			get
			{
				SBLDR s = new SBLDR();

				FIELD.ST_GivenName given = ( FIELD.ST_GivenName )base.GetField( ORDINAL.GivenName );
				FIELD.ST_MiddleNames middle = ( FIELD.ST_MiddleNames )base.GetField( ORDINAL.MiddleNames );
				FIELD.ST_ProperSurname surname = ( FIELD.ST_ProperSurname )base.GetField( ORDINAL.ProperSurname );

				if ( given.Value.Length >= 1 )
					s = s.Append( given.AsLowerInitial );

				if ( middle.Value.Length >= 1 )
					s = s.Append( middle.AsLowerInitial );

				if ( surname.Value.Length >= 1 )
					s = s.Append( surname.AsLowerInitial );

				return SHORT_TXT.RectifyText( s.ToString() );
			}
		}
		#endregion
	}
}
