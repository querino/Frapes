
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Frapes
{
	
	
	/// <summary>
	/// This class contains a list of processing nodes in the system;
	/// </summary>
	public class NodeList
	{
		// EXISTENTE NO ARQUIVO ORIGINAL
		// private SchedulerInterface MyInterface = null;
		
		private int MaxNodeId = 0;
		private List<BasicNode> Nodes = new List<BasicNode> ();
		
		// EXISTENTE NO ARQUIVO ORIGINAL
		// NodeList (SchedulerInterface Interface)
		// {
		//		this.MyInterface = Interface;
		// }
		
		/// <summary>
		/// Returns all the nodes from the Nodes list
		/// </summary>
		/// <returns>
		/// A <see cref="List"/>
		/// </returns>
		public List<BasicNode> GetAllNodes ()
		{
			return this.Nodes;
		}
		
		/// <summary>
		/// Used to add a node to the list.
		/// </summary>
		/// <param name="node">
		/// A <see cref="BasicNode"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool AddNode (BasicNode node)
		{
			bool result = true;
			
			if (this.Nodes.Count == 0)
			{
				this.MaxNodeId = 0;
			}
			
			if (!(this.Nodes.Contains (node)))
			{
				this.MaxNodeId++;
				node.NodeId = this.MaxNodeId;
				this.Nodes.Add (node);
			}
			else
			{
				result = false;
			}
			return result;
		}
		
		/// <summary>
		/// Removes the specified node from the list
		/// </summary>
		/// <param name="node">
		/// A <see cref="BasicNode"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool RemoveNode (BasicNode node)
		{
			bool result = true;
			
			if (this.Nodes.Contains (node))
			{
				if (node.NodeId == this.MaxNodeId)
				{
					this.MaxNodeId--;
				}
				this.Nodes.Remove (node);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}
		
		/// <summary>
		/// Clears the node list.
		/// </summary>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool RemoveAll ()
		{
			this.Nodes = new List<BasicNode> ();
			this.MaxNodeId = 0;
			return true;
		}
		
		/// <summary>
		/// Removes a node from the list at the given position.
		/// </summary>
		/// <param name="pos">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool RemoveAt (int pos)
		{
			this.Nodes.RemoveAt (pos);
			return true;
		}
		
		//// <value>
		/// Returns the total number of node on the list.
		/// </value>
		public int Count
		{
			get
			{
				return this.Nodes.Count;
			}
		}
		
		/// <summary>
		/// Saves the Node list to a Xml file specified as a parameter
		/// </summary>
		/// <param name="filename">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool SaveToXml (string filename)
		{
			XmlSerializer serializer = new XmlSerializer (typeof(List<BasicNode>));
			TextWriter tw = new StreamWriter (@filename);
			serializer.Serialize (tw, this.GetAllNodes ());
			tw.Close ();
			return true;
		}
		
		public bool LoadFromXml (string filename)
		{
			XmlSerializer deserializer = new XmlSerializer (typeof(List<BasicNode>));
			TextReader tr = new StreamReader (filename);
			this.Nodes = (List<BasicNode>) deserializer.Deserialize (tr);
			this.MaxNodeId = this.Nodes.Count;
			return true;
		}
	}
}