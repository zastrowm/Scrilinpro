using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace LineProcessorApp.Views
{
	/// <summary> Interface for the processing view. </summary>
	public interface IProcessingView
	{
		/// <summary> All of expressions. </summary>
		ObservableCollection<IExpressionView> Expressions { get; }

		/// <summary> The current example text. </summary>
		string ExampleText { get; }

		/// <summary> Indicates that the example line has changed. </summary>
		event Action<string> ExampleChanged;

		/// <summary> Indicates that a certain expression has changed </summary>
		event Action<IExpressionView> ExpressionChanged;
	}
}