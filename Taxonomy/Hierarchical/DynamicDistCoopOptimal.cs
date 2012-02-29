
using System;
using System.Collections.Generic;

namespace Frapes.Taxonomy.Hierarchical
{
	
	/// <summary>
	/// Class for Dynamic Distributed Cooperative Optimal strategies. Must have the specifications 
	/// defined by the IDynamicDistCoop interface
	/// </summary>	
	public abstract class DynamicDistCoopOptimal : IDynamicDistCoop
	{
		
		public DynamicDistCoopOptimal ()
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
			return string.Format("[DynamicDistCoopOptimal]");
		}
	}
}
