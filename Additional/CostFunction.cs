
using System;
using System.Collections.Generic;

namespace Frapes.Additional
{
	
	
	public class CostFunction
	{
		private string _id;
		
		//// <value>
		/// The identificatio of the CostFunction.
		/// </value>
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		/// <summary>
		/// List of constraints to be evaluated by the CostFunction.
		/// </summary>
		public List<Constraint> Constraints = new List<Constraint> ();
		
		public CostFunction ()
		{
		}
	}
}
