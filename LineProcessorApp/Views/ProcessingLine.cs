using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LineProcessorApp.Controllers;
using LineProcessorApp.Views;

namespace LineProcessorApp.Controls
{
	public partial class ProcessingLine : UserControl, IExpressionView
	{
		public ProcessingLine()
		{
			InitializeComponent();

			pnlLayout.ColumnStyles[0].SizeType = SizeType.Absolute;
			pnlLayout.ColumnStyles[1].SizeType = SizeType.Absolute;
			pnlLayout.ColumnStyles[2].SizeType = SizeType.Absolute;

			txtName.TextChanged += (o, e) => Changed(this);
			txtExpression.TextChanged += (o, e) => Changed(this);

			errExpression.SetIconAlignment(txtValue, ErrorIconAlignment.MiddleRight);
		}

		string IExpressionView.Expression
		{
			get { return txtExpression.Text; }
		}

		string IExpressionView.Value
		{
			get { return txtValue.Text; }
			set { txtValue.Text = value; }
		}

		string IExpressionView.Name
		{
			get { return txtName.Text; }
		}

		void IExpressionView.UpdateSizes(float nameSize, float expressionSize, float valueSize)
		{
			pnlLayout.ColumnStyles[0].Width = nameSize;
			pnlLayout.ColumnStyles[1].Width = expressionSize;
			pnlLayout.ColumnStyles[2].Width = valueSize;
		}

		public event Action<IExpressionView> Changed;

		public bool IsValid
		{
			get { return !String.IsNullOrEmpty(txtExpression.Text) && !String.IsNullOrEmpty(txtName.Text); }
		}

		public string Error
		{
			get { return errExpression.GetError(txtValue); }
			set { errExpression.SetError(txtValue, value); }
		}

		public void MakePrimary(string expression)
		{
			txtName.Text = "Line";
			txtName.ReadOnly = true;
			txtExpression.Text = expression;
			txtExpression.ReadOnly = true;
		}
	}
}