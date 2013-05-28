using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LineProcessor.Providers;
using NUnit.Framework;

namespace LineProcessor
{
	internal class CSharpProviderTests
	{
		private CSharpProvider _provider;

		[SetUp]
		public void Setup()
		{
			_provider = new CSharpProvider();
		}

		[Test]
		[Description("Exception results in ErrorValue")]
		public void Exception_results_in_ErrorValue()
		{
			IValue arg = _provider.Evaluate(null, new Arguments(), "throw new Exception();");

			Assert.IsTrue(arg.HasError);
			Assert.IsTrue(arg is ErrorValue);
		}

		[Test]
		[Description("Int expression results in int Value")]
		public void Int_expression_results_in_int_Value()
		{
			IValue arg = _provider.Evaluate(null, new Arguments(), "7 + 4");

			Assert.IsFalse(arg.HasError);
			Assert.IsTrue(arg is SafeValue<int>);
			Assert.AreEqual(11, arg.UntypedValue);
		}

		[Test]
		[Description("Arguments can be injected")]
		public void Arguments_can_be_injected()
		{
			var lastArg = new Argument(0, "test", new SafeValue<int>(17));
			var args = new Arguments();
			args.Add(lastArg);

			IValue arg = _provider.Evaluate(null, args, "test - 22");
			Assert.AreEqual(-5, arg.UntypedValue);
		}

		[Test]
		[Description("Exceptions are raised later")]
		public void Exceptions_are_raised_later()
		{
			IValue lastArg = _provider.Evaluate(new LineContext(0, "first"), new Arguments(), @"test_ - 22");
			var args = new Arguments();
			args.Add(new Argument(0, "test", lastArg));

			IValue arg = _provider.Evaluate(new LineContext(1, "second"), args, @"test_ - 22");
			Assert.IsTrue(arg.HasError);
		}

		[Test]
		[Description("Error free removes errors")]
		public void Error_free_removes_errors()
		{
			IValue lastArg = _provider.Evaluate(new LineContext(0, "first"), new Arguments(), @"test_ - 22");
			var args = new Arguments();
			args.Add(new Argument(0, "test", lastArg));

			IValue arg = _provider.Evaluate(new LineContext(1, "second"), args, @"ErrorFree(test_, 1) - 22");
			Assert.AreEqual(-21, arg.UntypedValue);
		}

		[Test]
		[Description("Convert from string to int fails")]
		public void Convert_from_string_to_int_fails()
		{
			IValue lastArg = _provider.Evaluate(new LineContext(0, "first"), new Arguments(), @"""Hello""");
			var args = new Arguments();
			args.Add(new Argument(0, "test", lastArg));

			IValue arg = _provider.Evaluate(new LineContext(1, "second"), args, @"Convert<int>(test_) - 22");

			object x = null;
			var exception = Assert.Throws<VariableHasErrorException>(() => x = arg.UntypedValue);

			Assert.IsTrue(exception.InnerException is TypeConversionException);
		}

		[Test]
		[Description("Convert a value with error reports VariableHasErrorException")]
		public void Convert_a_value_with_error_reports_VariableHasErrorException()
		{
			IValue lastArg = _provider.Evaluate(new LineContext(0, "first"), new Arguments(), @"""Hello""");
			var args = new Arguments();
			args.Add(new Argument(0, "test", lastArg));

			IValue arg = _provider.Evaluate(new LineContext(1, "second"), args, @"Convert<int>(test_) - 22");

			object x = null;
			Assert.Throws<VariableHasErrorException>(() => x = arg.UntypedValue);
		}
	}
}