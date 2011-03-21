using System;
using System.Threading;
using NUnit.Framework;
using RomanNumerals;

namespace AcceptanceTests
{
	[TestFixture]
	public class AcceptanceTests
	{
		private const int IndividualTestExecutionTimeInMilliseconds = 3000;
		private const int DeploymentTimeInMilliseconds = 15000;
		private const int CoordinationTimeInMilliseconds = 15000;

		[TestFixtureSetUp]
		public void SetUpFixture()
		{
			Console.Out.WriteLine("Deploying to QA...");
			Thread.Sleep(DeploymentTimeInMilliseconds);
			Console.Out.WriteLine("QA Team is coordinating and updating their test plans...");
			Thread.Sleep(CoordinationTimeInMilliseconds);
			Console.Out.WriteLine("QA Team is starting their tests...");
		}

		[TestCase(1, "I")]
		[TestCase(2, "II")]
		[TestCase(3, "III")]
		[TestCase(4, "IV")]
		[TestCase(5, "V")]
		[TestCase(6, "VI")]
		[TestCase(9, "IX")]
		[TestCase(10, "X")]
		[TestCase(11, "XI")]
		[TestCase(14, "XIV")]
		[TestCase(15, "XV")]
		[TestCase(19, "XIX")]
		[TestCase(20, "XX")]
		[TestCase(40, "XL")]
		[TestCase(49, "XLIX")]
		[TestCase(50, "L")]
		[TestCase(51, "LI")]
		[TestCase(90, "XC")]
		[TestCase(99, "XCIX")]
		[TestCase(100, "C")]
		[TestCase(101, "CI")]
		[TestCase(400, "CD")]
		[TestCase(499, "CDXCIX")]
		[TestCase(500, "D")]
		[TestCase(501, "DI")]
		[TestCase(900, "CM")]
		[TestCase(999, "CMXCIX")]
		[TestCase(1000, "M")]
		[TestCase(1001, "MI")]
		[TestCase(4999, "MMMMCMXCIX")]
		public void TestRomanNumberals(int number, string roman)
		{
			Console.Out.WriteLine("QA is testing that {0} gets converted to {1}...", number, roman);
			Thread.Sleep(IndividualTestExecutionTimeInMilliseconds);
			Assert.AreEqual(roman, new RomanNumeralConverter().Convert(number));
		}
	}
}