using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LineProcessor;
using LineProcessor.Providers;
using LineProcessorApp.Views;

namespace LineProcessorApp.Controllers
{
	/// <summary> Output controller. </summary>
	public class OutputController
	{
		/// <summary> The application controller for cross controller communication. </summary>
		private readonly ApplicationController _owner;

		/// <summary> The view that is attached to the controller. </summary>
		private readonly IOutputView _outputView;

		/// <summary> Constructor. </summary>
		/// <param name="owner"> The application controller for cross controller communication. </param>
		/// <param name="outputView"> The view that is attached to the controller. </param>
		public OutputController(ApplicationController owner, IOutputView outputView)
		{
			_owner = owner;
			_outputView = outputView;

			_outputView.CopyToClipboardRequested += CopyToClipboard;
			_outputView.ExportRequested += OutputViewOnExportRequested;
		}

		private void OutputViewOnExportRequested()
		{
			LineExpression[] expressions = _owner.Expressions.TakeWhile(r => r.IsValid)
			                                     .Select(r => new LineExpression(r.Name, r.Expression))
			                                     .ToArray();

			IEnumerable<string> lines = _owner.Lines;

			var processor = new Processor(new CSharpProvider(), expressions);
			IEnumerable<Arguments> results = processor.Parse(lines);

			IEnumerable<IValue> values = results.Select(r => r.All.Last().ArgumentValue);

			_outputView.Contents = String.Join("\r\n", values.Select(v => v.HasError ? "#ERR" : v.UntypedValue.ToString()));
		}

		/// <summary> Copies the text to the clipboard. </summary>
		private void CopyToClipboard()
		{
			Clipboard.SetText(_outputView.Contents ?? "");
		}
	}
}