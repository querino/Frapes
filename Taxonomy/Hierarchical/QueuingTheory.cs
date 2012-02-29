
using System;
using System.Collections.Generic;

namespace Frapes.Taxonomy.Hierarchical
{
	
	/// <summary>
	/// Class for QueuingTheory strategies. Must have the specifications defined by the IStaticOptimal and
	/// IStaticSubOptimalApproximate interfaces
	/// </summary>		
	public class QueuingTheory : IStaticOptimal, IStaticSubOptimalApproximate
	{
		
		public QueuingTheory ()
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
			return string.Format("[IStaticOptimal, IStaticSubOptimalApproximate]: [QueuingTheory]");
		}
	}
}
