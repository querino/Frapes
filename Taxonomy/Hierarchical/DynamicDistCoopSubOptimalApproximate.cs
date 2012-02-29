
using System;
using System.Collections.Generic;

namespace Frapes.Taxonomy.Hierarchical
{
	
	/// <summary>
	/// Class for Dynamic Distributed Cooperative SubOptimal Approximate strategies. 
	/// Must have the specifications defined by the IDynamicDistributedCoopSubOptimal interface
	/// </summary>	
	public abstract class DynamicDistCoopSubOptimalApproximate : IDynamicDistCoopSubOptimal
	{
		
		public DynamicDistCoopSubOptimalApproximate ()
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
			return string.Format("[DynamicDistCoopSubOptimalApproximate]");
		}		
	}
		
}
