using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LineProcessor
{
	/// <summary> Contains a series of arguments. </summary>
	public class Arguments
	{
		/// <summary> The arguments in a dictionary for fast lookup. </summary>
		private readonly Dictionary<string, Argument> _arguments;

		private readonly List<Argument> _orderedArguments;

		/// <summary> Default constructor. </summary>
		public Arguments()
		{
			_arguments = new Dictionary<string, Argument>();
			_orderedArguments = new List<Argument>();
		}

		/// <summary> Adds argument to the list of arguments. </summary>
		/// <param name="argument"> The Argument to add. </param>
		internal void Add(Argument argument)
		{
			_arguments.Add(argument.Name, argument);
			_orderedArguments.Add(argument);
		}

		/// <summary> All of the arguments in the collection. </summary>
		public IEnumerable<Argument> All
		{
			get
			{
				foreach (Argument arg in _orderedArguments)
				{
					yield return arg;
				}
			}
		}

		/// <summary> The number of arguments. </summary>
		public int Count
		{
			get { return _arguments.Count; }
		}

		/// <summary> Searches for an argument by name. </summary>
		/// <param name="name"> The name of the argument to search for. </param>
		/// <returns> The argument identified by name, or null if the argument does not exist. </returns>
		public Argument FindByName(string name)
		{
			Argument value;

			return _arguments.TryGetValue(name, out value)
				       ? value
				       : null;
		}
	}
}