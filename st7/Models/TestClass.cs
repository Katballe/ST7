using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace st7.Models
{
	public class TestClass
	{
		public int Id { get; set; }
		public string Value { get; set; }

		public TestClass(int id, string value)
		{
			Id = id;
			Value = value;
		}
	}
}
