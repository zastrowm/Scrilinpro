using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineProcessorApp.Controls;

namespace LineProcessorApp.Views
{
	/// <summary> View for the main view. </summary>
	public interface IApplicationView
	{
		/// <summary> The processing view. </summary>
		IProcessingView ProcessingView { get; }

		/// <summary> The input view. </summary>
		IInputView InputView { get; }

		/// <summary> The output view. </summary>
		IOutputView OutputView { get; }
	}
}