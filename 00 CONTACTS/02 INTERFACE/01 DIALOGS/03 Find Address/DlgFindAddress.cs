//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using static CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Select.Unique;
using ADDRESS		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using ADDRESSES		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Table;
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using LIKE			= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.Like;
//LOCAL
using NATION		= CONTACTS.LOCAL.TERTIARY.NATION.Row;
using NATIONS		= CONTACTS.LOCAL.TERTIARY.NATION.Table;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.INTERFACE.DIALOGS
{
	//_______________________________________________________________________________________________________________________________________________
	public partial class DlgFindAddress : Form
	{
		#region DECLARATION & CONSTRUCTION
		private static ADDRESSES all_Addresses = new ADDRESSES();
		private static NATIONS all_Nations = new NATIONS();

		private ADDRESS selected_Address = all_Addresses.DefaultAddress;
		private NATION one_Nation;

		//___________________________________________________________________________________________________________________________________________
		public DlgFindAddress()
		{
			InitializeComponent();
		}
		#endregion


		#region RESPONDERS
		//___________________________________________________________________________________________________________________________________________
		private ADDRESS Address
		{
			get { return selected_Address; }
			set
			{
				selected_Address = value;
				Country = all_Nations.NationByKey( selected_Address.FkCountry.Value );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private NATION Country
		{
			get { return all_Nations.NationByKey( Address.FkCountry.Value ); }
			set
			{
				Address.NewNation = value;
				one_Nation = value;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private int AddressPk
		{
			get { return Address.PkAddress.Value; }
			set { Address = all_Addresses.AddressByKey( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private string AddressPkAsText
		{
			get { return AddressPk.ToString(); }
			set { AddressPk = Convert.ToInt32( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private int CountryPk
		{
			get { return Address.FkCountry.Value; }
			set { Country = all_Nations.NationByKey( value ); }
		}
		//___________________________________________________________________________________________________________________________________________
		private string CountryPkAsText
		{
			get { return CountryPk.ToString(); }
			set { CountryPk = Convert.ToInt32( value ); }
		}


		#region STREET ADDRESS
		//___________________________________________________________________________________________________________________________________________
		private string HouseNumber
		{
			get { return Address.HouseNumber.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.HouseNumber( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string StreetName
		{
			get { return Address.StreetName.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.StreetName( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		#endregion


		#region 'BURB, CITY
		//___________________________________________________________________________________________________________________________________________
		private string Suburb
		{
			get { return Address.Suburb.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.SuburbName( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string City
		{
			get { return Address.City.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.CityName( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		#endregion


		#region POSTAL
		//___________________________________________________________________________________________________________________________________________
		private string PostBoxNumber
		{
			get { return Address.Suburb.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.BoxNumber( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string RuralDelivery
		{
			get { return Address.Suburb.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.RuralDelivery( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string PostCode
		{
			get { return Address.ProvinceName.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.PostalCode( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		#endregion


		#region EXTENSIONS
		//___________________________________________________________________________________________________________________________________________
		private string Assemblage
		{
			get { return Address.Suburb.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.Assemblage( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Level
		{
			get { return Address.Suburb.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.LevelNumber( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Unit
		{
			get { return Address.Suburb.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.UnitName( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string Extensions
		{
			get { return Address.Suburb.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.Extension( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		#endregion


		#region METROPOLITAN/PROVINCE
		//___________________________________________________________________________________________________________________________________________
		private string Metropolitan
		{
			get { return Address.Suburb.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.Metropolitan( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string ProvinceAbbreviation
		{
			get { return Address.Suburb.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.ProvinceAbbreviation( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		//___________________________________________________________________________________________________________________________________________
		private string ProvinceName
		{
			get { return Address.Suburb.Value; }
			set
			{
				Dictionary<int, BASE_ROW> like_column = new LIKE.ProvinceName( value ).Execute;
				DisplayAddresses( like_column );
			}
		}
		#endregion


		#region SELECTION
		//___________________________________________________________________________________________________________________________________________
		public ADDRESS SelectedAddress
		{
			get { return selected_Address; }
			set { selected_Address = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		public string SelectedIndexAsString
		{
			set { AddressPkAsText = value; }
		}
		//___________________________________________________________________________________________________________________________________________
		public string DoubleClick
		{
			set
			{
				AddressPkAsText = value;
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}
		#endregion


		#endregion RESPONDERS


		#region TEXTCHANGED & SELECTION
		//___________________________________________________________________________________________________________________________________________
		private void tbx_STR_HouseNumber_TextChanged( object sender, EventArgs e )
		{
			HouseNumber = tbx_STR_HouseNumber.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_STR_StreetName_TextChanged( object sender, EventArgs e )
		{
			StreetName = tbx_STR_StreetName.Text;
		}


		//___________________________________________________________________________________________________________________________________________
		private void tbx_LOC_City_TextChanged( object sender, EventArgs e )
		{
			City = tbx_LOC_City.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_LOC_Suburb_TextChanged( object sender, EventArgs e )
		{
			Suburb = tbx_LOC_Suburb.Text;
		}


		//___________________________________________________________________________________________________________________________________________
		private void tbx_BOX_Number_TextChanged( object sender, EventArgs e )
		{
			PostBoxNumber = tbx_BOX_Number.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_BOX_RuralDelivery_TextChanged( object sender, EventArgs e )
		{
			RuralDelivery = tbx_BOX_RuralDelivery.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_ZIP_PostalCode_TextChanged( object sender, EventArgs e )
		{
			PostCode = tbx_ZIP_PostalCode.Text;
		}


		//___________________________________________________________________________________________________________________________________________
		private void tbx_EXT_Assemblage_TextChanged( object sender, EventArgs e )
		{
			Assemblage = tbx_EXT_Assemblage.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_EXT_Level_TextChanged( object sender, EventArgs e )
		{
			Level = tbx_EXT_Level.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_EXT_Unit_TextChanged( object sender, EventArgs e )
		{
			Unit = tbx_EXT_Unit.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_EXT_Extension_TextChanged( object sender, EventArgs e )
		{
			Extensions = tbx_EXT_Extension.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_MET_Metropolitan_TextChanged( object sender, EventArgs e )
		{
			Metropolitan = tbx_MET_Metropolitan.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PRV_Abbreviation_TextChanged( object sender, EventArgs e )
		{
			ProvinceAbbreviation = tbx_PRV_Abbreviation.Text;
		}
		//___________________________________________________________________________________________________________________________________________
		private void tbx_PRV_Name_TextChanged( object sender, EventArgs e )
		{
			ProvinceName = tbx_PRV_Name.Text;
		}

		//___________________________________________________________________________________________________________________________________________
		private void lvw_MatchingAddresses_DoubleClick( object sender, EventArgs e )
		{
			DoubleClick = lvw_MatchingAddresses.SelectedItems[0].Text;
		}
		#endregion


		#region DISPLAYER
		//___________________________________________________________________________________________________________________________________________
		public void DisplayAddresses( Dictionary<int, BASE_ROW> address_rows )
		{
			this.lvw_MatchingAddresses.Items.Clear();
			int index = 0;

			foreach ( KeyValuePair<int, BASE_ROW> row in address_rows )
			{
				ADDRESS address = ( ADDRESS )row.Value;
				string[] columns = address.RealiseFinderPattern();

				lvw_MatchingAddresses.Items.Add( columns[0] );
				lvw_MatchingAddresses.Items[index].SubItems.Add( columns[1] );
				lvw_MatchingAddresses.Items[index].SubItems.Add( columns[2] );
				lvw_MatchingAddresses.Items[index].SubItems.Add( columns[3] );
				lvw_MatchingAddresses.Items[index].SubItems.Add( columns[4] );
				lvw_MatchingAddresses.Items[index].SubItems.Add( columns[5] );
				lvw_MatchingAddresses.Items[index++].SubItems.Add( columns[6] );
			}
		}
		#endregion


		#region TERMINATION
		//___________________________________________________________________________________________________________________________________________
		private void btn_CloseForm_Click( object sender, EventArgs e )
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		//___________________________________________________________________________________________________________________________________________
		private void btn_Cancel_Click( object sender, EventArgs e )
		{
			this.DialogResult = DialogResult.Cancel;
			this.selected_Address = all_Addresses.DefaultAddress;
			this.Close();
		}
		#endregion

	}
}
