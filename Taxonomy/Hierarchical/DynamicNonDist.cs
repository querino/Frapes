
using System;
using System.Collections.Generic;

namespace Frapes.Taxonomy.Hierarchical
{
	
	
	public abstract class DynamicNonDist : IDynamic
	{
		
		public DynamicNonDist ()
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
			return string.Format("[IDynamic]: [DynamicNonDist]");
		}
		
	}
}
