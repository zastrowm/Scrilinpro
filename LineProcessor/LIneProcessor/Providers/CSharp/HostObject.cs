using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LineProcessor.Providers.CSharp
{
	/// <summary> Contains the exposed methods for the scripts. </summary>
	public class HostObject
	{
		/// <summary> The arguments for the host. </summary>
		private readonly Arguments _arguments;

		/// <summary> Constructor. </summary>
		/// <param name="arguments"> The arguments. </param>
		public HostObject(Arguments arguments)
		{
			_arguments = arguments;
		}

		/// <summary> Attempts to get a named value. </summary>
		/// <typeparam name="T"> The type of variable to get. </typeparam>
		/// <param name="variableName"> The name of the variable. </param>
		/// <returns> The value of the variable, or a . </returns>
		public SafeValue<T> GetHostValue<T>(string variableName)
		{
			var value = _arguments.FindByName(variableName).ArgumentValue as SafeValue<T>;
			return value ?? new SafeValue<T>(default(T), new Exception("Named value is not of correct type."));
		}

		/// <summary> Check if a variable with the name and type exists. </summary>
		/// <typeparam name="T"> The type of variable. </typeparam>
		/// <param name="variableName"> The name of the variable. </param>
		/// <returns> true if it exist, false otherwise. </returns>
		public bool HasValue<T>(string variableName)
		{
			return _arguments.All.Any(arg => arg.Name == variableName && arg.ArgumentValue is T);
		}

		/// <summary> Convert a value to correct type, or return the defaultValue. </summary>
		/// <typeparam name="T"> The type of the variable to convert to. </typeparam>
		/// <param name="value"> The value to convert. </param>
		/// <param name="defaultValue"> (optional) the default value. </param>
		/// <returns>
		///  The underlying value, or defaultValue if an error occurs or the value is not of the correct
		///  type.
		/// </returns>
		public T ErrorFree<T>(IValue value, T defaultValue = default(T))
		{
			var safe = value as SafeValue<T>;
			if (safe == null || safe.HasError)
				return defaultValue;

			return safe.Value;
		}

		/// <summary> Convert a value to correct type, or return the defaultValue. </summary>
		/// <typeparam name="T"> The type of the variable to convert to. </typeparam>
		/// <param name="value"> The value to convert. </param>
		/// <param name="defaultValue"> (optional) the default value. </param>
		/// <returns>
		///  The underlying value, or defaultValue if an error occurs or the value is not of the correct
		///  type.
		/// </returns>
		public T ErrorFree<T>(SafeValue<T> value, T defaultValue = default(T))
		{
			SafeValue<T> safe = value;
			if (safe == null || safe.HasError)
				return defaultValue;

			return safe.Value;
		}

		/// <summary>
		///  Get the value of the variable if it does not have an error, or the default variable value.
		/// </summary>
		/// <typeparam name="T"> The type of the variable to convert to. </typeparam>
		/// <param name="value"> The value to convert. </param>
		/// <returns>
		///  The underlying value, or default(T) if an error occurs or the value is not of the correct
		///  type.
		/// </returns>
		public T Value<T>(SafeValue<T> value)
		{
			return ErrorFree(value);
		}

		/// <summary> Converts the given IValue to the passed type. </summary>
		/// <exception cref="VariableHasErrorException">	If the value has an error. </exception>
		/// <exception cref="TypeConversionException">	If the type cannot be converted. </exception>
		/// <typeparam name="T"> The type to convert to. </typeparam>
		/// <param name="value"> The value to convert. </param>
		/// <returns> The value of the variable. </returns>
		public T Convert<T>(IValue value)
		{
			var safe = value as SafeValue<T>;

			if (value.HasError)
			{
				// exception should be thrown
				object unused = value.UntypedValue;

				// get rid of resharper warning:
				if (unused != null)
					throw new NullReferenceException();

				// should never get here
				return default(T);
			}

			if (safe == null)
			{
				throw new TypeConversionException(typeof(T), value.ValueType);
			}

			return safe.Value;
		}
	}
}