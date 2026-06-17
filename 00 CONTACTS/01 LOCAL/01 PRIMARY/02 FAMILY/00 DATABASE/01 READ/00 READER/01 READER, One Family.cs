
//___________________________________________________________________________________________________________________________________________________
using System.Data.OleDb;
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
			public FAMILY_ROW ReadFamily()
			{
				FAMILY_ROW family;

				try
				{
					base.Connection.Open();
					OleDbDataReader reader = base.ExecuteReader();
					reader.Read();

					family = ReadRow();

					reader.Close();
					base.Connection.Close();
					return family;
				}
				catch ( Exception e )
				{
					base.Connection.Close();
					return null;
				}
			}
		}
	}
}
