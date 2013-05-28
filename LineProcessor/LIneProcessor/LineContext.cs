using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LineProcessor
{
	/// <summary> Context for each line of execution. </summary>
	public class LineContext
	{
		/// <summary> Constructor. </summary>
		/// <param name="lineNumber"> The line number that the expression represents. </param>
		/// <param name="name"> The name of the line. </param>
		public LineContext(int lineNumber, string name)
		{
			Name = name;
			LineNumber = lineNumber;
		}

		/// <summary> The line number that the expression represents. </summary>
		public int LineNumber { get; private set; }

		/// <summary> The name of the line. </summary>
		public string Name { get; private set; }
	}
}