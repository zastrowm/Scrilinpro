using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
	/// <summary> Static string extension methods. </summary>
	public static class StringExtensions
	{
		/// <summary> Format the string with the parameters. </summary>
		/// <param name="self"> The string to format with. </param>
		/// <param name="args"> The arguments to format. </param>
		/// <returns> The formatted string. </returns>
		/// <example> "Hello, {0}!  Today is {1}".FormatWith("World", "Monday"); </example>
		public static String FormatWith(this String self, params Object[] args)
		{
			return String.Format(self, args);
		}

		/// <summary> Format the string with the parameters. </summary>
		/// <param name="self"> The string to format with. </param>
		/// <param name="args"> The arguments to format. </param>
		/// <returns> The formatted string. </returns>
		/// <example> "Hello, {0}!  Today is {1}".FormatWith("World", "Monday"); </example>
		public static String _(this String self, params Object[] args)
		{
			return self.FormatWith(args);
		}

		/// <summary> Return whether or not the string is empty or just whitespace. </summary>
		/// <param name="self"> The string to extend. </param>
		/// <returns> true if the the string is empty or whitespace. </returns>
		public static bool IsBlank(this String self)
		{
			return String.IsNullOrWhiteSpace(self);
		}

		/// <summary> Get the content of the string between two strings. </summary>
		/// <param name="self"> the string to extend. </param>
		/// <param name="leftSide"> the start of the string. </param>
		/// <param name="rightSide"> the end of the string. </param>
		/// <returns> the string between the two substrings, or an empty string. </returns>
		public static string Between(this string self, string leftSide, string rightSide)
		{
			int posA = self.IndexOf(leftSide);
			int posB = self.LastIndexOf(rightSide);
			int adjustedPosA = posA + leftSide.Length;

			if (posA == -1 || posB == -1 || adjustedPosA >= posB)
				return String.Empty;

			return self.Substring(adjustedPosA, posB - adjustedPosA);
		}

		/// <summary> Return the portion of a string before another string. </summary>
		/// <param name="self"> the string to extend. </param>
		/// <param name="rightSide"> The string that is the delimiter. </param>
		/// <returns>
		/// 	the portion of the string before rightSide, or an empty string if rightSide does not
		/// 	exist.
		/// </returns>
		public static string Before(this string self, string rightSide)
		{
			int posA = self.IndexOf(rightSide);
			if (posA == -1)
				return String.Empty;

			return self.Substring(0, posA);
		}

		/// <summary> Return the portion of a string after another string. </summary>
		/// <param name="self"> the string to extend. </param>
		/// <param name="leftSide"> The string right before the portion of the string that we want. </param>
		/// <returns>
		/// 	the portion of the string after leftSide, or an empty string if leftSide does not exist.
		/// </returns>
		public static string After(this string self, string leftSide)
		{
			int posA = self.LastIndexOf(leftSide);
			int adjustedPosA = posA + leftSide.Length;

			if (posA == -1 || adjustedPosA >= self.Length)
				return String.Empty;

			return self.Substring(adjustedPosA);
		}

		/// <summary> Split a string on any of the characters contained in the string. </summary>
		/// <param name="self"> The string to extend. </param>
		/// <param name="what"> the characters to split on. </param>
		/// <returns> an array of strings split from the original. </returns>
		public static string[] Split(this string self, string what)
		{
			return self.Split(what.ToArray());
		}

		/// <summary> Return the substring between two indices. </summary>
		/// <param name="self"> The string to extend. </param>
		/// <param name="startIndex"> The start index of the substring. </param>
		/// <param name="endIndex"> The end index of the substring. </param>
		/// <returns> The substring from startIndex with a length of endIndex - startIndex. </returns>
		public static string Substr(this string self, int startIndex, int endIndex)
		{
			if (endIndex > self.Length)
				endIndex = self.Length - 1;
			if (startIndex < 0 || endIndex < 0 || startIndex > endIndex)
				return String.Empty;

			return self.Substring(startIndex, endIndex - startIndex);
		}
	}
}