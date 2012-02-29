
using System;

namespace Frapes.Additional
{
	
	/// <summary>
	/// A graph node inside a Graph
	/// </summary>
	public class GraphNode
	{
		private string _id;
		private string _value;
		
		//// <value>
		/// The identification of the graph node.
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
		/// The value associated with the graph node.
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
		
		public GraphNode ()
		{
		}
	}
}
