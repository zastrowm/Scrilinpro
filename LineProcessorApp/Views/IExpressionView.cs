using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LineProcessorApp.Views
{
	/// <summary> A control that holds an expression. </summary>
	public interface IExpressionView
	{
		/// <summary> The name of the expression. </summary>
		string Name { get; }

		/// <summary> The expression for the variable. </summary>
		string Expression { get; }

		/// <summary> The value of the expression. </summary>
		string Value { get; set; }

		/// <summary> Updates the sizes of the name, expression and value. </summary>
		/// <param name="nameSize"> The size of the name field. </param>
		/// <param name="expressionSize"> The size of the expression field. </param>
		/// <param name="valueSize"> The size of the value field. </param>
		void UpdateSizes(float nameSize, float expressionSize, float valueSize);

		/// <summary> Indicates that the expression or name changed. </summary>
		event Action<IExpressionView> Changed;

		/// <summary> True if the expression is valid for parsing. </summary>
		bool IsValid { get; }

		/// <summary> The error on the expression. </summary>
		string Error { get; set; }
	}
}