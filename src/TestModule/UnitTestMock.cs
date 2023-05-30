namespace TestModule;

public interface IUnitTestMock
{
	public int Returns0();
}

public class UnitTestMockFails : IUnitTestMock
{
	public int Returns0() => 1;
	
	public static void Main(string[] args)
	{
		var a = Mod(1,2);
	}
}

public class UnitTestMockSuccess : IUnitTestMock
{
	public int Returns0() => 0;
}
