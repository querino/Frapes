
using System;
using Frapes.Additional;

namespace Frapes.Taxonomy.Flat
{
	
	
	/// <summary>
	/// Class for bidding algorithms.
	/// </summary>
	public abstract class Bidding
	{
		
		public Bidding ()
		{
		}
		
		public bool SendTaskOffer (TaskOffer taskoffer)
		{
			return true;	
		}
		
		public BidOffer ReceiveBidOffer ()
		{
			BidOffer bidoffer = new BidOffer ();
			return bidoffer;
		}
	}
}
