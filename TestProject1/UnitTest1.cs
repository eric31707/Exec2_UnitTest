using Ispan.Utilities;

namespace TestProject1
{
	public class Tests
	{
		[Test]
		public void IsTradingTime�P�_�O���O�����()
		{
			var obj = new TaiwainStockUtility();
			bool actual = obj.IsTradingTime(DateTime.Now);
			bool expected = true;
			Assert.AreEqual(expected, actual);
		}
	}
}