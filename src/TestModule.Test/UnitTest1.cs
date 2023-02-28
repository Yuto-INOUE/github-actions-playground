namespace TestModule.Test;

[TestClass]
public class UnitTest1
{
	[TestMethod]
	public void TestMethod1()
	{
		Assert.Equals(new UnitTestMockSuccess().Returns0(), 0);
		Assert.Equals(new UnitTestMockFails().Returns0(), 0);
	}
}
