using System;

namespace Data
{
	namespace Sql
	{
		public class SqlDataAccess
		{
			public string GetData()
			{
				return "from sql server";
			}
		}
	}
	namespace Oracle
	{
		public class OracleDataAccess
		{
			public string GetData()
			{
				return "from oracle server";
			}
		}
	}
}








