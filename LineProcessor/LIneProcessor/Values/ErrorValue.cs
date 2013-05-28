using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LineProcessor
{
	/// <summary> A value in which an exception was caused. </summary>
	public class ErrorValue : SafeValue<VariableHasErrorException>
	{
		/// <summary> Constructor. </summary>
		/// <param name="innerException"> The exception that occurred while trying to calculate the value. </param>
		internal ErrorValue(Exception innerException)
			: this(new VariableHasErrorException(innerException))
		{
		}

		/// <summary> Private Constructor. </summary>
		/// <param name="errorException"> Details of the exception. </param>
		private ErrorValue(VariableHasErrorException errorException)
			: base(errorException, errorException)
		{
		}
	}
}