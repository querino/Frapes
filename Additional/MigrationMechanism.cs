
using System;
using Frapes;

namespace Frapes.Additional
{
	
	/// <summary>
	/// Provides access to a migration mechanism needed by Distribited algorithms.
	/// </summary>
	public class MigrationMechanism
	{
		
		public MigrationMechanism ()
		{
		}
		
		public bool Migrate (BasicProcess process)
		{
			return true;
		}
	}
}
