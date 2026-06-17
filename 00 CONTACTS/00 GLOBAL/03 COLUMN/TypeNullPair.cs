//_______________________________________________________________________________________________________________________________________________
using System;
//GLOBAL
using NULLITY = CONTACTS.GLOBAL.Nullity;

//_______________________________________________________________________________________________________________________________________________
namespace CONTACTS.GLOBAL.DATABASE.COLUMN
{
	//_______________________________________________________________________________________________________________________________________________
	public class TypeNullPair<T>
	{
		private T _value;
		private NULLITY _nullity;

		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Value:		unassigned.
		/// Nullity:	DbNull
		/// </summary>
		public TypeNullPair()
		{
			_nullity = NULLITY.DbNull;
		}
		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Value:		value.
		/// Nullity:	DbNull
		/// </summary>
		public TypeNullPair( T value )
		{
			_value = value;
			_nullity = NULLITY.DbNull;
		}
		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Value:		value.
		/// Nullity:	nullity
		/// </summary>
		public TypeNullPair( T value, NULLITY nullity )
		{
			_value = value;
			_nullity = nullity;
		}
		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Gets & sets type agnostic value
		/// </summary>
		public T Value
		{
			get { return _value; }
			set { _value = value; }
		}
		//_______________________________________________________________________________________________________________________________________________
		/// <summary>
		/// Gets & sets Nullity value.
		/// </summary>
		public NULLITY NullState
		{
			get { return _nullity; }
			set { _nullity = value; }
		}
	}
}
