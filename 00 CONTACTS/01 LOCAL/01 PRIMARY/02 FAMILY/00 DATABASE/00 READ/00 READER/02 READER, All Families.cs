
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
//GLOBAL
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
//FAMILY
using FAMILY_ROW	= CONTACTS.LOCAL.PRIMARY.FAMILY.Row;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class FamilyReader
		{
			//_______________________________________________________________________________________________________________________________________
			public Dictionary<int, BASE_ROW> ReadFamilies()
			{
				Dictionary<int, BASE_ROW> all_familys = new Dictionary<int, BASE_ROW>();
				FAMILY_ROW family;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();

					while ( reader.Read() )
					{
						family = ReadRow();
						all_familys.Add( family.PkFamily.Value, family );
					}

					reader.Close();
					base.Connection.Close();
				}
				catch ( Exception e )
				{
					base.Connection.Close();
				}

				return all_familys;
			}
		}
	}
}
