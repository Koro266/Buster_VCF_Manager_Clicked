//___________________________________________________________________________________________________________________________________________________
//SYSTEM
using STRING = System.Text.StringBuilder;
//GLOBAL
using PRESET = CONTACTS.GLOBAL.VALUES.CONSTANT.Preset;

//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.CONNECTION
{
	public enum StartupForm
	{
		Overseer,
		Person,
		Group,
		Family,
		Address,
		Device
	};

	//_______________________________________________________________________________________________________________________________________________
	public class DbConnector
	{
		private const string prefix_Year		= "2026";
		private const string prefix_Month		= "06";
		private const string prefix_Day			= "01";
		private const string prefix_Sequence	= "01";
		private const string prefix_Pattern		= "#0.#1.#2.#3";
		private const string currency_Pattern	= "#0 VCF Builder.accdb";
		private const string provider_Pattern	= "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=#0";
		private const string full_RootPath		= @"C:\Users\Brusster\ContactsManager\Database\";

		/// <summary>
		/// Defines templates for output VCF file names.
		/// </summary>
		//Export file name root paths.
		private static string root_path_export	= full_RootPath + "Export\\";
		private static string root_path_person	= root_path_export + "PERSONS\\";
		private static string root_path_group	= root_path_export + "GROUPS\\";
		private static string root_path_family	= root_path_export + "FAMILIES\\";

		//Export file name templates using currency date.
		private static string template_person = "PSN = #0, #1 {#2}; #3.vcf";
		private static string template_group = "GRP = #0 {#1}; #2.vcf";
		private static string template_family = "FAM = #0 {#1}; #2.vcf";

		/// <summary>
		/// FullyQualifiedRoot + Export\ + PERSONS\ + "PSN, #0; #1, #2 (#3).vcf" -- 
		/// where #0=currency date/time, #1=SURNAME, #2=Given name, and #3=pk_Person
		/// </summary>
		public static string PersonTemplate { get { return root_path_person + template_person; } }
		/// <summary>
		/// FullyQualifiedRoot + Export\ + GROUPS\ + "GRP, #0; #1 (#2).vcf" -- 
		/// where #0=currency date/time, #1=Group name and #2=pk_Group
		/// </summary>
		public static string GroupTemplate { get { return root_path_group + template_group; } }
		/// <summary>
		/// FullyQualifiedRoot + Export\ + FAMILIES\ + "FAM, #0; #1 (#2).vcf" -- 
		/// where #0=currency date/time, #1=Family name and #2=pk_Family
		/// </summary>
		public static string FamilyTemplate { get { return root_path_family + template_family; } }

		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Constructs the database filename used in the Currency clause of a VCF file.
		/// "2026.03.20.01 VCF Builder.accdb".
		/// The prefix is identical for both RELEASE and DEBUG database files
		/// </summary>
		public static string VcfDbFileName
		{
			get
			{
				STRING s = new STRING( currency_Pattern );
				s.Replace( PRESET.S0, FileNamePrefix );
				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Constructs the file name prefix: "yyyy.mm.dd.seq", e.g.: "2025.09.24.01".
		/// The prefix is identical for both RELEASE and DEBUG database files
		/// </summary>
		public static string FileNamePrefix
		{
			get
			{
				STRING s = new STRING( prefix_Pattern );
				s.Replace( PRESET.S0, prefix_Year );
				s.Replace( PRESET.S1, prefix_Month );
				s.Replace( PRESET.S2, prefix_Day );
				s.Replace( PRESET.S3, prefix_Sequence );
				return s.ToString();
			}
		}

#if DEBUG
		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Constants that are specific to a DEBUG compile & connection.
		/// </summary>
		private const string file_Name				="VCF Builder - Copy.accdb";
		private const string header_Text			="VCF Builder - Copy";
		private const string fullyqualified_Pattern	="#0#1 #2";
		private const string abbreviated_Pattern	= @"C:\...ContactsManager...\#0 #1 (DEBUG)";

		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Fully-qualified name of the [debug version] of the database file.
		/// </summary>
		public string FullyQualifiedFileName
		{
			get
			{
				STRING s = new STRING( fullyqualified_Pattern );
				s.Replace( PRESET.S0, full_RootPath );
				s.Replace( PRESET.S1, FileNamePrefix );
				s.Replace( PRESET.S2, file_Name );
				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Fully-qualified connection string for the [debug version] of the database file.
		/// </summary>
		public string FullyQualifiedConnectionString
		{
			get
			{
				STRING s = new STRING( provider_Pattern );
				s.Replace( PRESET.S0, FullyQualifiedFileName );
				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// The database name that appears on the interface.
		/// Identifies the target database as the DEBUG version.
		/// </summary>
		public string PartiallyQualifiedFileName
		{
			get
			{
				STRING s = new STRING( abbreviated_Pattern );
				s.Replace( PRESET.S0, FileNamePrefix );
				s.Replace( PRESET.S1, header_Text );
				return s.ToString();
			}
		}

#else
		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Constants that are specific to a RELEASE compile & connection.
		/// </summary>
		private const string file_Name					= "VCF Builder.accdb";
		private const string header_Text				= "VCF Builder";
		private const string git_Commit					= "77009a9; 16 July 26, 6:25 pm";
		private const string fullyqualified_Pattern		= "#0#1 #2";
		private const string abbreviated_Pattern		= @"C:\...ContactsManager...\#0 #1, (RELEASE Commit: #2)";

		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Fully-qualified connection string for the [release version] of the database file.
		/// </summary>
		public string FullyQualifiedFileName
		{
			get
			{
				STRING s = new STRING( fullyqualified_Pattern );
				s.Replace( PRESET.S0, full_RootPath );
				s.Replace( PRESET.S1, FileNamePrefix );
				s.Replace( PRESET.S2, file_Name );
				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Fully-qualified connection string for the [release version] of the database file.
		/// </summary>
		public string FullyQualifiedConnectionString
		{
			get
			{
				STRING s = new STRING( provider_Pattern );
				s.Replace( PRESET.S0, FullyQualifiedFileName );
				return s.ToString();
			}
		}
		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// The database name that appears on the interface.
		/// Identifies the target database as the RELEASE version.
		/// </summary>
		public string PartiallyQualifiedFileName
		{
			get
			{
				STRING s = new STRING( abbreviated_Pattern );
				s.Replace( PRESET.S0, FileNamePrefix );
				s.Replace( PRESET.S1, header_Text );
				s.Replace( PRESET.S2, git_Commit );
				return s.ToString();
			}
		}
#endif
	}
}
