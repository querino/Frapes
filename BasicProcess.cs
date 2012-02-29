
using System;

namespace Frapes
{		
	/// <summary>
	/// This class is used to represent a process in the system.
	/// </summary>
	public class BasicProcess
	{
		private int _state = Defines.NotReady;
		private int _processid = 0;
		private int _readytime = 0;
		private int _deadlinetime = 0;
		private int _executiontime = 0;
		private int _priority = 0;
		private int _sort = 0;
		private int _blockingtime = 0;
		private int _blockinglength = 0;
		
		/// <value>
		/// Indicates the process current state. It should be set
		/// to a constant declare on the Defines class.
		/// </value>
		public int State
		{
			get { return _state; }
			set { _state = value; }
		}
		
		/// <value>
		/// The Process Identifier, unique to each process on the system.
		/// </value>
		public int ProcessId
		{
			get { return _processid; }
			set { _processid = value; }
		}
		
		/// <value>
		/// The amount of system time units required for the process to become ready
		/// for execution. 
		/// </value>
		public int ReadyTime
		{
			get { return _readytime; }
			set { _readytime = value; }
		}
		
		/// <value>
		/// The maximum amount of system time units for the process to complete execution.
		/// </value>
		public int DeadlineTime
		{
			get { return _deadlinetime; }
			set { _deadlinetime = value; }
		}
	
		/// <value>
		/// The total time units passed since the process started execution.
		/// </value>
		public int ExecutionTime
		{
			get { return _executiontime; }
			set { _executiontime = value; }
		}

		//// <value>
		/// Represents the process priority
		/// </value>
		public int Priority
		{
			get { return _priority; }
			set { _priority = value; }
		}
		
		//// <value>
		/// Order of the process
		/// </value>
		public int Sort
		{
			get { return _sort; }
			set { _sort = value; }
		}
		
		//// <value>
		/// Time units when the process will be blocked.
		/// </value>
		public int BlockingTime
		{
			get { return _blockingtime; }
			set { _blockingtime = value; }
		}
		
		//// <value>
		/// How long the blocking will take.
		/// </value>
		public int BlockingLength
		{
			get { return _blockinglength; }
			set { _blockinglength = value; }
		}
		
		/// <summary>
		/// Array of strings with the Process properties labels.
		/// </summary>
		public static string[] ProcessLabels = {"Process Id", "Ready Time", "Exec Time", "Deadline Time", "Priority", "Blocking Time", "Blocking Length"};

		/// <summary>
		/// Default constructor method for the BasicProcess class.
		/// </summary>
		public BasicProcess ()
		{
		}
		
		/// <summary>
		/// Constructor that sets default values.
		/// </summary>
		/// <param name="procId">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="readyTime">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="execTime">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="deadlineTime">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="priority">
		/// A <see cref="System.Int32"/>
		/// </param>
		public BasicProcess (int procId, int readyTime, int execTime, int deadlineTime, int priority)
		{
			this.ProcessId = procId;
			this.ReadyTime = readyTime;
			this.DeadlineTime = deadlineTime;
			this.ExecutionTime = execTime;
			this.Priority = priority;
			
			// process may be already ready
			if (this.ReadyTime <= 0)
				this.State = Defines.Ready;
			
			// process may have finished
			if (this.ExecutionTime <= 0)
				this.State = Defines.Finished;
		}
		
		/// <summary>
		/// Constructor that sets default values for processes with a Blocking time and length.
		/// </summary>
		/// <param name="procId">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="readyTime">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="execTime">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="deadlineTime">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="priority">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="blockingTime">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="blockingLength">
		/// A <see cref="System.Int32"/>
		/// </param>
		public BasicProcess (int procId, int readyTime, int execTime, int deadlineTime, int priority, int blockingTime, int blockingLength)
		{
			this.ProcessId = procId;
			this.ReadyTime = readyTime;
			this.DeadlineTime = deadlineTime;
			this.ExecutionTime = execTime;
			this.Priority = priority;
			this.BlockingTime = blockingTime;
			this.BlockingLength = blockingLength;
			
			// Process may be running
			if (this.ReadyTime <= 0)
			{
				this.State = Defines.Ready;
				// Process may be blocked already (very unlikely, but...)
				if ((this.BlockingTime == 0) && (this.BlockingLength > 0))
				{
					this.State = Defines.Blocked;
				}
			}
			
			// Process may have finished
			if (this.ExecutionTime <= 0)
			{
				this.State = Defines.Finished;
			}
		}

		/// <summary>
		/// Constructor that sets default values for processes with a Blocking time and length, and a sort value.
		/// </summary>
		/// <param name="procId">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="readyTime">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="execTime">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="deadlineTime">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="priority">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="blockingTime">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="blockingLength">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="sort">
		/// A <see cref="System.Int32"/>
		/// </param>
		public BasicProcess (int procId, int readyTime, int execTime, int deadlineTime, int priority, int blockingTime, int blockingLength, int sort)
		{
			this.ProcessId = procId;
			this.ReadyTime = readyTime;
			this.DeadlineTime = deadlineTime;
			this.ExecutionTime = execTime;
			this.Priority = priority;
			this.BlockingTime = blockingTime;
			this.BlockingLength = blockingLength;
			this.Sort = sort;
			
			// Process may be running
			if (this.ReadyTime <= 0)
			{
				this.State = Defines.Ready;
				// Process may be already blocked...unusual, but can happen
				if ((this.BlockingTime == 0) && (this.BlockingLength > 0))
				{
					this.State = Defines.Blocked;
				}
			}
			
			// process may be finished
			if (this.ExecutionTime <= 0)
			{
				this.State = Defines.Finished;
			}
		}
		
		/// <summary>
		/// Constructor used to create a copy of an existing process
		/// </summary>
		/// <param name="process">
		/// A <see cref="BasicProcess"/>
		/// </param>
		public BasicProcess (BasicProcess process)
		{
			this.ProcessId = process.ProcessId;
			this.ReadyTime = process.ReadyTime;
			this.DeadlineTime = process.DeadlineTime;
			this.ExecutionTime = process.ExecutionTime;
			this.State = process.State;
			this.Priority = process.Priority;
			this.BlockingTime = process.BlockingTime;
			this.BlockingLength = process.BlockingLength;
		}
		
		/// <summary>
		/// Makes the process ready.
		/// </summary>
		public void SetReady ()
		{
			this.State = Defines.Ready;
		}
		
		/// <summary>
		/// It is called if the process is the actual running one.
		/// Only effective if State is Ready
		/// </summary>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool Run ()
		{
			bool result = true;
			
			if ((this.State == Defines.Ready) || (this.State == Defines.Running))
			{
				this.ExecutionTime--;
				this.ReadyTime--;
				this.DeadlineTime--;
				this.BlockingTime--;
				this.State = Defines.Running;
				
				if ((this.BlockingTime <= 0) && (this.BlockingLength > 0))
				{
					this.State = Defines.Blocked;
					this.BlockingLength++;
				}
				
				if (this.ExecutionTime <= 0)
				{
					this.State = Defines.Finished;
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}
		
		/// <summary>
		/// It is called if BasicProcess is called after every time unit.
		/// If State is Running, it sets State to Ready. Returns false if Deadline is missed and does nothing except that.
		/// </summary>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool UpdateStatistics ()
		{
			bool result = true;
			
			if (this.State == Defines.Finished)
			{
				// finished, do nothing
			}
			else if (this.State == Defines.NotReady)
			{
				this.DeadlineTime--;
				this.ReadyTime--;
				if (this.ReadyTime <= 0)
				{
					this.State = Defines.Ready;
				}
			}
			else if (this.State == Defines.Ready)
			{
				this.ReadyTime--;
				this.DeadlineTime--;
				if (this.DeadlineTime < 0)
				{
					result = false;
				}
			}
			else if (this.State == Defines.Running)
			{
				// Pocess running, do nothing
			}
			else if (this.State == Defines.Blocked)
			{
				this.DeadlineTime--;
				this.ReadyTime--;
				this.BlockingLength--;
				if (this.BlockingLength <= 0)
				{
					this.State = Defines.Ready;
					if (this.ExecutionTime == 0)
					{
						this.State = Defines.Finished;
					}
				}
			}
			return result;
		}
		
		/// <summary>
		/// Dump the necessary information according to the process State
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		public string DumpStatistics ()
		{
			string result = "Process: " + Convert.ToString (this.ProcessId) + " ";
			
			if (this.State == Defines.NotReady)
			{
				result = result + "Gets ready in " + Convert.ToString (this.ReadyTime) + " timeunits. " + "Deadline Time: " + Convert.ToString (this.DeadlineTime);
			}
			else if (this.State == Defines.Ready)
			{
				result = result + "Ready: Exec. Time: " + Convert.ToString (this.ExecutionTime) + " Deadline Time: " + Convert.ToString (this.DeadlineTime);
			}
			else if (this.State == Defines.Finished)
			{
				result = result + "Finished: Answer Time = " + Convert.ToString (-1 * this.ReadyTime);				
			}
			else if (this.State == Defines.Blocked)
			{
				result = result + "Blocked, " + Convert.ToString (this.BlockingLength) + " timeunits to go. " + " Deadline Time: " + Convert.ToString (this.DeadlineTime);
			}
			else
			{
				result = result + "Running: Exec. Time: " + Convert.ToString (this.ExecutionTime) + " Deadline Time: " + Convert.ToString (this.DeadlineTime);
			}
			
			if ((this.DeadlineTime <= 0) && (this.ExecutionTime != 0))
			{
				result = result + " DEADLINE ACHIEVED";
			}
			
			return result;
		}
		
		/// <summary>
		/// Returns a string with the BasicProcess information
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		public override string ToString ()
		{
			return string.Format ("[BasicProcess: State={0}, ProcessId={1}, ReadyTime={2}, DeadlineTime={3}, ExecutionTime={4}, Priority={5}, Sort={6}, BlockingTime={7}, BlockingLength={8}]", State, ProcessId, ReadyTime, DeadlineTime, ExecutionTime, Priority, Sort, BlockingTime, BlockingLength);
		}

	}
}
