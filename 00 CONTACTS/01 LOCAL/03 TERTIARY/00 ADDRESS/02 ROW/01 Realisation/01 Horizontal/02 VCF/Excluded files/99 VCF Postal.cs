//___________________________________________________________________________________________________________________________________________________
//GLOBAL
//LOCAL
using ADDRESS_ROW	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Row;
using VCF_ADDRESS	= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.VCF.Item_01_Postal;
using BOX_RD		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.VCF.Item_00_BoxRd;
using STREET		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.VCF.Item_01_Street;
using BURB_CITY		= CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.VCF.Item_02_SuburbCity;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS.REALISER.HORIZONTAL.VCF
{
	//___________________________________________________________________________________________________________________________________________
	public class VcfAddress : BaseAddress
	{
		private BOX_RD _BoxRd;
		private STREET _Street;
		private BURB_CITY _BurbCity;
		private VCF_ADDRESS _VcfAddress;

		//___________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Constructs a VCF Postal address using the postal definition in the database address row. 
		/// </summary>
		public VcfAddress( ADDRESS_ROW address_row ) : base( address_row )
		{
			_BoxRd = new BOX_RD( address_row );
			_Street = new STREET( address_row );
			_BurbCity = new BURB_CITY( address_row );
			_VcfAddress = new VCF_ADDRESS( address_row );
		}
		//_______________________________________________________________________________________________________________________________________
		public string RealiseRule
		{
			get
			{
				string s = String.Empty;

				s += _VcfAddress.RealiseAddressRule;
				//s += _Street.RealiseAddressRule;
				//s += _BurbCity.RealiseAddressRule;

				return s;
			}
		}
	}
}
