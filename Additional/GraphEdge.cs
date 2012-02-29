
using System;

namespace Frapes.Additional
{
	
	/// <summary>
	/// An Edge of the graph, containing the Id of the nodes connected to it.
	/// </summary>
	public class GraphEdge
	{
		private string _graphnodea;
		private string _graphnodeb;
		
		//// <value>
		/// The identifier of the graph node
		/// </value>
		public string GraphNodeA
		{
			get
			{
				return this._graphnodea;
			}
			set
			{
				this._graphnodea = value;
			}
		}
		
		//// <value>
		/// The identifier of the Graph Node
		/// </value>
		public string GraphNodeB
		{
			get
			{
				return this._graphnodeb;
			}
			set
			{
				this._graphnodeb = value;
			}
		}
		
		public GraphEdge ()
		{
		}
	}
}
