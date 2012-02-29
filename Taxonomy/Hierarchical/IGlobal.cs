
using System;
using System.Collections.Generic;
using Frapes;

namespace Frapes.Taxonomy.Hierarchical
{
		
	/// <summary>
	/// Basic interface for Global strategies
	/// </summary>
	public interface IGlobal
	{	
		bool IsPreemptive ();
		BasicProcess Schedule (List<BasicProcess> processes);
	}
}
