//___________________________________________________________________________________________________________________________________________________
//GLOBAL
using BASE_ROW = CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//LOCAL 
using ORDINAL	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Constants.OrdinalByName;
using FIELD		= CONTACTS.LOCAL.TERTIARY.ADDRESS.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Row : BASE_ROW
	{
		#region STREET LINE
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if there is at least one street value column that carries a non-null value.
		/// </summary>
		public bool IsStreetLine
		{
			get
			{ 
				return
					HouseNumber.IsNull &&
					StreetName.IsNull &&
					StreetType.IsNull &&
					Compass.IsNull;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if there is at least one city value column that carries a non-null value.
		/// </summary>
		public bool IsCityLine
		{
			get
			{
				return
					Suburb.IsNotNull &&
					City.IsNotNull;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if there is at least one metro value column that carries a non-null value.
		/// </summary>
		public bool IsMetroLine
		{
			get
			{
				return
					Metropolitan.IsNotNull &&
					ProvinceName.IsNotNull &&
					ProvinceCode.IsNotNull;
			}
		}
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if there is at least one Country value column that carries a non-null value.
		/// </summary>
		public bool IsCountryLine
		{
			get
			{
				return
					CountryName.IsNotNull &&
					CountryCode.IsNotNull &&
					ShortIsoCode.IsNotNull &&
					LongIsoCode.IsNotNull;
			}
		}
		#endregion


		#region  POSTAL LINE
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if there is at least one Postal value column that carries a non-null value.
		/// </summary>
		public bool IsPostalLine
		{
			get
			{
				return
					BoxNumber.IsNotNull &&
					RuralDelivery.IsNotNull &&
					PostalCode.IsNotNull;
			}
		}
		#endregion


		#region EXTENSIONS LINE
		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Returns true if there is at least one Extensions value column that carries a non-null value.
		/// </summary>
		public bool IsExtensionsLine
		{
			get
			{
				return
					Assemblage.IsNotNull &&
					Level.IsNotNull &&
					Unit.IsNotNull &&
					Extension.IsNotNull;
			}
		}
		#endregion
	}
}
