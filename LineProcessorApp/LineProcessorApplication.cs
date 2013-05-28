using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LineProcessorApp
{
	public partial class LineProcessorApplication : Form
	{
		public LineProcessorApplication()
		{
			InitializeComponent();
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ctlTabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			ctlProcessor.Lines = ctlInput.Lines.ToArray();
		}
	}
}