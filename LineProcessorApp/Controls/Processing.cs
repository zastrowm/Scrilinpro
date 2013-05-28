using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LineProcessor;
using LineProcessor.Providers;

namespace LineProcessorApp.Controls
{
	public partial class Processing : UserControl
	{
		private readonly List<ControlRow> _controlRows;

		private readonly CSharpProvider _provider;
		private string[] _lines;
		private bool _isEvaluating = false;
		private bool _shouldRevaluate = false;
		private readonly Timer _timer;

		public Processing()
		{
			InitializeComponent();

			var first = new ControlRow(txt1Name, txt1Expression, txt1Example);
			_controlRows = new List<ControlRow>();
			_controlRows.Add(first);
			first.ExpressionTextChanged += txtExpression_TextChanged;

			for (int i = 0; i < 5; i++)
			{
				btnAdd.PerformClick();
			}

			_provider = new CSharpProvider();
			_timer = new Timer();
			_timer.Tick += (a, b) =>
				{
					_timer.Stop();
					Reevaluate();
				};
			_timer.Interval = TimeSpan.FromMilliseconds(500).Milliseconds;
		}

		private void txtExpression_TextChanged(object sender, EventArgs e)
		{
			_timer.Start();
		}

		public string[] Lines
		{
			get { return _lines; }
			set
			{
				_lines = value;
				string previousSelected = cboExampleInput.Text;

				cboExampleInput.Items.Clear();
				for (int i = 0; i < value.Length; i++)
				{
					cboExampleInput.Items.Add(value[i]);
				}

				cboExampleInput.SelectedIndex = value.Contains(previousSelected) && !String.IsNullOrEmpty(previousSelected)
					                                ? Array.IndexOf(value, previousSelected)
					                                : 0;
			}
		}

		private void cboExampleInput_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtExample.Text = cboExampleInput.Text;
			txtExpression.Text = "n/a";
			txtInputName.Text = "line";

			Reevaluate();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Add(ControlRow.Copy(_controlRows[0]));
		}

		private void Add(ControlRow newRow)
		{
			pnlRows.SuspendLayout();

			int rowNumber = pnlRows.RowCount++;

			_controlRows.Add(newRow);

			ControlRow first = _controlRows[0];

			pnlRows.Controls.Add(newRow.Name, pnlRows.GetColumn(first.Name), rowNumber);
			pnlRows.Controls.Add(newRow.Expression, pnlRows.GetColumn(first.Expression), rowNumber);
			pnlRows.Controls.Add(newRow.Result, pnlRows.GetColumn(first.Result), rowNumber);

			newRow.ExpressionTextChanged += txtExpression_TextChanged;

			pnlRows.ResumeLayout();
		}

		private void btnEvaluate_Click(object sender, EventArgs e)
		{
			Reevaluate();
		}

		private async Task Reevaluate()
		{
			if (_isEvaluating)
			{
				_shouldRevaluate = true;
				return;
			}

			string input = cboExampleInput.Text;
			Argument[] results = null;

			_isEvaluating = true;

			await Task.Factory.StartNew(() =>
				{
					Processor processor = GetProcessor();
					results = processor.Parse(input).All.ToArray();
				});

			_isEvaluating = false;

			for (int i = 1; i < results.Length; i++)
			{
				IValue value = results[i].ArgumentValue;
				ControlRow row = _controlRows[i - 1];
				if (value.HasError)
				{
					row.Result.Text = "#ERR";
					errExample.SetError(row.Result, value.ErrorMessage);
					errExample.SetIconAlignment(row.Result, ErrorIconAlignment.MiddleRight);
				}
				else
				{
					row.Result.Text = value.UntypedValue.ToString();
					errExample.SetError(row.Result, null);
				}
			}

			if (_shouldRevaluate)
			{
				_shouldRevaluate = false;
				Reevaluate();
			}
		}

		private Processor GetProcessor()
		{
			LineExpression[] expressions = _controlRows.TakeWhile(r => !String.IsNullOrEmpty(r.Name.Text))
			                                           .Select(r => new LineExpression(r.Name.Text, r.Expression.Text))
			                                           .ToArray();

			return new Processor(_provider, expressions);
		}

		public IEnumerable<Arguments> AllResults
		{
			get { return GetProcessor().Parse(Lines); }
		}

		private async void Processing_Load(object sender, EventArgs e)
		{
			await Reevaluate();
		}
	}
}