
using System;
using System.Collections.Generic;
using Frapes.Additional;

namespace Frapes.Taxonomy.Hierarchical
{
	
	
	/// <summary>
	/// Class for Enumerative strategies. Must have the specifications defined by the IStaticOptimal and
	/// IStaticSubOptimalApproximate interfaces
	/// </summary>
	public class MathProgramming : IStaticOptimal, IStaticSubOptimalApproximate
	{
		
		private CostFunction MathCostFunction = new CostFunction ();
		
		/// <summary>
		/// Default constructor for the MathProgramming
		/// </summary>
		/// <param name="costfunction">
		/// A <see cref="CostFunction"/>
		/// </param>
		public MathProgramming (CostFunction costfunction)
		{
			this.MathCostFunction = costfunction;
		}
		
		public virtual BasicProcess Schedule (List<BasicProcess> processes)
		{
			if (this.MathCostFunction.Id != null)
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
			return string.Format("[IStaticOptimal, IStaticSubOptimalApproximate]: [MathProgramming]");
		}
	}
}
