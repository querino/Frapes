
using System;

namespace Frapes.Additional
{
	
	/// <summary>
	/// This class is used to identify a requirement associated with a task(process)
	/// </summary>
	public class TaskOfferRequirement
	{
		private string _name;
		private string _value;
		
		//// <value>
		/// The name associated with the TaskRequirement
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
		/// The value associated with the TaskRequirement
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
		
		public TaskOfferRequirement ()
		{
		}
	}
}
