using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LineProcessorApp.Controls
{
	public partial class Input : UserControl
	{
		public Input()
		{
			InitializeComponent();
		}

		/// <summary> All of the lines in the control. </summary>
		public IEnumerable<string> Lines
		{
			get
			{
				return txtInput.Text.Split('\n').Select(s => s.EndsWith("\r")
					                                             ? s.Substring(0, s.Length - 1)
					                                             : s);
			}
		}

		private void btnClipboard_Click(object sender, EventArgs e)
		{
			try
			{
				txtInput.Text = Clipboard.GetText();
			}
			catch (Exception)
			{
			}
		}
	}
}