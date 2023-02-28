namespace TestModule;

public interface IUnitTestMock
{
	public int Returns0();
}

public class UnitTestMockFails : IUnitTestMock
{
	public int Returns0() => 1;
}

public class UnitTestMockSuccess : IUnitTestMock
{
}
