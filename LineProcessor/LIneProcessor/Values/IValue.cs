using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LineProcessor
{
	/// <summary> Interface for a value which may have an error associated with it. </summary>
	public interface IValue
	{
		/// <summary> Does the value have an error associated with it. </summary>
		bool HasError { get; }

		/// <summary> Gets the untyped value. Must throw an exception if HasError is true. </summary>
		object UntypedValue { get; }

		/// <summary> Gets the type of the value. </summary>
		Type ValueType { get; }

		/// <summary> The error message, if HasError is true. </summary>
		string ErrorMessage { get; }
	}
}