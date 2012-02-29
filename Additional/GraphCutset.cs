
using System;
using System.Collections.Generic;

namespace Frapes.Additional
{
	
	
	/// <summary>
	/// Class used to define the cutset inside a Graph.
	/// </summary>
	public class GraphCutset
	{
		
		/// <summary>
		/// The list of graph nodes inside the Cutset.
		/// </summary>
		public List<GraphNode> CutsetNodes = new List<GraphNode> ();
		
		public GraphCutset ()
		{
		}
	}
}
