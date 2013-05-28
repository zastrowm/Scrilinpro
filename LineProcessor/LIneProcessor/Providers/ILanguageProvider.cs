using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LineProcessor.Providers
{
	/// <summary> Provides language support for the program. </summary>
	public interface ILanguageProvider
	{
		/// <summary> Evaluates a line or script. </summary>
		/// <param name="context"> Information about the line to be executed. </param>
		/// <param name="arguments"> The provided arguments to the line. </param>
		/// <param name="contents"> The contents of the line to execute. </param>
		/// <returns> The value of the expression. </returns>
		IValue Evaluate(LineContext context, Arguments arguments, string contents);
	}
}