
using System;
using System.Collections.Generic;
using Frapes.Additional;

namespace Frapes.Taxonomy.Hierarchical
{
	
	/// <summary>
	/// Class for Dynamic Distributed Cooperative SubOptimal Heuristica strategies. 
	/// Must have the specifications defined by the IDynamicDistCoopSubOptimal
	/// </summary>	
	public abstract class DynamicDistCoopSubOptimalHeuristic : IDynamicDistCoopSubOptimal
	{
		
		private Heuristic Heuristic;
		
		public DynamicDistCoopSubOptimalHeuristic (Heuristic heuristic)
		{
			this.Heuristic = heuristic;
		}
		
		public virtual BasicProcess Schedule (List<BasicProcess> processes)
		{
			if (this.Heuristic != null)
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
			return string.Format("[DynamicDistCoopSubOptimalHeuristic]");
		}
	}
}
