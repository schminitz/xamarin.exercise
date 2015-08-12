using System;
using NUnit.Framework;
using exercise2;

namespace exercise2ios.unittests
{
	[TestFixture]
	public class ExerciseTests
	{
		ExerciseMain instance;

		[SetUp]
		public void Setup ()
		{
			instance = new ExerciseMain();
		}

		[TearDown]
		public void Tear ()
		{
			instance = null;
		}

		[Test]
		public void ExerciseTests01 ()
		{
			Assert.AreEqual (instance.ReturnTwo(), 2);
		}

		[Test]
		public void ExerciseTests02 ()
		{
			Assert.AreEqual (instance.ReturnTwo(), 1);
		}


	}
}

