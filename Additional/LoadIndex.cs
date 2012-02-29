
using System;

namespace Frapes.Additional
{
	
	
	/// <summary>
	/// Class used to define a Load Index used by some strategies.
	/// </summary>
	public class LoadIndex
	{
		private string _id;
		
		//// <value>
		/// The identification of the Load Index.
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
		
		public LoadIndex()
		{
		}
		
		/// <summary>
		/// Calculates the load index.
		/// </summary>
		/// <returns>
		/// A <see cref="System.Int32"/>
		/// </returns>
		public int Calculate ()
		{
			return 0;
		}
	}
}
