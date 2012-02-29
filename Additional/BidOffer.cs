
using System;

namespace Frapes.Additional
{
	
	/// <summary>
	/// BidOffer associated with a Bidding strategy
	/// </summary>
	public class BidOffer
	{
		
		private string _id;
		private string _processid;
		
		//// <value>
		/// The identification of the BidOffer.
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
		
		//// <value>
		/// The identification of the associated Process.
		/// </value>
		public string ProcessId
		{
			get
			{
				return this._processid;
			}
			set
			{
				this._processid = value;
			}
		}
		
		public BidOffer ()
		{
		}
	}
}
