using System;//mscorlib.dll
//to access "Simple" class inside "Test" namespace from //"TestApp.dll"
using Test;

namespace TestExecutable
{
	public class SimpleExecutable
	{
		static void Main()
		{
			Simple simpleObj = new Simple();
			string output = 
				simpleObj.SayHello("Joydip");
			Console.WriteLine(output);
		}
	}
}