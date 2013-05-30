using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LineProcessorApp.Controls
{
	/// <summary> Interface for the input view. </summary>
	public interface IInputView
	{
		/// <summary> The text that the user wishes to process. </summary>
		string Contents { get; set; }

		/// <summary> Event indicating that the user wants to load the text from the clipboard. </summary>
		event Action LoadFromClipboard;

		/// <summary> Event indicating that the user wants to load text from a file. </summary>
		event Action LoadFromFile;
	}
}