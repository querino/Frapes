
using System;
using System.Collections.Generic;
using Frapes.Taxonomy.Hierarchical;

namespace Frapes.Algorithms
{
	
	
	public class RoundRobin : DynamicNonDist
	{
		private int RoundRobinValue = 0;
		
		public RoundRobin ()
		{
		}
		
		public override BasicProcess Schedule (List<BasicProcess> processes)
		{
			BasicProcess result = new BasicProcess ();
			
			if (this.RoundRobinValue >= processes.Count)
			{
				this.RoundRobinValue = 0;
			}
			for (int i = 0; i < processes.Count; i++)
			{
				if (this.RoundRobinValue == processes.Count)
				{
					this.RoundRobinValue = 0;
				}
				if (processes[this.RoundRobinValue].State == Defines.Ready)
				{
					result = processes[this.RoundRobinValue];
					this.RoundRobinValue++;
					break;
				}
				this.RoundRobinValue++;
			}
//			Console.WriteLine (this.ToString () + ": Selected Process: " + result.ProcessId);
			return result;
		}
		
		public override string ToString ()
		{
			return string.Format(base.ToString () + ": [RoundRobin]");
		}
	}
}
