using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace LineProcessorApp.Controls
{
	internal class ControlRow
	{
		public TextBox Name { get; private set; }

		public TextBox Expression { get; private set; }

		public TextBox Result { get; private set; }

		private ControlRow()
		{
			Name = new TextBox();
			Expression = new TextBox();
			Result = new TextBox();
		}

		public ControlRow(TextBox name, TextBox expression, TextBox result)
		{
			Name = name;
			Expression = expression;
			Result = result;
		}

		public static ControlRow Copy(ControlRow from)
		{
			var to = new ControlRow();

			to.Name.Dock = from.Name.Dock;
			to.Expression.Dock = from.Expression.Dock;
			to.Result.Dock = from.Result.Dock;
			to.Result.ReadOnly = true;

			return to;
		}

		public event EventHandler ExpressionTextChanged
		{
			add { Expression.TextChanged += value; }
			remove { Expression.TextChanged -= value; }
		}
	}
}