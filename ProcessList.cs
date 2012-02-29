
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Frapes
{
	/// <summary>
	/// This class contains the a list of Processes on the system, as well as a list of
	/// Processes currently running.
	/// </summary>
	public class ProcessList
	{
		/// <summary>
		/// Maximum Process Identifier on the list
		/// </summary>
		private int MaxProcessId = 0;
		/// <summary>
		/// The actual list of Processes
		/// </summary>
		private List<BasicProcess> Processes = new List<BasicProcess> ();
		/// <summary>
		/// The list of processes in running state
		/// </summary>
		private List<BasicProcess> RunningProcesses = new List<BasicProcess> ();
		
		// EXISTENTE NO ARQUIVO ORIGINAL
		// ProcessList (SchedulerInterface Interface)
		// {
		//      this.MyInterface = Interface;
		// }
		
		/// <summary>
		/// Method used to obtain a list of current processes
		/// </summary>
		/// <returns>
		/// A <see cref="List"/>
		/// </returns>
		public List<BasicProcess> GetAllProcesses ()
		{
			return this.Processes;	
		}
		
		/// <summary>
		/// Adds a process to the list
		/// </summary>
		/// <param name="process">
		/// A <see cref="BasicProcess"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool AddProcess (BasicProcess process)
		{
			bool result = true;
			
			// If List is empty
			if (this.Processes.Count == 0)
			{
				this.MaxProcessId = 0;
			}
			
			// Is the process passed as a paramater already in the list?
			if (!(this.Processes.Contains (process)))
			{
				this.MaxProcessId++; // Generate next process id
				process.ProcessId = this.MaxProcessId;
				process.Sort = process.ProcessId;
				
				this.Processes.Add (process);
				
				try	
				{
					BasicProcess runningProcess = new BasicProcess (process);
					if (this.RunningProcesses.Count == 0)
					{
						this.RunningProcessesReset ();
					}
					else
					{
						this.RunningProcesses.Add (runningProcess);
					}
				}
				catch (Exception e)
				{
					if (Defines.DebugMode)
					{
						Console.WriteLine ("ProcessList: Exception: " + e.ToString ());
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}
		
		/// <summary>
		/// Removes a process from the list
		/// </summary>
		/// <param name="process">
		/// A <see cref="BasicProcess"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool RemoveProcess (BasicProcess process)
		{
			bool result = false;
			
			if (this.Processes.Contains (process))
			{
				if (process.ProcessId == this.MaxProcessId)
				{
					this.MaxProcessId--;
				}
				this.Processes.Remove (process);
				result = true;
			}
			else
			{
				result = false;
			}
			// Removing of process from the RunningProcess list can only be done
			// using the RunningProcessesReset() method.
			return result;
		}
		
		/// <summary>
		/// Clears both the Processes and RunningProcesses lists.
		/// </summary>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool RemoveAll ()
		{
			this.Processes = new List<BasicProcess> ();
			this.RunningProcesses = new List<BasicProcess> ();
			this.MaxProcessId = 0;
			return true;
		}
		
		/// <summary>
		/// Resets the running process list, copying the processes from the Processes list.
		/// </summary>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool RunningProcessesReset ()
		{
			bool result = false;
			this.RunningProcesses = new List<BasicProcess> ();
			if (this.Processes.Count > 0)
			{
				try
				{
					for (int i = 0; i < this.Processes.Count; i++)
					{
						BasicProcess proc = new BasicProcess (this.Processes[i]);
						this.RunningProcesses.Add (proc);
					}
					result = true;
				}
				catch (Exception e)
				{
					if (Defines.DebugMode)
					{
						Console.WriteLine ("ProcessList.RunningProcessesReset: Exception: " + e.ToString ());
						this.RunningProcesses.Clear ();
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}
		
		/// <summary>
		/// Used to call the UpdateStatistics method for each process in the RunningProcesses list
		/// </summary>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool RunningProcessesUpdateStat ()
		{
			bool result = true;
			
			if (this.RunningProcesses.Count > 0)
			{
				for (int i = 0; i < this.RunningProcesses.Count; i++)
				{
					this.RunningProcesses[i].UpdateStatistics ();
				}
			}
			return result;
		}
		
		/// <summary>
		/// Returns a BasicProcess from the RunningProcesses list according to the
		/// processid passed.
		/// </summary>
		/// <param name="processid">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <returns>
		/// A <see cref="BasicProcess"/>
		/// </returns>
		public BasicProcess GetRunningProcess (int processid)
		{
			BasicProcess result = null;
			
			if (this.RunningProcesses.Count > 0)
			{
				for (int i = 0; i < this.RunningProcesses.Count; i++)
				{
					if (this.RunningProcesses[i].ProcessId == processid)
					{
						result = this.RunningProcesses[i];
					}
				}
			}
			if (result == null)
			{
				throw new Exception("No process with the specified Id found in the RunningProcesses list");
			}
			return result;
		}
		
		/// <summary>
		/// Returns the list of running processes.
		/// </summary>
		/// <returns>
		/// A <see cref="List"/>
		/// </returns>
		public List<BasicProcess> GetAllRunningProcesses ()
		{
			return this.RunningProcesses;
		}
		
		/// <summary>
		/// Removes a process from the RunningProcesses list
		/// </summary>
		/// <param name="process">
		/// A <see cref="BasicProcess"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool RemoveRunningProcess (BasicProcess process)
		{
			bool result = true;
			if (this.RunningProcesses.Contains (process))
			{
				this.RunningProcesses.Remove (process);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}
		
		//// <value>
		/// The number of processes on the list
		/// </value>
		public int Count
		{
			get
			{
				return this.Processes.Count;
			}
		}
		
		/// <summary>
		/// Removes the process at the given position.
		/// </summary>
		/// <param name="pos">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool RemoveAt (int pos)
		{
			this.Processes.RemoveAt (pos);
			return true;
		}
		
		/// <summary>
		/// Saves the process list to a Xml file specified as a parameter
		/// </summary>
		/// <param name="filename">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool SaveToXml (string filename)
		{
			XmlSerializer serializer = new XmlSerializer (typeof(List<BasicProcess>));
			TextWriter tw = new StreamWriter (@filename);
			serializer.Serialize (tw, this.GetAllProcesses ());
			tw.Close ();
			return true;
		}
		
		/// <summary>
		/// Loads the process list from a Xml file specified as a parameter.
		/// </summary>
		/// <param name="filename">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool LoadFromXml (string filename)
		{
			XmlSerializer deserializer = new XmlSerializer (typeof(List<BasicProcess>));
			TextReader tr = new StreamReader (@filename);
			this.Processes = (List<BasicProcess>) deserializer.Deserialize (tr);
			this.MaxProcessId = this.Processes.Count;
			tr.Close ();	
			return true;
		}
	}
}
