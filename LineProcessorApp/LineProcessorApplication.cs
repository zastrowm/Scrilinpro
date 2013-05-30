using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LineProcessorApp.Controllers;
using LineProcessorApp.Controls;
using LineProcessorApp.Views;

namespace LineProcessorApp
{
	public partial class LineProcessorApplication : Form, IApplicationView
	{
		private ApplicationController _controller;

		public LineProcessorApplication()
		{
			InitializeComponent();

			_controller = new ApplicationController(this);
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public IProcessingView ProcessingView
		{
			get { return ctlProcessor; }
		}

		public IInputView InputView
		{
			get { return ctlInput; }
		}

		public IOutputView OutputView
		{
			get { return ctlOutput; }
		}
	}
}