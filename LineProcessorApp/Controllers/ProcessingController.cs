using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LineProcessor;
using LineProcessor.Providers;
using LineProcessorApp.Views;

namespace LineProcessorApp.Controllers
{
	/// <summary> All the logic related to processing the expressions. </summary>
	internal class ProcessingController
	{
		/// <summary> The view for the controller. </summary>
		private readonly IProcessingView _processingView;

		/// <summary> The current provider to use when parsing expressions. </summary>
		private readonly CSharpProvider _provider;

		/// <summary> Time of the last request. </summary>
		private DateTime _lastRequestTime;

		/// <summary> Gets a value indicating whether we're currently evaluating expressions. </summary>
		private volatile bool _isEvaluating;

		/// <summary> Constructor. </summary>
		/// <param name="processingView"> The view for the controller. </param>
		public ProcessingController(IProcessingView processingView)
		{
			_processingView = processingView;
			_processingView.ExpressionChanged += HandleExpressionChanged;
			_processingView.ExampleChanged += HandleExampleChanged;

			_provider = new CSharpProvider();
		}

		private async void HandleExampleChanged(string exampleText)
		{
			await ReEvaluate();
		}

		private async void HandleExpressionChanged(IExpressionView expressionView)
		{
			await ReEvaluate();
		}

		private async Task ReEvaluate()
		{
			_lastRequestTime = DateTime.Now;

			if (_isEvaluating)
				return;

			DateTime initialRequesetTime = _lastRequestTime;

			_isEvaluating = true;

			LineExpression[] expressions = _processingView.Expressions.TakeWhile(r => r.IsValid)
			                                              .Select(r => new LineExpression(r.Name, r.Expression))
			                                              .ToArray();

			string input = _processingView.ExampleText;

			Argument[] results = await Task.Factory.StartNew(delegate
				{
					var processor = new Processor(_provider, expressions);
					return processor.Parse(input).All.ToArray();
				});

			_isEvaluating = false;

			for (int i = 1; i < results.Length; i++)
			{
				IValue value = results[i].ArgumentValue;
				IExpressionView expression = _processingView.Expressions.FirstOrDefault(e => e.Name == results[i].Name);

				if (expression == null)
					continue;

				if (value.HasError)
				{
					expression.Value = "#ERR";
					expression.Error = value.ErrorMessage;
				}
				else
				{
					expression.Value = value.UntypedValue.ToString();
					expression.Error = null;
				}
			}

			if (initialRequesetTime != _lastRequestTime)
			{
				await ReEvaluate();
			}
		}
	}
}