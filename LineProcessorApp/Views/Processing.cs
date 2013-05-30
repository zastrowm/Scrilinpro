using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LineProcessor;
using LineProcessor.Providers;
using LineProcessorApp.Controllers;
using LineProcessorApp.Model;
using LineProcessorApp.Views;

namespace LineProcessorApp.Controls
{
	public partial class ProcessingView : UserControl, IProcessingView
	{
		private readonly List<ControlRow> _controlRows;

		private readonly CSharpProvider _provider;
		private string[] _lines;

		public ProcessingView()
		{
			InitializeComponent();

			Expressions = new ObservableCollection<IExpressionView>();
			pnlHeader.SizeChanged += PnlHeaderOnSizeChanged;

			ctlValueLine.Changed += SingleExpressionChanged;
			ctlValueLine.MakePrimary("Example Line");

			for (int i = 0; i < 6; i++)
			{
				AddLine();
			}

			PnlHeaderOnSizeChanged(null, null);
		}

		private void PnlHeaderOnSizeChanged(object sender, EventArgs eventArgs)
		{
			int widthName = lblName.Width + 6;
			int widthExpression = lblExpression.Width + 6;
			int widthExample = lblExample.Width + 6;

			((IExpressionView)ctlValueLine).UpdateSizes(widthName, widthExpression, widthExample);
			ctlValueLine.Changed += SingleExpressionChanged;

			foreach (IExpressionView expr in Expressions)
			{
				expr.UpdateSizes(widthName, widthExpression, widthExample);
			}
		}

		/// <summary> Add a new expression/line to the table. </summary>
		private void AddLine()
		{
			var newLine = new ProcessingLine();
			pnlLines.Controls.Add(newLine);
			newLine.Changed += SingleExpressionChanged;

			Expressions.Add(newLine);

			PnlHeaderOnSizeChanged(null, null);
		}

		private void SingleExpressionChanged(IExpressionView expressionView)
		{
			timChangeTimer.Start();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddLine();
		}

		private void btnEvaluate_Click(object sender, EventArgs e)
		{
			OnExpressionChanged(null);
		}

		public ObservableCollection<IExpressionView> Expressions { get; private set; }

		string IProcessingView.ExampleText
		{
			get { return cboExampleInput.Text; }
		}

		public event Action<string> ExampleChanged;

		public event Action<IExpressionView> ExpressionChanged;

		protected virtual void OnExpressionChanged(IExpressionView obj)
		{
			Action<IExpressionView> handler = ExpressionChanged;
			if (handler != null)
				handler(obj);
		}

		private void HandleTextChangedTick(object sender, EventArgs e)
		{
			OnExpressionChanged(null);
			timChangeTimer.Stop();
		}
	}
}