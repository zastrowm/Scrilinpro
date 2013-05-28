using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using LineProcessor.Providers.CSharp;
using Roslyn.Compilers;
using Roslyn.Scripting;
using Roslyn.Scripting.CSharp;

namespace LineProcessor.Providers
{
	/// <summary> Provides C# support. </summary>
	public class CSharpProvider : ILanguageProvider
	{
		/// <summary> The actual script engine. </summary>
		private readonly ScriptEngine _engine;

		/// <summary> Default constructor. </summary>
		public CSharpProvider()
		{
			_engine = new ScriptEngine();
			_engine.AddReference("System");
			_engine.AddReference("System.Core");
			_engine.AddReference("System.Data");
			_engine.AddReference("System.Xml");
			_engine.AddReference("System.Xml.Linq");
			_engine.AddReference(typeof(CSharpProvider).Assembly.Location);
			_engine.AddReference(typeof(NullObject).Assembly.Location);
		}

		/// <summary> Evaluates a line or script. </summary>
		/// <param name="context"> Information about the line to be executed. </param>
		/// <param name="arguments"> The provided arguments to the line. </param>
		/// <param name="contents"> The contents of the line to execute. </param>
		/// <returns> The value of the expression. </returns>
		public IValue Evaluate(LineContext context, Arguments arguments, string contents)
		{
			var host = new HostObject(arguments);

			Session session = _engine.CreateSession(host);
			session.ImportNamespace("System");
			session.ImportNamespace("System.Linq");
			session.ImportNamespace("System.Collections.Generic");
			session.ImportNamespace("System.Text");

			const string format = "var {0} = Value(GetHostValue<{1}>(\"{0}\"));";
			const string formatActual = "var {0}_ = GetHostValue<{1}>(\"{0}\");";

			foreach (Argument arg in arguments.All)
			{
				session.Execute(String.Format(format, arg.Name, arg.ArgumentValue.ValueType.FullName));
				session.Execute(String.Format(formatActual, arg.Name, arg.ArgumentValue.ValueType.FullName));
			}

			try
			{
				object result = session.Execute(contents);
				return SafeValue.FromRawValue(result);
			}
			catch (CompilationErrorException e)
			{
				var error = new Exception(string.Format("Invalid Script for '{0}'", context.Name), e);
				return SafeValue.FromException(error);
			}
			catch (Exception e)
			{
				return SafeValue.FromException(e);
			}
		}
	}
}