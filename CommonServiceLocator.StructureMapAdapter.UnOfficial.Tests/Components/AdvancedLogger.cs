using System;

namespace CommonServiceLocator.StructureMapAdapter.Unofficial.Tests
{
    public class AdvancedLogger : ILogger
	{
		public void Log(string msg)
		{
			Console.WriteLine("Log: {0}", msg);
		}
	}
}