
using System;
using System.Collections.Generic;

namespace Frapes.Additional
{
	
	/// <summary>
	/// Class used to represent a graph.
	/// </summary>
	public class Graph
	{	
		/// <summary>
		/// The list of Graph Nodes inside the graph.
		/// </summary>
		/// <param name="graphnode">
		/// A <see cref="GraphNode"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public List<GraphNode> GraphNodes = new List<GraphNode> ();
		
		/// <summary>
		/// Adds a Graph Node to the graph.
		/// </summary>
		/// <param name="graphnode">
		/// A <see cref="GraphNode"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool AddGraphNode (GraphNode graphnode)
		{
			bool result = true;
			this.GraphNodes.Add(graphnode);
			return result;
		}
		
		/// <summary>
		/// Removes a Graph Node from the Graph
		/// </summary>
		/// <param name="graphnode">
		/// A <see cref="GraphNode"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool RemoveGraphNode (GraphNode graphnode)
		{
			bool result = false;
			
			if (this.GraphNodes.Contains (graphnode))
			{
				this.GraphNodes.Remove (graphnode);
				result = true;
			}
			return result;
		}
		
		public Graph ()
		{
			this.GraphNodes = new List<GraphNode> ();
		}
	}
}
