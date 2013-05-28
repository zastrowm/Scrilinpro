using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineProcessor
{
	/// <summary> When an attempt to convert a type from another type fails. </summary>
	public class TypeConversionException : Exception
	{
		/// <summary> Constructor. </summary>
		/// <param name="toType">  The type that was trying to convert to. </param>
		/// <param name="fromType"> The actual type of the variable. </param>
		public TypeConversionException(Type toType, Type fromType)
			: base(String.Format("Value is not of type {0}; value is type {1}", toType, fromType))
		{
		}
	}
}