using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineProcessor.Providers;
using NUnit.Framework;

namespace LineProcessor
{
	internal class LineProcessorTests
	{
		private Processor _processor;

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		[Description("Processor works")]
		public void Processor_works()
		{
			_processor = new Processor(new CSharpProvider(),
			                               new LineExpression[]
				                               {
					                               new LineExpression("lineLength", "line.Length"),
					                               new LineExpression("firstComma", "line.IndexOf(\",\")"),
					                               new LineExpression("diff", "lineLength - firstComma"),
				                               });

			Arguments args = _processor.Parse("This is the argument list, isn't it nice?");

			Assert.AreEqual(41, args.FindByName("lineLength").ArgumentValue.UntypedValue);
			Assert.AreEqual(25, args.FindByName("firstComma").ArgumentValue.UntypedValue);
			Assert.AreEqual(41 - 25, args.FindByName("diff").ArgumentValue.UntypedValue);
		}
	}
}