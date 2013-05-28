using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;
using Roslyn.Scripting.CSharp;

namespace LineProcessor
{
	/// <summary> Helper class. </summary>
	public static class SafeValue
	{
		/// <summary> Create a new value from an exception </summary>
		/// <param name="exception"> The exception. </param>
		/// <returns> An IValue that represents an exception. </returns>
		public static IValue FromException(Exception exception)
		{
			return new ErrorValue(exception);
		}

		/// <summary> Create an IValue from an object. </summary>
		/// <param name="value"> The value to create. </param>
		/// <returns> The IValue that represents the object value passed in. </returns>
		public static IValue FromRawValue(object value)
		{
			Type varType = value == null ? typeof(object) : value.GetType();

			var actualValue = (IValue)Activator.CreateInstance(typeof(SafeValue<>).MakeGenericType(varType), value);
			return actualValue;
		}
	}

	/// <summary> Represents a value that may or may not have an error associated with it. </summary>
	/// <typeparam name="T"> Generic type parameter. </typeparam>
	public class SafeValue<T> : IValue
	{
		/// <summary> The value of the variable. </summary>
		private readonly T _value;

		/// <summary> The exception that occurred while trying to calculate the value. </summary>
		private readonly Exception _exception;

		/// <summary> Constructor. </summary>
		/// <param name="value"> The value of the variable. </param>
		public SafeValue(T value)
			: this(value, null)
		{
		}

		/// <summary> Constructor. </summary>
		/// <param name="value"> The value of the variable. </param>
		/// <param name="exception">The exception that occurred while trying to calculate the value. </param>
		internal SafeValue(T value, Exception exception)
		{
			_value = value;
			_exception = exception;
		}

		/// <summary> True if an error occurred while trying to calculate the value. </summary>
		public bool HasError
		{
			get { return _exception != null; }
		}

		/// <summary> Gets the raw value of the value. </summary>
		/// <exception cref="Exception"> If an exception occurred while trying to calculate the value. </exception>
		public object UntypedValue
		{
			get { return Value; }
		}

		/// <summary> Gets the type of the value. </summary>
		public Type ValueType
		{
			get { return typeof(T); }
		}

		/// <summary> The error message, if HasError is true. </summary>
		public string ErrorMessage
		{
			get { return _exception.InnerException.Message; }
		}

		/// <summary> Gets the value of the variable. </summary>
		/// <exception cref="Exception"> If an exception occurred while trying to calculate the value. </exception>
		public T Value
		{
			get
			{
				if (HasError)
					throw _exception;

				return _value;
			}
		}

		public override string ToString()
		{
			return !HasError ? ObjectFormatter.Instance.FormatObject(Value) : "#ERR";
		}

		/// <summary> Implicitly convert the SafeValue into the unwrapped type. </summary>
		/// <param name="safeValue"> The safe value to unwrap. </param>
		public static implicit operator T(SafeValue<T> safeValue)
		{
			return safeValue.Value;
		}
	}
}