//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW			= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using LIKE				= CONTACTS.GLOBAL.DATABASE.READ.Like;
//LOCAL
using ADDRESS_READER	= CONTACTS.LOCAL.TERTIARY.ADDRESS.Database.AddressReader;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.TERTIARY.ADDRESS
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________
		public partial class Like
		{
			//_______________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns PK_Address and concatenated TDF_Address rows where 
			/// Rural Delivery number begins with the given character(s).
			/// </summary>
			public class RuralDelivery : LIKE
			{
				private const string _target_Field = "st_RuralDelivery";
				private ADDRESS_READER address_Reader;

				//___________________________________________________________________________________________________________________________
				public RuralDelivery( string sought_after_text )
				{
					string sql_text = PrepareSQL( _target_Field );
					OleDbParameter parameter = PrepareParameter( sql_text, sought_after_text );
					address_Reader = new ADDRESS_READER( sql_text, parameter );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return address_Reader.ReadAddresses(); }
				}
			}
		}
	}
}
