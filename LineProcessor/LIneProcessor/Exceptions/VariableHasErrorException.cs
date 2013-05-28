using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineProcessor
{
	/// <summary> Indicates that a variable has an exception. </summary>
	public class VariableHasErrorException : Exception
	{
		/// <summary> Constructor. </summary>
		/// <param name="exception"> The exception that explains the root of the problem. </param>
		public VariableHasErrorException(Exception exception)
			: base("Variable has error", exception)
		{
		}
	}
}