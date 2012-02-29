
using System;
using System.Collections.Generic;
using Frapes;
using Frapes.Taxonomy.Hierarchical;

namespace Frapes.Algorithms
{
	
	
	/// <summary>
	/// First Come First Serve algorithm.
	/// Based on the example provided by SchedSim, by Stefan Wildemann.
	/// </summary>
	public class FirstComeFirstServe : QueuingTheory
	{
		
		public FirstComeFirstServe ()
		{
		}
		
		public override string ToString ()
		{
			return string.Format (base.ToString () + ": First Come First Serve");
		}
		
		public override BasicProcess Schedule (List<BasicProcess> processes)
		{
			BasicProcess result = new BasicProcess ();
			
			for (int i = 0; i < processes.Count; i++)
			{
				if (processes[i].State == Defines.Ready)
				{
					if (result.ProcessId != 0)
					{
						if (processes[i].ReadyTime < result.ReadyTime)
						{
							result = processes[i];
						}
					}
					else
					{
						result = processes[i];
					}
				}
			}
			
//			Console.WriteLine (this.ToString () + ": Selected Process: " + result.ProcessId);
			return result;
		}
		
		public override bool IsPreemptive ()
		{
			return false;
		}	
	}
}
