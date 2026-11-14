//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow ;
//LOCAL
using ADDRESS_ROW		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using SELECT_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select;
using LIKE				= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Like;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.CONTROLS.HORIZONTAL.LISTVIEW
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class ListViewAddress
	{
		//___________________________________________________________________________________________________________________________________________
		public ADDRESS_ROW DefaultAddress
		{
			get { return new SELECT_ADDRESS.DefaultAddress().Execute; }
		}


		#region STREET ADDRESS
		//___________________________________________________________________________________________________________________________________________
		public string HouseNumber
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.HouseNumber( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public string StreetName
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.StreetName( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		#endregion


		#region 'BURB, CITY
		//___________________________________________________________________________________________________________________________________________
		public string Suburb
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.SuburbName( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public string City
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.CityName( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		#endregion


		#region POSTAL
		//___________________________________________________________________________________________________________________________________________
		public string PoBox
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.BoxNumber( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public string RuralDelivery
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.RuralDelivery( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public string PostCode
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.PostalCode( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		#endregion


		#region EXTENSIONS
		//___________________________________________________________________________________________________________________________________________
		public string Assemblage
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.Assemblage( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public string Level
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.LevelNumber( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public string Unit
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.UnitName( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public string Extentions
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.Extension( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		#endregion


		#region METROPOLITAN/PROVINCE
		//___________________________________________________________________________________________________________________________________________
		public string Metropolitan
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.Metropolitan( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public string ProvinceName
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.ProvinceName( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		public string ProvinceAbbrev
		{
			set
			{
				Dictionary<int, BASE_ROW> base_rows = new LIKE.ProvinceAbbreviation( value ).Execute;
				DisplayAddresses( base_rows );
			}
		}
		#endregion
	}
}
