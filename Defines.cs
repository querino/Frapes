
using System;

namespace Frapes
{
	
	/// <summary>
	/// Defines for several process state possibilities
	/// </summary>
	public static class Defines
	{
		public const int Running = 1;
		public const int NotReady = 2;
		public const int Ready = 3;
		public const int Finished = 4;
		public const int Blocked = 5;
		
		public const int PreemptiveProcessFinishedOrBlocked = 1;
		public const int PreemptiveTimesliceEnd = 2;
		public const int PreemptiveTimesliceContinued = 3;
		public const int NonPreemptiveProcessFinishedOrBlocked = 4;
		public const int NonPreemptiveProcessContinued = 5;
		
		/// <summary>
		/// Should Frapes run in Debug mode? If true, messages will be shown
		/// in the Console window.
		/// </summary>
		public const bool DebugMode = true;
		
		/// <summary>
		/// Include here the names of all the available strategies
		/// </summary>
		public static string[] AvailableSchedulers = {"First Come First Serve",
											   "Round Robin"};
		
	}
}
