using System;

namespace CommonServiceLocator.StructureMapAdapter.Unofficial.Tests
{
    public class SimpleLogger : ILogger
	{
		public void Log(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}