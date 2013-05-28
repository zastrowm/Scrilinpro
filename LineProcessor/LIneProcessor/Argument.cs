using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LineProcessor
{
	/// <summary> Represents a value in the system. </summary>
	public class Argument
	{
		/// <summary> The relative order of the argument. </summary>
		public int Order { get; private set; }

		/// <summary> The name of the argument. </summary>
		public string Name { get; private set; }

		/// <summary> The argument value. </summary>
		public IValue ArgumentValue { get; private set; }

		/// <summary> Constructor. </summary>
		/// <param name="order"> The relative order of the argument. </param>
		/// <param name="name"> The name of the argument. </param>
		/// <param name="value"> The value. </param>
		internal Argument(int order, string name, IValue value)
		{
			Order = order;
			Name = name;
			ArgumentValue = value;
		}

		//public static Argument FromValue(IValue value)
		//{
		//	return new Argument(-1, "", value);
		//}

		///// <summary> Create an argument that wrape. </summary>
		///// <param name="value"> The value. </param>
		///// <returns> . </returns>
		//internal static Argument MakeSafeObject(object value)
		//{
		//	if (value == null)
		//		return FromValue(new SafeValue<object>(value));

		//	Type varType = value.GetType();

		//	var actualValue = (IValue)Activator.CreateInstance(typeof(SafeValue<>).MakeGenericType(varType), value);
		//	return FromValue(actualValue);
		//}
	}
}