
using System;
using System.Collections.Generic;

namespace Frapes.Taxonomy.Hierarchical
{
	
	
	public abstract class DynamicDistNonCoop : IDynamicDist
	{
		
		public DynamicDistNonCoop ()
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
			return string.Format("[IDynamicDist]: [DynamicDistNonCoop]");
		}
		
	}
}
