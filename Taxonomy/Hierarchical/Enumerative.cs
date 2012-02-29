
using System;
using System.Collections.Generic;

namespace Frapes.Taxonomy.Hierarchical
{
	
	
	/// <summary>
	/// Class for Enumerative strategies. Must have the specifications defined by the IStaticOptimal and
	/// IStaticSubOptimalApproximate interfaces
	/// </summary>
	public abstract class Enumerative : IStaticOptimal, IStaticSubOptimalApproximate
	{
		
		public Enumerative ()
		{
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
			return string.Format("[IStaticOptimal, IStaticSubOptimalApproximate]: [Enumerative]");
		}
	}
}
