//___________________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL
{
	//___________________________________________________________________________________________________________________________________________________
	public static class StartupManager
	{
		//___________________________________________________________________________________________________________________________________________________
		public enum StartupForm
		{
			Overseer,
			Person,
			Group,
			Family,
			Address,
			Device,
			FindPerson,
			FindGroup,
			FindAddress,
			FindDevice
		};

		#if DEBUG
		private static StartupForm startup_Interface = StartupForm.Family;
		#else
		private static StartupForm startup_Interface = StartupForm.Overseer;
		#endif

		//___________________________________________________________________________________________________________________________________________________
		public static StartupForm StartUpInterface
		{
			get { return startup_Interface; }
		}
	}
	//TODO: Standardise across all forms the "is enabled/disabled" approach.


	//_______________________________________________________________________________________________
	/// <summary>
	/// This enum is supposed to companion every value object and report on its USABILTY (i.e., its NULL) state.
	///	For reference types (DateTime, String):
	///		For a blank value in a Access TableView, OleDbDateReader.IsDBNull will return TRUE.
	///	
	/// For value types (basically everything else):
	///		For a blank value in an Access TableView, OleDbDateReader.IsDBNull returns FALSE.
	///		It returns false because Access stores a actual value which (for int) is -1 which is a valid, non-null integer value 
	///		and therefore OleDbDateReader.IsDBNull returns FALSE even if the server-side field is visual 'blank'.
	///		
	///		What makes it worse is that the value returned is a valid value of the type; e.g., a 'blank' int field
	///		returns -1 which is a valid, non-null int which can be validly stored as a valid data value in a Access, non-blank field.
	///		Relying on -1 as a signal value only makes sense if the developer KNOWS FOR ABSOLUTE, ROCK-SOLID CERTAIN
	///		that the source column does not contain, and will never contain, any, -ve values, in particular, -1.
	///		One would think Access could somehow compensate for this but it doesn't. After all, Access knows the field is blank
	///		and therefore knows that it is 'null' and therefore knows to display blank. But, for some reason, when the value needs to go to
	///		a client all bets are off. OleDbDateReader.IsDBNull should be exactly what it says: Does Access' flag the current row/column as "visual blank"?
	///		But it doesn't. In other words, they dropped their too-hard basket on me and didn't bother to tell me (at least not in any obvious way).
	///		
	///		And none of this applies to value type boolean for which only 2 values are available and 'visual blank'
	///		'correctly' crosses the server/client boundary by interpreting 'blank' as false.
	/// </summary>
	public enum Nullity
	{
		//___________________________________________________________________________________________
		/// <summary>
		///		DbNull must be applied after the value is assessed by type (value cf reference).
		///		A value is only considered to be NULL (DbNull) if:
		///			it is a reference type it is actual null,
		///			it is a value type and the db reader has returned the signal ("Hey! Look at me! I'm really NULL!!") value,
		///			it is a value type for which the intended, actual, non-null value == the signal value,
		///			then you throw up your hands in horror and sue MS for life-deforming emotional stress bordering on lunacy ... .
		///
		///		This should probably be something like: Value_Reference_Agnostic_Actual_Honest_To_Goodness_UNUSABLE_that_is_to_say_NULL_Value.
		///		More seriously, "ActualNull" would be better. This name arose from what was misunderstood to be the close connection between
		///		OleDbDateReader.IsDBNull and the null state of the value returned from the server.
		/// </summary>
		DbNull,

		//___________________________________________________________________________________________
		/// <summary>
		/// Value is non-null, non-default but has some characteristic that prevents its use.
		/// EG: a DateTime value that cannot be displayed in a DateTime combobox.
		/// </summary>
		FunctionalNull,

		//___________________________________________________________________________________________
		/// <summary>
		/// An ordinary, plain ol' warm 'n fuzzy, not null, usable value, ... phew... finally.
		/// But don't be complacent about this. It's watching you and as soon as that I'm-smarter-than-you schtick
		/// creeps over you, it will come back bite you in the butt.
		/// </summary>
		NotNull
	};
}
