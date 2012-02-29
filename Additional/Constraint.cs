
using System;

namespace Frapes.Additional
{
	
	
	public class Constraint
	{
		private string _name;
		private string _value;
		
		//// <value>
		/// The name of the Constraint.
		/// </value>
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		
		//// <value>
		/// The value of the Constraint.
		/// </value>
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}
		
		public Constraint ()
		{
		}
	}
}
