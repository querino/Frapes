
using System;
using System.Collections.Generic;

namespace Frapes.Additional
{
	
	/// <summary>
	/// The task offer used by the Bidding algorithm.
	/// </summary>
	public class TaskOffer
	{
		
		private string _taskid;
		private DateTime _expiration;
		
		//// <value>
		/// The identification of the Task.
		/// </value>
		public string TaskId
		{
			get
			{
				return this._taskid;
			}
			set
			{
				this._taskid = value;
			}
		}
		
		//// <value>
		/// The expiration time for the task offer.
		/// </value>
		public DateTime Expiration
		{
			get
			{
				return this._expiration;
			}
			set
			{
				this._expiration = value;
			}
		}
		
		/// <summary>
		/// List of requirements associated with this TaskOffer.
		/// </summary>
		public List<TaskOfferRequirement> Requirements = new List<TaskOfferRequirement> ();
		
		public TaskOffer ()
		{
		}
	}
}
