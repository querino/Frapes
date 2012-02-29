
using System;
using Frapes.Additional;
using System.Collections.Generic;

namespace Frapes.Taxonomy.Hierarchical
{

	/// <summary>
	/// Class for GraphTheory strategies. Must have the specifications defined by the IStaticOptimal and
	/// IStaticSubOptimalApproximate interfaces
	/// </summary>	
	public abstract class GraphTheory : IStaticOptimal, IStaticSubOptimalApproximate
	{
		/// <summary>
		/// The graph associated with the strategy.
		/// </summary>
		private Graph Graph;
		
		public GraphTheory (Graph graph)
		{
			this.Graph = graph;
		}
		
		public virtual BasicProcess Schedule (List<BasicProcess> processes)
		{
			if (this.Graph != null)
			{
				return processes[0];
			}
			else
			{
				return null;
			}
		}	

		public virtual bool IsPreemptive ()
		{
			return true;
		}
		
		public override string ToString ()
		{
			return string.Format("[IStaticOptimal, IStaticSubOptimalApproximate]: [GraphTheory]");
		}
	}
}
