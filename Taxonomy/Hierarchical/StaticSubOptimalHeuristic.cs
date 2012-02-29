
using System;
using System.Collections.Generic;

using Frapes;
using Frapes.Additional;

namespace Frapes.Taxonomy.Hierarchical
{
	/// <summary>
	/// Class for Enumerative strategies. Must have the specifications defined by the IStaticSubOptimal 
	/// interface
	/// </summary>
	public class StaticSubOptimalHeuristic : IStaticSubOptimal
	{
		public Heuristic AlgorithmHeuristic;
		
		public StaticSubOptimalHeuristic (Heuristic heuristic)
		{
			this.AlgorithmHeuristic = heuristic;
		}
		
		public virtual BasicProcess Schedule (List<BasicProcess> processes)
		{
			return processes[0];
		}
		
		public virtual bool IsPreemptive ()
		{
			return true;
		}		
		
		public override string ToString ()
		{
			return string.Format("[IStaticSubOptimal]: [StaticSubOptimalHeuristic]");
		}

	}
}
