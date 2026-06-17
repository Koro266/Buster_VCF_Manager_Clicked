//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL 
using ORDINAL	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Column;
using COUNTRY	= CONTACTS.LOCAL.TERTIARY.NATION.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		#region VALUE ALTERATION, STREET ADDRESS +
		//___________________________________________________________________________________________________________________________________________
		public string NewHouseNumber
		{
			set { Replace( ORDINAL.HouseNumber, new FIELD.ST_HouseNumber( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewStreetName
		{
			set { Replace( ORDINAL.StreetName, new FIELD.ST_StreetName( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewStreetType
		{
			set { Replace( ORDINAL.StreetType, new FIELD.ST_StreetType( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewCompass
		{
			set { Replace( ORDINAL.Compass, new FIELD.ST_Compass( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewSuburb
		{
			set { Replace( ORDINAL.Suburb, new FIELD.ST_Suburb( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewCity
		{
			set { Replace( ORDINAL.City, new FIELD.ST_City( value ) ); }
		}
		#endregion


		#region  VALUE ALTERATION, METRO/PROVINCIAL
		//___________________________________________________________________________________________________________________________________________
		public string NewMetropolitan
		{
			set { Replace( ORDINAL.Metropolitan, new FIELD.ST_Metropolitan( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewProvinceName
		{
			set { Replace( ORDINAL.ProvinceName, new FIELD.ST_ProvinceName( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewProvinceCode
		{
			set { Replace( ORDINAL.ProvinceCode, new FIELD.ST_ProvinceCode( value ) ); }
		}
		#endregion


		#region  VALUE ALTERATION, COUNTRY
		//___________________________________________________________________________________________________________________________________________
		public COUNTRY NewNation
		{
			get { return address_Nation; }
			set
			{
				Replace( ORDINAL.FkCountry, new FIELD.FK_Country( value.PkCountry.Value ) );
				address_Nation = value;
			}
		}
		#endregion


		#region  VALUE ALTERATION, POSTAL
		//___________________________________________________________________________________________________________________________________________
		public string NewBoxNumber
		{
			set { Replace( ORDINAL.BoxNumber, new FIELD.ST_BoxNumber( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewRuralDelivery
		{
			set { Replace( ORDINAL.RuralDelivery, new FIELD.ST_RuralDelivery( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewPostalCode
		{
			set { Replace( ORDINAL.PostalCode, new FIELD.ST_PostalCode( value ) ); }
		}
		#endregion


		#region  VALUE ALTERATION, EXTENSIONS
		//___________________________________________________________________________________________________________________________________________
		public string NewAssemblage
		{
			set { Replace( ORDINAL.Assemblage, new FIELD.ST_Assemblage( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewLevel
		{
			set { Replace( ORDINAL.Level, new FIELD.ST_Level( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewUnit
		{
			set { Replace( ORDINAL.Unit, new FIELD.ST_Unit( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewExtension
		{
			set { Replace( ORDINAL.Extension, new FIELD.ST_Extension( value ) ); }
		}
		#endregion


		#region  VALUE ALTERATION, VCF RULES
		//___________________________________________________________________________________________________________________________________________
		public string NewVcfPostal
		{
			set { Replace( ORDINAL.VcfPostal, new FIELD.ST_VcfPostal( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewVcfPhysical
		{
			set { Replace( ORDINAL.VcfPhysical, new FIELD.ST_VcfPhysical( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewVcfExtended
		{
			set { Replace( ORDINAL.VcfExtended, new FIELD.ST_VcfExtended( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public string NewExcelPattern
		{
			set { Replace( ORDINAL.ExcelPattern, new FIELD.ST_ExcelPattern( value ) ); }
		}
		//___________________________________________________________________________________________________________________________________________
		public bool NewIsChristmas
		{
			set { Replace( ORDINAL.Christmas, new FIELD.IS_Christmas( value ) ); }
		}
		#endregion
	}
}
