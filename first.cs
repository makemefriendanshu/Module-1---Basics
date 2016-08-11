using System;

//use the namespace to access class
using Data.Sql;

namespace Siemens
{
	class Sample
	{
		static void Main(string[] args)
		{
			Console.WriteLine("welcome to CSharp");
			
			//create instance of SqlDataAccess
			SqlDataAccess sd = new SqlDataAccess();

			//call GetData method on the instance
			string output = sd.GetData();

			//disply method return value
			Console.WriteLine(output);			
		}
	}
}