using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LineProcessorApp.Model
{
	public class Expression
	{
		/// <summary> The name of the expression. </summary>
		public string Name { get; private set; }

		/// <summary> The expressions contents. </summary>
		public string ExpressionText { get; private set; }

		/// <summary> Constructor. </summary>
		/// <param name="name"> The name of the expression. </param>
		/// <param name="expressionText"> The expressions contents. </param>
		public Expression(string name, string expressionText)
		{
			Name = name;
			ExpressionText = expressionText;
		}
	}
}