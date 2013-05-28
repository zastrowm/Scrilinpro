using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LineProcessor
{
	/// <summary> A single named expression. </summary>
	public class LineExpression
	{
		/// <summary> The name of the line. </summary>
		public string Name { get; private set; }

		/// <summary> The expression to convert. </summary>
		public string Expression { get; private set; }

		/// <summary> Constructor. </summary>
		/// <param name="name"> The name of the line. </param>
		/// <param name="expression"> The expression to convert. </param>
		public LineExpression(string name, string expression)
		{
			if (name == null)
				throw new ArgumentNullException("name");
			if (expression == null)
				throw new ArgumentNullException("expression");

			Name = name;
			Expression = expression;
		}
	}
}