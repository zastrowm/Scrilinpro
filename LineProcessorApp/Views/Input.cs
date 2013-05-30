using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LineProcessorApp.Controls;

namespace LineProcessorApp.Views
{
	public partial class Input : UserControl, IInputView
	{
		public Input()
		{
			InitializeComponent();

			btnClipboard.Click += (o, e) => LoadFromClipboard();
			btnLoad.Click += (o, e) => LoadFromFile();
		}

		public string Contents
		{
			get { return txtInput.Text; }
			set { txtInput.Text = value; }
		}

		public event Action LoadFromClipboard;

		public event Action LoadFromFile;
	}
}