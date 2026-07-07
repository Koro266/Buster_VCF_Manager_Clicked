//___________________________________________________________________________________________________________________________________________________
using BASE_ROW		= CONTACTS.GLOBAL.DATABASE.ROW.BaseRow;
using READER		= CONTACTS.LOCAL.PRIMARY.FAMILY.Database.FamilyReader;
using COLUMNS		= CONTACTS.LOCAL.PRIMARY.FAMILY.Column;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.LOCAL.PRIMARY.FAMILY
{
	//___________________________________________________________________________________________________________________________________________
	public partial class Database
	{
		//___________________________________________________________________________________________________________________________________________
		public partial class Select
		{
			//___________________________________________________________________________________________________________________________________
			/// <summary>
			/// Returns all joined TDF_Families rows.
			/// </summary>
			public class AllJoinedFamilyPersons
			{
				private READER family_Reader;
				private const string sql_text =
				@"
					SELECT
						TDF_Families.pk_Family,
						TDF_Families.fk_LeftPerson,
						TDF_Families.fk_RightPerson,
						TDF_Families.st_FamilyType,
						TDF_Families.st_FamilyName,
						TDF_Families.st_SortableName,
						TDF_Families.st_JointName,
						TDF_Families.st_NaturalName,
						TDF_Families.st_PostalName,
						TDF_Families.st_Notes,
						TDF_Families.dt_WeddingDate,
						TDF_Families.dt_CurrencyDate,

						TDF_Families.is_Selected,
						TDF_Families.is_DefaultRow,
						TDF_Families.is_Export,
						TDF_Families.is_Blocked,
						TDF_Families.is_Inactive,
						TDF_Families.is_Christmas,
						TDF_Families.is_ExChristmas,
						TDF_Families.is_Dissolved,
						TDF_Families.is_CorlettRd,
						TDF_Families.is_StTheresa,

						TDF_Person_Left.st_UpperSurname AS LeftUpperSurname,
						TDF_Person_Left.st_ProperSurname AS LeftProperSurname,
						TDF_Person_Left.st_GivenName AS LeftGivenName,
						TDF_Person_Right.st_UpperSurname AS RightUpperSurname,
						TDF_Person_Right.st_ProperSurname AS RightProperSurname,
						TDF_Person_Right.st_GivenName AS RightGivenName
					FROM
						(
							TDF_Families
							INNER JOIN TDF_Persons AS TDF_Person_Left ON TDF_Families.fk_LeftPerson = TDF_Person_Left.pk_Person
						)
						INNER JOIN TDF_Persons AS TDF_Person_Right ON TDF_Families.fk_RightPerson = TDF_Person_Right.pk_Person
				";
				//_______________________________________________________________________________________________________________________________
				public AllJoinedFamilyPersons()
				{
					family_Reader = new READER( sql_text );
				}
				//_______________________________________________________________________________________________________________________________
				public Dictionary<int, BASE_ROW> Execute
				{
					get { return family_Reader.ReadPersonedFamilies(); }
				}
			}
		}
	}
}
