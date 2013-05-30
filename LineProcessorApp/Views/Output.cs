using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineProcessorApp.Views
{
	public partial class Output : UserControl, IOutputView
	{
		public Output()
		{
			InitializeComponent();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			ExportRequested();
		}

		private void btnCopyToClipboard_Click(object sender, EventArgs e)
		{
			CopyToClipboardRequested();
		}

		string IOutputView.Contents
		{
			get { return txtOutput.Text; }
			set { txtOutput.Text = value; }
		}

		public event Action ExportRequested;

		public event Action CopyToClipboardRequested;
	}
}