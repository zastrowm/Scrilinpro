using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LineProcessorApp.Views
{
	/// <summary> Interface for output view. </summary>
	public interface IOutputView
	{
		/// <summary> The contents of the output. </summary>
		string Contents { get; set; }

		/// <summary> Indicates that the user would like the output to export. </summary>
		event Action ExportRequested;

		/// <summary>
		///  Indicates that the user wishes to copy the text to the clipboard.
		/// </summary>
		event Action CopyToClipboardRequested;
	}
}