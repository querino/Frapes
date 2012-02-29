
using System;
using System.Collections.Generic;
using Frapes.Additional;

namespace Frapes.Taxonomy.Flat
{
	
	// Class for adaptive algorithms
	public abstract class LoadBalancing
	{
		private Graph LoadBalanceGraph = new Graph ();
		
		public LoadBalancing (Graph graph)
		{
			this.LoadBalanceGraph = graph;
		}
		
		public void TraverseGraph()
		{
			for (int i = 0; i < this.LoadBalanceGraph.GraphNodes.Count; i++)
				Console.WriteLine (this.LoadBalanceGraph.GraphNodes[i].Id);
		}
	}
}
