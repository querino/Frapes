
using System;

namespace Frapes
{
	
	/// <summary>
	/// This class is used to represent a processing node inside the system.
	/// </summary>
	public class BasicNode
	{
		
		private int _nodeid;
		private int _status = Defines.Ready;
		private int _timeslice;
		private int _actualtimeslice;
		private BasicProcess _lastscheduled;
		private int _override;
		
		public int NodeId
		{
			get
			{
				return _nodeid;
			}
			set
			{
				_nodeid = value;
			}
		}
		
		public int Status
		{
			get
			{
				return _status;
			}
			set
			{
				_status = value;
			}
		}
		
		public int TimeSlice
		{
			get
			{
				return _timeslice;
			}
			set
			{
				_timeslice = value;
			}
		}
		
		public int ActualTimeSlice
		{
			get
			{
				return _actualtimeslice;
			}
			set
			{
				_actualtimeslice = value;
			}
		}
		
		public BasicProcess LastScheduled
		{
			get
			{
				return _lastscheduled;
			}
			set
			{
				_lastscheduled = value;
			}
		}
		
		public int Override
		{
			get
			{
				return _override;
			}
			set
			{
				_override = value;
			}
		}
		
		/// <summary>
		/// Labels to the required node information.
		/// </summary>
		public static string[] NodeLabels = {"Node Id", "Timeslice"};
		
		/// <summary>
		/// Default empty constructor for the Basic Node
		/// </summary>
		public BasicNode ()
		{
		}
		
		/// <summary>
		/// Constructor for a new node, with basic information.
		/// </summary>
		/// <param name="nodeid">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="timeslice">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="status">
		/// A <see cref="System.Int32"/>
		/// </param>
		public BasicNode (int nodeid, int timeslice, int status)
		{
			this.NodeId = nodeid;
			this.TimeSlice = timeslice;
			this.Status = status;
			this.LastScheduled = new BasicProcess (0, 0, 0, 0, 0);
		}
		
		/// <summary>
		/// Used to create a copy of an existing node
		/// </summary>
		/// <param name="N">
		/// A <see cref="BasicNode"/>
		/// </param>
		public BasicNode (BasicNode N)
		{
			this.NodeId = N.NodeId;
			this.TimeSlice = N.TimeSlice;
			this.Status = N.Status;
			this.ActualTimeSlice = N.ActualTimeSlice;
			this.LastScheduled = N.LastScheduled;
			this.Override = N.Override;
		}
		
		/// <summary>
		/// Returns a string with basic node information.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		public override string ToString ()
		{
			return string.Format ("[BasicNode: NodeId={0}, Status={1}, TimeSlice={2}, ActualTimeSlice={3}, LastScheduled={4}, Override={5}]", NodeId, Status, TimeSlice, ActualTimeSlice, LastScheduled, Override);
		}
	}
}
