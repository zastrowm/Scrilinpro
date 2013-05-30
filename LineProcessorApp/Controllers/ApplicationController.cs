using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineProcessorApp.Controls;
using LineProcessorApp.Views;

namespace LineProcessorApp.Controllers
{
	/// <summary> The main logic for the application. </summary>
	public class ApplicationController
	{
		/// <summary> The view for the controller. </summary>
		private readonly IApplicationView _view;

		/// <summary> Handles all input related tasks. </summary>
		private readonly InputController _input;

		/// <summary> Handles all processing related tasks. </summary>
		private ProcessingController _processing;

		/// <summary> Handles all processing related to the output. </summary>
		private OutputController _output;

		/// <summary> Constructor. </summary>
		/// <param name="view"> The view for the controller. </param>
		public ApplicationController(IApplicationView view)
		{
			_view = view;

			_input = new InputController(view.InputView);
			_processing = new ProcessingController(view.ProcessingView);
			_output = new OutputController(this, view.OutputView);
		}

		public ObservableCollection<IExpressionView> Expressions
		{
			get { return _view.ProcessingView.Expressions; }
		}

		public IEnumerable<string> Lines
		{
			get { return _input.Lines; }
		}
	}
}