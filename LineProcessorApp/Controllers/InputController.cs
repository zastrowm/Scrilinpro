using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace LineProcessorApp.Controls
{
	/// <summary> Input controller. </summary>
	public class InputController
	{
		private readonly IInputView _inputView;

		public InputController(IInputView inputView)
		{
			_inputView = inputView;

			_inputView.LoadFromClipboard += CopyFromClipboard;
		}

		/// <summary> All of the lines in the control. </summary>
		public IEnumerable<string> Lines
		{
			get { return _inputView.Contents.Replace("\r\n", "\n").Split('\n'); }
		}

		private void CopyFromClipboard()
		{
			try
			{
				_inputView.Contents = Clipboard.GetText();
			}
			catch (Exception)
			{
			}
		}
	}
}