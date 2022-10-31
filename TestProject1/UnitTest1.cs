using Ispan.Utilities;

namespace TestProject1
{
	public class Tests
	{
		[Test]
		public void IsTradingTime判斷是不是交易日()
		{
			var obj = new TaiwainStockUtility();
			bool actual = obj.IsTradingTime(DateTime.Now);
			bool expected = true;
			Assert.AreEqual(expected, actual);
		}
	}
}