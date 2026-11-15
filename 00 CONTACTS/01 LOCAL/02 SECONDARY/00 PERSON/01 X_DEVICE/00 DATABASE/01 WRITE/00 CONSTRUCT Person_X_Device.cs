//___________________________________________________________________________________________________________________________________________________
//LOCAL
using PERSON_X_DEVICE	= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Row;
using COLUMNS			= CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.SECONDARY.PERSON.XDEVICE
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//_______________________________________________________________________________________________________________________________
		/// <summary>
		/// Creates an 'internal' representation of a Person_x_Device row which serves as the input to an INSERT operation.
		/// </summary>
		public static PERSON_X_DEVICE ConstructDeviceRow( int fk_person, int fk_device, string list_order, string label )
		{
			PERSON_X_DEVICE person_x_device = new PERSON_X_DEVICE();

			person_x_device.Append( new COLUMNS.PK_Person_X_Device( 0 ) );
			person_x_device.Append( new COLUMNS.FK_Person( fk_person ) );
			person_x_device.Append( new COLUMNS.FK_Device( fk_device ) );
			person_x_device.Append( new COLUMNS.ST_ListOrder( list_order ) );
			person_x_device.Append( new COLUMNS.ST_Label( label ) );

			return person_x_device;
		}
	}
}
