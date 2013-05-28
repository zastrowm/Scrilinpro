using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineProcessor.Providers;

namespace LineProcessor
{
	/// <summary> Processes a single step of expressions. </summary>
	public class Processor
	{
		/// <summary> The provider that does the parsing of expressions. </summary>
		private readonly ILanguageProvider _provider;

		/// <summary> All of the expressions to parse. </summary>
		private readonly LineExpression[] _expressions;

		/// <summary> Constructor. </summary>
		/// <param name="provider"> The provider that does the parsing of expressions. </param>
		/// <param name="expressions"> The expressions to parse. </param>
		public Processor(ILanguageProvider provider, LineExpression[] expressions)
		{
			_provider = provider;
			_expressions = expressions;
		}

		/// <summary> Parses a single line. </summary>
		/// <param name="singleLine"> The single line to parse. </param>
		/// <returns> The arguments for the line. </returns>
		public Arguments Parse(string singleLine)
		{
			if (singleLine == null)
				singleLine = "";

			var args = new Arguments();
			args.Add(new Argument(0, "line", new SafeValue<string>(singleLine)));

			foreach (LineExpression expr in _expressions)
			{
				int order = args.Count;
				var context = new LineContext(order, expr.Name);
				IValue value = _provider.Evaluate(context, args, expr.Expression);
				args.Add(new Argument(order, expr.Name, value));
			}

			return args;
		}

		/// <summary> Parses multiple lines and returns an argument list for each line. </summary>
		/// <exception cref="ArgumentNullException">	When one or more required arguments are null. </exception>
		/// <param name="lines"> The lines to parse. </param>
		/// <returns> The arguments for all of the lines. </returns>
		public IEnumerable<Arguments> Parse(IEnumerable<string> lines)
		{
			if (lines == null)
				throw new ArgumentNullException("lines");

			return ParseSafe(lines);
		}

		/// <summary> Parses multiple lines and returns an argument list for each line. </summary>
		/// <exception cref="ArgumentNullException">	When one or more required arguments are null. </exception>
		/// <param name="lines"> The lines to parse. </param>
		/// <returns> The arguments for all of the lines. </returns>
		public IEnumerable<Arguments> Parse(params string[] lines)
		{
			if (lines == null)
				throw new ArgumentNullException("lines");

			return ParseSafe(lines);
		}

		private IEnumerable<Arguments> ParseSafe(IEnumerable<string> lines)
		{
			foreach (string line in lines)
			{
				yield return Parse(line);
			}
		}
	}
}